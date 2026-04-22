using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Bilet
    {
        public int ID { get; set; }
        public int KullaniciID { get; set; }
        public int SeansID { get; set; }
        public int KoltukID { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime SatinAlmaTarihi { get; set; }
        public enum Durum
        {
            Aktif,
            IptalEdildi
        }
        public Durum BiletDurumu { get; set; }
        public Koltuk Koltuk { get; set; }
        public Kullanici Kullanici { get; set; }
        public Seans Seans { get; set; }
    }
}
