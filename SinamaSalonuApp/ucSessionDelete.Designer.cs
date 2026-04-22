namespace SinamaSalonuApp
{
    partial class ucSessionDelete
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbSelectSession = new Guna.UI2.WinForms.Guna2ComboBox();
            cbFilm = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpSessionTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbAuditorium = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblPrice = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.CustomizableEdges = customizableEdges1;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(9, 99, 126);
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(424, 441);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(180, 45);
            btnDelete.TabIndex = 30;
            btnDelete.Text = "Sil";
            btnDelete.Click += btnDelete_Click;
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel6.Location = new Point(162, 73);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(255, 32);
            guna2HtmlLabel6.TabIndex = 28;
            guna2HtmlLabel6.Text = "Sileceğiniz Seansı Seçiniz:";
            // 
            // cbSelectSession
            // 
            cbSelectSession.BackColor = Color.Transparent;
            cbSelectSession.BorderThickness = 2;
            cbSelectSession.CustomizableEdges = customizableEdges3;
            cbSelectSession.DrawMode = DrawMode.OwnerDrawFixed;
            cbSelectSession.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectSession.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSelectSession.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSelectSession.Font = new Font("Segoe UI", 10F);
            cbSelectSession.ForeColor = Color.Black;
            cbSelectSession.ItemHeight = 30;
            cbSelectSession.Location = new Point(424, 71);
            cbSelectSession.Name = "cbSelectSession";
            cbSelectSession.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbSelectSession.Size = new Size(200, 36);
            cbSelectSession.TabIndex = 29;
            cbSelectSession.SelectedIndexChanged += cbSelectSession_SelectedIndexChanged;
            // 
            // cbFilm
            // 
            cbFilm.BackColor = Color.Transparent;
            cbFilm.BorderThickness = 2;
            cbFilm.CustomizableEdges = customizableEdges5;
            cbFilm.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilm.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilm.Font = new Font("Segoe UI", 10F);
            cbFilm.ForeColor = Color.Black;
            cbFilm.ItemHeight = 30;
            cbFilm.Location = new Point(424, 242);
            cbFilm.Name = "cbFilm";
            cbFilm.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbFilm.Size = new Size(200, 36);
            cbFilm.TabIndex = 33;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel2.Location = new Point(288, 321);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(127, 32);
            guna2HtmlLabel2.TabIndex = 32;
            guna2HtmlLabel2.Text = "Seans Tarihi:";
            // 
            // dtpSessionTime
            // 
            dtpSessionTime.Checked = true;
            dtpSessionTime.CustomFormat = "dd.MM.yyyy HH:mm";
            dtpSessionTime.CustomizableEdges = customizableEdges7;
            dtpSessionTime.FillColor = Color.White;
            dtpSessionTime.Font = new Font("Segoe UI", 20F);
            dtpSessionTime.Format = DateTimePickerFormat.Custom;
            dtpSessionTime.Location = new Point(424, 321);
            dtpSessionTime.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpSessionTime.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpSessionTime.Name = "dtpSessionTime";
            dtpSessionTime.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpSessionTime.Size = new Size(267, 36);
            dtpSessionTime.TabIndex = 34;
            dtpSessionTime.Value = new DateTime(2026, 4, 19, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel3.Location = new Point(164, 243);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(253, 32);
            guna2HtmlLabel3.TabIndex = 35;
            guna2HtmlLabel3.Text = "Seansta gösterilecek film:";
            // 
            // cbAuditorium
            // 
            cbAuditorium.BackColor = Color.Transparent;
            cbAuditorium.BorderThickness = 2;
            cbAuditorium.CustomizableEdges = customizableEdges9;
            cbAuditorium.DrawMode = DrawMode.OwnerDrawFixed;
            cbAuditorium.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAuditorium.FocusedColor = Color.FromArgb(94, 148, 255);
            cbAuditorium.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbAuditorium.Font = new Font("Segoe UI", 10F);
            cbAuditorium.ForeColor = Color.Black;
            cbAuditorium.ItemHeight = 30;
            cbAuditorium.Location = new Point(424, 185);
            cbAuditorium.Name = "cbAuditorium";
            cbAuditorium.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbAuditorium.Size = new Size(200, 36);
            cbAuditorium.TabIndex = 37;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel4.Location = new Point(61, 185);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(354, 32);
            guna2HtmlLabel4.TabIndex = 36;
            guna2HtmlLabel4.Text = "Seansın bulunduğu salon numarası:";
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.Location = new Point(272, 129);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(143, 32);
            guna2HtmlLabel1.TabIndex = 39;
            guna2HtmlLabel1.Text = "Seansın Fiyatı:";
            // 
            // lblPrice
            // 
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPrice.Location = new Point(439, 129);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(47, 32);
            lblPrice.TabIndex = 41;
            lblPrice.Text = "fiyat";
            // 
            // ucSessionDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblPrice);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(cbAuditorium);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(dtpSessionTime);
            Controls.Add(cbFilm);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(btnDelete);
            Controls.Add(cbSelectSession);
            Controls.Add(guna2HtmlLabel6);
            Name = "ucSessionDelete";
            Size = new Size(967, 586);
            Load += ucSessionDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelectSession;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilm;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpSessionTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2ComboBox cbAuditorium;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPrice;
    }
}
