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
    public partial class ucActorAdd : UserControl
    {
        private readonly IOyuncuService _oyuncuService;
        public ucActorAdd(IOyuncuService oyuncuService)
        {
            InitializeComponent();
            _oyuncuService = oyuncuService;
        }
        private void ClearInputs()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            { MessageBox.Show("Eklenecek oyuncunun ad ve soyad bilgileri boş olamaz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            if (dtpBirthDate.Value > DateTime.Today /*|| (DateTime.Today.Year - dtpBirthDate.Value.Year) < 18 */) //18 yaşından küçük kişiler filmlerde oynayabilir
            {
                MessageBox.Show("Doğum tarihi girşini düzgün yapın", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                Oyuncu oyuncu = new()
                {
                    Ad = txtName.Text,
                    Soyad = txtSurname.Text,
                    DogumTarihi = dtpBirthDate.Value
                };
                await _oyuncuService.TEkleAsync(oyuncu);
                MessageBox.Show($"{oyuncu.Ad} {oyuncu.Soyad} adlı oyuncu başarıyla kayıt edildi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu" + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputs();
            }
        }
    }
}
