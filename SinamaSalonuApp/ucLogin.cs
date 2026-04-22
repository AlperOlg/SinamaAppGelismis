using Guna.UI2.WinForms;
using SinamaApp.Business.Abstract;
using SinamaApp.Entities.Concrete;
using SinamaSalonuApp.Helpers;
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
    public partial class ucLogin : UserControl
    {
        private readonly IKullaniciService _kullaniciService;

        public event EventHandler<Kullanici> LoginSuccessful;

        public ucLogin(IKullaniciService kullaniciService)
        {
            InitializeComponent();
            _kullaniciService = kullaniciService;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
                {
                    MessageBox.Show("Lütfen tüm alanları doldurun.");
                    return;
                }

                var user = await _kullaniciService.TKullaniciGirisYapAsync(txtUsername.Text, txtPassword.Text);
                
                if (cbRememberMe.Checked)
                {
                    SettingsHelper.SaveRememberMe(user.ID);
                }
                else
                {
                    SettingsHelper.ClearRememberMe();
                }

                MessageBox.Show($"Hoş geldiniz, {user.Ad} {user.Soyad}!");
                LoginSuccessful?.Invoke(this, user);
            }
            catch (Exception ex)
            {
                lblWarning.Visible = true ;
                lblWarning.Text = ex.Message;
            }
        }
    }
}
