namespace SinamaSalonuApp
{
    partial class ucSeansList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvSeanslar = new Guna.UI2.WinForms.Guna2DataGridView();
            ID = new DataGridViewTextBoxColumn();
            FilmAd = new DataGridViewTextBoxColumn();
            SalonNo = new DataGridViewTextBoxColumn();
            SeansSaati = new DataGridViewTextBoxColumn();
            BiletAl = new DataGridViewButtonColumn();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvSeanslar).BeginInit();
            SuspendLayout();
            // 
            // dgvSeanslar
            // 
            dgvSeanslar.AllowUserToAddRows = false;
            dgvSeanslar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSeanslar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSeanslar.BackgroundColor = Color.FromArgb(235, 244, 246);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(9, 99, 126);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSeanslar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSeanslar.ColumnHeadersHeight = 40;
            dgvSeanslar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSeanslar.Columns.AddRange(new DataGridViewColumn[] { ID, FilmAd, SalonNo, SeansSaati, BiletAl });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSeanslar.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSeanslar.GridColor = Color.FromArgb(231, 229, 255);
            dgvSeanslar.Location = new Point(20, 70);
            dgvSeanslar.Name = "dgvSeanslar";
            dgvSeanslar.ReadOnly = true;
            dgvSeanslar.RowHeadersVisible = false;
            dgvSeanslar.Size = new Size(1200, 420);
            dgvSeanslar.TabIndex = 0;
            dgvSeanslar.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvSeanslar.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvSeanslar.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvSeanslar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvSeanslar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvSeanslar.ThemeStyle.BackColor = Color.FromArgb(235, 244, 246);
            dgvSeanslar.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvSeanslar.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(9, 99, 126);
            dgvSeanslar.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvSeanslar.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            dgvSeanslar.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvSeanslar.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvSeanslar.ThemeStyle.HeaderStyle.Height = 40;
            dgvSeanslar.ThemeStyle.ReadOnly = true;
            dgvSeanslar.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvSeanslar.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvSeanslar.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10.5F);
            dgvSeanslar.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvSeanslar.ThemeStyle.RowsStyle.Height = 25;
            dgvSeanslar.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvSeanslar.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvSeanslar.CellContentClick += dgvSeanslar_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Visible = false;
            // 
            // FilmAd
            // 
            FilmAd.HeaderText = "Film Adı";
            FilmAd.Name = "FilmAd";
            FilmAd.ReadOnly = true;
            // 
            // SalonNo
            // 
            SalonNo.HeaderText = "Salon";
            SalonNo.Name = "SalonNo";
            SalonNo.ReadOnly = true;
            // 
            // SeansSaati
            // 
            SeansSaati.HeaderText = "Seans Saati";
            SeansSaati.Name = "SeansSaati";
            SeansSaati.ReadOnly = true;
            // 
            // BiletAl
            // 
            BiletAl.FlatStyle = FlatStyle.Flat;
            BiletAl.HeaderText = "İşlem";
            BiletAl.Name = "BiletAl";
            BiletAl.ReadOnly = true;
            BiletAl.Text = "Bilet Al";
            BiletAl.UseColumnTextForButtonValue = true;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(9, 99, 126);
            guna2HtmlLabel1.Location = new Point(20, 20);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(110, 39);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Seanslar";
            // 
            // btnRefresh
            // 
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.DisabledState.BorderColor = Color.DarkGray;
            btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRefresh.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRefresh.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRefresh.FillColor = Color.FromArgb(9, 99, 126);
            btnRefresh.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1120, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(100, 38);
            btnRefresh.TabIndex = 38;
            btnRefresh.Text = "Yenile";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ucSeansList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 244, 246);
            Controls.Add(btnRefresh);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(dgvSeanslar);
            Name = "ucSeansList";
            RightToLeft = RightToLeft.No;
            Size = new Size(1254, 525);
            Load += ucSeansList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSeanslar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Guna.UI2.WinForms.Guna2DataGridView dgvSeanslar;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FilmAd;
        private DataGridViewTextBoxColumn SalonNo;
        private DataGridViewTextBoxColumn SeansSaati;
        private DataGridViewButtonColumn BiletAl;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
