using SinamaApp.Entities.Concrete.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Kullanici : Insan
    {
        public string KullaniciAdi{ get; set; }
        public string Sifre { get; set; }
    }
}
