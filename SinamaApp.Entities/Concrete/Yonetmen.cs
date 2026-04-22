using SinamaApp.Entities.Concrete.BaseClass;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Entities.Concrete
{
    public class Yonetmen : Insan
    {
        public string? Bio { get; set; }
        public ICollection<Film> Filmler { get; set; }
    }
}
