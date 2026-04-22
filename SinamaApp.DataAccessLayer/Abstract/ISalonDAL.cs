using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Abstract
{
    public interface ISalonDAL : IEntityRepository<Salon>
    {
        Task<Salon> SalonGetirKoltuklarlaAsync(int salonID);
    }
}
