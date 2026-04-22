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
    public class SalonManager : GenericManager<Salon>, ISalonService
    {
        private readonly ISalonDAL _salonDAL;
        public SalonManager(ISalonDAL salonDAL) : base(salonDAL)
        {
            _salonDAL = salonDAL;
        }

        public async Task<Salon> TSalonGetirKoltuklarlaAsync(int salonID)
        {
            return await _salonDAL.SalonGetirKoltuklarlaAsync(salonID);
        }
    }
}
