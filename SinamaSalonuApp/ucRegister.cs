using Guna.UI2.WinForms;
using SinamaApp.Business.Abstract;
using SinamaApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinamaSalonuApp
{
    public partial class ucRegister : UserControl
    {
        private readonly IKullaniciService _kullaniciService;

        public event EventHandler RegistrationSuccessful;

        public ucRegister(IKullaniciService kullaniciService)
        {
            InitializeComponent();
            _kullaniciService = kullaniciService;
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtLastName.Text) ||
                    string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }
                if(dtpBirthDate.Value > DateTime.Now)
                {
                    MessageBox.Show("Geçerli doğum tarihi girin");
                    return;
                }
                else if (Convert.ToInt32(DateTime.Today.Year - dtpBirthDate.Value.Year) < 18)
                {
                    MessageBox.Show("Kayıt olabilmek için 18 yaşıdnan büyük olmalısınız");
                    return;
                }
                Kullanici newUser = new Kullanici
                    {
                        Ad = txtFirstName.Text,
                        Soyad = txtLastName.Text,
                        KullaniciAdi = txtUsername.Text,
                        Sifre = txtPassword.Text,
                        DogumTarihi = dtpBirthDate.Value
                    };

                await _kullaniciService.TKullaniciKayitOlAsync(newUser);
                MessageBox.Show("Kayıt işlemi başarıyla tamamlandı. Şimdi giriş yapabilirsiniz.");
                RegistrationSuccessful?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                lblPasswordWarning.Visible = true;
                lblPasswordWarning.Text = ex.Message;
            }
        }
    }
}
