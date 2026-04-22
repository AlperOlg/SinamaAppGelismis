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
    public partial class ucSessionUpdate : UserControl
    {
        private readonly ISeansService _seansService;
        private readonly IFilmService _filmService;
        private readonly ISalonService _salonService;

        public ucSessionUpdate(ISeansService seansService, IFilmService filmService, ISalonService salonService)
        {
            InitializeComponent();
            _seansService = seansService;
            _filmService = filmService;
            _salonService = salonService;
        }
        public async Task Listele()
        {
            await LoadDatas();
        }
        private async Task LoadDatas()
        {
            List<Seans> seanslar = await _seansService.THepsiniGetirAsync();
            cbSelectSession.DisplayMember = "ID";
            cbSelectSession.ValueMember = "ID";
            cbSelectSession.DataSource = seanslar.Select(s => new { s.ID }).ToList();

            List<Film> filmler = await _filmService.THepsiniGetirAsync();
            cbFilms.ValueMember = "ID";
            cbFilms.DisplayMember = "FilmAd";
            cbFilms.DataSource = filmler.Select(f => new { f.ID, f.FilmAd }).ToList();

            List<Salon> salonlar = await _salonService.THepsiniGetirAsync();
            cbAuditorium.ValueMember = "ID";
            cbAuditorium.DisplayMember = "SalonNo";
            cbAuditorium.DataSource = salonlar.Select(s => new { s.ID, s.SalonNo }).ToList();
        }

        private async void ucSessionUpdate_Load(object sender, EventArgs e)
        {
            await LoadDatas();
        }

        private async void cbSelectSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectSession.SelectedValue == null || !(cbSelectSession.SelectedValue is int sessionID)) { return; }
            Seans seans = await _seansService.TBirTaneGetirAsync(s => s.ID == sessionID);
            if (seans == null) { return; }
            txtSessionPrice.Text = seans.Fiyat.ToString();
            cbFilms.SelectedValue = seans.FilmID;
            cbAuditorium.SelectedValue = seans.SalonID;
            dtpSessionTime.Value = seans.SeansSaati;
            mtxtSessionHour.Text = seans.SeansSaati.ToString("HH:mm");
        }

        private void txtSessionPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnSessionUpdate_Click(object sender, EventArgs e)
        {
            if (cbSelectSession.SelectedValue == null || !(cbSelectSession.SelectedValue is int sessionID)) { return; }
            try
            {
                Seans seans = await _seansService.TBirTaneGetirAsync(s => s.ID == sessionID);
                if(seans == null) { return; }
                if (string.IsNullOrEmpty(txtSessionPrice.Text) || !decimal.TryParse(txtSessionPrice.Text, out decimal sessionPrice))
                {
                    MessageBox.Show("Fiyat yanlış formatta girildi");
                    return;
                }

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
                DateTime seansTarihSaat = dtpSessionTime.Value.Date + seansSaatiSpan;

                if (seansTarihSaat <= DateTime.Now)
                {
                    MessageBox.Show("Seans tarihi ve saati gelecekte olmalıdır.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                seans.Fiyat = sessionPrice;
                seans.SalonID = (int)cbAuditorium.SelectedValue;
                seans.FilmID = (int)cbFilms.SelectedValue;
                seans.SeansSaati = seansTarihSaat;

                await _seansService.TGuncelleAsync(seans);
                MessageBox.Show("Seans başarıyla güncellendi");
            }
            catch (Exception ex)
            {

            }
        }
    }
}
