namespace SinamaSalonuApp
{
    partial class ucDirectorAdd
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnAdd = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtBio = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges11;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(9, 99, 126);
            btnAdd.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(436, 402);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAdd.Size = new Size(180, 45);
            btnAdd.TabIndex = 38;
            btnAdd.Text = "Ekle";
            btnAdd.Click += btnAdd_Click;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel3.Location = new Point(179, 297);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(251, 32);
            guna2HtmlLabel3.TabIndex = 37;
            guna2HtmlLabel3.Text = "Yonetmen Doğum Tarihi:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Checked = true;
            dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpBirthDate.CustomizableEdges = customizableEdges13;
            dtpBirthDate.FillColor = Color.White;
            dtpBirthDate.Font = new Font("Segoe UI", 20F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(436, 293);
            dtpBirthDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            dtpBirthDate.Size = new Size(200, 36);
            dtpBirthDate.TabIndex = 36;
            dtpBirthDate.Value = new DateTime(2026, 4, 19, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel2.Location = new Point(248, 148);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(182, 32);
            guna2HtmlLabel2.TabIndex = 35;
            guna2HtmlLabel2.Text = "Yonetmen Soyadı:";
            // 
            // txtSurname
            // 
            txtSurname.BorderThickness = 2;
            txtSurname.CustomizableEdges = customizableEdges15;
            txtSurname.DefaultText = "";
            txtSurname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSurname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSurname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Font = new Font("Segoe UI", 9F);
            txtSurname.ForeColor = Color.Black;
            txtSurname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Location = new Point(436, 144);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "";
            txtSurname.SelectedText = "";
            txtSurname.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtSurname.Size = new Size(200, 36);
            txtSurname.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.Location = new Point(280, 65);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(150, 32);
            guna2HtmlLabel1.TabIndex = 33;
            guna2HtmlLabel1.Text = "Yonetmen Adı:";
            // 
            // txtName
            // 
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges17;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(436, 65);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtName.Size = new Size(200, 36);
            txtName.TabIndex = 32;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel4.Location = new Point(159, 223);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(265, 32);
            guna2HtmlLabel4.TabIndex = 39;
            guna2HtmlLabel4.Text = "Yonetmen Bio (opsiyonel):";
            // 
            // txtBio
            // 
            txtBio.BorderThickness = 2;
            txtBio.CustomizableEdges = customizableEdges19;
            txtBio.DefaultText = "";
            txtBio.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtBio.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtBio.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtBio.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtBio.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBio.Font = new Font("Segoe UI", 9F);
            txtBio.ForeColor = Color.Black;
            txtBio.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtBio.Location = new Point(436, 219);
            txtBio.Name = "txtBio";
            txtBio.PlaceholderText = "";
            txtBio.SelectedText = "";
            txtBio.ShadowDecoration.CustomizableEdges = customizableEdges20;
            txtBio.Size = new Size(200, 36);
            txtBio.TabIndex = 40;
            // 
            // ucDirectorAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtBio);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(btnAdd);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(dtpBirthDate);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtSurname);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtName);
            Name = "ucDirectorAdd";
            Size = new Size(1016, 510);
            Load += ucDirectorAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox txtBio;
    }
}
