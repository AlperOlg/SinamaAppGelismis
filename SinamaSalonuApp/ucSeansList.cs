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
    public partial class ucSeansList : UserControl
    {
        private readonly ISeansService _seansService;
        private readonly IServiceProvider _serviceProvider;

        public ucSeansList(ISeansService seansService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _seansService = seansService;
            _serviceProvider = serviceProvider;
        }

        private async void ucSeansList_Load(object sender, EventArgs e)
        {
            await Listele();
        }

        public async Task Listele()
        {
            try
            {
                dgvSeanslar.DataSource = null;
                dgvSeanslar.Rows.Clear();
                var seanslar = await _seansService.TSeanslariGetirDetayliAsync();
                if (seanslar == null) { return; }
                foreach (var seans in seanslar)
                {
                    dgvSeanslar.Rows.Add(seans.ID, seans.Film.FilmAd, "Salon " + seans.Salon.SalonNo, seans.SeansSaati.ToString("g"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Seanslar yüklenirken hata oluştu: " + ex.Message);
            }
        }

        private void dgvSeanslar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvSeanslar.Columns["BiletAl"].Index && e.RowIndex >= 0)
            {
                int seansID = Convert.ToInt32(dgvSeanslar.Rows[e.RowIndex].Cells["ID"].Value);

                // Navigate to ucBiletAl
                var ucBiletAl = _serviceProvider.GetRequiredService<ucBiletAl>();
                ucBiletAl.SetSeans(seansID);

                // This logic depends on having access to UserControlPanel of Form1
                // We can find the parent Form1
                Form1 mainForm = this.FindForm() as Form1;
                if (mainForm != null)
                {
                    var pnl = mainForm.Controls.Find("UserControlPanel", true).FirstOrDefault() as Panel;
                    if (pnl != null)
                    {
                        pnl.Controls.Clear();
                        pnl.Controls.Add(ucBiletAl);
                        ucBiletAl.Dock = DockStyle.Fill;
                    }
                }
            }
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
