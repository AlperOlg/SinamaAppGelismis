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
    public partial class ucDirectorAdd : UserControl
    {
        private readonly IYonetmenService _yonetmenService;
        public ucDirectorAdd(IYonetmenService yonetmenService)
        {
            InitializeComponent();
            _yonetmenService = yonetmenService;
        }

        private void ucDirectorAdd_Load(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void ClearInputs()
        {
            txtBio.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string? bio = null;
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            { MessageBox.Show("Yönetmen Kayıdı için boş bilgi bırakılamaz", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if ((DateTime.Today.Year - dtpBirthDate.Value.Year) < 18)
            { MessageBox.Show("18 yaşından büyük olmalı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (!string.IsNullOrWhiteSpace(txtBio.Text)) 
            { bio = txtBio.Text; }

            try
            {
                btnAdd.Enabled = false;
                this.Cursor = Cursors.WaitCursor;

                Yonetmen eklenecekYonetmen = new()
                {
                    Ad = txtName.Text,
                    Soyad = txtSurname.Text,
                    DogumTarihi = dtpBirthDate.Value,
                    Bio = bio
                };
                await _yonetmenService.TEkleAsync(eklenecekYonetmen);
                MessageBox.Show($"{eklenecekYonetmen.Ad} {eklenecekYonetmen.Soyad} adlı yönetmen başarıyla kayıt edildi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("beklenmedik bir hata oluştu: " + ex.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                btnAdd.Enabled = true;
                this.Cursor = Cursors.Default;

            }
        }
    }
}
