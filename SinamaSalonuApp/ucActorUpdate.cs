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
    public partial class ucActorUpdate : UserControl
    {
        private readonly IOyuncuService _oyuncuService;
        private Oyuncu _guncellenecekOyuncu;
        public ucActorUpdate(IOyuncuService oyuncuService)
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
        private async void ucActorUpdate_Load(object sender, EventArgs e)
        {
            await VerileriYukle();
        }

        private async void cbSelectActor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectActor.SelectedValue == null) { return; }
            try
            {
                int oyuncuID = (int)cbSelectActor.SelectedValue;
                Oyuncu guncellenecekOyuncu = await _oyuncuService.TBirTaneGetirAsync(o => o.ID == oyuncuID);
                _guncellenecekOyuncu = guncellenecekOyuncu;
                txtName.Text = _guncellenecekOyuncu.Ad;
                txtSurname.Text = _guncellenecekOyuncu.Soyad;
                dtpBirthDate.Value = _guncellenecekOyuncu.DogumTarihi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_guncellenecekOyuncu == null) { return; }

            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            { MessageBox.Show("Güncelleme için boş bilgi bırakmayın", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            if (dtpBirthDate.Value > DateTime.Today)
            { MessageBox.Show("Doğum tarihi girşini düzgün yapın", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }

            try
            {
                Oyuncu oyuncu = new()
                {
                    ID = _guncellenecekOyuncu.ID,
                    Ad = txtName.Text,
                    Soyad = txtSurname.Text,
                    DogumTarihi = dtpBirthDate.Value
                };
                await _oyuncuService.TGuncelleAsync(oyuncu);
                MessageBox.Show("Oyuncu başarıyla güncellendi", "başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message, "hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
