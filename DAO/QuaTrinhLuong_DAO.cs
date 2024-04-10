using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class QuaTrinhLuong_DAO
    {
        static SqlConnection conn;
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuong()
        {
            string sTruyVan = "select q.*,n.* from quatrinhluong q,nhanvien n where q.manv=n.manv";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTLuong = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qtl = new QuaTrinhLuong_DTO();
                qtl.Manv = dt.Rows[i]["manv"].ToString();
                qtl.Ngaybd = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qtl.Hsluong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                qtl.Ghichu = bool.Parse(dt.Rows[i]["ghichu"].ToString());

                qtl.NvNhanVien = new NhanVien_DTO();
                qtl.NvNhanVien.Holot = dt.Rows[i]["holot"].ToString();
                qtl.NvNhanVien.Tennv = dt.Rows[i]["tennv"].ToString();
                lstQTLuong.Add(qtl);
            }
            conn.Close();
            return lstQTLuong;



        }
    }
}
