using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.DataAccessLayer.Concrete.EFCore;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class FilmManager : GenericManager<Film>, IFilmService
    {
        private readonly IFilmDAL _filmDAL;
        public FilmManager(IFilmDAL filmDAL) : base(filmDAL) 
        {
            _filmDAL = filmDAL;
        }
        public async Task<List<Film>> TFilmleriGetirKategoriAsync(Expression<Func<Film, bool>> filter)
        {
            List<Film> filmler = await _filmDAL.FilmleriGetirKategoriAsync(filter);
            if (filmler.Count <= 0) { throw new Exception("TFilmleriGetirKategoriAsync Metotundan Hiçbir Değer Gelmedi"); }
            return filmler;
        }

        public async Task<List<Film>> TFilmleriGetirYonetmenAdAsync(Expression<Func<Film, bool>> filter)
        {
            List<Film> filmler = await _filmDAL.FilmleriGetirYonetmenAdAsync(filter);
            if(filmler.Count <= 0) { throw new Exception("TFilmleriGetirYonetmenAdAsync Metotundan Hiçbir Değer Gelmedi"); }
            return filmler;
        }
    }
}
