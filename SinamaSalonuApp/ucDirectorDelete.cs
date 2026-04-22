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
    public partial class ucDirectorDelete : UserControl
    {
        private readonly IYonetmenService _yonetmenService;
        public ucDirectorDelete(IYonetmenService yonetmenService)
        {
            InitializeComponent();
            _yonetmenService = yonetmenService;
        }
        public async Task VerileriYukle()
        {
            List<Yonetmen> yonetmenler = await _yonetmenService.THepsiniGetirAsync();
            cbSelectDirector.DisplayMember = "AdSoyad";
            cbSelectDirector.ValueMember = "ID";
            cbSelectDirector.DataSource = yonetmenler.Select(y => new { ID = y.ID, AdSoyad = y.Ad + " " + y.Soyad }).ToList();
        }

        private void cbSelectDirector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {

            if (cbSelectDirector.SelectedValue == null) { MessageBox.Show("Silinecek yönetmeni seçin", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnDelete.Enabled = false;

                int yonetmenID = (int)cbSelectDirector.SelectedValue;
                Yonetmen yonetmen = await _yonetmenService.TBirTaneGetirAsync(y=>y.ID == yonetmenID);
                await _yonetmenService.TSilAsync(yonetmen);
                MessageBox.Show($"{yonetmen.Ad} {yonetmen.Soyad} adlı yönetmen başarıyla silindi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await VerileriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("beklenmedik bir hata oluştu: " + ex.Message, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnDelete.Enabled = true;
            }
        }
    }
}
