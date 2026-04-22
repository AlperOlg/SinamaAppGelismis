namespace SinamaSalonuApp
{
    partial class ucKasa
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblKoltuk = new System.Windows.Forms.Label();
            this.lblSeans = new System.Windows.Forms.Label();
            this.lblSalon = new System.Windows.Forms.Label();
            this.lblFilm = new System.Windows.Forms.Label();
            this.btnOde = new Guna.UI2.WinForms.Guna2Button();
            this.btnVazgec = new Guna.UI2.WinForms.Guna2Button();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(262, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ÖDEME EKRANI";
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.pnlInfo.BorderRadius = 15;
            this.pnlInfo.Controls.Add(this.lblFiyat);
            this.pnlInfo.Controls.Add(this.lblKoltuk);
            this.pnlInfo.Controls.Add(this.lblSeans);
            this.pnlInfo.Controls.Add(this.lblSalon);
            this.pnlInfo.Controls.Add(this.lblFilm);
            this.pnlInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(38)))));
            this.pnlInfo.Location = new System.Drawing.Point(40, 90);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(500, 300);
            this.pnlInfo.TabIndex = 1;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFiyat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(121)))), ((int)(((byte)(198)))));
            this.lblFiyat.Location = new System.Drawing.Point(20, 240);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(155, 32);
            this.lblFiyat.TabIndex = 4;
            this.lblFiyat.Text = "Tutar: 0.00 TL";
            // 
            // lblKoltuk
            // 
            this.lblKoltuk.AutoSize = true;
            this.lblKoltuk.BackColor = System.Drawing.Color.Transparent;
            this.lblKoltuk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKoltuk.ForeColor = System.Drawing.Color.White;
            this.lblKoltuk.Location = new System.Drawing.Point(20, 180);
            this.lblKoltuk.Name = "lblKoltuk";
            this.lblKoltuk.Size = new System.Drawing.Size(123, 21);
            this.lblKoltuk.TabIndex = 3;
            this.lblKoltuk.Text = "Koltuk Seçilmedi";
            // 
            // lblSeans
            // 
            this.lblSeans.AutoSize = true;
            this.lblSeans.BackColor = System.Drawing.Color.Transparent;
            this.lblSeans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeans.ForeColor = System.Drawing.Color.White;
            this.lblSeans.Location = new System.Drawing.Point(20, 130);
            this.lblSeans.Name = "lblSeans";
            this.lblSeans.Size = new System.Drawing.Size(121, 21);
            this.lblSeans.TabIndex = 2;
            this.lblSeans.Text = "Seans Seçilmedi";
            // 
            // lblSalon
            // 
            this.lblSalon.AutoSize = true;
            this.lblSalon.BackColor = System.Drawing.Color.Transparent;
            this.lblSalon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalon.ForeColor = System.Drawing.Color.White;
            this.lblSalon.Location = new System.Drawing.Point(20, 80);
            this.lblSalon.Name = "lblSalon";
            this.lblSalon.Size = new System.Drawing.Size(119, 21);
            this.lblSalon.TabIndex = 1;
            this.lblSalon.Text = "Salon Seçilmedi";
            // 
            // lblFilm
            // 
            this.lblFilm.AutoSize = true;
            this.lblFilm.BackColor = System.Drawing.Color.Transparent;
            this.lblFilm.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFilm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.lblFilm.Location = new System.Drawing.Point(20, 25);
            this.lblFilm.Name = "lblFilm";
            this.lblFilm.Size = new System.Drawing.Size(107, 30);
            this.lblFilm.TabIndex = 0;
            this.lblFilm.Text = "Film Adı";
            // 
            // btnOde
            // 
            this.btnOde.BorderRadius = 10;
            this.btnOde.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnOde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.btnOde.Location = new System.Drawing.Point(340, 420);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(200, 50);
            this.btnOde.TabIndex = 2;
            this.btnOde.Text = "ÖDE";
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnVazgec
            // 
            this.btnVazgec.BorderRadius = 10;
            this.btnVazgec.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnVazgec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVazgec.ForeColor = System.Drawing.Color.White;
            this.btnVazgec.Location = new System.Drawing.Point(40, 420);
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(200, 50);
            this.btnVazgec.TabIndex = 3;
            this.btnVazgec.Text = "VAZGEÇ";
            this.btnVazgec.Click += new System.EventHandler(this.btnVazgec_Click);
            // 
            // ucKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.Controls.Add(this.btnVazgec);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.lblTitle);
            this.Name = "ucKasa";
            this.Size = new System.Drawing.Size(600, 500);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Guna.UI2.WinForms.Guna2Panel pnlInfo;
        private System.Windows.Forms.Label lblFilm;
        private System.Windows.Forms.Label lblSalon;
        private System.Windows.Forms.Label lblSeans;
        private System.Windows.Forms.Label lblKoltuk;
        private System.Windows.Forms.Label lblFiyat;
        private Guna.UI2.WinForms.Guna2Button btnOde;
        private Guna.UI2.WinForms.Guna2Button btnVazgec;
    }
}
