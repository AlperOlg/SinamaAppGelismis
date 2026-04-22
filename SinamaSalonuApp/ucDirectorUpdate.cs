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
    public partial class ucDirectorUpdate : UserControl
    {
        private IYonetmenService _yonetmenService;
        private Yonetmen? guncellenecekYonetmen = null;
        public ucDirectorUpdate(IYonetmenService yonetmenService)
        {
            InitializeComponent();
            _yonetmenService = yonetmenService;
        }
        public async Task VerileriYukle()
        {
            List<Yonetmen> yonetmen = await _yonetmenService.THepsiniGetirAsync();
            cbSelectDirector.ValueMember = "ID";
            cbSelectDirector.DisplayMember = "AdSoyad";
            cbSelectDirector.DataSource = yonetmen.Select(y => new { ID = y.ID, AdSoyad = y.Ad + " " + y.Soyad }).ToList();
        }
        private void Temizle()
        {
            txtName.Text = string.Empty;
            txtSurname.Text = string.Empty;
            txtBio.Text = string.Empty;
            dtpBirthDate.Value = DateTime.Now;
        }
        private async void ucDirectorUpdate_Load(object sender, EventArgs e)
        {
            await VerileriYukle();
        }

        private async void cbSelectDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectDirector.SelectedValue == null || !(cbSelectDirector.SelectedValue is int yonetmenID)) { return; }
            try
            {
                guncellenecekYonetmen = await _yonetmenService.TBirTaneGetirAsync(y=>y.ID == yonetmenID);
                txtName.Text = guncellenecekYonetmen.Ad;
                txtSurname.Text = guncellenecekYonetmen.Soyad;
                txtBio.Text = guncellenecekYonetmen.Bio;
                dtpBirthDate.Value = guncellenecekYonetmen.DogumTarihi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnGuncelle_Click(object sender, EventArgs e)
        {
            string? bio = null;
            
            if(guncellenecekYonetmen == null)
            { MessageBox.Show("Güncelleme için yönetmeni seçin", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (cbSelectDirector.SelectedValue == null || !(cbSelectDirector.SelectedValue is int yonetmenID)) { return; }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            { MessageBox.Show("Güncelleme için boş bilgi bırakmayın", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if ((DateTime.Today.Year - dtpBirthDate.Value.Year) < 18)
            { MessageBox.Show("Doğum tarihi 18den yüksek olmalı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (!string.IsNullOrWhiteSpace(txtBio.Text))
            { bio = txtBio.Text; }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnGuncelle.Enabled = false;

                guncellenecekYonetmen.Ad = txtName.Text;
                guncellenecekYonetmen.Soyad = txtSurname.Text;
                guncellenecekYonetmen.DogumTarihi = dtpBirthDate.Value;
                guncellenecekYonetmen.Bio = bio;
                await _yonetmenService.TGuncelleAsync(guncellenecekYonetmen);
                MessageBox.Show("Yönetmen başarıyla güncellendi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Temizle();
                await VerileriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnGuncelle.Enabled = true;
            }
        }
    }
}
