using Microsoft.EntityFrameworkCore;
using SinamaApp.Business.Abstract;
using SinamaApp.Entities.Concrete;
using SinamaSalonuApp.Helpers;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace SinamaSalonuApp
{
    public partial class Form1 : BaseForm
    {
        private readonly IFilmService _filmService;
        private readonly ucAddFilm _ucAddFilm;
        private readonly ucSeansList _ucSeansList;
        private readonly ucBiletAl _ucBiletAl;
        private readonly ucLogin _ucLogin;
        private readonly ucRegister _ucRegister;
        private readonly ucKasa _ucKasa;
        private readonly ucUpdateFilm _ucUpdateFilm;
        private readonly ucDeleteFilm _ucDeleteFilm;
        private readonly ucSeansAdd _ucSeansAdd;
        private readonly ucSessionDelete _ucSessionDelete;
        private readonly ucSessionUpdate _ucSessionUpdate;
        private readonly ucActorAdd _ucActorAdd;
        private readonly ucActorUpdate _ucActorUpdate;
        private readonly ucActorDelete _ucActorDelete;
        private readonly ucDirectorAdd _ucDirectorAdd;
        private readonly ucDirectorUpdate _ucDirectorUpdate;
        private readonly ucDirectorDelete _ucDirectorDelete;
        private readonly ucList _ucList;
        private readonly IKullaniciService _kullaniciService;
        public enum EntityEnum { Film, Yonetmen, Oyuncu, Salon }
        public static Kullanici? LoggedInUser { get; private set; }

        public Form1(IFilmService filmService, ucAddFilm ucAddFilm, ucList ucList, ucSeansList ucSeansList, ucBiletAl ucBiletAl, ucLogin ucLogin, ucRegister ucRegister, ucKasa ucKasa, ucUpdateFilm ucUpdateFilm, ucDeleteFilm ucDeleteFilm, ucSeansAdd ucSeansAdd, ucSessionDelete ucSessionDelete, ucSessionUpdate ucSessionUpdate, ucActorAdd ucActorAdd, ucActorDelete ucActorDelete, ucActorUpdate ucActorUpdate, ucDirectorAdd ucDirectorAdd, ucDirectorUpdate ucDirectorUpdate,ucDirectorDelete ucDirectorDelete, IKullaniciService kullaniciService)
        {
            InitializeComponent();
            _ucAddFilm = ucAddFilm;
            _ucList = ucList;
            _ucSeansList = ucSeansList;
            _ucBiletAl = ucBiletAl;
            _ucLogin = ucLogin;
            _ucRegister = ucRegister;
            _ucKasa = ucKasa;
            _ucUpdateFilm = ucUpdateFilm;
            _ucDeleteFilm = ucDeleteFilm;
            _ucSeansAdd = ucSeansAdd;
            _ucSessionDelete = ucSessionDelete;
            _ucSessionUpdate = ucSessionUpdate;
            _filmService = filmService;
            _ucActorAdd = ucActorAdd;
            _ucActorDelete = ucActorDelete;
            _ucActorUpdate = ucActorUpdate;
            _ucDirectorAdd = ucDirectorAdd;
            _ucDirectorUpdate = ucDirectorUpdate;
            _ucDirectorDelete = ucDirectorDelete;
            _kullaniciService = kullaniciService;

            _ucLogin.LoginSuccessful += (s, user) =>
            {
                LoggedInUser = user;
                btnUser.Text = user.Ad;
                UpdateAuthButtons(true);
                ShowSeansList();
            };

            _ucRegister.RegistrationSuccessful += (s, e) =>
            {
                ShowLogin();
            };

            _btnMaxAndMin = btnMaxMin;
            _btnMinimize = btnMini;
            _btnClose = btnExit;
            InitButtons();

            panel1.MouseDown += panel1_MouseDown;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }
        private void ChangePanelVisibility(bool TrueOrFalse, params Control[] panels)
        {
            foreach (Control panel in panels)
            {
                panel.Visible = TrueOrFalse;
            }
        }
        private void ChangeButtonColor(Color color, params Control[] buttons)
        {
            foreach (var button in buttons)
            {
                button.BackColor = color;
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            var rememberedUserId = SettingsHelper.GetRememberMeUserId();
            if (rememberedUserId.HasValue)
            {
                var user = await _kullaniciService.TBirTaneGetirAsync(x => x.ID == rememberedUserId.Value);
                if (user != null)
                {
                    LoggedInUser = user;
                    btnUser.Text = user.Ad;
                    UpdateAuthButtons(true);
                    ShowSeansList();
                }
                else
                {
                    UpdateAuthButtons(false);
                    ShowLogin();
                }
            }
            else
            {
                UpdateAuthButtons(false);
                ShowLogin();
            }
        }

        private void btnFilms_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = false;
            ChangePanelVisibility(true, pnlFilms);
            ChangePanelVisibility(false, pnlUser, pnlSession, pnlActors, pnlDirectors);
            ChangeButtonColor(Color.FromArgb(59, 193, 168), btnFilms);
            ChangeButtonColor(Color.FromArgb(36, 158, 148), btnUser, btnSessions, btnActors, btnDirectors);
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = false;
        }
        private void ChangeUserControl(UserControl uc)
        {
            UserControlPanel.Visible = true;
            UserControlPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            UserControlPanel.Controls.Add(uc);
        }
        private void btnFilmAdd_Click(object sender, EventArgs e)
        {
            ShowFilmAdd();
        }
        private void ShowFilmAdd()
        {
            ChangeUserControl(_ucAddFilm);
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await ShowFilmUpdate();
        }
        private async Task ShowFilmUpdate()
        {
            ChangeUserControl(_ucUpdateFilm);
            await _ucUpdateFilm.Listele();
        }
        private void btnReservation_Click(object sender, EventArgs e)
        {
            ShowSeansList();
        }

        public void ShowSeansList()
        {
            ChangeUserControl(_ucSeansList);
        }

        private async void btnFilmList_Click(object sender, EventArgs e)
        {
            await ShowFilmList();
        }
        private async Task ShowFilmList()
        {
            _ucList.entityEnum = EntityEnum.Film;
            ChangeUserControl(_ucList);
            await _ucList.VerileriYukle();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = false;
            ChangePanelVisibility(true, pnlUser);
            ChangePanelVisibility(false, pnlFilms, pnlSession, pnlActors, pnlDirectors);
            ChangeButtonColor(Color.FromArgb(59, 193, 168), btnUser);
            ChangeButtonColor(Color.FromArgb(36, 158, 148), btnFilms, btnSessions, btnActors, btnDirectors);
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            ShowRegister();
        }

        public void ShowLogin()
        {
            ChangeUserControl(_ucLogin);
        }

        public void ShowRegister()
        {
            ChangeUserControl(_ucRegister);
        }

        public void ShowKasa(Seans seans, List<Koltuk> koltuklar)
        {
            ChangeUserControl(_ucKasa);
            _ucKasa.SetDetails(seans, koltuklar);
        }
        public async Task ShowDelete()
        {
            ChangeUserControl(_ucDeleteFilm);
            await _ucDeleteFilm.Listele();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Hesaptan çıkmak istediğine emin misiniz?", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) { return; }

            SettingsHelper.ClearRememberMe();
            LoggedInUser = null;
            btnUser.Text = "Kullanıcılar";
            UpdateAuthButtons(false);
            MessageBox.Show("Hesaptan çıkış yapıldı", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowLogin();
        }

        private void UpdateAuthButtons(bool isLoggedIn)
        {
            btnLogIn.Enabled = !isLoggedIn;
            btnSignUp.Enabled = !isLoggedIn;
            btnLogOut.Visible = isLoggedIn;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await ShowDelete();
        }

        private void btnSessions_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = false;
            ChangePanelVisibility(true, pnlSession);
            ChangePanelVisibility(false, pnlFilms, pnlUser, pnlActors, pnlDirectors);
            ChangeButtonColor(Color.FromArgb(59, 193, 168), btnSessions);
            ChangeButtonColor(Color.FromArgb(36, 158, 148), btnFilms, btnUser, btnActors, btnDirectors);
        }

        private void btnSessionAdd_Click(object sender, EventArgs e)
        {
            ShowSeansAdd();
        }

        private void btnSessionShow_Click(object sender, EventArgs e)
        {
            ShowSeansList();
        }

        private async void btnSessionUpdate_Click(object sender, EventArgs e)
        {
            await ShowSessionUpdate();
        }

        private async void btnSessionDelete_Click(object sender, EventArgs e)
        {
            await ShowSessionDelete();
        }
        public async Task ShowSessionDelete()
        {
            ChangeUserControl(_ucSessionDelete);
            await _ucSessionDelete.Listele();
        }
        public void ShowSeansAdd()
        {
            ChangeUserControl(_ucSeansAdd);
        }
        public async Task ShowSessionUpdate()
        {
            ChangeUserControl(_ucSessionUpdate);
            await _ucSessionUpdate.Listele();
        }

        private void btnActors_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = true;
            ChangePanelVisibility(true, pnlActors);
            ChangePanelVisibility(false, pnlFilms, pnlUser, pnlSession, pnlDirectors);
            ChangeButtonColor(Color.FromArgb(59, 193, 168), btnActors);
            ChangeButtonColor(Color.FromArgb(36, 158, 148), btnFilms, btnUser, btnSessions, btnDirectors);
        }

        private async void btnActorList_Click(object sender, EventArgs e)
        {
            await ShowActorList();
        }
        private async Task ShowActorList()
        {
            _ucList.entityEnum = EntityEnum.Oyuncu;
            ChangeUserControl(_ucList);
            await _ucList.VerileriYukle();
        }

        private void btnActorAdd_Click(object sender, EventArgs e)
        {
            ShowActorAdd();
        }
        private void ShowActorAdd()
        {
            ChangeUserControl(_ucActorAdd);
        }

        private async void btnActorDelete_Click(object sender, EventArgs e)
        {
            await ShowActorDelete();
        }
        private async Task ShowActorDelete()
        {
            ChangeUserControl(_ucActorDelete);
            await _ucActorDelete.VerileriYukle();
        }

        private async void btnActorUpdate_Click(object sender, EventArgs e)
        {
            await ShowActorUpdate();
        }
        private async Task ShowActorUpdate()
        {
            ChangeUserControl(_ucActorUpdate);
            await _ucActorUpdate.VerileriYukle();
        }

        private void btnDirectors_Click(object sender, EventArgs e)
        {
            UserControlPanel.Visible = true;
            ChangePanelVisibility(true, pnlDirectors);
            ChangePanelVisibility(false, pnlFilms, pnlUser, pnlSession, pnlActors);
            ChangeButtonColor(Color.FromArgb(59, 193, 168), btnDirectors);
            ChangeButtonColor(Color.FromArgb(36, 158, 148), btnFilms, btnUser, btnSessions, btnActors);
        }

        private async void btnDirectorList_Click(object sender, EventArgs e)
        {
            await ShowDirectorList();
        }
        private async Task ShowDirectorList()
        {
            _ucList.entityEnum = EntityEnum.Yonetmen;
            ChangeUserControl(_ucList);
            await _ucList.VerileriYukle();
        }

        private void btnDirectorAdd_Click(object sender, EventArgs e)
        {
            ShowDirectorAdd();
        }
        private void ShowDirectorAdd()
        {
            ChangeUserControl(_ucDirectorAdd);
        }

        private async void btnDirectorDelete_Click(object sender, EventArgs e)
        {
            await ShowDirectorDelete();
        }
        private async Task ShowDirectorDelete()
        {
            ChangeUserControl(_ucDirectorDelete);
            await _ucDirectorDelete.VerileriYukle();
        }

        private async void btnDirectorUpdate_Click(object sender, EventArgs e)
        {
            await ShowDirectorUpdate();
        }
        private async Task ShowDirectorUpdate()
        {
            ChangeUserControl(_ucDirectorUpdate);
            await _ucDirectorUpdate.VerileriYukle();
        }
    }
}
