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
    public class NguoiDung_DAO
    {
        static SqlConnection conn;
        // Lấy thông tin người dùng có tên đăng nhập và mật khẩu tương ứng, trả về null nếu không thấy
        public static NguoiDung_DTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where ten=N'{0}' and matkhau='{1}'", ten, matkhau);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.Ten = dt.Rows[0]["ten"].ToString();
            nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
            nd.Quyen = int.Parse(dt.Rows[0]["quyen"].ToString());

            conn.Close();
            return nd;
        }

        public static bool CapNhatNguoiDung(NguoiDung_DTO nd)
        {
            string sql = string.Format(@"update nguoidung set matkhau='{0}' where ten='{1}'", nd.Matkhau, nd.Ten);
            conn = DataProvider.Connect();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, conn);
            return kq;
        }
    }
}
