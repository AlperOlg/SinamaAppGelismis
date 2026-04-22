using SinamaApp.Business.Abstract;
using SinamaApp.DataAccessLayer.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinamaApp.Business.Concrete
{
    public class KullaniciManager : GenericManager<Kullanici>, IKullaniciService
    {
        private readonly IKullaniciDAL _kullaniciDAL;
        public KullaniciManager(IKullaniciDAL kullaniciDAL) : base(kullaniciDAL)
        {
            _kullaniciDAL = kullaniciDAL;
        }

        public async Task<Kullanici> TKullaniciGirisYapAsync(string kullaniciAdi, string sifre)
        {
            // Fetch user by username only
            var kullanici = await _kullaniciDAL.BirTaneGetirAsync(k => k.KullaniciAdi == kullaniciAdi);
            
            if (kullanici == null)
            {
                throw new Exception("Kullanıcı bulunamadı!");
            }

            // Verify the provided password against the stored BCrypt hash
            bool isPasswordCorrect = BCrypt.Net.BCrypt.Verify(sifre, kullanici.Sifre);
            
            if (!isPasswordCorrect)
            {
                throw new Exception("Hatalı şifre!");
            }
            
            return kullanici;
        }

        public async Task TKullaniciKayitOlAsync(Kullanici kullanici)
        {
            var existingUser = await _kullaniciDAL.BirTaneGetirAsync(k => k.KullaniciAdi == kullanici.KullaniciAdi);
            if (existingUser != null)
            {
                throw new Exception("Bu kullanıcı adı zaten alınmış!");
            }

            // Password validation: minimum 8 characters
            if (string.IsNullOrEmpty(kullanici.Sifre) || kullanici.Sifre.Length < 8)
            {
                throw new Exception("Şifre en az 8 karakter olmalıdır!");
            }

            // Password validation: at least one uppercase letter
            if (!kullanici.Sifre.Any(char.IsUpper))
            {
                throw new Exception("Şifre en az bir büyük harf içermelidir!");
            }

            // Hash the password before saving
            kullanici.Sifre = BCrypt.Net.BCrypt.HashPassword(kullanici.Sifre);

            await _kullaniciDAL.EkleAsync(kullanici);
        }
    }
}
