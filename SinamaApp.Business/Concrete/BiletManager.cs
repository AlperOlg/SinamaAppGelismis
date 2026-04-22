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
    public class BiletManager : GenericManager<Bilet>, IBiletService
    {
        private readonly IBiletDAL _biletDAL;
        public BiletManager(IBiletDAL biletDAL) : base(biletDAL)
        {
            _biletDAL = biletDAL;
        }

        public async Task TBiletSatAsync(Bilet bilet)
        {
            // Business Logic: Check if the seat is already taken for this session
            var existingBilet = await _biletDAL.BirTaneGetirAsync(b => b.SeansID == bilet.SeansID && b.KoltukID == bilet.KoltukID);
            
            if (existingBilet != null)
            {
                throw new Exception("Bu koltuk bu seans için zaten rezerve edilmiş!");
            }

            await _biletDAL.EkleAsync(bilet);
        }

        public async Task<List<Bilet>> TSeansaGoreBiletleriGetirAsync(int seansID)
        {
            return await _biletDAL.HepsiniGetirAsync(b => b.SeansID == seansID);
        }
    }
}
