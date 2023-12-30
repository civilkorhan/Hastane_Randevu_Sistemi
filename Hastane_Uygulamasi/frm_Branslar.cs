using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Uygulamasi
{
    public partial class frm_Branslar : Form
    {
        public frm_Branslar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void frm_Branslar_Load(object sender, EventArgs e)
        {
            DataTable drtbl = new DataTable();
            SqlDataAdapter gtr = new SqlDataAdapter("Select * from tbl_Brans", bgl.baglanti()); 
            gtr.Fill(drtbl);
            dataGridView1.DataSource= drtbl;

            SqlCommand komut_new2 = new SqlCommand("Select brans_ad from tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut_new2.ExecuteReader();
            while (dr2.Read())
            {
                cmbo_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cmbo_brans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand add = new SqlCommand("insert into tbl_Brans (brans_ad) values (@b1) ", bgl.baglanti());
            add.Parameters.AddWithValue("@b1",cmbo_brans.Text);
            add.Parameters.AddWithValue("@b2",txt_ad.Text);
            add.ExecuteNonQuery();
            MessageBox.Show("Brans Eklendi");
            bgl.baglanti().Close();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand dlt = new SqlCommand("delete from tbl_Brans where brans_id=@b1 ", bgl.baglanti());
            dlt.Parameters.AddWithValue("@b1", txt_ad.Text);
            dlt.ExecuteNonQuery();
            MessageBox.Show("Brans Silindi");
            bgl.baglanti().Close();


        }

        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            SqlCommand updt = new SqlCommand("update tbl_Brans set brans_ad=@b2  where brans_id=@b1 )", bgl.baglanti());
            updt.Parameters.AddWithValue("@b1",txt_ad.Text);
            updt.Parameters.AddWithValue("@b2",cmbo_brans.Text);
            updt.ExecuteNonQuery();
            MessageBox.Show("Brans Güncellendi");
            bgl.baglanti().Close();

        }
    }
}
