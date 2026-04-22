using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface IGenericService<T>
    {
        public Task<List<T>> THepsiniGetirAsync(Expression<Func<T, bool>> filter = null);
        public Task<T> TBirTaneGetirAsync(Expression<Func<T, bool>> filter);
        public Task TSilAsync(T entity);
        public Task TEkleAsync(T entity);
        public Task TGuncelleAsync(T entity);
    }
}
