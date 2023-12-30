namespace Hastane_Uygulamasi
{
    partial class frm_Doktor_Detay
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
            this.groupBox_dktor_bilgi = new System.Windows.Forms.GroupBox();
            this.lbl_isim_deger = new System.Windows.Forms.Label();
            this.lbltc_deger = new System.Windows.Forms.Label();
            this.lbl_adsoy_deger = new System.Windows.Forms.Label();
            this.lbl_tc_deger = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox_randevular = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_randevu_dty = new System.Windows.Forms.GroupBox();
            this.richTextBox_randevu_dty = new System.Windows.Forms.RichTextBox();
            this.groupBox_hizli_erisim = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_dyrular = new System.Windows.Forms.Button();
            this.btn_blgi_dznle = new System.Windows.Forms.Button();
            this.groupBox_dktor_bilgi.SuspendLayout();
            this.groupBox_randevular.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_randevu_dty.SuspendLayout();
            this.groupBox_hizli_erisim.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_dktor_bilgi
            // 
            this.groupBox_dktor_bilgi.Controls.Add(this.lbl_isim_deger);
            this.groupBox_dktor_bilgi.Controls.Add(this.lbltc_deger);
            this.groupBox_dktor_bilgi.Controls.Add(this.lbl_adsoy_deger);
            this.groupBox_dktor_bilgi.Controls.Add(this.lbl_tc_deger);
            this.groupBox_dktor_bilgi.Controls.Add(this.lbl_adsoyad);
            this.groupBox_dktor_bilgi.Controls.Add(this.lbl_tc);
            this.groupBox_dktor_bilgi.Location = new System.Drawing.Point(0, 0);
            this.groupBox_dktor_bilgi.Name = "groupBox_dktor_bilgi";
            this.groupBox_dktor_bilgi.Size = new System.Drawing.Size(219, 102);
            this.groupBox_dktor_bilgi.TabIndex = 0;
            this.groupBox_dktor_bilgi.TabStop = false;
            this.groupBox_dktor_bilgi.Text = "Doktor Bilgi Ekranı";
            // 
            // lbl_isim_deger
            // 
            this.lbl_isim_deger.AutoSize = true;
            this.lbl_isim_deger.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isim_deger.Location = new System.Drawing.Point(110, 59);
            this.lbl_isim_deger.Name = "lbl_isim_deger";
            this.lbl_isim_deger.Size = new System.Drawing.Size(59, 18);
            this.lbl_isim_deger.TabIndex = 13;
            this.lbl_isim_deger.Text = "Null Null";
            // 
            // lbltc_deger
            // 
            this.lbltc_deger.AutoSize = true;
            this.lbltc_deger.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltc_deger.Location = new System.Drawing.Point(105, 26);
            this.lbltc_deger.Name = "lbltc_deger";
            this.lbltc_deger.Size = new System.Drawing.Size(96, 18);
            this.lbltc_deger.TabIndex = 12;
            this.lbltc_deger.Text = "00000000000";
            // 
            // lbl_adsoy_deger
            // 
            this.lbl_adsoy_deger.AutoSize = true;
            this.lbl_adsoy_deger.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adsoy_deger.Location = new System.Drawing.Point(125, 59);
            this.lbl_adsoy_deger.Name = "lbl_adsoy_deger";
            this.lbl_adsoy_deger.Size = new System.Drawing.Size(0, 18);
            this.lbl_adsoy_deger.TabIndex = 11;
            // 
            // lbl_tc_deger
            // 
            this.lbl_tc_deger.AutoSize = true;
            this.lbl_tc_deger.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc_deger.Location = new System.Drawing.Point(125, 26);
            this.lbl_tc_deger.Name = "lbl_tc_deger";
            this.lbl_tc_deger.Size = new System.Drawing.Size(0, 18);
            this.lbl_tc_deger.TabIndex = 10;
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adsoyad.Location = new System.Drawing.Point(39, 59);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(72, 18);
            this.lbl_adsoyad.TabIndex = 9;
            this.lbl_adsoyad.Text = "Ad/Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tc.Location = new System.Drawing.Point(64, 26);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(47, 18);
            this.lbl_tc.TabIndex = 8;
            this.lbl_tc.Text = "Tc No:";
            // 
            // groupBox_randevular
            // 
            this.groupBox_randevular.Controls.Add(this.dataGridView1);
            this.groupBox_randevular.Location = new System.Drawing.Point(225, 0);
            this.groupBox_randevular.Name = "groupBox_randevular";
            this.groupBox_randevular.Size = new System.Drawing.Size(380, 339);
            this.groupBox_randevular.TabIndex = 1;
            this.groupBox_randevular.TabStop = false;
            this.groupBox_randevular.Text = "Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(374, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox_randevu_dty
            // 
            this.groupBox_randevu_dty.Controls.Add(this.richTextBox_randevu_dty);
            this.groupBox_randevu_dty.Location = new System.Drawing.Point(0, 108);
            this.groupBox_randevu_dty.Name = "groupBox_randevu_dty";
            this.groupBox_randevu_dty.Size = new System.Drawing.Size(219, 139);
            this.groupBox_randevu_dty.TabIndex = 2;
            this.groupBox_randevu_dty.TabStop = false;
            this.groupBox_randevu_dty.Text = "Randevu Detay";
            // 
            // richTextBox_randevu_dty
            // 
            this.richTextBox_randevu_dty.Location = new System.Drawing.Point(3, 16);
            this.richTextBox_randevu_dty.Name = "richTextBox_randevu_dty";
            this.richTextBox_randevu_dty.Size = new System.Drawing.Size(210, 118);
            this.richTextBox_randevu_dty.TabIndex = 0;
            this.richTextBox_randevu_dty.Text = "";
            // 
            // groupBox_hizli_erisim
            // 
            this.groupBox_hizli_erisim.Controls.Add(this.btn_cikis);
            this.groupBox_hizli_erisim.Controls.Add(this.btn_dyrular);
            this.groupBox_hizli_erisim.Controls.Add(this.btn_blgi_dznle);
            this.groupBox_hizli_erisim.Location = new System.Drawing.Point(10, 248);
            this.groupBox_hizli_erisim.Name = "groupBox_hizli_erisim";
            this.groupBox_hizli_erisim.Size = new System.Drawing.Size(212, 91);
            this.groupBox_hizli_erisim.TabIndex = 3;
            this.groupBox_hizli_erisim.TabStop = false;
            this.groupBox_hizli_erisim.Text = "Hızlı Erişim";
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackColor = System.Drawing.Color.Tomato;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(57, 52);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(110, 30);
            this.btn_cikis.TabIndex = 2;
            this.btn_cikis.Text = "Çıkış Yap";
            this.btn_cikis.UseVisualStyleBackColor = false;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_dyrular
            // 
            this.btn_dyrular.Location = new System.Drawing.Point(111, 16);
            this.btn_dyrular.Name = "btn_dyrular";
            this.btn_dyrular.Size = new System.Drawing.Size(98, 30);
            this.btn_dyrular.TabIndex = 1;
            this.btn_dyrular.Text = "Duyurular";
            this.btn_dyrular.UseVisualStyleBackColor = true;
            this.btn_dyrular.Click += new System.EventHandler(this.btn_dyrular_Click);
            // 
            // btn_blgi_dznle
            // 
            this.btn_blgi_dznle.Location = new System.Drawing.Point(6, 16);
            this.btn_blgi_dznle.Name = "btn_blgi_dznle";
            this.btn_blgi_dznle.Size = new System.Drawing.Size(95, 30);
            this.btn_blgi_dznle.TabIndex = 0;
            this.btn_blgi_dznle.Text = "Bilgileri Düzenle";
            this.btn_blgi_dznle.UseVisualStyleBackColor = true;
            this.btn_blgi_dznle.Click += new System.EventHandler(this.btn_blgi_dznle_Click);
            // 
            // frm_Doktor_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(611, 342);
            this.Controls.Add(this.groupBox_hizli_erisim);
            this.Controls.Add(this.groupBox_randevu_dty);
            this.Controls.Add(this.groupBox_randevular);
            this.Controls.Add(this.groupBox_dktor_bilgi);
            this.Name = "frm_Doktor_Detay";
            this.Text = "Doktor_Detay";
            this.Load += new System.EventHandler(this.frm_Doktor_Detay_Load);
            this.groupBox_dktor_bilgi.ResumeLayout(false);
            this.groupBox_dktor_bilgi.PerformLayout();
            this.groupBox_randevular.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_randevu_dty.ResumeLayout(false);
            this.groupBox_hizli_erisim.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_dktor_bilgi;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_adsoy_deger;
        private System.Windows.Forms.Label lbl_tc_deger;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox groupBox_randevular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_randevu_dty;
        private System.Windows.Forms.RichTextBox richTextBox_randevu_dty;
        private System.Windows.Forms.GroupBox groupBox_hizli_erisim;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_dyrular;
        private System.Windows.Forms.Button btn_blgi_dznle;
        private System.Windows.Forms.Label lbl_isim_deger;
        private System.Windows.Forms.Label lbltc_deger;
    }
}