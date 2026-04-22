using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Seans
    {
        public int ID { get; set; }
        public DateTime SeansSaati { get; set; }
        public int FilmID { get; set; }
        public int SalonID { get; set; }
        public decimal Fiyat { get; set; }
        public Film Film { get; set; }
        public Salon Salon { get; set; }
    }
}
