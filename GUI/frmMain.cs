using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool bDangNhap; // true: đăng nhập thành công, false: chưa đăng nhập
        frmChucVu fCV;
        frmNhanVien fNV;
        public NguoiDung_DTO NguoiDung;
        frmDangNhap fDN;
        // Hàm hiển thị các lệnh trên menu tương ứng với trạng thái đăng nhập
        private void HienThiMenu()
        {
            iDangNhap.Enabled = !bDangNhap;
            iDangXuat.Enabled = bDangNhap;
            iDanhMuc.Enabled = bDangNhap;
            iNghiepVu.Enabled = bDangNhap;
            // tương tự cho các menu còn lại


            if (bDangNhap == true)
            {
                txtNguoiDung.Text = "Người dùng: " + NguoiDung.Ten;
                txtThoiDiemDangNhap.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ:
                // 1. quantri: sử dụng tất cả menu
                // 2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.Quyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1: // SV tự bổ sung
                        iDanhMuc.Enabled = bDangNhap;
                        iNghiepVu.Enabled = bDangNhap;
                        break;
                    case 2: // SV tự bổ sung
                        iDanhMuc.Enabled = !bDangNhap;
                        iNghiepVu.Enabled = !bDangNhap;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                txtNguoiDung.Text = "Chưa đăng nhập";
                txtThoiDiemDangNhap.Text = "";
            }
        }
    
        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                fCV = new frmChucVu();
                fCV.ShowDialog();
        
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
                fNV = new frmNhanVien();
                fNV.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            HienThiMenu();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quáTrìnhNângLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuaTrinhLuong frmQTL = new frm_QuaTrinhLuong();
            frmQTL.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap frmDN = new frmDangNhap();

            if (frmDN.ShowDialog() == DialogResult.OK)
            {
                string sTen = frmDN.txtTaiKhoan.Text;
                string sMatKhau = frmDN.txtMatKhau.Text;
                NguoiDung = new NguoiDung_DTO();
                NguoiDung = NguoiDung_BUS.LayNguoiDung(sTen, sMatKhau);
                if (NguoiDung != null)
                {
                    bDangNhap = true;
                }
            }
            else
            {
                bDangNhap = false;
                MessageBox.Show("Đăng nhập thất bại!!");
            }
            HienThiMenu();
        }

        private void iDangXuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            foreach (Form f in this.MdiChildren)
            {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất và thiết lập lại menu
            bDangNhap = false;
            HienThiMenu();
        }

        private void saoLưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog saoluuFolder = new FolderBrowserDialog();
            saoluuFolder.Description = "Chọn thư mục lưu trữ";
            if (saoluuFolder.ShowDialog() == DialogResult.OK)
            {
                string sDuongDan = saoluuFolder.SelectedPath;
                if (CSDL_BUS.SaoLuu(sDuongDan) == true)
                    MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan);
                else
                    MessageBox.Show("Thao tác không thành công");
            }
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog phuchoiFile = new OpenFileDialog();
            phuchoiFile.Filter = "*.bak|*.bak";
            phuchoiFile.Title = "Chọn tập tin phục hồi (.bak)";
            if (phuchoiFile.ShowDialog() == DialogResult.OK &&
            phuchoiFile.CheckFileExists == true)
            {
                string sDuongDan = phuchoiFile.FileName;
                if (CSDL_BUS.PhucHoi(sDuongDan) == true)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
