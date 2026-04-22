using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Koltuk
    {
        public int ID { get; set; }
        public int Numara { get; set; }
        public string Satir { get; set; }
        public int SalonID { get; set; }
        public Salon Salon { get; set; }
    }
}
