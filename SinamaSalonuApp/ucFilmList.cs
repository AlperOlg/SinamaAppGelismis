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
    public partial class ucFilmList : UserControl
    {
        private readonly IFilmService _filmService;
        public ucFilmList(IFilmService filmService)
        {
            InitializeComponent();
            _filmService = filmService;
        }
        public async Task Listele()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                dataGridView.DataSource = null;
                dataGridView.DataSource = await _filmService.THepsiniGetirAsync();

            }
            catch (Exception ex)
            {
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        private async void ucFilmList_Load(object sender, EventArgs e)
        {

            await Listele();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            btnRefresh.Enabled = false;

            await Listele();

            this.Cursor = Cursors.Default;
            btnRefresh.Enabled = true;
        }
    }
}
