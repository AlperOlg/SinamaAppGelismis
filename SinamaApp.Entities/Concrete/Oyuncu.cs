using SinamaApp.Entities.Concrete.BaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Oyuncu : Insan
    {
        public ICollection<Film> Filmler { get; set; }
    }
}
