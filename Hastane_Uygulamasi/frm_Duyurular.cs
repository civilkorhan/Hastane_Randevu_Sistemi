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
    public partial class frm_Duyurular : Form
    {
        public frm_Duyurular()
        {
            InitializeComponent();
        }

        sqlbaglantisi sqlbaglantisi = new sqlbaglantisi();
        private void frm_Duyurular_Load(object sender, EventArgs e)
        {
            DataTable dyr = new DataTable();
            SqlDataAdapter ykle = new SqlDataAdapter("Select * from tbl_Duyurular", sqlbaglantisi.baglanti());
            ykle.Fill(dyr);
            dataGridView_dyrlar.DataSource = dyr;
        }

        private void dataGridView_dyrlar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
        }
    }
}
