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
    public class NhanVien_DAO
    {
        static SqlConnection conn;
        public static List<NhanVien_DTO> LayNhanVien() {
            string sTruyVan = @"select n.*, c.tencv from nhanvien n, chucvu c where
n.macv = c.macv";
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn); 

            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for(int i = 0; i<dt.Rows.Count; i++) {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();

                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

        //Tìm nhân viên theo mã
          public static List<NhanVien_DTO> TimNhanVienTheoMa(string ma)
          {
            string sTruyVan = string.Format(@"select * from nhanvien where manv like '%{0}%'",ma);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                lstNhanVien.Add(nv);
            }
            conn.Close();
            return lstNhanVien;
        }


        //Tìm nhân viên theo tên
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like '%{0}%' ", ten);
            conn = DataProvider.Connect();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                lstNhanVien.Add(nv);
            }
            conn.Close();
            return lstNhanVien;
        }

        //Tìm nhân viên theo họ và tên
        public static List<NhanVien_DTO> TimNhanVienTheoHoTen(string holot, string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where holot like N'%{0}%' and tennv like N'%{1}%'", holot, ten);
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<DTO.NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = (DateTime)dt.Rows[i]["ngaysinh"];
                lstNhanVien.Add(nv);
            }
            conn.Close();
            return lstNhanVien;
        }
    }
}
