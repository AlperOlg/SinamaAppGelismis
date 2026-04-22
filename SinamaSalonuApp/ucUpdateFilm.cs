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
    public partial class ucUpdateFilm : UserControl
    {
        private readonly IFilmService _filmService;
        private readonly IYonetmenService _yonetmenService;
        private readonly IOyuncuService _oyuncuService;
        private readonly IKategoriService _kategoriService;

        public ucUpdateFilm(IFilmService filmService, IYonetmenService yonetmenService, IOyuncuService oyuncuService, IKategoriService kategoriService)
        {
            InitializeComponent();
            _filmService = filmService;
            _yonetmenService = yonetmenService;
            _oyuncuService = oyuncuService;
            _kategoriService = kategoriService;
        }

        private async void ucUpdateFilm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task Listele()
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            try
            {
                var films = await _filmService.THepsiniGetirAsync();
                cbSelectFilm.ValueMember = "ID";
                cbSelectFilm.DisplayMember = "FilmAd";
                cbSelectFilm.DataSource = films.Select(f => new { f.ID, f.FilmAd }).ToList();

                var yonetmenler = await _yonetmenService.THepsiniGetirAsync();
                cbYonetmen.ValueMember = "ID";
                cbYonetmen.DisplayMember = "AdSoyad";
                cbYonetmen.DataSource = yonetmenler.Select(y => new { ID = y.ID, AdSoyad = (y.Ad + " " + y.Soyad) }).ToList();

                var kategoriler = await _kategoriService.THepsiniGetirAsync();
                cbKategori.ValueMember = "ID";
                cbKategori.DisplayMember = "KategoriAdi";
                cbKategori.DataSource = kategoriler.Select(k => new { ID = k.ID, k.KategoriAdi }).ToList();

                var oyuncular = await _oyuncuService.THepsiniGetirAsync();
                cbBasRol.ValueMember = "ID";
                cbBasRol.DisplayMember = "AdSoyad";
                cbBasRol.DataSource = oyuncular.Select(o => new { ID = o.ID, AdSoyad = (o.Ad + " " + o.Soyad) }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private async void cbSelectFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSelectFilm.SelectedValue == null || !(cbSelectFilm.SelectedValue is int filmId)) return;

            try
            {
                var film = await _filmService.TBirTaneGetirAsync(f => f.ID == filmId);
                if (film != null)
                {
                    txtFilmName.Text = film.FilmAd;
                    txtReleaseDate.Text = film.FilmYili.ToString();
                    cbYonetmen.SelectedValue = film.YonetmenID;
                    cbKategori.SelectedValue = film.KategoriID;
                    cbBasRol.SelectedValue = film.BasRolOyuncuID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film detayları yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (cbSelectFilm.SelectedValue == null)
            {
                MessageBox.Show("Lütfen güncellenecek filmi seçin.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFilmName.Text) || string.IsNullOrWhiteSpace(txtReleaseDate.Text))
            {
                MessageBox.Show("Lütfen film adını ve yılını doldurun.");
                return;
            }

            try
            {
                int filmId = (int)cbSelectFilm.SelectedValue;
                var film = await _filmService.TBirTaneGetirAsync(f => f.ID == filmId);

                if (film != null)
                {
                    film.FilmAd = txtFilmName.Text;
                    film.FilmYili = int.Parse(txtReleaseDate.Text);
                    film.YonetmenID = (int)cbYonetmen.SelectedValue;
                    film.KategoriID = (int)cbKategori.SelectedValue;
                    film.BasRolOyuncuID = (int)cbBasRol.SelectedValue;

                    await _filmService.TGuncelleAsync(film);
                    MessageBox.Show("Film başarıyla güncellendi.");
                    await LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film güncellenirken hata oluştu: " + ex.Message);
            }
        }
    }
}
