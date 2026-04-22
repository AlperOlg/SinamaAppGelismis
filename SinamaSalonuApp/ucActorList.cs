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
    public partial class ucActorList : UserControl
    {
        private readonly IOyuncuService _oyuncuService;
        public ucActorList(IOyuncuService oyuncuService)
        {
            InitializeComponent();
            _oyuncuService = oyuncuService;
        }

        private async void ucActorList_Load(object sender, EventArgs e)
        {
            await Listele();
        }

        public async Task Listele()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                btnRefresh.Enabled = false;

                dataGridView.DataSource = null;
                dataGridView.DataSource = await _oyuncuService.THepsiniGetirAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnRefresh.Enabled = true;
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await Listele();
        }
    }
}
