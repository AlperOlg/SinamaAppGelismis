using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Kategori
    {
        public int ID { get; set; }
        public string KategoriAdi { get; set; }
        public string? Aciklama { get; set; } 
        public ICollection<Film> Filmler { get; set; }
    }
}
