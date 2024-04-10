using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class ChucVu_DAO
    {
        static SqlConnection conn;
        public static List<ChucVu_DTO> LayChucVu()
        {
            string sTruyVan = @"select * from chucvu";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);

            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Macv = dt.Rows[i]["macv"].ToString();
                cv.Tencv = dt.Rows[i]["tencv"].ToString();
                cv.Hsphucap = (float)dt.Rows[i]["hsphucap"];
                lstChucVu.Add(cv);
            }
            conn.Close();
            return lstChucVu;
        }
    }
}
