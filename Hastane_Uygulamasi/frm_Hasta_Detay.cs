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
//using System.Data.Common; //sistem kütüphanemi ekledim

namespace Hastane_Uygulamasi
{
    public partial class frm_Hasta_Detay : Form
    {
        public frm_Hasta_Detay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlbaglantisi bgl=new sqlbaglantisi();

       

        private void frm_Hasta_Detay_Load(object sender, EventArgs e)
        {
            // ad-soyad veri tabanından çekme
            label3_tcdeger.Text = tc;
            SqlCommand komut = new SqlCommand("Select hasta_ad,hasta_soyad From tbl_Hastalar Where hasta_TC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",label3_tcdeger.Text); //buraya label3_tcdeger yerine tc de yazabilirdik
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                label4_adsoyad_deger.Text = dr[0] + " " + dr[1]; // boşluk için bıraktığımız stringden dolayı tamamını stringe çevirmedik gelen ilk değer yani 0 ad diğeri ise soyad
            }
            bgl.baglanti().Close();

            //randevu çekme
            DataTable dt = new DataTable(); // sanal tablo oluşturduk
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Randevu where randevu_hasta_Tc=" + tc, bgl.baglanti());
            da.Fill(dt); // sanal tabloyu doldur dedik
            dataGridView1.DataSource = dt; // datagridview de bağlantı açıp kapatmaya gerek yoktur.


            //Bransları Çekme

            SqlCommand komut2 = new SqlCommand("Select brans_ad from tbl_Brans",bgl.baglanti());
            SqlDataReader dr2 =komut2.ExecuteReader();
            while (dr2.Read())
            {
                comboBox_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void comboBox_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_doktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select doktor_ad,doktor_soyad from tbl_Doctor Where doktor_brans=@p1 ",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",comboBox_brans.Text);
            SqlDataReader dr3=komut3.ExecuteReader();
            while(dr3.Read())
            {
                comboBox_doktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void comboBox_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Randevu where randevu_brans='" + comboBox_brans.Text + "'" + " and randevu_doktor='" + comboBox_doktor.Text + "'and randevu_durum=0", bgl.baglanti());   //tek tırnağı ' çift tırnak arasında yazdık''
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        // bilgi güncelleme
        private void linkLbl_güncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_Hasta_Bilgi_Güncelleme frm = new frm_Hasta_Bilgi_Güncelleme(); 
            frm.TCno = label3_tcdeger.Text;
            frm.Show();

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtbox_id.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btn_randevu_al_Click(object sender, EventArgs e)
        {
            SqlCommand al = new SqlCommand("Update tbl_Randevu set randevu_durum=1,randevu_hasta_tc=@p1,randevu_hasta_sikayet=@p2 where randevu_id=@p3", bgl.baglanti());
            al.Parameters.AddWithValue("@p1",label3_tcdeger.Text);
            al.Parameters.AddWithValue("@p2", richTextBox_sikayet.Text);
            al.Parameters.AddWithValue("@p3",txtbox_id.Text);
            al.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı","Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
        }
    }
}
