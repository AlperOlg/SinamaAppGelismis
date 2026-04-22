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
    public class EfSeansDAL : EfEntityRepositoryBase<Seans>, ISeansDAL
    {
        public EfSeansDAL(IDbContextFactory<SinamaAppDbContext> contextFactory) : base(contextFactory)
        {
        }

        public async Task<List<Seans>> SeanslariGetirDetayliAsync(Expression<Func<Seans, bool>> filter = null)
        {
            using var context = _contextFactory.CreateDbContext();
            IQueryable<Seans> query = context.Seanslar.Include(s => s.Film).Include(s => s.Salon);
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }
    }
}
