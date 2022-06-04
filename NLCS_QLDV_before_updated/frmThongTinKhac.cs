using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLCS_QLDV
{
    public partial class frmThongTinKhac : Form
    {
        public frmThongTinKhac()
        {
            InitializeComponent();
        }
        SqlDataReader drDV;

        void GanDuLieuCongTac()
        {
            SqlCommand cmdCommand = new SqlCommand();
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "Select Madonvi, Ngaychuyenden from DVDangCongTac where MSDV ='" + MyPublics.strMSDV + "'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                txtMaDVCongTac.Text = drDV[0].ToString();
                dtpNgayCongTac.Value = DateTime.Parse(drDV[1].ToString());
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();

            //Gan du ten cuadon vi
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "select Tendonvi, Tructhuoc from DonVi where Madonvi = '" + txtMaDVCongTac.Text +"'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                txtTenDVCongTac.Text = drDV[0].ToString();
                txtTTCongTac.Text = drDV[1].ToString();
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();
        }
        void GanDuLieuCuTru()
        {
            SqlCommand cmdCommand = new SqlCommand();
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "Select Madonvi, Ngaychuyenden from DVDangCuTru where MSDV ='" + MyPublics.strMSDV + "'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                txtMaDVCuTru.Text = drDV[0].ToString();
                dtpNgayCuTru.Value = DateTime.Parse(drDV[1].ToString());
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();

            //Gan du ten cuadon vi
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "select Tendonvi, Tructhuoc from DonVi where Madonvi = '" + txtMaDVCuTru.Text + "'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                txtTenDVCuTru.Text = drDV[0].ToString();
                txtTTCuTru.Text = drDV[1].ToString();
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();
        }
        void DieuKhienBinhThuong()
        {
            txtMaDVCongTac.ReadOnly = true;
            txtTenDVCongTac.ReadOnly = true;
            txtTTCongTac.ReadOnly = true;
            txtMaDVCuTru.ReadOnly = true;
            txtTenDVCuTru.ReadOnly = true;
            txtTTCuTru.ReadOnly = true;
            txtTuoiDang.ReadOnly = true;
            dtpNgayCongTac.Enabled = false;
            dtpNgayCuTru.Enabled = false;
        }
        void GanTuoiDang()
        {
            int nam = MyPublics.NgayvaoDang.Year;
            int result = DateTime.Today.Year - nam;
            txtTuoiDang.Text = result.ToString();
        }
        private void frmThongTinKhac_Load(object sender, EventArgs e)
        {
            //giao dien
            label1.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            panel1.BackColor = Color.FromArgb(175, Color.Black);
            panel2.BackColor = Color.FromArgb(175, Color.Black);
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            GanDuLieuCongTac();
            GanDuLieuCuTru();
            GanTuoiDang();
            DieuKhienBinhThuong();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
