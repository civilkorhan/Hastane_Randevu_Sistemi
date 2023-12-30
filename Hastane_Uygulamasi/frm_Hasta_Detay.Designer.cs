namespace Hastane_Uygulamasi
{
    partial class frm_Hasta_Detay
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
            this.groupBox_kisibilgi = new System.Windows.Forms.GroupBox();
            this.linkLbl_güncelle = new System.Windows.Forms.LinkLabel();
            this.label4_adsoyad_deger = new System.Windows.Forms.Label();
            this.label3_tcdeger = new System.Windows.Forms.Label();
            this.lbl_adsoyad = new System.Windows.Forms.Label();
            this.lbl_tc = new System.Windows.Forms.Label();
            this.groupBox_rndevu_paneli = new System.Windows.Forms.GroupBox();
            this.txtbox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox_sikayet = new System.Windows.Forms.RichTextBox();
            this.comboBox_doktor = new System.Windows.Forms.ComboBox();
            this.comboBox_brans = new System.Windows.Forms.ComboBox();
            this.lbl_doktor = new System.Windows.Forms.Label();
            this.lbl_sikayet = new System.Windows.Forms.Label();
            this.lbl_brans = new System.Windows.Forms.Label();
            this.btn_randevu_al = new System.Windows.Forms.Button();
            this.groupBox_gecmisrandevu = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_aktifrandevu = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox_kisibilgi.SuspendLayout();
            this.groupBox_rndevu_paneli.SuspendLayout();
            this.groupBox_gecmisrandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_aktifrandevu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_kisibilgi
            // 
            this.groupBox_kisibilgi.Controls.Add(this.linkLbl_güncelle);
            this.groupBox_kisibilgi.Controls.Add(this.label4_adsoyad_deger);
            this.groupBox_kisibilgi.Controls.Add(this.label3_tcdeger);
            this.groupBox_kisibilgi.Controls.Add(this.lbl_adsoyad);
            this.groupBox_kisibilgi.Controls.Add(this.lbl_tc);
            this.groupBox_kisibilgi.Location = new System.Drawing.Point(0, 0);
            this.groupBox_kisibilgi.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_kisibilgi.Name = "groupBox_kisibilgi";
            this.groupBox_kisibilgi.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_kisibilgi.Size = new System.Drawing.Size(272, 151);
            this.groupBox_kisibilgi.TabIndex = 0;
            this.groupBox_kisibilgi.TabStop = false;
            this.groupBox_kisibilgi.Text = "Kişi Bilgi";
            // 
            // linkLbl_güncelle
            // 
            this.linkLbl_güncelle.AutoSize = true;
            this.linkLbl_güncelle.Location = new System.Drawing.Point(36, 113);
            this.linkLbl_güncelle.Name = "linkLbl_güncelle";
            this.linkLbl_güncelle.Size = new System.Drawing.Size(99, 18);
            this.linkLbl_güncelle.TabIndex = 7;
            this.linkLbl_güncelle.TabStop = true;
            this.linkLbl_güncelle.Text = "Profili Güncelle";
            this.linkLbl_güncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_güncelle_LinkClicked);
            // 
            // label4_adsoyad_deger
            // 
            this.label4_adsoyad_deger.AutoSize = true;
            this.label4_adsoyad_deger.Location = new System.Drawing.Point(124, 82);
            this.label4_adsoyad_deger.Name = "label4_adsoyad_deger";
            this.label4_adsoyad_deger.Size = new System.Drawing.Size(59, 18);
            this.label4_adsoyad_deger.TabIndex = 3;
            this.label4_adsoyad_deger.Text = "Null Null";
            // 
            // label3_tcdeger
            // 
            this.label3_tcdeger.AutoSize = true;
            this.label3_tcdeger.Location = new System.Drawing.Point(124, 49);
            this.label3_tcdeger.Name = "label3_tcdeger";
            this.label3_tcdeger.Size = new System.Drawing.Size(85, 18);
            this.label3_tcdeger.TabIndex = 2;
            this.label3_tcdeger.Text = "___________";
            // 
            // lbl_adsoyad
            // 
            this.lbl_adsoyad.AutoSize = true;
            this.lbl_adsoyad.Location = new System.Drawing.Point(38, 82);
            this.lbl_adsoyad.Name = "lbl_adsoyad";
            this.lbl_adsoyad.Size = new System.Drawing.Size(72, 18);
            this.lbl_adsoyad.TabIndex = 1;
            this.lbl_adsoyad.Text = "Ad/Soyad:";
            // 
            // lbl_tc
            // 
            this.lbl_tc.AutoSize = true;
            this.lbl_tc.Location = new System.Drawing.Point(63, 49);
            this.lbl_tc.Name = "lbl_tc";
            this.lbl_tc.Size = new System.Drawing.Size(47, 18);
            this.lbl_tc.TabIndex = 0;
            this.lbl_tc.Text = "Tc No:";
            // 
            // groupBox_rndevu_paneli
            // 
            this.groupBox_rndevu_paneli.Controls.Add(this.txtbox_id);
            this.groupBox_rndevu_paneli.Controls.Add(this.label1);
            this.groupBox_rndevu_paneli.Controls.Add(this.richTextBox_sikayet);
            this.groupBox_rndevu_paneli.Controls.Add(this.comboBox_doktor);
            this.groupBox_rndevu_paneli.Controls.Add(this.comboBox_brans);
            this.groupBox_rndevu_paneli.Controls.Add(this.lbl_doktor);
            this.groupBox_rndevu_paneli.Controls.Add(this.lbl_sikayet);
            this.groupBox_rndevu_paneli.Controls.Add(this.lbl_brans);
            this.groupBox_rndevu_paneli.Controls.Add(this.btn_randevu_al);
            this.groupBox_rndevu_paneli.Location = new System.Drawing.Point(0, 158);
            this.groupBox_rndevu_paneli.Name = "groupBox_rndevu_paneli";
            this.groupBox_rndevu_paneli.Size = new System.Drawing.Size(272, 253);
            this.groupBox_rndevu_paneli.TabIndex = 1;
            this.groupBox_rndevu_paneli.TabStop = false;
            this.groupBox_rndevu_paneli.Text = "Randevu Paneli";
            // 
            // txtbox_id
            // 
            this.txtbox_id.Enabled = false;
            this.txtbox_id.Location = new System.Drawing.Point(76, 22);
            this.txtbox_id.Name = "txtbox_id";
            this.txtbox_id.Size = new System.Drawing.Size(150, 26);
            this.txtbox_id.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "id:";
            // 
            // richTextBox_sikayet
            // 
            this.richTextBox_sikayet.Location = new System.Drawing.Point(76, 118);
            this.richTextBox_sikayet.Name = "richTextBox_sikayet";
            this.richTextBox_sikayet.Size = new System.Drawing.Size(150, 85);
            this.richTextBox_sikayet.TabIndex = 6;
            this.richTextBox_sikayet.Text = "";
            // 
            // comboBox_doktor
            // 
            this.comboBox_doktor.FormattingEnabled = true;
            this.comboBox_doktor.Location = new System.Drawing.Point(76, 86);
            this.comboBox_doktor.Name = "comboBox_doktor";
            this.comboBox_doktor.Size = new System.Drawing.Size(150, 26);
            this.comboBox_doktor.TabIndex = 5;
            this.comboBox_doktor.SelectedIndexChanged += new System.EventHandler(this.comboBox_doktor_SelectedIndexChanged);
            // 
            // comboBox_brans
            // 
            this.comboBox_brans.FormattingEnabled = true;
            this.comboBox_brans.Location = new System.Drawing.Point(76, 54);
            this.comboBox_brans.Name = "comboBox_brans";
            this.comboBox_brans.Size = new System.Drawing.Size(150, 26);
            this.comboBox_brans.TabIndex = 4;
            this.comboBox_brans.SelectedIndexChanged += new System.EventHandler(this.comboBox_brans_SelectedIndexChanged);
            // 
            // lbl_doktor
            // 
            this.lbl_doktor.AutoSize = true;
            this.lbl_doktor.Location = new System.Drawing.Point(13, 89);
            this.lbl_doktor.Name = "lbl_doktor";
            this.lbl_doktor.Size = new System.Drawing.Size(55, 18);
            this.lbl_doktor.TabIndex = 3;
            this.lbl_doktor.Text = "Doktor:";
            // 
            // lbl_sikayet
            // 
            this.lbl_sikayet.AutoSize = true;
            this.lbl_sikayet.Location = new System.Drawing.Point(12, 121);
            this.lbl_sikayet.Name = "lbl_sikayet";
            this.lbl_sikayet.Size = new System.Drawing.Size(56, 18);
            this.lbl_sikayet.TabIndex = 2;
            this.lbl_sikayet.Text = "Şikayet:";
            // 
            // lbl_brans
            // 
            this.lbl_brans.AutoSize = true;
            this.lbl_brans.Location = new System.Drawing.Point(21, 57);
            this.lbl_brans.Name = "lbl_brans";
            this.lbl_brans.Size = new System.Drawing.Size(47, 18);
            this.lbl_brans.TabIndex = 1;
            this.lbl_brans.Text = "Branş:";
            // 
            // btn_randevu_al
            // 
            this.btn_randevu_al.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_randevu_al.Location = new System.Drawing.Point(76, 209);
            this.btn_randevu_al.Name = "btn_randevu_al";
            this.btn_randevu_al.Size = new System.Drawing.Size(150, 31);
            this.btn_randevu_al.TabIndex = 0;
            this.btn_randevu_al.Text = "Randevu Al";
            this.btn_randevu_al.UseVisualStyleBackColor = false;
            this.btn_randevu_al.Click += new System.EventHandler(this.btn_randevu_al_Click);
            // 
            // groupBox_gecmisrandevu
            // 
            this.groupBox_gecmisrandevu.Controls.Add(this.dataGridView1);
            this.groupBox_gecmisrandevu.Location = new System.Drawing.Point(288, 0);
            this.groupBox_gecmisrandevu.Name = "groupBox_gecmisrandevu";
            this.groupBox_gecmisrandevu.Size = new System.Drawing.Size(329, 151);
            this.groupBox_gecmisrandevu.TabIndex = 2;
            this.groupBox_gecmisrandevu.TabStop = false;
            this.groupBox_gecmisrandevu.Text = "Geçmiş Randevular";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 126);
            this.dataGridView1.TabIndex = 3;
            // 
            // groupBox_aktifrandevu
            // 
            this.groupBox_aktifrandevu.Controls.Add(this.dataGridView2);
            this.groupBox_aktifrandevu.Location = new System.Drawing.Point(288, 158);
            this.groupBox_aktifrandevu.Name = "groupBox_aktifrandevu";
            this.groupBox_aktifrandevu.Size = new System.Drawing.Size(329, 253);
            this.groupBox_aktifrandevu.TabIndex = 2;
            this.groupBox_aktifrandevu.TabStop = false;
            this.groupBox_aktifrandevu.Text = "Aktif Randevular";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(323, 228);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frm_Hasta_Detay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(645, 430);
            this.Controls.Add(this.groupBox_aktifrandevu);
            this.Controls.Add(this.groupBox_gecmisrandevu);
            this.Controls.Add(this.groupBox_rndevu_paneli);
            this.Controls.Add(this.groupBox_kisibilgi);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Hasta_Detay";
            this.Text = "Hasta_Detay";
            this.Load += new System.EventHandler(this.frm_Hasta_Detay_Load);
            this.groupBox_kisibilgi.ResumeLayout(false);
            this.groupBox_kisibilgi.PerformLayout();
            this.groupBox_rndevu_paneli.ResumeLayout(false);
            this.groupBox_rndevu_paneli.PerformLayout();
            this.groupBox_gecmisrandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_aktifrandevu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_kisibilgi;
        private System.Windows.Forms.Label label4_adsoyad_deger;
        private System.Windows.Forms.Label label3_tcdeger;
        private System.Windows.Forms.Label lbl_adsoyad;
        private System.Windows.Forms.Label lbl_tc;
        private System.Windows.Forms.GroupBox groupBox_rndevu_paneli;
        private System.Windows.Forms.Label lbl_doktor;
        private System.Windows.Forms.Label lbl_sikayet;
        private System.Windows.Forms.Label lbl_brans;
        private System.Windows.Forms.Button btn_randevu_al;
        private System.Windows.Forms.GroupBox groupBox_gecmisrandevu;
        private System.Windows.Forms.GroupBox groupBox_aktifrandevu;
        private System.Windows.Forms.RichTextBox richTextBox_sikayet;
        private System.Windows.Forms.ComboBox comboBox_doktor;
        private System.Windows.Forms.ComboBox comboBox_brans;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel linkLbl_güncelle;
        private System.Windows.Forms.TextBox txtbox_id;
        private System.Windows.Forms.Label label1;
    }
}