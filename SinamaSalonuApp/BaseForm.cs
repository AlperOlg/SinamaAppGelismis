using Guna.UI2.WinForms;
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
    public partial class BaseForm : Form
    {
        public Guna2Button _btnClose;
        public Guna2Button _btnMaxAndMin;
        public Guna2Button _btnMinimize;
        public BaseForm()
        {
            InitializeComponent();
        }
        private void BaseForm_Load(object sender, EventArgs e)
        {
           
        }
        protected void InitButtons()
        {
            _btnClose.Click += new EventHandler(btnCloseClick);
            _btnMaxAndMin.Click += new EventHandler(btnMaxAndMinClick);
            _btnMinimize.Click += new EventHandler(MinimizeWindow);
            this.SizeChanged += new EventHandler(SizeChange);
        }
        private void btnCloseClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Uygulamadan Çıkılıyor", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { Environment.Exit(0); }
        }
        private void btnMaxAndMinClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        private void SizeChange(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                _btnMaxAndMin.Image = Properties.Resources.icons8_Min;
            }
            else
            {
                _btnMaxAndMin.Image = Properties.Resources.icons8_Max;
            }
        }
        private void MinimizeWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       
    }
}
