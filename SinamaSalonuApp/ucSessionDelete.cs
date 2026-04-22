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
    public partial class ucSessionDelete : UserControl
    {
        private readonly ISeansService _seansService;
        private readonly IFilmService _filmService;
        private readonly ISalonService _salonService;

        public ucSessionDelete(ISeansService seansService, IFilmService filmService, ISalonService salonService)
        {
            InitializeComponent();
            _seansService = seansService;
            _filmService = filmService;
            _salonService = salonService;

        }

        private async void ucSessionDelete_Load(object sender, EventArgs e)
        {
            await LoadDatas();
        }
        public async Task Listele()
        {
            await LoadDatas();
        }
        private async Task LoadDatas()
        {
            List<Seans> seanslar = await _seansService.THepsiniGetirAsync();
            cbSelectSession.ValueMember = "ID";
            cbSelectSession.DisplayMember = "ID";
            cbSelectSession.DataSource = seanslar.Select(s => new { ID = s.ID }).ToList();

            List<Film> filmler = await _filmService.THepsiniGetirAsync();
            cbFilm.ValueMember = "ID";
            cbFilm.DisplayMember = "FilmAd";
            cbFilm.DataSource = filmler.Select(f => new { f.ID, f.FilmAd }).ToList();

            List<Salon> salonlar = await _salonService.THepsiniGetirAsync();
            cbAuditorium.ValueMember = "ID";
            cbAuditorium.DisplayMember = "SalonNo";
            cbAuditorium.DataSource = salonlar.Select(s => new { s.ID, s.SalonNo }).ToList();

        }

        private async void cbSelectSession_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectSession.SelectedValue == null || !(cbSelectSession.SelectedValue is int sessionID)) { return; }
            try
            {
                Seans seans = await _seansService.TBirTaneGetirAsync(s => s.ID == sessionID);
                if (seans != null)
                {
                    lblPrice.Text = (seans.Fiyat.ToString() + " TL");
                    cbAuditorium.SelectedValue = seans.SalonID;
                    cbFilm.SelectedValue = seans.FilmID;
                    dtpSessionTime.Value = seans.SeansSaati;
                }
                else
                {
                    MessageBox.Show("null");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (cbSelectSession.SelectedValue == null || !(cbSelectSession.SelectedValue is int sessionID)) { return; }
            try
            {
                Seans seans = await _seansService.TBirTaneGetirAsync(s=>s.ID == sessionID);
                if(seans == null) { throw new Exception("Bir seans seçin"); }
                await _seansService.TSilAsync(seans);
                MessageBox.Show("Seans baþarýyla silindi");
                await LoadDatas();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"bir hata meydana geldi: '{ex.Message}'");
            }
            
        }
    }
}
