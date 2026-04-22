using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.DataAccessLayer.Abstract
{
    public interface IFilmDAL : IEntityRepository<Film>
    {
        public Task<List<Film>> FilmleriGetirYonetmenAdAsync(Expression<Func<Film, bool>> filter);
        public Task<List<Film>> FilmleriGetirKategoriAsync(Expression<Func<Film, bool>> filter);
    }
}
