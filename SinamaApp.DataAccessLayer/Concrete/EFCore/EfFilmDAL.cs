using Microsoft.EntityFrameworkCore;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Concrete.EFCore
{
    public class EfFilmDAL : EfEntityRepositoryBase<Film>, IFilmDAL
    {
        public EfFilmDAL(IDbContextFactory<SinamaAppDbContext> contextFactory) : base(contextFactory)
        {
        }

        public async Task<List<Film>> FilmleriGetirKategoriAsync(Expression<Func<Film, bool>> filter)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Filmler.Include(f => f.Kategori).Where(filter).ToListAsync();
        }

        public async Task<List<Film>> FilmleriGetirYonetmenAdAsync(Expression<Func<Film, bool>> filter)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Filmler.Include(f => f.Yonetmen).Where(filter).ToListAsync();
        }
    }
}
