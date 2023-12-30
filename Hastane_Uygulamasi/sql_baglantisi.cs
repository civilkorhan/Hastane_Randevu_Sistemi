using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Uygulamasi
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-Q60UHL2\\SQLEXPRESS05;Initial Catalog=hastane_Proje;Integrated Security=True;");
            baglan.Open();
            return baglan;
        }
    }
}
