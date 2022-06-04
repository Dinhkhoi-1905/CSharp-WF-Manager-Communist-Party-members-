using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLCS_QLDV
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnsiDanhSachDangVien_Click(object sender, EventArgs e)
        {
            frmDanhSachDangVien dsdv = new frmDanhSachDangVien();
            dsdv.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip1.BackColor = Color.Transparent;
            mnsTuyChon.BackColor = Color.Transparent;
            frmDangNhap fDangNhap = new frmDangNhap(this);
            fDangNhap.ShowDialog();
        }

        private void danhSáchCuộcHọpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDanhSachCuocHop frm = new frmDanhSachCuocHop();
            frm.ShowDialog();
        }

        private void phiếuLiênLạcTheoCuộcHọpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPLLTheoCuocHop fr = new frmPLLTheoCuocHop();
            fr.ShowDialog();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thoátĐăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTin fr = new frmThongTin();
            fr.ShowDialog();
        }
    }
}
