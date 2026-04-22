namespace SinamaSalonuApp
{
    partial class ucBiletAl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlSeats = new FlowLayoutPanel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblSessionInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRezerveEt = new Guna.UI2.WinForms.Guna2Button();
            lblSelectedSeat = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnBack = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // pnlSeats
            // 
            pnlSeats.AutoScroll = true;
            pnlSeats.Location = new Point(20, 80);
            pnlSeats.Name = "pnlSeats";
            pnlSeats.Size = new Size(1200, 350);
            pnlSeats.TabIndex = 0;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(9, 99, 126);
            guna2HtmlLabel1.Location = new Point(20, 15);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(179, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Koltuk Seçimi";
            // 
            // lblSessionInfo
            // 
            lblSessionInfo.BackColor = Color.Transparent;
            lblSessionInfo.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 162);
            lblSessionInfo.Location = new Point(20, 54);
            lblSessionInfo.Name = "lblSessionInfo";
            lblSessionInfo.Size = new Size(96, 23);
            lblSessionInfo.TabIndex = 2;
            lblSessionInfo.Text = "Seans Bilgisi...";
            // 
            // btnRezerveEt
            // 
            btnRezerveEt.CustomizableEdges = customizableEdges1;
            btnRezerveEt.DisabledState.BorderColor = Color.DarkGray;
            btnRezerveEt.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRezerveEt.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRezerveEt.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRezerveEt.FillColor = Color.FromArgb(36, 158, 148);
            btnRezerveEt.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRezerveEt.ForeColor = Color.White;
            btnRezerveEt.Location = new Point(1020, 450);
            btnRezerveEt.Name = "btnRezerveEt";
            btnRezerveEt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRezerveEt.Size = new Size(200, 50);
            btnRezerveEt.TabIndex = 3;
            btnRezerveEt.Text = "Rezervasyon Yap";
            btnRezerveEt.Visible = false;
            btnRezerveEt.Click += btnRezerveEt_Click;
            // 
            // lblSelectedSeat
            // 
            lblSelectedSeat.BackColor = Color.Transparent;
            lblSelectedSeat.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSelectedSeat.Location = new Point(20, 460);
            lblSelectedSeat.Name = "lblSelectedSeat";
            lblSelectedSeat.Size = new Size(147, 27);
            lblSelectedSeat.TabIndex = 4;
            lblSelectedSeat.Text = "Seçilen Koltuk: -";
            // 
            // btnBack
            // 
            btnBack.CustomizableEdges = customizableEdges3;
            btnBack.DisabledState.BorderColor = Color.DarkGray;
            btnBack.DisabledState.CustomBorderColor = Color.DarkGray;
            btnBack.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnBack.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnBack.FillColor = Color.Transparent;
            btnBack.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(9, 99, 126);
            btnBack.Location = new Point(1120, 15);
            btnBack.Name = "btnBack";
            btnBack.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnBack.Size = new Size(100, 40);
            btnBack.TabIndex = 5;
            btnBack.Text = "Geri Dön";
            btnBack.Click += btnBack_Click;
            // 
            // ucBiletAl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 246);
            Controls.Add(btnBack);
            Controls.Add(lblSelectedSeat);
            Controls.Add(btnRezerveEt);
            Controls.Add(lblSessionInfo);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(pnlSeats);
            Name = "ucBiletAl";
            Size = new Size(1254, 525);
            ResumeLayout(false);
            PerformLayout();
        }

        private FlowLayoutPanel pnlSeats;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSessionInfo;
        private Guna.UI2.WinForms.Guna2Button btnRezerveEt;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSelectedSeat;
        private Guna.UI2.WinForms.Guna2Button btnBack;
    }
}
