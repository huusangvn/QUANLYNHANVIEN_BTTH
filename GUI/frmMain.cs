using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmChucVu fCV;
        frmNhanVien fNV;
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

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void quáTrìnhNângLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QuaTrinhLuong frmQTL = new frm_QuaTrinhLuong();
            frmQTL.Show();
        }
    }
}
