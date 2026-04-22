using Microsoft.EntityFrameworkCore;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Concrete.EFCore
{
    public class EfSalonDAL : EfEntityRepositoryBase<Salon>, ISalonDAL
    {
        public EfSalonDAL(IDbContextFactory<SinamaAppDbContext> contextFactory) : base(contextFactory)
        {
        }

        public async Task<Salon> SalonGetirKoltuklarlaAsync(int salonID)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.Salonlar.Include(s => s.Koltuklar).FirstOrDefaultAsync(s => s.ID == salonID);
        }
    }
}
