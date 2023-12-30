namespace Hastane_Uygulamasi
{
    partial class frm_Hasta_Bilgi_Güncelleme
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
            this.label7 = new System.Windows.Forms.Label();
            this.cmbo_cinsiyet = new System.Windows.Forms.ComboBox();
            this.masked_tel = new System.Windows.Forms.MaskedTextBox();
            this.btn_güncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txtbx_soyad = new System.Windows.Forms.TextBox();
            this.msk_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-5, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(406, 34);
            this.label7.TabIndex = 35;
            this.label7.Text = "  Hasta Bilgi Güncelleme Paneli";
            // 
            // cmbo_cinsiyet
            // 
            this.cmbo_cinsiyet.FormattingEnabled = true;
            this.cmbo_cinsiyet.Items.AddRange(new object[] {
            "Erkek ",
            "Kadın"});
            this.cmbo_cinsiyet.Location = new System.Drawing.Point(143, 276);
            this.cmbo_cinsiyet.Name = "cmbo_cinsiyet";
            this.cmbo_cinsiyet.Size = new System.Drawing.Size(100, 27);
            this.cmbo_cinsiyet.TabIndex = 6;
            // 
            // masked_tel
            // 
            this.masked_tel.Location = new System.Drawing.Point(143, 239);
            this.masked_tel.Mask = "(999) 000-0000";
            this.masked_tel.Name = "masked_tel";
            this.masked_tel.Size = new System.Drawing.Size(100, 27);
            this.masked_tel.TabIndex = 5;
            // 
            // btn_güncelle
            // 
            this.btn_güncelle.BackColor = System.Drawing.Color.Lime;
            this.btn_güncelle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_güncelle.Location = new System.Drawing.Point(143, 316);
            this.btn_güncelle.Name = "btn_güncelle";
            this.btn_güncelle.Size = new System.Drawing.Size(100, 31);
            this.btn_güncelle.TabIndex = 32;
            this.btn_güncelle.Text = "Güncelle";
            this.btn_güncelle.UseVisualStyleBackColor = false;
            this.btn_güncelle.Click += new System.EventHandler(this.btn_güncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(71, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(72, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 30;
            this.label5.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(83, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 29;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ad:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(143, 199);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 27);
            this.txt_sifre.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(143, 78);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(100, 27);
            this.txt_ad.TabIndex = 1;
            // 
            // txtbx_soyad
            // 
            this.txtbx_soyad.Location = new System.Drawing.Point(143, 115);
            this.txtbx_soyad.Name = "txtbx_soyad";
            this.txtbx_soyad.Size = new System.Drawing.Size(100, 27);
            this.txtbx_soyad.TabIndex = 2;
            // 
            // msk_tcno
            // 
            this.msk_tcno.Location = new System.Drawing.Point(143, 160);
            this.msk_tcno.Mask = "00000000000";
            this.msk_tcno.Name = "msk_tcno";
            this.msk_tcno.Size = new System.Drawing.Size(100, 27);
            this.msk_tcno.TabIndex = 3;
            this.msk_tcno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(94, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(87, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tc No:";
            // 
            // frm_Hasta_Bilgi_Güncelleme
            // 
            this.AcceptButton = this.btn_güncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(405, 361);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbo_cinsiyet);
            this.Controls.Add(this.masked_tel);
            this.Controls.Add(this.btn_güncelle);
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
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.Name = "frm_Hasta_Bilgi_Güncelleme";
            this.Text = "Hasta Bilgi_Güncelleme";
            this.Load += new System.EventHandler(this.frm_Hasta_Bilgi_Güncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbo_cinsiyet;
        private System.Windows.Forms.MaskedTextBox masked_tel;
        private System.Windows.Forms.Button btn_güncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txtbx_soyad;
        private System.Windows.Forms.MaskedTextBox msk_tcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}