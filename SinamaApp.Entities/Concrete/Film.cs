using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{    public class Film
    {
        public int ID { get; set; }
        public string FilmAd { get; set; }

        public int FilmYili { get; set; }
        public int KategoriID { get; set; }
        public int YonetmenID { get; set; }
        public int BasRolOyuncuID { get; set;  }
        public Oyuncu BasRolOyuncu { get; set; }
        public ICollection<Oyuncu> Oyuncular { get; set; }

        public Kategori Kategori { get; set; }
        public Yonetmen Yonetmen { get; set; }
    }
}

