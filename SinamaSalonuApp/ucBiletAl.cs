using Guna.UI2.WinForms;
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
    public partial class ucBiletAl : UserControl
    {
        private readonly ISalonService _salonService;
        private readonly IBiletService _biletService;
        private readonly ISeansService _seansService;
        private readonly IKoltukService _koltukService;

        private int _selectedSeansID;
        private List<int> _selectedKoltukIDs = new List<int>();
        private List<Koltuk> _selectedKoltuklar = new List<Koltuk>();
        private Seans _currentSeans;
        private bool _isLoading = false;

        public ucBiletAl(ISalonService salonService, IBiletService biletService, ISeansService seansService, IKoltukService koltukService)
        {
            InitializeComponent();
            _salonService = salonService;
            _biletService = biletService;
            _seansService = seansService;
            _koltukService = koltukService;
        }

        public async void SetSeans(int seansID)
        {
            _selectedSeansID = seansID;
            await LoadData();
        }

        private async Task LoadData()
        {
            if (_isLoading) return;
            try
            {
                _isLoading = true;
                pnlSeats.Controls.Clear();
                _selectedKoltukIDs.Clear();
                _selectedKoltuklar.Clear();
                btnRezerveEt.Visible = false;
                lblSelectedSeat.Text = "Seçilen Koltuk: -";

                var seansList = await _seansService.THepsiniGetirAsync(s => s.ID == _selectedSeansID);
                _currentSeans = seansList.FirstOrDefault();
                if (_currentSeans == null) return;

                // Detailed info for label
                var detailedSeans = await _seansService.TSeanslariGetirDetayliAsync(s => s.ID == _selectedSeansID);
                var seansInfo = detailedSeans.FirstOrDefault();
                if (seansInfo != null)
                {
                    lblSessionInfo.Text = $"{seansInfo.Film.FilmAd} | Salon {seansInfo.Salon.SalonNo} | {seansInfo.SeansSaati:g}";
                }

                // Get all seats for this salon
                var salon = await _salonService.TSalonGetirKoltuklarlaAsync(_currentSeans.SalonID);
                
                // Get reserved tickets for this session
                var reservedTickets = await _biletService.TSeansaGoreBiletleriGetirAsync(_selectedSeansID);
                var reservedKoltukIDs = reservedTickets.Select(b => b.KoltukID).ToList();

                foreach (var koltuk in salon.Koltuklar.OrderBy(k => k.Satir).ThenBy(k => k.Numara))
                {
                    Guna2Button btnSeat = new Guna2Button();
                    btnSeat.Text = $"{koltuk.Satir}{koltuk.Numara}";
                    btnSeat.Size = new Size(60, 60);
                    btnSeat.Tag = koltuk.ID;
                    btnSeat.BorderRadius = 10;
                    btnSeat.Margin = new Padding(5);

                    if (reservedKoltukIDs.Contains(koltuk.ID))
                    {
                        btnSeat.FillColor = Color.Salmon; // Occupied
                        btnSeat.Enabled = false;
                    }
                    else
                    {
                        btnSeat.FillColor = Color.MediumSeaGreen; // Available
                        btnSeat.Click += (s, e) => {
                            int kID = (int)btnSeat.Tag;
                            if (_selectedKoltukIDs.Contains(kID))
                            {
                                _selectedKoltukIDs.Remove(kID);
                                _selectedKoltuklar.RemoveAll(k => k.ID == kID);
                                btnSeat.FillColor = Color.MediumSeaGreen;
                            }
                            else
                            {
                                _selectedKoltukIDs.Add(kID);
                                _selectedKoltuklar.Add(koltuk);
                                btnSeat.FillColor = Color.Gold;
                            }

                            if (_selectedKoltuklar.Count > 0)
                            {
                                lblSelectedSeat.Text = $"Seçilen Koltuklar: {string.Join(", ", _selectedKoltuklar.Select(k => k.Satir + k.Numara))}";
                                btnRezerveEt.Visible = true;
                            }
                            else
                            {
                                lblSelectedSeat.Text = "Seçilen Koltuk: -";
                                btnRezerveEt.Visible = false;
                            }
                        };
                    }
                    pnlSeats.Controls.Add(btnSeat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koltuklar yüklenirken hata: " + ex.Message);
            }
            finally
            {
                _isLoading = false;
            }
        }

        private void HighlightCurrentSelections()
        {
            foreach (Control ctrl in pnlSeats.Controls)
            {
                if (ctrl is Guna2Button btn && btn.Enabled && btn.FillColor != Color.Salmon)
                {
                    int kID = (int)btn.Tag;
                    btn.FillColor = _selectedKoltukIDs.Contains(kID) ? Color.Gold : Color.MediumSeaGreen;
                }
            }
        }

        private void btnRezerveEt_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 mainForm = this.FindForm() as Form1;
                if (mainForm != null && _currentSeans != null && _selectedKoltuklar.Count > 0)
                {
                    if (Form1.LoggedInUser == null)
                    {
                        MessageBox.Show("Rezervasyon yapabilmek için lütfen giriş yapın.", "Giriş Gerekli", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        mainForm.ShowLogin();
                        return;
                    }
                    mainForm.ShowKasa(_currentSeans, _selectedKoltuklar);
                }
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                if (ex.InnerException != null)
                {
                    message += "\nDetay: " + ex.InnerException.Message;
                }
                MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 mainForm = this.FindForm() as Form1;
            if (mainForm != null)
            {
                var pnl = mainForm.Controls.Find("UserControlPanel", true).FirstOrDefault() as Panel;
                if (pnl != null)
                {
                    pnl.Controls.Clear();
                    // We need to show ucSeansList again. 
                    // Since it's injected, we can get it from DI if we had access or just create a new one. 
                    // Best way is to have Form1 handle this.
                    mainForm.ShowSeansList(); 
                }
            }
        }
    }
}
