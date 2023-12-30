using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Uygulamasi
{
    public partial class frm_Doktor_Panel : Form
    {
        public frm_Doktor_Panel()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl = new sqlbaglantisi();



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        // sql tablosunu datagrid e aktarma
        private void frm_Doktor_Panel_Load(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_Doctor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            // comboboxa brans çekme

            SqlCommand komut_new2 = new SqlCommand("Select brans_ad from tbl_Brans", bgl.baglanti());
            SqlDataReader dr2 = komut_new2.ExecuteReader();
            while (dr2.Read())
            {
                cmbo_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }
        // tıkladığında bilgileri getirme
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txt_ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbo_brans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskd_Tc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();

        }
        // dr ekleme
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into tbl_Doctor (doktor_ad,doktor_soyad,doktor_brans,doktor_TC,doktor_sifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            ekle.Parameters.AddWithValue("@d1",txt_ad.Text);
            ekle.Parameters.AddWithValue("@d2", txt_soyad.Text);
            ekle.Parameters.AddWithValue("@d3", cmbo_brans.Text);
            ekle.Parameters.AddWithValue("@d4", mskd_Tc.Text);
            ekle.Parameters.AddWithValue("@d5", txt_sifre.Text);
            ekle.ExecuteNonQuery();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bgl.baglanti().Close();
                
        }
        // dr silme

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("Delete from tbl_Doctor where doktor_TC=@p1", bgl.baglanti());
            sil.Parameters.AddWithValue("@p1",mskd_Tc.Text);
            sil.ExecuteNonQuery();
            MessageBox.Show("Doktor Silindi","Bilgi",MessageBoxButtons.OK);
            bgl.baglanti().Close();

        }

        // dr güncelleme
        private void btn_gnclle_Click(object sender, EventArgs e)
        {
            SqlCommand gnclle = new SqlCommand("Update tbl_Doctor set doktor_ad= @g1,doktor_soyad=@g2,doktor_brans=@g3,doktor_TC=@g4,doktor_sifre=@g5 where doktor_TC=@g4", bgl.baglanti());
            gnclle.Parameters.AddWithValue("@g1",txt_ad.Text);
            gnclle.Parameters.AddWithValue("@g2", txt_soyad.Text);
            gnclle.Parameters.AddWithValue("@g3", cmbo_brans.Text);
            gnclle.Parameters.AddWithValue("@g4", mskd_Tc.Text);
            gnclle.Parameters.AddWithValue("@g5", txt_sifre.Text);
            gnclle.ExecuteNonQuery() ;
            MessageBox.Show("Doktor Güncellendi", "Bilgi",MessageBoxButtons.OK);
            bgl.baglanti().Close();



        }


    }

}
