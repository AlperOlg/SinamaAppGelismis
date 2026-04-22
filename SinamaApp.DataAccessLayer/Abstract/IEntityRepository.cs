using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Abstract
{
    public interface IEntityRepository<T>
    {
        public Task<List<T>> HepsiniGetirAsync(Expression<Func<T, bool>> filter = null);
        public Task<T> BirTaneGetirAsync(Expression<Func<T, bool>> filter);
        public Task SilAsync(T entity);
        public Task EkleAsync(T entity);
        public Task GuncelleAsync(T entity);
    }
}
