namespace Hastane_Uygulamasi
{
    partial class frm_Doktor_Bilgi_Güncelleme
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
            this.btn_gnclle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.txtbx_soyad = new System.Windows.Forms.TextBox();
            this.msk_tcno = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_brans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Harlow Solid Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 34);
            this.label7.TabIndex = 49;
            this.label7.Text = "  Doktor Bilgi Güncelleme Paneli";
            // 
            // btn_gnclle
            // 
            this.btn_gnclle.BackColor = System.Drawing.Color.Lime;
            this.btn_gnclle.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_gnclle.Location = new System.Drawing.Point(165, 296);
            this.btn_gnclle.Name = "btn_gnclle";
            this.btn_gnclle.Size = new System.Drawing.Size(118, 42);
            this.btn_gnclle.TabIndex = 46;
            this.btn_gnclle.Text = "Güncelle";
            this.btn_gnclle.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(108, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(105, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 19);
            this.label1.TabIndex = 42;
            this.label1.Text = "Ad:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(165, 218);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(118, 20);
            this.txt_sifre.TabIndex = 4;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(165, 97);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(118, 20);
            this.txt_ad.TabIndex = 1;
            // 
            // txtbx_soyad
            // 
            this.txtbx_soyad.Location = new System.Drawing.Point(165, 134);
            this.txtbx_soyad.Name = "txtbx_soyad";
            this.txtbx_soyad.Size = new System.Drawing.Size(118, 20);
            this.txtbx_soyad.TabIndex = 2;
            // 
            // msk_tcno
            // 
            this.msk_tcno.Location = new System.Drawing.Point(165, 179);
            this.msk_tcno.Mask = "00000000000";
            this.msk_tcno.Name = "msk_tcno";
            this.msk_tcno.Size = new System.Drawing.Size(118, 20);
            this.msk_tcno.TabIndex = 3;
            this.msk_tcno.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(116, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 37;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(109, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tc No:";
            // 
            // comboBox_brans
            // 
            this.comboBox_brans.FormattingEnabled = true;
            this.comboBox_brans.Location = new System.Drawing.Point(165, 256);
            this.comboBox_brans.Name = "comboBox_brans";
            this.comboBox_brans.Size = new System.Drawing.Size(118, 21);
            this.comboBox_brans.TabIndex = 5;
            // 
            // frm_Doktor_Bilgi_Güncelleme
            // 
            this.AcceptButton = this.btn_gnclle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(459, 352);
            this.Controls.Add(this.comboBox_brans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_gnclle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.txtbx_soyad);
            this.Controls.Add(this.msk_tcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_Doktor_Bilgi_Güncelleme";
            this.Text = "Doktor_Bilgi_Güncelleme";
            this.Load += new System.EventHandler(this.frm_Doktor_Bilgi_Güncelleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_gnclle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.TextBox txtbx_soyad;
        private System.Windows.Forms.MaskedTextBox msk_tcno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_brans;
    }
}