using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{

    public class QuaTrinhLuong_DTO
    {
        private string manv;
        private DateTime ngaybd;
        private bool ghichu;
        private float hsluong;
        public string Manv { get => manv; set => manv = value; }
        public DateTime Ngaybd { get => ngaybd; set => ngaybd = value; }
        public bool Ghichu { get => ghichu; set => ghichu = value; }
        public float Hsluong { get => hsluong; set => hsluong = value; }


        private NhanVien_DTO nvNhanVien;

        public NhanVien_DTO NvNhanVien
        {
            get { return nvNhanVien; }
            set { nvNhanVien = value; }
        }
    }
}
