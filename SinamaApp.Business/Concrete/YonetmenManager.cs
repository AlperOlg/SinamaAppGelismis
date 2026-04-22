using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class YonetmenManager : GenericManager<Yonetmen>, IYonetmenService
    {
        private readonly IYonetmenDAL _yonetmenDAL;
        public YonetmenManager(IYonetmenDAL yonetmenDAL) : base(yonetmenDAL)
        {
            _yonetmenDAL = yonetmenDAL;
        }
        public async Task<Yonetmen> TYonetmenGetirAdAsync(Expression<Func<Yonetmen, bool>> filter)
        {
            Yonetmen yonetmen = await _yonetmenDAL.YonetmenGetirAdAsync(filter);
            if(yonetmen == null) { throw new Exception("Yonetmen Yok"); }
            return yonetmen;
        }

        public Task<List<Film>> TYonetmeninFilmleriniGetirAsync(int yonetmenID)
        {
            throw new NotImplementedException();
        }
    }
}
