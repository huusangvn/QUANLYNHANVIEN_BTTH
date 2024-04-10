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
    }
}
