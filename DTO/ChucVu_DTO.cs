using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ChucVu_DTO
    {
        private string tencv;
        private string macv;
        private float hsphucap;
        public string Tencv { get => tencv; set => tencv = value; }
        public string Macv { get => macv; set => macv = value; }
        public float Hsphucap { get => hsphucap; set => hsphucap = value; }
    }
}
