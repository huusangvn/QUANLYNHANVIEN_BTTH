using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DAO
{
    public class DataProvider
    {

        public static SqlConnection Connect()
        {
            string strConn = @"Data Source=DESKTOP-NF5VIC7;Initial Catalog=QLNV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            return conn;
        }

        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection Connet)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, Connet);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection Connet)
        {

            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, Connet);
                cm.ExecuteNonQuery();
                return true;

            }catch(Exception)
            {
                return false;
            }


        }
    }
}
