namespace Hastane_Uygulamasi
{
    partial class frm_Hasta_Giris
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linklbl_uyeol = new System.Windows.Forms.LinkLabel();
            this.msk_tcno = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_sifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Forte", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.Location = new System.Drawing.Point(74, 45);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(190, 35);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Hasta Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(75, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tc No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(75, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // linklbl_uyeol
            // 
            this.linklbl_uyeol.AutoSize = true;
            this.linklbl_uyeol.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linklbl_uyeol.Location = new System.Drawing.Point(259, 119);
            this.linklbl_uyeol.Name = "linklbl_uyeol";
            this.linklbl_uyeol.Size = new System.Drawing.Size(67, 24);
            this.linklbl_uyeol.TabIndex = 3;
            this.linklbl_uyeol.TabStop = true;
            this.linklbl_uyeol.Text = "Üye Ol";
            this.linklbl_uyeol.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbl_uyeol_LinkClicked);
            // 
            // msk_tcno
            // 
            this.msk_tcno.Location = new System.Drawing.Point(140, 98);
            this.msk_tcno.Name = "msk_tcno";
            this.msk_tcno.Size = new System.Drawing.Size(100, 20);
            this.msk_tcno.TabIndex = 1;
            this.msk_tcno.ValidatingType = typeof(int);
            // 
            // txtbx_sifre
            // 
            this.txtbx_sifre.Location = new System.Drawing.Point(140, 137);
            this.txtbx_sifre.Name = "txtbx_sifre";
            this.txtbx_sifre.Size = new System.Drawing.Size(100, 20);
            this.txtbx_sifre.TabIndex = 2;
            this.txtbx_sifre.UseSystemPasswordChar = true;
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(139, 175);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(101, 40);
            this.btn_giris.TabIndex = 6;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // frm_Hasta_Giris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(365, 241);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txtbx_sifre);
            this.Controls.Add(this.msk_tcno);
            this.Controls.Add(this.linklbl_uyeol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_baslik);
            this.Name = "frm_Hasta_Giris";
            this.Text = "Hasta Giris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lbl_baslik;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.LinkLabel linklbl_uyeol;
        public System.Windows.Forms.MaskedTextBox msk_tcno;
        public System.Windows.Forms.TextBox txtbx_sifre;
        public System.Windows.Forms.Button btn_giris;
    }
}