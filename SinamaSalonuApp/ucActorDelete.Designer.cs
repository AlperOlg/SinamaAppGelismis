namespace SinamaSalonuApp
{
    partial class ucActorDelete
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
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            dtpBirthDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtSurname = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtName = new Guna.UI2.WinForms.Guna2TextBox();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbSelectActor = new Guna.UI2.WinForms.Guna2ComboBox();
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
            btnDelete.Location = new Point(430, 439);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDelete.Size = new Size(180, 45);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Sil";
            btnDelete.Click += btnDelete_Click;
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel3.Location = new Point(198, 330);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(226, 32);
            guna2HtmlLabel3.TabIndex = 37;
            guna2HtmlLabel3.Text = "Oyuncu Doğum Tarihi:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Checked = true;
            dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpBirthDate.CustomizableEdges = customizableEdges3;
            dtpBirthDate.Enabled = false;
            dtpBirthDate.FillColor = Color.White;
            dtpBirthDate.Font = new Font("Segoe UI", 20F);
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(430, 330);
            dtpBirthDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpBirthDate.Size = new Size(200, 36);
            dtpBirthDate.TabIndex = 36;
            dtpBirthDate.Value = new DateTime(2026, 4, 19, 0, 0, 0, 0);
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel2.Location = new Point(267, 248);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(157, 32);
            guna2HtmlLabel2.TabIndex = 35;
            guna2HtmlLabel2.Text = "Oyuncu Soyadı:";
            // 
            // txtSurname
            // 
            txtSurname.BorderThickness = 2;
            txtSurname.CustomizableEdges = customizableEdges5;
            txtSurname.DefaultText = "";
            txtSurname.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSurname.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSurname.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSurname.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Font = new Font("Segoe UI", 9F);
            txtSurname.ForeColor = Color.Black;
            txtSurname.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSurname.Location = new Point(430, 244);
            txtSurname.Name = "txtSurname";
            txtSurname.PlaceholderText = "";
            txtSurname.ReadOnly = true;
            txtSurname.SelectedText = "";
            txtSurname.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSurname.Size = new Size(200, 36);
            txtSurname.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel1.Location = new Point(299, 160);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(125, 32);
            guna2HtmlLabel1.TabIndex = 33;
            guna2HtmlLabel1.Text = "Oyuncu Adı:";
            // 
            // txtName
            // 
            txtName.BorderThickness = 2;
            txtName.CustomizableEdges = customizableEdges7;
            txtName.DefaultText = "";
            txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Font = new Font("Segoe UI", 9F);
            txtName.ForeColor = Color.Black;
            txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtName.Location = new Point(430, 156);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "";
            txtName.ReadOnly = true;
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtName.Size = new Size(200, 36);
            txtName.TabIndex = 32;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel4.Location = new Point(246, 66);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(178, 32);
            guna2HtmlLabel4.TabIndex = 39;
            guna2HtmlLabel4.Text = "Silinecek Oyuncu:";
            // 
            // cbSelectActor
            // 
            cbSelectActor.BackColor = Color.Transparent;
            cbSelectActor.CustomizableEdges = customizableEdges9;
            cbSelectActor.DrawMode = DrawMode.OwnerDrawFixed;
            cbSelectActor.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectActor.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSelectActor.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSelectActor.Font = new Font("Segoe UI", 10F);
            cbSelectActor.ForeColor = Color.FromArgb(68, 88, 112);
            cbSelectActor.ItemHeight = 30;
            cbSelectActor.Location = new Point(430, 66);
            cbSelectActor.Name = "cbSelectActor";
            cbSelectActor.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbSelectActor.Size = new Size(200, 36);
            cbSelectActor.TabIndex = 40;
            cbSelectActor.SelectedIndexChanged += cbSelectActor_SelectedIndexChanged;
            // 
            // ucActorDelete
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbSelectActor);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(btnDelete);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(dtpBirthDate);
            Controls.Add(guna2HtmlLabel2);
            Controls.Add(txtSurname);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(txtName);
            Name = "ucActorDelete";
            Size = new Size(1016, 510);
            Load += ucActorDelete_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBirthDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2ComboBox cbSelectActor;
    }
}
