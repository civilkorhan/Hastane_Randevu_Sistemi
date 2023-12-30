namespace Hastane_Uygulamasi
{
    partial class frm_Duyurular
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
            this.dataGridView_dyrlar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dyrlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_dyrlar
            // 
            this.dataGridView_dyrlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_dyrlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dyrlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_dyrlar.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_dyrlar.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_dyrlar.Name = "dataGridView_dyrlar";
            this.dataGridView_dyrlar.Size = new System.Drawing.Size(773, 426);
            this.dataGridView_dyrlar.TabIndex = 0;
            this.dataGridView_dyrlar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dyrlar_CellDoubleClick);
            // 
            // frm_Duyurular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(773, 426);
            this.Controls.Add(this.dataGridView_dyrlar);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Duyurular";
            this.Text = "frm_Duyurular";
            this.Load += new System.EventHandler(this.frm_Duyurular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dyrlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_dyrlar;
    }
}