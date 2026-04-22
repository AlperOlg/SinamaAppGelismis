using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Abstract
{
    public interface IKullaniciService : IGenericService<Kullanici>
    {
        Task<Kullanici> TKullaniciGirisYapAsync(string kullaniciAdi, string sifre);
        Task TKullaniciKayitOlAsync(Kullanici kullanici);
    }
}
