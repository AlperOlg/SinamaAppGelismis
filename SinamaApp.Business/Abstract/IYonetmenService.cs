using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface IYonetmenService : IGenericService<Yonetmen>
    {
        Task<Yonetmen> TYonetmenGetirAdAsync(Expression<Func<Yonetmen, bool>> filter);
        Task<List<Film>> TYonetmeninFilmleriniGetirAsync(int yonetmenID);
    }
}
