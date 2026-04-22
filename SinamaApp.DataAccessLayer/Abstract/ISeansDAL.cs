using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Abstract
{
    public interface ISeansDAL : IEntityRepository<Seans>
    {
        Task<List<Seans>> SeanslariGetirDetayliAsync(Expression<Func<Seans, bool>> filter = null);
    }
}
