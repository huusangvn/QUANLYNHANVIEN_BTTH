using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAO.LayNhanVien();
        }
        //Tìm nhân viên theo tên
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }
        //Tìm nhân viên theo mã
        public static List<NhanVien_DTO> TimNhanVienTheoMa(string ma)
        {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);
        }
        //Tìm nhân viên theo họ tên
        public static List<NhanVien_DTO> TimNhanVienTheoHoTen(string holot, string tennv)
        {
            return NhanVien_DAO.TimNhanVienTheoHoTen(holot,tennv);
        }
    }
}

