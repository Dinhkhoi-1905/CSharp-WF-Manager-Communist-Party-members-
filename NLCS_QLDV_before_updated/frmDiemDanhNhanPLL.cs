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
    public partial class frmDiemDanhNhanPLL : Form
    {
        public frmDiemDanhNhanPLL()
        {
            InitializeComponent();
        }
        DataSet dsDiemDanh = new DataSet();
        SqlDataReader drDV;

        void DieuKhienKhiBinhThuong()
        {
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDongForm.Enabled = true;
            btnChinhSua.Enabled = true;
            txtTenCuocHop.Enabled = true;

            txtMSDV.ReadOnly = true;
            txtMSDV.BackColor = Color.White;
            txtTrangThai.ReadOnly = true;
            txtTrangThai.BackColor = Color.White;
            txtHoTenDangVien.ReadOnly = true;
            txtHoTenDangVien.BackColor = Color.White;
            txtTenNguoiNhan.ReadOnly = true;
            txtTenNguoiNhan.BackColor = Color.White;
            txtTrangThai.ReadOnly = true;
            dgvDiemDanhPLL.Enabled = true;
            dtpTGNhan.Enabled = false;
        }
        void GanDuLieu()
        {
            txtTenCuocHop.Text = MyPublics.strTenCuocHop;
            //txtHoTenDangVien.Text = dgvDiemDanhPLL[1, dgvDiemDanhPLL.CurrentRow.Index].Value.ToString();
            txtMSDV.Text = dgvDiemDanhPLL[1, dgvDiemDanhPLL.CurrentRow.Index].Value.ToString();
            txtTenNguoiNhan.Text = dgvDiemDanhPLL[3, dgvDiemDanhPLL.CurrentRow.Index].Value.ToString();
                
            dtpTGNhan.Value = DateTime.Parse(dgvDiemDanhPLL[4, dgvDiemDanhPLL.CurrentRow.Index].Value.ToString());

            //Lấy giá trị họ tên ĐV từ bảng DangVien
            SqlCommand cmdCommand = new SqlCommand();
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "Select Hoten from DangVien where MSDV ='" + txtMSDV.Text +"'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            while (drDV.Read())
            {
                for (int i = 0; i < drDV.FieldCount; i++)
                {
                    txtHoTenDangVien.Text = drDV.GetValue(i).ToString();
                }
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();
            if (txtTenNguoiNhan.Text == "")
            {
                txtTrangThai.Text = "Chưa nhận";
                dtpTGNhan.Visible = false;
            }
            else
            {
                txtTrangThai.Text = "Đã nhận";
                dtpTGNhan.Visible = true;
            }
        }
        void NhanDuLieu()
        {
            string strSelect = "select * from PhieuLienLac where MSCH = '" + MyPublics.strMaCuocHop +"'";
            MyPublics.OpenData(strSelect, dsDiemDanh, "PhieuLienLac");
        }
        private void frmDiemDanhNhanPLL_Load(object sender, EventArgs e)
        {
            //giao dien
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            label2.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            //
            NhanDuLieu();

            dgvDiemDanhPLL.DataSource = dsDiemDanh;
            dgvDiemDanhPLL.DataMember ="PhieuLienLac";
            dgvDiemDanhPLL.AllowUserToAddRows = false;
            dgvDiemDanhPLL.AllowUserToDeleteRows = false;
            dgvDiemDanhPLL.Width = 520;
            dgvDiemDanhPLL.Columns[0].Width = 50;
            dgvDiemDanhPLL.Columns[0].HeaderText = "Mã Phiếu liên lạc";
            dgvDiemDanhPLL.Columns[1].Width = 50;
            dgvDiemDanhPLL.Columns[1].HeaderText = "MSDV";
            dgvDiemDanhPLL.Columns[2].Width = 50;
            dgvDiemDanhPLL.Columns[2].HeaderText = "MSCH";
            dgvDiemDanhPLL.Columns[3].Width = 150;
            dgvDiemDanhPLL.Columns[3].HeaderText = "Người nhận";
            dgvDiemDanhPLL.Columns[4].Width = 150;
            dgvDiemDanhPLL.Columns[4].HeaderText = "Thời gian nhận";
            dgvDiemDanhPLL.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDiemDanhPLL_CellClick(object sender, DataGridViewCellEventArgs e)
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
            txtTenCuocHop.Enabled = false;

            txtMSDV.ReadOnly = true;
            txtMSDV.BackColor = Color.White;
            txtTrangThai.ReadOnly = true;
            txtTrangThai.BackColor = Color.White;
            txtHoTenDangVien.ReadOnly = true;
            txtHoTenDangVien.BackColor = Color.White;
            txtTenNguoiNhan.ReadOnly = false;
            txtTenNguoiNhan.BackColor = Color.White;

            txtTenNguoiNhan.Focus();
            dgvDiemDanhPLL.Enabled = false;
            dtpTGNhan.Enabled = true;
        }
        void ThucThiLuu()
        {
            string strSql;
            strSql = "Update PhieuLienLac Set Nguoinhan = @Nguoinhan, Thoigiannhan = @Thoigiannhan  Where MSPLL = @MSPLL";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@Nguoinhan", txtTenNguoiNhan.Text);
            cmdCommand.Parameters.AddWithValue("@Thoigiannhan", dtpTGNhan.Value);
            cmdCommand.Parameters.AddWithValue("@MSPLL", dgvDiemDanhPLL[0, dgvDiemDanhPLL.CurrentRow.Index].Value.ToString());

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
            DialogResult blnDongY;
            blnDongY = MessageBox.Show("Bạn thật sự muốn thay đổi ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (blnDongY == DialogResult.Yes)
            {
                ThucThiLuu();
                MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }
    }
}
