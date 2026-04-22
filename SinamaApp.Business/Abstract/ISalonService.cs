using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface ISalonService : IGenericService<Salon>
    {
        Task<Salon> TSalonGetirKoltuklarlaAsync(int salonID);
    }
}
