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
    public partial class ucActorDelete : UserControl
    {
        private readonly IOyuncuService _oyuncuService;
        private Oyuncu? _silinecekOyuncu;
        public ucActorDelete(IOyuncuService oyuncuService)
        {
            InitializeComponent();
            _oyuncuService = oyuncuService;
        }
        public async Task VerileriYukle()
        {
            List<Oyuncu> oyuncular = await _oyuncuService.THepsiniGetirAsync();
            cbSelectActor.DisplayMember = "AdSoyad";
            cbSelectActor.ValueMember = "ID";
            cbSelectActor.DataSource = oyuncular.Select(o => new { ID = o.ID, AdSoyad = (o.Ad + " " + o.Soyad) }).ToList();
        }
        private async void ucActorDelete_Load(object sender, EventArgs e)
        {
            await VerileriYukle();
        }

        private async void cbSelectActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectActor.SelectedValue == null) { return; }
            try
            {
                int oyuncuID = (int)cbSelectActor.SelectedValue;
                Oyuncu silinecekOyuncu = await _oyuncuService.TBirTaneGetirAsync(o => o.ID == oyuncuID);
                _silinecekOyuncu = silinecekOyuncu;
                txtName.Text = silinecekOyuncu.Ad;
                txtSurname.Text = silinecekOyuncu.Soyad;
                dtpBirthDate.Value = silinecekOyuncu.DogumTarihi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (_silinecekOyuncu == null)
            {
                MessageBox.Show("Silinecek Oyuncuyu seçin", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnDelete.Enabled = false;

                await _oyuncuService.TSilAsync(_silinecekOyuncu);
                MessageBox.Show($"{_silinecekOyuncu.Ad} {_silinecekOyuncu.Soyad} adlı oyuncu başarıyla silindi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _silinecekOyuncu = null;
                await VerileriYukle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnDelete.Enabled = true;
            }
        }
    }
}
