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
    public partial class frmDanhSachCuocHop : Form
    {
        public frmDanhSachCuocHop()
        {
            InitializeComponent();
        }
        DataSet dsCuocHop = new DataSet();
        int ThemSua = 0;
        void DieuKhienKhiBinhThuong()
        {
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDongForm.Enabled = true;
            btnChinhSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;

            txtMSCH.ReadOnly = true;
            txtMSCH.BackColor = Color.White;
            txtTenCH.ReadOnly = true;
            txtTenCH.BackColor = Color.White;
            dtpTGHop.Enabled = false;
            dtpTGNhanPLL.Enabled = false;
            txtDiaDiemHop.ReadOnly = true;
            txtDiaDiemHop.BackColor = Color.White;
            txtDDNhanPLL.ReadOnly = true;
            txtDDNhanPLL.BackColor = Color.White;
            dgvDanhSachCuocHop.Enabled = true;

        }
        void GanDuLieu()
        {
            txtMSCH.Text = dgvDanhSachCuocHop[0, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString();
            txtTenCH.Text = dgvDanhSachCuocHop[1, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString();
            dtpTGHop.Value = DateTime.Parse(dgvDanhSachCuocHop[2, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString());
            txtDiaDiemHop.Text = dgvDanhSachCuocHop[3, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString();
            dtpTGNhanPLL.Value = DateTime.Parse(dgvDanhSachCuocHop[4, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString());
            txtDDNhanPLL.Text = dgvDanhSachCuocHop[5, dgvDanhSachCuocHop.CurrentRow.Index].Value.ToString();

            //gan du lieu cho frm diem danh:
            MyPublics.strMaCuocHop = txtMSCH.Text;
            MyPublics.strTenCuocHop = txtTenCH.Text;
        }
        void NhanDuLieu()
        {
            string strSelect = "Select * From CuocHop";
            MyPublics.OpenData(strSelect, dsCuocHop, "CuocHop");
        }
        private void frmDanhSachCuocHop_Load(object sender, EventArgs e)
        {
            //giao dien
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //
            NhanDuLieu();
            dgvDanhSachCuocHop.DataSource = dsCuocHop;
            dgvDanhSachCuocHop.DataMember = "CuocHop";

            dgvDanhSachCuocHop.AllowUserToAddRows = false;
            dgvDanhSachCuocHop.AllowUserToDeleteRows = false;
            dgvDanhSachCuocHop.Width = 975;
            dgvDanhSachCuocHop.Columns[0].Width = 75;
            dgvDanhSachCuocHop.Columns[0].HeaderText = "Mã cuộc họp";
            dgvDanhSachCuocHop.Columns[1].Width = 150;
            dgvDanhSachCuocHop.Columns[1].HeaderText = "Tên cuộc họp";
            dgvDanhSachCuocHop.Columns[2].Width = 150;
            dgvDanhSachCuocHop.Columns[2].HeaderText = "Thời gian họp";
            dgvDanhSachCuocHop.Columns[3].Width = 200;
            dgvDanhSachCuocHop.Columns[3].HeaderText = "Địa điểm họp";
            dgvDanhSachCuocHop.Columns[4].Width = 150;
            dgvDanhSachCuocHop.Columns[4].HeaderText = "Thời gian nhận PLL";
            dgvDanhSachCuocHop.Columns[5].Width = 200;
            dgvDanhSachCuocHop.Columns[5].HeaderText = "Địa điểm nhận PLL";
            dgvDanhSachCuocHop.AllowUserToAddRows = false;
            dgvDanhSachCuocHop.AllowUserToDeleteRows = false;
            dgvDanhSachCuocHop.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void dgvDanhSachCuocHop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void DieuKhienKhiThem()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;

            txtMSCH.ReadOnly = false;
            txtTenCH.ReadOnly = false;
            dtpTGHop.Enabled = true;
            dtpTGNhanPLL.Enabled = true;
            txtDiaDiemHop.ReadOnly = false;
            txtDDNhanPLL.ReadOnly = false;

            dgvDanhSachCuocHop.Enabled = false;
            txtMSCH.Clear();
            txtTenCH.Clear();
            txtDiaDiemHop.Clear();
            txtDDNhanPLL.Clear();
            txtMSCH.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;

            //txtMSCH.ReadOnly = false;
            txtTenCH.ReadOnly = false;
            dtpTGHop.Enabled = true;
            dtpTGNhanPLL.Enabled = true;
            txtDiaDiemHop.ReadOnly = false;
            txtDDNhanPLL.ReadOnly = false;

            //cbQuyenSD.Enabled = true;
            dgvDanhSachCuocHop.Enabled = false;
            txtTenCH.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            DieuKhienKhiChinhSua();
        }
        void ThucThiLuu()
        {
            string strSql;
            if (ThemSua == 1)
                strSql = "Insert Into CuocHop Values(@MSCH, @TenCH, @TGHop, @DDHop, @TGNhanPLL, @DDNhanPLL)";
            else
                strSql = "Update CuocHop Set Tencuochop = @TenCH,Thoigian=@TGHop,Diadiem=@DDHop,ThoigianphatPLL=@TGNhanPLL,DiadiemphatPLL=@DDNhanPLL Where MSCH = @MSCH";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSCH", txtMSCH.Text.Trim());
            cmdCommand.Parameters.AddWithValue("@TenCH", txtTenCH.Text.Trim());
            cmdCommand.Parameters.AddWithValue("@TGHop", dtpTGHop.Value);
            cmdCommand.Parameters.AddWithValue("@DDHop", txtDiaDiemHop.Text.Trim());
            cmdCommand.Parameters.AddWithValue("@TGNhanPLL", dtpTGNhanPLL.Value);
            cmdCommand.Parameters.AddWithValue("@DDNhanPLL", txtDDNhanPLL.Text.Trim());

            // Lưu dữ liệu về Server
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            // Xóa dữ liệu cũ và nhận lại dữ liệu cho DataSet
            dsCuocHop.Clear();
            ThemSua = 0;
            NhanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMSCH.Text.Trim().Length > 6)
            {
                MessageBox.Show("Mã số cuộc họp không được quá 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMSCH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mã số Cuộc họp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSCH.Focus();
                return;
            }
            if (txtTenCH.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập Tên cuộc họp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenCH.Focus();
                return;
            }
            if (txtDiaDiemHop.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập địa điểm cuộc họp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaDiemHop.Focus();
                return;
            }
            if (txtDDNhanPLL.Text.Trim() == "")
            {
                MessageBox.Show("Lỗi chưa nhập địa nhận phiếu liên lạc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDDNhanPLL.Focus();
                return;
            }
            if ((ThemSua == 1) && (MyPublics.TonTaiKhoaChinh(txtMSCH.Text, "MSCH", "CuocHop")))
            {
                MessageBox.Show("Mã số cuộc họp này đã có rồi!");
                txtMSCH.Focus();
                txtMSCH.Clear();
            }
            else { 

                ThucThiLuu();
                MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            ThemSua = 0;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MyPublics.TonTaiKhoaChinh(txtMSCH.Text, "MSCH", "PhieuLienLac"))
                MessageBox.Show("Phải xóa phiếu liên lạc của cuộc họp này trước !");
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDelete = "Delete CuocHop Where MSCH = @MSCH";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSCH", txtMSCH.Text);
                    // Lưu dữ liệu về Server
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    // Cập nhật dữ liệu cho DataSet
                    dsCuocHop.Tables["CuocHop"].Rows.RemoveAt(dgvDanhSachCuocHop.CurrentRow.Index);
                    GanDuLieu();
                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void btnDiemDanh_Click(object sender, EventArgs e)
        {
            
            frmDiemDanhHop dd = new frmDiemDanhHop();
            dd.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDiemDanhNhanPLL fr = new frmDiemDanhNhanPLL();
            fr.ShowDialog();
        }
    }
}
