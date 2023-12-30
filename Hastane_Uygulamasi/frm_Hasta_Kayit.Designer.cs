namespace Hastane_Uygulamasi
{
    partial class frm_Hasta_Kayit
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
            this.txtbx_soyad = new System.Windows.Forms.TextBox();
            this.msk_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_kaydol = new System.Windows.Forms.Button();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.cmbo_cinsiyet = new System.Windows.Forms.ComboBox();
            this.lbl_Hasta_Kayit_Baslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_soyad
            // 
            this.txtbx_soyad.Location = new System.Drawing.Point(152, 102);
            this.txtbx_soyad.Name = "txtbx_soyad";
            this.txtbx_soyad.Size = new System.Drawing.Size(100, 20);
            this.txtbx_soyad.TabIndex = 2;
            // 
            // msk_tcno
            // 
            this.msk_tcno.Location = new System.Drawing.Point(152, 147);
            this.msk_tcno.Mask = "00000000000";
            this.msk_tcno.Name = "msk_tcno";
            this.msk_tcno.Size = new System.Drawing.Size(100, 20);
            this.msk_tcno.TabIndex = 3;
            this.msk_tcno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(103, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(96, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tc No:";
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(152, 65);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(152, 186);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_sifre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(115, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ad:";
           // this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(92, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(80, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // btn_kaydol
            // 
            this.btn_kaydol.BackColor = System.Drawing.Color.Lime;
            this.btn_kaydol.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydol.Location = new System.Drawing.Point(152, 303);
            this.btn_kaydol.Name = "btn_kaydol";
            this.btn_kaydol.Size = new System.Drawing.Size(100, 31);
            this.btn_kaydol.TabIndex = 18;
            this.btn_kaydol.Text = "Kaydol";
            this.btn_kaydol.UseVisualStyleBackColor = false;
            this.btn_kaydol.Click += new System.EventHandler(this.btn_kaydol_Click);
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(152, 226);
            this.masked_tel.Mask = "(999) 000-0000";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(100, 20);
            this.masked_tel.TabIndex = 5;
            // 
            // cmbo_cinsiyet
            // 
            this.cmbo_cinsiyet.FormattingEnabled = true;
            this.cmbo_cinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbo_cinsiyet.Location = new System.Drawing.Point(152, 263);
            this.cmbo_cinsiyet.Name = "cmbo_cinsiyet";
            this.cmbo_cinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cmbo_cinsiyet.TabIndex = 6;
            // 
            // lbl_Hasta_Kayit_Baslik
            // 
            this.lbl_Hasta_Kayit_Baslik.AutoSize = true;
            this.lbl_Hasta_Kayit_Baslik.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hasta_Kayit_Baslik.Location = new System.Drawing.Point(55, 18);
            this.lbl_Hasta_Kayit_Baslik.Name = "lbl_Hasta_Kayit_Baslik";
            this.lbl_Hasta_Kayit_Baslik.Size = new System.Drawing.Size(321, 34);
            this.lbl_Hasta_Kayit_Baslik.TabIndex = 21;
            this.lbl_Hasta_Kayit_Baslik.Text = "Yeni Hasta Kayıt Paneli";
           // this.lbl_Hasta_Kayit_Baslik.Click += new System.EventHandler(this.label7_Click);
            // 
            // frm_Hasta_Kayit
            // 
            this.AcceptButton = this.btn_kaydol;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(407, 350);
            this.Controls.Add(this.lbl_Hasta_Kayit_Baslik);
            this.Controls.Add(this.cmbo_cinsiyet);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.btn_kaydol);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txtbx_soyad);
            this.Controls.Add(this.msk_tcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_Hasta_Kayit";
            this.Text = "frm_Hasta_Kayit";
           // this.Load += new System.EventHandler(this.frm_Hasta_Kayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_soyad;
        private System.Windows.Forms.MaskedTextBox msk_tcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_kaydol;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.ComboBox cmbo_cinsiyet;
        private System.Windows.Forms.Label lbl_Hasta_Kayit_Baslik;
    }
}