using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
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
    public class EfYonetmenDAL : EfEntityRepositoryBase<Yonetmen>, IYonetmenDAL
    {
        public EfYonetmenDAL(IDbContextFactory<SinamaAppDbContext> contextFactory) : base(contextFactory)
        {
        }
        public async Task<Yonetmen> YonetmenGetirAdAsync(Expression<Func<Yonetmen, bool>> filter)
        {
            using var context = _contextFactory.CreateDbContext();
            Yonetmen? yonetmen = await context.Yonetmenler.FirstOrDefaultAsync(filter);
            return yonetmen;
        }
        public async Task<List<Film>> YonetmeninFilmleriniGetirAsync(int yonetmenID = -1, string? yonetmenAdSoyad = null)
        {
            using var context = _contextFactory.CreateDbContext();
            if (yonetmenID > 0)
            {
                List<Film> filmler = await context.Filmler.Where(y => y.YonetmenID == yonetmenID).ToListAsync();
                return filmler;
            }
            else if(!string.IsNullOrWhiteSpace(yonetmenAdSoyad))
            {
                List<Film> filmler = await context.Filmler.Include(y => y.Yonetmen).Where(y => (y.Yonetmen.Ad + " " + y.Yonetmen.Soyad) == yonetmenAdSoyad).ToListAsync();
                return filmler;
            }
            else
            {
                throw new Exception("Id veya AdSoyad girilmeli");
            }
        }
    }
}
