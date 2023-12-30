namespace Hastane_Uygulamasi
{
    partial class frm_Girisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Girisler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_hasta = new System.Windows.Forms.Button();
            this.btn_doktor = new System.Windows.Forms.Button();
            this.btn_sekreter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(100, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(254, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(389, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "SEKRETER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Script MT Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 42);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dalmaz Health";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(433, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 62);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(119, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btn_hasta
            // 
            this.btn_hasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hasta.BackgroundImage")));
            this.btn_hasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hasta.Location = new System.Drawing.Point(71, 192);
            this.btn_hasta.Name = "btn_hasta";
            this.btn_hasta.Size = new System.Drawing.Size(123, 90);
            this.btn_hasta.TabIndex = 9;
            this.btn_hasta.UseVisualStyleBackColor = true;
            this.btn_hasta.Click += new System.EventHandler(this.btn_hasta_Click);
            // 
            // btn_doktor
            // 
            this.btn_doktor.BackColor = System.Drawing.Color.Honeydew;
            this.btn_doktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_doktor.BackgroundImage")));
            this.btn_doktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_doktor.Location = new System.Drawing.Point(227, 192);
            this.btn_doktor.Name = "btn_doktor";
            this.btn_doktor.Size = new System.Drawing.Size(127, 90);
            this.btn_doktor.TabIndex = 10;
            this.btn_doktor.UseVisualStyleBackColor = true;
            this.btn_doktor.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_sekreter
            // 
            this.btn_sekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_sekreter.BackgroundImage")));
            this.btn_sekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sekreter.Location = new System.Drawing.Point(377, 192);
            this.btn_sekreter.Name = "btn_sekreter";
            this.btn_sekreter.Size = new System.Drawing.Size(124, 90);
            this.btn_sekreter.TabIndex = 11;
            this.btn_sekreter.UseVisualStyleBackColor = true;
            this.btn_sekreter.Click += new System.EventHandler(this.btn_sekreter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Script MT Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(123, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(338, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "TC. Sağlık Bakanlığı ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 38);
            this.label6.TabIndex = 13;
            this.label6.Text = "ÖZEL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Script MT Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(220, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 38);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hastanesi";
            // 
            // frm_Girisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(563, 307);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_sekreter);
            this.Controls.Add(this.btn_doktor);
            this.Controls.Add(this.btn_hasta);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frm_Girisler";
            this.Text = "Giriş Sekmesi";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_hasta;
        private System.Windows.Forms.Button btn_sekreter;
        public System.Windows.Forms.Button btn_doktor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

