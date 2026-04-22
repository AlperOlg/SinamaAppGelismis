using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class OyuncuManager : GenericManager<Oyuncu>, IOyuncuService
    {
        public OyuncuManager(IOyuncuDAL oyuncuDAL) : base(oyuncuDAL)
        {
        }
    }
}
