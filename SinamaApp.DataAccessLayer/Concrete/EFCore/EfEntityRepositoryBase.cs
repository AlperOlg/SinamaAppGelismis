using Microsoft.EntityFrameworkCore;
using SinamaApp.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Concrete.EFCore
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity>
        where TEntity : class, new()
    {
        protected readonly IDbContextFactory<SinamaAppDbContext> _contextFactory;
        public EfEntityRepositoryBase(IDbContextFactory<SinamaAppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<TEntity?> BirTaneGetirAsync(Expression<Func<TEntity, bool>> filter)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(filter);
        }

        public async Task EkleAsync(TEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            await context.Set<TEntity>().AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task GuncelleAsync(TEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<TEntity>().Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> HepsiniGetirAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using var context = _contextFactory.CreateDbContext();
            IQueryable<TEntity> query = context.Set<TEntity>().AsNoTracking();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            return await query.ToListAsync();
        }

        public async Task SilAsync(TEntity entity)
        {
            using var context = _contextFactory.CreateDbContext();
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }
    }
}
