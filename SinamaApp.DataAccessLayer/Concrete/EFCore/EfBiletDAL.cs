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
    public class EfBiletDAL : EfEntityRepositoryBase<Bilet>, IBiletDAL
    {
        public EfBiletDAL(IDbContextFactory<SinamaAppDbContext> contextFactory) : base(contextFactory)
        {
        }
    }
}
