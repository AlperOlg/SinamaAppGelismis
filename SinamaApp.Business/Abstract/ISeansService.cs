using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface ISeansService : IGenericService<Seans>
    {
        Task<List<Seans>> TSeanslariGetirDetayliAsync(Expression<Func<Seans, bool>> filter = null);
    }
}
