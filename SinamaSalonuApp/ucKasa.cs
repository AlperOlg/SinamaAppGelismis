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
    public partial class ucKasa : UserControl
    {
        private readonly IBiletService _biletService;
        private Seans _selectedSeans;
        private List<Koltuk> _selectedKoltuklar;

        public ucKasa(IBiletService biletService)
        {
            InitializeComponent();
            _biletService = biletService;
        }

        public void SetDetails(Seans seans, List<Koltuk> koltuklar)
        {
            _selectedSeans = seans;
            _selectedKoltuklar = koltuklar;

            lblFilm.Text = seans.Film?.FilmAd ?? "Film Bilgisi Yok";
            lblSalon.Text = $"Salon: {seans.Salon?.SalonNo}";
            lblSeans.Text = $"Seans: {seans.SeansSaati:g}";
            
            lblKoltuk.Text = $"Koltuklar: {string.Join(", ", koltuklar.Select(k => k.Satir + k.Numara))}";
            
            decimal birimFiyat = seans.Fiyat < 200 ? 200 : seans.Fiyat;
            decimal toplamFiyat = birimFiyat * koltuklar.Count;
            lblFiyat.Text = $"Toplam Tutar: {toplamFiyat:N2} TL ({koltuklar.Count} Bilet)";
        }

        private async void btnOde_Click(object sender, EventArgs e)
        {
            if (_selectedSeans == null || _selectedKoltuklar == null || _selectedKoltuklar.Count == 0) return;

            if (Form1.LoggedInUser == null)
            {
                MessageBox.Show("Ödeme yapabilmek için giriş yapmış olmanız gerekmektedir.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                btnOde.Enabled = false;
                btnVazgec.Enabled = false;

                // Simulate payment delay
                await Task.Delay(1000);

                decimal biletFiyat = _selectedSeans.Fiyat < 200 ? 200 : _selectedSeans.Fiyat;

                foreach (var koltuk in _selectedKoltuklar)
                {
                    Bilet yeniBilet = new Bilet
                    {
                        SeansID = _selectedSeans.ID,
                        KoltukID = koltuk.ID,
                        KullaniciID = Form1.LoggedInUser.ID,
                        Fiyat = biletFiyat,
                        SatinAlmaTarihi = DateTime.Now,
                        BiletDurumu = Bilet.Durum.Aktif
                    };

                    await _biletService.TBiletSatAsync(yeniBilet);
                }

                MessageBox.Show($"{_selectedKoltuklar.Count} adet bilet için ödeme işlemi başarıyla gerçekleşti!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Return to session list
                Form1 mainForm = this.FindForm() as Form1;
                mainForm?.ShowSeansList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ödeme sırasında hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnOde.Enabled = true;
                btnVazgec.Enabled = true;
            }
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            mainForm?.ShowSeansList();
        }
    }
}
