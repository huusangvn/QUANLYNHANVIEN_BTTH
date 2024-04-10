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
    public partial class frmChucVu : Form
    {
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void dtgvChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dtgvChucVu.DataSource = lstChucVu;


            dtgvChucVu.Columns["Macv"].HeaderText = "Mã Chức Vụ";
            dtgvChucVu.Columns["Tencv"].HeaderText = "Tên chức vụ";
            dtgvChucVu.Columns["Hsphucap"].HeaderText = "Hệ số phụ cấp";
            dtgvChucVu.Columns["Macv"].Width = 120;
            dtgvChucVu.Columns["Tencv"].Width = 120;
            dtgvChucVu.Columns["Hsphucap"].Width = 120;
        }
    }
}
