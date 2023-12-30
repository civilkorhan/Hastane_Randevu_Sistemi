namespace Hastane_Uygulamasi
{
    partial class frm_Doktor_Giris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.msk_tcno = new System.Windows.Forms.MaskedTextBox();
            this.txtbx_sifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(40, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tc No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // btn_giris
            // 
            this.btn_giris.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_giris.Location = new System.Drawing.Point(111, 161);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(101, 40);
            this.btn_giris.TabIndex = 13;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // msk_tcno
            // 
            this.msk_tcno.Location = new System.Drawing.Point(112, 84);
            this.msk_tcno.Mask = "00000000000";
            this.msk_tcno.Name = "msk_tcno";
            this.msk_tcno.Size = new System.Drawing.Size(100, 26);
            this.msk_tcno.TabIndex = 11;
            this.msk_tcno.ValidatingType = typeof(int);
            // 
            // txtbx_sifre
            // 
            this.txtbx_sifre.Location = new System.Drawing.Point(112, 123);
            this.txtbx_sifre.Name = "txtbx_sifre";
            this.txtbx_sifre.Size = new System.Drawing.Size(100, 26);
            this.txtbx_sifre.TabIndex = 12;
            this.txtbx_sifre.UseSystemPasswordChar = true;
            // 
            // frm_Doktor_Giris
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(285, 224);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.txtbx_sifre);
            this.Controls.Add(this.msk_tcno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Doktor_Giris";
            this.Text = "frm_Doktor_Giris";
            this.Load += new System.EventHandler(this.frm_Doktor_Giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.MaskedTextBox msk_tcno;
        private System.Windows.Forms.TextBox txtbx_sifre;
    }
}