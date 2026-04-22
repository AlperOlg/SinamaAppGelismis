namespace SinamaSalonuApp
{
    partial class ucDeleteFilm
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
            cbSelectFilm = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // cbSelectFilm
            // 
            cbSelectFilm.BackColor = Color.Transparent;
            cbSelectFilm.BorderThickness = 2;
            cbSelectFilm.CustomizableEdges = customizableEdges1;
            cbSelectFilm.DrawMode = DrawMode.OwnerDrawFixed;
            cbSelectFilm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSelectFilm.FocusedColor = Color.FromArgb(94, 148, 255);
            cbSelectFilm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbSelectFilm.Font = new Font("Segoe UI", 10F);
            cbSelectFilm.ForeColor = Color.Black;
            cbSelectFilm.ItemHeight = 30;
            cbSelectFilm.Location = new Point(359, 148);
            cbSelectFilm.Name = "cbSelectFilm";
            cbSelectFilm.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cbSelectFilm.Size = new Size(200, 36);
            cbSelectFilm.TabIndex = 26;
            // 
            // guna2HtmlLabel6
            // 
            guna2HtmlLabel6.BackColor = Color.Transparent;
            guna2HtmlLabel6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            guna2HtmlLabel6.Location = new Point(97, 152);
            guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            guna2HtmlLabel6.Size = new Size(241, 32);
            guna2HtmlLabel6.TabIndex = 25;
            guna2HtmlLabel6.Text = "Sileceğiniz Filmi Seçiniz:";
            // 
            // btnDelete
            // 
            btnDelete.CustomizableEdges = customizableEdges3;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.FromArgb(9, 99, 126);
            btnDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(379, 341);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDelete.Size = new Size(180, 45);
            btnDelete.TabIndex = 27;
            btnDelete.Text = "Sil";
            btnDelete.Click += btnDelete_Click;
            // 
            // ucDeleteFilm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(cbSelectFilm);
            Controls.Add(guna2HtmlLabel6);
            Name = "ucDeleteFilm";
            Size = new Size(967, 586);
            Load += ucDeleteFilm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbSelectFilm;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
    }
}
