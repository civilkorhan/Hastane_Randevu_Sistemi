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
    public partial class frm_Sekreter_Detay : Form
    {
        public frm_Sekreter_Detay()
        {
            InitializeComponent();
        }
        public string tc2;
        sqlbaglantisi bgl = new sqlbaglantisi();
        private void button4_Click(object sender, EventArgs e) //buton doktor paneli
        {
            frm_Doktor_Panel drpnl = new frm_Doktor_Panel();
            drpnl.Show();
        }

        private void groupBox_branslar_Enter(object sender, EventArgs e)
        {

        }

        private void frm_Sekreter_Detay_Load(object sender, EventArgs e)
        {
            
            // ad-soyad çektik
            lbl_tc_deger.Text = tc2;
            SqlCommand komut_new = new SqlCommand("Select sekreter_ad,sekreter_soyad From tbl_Sekreter Where sekreter_TC=@p4", bgl.baglanti());
            komut_new.Parameters.AddWithValue("@p4", tc2);
            SqlDataReader dr1=komut_new.ExecuteReader();
            while (dr1.Read())
            {
                lbl_adsoy_deger.Text = dr1[0] + "  " + dr1[1];                  
            }
            bgl.baglanti().Close();

            // bransları çekme 

            DataTable dt1=new DataTable();   //DATA GRID E ÇEKME İŞLEMLERİMDEN SANAL TABLO OLUŞTURUP ÇEKİYORUZ
            SqlDataAdapter da = new SqlDataAdapter("Select * from tbl_Brans", bgl.baglanti());
            da.Fill(dt1);
            dataGridView_brans.DataSource = dt1;

            // doktor çekme işlemi datagride

            DataTable dt2=new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select * from tbl_Doctor", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView_drler.DataSource = dt2;    

            // combobox'a brans çekme 

           
            SqlCommand komut_new2=new SqlCommand("Select brans_ad from tbl_Brans",bgl.baglanti());
            SqlDataReader dr2=komut_new2.ExecuteReader();
            while (dr2.Read())
            {
                combo_brans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            // dr combosuna doktor çekme
            SqlCommand drgel = new SqlCommand("Select doktor_ad,doktor_soyad from tbl_Doctor ", bgl.baglanti());
           
            SqlDataReader droku=drgel.ExecuteReader();
            while (droku.Read())
            {
                cmbobox_dr.Items.Add(droku[0]+" "+ droku[1]);
            }

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand kaydet = new SqlCommand("insert into tbl_Randevu (randevu_tarih,randevu_saat,randevu_brans,randevu_doktor) values(@r1,@r2,@r3,@r4)", bgl.baglanti());
            kaydet.Parameters.AddWithValue("@r1",mskd_tarih.Text);
            kaydet.Parameters.AddWithValue("@r2",mskd_saat.Text);
            kaydet.Parameters.AddWithValue("@r3", combo_brans.Text);
            kaydet.Parameters.AddWithValue("@r4", cmbobox_dr.Text);

            kaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevunuz Oluşturulmuştur");
        }

        private void combo_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbobox_dr.Items.Clear();
            SqlCommand getir=new SqlCommand("Select doktor_ad,doktor_soyad from tbl_Doctor where doktor_brans=@p1",bgl.baglanti());
            getir.Parameters.AddWithValue("@p1",combo_brans.Text);
            SqlDataReader oku=getir.ExecuteReader();
            while(oku.Read())
            {
                cmbobox_dr.Items.Add(oku[0]+" "+ oku[1]);
            }
            bgl.baglanti().Close();

        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            SqlCommand dyrgtr = new SqlCommand("insert into tbl_Duyurular (Duyuru) values (@d1)", bgl.baglanti());
            dyrgtr.Parameters.AddWithValue("@d1",richTextBox_duyuru.Text);
            dyrgtr.ExecuteNonQuery();
            MessageBox.Show("Duyuru Oluştuşturuldu");
            bgl.baglanti().Close();

        }

        private void btn_brns_panel_Click(object sender, EventArgs e)
        {
            frm_Branslar brnspnl = new frm_Branslar();
            brnspnl.Show();
            this.Hide();
        }

        private void btn_rndevu_pnl_Click(object sender, EventArgs e)
        {
            frm_Randevu_Paneli rndvpnl=new frm_Randevu_Paneli();
            rndvpnl.Show();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            SqlCommand dlt = new SqlCommand("Delete from tbl_Randevu where randevu_id=@s1", bgl.baglanti());
            dlt.Parameters.AddWithValue("@s1",txtbox_id.Text);
            dlt.ExecuteNonQuery();
            MessageBox.Show("Randevu Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }
    }
}
