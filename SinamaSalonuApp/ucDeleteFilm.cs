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
    public partial class ucDeleteFilm : UserControl
    {
        private readonly IFilmService _filmService;
        public ucDeleteFilm(IFilmService filmSerivce)
        {
            InitializeComponent();
            _filmService = filmSerivce;
        }

        private async void ucDeleteFilm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }
        public async Task Listele()
        {
            await LoadData();
        }
        private async Task LoadData()
        {
            List<Film> films = await _filmService.THepsiniGetirAsync();
            if (films.Count <= 0)
            {
                MessageBox.Show("kayıtlı film yok");
                return;
            }
            cbSelectFilm.DataSource = films.Select(f => new { f.ID, f.FilmAd }).ToList();
            cbSelectFilm.ValueMember = "ID";
            cbSelectFilm.DisplayMember = "FilmAd";
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if(cbSelectFilm.SelectedValue == null || !(cbSelectFilm.SelectedValue is int filmId)) { return; }
            try
            {
                Film film = await _filmService.TBirTaneGetirAsync(f=>f.ID == filmId);
                await _filmService.TSilAsync(film);
                MessageBox.Show("başarıyla silindi");
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
