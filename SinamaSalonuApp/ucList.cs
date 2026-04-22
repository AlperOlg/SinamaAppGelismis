using SinamaApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SinamaSalonuApp.Form1;

namespace SinamaSalonuApp
{
    public partial class ucList : UserControl
    {
        private readonly IFilmService _filmService;
        private readonly IYonetmenService _yonetmenService;
        private readonly IOyuncuService _oyuncuService;
        private readonly ISalonService _salonService;
        public EntityEnum entityEnum;
        public ucList(IFilmService filmService, IYonetmenService yonetmenService, IOyuncuService oyuncuService, ISalonService salonService)
        {
            InitializeComponent();
            _filmService = filmService;
            _yonetmenService = yonetmenService;
            _oyuncuService = oyuncuService;
            _salonService = salonService;
        }
        public async Task VerileriYukle()
        {
           
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnRefresh.Enabled = false;
                dataGridView.DataSource = null;
                switch (entityEnum)
                {
                    case EntityEnum.Film:
                        lblInfo.Text = "Filmler:";
                        dataGridView.DataSource = await _filmService.THepsiniGetirAsync();
                        break;
                    case EntityEnum.Yonetmen:
                        lblInfo.Text = "Yonetmenler:";
                        dataGridView.DataSource = await _yonetmenService.THepsiniGetirAsync();
                        break;
                    case EntityEnum.Oyuncu:
                        lblInfo.Text = "Oyuncular:";
                        dataGridView.DataSource = await _oyuncuService.THepsiniGetirAsync();
                        break;
                    case EntityEnum.Salon:
                        lblInfo.Text = "Salonlar:";
                        dataGridView.DataSource = await _salonService.THepsiniGetirAsync();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException(nameof(entityEnum), entityEnum, "Listeleme için geçersiz veya desteklenmeyen bir tablo tipi seçildi.");
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnRefresh.Enabled = true;
            }
        }

        private async void ucList_Load(object sender, EventArgs e)
        {
            await VerileriYukle();
        }
    }
}
