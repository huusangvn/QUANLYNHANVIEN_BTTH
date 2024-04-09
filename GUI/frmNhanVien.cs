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

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dtgvNhanVien.DataSource = lstNhanVien;

            // Dữ liệu combobox Chức vụ
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cbChucVu.DataSource = lstChucVu;
            cbChucVu.DisplayMember = "Tencv";
            cbChucVu.ValueMember = "Macv";
        }

        private void dtgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbChucVu_Click(object sender, EventArgs e)
        {

        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ma = txtTim.Text;
            string ten = txtTim.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(ten);
            List<NhanVien_DTO> lstnvma = NhanVien_BUS.TimNhanVienTheoMa(ma);
            if (lstnv == null || lstnvma == null)
            {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dtgvNhanVien.DataSource = lstnv;
            dtgvNhanVien.DataSource = lstnvma;
        }
    }
}
