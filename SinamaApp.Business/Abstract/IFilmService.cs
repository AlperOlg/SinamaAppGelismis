using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface IFilmService : IGenericService<Film>
    {
        public Task<List<Film>> TFilmleriGetirYonetmenAdAsync(Expression<Func<Film, bool>> filter);
        public Task<List<Film>> TFilmleriGetirKategoriAsync(Expression<Func<Film, bool>> filter);
    }
}
