using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface IBiletService : IGenericService<Bilet>
    {
        Task TBiletSatAsync(Bilet bilet);
        Task<List<Bilet>> TSeansaGoreBiletleriGetirAsync(int seansID);
    }
}
