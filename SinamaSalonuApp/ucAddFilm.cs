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
    public partial class ucAddFilm : UserControl
    {
        private readonly IFilmService _filmService;
        private readonly IYonetmenService _yonetmenService;
        private readonly IOyuncuService _oyuncuService;
        private readonly IKategoriService _kategoriService;

        public ucAddFilm(IFilmService filmService, IYonetmenService yonetmenService, IOyuncuService oyuncuService, IKategoriService kategoriService)
        {
            InitializeComponent();
            _filmService = filmService;
            _yonetmenService = yonetmenService;
            _oyuncuService = oyuncuService;
            _kategoriService = kategoriService;
        }

        private async void ucAddFilm_Load(object sender, EventArgs e)
        {
            try
            {
                cbYonetmen.DataSource = null;
                cbYonetmen.Items.Clear();
                var yonetmenler = await _yonetmenService.THepsiniGetirAsync();
                cbYonetmen.ValueMember = "ID";
                cbYonetmen.DisplayMember = "AdSoyad";
                cbYonetmen.DataSource = yonetmenler.Select(y => new {ID = y.ID, AdSoyad = (y.Ad + " " + y.Soyad)}).ToList();

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

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilmName.Text) || string.IsNullOrWhiteSpace(txtReleaseDate.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            if (cbYonetmen.SelectedValue == null || cbKategori.SelectedValue == null || cbBasRol.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapın.");
                return;
            }

            try
            {
                Film yeniFilm = new Film
                {
                    FilmAd = txtFilmName.Text,
                    FilmYili = int.Parse(txtReleaseDate.Text),
                    YonetmenID = (int)cbYonetmen.SelectedValue,
                    KategoriID = (int)cbKategori.SelectedValue,
                    BasRolOyuncuID = (int)cbBasRol.SelectedValue,
                };

                await _filmService.TEkleAsync(yeniFilm);
                MessageBox.Show("Film başarıyla eklendi.");

                // Alanları temizle
                txtFilmName.Text = "";
                txtReleaseDate.Text = "";
            }
            catch (FormatException fx)
            {
                MessageBox.Show("Yayınlanan yılı düzgün formattta giriniz: '" + fx.Message + "'", "Format Hatası",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Film eklenirken bir hata oluştu: '" + ex.Message + "'", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region MouseHoverEvents
        private void txtFilmName_MouseHover(object sender, EventArgs e)
        {
        }

        private void txtReleaseDate_MouseHover(object sender, EventArgs e)
        {
        }

        private void cbYonetmen_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void cbKategori_MouseHover(object sender, EventArgs e)
        {
        }

        private void cbBasRol_MouseHover(object sender, EventArgs e)
        {
        }

        private void cbYonetmen_MouseHover(object sender, EventArgs e)
        {
        }
        #endregion

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
