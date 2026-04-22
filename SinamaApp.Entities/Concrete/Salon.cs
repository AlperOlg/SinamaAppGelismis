using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Salon
    {
        public int ID{ get; set; }
        public int SalonNo{ get; set; }
        public ICollection<Seans> Seanslar { get; set; }
        public ICollection<Koltuk> Koltuklar { get; set; }
    }
}
