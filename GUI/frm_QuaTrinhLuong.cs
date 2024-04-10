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
    public partial class frm_QuaTrinhLuong : Form
    {
        public frm_QuaTrinhLuong()
        {
            InitializeComponent();
        }

        private void dtgvQuaTrinhLuong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_QuaTrinhLuong_Load(object sender, EventArgs e)
        {
            List<QuaTrinhLuong_DTO> lstQuaTrinhLuong = QuanTrinhLuong_BUS.LayQuaTrinhLuong();
            dtgvQuaTrinhLuong.DataSource = lstQuaTrinhLuong;
        }
    }
}
