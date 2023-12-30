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
    public partial class frm_Doktor_Bilgi_Güncelleme : Form
    {
        public frm_Doktor_Bilgi_Güncelleme()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        public string TCNO;

        private void frm_Doktor_Bilgi_Güncelleme_Load(object sender, EventArgs e)
        {

            msk_tcno.Text = TCNO;
            SqlCommand blggtr=new SqlCommand("Select * from tbl_Doctor where doktor_TC=@p1",bgl.baglanti());
            blggtr.Parameters.AddWithValue("@p1",msk_tcno.Text);
            SqlDataReader okublg=blggtr.ExecuteReader();
            while (okublg.Read())
            {
                txt_ad.Text = okublg[1].ToString();
                txtbx_soyad.Text = okublg[2].ToString();
                comboBox_brans.Text = okublg[3].ToString();
                txt_sifre.Text = okublg[5].ToString();
            }
            bgl.baglanti().Close();
                

            SqlCommand brnsckme=new SqlCommand("Select brans_ad from tbl_Brans ",bgl.baglanti());
            SqlDataReader okubrs=brnsckme.ExecuteReader();  
            while(okubrs.Read())
            {
                comboBox_brans.Items.Add(okubrs[0]);
            }


            SqlCommand updt = new SqlCommand("update tbl_Doctor set doktor_ad=@d1, doktor_soyad=@d2,doktor_brans=@d3,doktor_sifre=@d4 where doktor_TC=@d5", bgl.baglanti());
            updt.Parameters.AddWithValue("@d1",txt_ad.Text);
            updt.Parameters.AddWithValue("@d2", txtbx_soyad.Text);
            updt.Parameters.AddWithValue("@d3", comboBox_brans.Text);
            updt.Parameters.AddWithValue("@d4", txt_sifre.Text);
            updt.Parameters.AddWithValue("@d5", msk_tcno.Text);
            updt.ExecuteNonQuery();
            bgl.baglanti().Close();
            //MessageBox.Show("Bilgileriniz Güncellenmiştir");


        }
    }
    
}
