using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string manv;
        private string holot;
        private string tennv;
        private string phai;
        private DateTime ngaysinh;
        public string Manv { get => manv; set => manv = value; }
        public string Holot { get => holot; set => holot = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Phai { get => phai; set => phai = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Macv { get => macv; set => macv = value; }
        public string Tencv { get => tencv; set => tencv = value; }

        private string macv;
        private string tencv;
    }
}
