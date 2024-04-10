using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        public void HienThiDanhSachSinhVien()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dtgvNhanVien.DataSource = lstNhanVien;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

            HienThiDanhSachSinhVien();
            // Dữ liệu combobox Chức vụ
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cbChucVu.DataSource = lstChucVu;
            cbChucVu.DisplayMember = "Tencv";
            cbChucVu.ValueMember = "Macv";

            radTimTheoMA.Checked = true;
            radTimTheoTen.Checked = false;
            radTimTheoHoTen.Checked = false;

        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dtgvNhanVien.SelectedRows[0];
            txtMaSo.Text = r.Cells["Manv"].Value.ToString();
            txtHoLot.Text = r.Cells["Holot"].Value.ToString();
            txtTen.Text = r.Cells["Tennv"].Value.ToString();
            if (r.Cells["Phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dNgaySinh.Text = r.Cells["Ngaysinh"].Value.ToString();
            cbChucVu.SelectedValue = r.Cells["Macv"].Value;
        }

        private void cbChucVu_Click(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            txtTimHoLot.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSo.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");

                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaSo.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaSo.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaSo.Text;
            nv.Holot = txtHoLot.Text;
            nv.Tennv = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.Phai = "Nam";
            }
            else
            {
                nv.Phai = "Nữ";
            }
            nv.Ngaysinh = DateTime.Parse(dNgaySinh.Text);
            nv.Macv = cbChucVu.SelectedValue.ToString();
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được.");
                return;
            }
            else
            {
                HienThiDanhSachSinhVien();
                MessageBox.Show("Đã thêm nhân viên.");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (radTimTheoMA.Checked == true)
            {
                string ma = txtTim.Text;
                List<NhanVien_DTO> lstnvma = NhanVien_BUS.TimNhanVienTheoMa(ma);

                if (lstnvma == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dtgvNhanVien.DataSource = lstnvma;


            }
            else if(radTimTheoTen.Checked == true)
            {
                string ten = txtTim.Text;
                List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);

                if (lstnv == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dtgvNhanVien.DataSource = lstnv;
            }
            else if(radTimTheoHoTen.Checked == true)
            {
                string holot = txtTimHoLot.Text;
                string ten = txtTimTen.Text;
                List<NhanVien_DTO> lstnvht = NhanVien_BUS.TimNhanVienTheoHoTen(holot,ten);
                if (lstnvht == null)
                {
                    MessageBox.Show("Không tìm thấy!");
                    return;
                }
                dtgvNhanVien.DataSource = lstnvht;
            }
        }

        private void txtTimHoLot_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTimTen_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaSo.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaSo.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaSo.Text;
            nv.Holot = txtHoLot.Text;
            nv.Tennv = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.Phai = "Nam";
            }
            else
            {
                nv.Phai = "Nữ";
            }
            nv.Ngaysinh = DateTime.Parse(dNgaySinh.Text);
            nv.Macv = cbChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.XoaNhanVien(nv) == true)
            {
                HienThiDanhSachSinhVien();
                MessageBox.Show("Đã xóa nhân viên.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaSo.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaSo.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaSo.Text;
            nv.Holot = txtHoLot.Text;
            nv.Tennv = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.Phai = "Nam";
            }
            else
            {
                nv.Phai = "Nữ";
            }
            nv.Ngaysinh = DateTime.Parse(dNgaySinh.Text);
            nv.Macv = cbChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.SuaNhanVien(nv) == true)
            {
                HienThiDanhSachSinhVien();
                MessageBox.Show("Đã cập nhật thông tin nhân viên.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }
    }
}
