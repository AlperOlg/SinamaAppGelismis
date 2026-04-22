using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Abstract
{
    public interface IYonetmenDAL : IEntityRepository<Yonetmen>
    {
        Task<Yonetmen> YonetmenGetirAdAsync(Expression<Func<Yonetmen,bool>> filter);
        Task<List<Film>> YonetmeninFilmleriniGetirAsync(int yonetmenID = -1, string? yonetmenAdSoyad = null);
    }
}
