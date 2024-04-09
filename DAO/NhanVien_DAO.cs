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


        public void NhanVien()
        {

        }
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
                nv.Tencv = dt.Rows[i]["tencv"].ToString();

                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

        //Tìm nhân viên theo mã
          public static NhanVien_DTO TimNhanVienTheoMa(string ma)
          {
              string sTruyVan = string.Format(@"select * from nhanvien where manv like '%{0}' ");
              conn = DataProvider.Connect();
              DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, conn);

              if (dt.Rows.Count == 0)
              {
                  return null;
              }
              NhanVien_DTO nv = new NhanVien_DTO();
              nv.Manv = dt.Rows[0]["manv"].ToString();
              nv.Holot = dt.Rows[0]["holot"].ToString();
              nv.Tennv = dt.Rows[0]["tennv"].ToString();
              nv.Phai = dt.Rows[0]["phai"].ToString();
              nv.Ngaysinh = (DateTime)dt.Rows[0]["ngaysinh"];
              nv.Tencv = dt.Rows[0]["tencv"].ToString();

              conn.Close();
              return nv;

          }


        //Tìm nhân viên theo tên
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like
'%{0}%'", ten);

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
    }
}
