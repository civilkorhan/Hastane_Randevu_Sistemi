using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hastane_Uygulamasi
{
    public partial class frm_Doktor_Detay : Form
    {
        public frm_Doktor_Detay()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();

        public string dr_TC;
        


        private void frm_Doktor_Detay_Load(object sender, EventArgs e)
        {
            // isim soyisim taşıdık
            lbltc_deger.Text = dr_TC; // tc
            SqlCommand adsyd= new SqlCommand("Select doktor_ad,doktor_soyad from tbl_Doctor where doktor_TC=@d1",bgl.baglanti());
            adsyd.Parameters.AddWithValue("@d1",dr_TC);
            SqlDataReader okuad = adsyd.ExecuteReader();
            while(okuad.Read())  
            {
                lbl_isim_deger.Text = okuad[0] + " " + okuad[1];

            }
            bgl.baglanti().Close();

           // Randevu çağırma
           DataTable dt=new DataTable();
           SqlDataAdapter da=new SqlDataAdapter("Select * from tbl_randevu where randevu_doktor='"+lbl_isim_deger.Text+"'",bgl.baglanti());
           da.Fill(dt);
           dataGridView1.DataSource = dt;  

        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            // Çıkış Yaptık
            frm_Doktor_Detay cls=new frm_Doktor_Detay();    
            this.Close(); 
        }

        private void btn_dyrular_Click(object sender, EventArgs e)
        {
            frm_Duyurular dyr=new frm_Duyurular();
            dyr.Show();
        }

        private void btn_blgi_dznle_Click(object sender, EventArgs e)
        {
            frm_Doktor_Bilgi_Güncelleme drnew= new frm_Doktor_Bilgi_Güncelleme();

            drnew.TCNO = lbltc_deger.Text;
            drnew.Show();
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            richTextBox_randevu_dty.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();   
        }
    }
}
