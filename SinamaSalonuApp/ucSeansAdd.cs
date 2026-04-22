using Microsoft.Extensions.DependencyInjection;
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
    public partial class ucSeansAdd : UserControl
    {
        private readonly ISeansService _seansService;
        private readonly IFilmService _filmService;
        private readonly ISalonService _salonService;

        public ucSeansAdd(ISeansService seansService, IFilmService filmService, ISalonService salonService)
        {
            InitializeComponent();
            _seansService = seansService;
            _filmService = filmService;
            _salonService = salonService;
        }

        private async void ucSeansAdd_Load(object sender, EventArgs e)
        {
            await VerileriYukleAsync();
        }

        private async Task VerileriYukleAsync()
        {
            try
            {
                cbFilm.DataSource = null;
                cbFilm.Items.Clear();
                var filmler = await _filmService.THepsiniGetirAsync();
                cbFilm.ValueMember = "ID";
                cbFilm.DisplayMember = "FilmAd";
                cbFilm.DataSource = filmler.Select(f => new { f.ID, f.FilmAd }).ToList();

                cbAuditorium.DataSource = null;
                cbAuditorium.Items.Clear();
                var salonlar = await _salonService.THepsiniGetirAsync();
                cbAuditorium.ValueMember = "ID";
                cbAuditorium.DisplayMember = "SalonNo";
                cbAuditorium.DataSource = salonlar
                    .Select(s => new { s.ID, SalonNo = "Salon " + s.SalonNo })
                    .ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSessionPrice.Text))
            {
                MessageBox.Show("Lütfen seans fiyatını giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSessionPrice.Focus();
                return;
            }

            if (cbFilm.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbAuditorium.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir salon seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtSessionPrice.Text.Replace(',', '.'),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal fiyat) || fiyat <= 0)
            {
                MessageBox.Show("Geçerli bir fiyat giriniz (örn: 75.50).", "Format Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSessionPrice.Focus();
                return;
            }

            // Saat validasyonu — mtxtSessionHour maskesi "00:00" formatında
            string saatMetni = mtxtSessionHour.Text.Trim();
            if (string.IsNullOrWhiteSpace(saatMetni) || saatMetni == ":")
            {
                MessageBox.Show("Lütfen seans saatini giriniz (örn: 14:30).", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mtxtSessionHour.Focus();
                return;
            }

            if (!TimeSpan.TryParseExact(saatMetni, "hh\\:mm",
                    System.Globalization.CultureInfo.InvariantCulture, out TimeSpan seansSaatiSpan))
            {
                MessageBox.Show("Saat formatı hatalı. Lütfen SS:DD formatında giriniz (örn: 14:30).", "Format Hatası",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                mtxtSessionHour.Focus();
                return;
            }

            // Tarih (dtpSessionTime) + Saat (mtxtSessionHour) birleştir
            DateTime seansTarihSaat = dtpSessionTime.Value.Date + seansSaatiSpan;

            if (seansTarihSaat <= DateTime.Now)
            {
                MessageBox.Show("Seans tarihi ve saati gelecekte olmalıdır.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                guna2Button1.Enabled = false;

                Seans yeniSeans = new Seans
                {
                    FilmID     = (int)cbFilm.SelectedValue,
                    SalonID    = (int)cbAuditorium.SelectedValue,
                    SeansSaati = seansTarihSaat,
                    Fiyat      = fiyat
                };

                await _seansService.TEkleAsync(yeniSeans);

                MessageBox.Show("Seans başarıyla eklendi.", "Başarılı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seans eklenirken bir hata oluştu: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                guna2Button1.Enabled = true;
            }
        }

        private void FormTemizle()
        {
            txtSessionPrice.Text  = string.Empty;
            mtxtSessionHour.Text  = string.Empty;
            dtpSessionTime.Value  = DateTime.Now.AddDays(1).Date;
            if (cbFilm.Items.Count > 0) cbFilm.SelectedIndex = 0;
            if (cbAuditorium.Items.Count > 0)     cbAuditorium.SelectedIndex = 0;
        }
    }
}
