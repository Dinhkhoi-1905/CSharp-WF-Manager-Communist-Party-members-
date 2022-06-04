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
    public partial class frmDiemDanhHop : Form
    {
        public frmDiemDanhHop()
        {
            InitializeComponent();
        }
        DataSet dsDiemDanh = new DataSet();
        SqlDataReader drDV;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void DieuKhienKhiBinhThuong()
        {
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDongForm.Enabled = true;
            btnChinhSua.Enabled = true;

            txtMSDV.ReadOnly = true;
            txtMSDV.BackColor = Color.White;
            txtTenCH.ReadOnly = true;
            txtTenCH.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            gbThamGia.Enabled = false;
            gbThamGia.BackColor = Color.White;
        }

        void GanDuLieu()
        {
            txtTenCH.Text = MyPublics.strTenCuocHop;
            txtHoTen.Text = dgvDiemDanh[1, dgvDiemDanh.CurrentRow.Index].Value.ToString();
            txtMSDV.Text = dgvDiemDanh[0, dgvDiemDanh.CurrentRow.Index].Value.ToString();
            if(dgvDiemDanh[2, dgvDiemDanh.CurrentRow.Index].Value.ToString().ElementAt(0) == '1')
            {
                rbCo.Checked = true;
            }
            else if(dgvDiemDanh[2, dgvDiemDanh.CurrentRow.Index].Value.ToString().ElementAt(0) == '2')
            {
                rbVang.Checked = true;
            }
            else rbVangCP.Checked = true;
            //Lấy giá trị họ tên ĐV từ bảng DangVien
            SqlCommand cmdCommand = new SqlCommand();
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "Select Hoten from DangVien where MSDV ='" + txtMSDV.Text +"'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                for (int i=0; i < drDV.FieldCount; i++)
                {
                    txtHoTen.Text = drDV.GetValue(i).ToString();
                }
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();
        }
        void NhanDuLieu()
        {
            string strSelect = "select * from DVThamGiaCuocHop where MSCH = '" + MyPublics.strMaCuocHop +"'";
            MyPublics.OpenData(strSelect, dsDiemDanh, "DVThamGiaCuocHop");
        }
        private void frmDiemDanhHop_Load(object sender, EventArgs e)
        {
            //giao dien
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;

            //
            NhanDuLieu();
            dgvDiemDanh.DataSource = dsDiemDanh;
            dgvDiemDanh.DataMember = "DVThamGiaCuocHop";
            dgvDiemDanh.AllowUserToAddRows = false;
            dgvDiemDanh.AllowUserToDeleteRows = false;
            dgvDiemDanh.Width = 370;
            dgvDiemDanh.Columns[0].Width = 100;
            dgvDiemDanh.Columns[0].HeaderText = "MS Đảng Viên";
            dgvDiemDanh.Columns[1].Width = 100;
            dgvDiemDanh.Columns[1].HeaderText = "MS cuộc họp";
            dgvDiemDanh.Columns[2].Width = 100;
            dgvDiemDanh.Columns[2].HeaderText = "Tham gia";
            dgvDiemDanh.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDiemDanh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DieuKhienKhiChinhSua()
        {
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnDongForm.Enabled = false;
            btnChinhSua.Enabled = false;

            txtMSDV.ReadOnly = true;
            txtMSDV.BackColor = Color.White;
            txtTenCH.ReadOnly = true;
            txtTenCH.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            gbThamGia.Enabled = true;
            gbThamGia.BackColor = Color.White;
        }

        void ThucThiLuu()
        {
            string strSql;
                strSql = "Update DVThamGiaCuocHop Set Thamgia = @Thamgia Where MSCH = @MSCH and MSDV=@MSDV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSCH", MyPublics.strMaCuocHop);
            cmdCommand.Parameters.AddWithValue("@MSDV", txtMSDV.Text.Trim());

            if (rbCo.Checked == true)
            {
                cmdCommand.Parameters.AddWithValue("@ThamGia", 1);
            }
            else if(rbVang.Checked == true)
            {
                cmdCommand.Parameters.AddWithValue("@ThamGia", 2);
            }
            else cmdCommand.Parameters.AddWithValue("@ThamGia", 3);

            // Lưu dữ liệu về Server
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            // Xóa dữ liệu cũ và nhận lại dữ liệu cho DataSet
            dsDiemDanh.Clear();
            NhanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucThiLuu();
            MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }
    }
}
