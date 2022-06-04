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
    public partial class frmDanhSachDangVien : Form
    {
        public frmDanhSachDangVien()
        {
            InitializeComponent();
        }
        DataSet dsDangVien = new DataSet();
        DataView dvDangVien = new DataView();
        DataSet dsQueQuan = new DataSet();
        int ViTriTinh, ThemSua = 0;
        void DieuKhienKhiBinhThuong()
        {
            button1.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnDongForm.Enabled = true;
            btnChinhSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            cbbQueQuan.Enabled = true;

            txtMSDV.ReadOnly = true;
            txtMSDV.BackColor = Color.White;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;

            gbGioiTinh.Enabled = false;
            //cbQuyenSD.Enabled = false;
            dgvDanhSachDangVien.Enabled = true;
            txtDiaChi.ReadOnly = true;
            txtDiaChi.BackColor = Color.White;
            txtSDT.ReadOnly = true;
            txtSDT.BackColor = Color.White;

            dtpNgayVaoDang.Enabled = false;
            dtpNgayChinhThuc.Enabled = false;
            dtpNgaySinh.Enabled = false;
        }

        void GanDuLieu()
        {
            if (dvDangVien.Count > 0)
            {
                txtMSDV.Text = dgvDanhSachDangVien[0, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString();
                txtHoTen.Text = dgvDanhSachDangVien[1, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString();
                if (dgvDanhSachDangVien[2, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString() == "Nam")
                    rbNam.Checked = true;
                else
                    rbNu.Checked = true;
                dtpNgaySinh.Value = DateTime.Parse(dgvDanhSachDangVien[3, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString());

                dtpNgayVaoDang.Value = DateTime.Parse(dgvDanhSachDangVien[5, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString());
                dtpNgayChinhThuc.Value = DateTime.Parse(dgvDanhSachDangVien[6, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString());
                txtDiaChi.Text = dgvDanhSachDangVien[7, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString();
                txtSDT.Text = dgvDanhSachDangVien[8, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString();

                MyPublics.strMSDV = txtMSDV.Text;
                MyPublics.NgayvaoDang = dtpNgayVaoDang.Value;
            }
            else
            {
                txtMSDV.Clear();
                txtHoTen.Clear();
                rbNam.Checked = true;
                dtpNgaySinh.Value = DateTime.Today;
            }
        }
        void NhanDuLieu()
        {
            // Nhận danh sách Đảng viên
            string strSelect = "Select * From DangVien";
            MyPublics.OpenData(strSelect, dsDangVien, "DangVien");
        }
        private void frmDanhSachDangVien_Load(object sender, EventArgs e)
        {
            //Giao dien
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            lbTitle.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            rbNam.BackColor = Color.Transparent;
            rbNu.BackColor = Color.Transparent;
            gbGioiTinh.BackColor = Color.White;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;


            NhanDuLieu();
            //combobox Quê quán:
                string strSelect = "Select distinct QueQuan From DangVien";
                MyPublics.OpenData(strSelect, dsQueQuan, "DangVien");
                cbbQueQuan.DataSource = dsQueQuan.Tables["DangVien"];
                cbbQueQuan.DisplayMember = "Quequan";
                cbbQueQuan.ValueMember = "Quequan";
                cbbQueQuan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbbQueQuan.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Gán dữ liệu cho dataview và lọc ĐV theo quê quán:
                dvDangVien.Table = dsDangVien.Tables["DangVien"];
                dvDangVien.RowFilter = "Quequan like '" + cbbQueQuan.SelectedValue + "'";
                dgvDanhSachDangVien.DataSource = dvDangVien;

            //dgvDanhSachDangVien.DataSource = dsDangVien;
            //dgvDanhSachDangVien.DataMember = "DangVien";


            dgvDanhSachDangVien.AllowUserToAddRows = false;
            dgvDanhSachDangVien.AllowUserToDeleteRows = false;
            dgvDanhSachDangVien.Width = 1080;
            dgvDanhSachDangVien.Columns[0].Width = 75;
            dgvDanhSachDangVien.Columns[0].HeaderText = "Mã ĐV";
            dgvDanhSachDangVien.Columns[1].Width = 150;
            dgvDanhSachDangVien.Columns[1].HeaderText = "Họ tên";
            dgvDanhSachDangVien.Columns[2].Width = 50;
            dgvDanhSachDangVien.Columns[2].HeaderText = "Phái";
            dgvDanhSachDangVien.Columns[3].Width = 100;
            dgvDanhSachDangVien.Columns[3].HeaderText = "Ngày sinh";
            dgvDanhSachDangVien.Columns[4].Width = 100;
            dgvDanhSachDangVien.Columns[4].HeaderText = "Quê quán";
            dgvDanhSachDangVien.Columns[5].Width = 100;
            dgvDanhSachDangVien.Columns[5].HeaderText = "Ngày vào Đảng";
            dgvDanhSachDangVien.Columns[6].Width = 100;
            dgvDanhSachDangVien.Columns[6].HeaderText = "ĐV chính thức";
            dgvDanhSachDangVien.Columns[7].Width = 250;
            dgvDanhSachDangVien.Columns[7].HeaderText = "Nơi cư trú";
            dgvDanhSachDangVien.Columns[8].Width = 100;
            dgvDanhSachDangVien.Columns[8].HeaderText = "SĐT";
            dgvDanhSachDangVien.AllowUserToAddRows = false;
            dgvDanhSachDangVien.AllowUserToDeleteRows = false;
            dgvDanhSachDangVien.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienKhiBinhThuong();
        }

        private void cbbQueQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cbbQueQuan.SelectedIndex != -1) && (ThemSua == 0))
            {
                dvDangVien.RowFilter = "Quequan like '" + cbbQueQuan.SelectedValue + "'";
                dgvDanhSachDangVien.DataSource = dvDangVien;
                GanDuLieu();
            }
            else
            {
                dvDangVien.RowFilter = "Quequan like '" + cbbQueQuan.SelectedValue + "'";
                dgvDanhSachDangVien.DataSource = dvDangVien;
            }
        }

        private void dgvDanhSachDangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void DieuKhienKhiThem()
        {
            button1.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtMSDV.ReadOnly = false;
            txtHoTen.ReadOnly = false;
            dtpNgaySinh.Value = DateTime.Today;
            gbGioiTinh.Enabled = true;
            rbNam.Checked = true;
            cbbQueQuan.Enabled = false;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            dtpNgayVaoDang.Enabled = true;
            dtpNgayChinhThuc.Enabled = true;
            dtpNgaySinh.Enabled = true;

            dtpNgayVaoDang.Value = DateTime.Today;
            dtpNgayChinhThuc.Value = DateTime.Today;
            dgvDanhSachDangVien.Enabled = false;
            txtMSDV.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtMSDV.Focus();
        }
        void DieuKhienKhiChinhSua()
        {
            button1.Enabled = false;
            btnThem.Enabled = false;
            btnChinhSua.Enabled = false;
            btnLuu.Enabled = true;
            btnKhongLuu.Enabled = true;
            btnXoa.Enabled = false;
            btnDongForm.Enabled = false;
            txtHoTen.ReadOnly = false;
            gbGioiTinh.Enabled = true;
            cbbQueQuan.Enabled = true;
            txtDiaChi.ReadOnly = false;
            txtSDT.ReadOnly = false;
            dtpNgayVaoDang.Enabled = true;
            dtpNgayChinhThuc.Enabled = true;
            dtpNgaySinh.Enabled = true;

            //cbQuyenSD.Enabled = true;
            dgvDanhSachDangVien.Enabled = false;
            txtHoTen.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemSua = 1;
            ViTriTinh = cbbQueQuan.SelectedIndex;
            DieuKhienKhiThem();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            ThemSua = 2;
            ViTriTinh = cbbQueQuan.SelectedIndex;
            DieuKhienKhiChinhSua();
        }

        void ThucThiLuu()
        {
            string strSql, strPhai = "Nam", strQuequan;
            if (ThemSua == 1)
                strSql = "Insert Into DangVien Values(@MSDV, @HoTen, @GioiTinh, @NgaySinh, @QueQuan, @NgayVaoDang, @DVChinhThuc, @NoiCuTru, @SDT)";
            else
                strSql = "Update DangVien Set Hoten = @HoTen, Gioitinh=@GioiTinh, Ngaysinh = @NgaySinh, Quequan = @QueQuan, Ngayvaodang = @NgayVaoDang, Ngayvaodangct=@DVChinhThuc, Diachicutru=@NoiCuTru, SDT=@SDT Where MSDV = @MSDV";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSDV", txtMSDV.Text.Trim());
            cmdCommand.Parameters.AddWithValue("@HoTen", txtHoTen.Text.Trim());
            //cmdCommand.Parameters.AddWithValue("@Ten", txtTen.Text);
            if (rbNu.Checked)
                strPhai = "Nu";
            cmdCommand.Parameters.AddWithValue("@GioiTinh", strPhai);
            cmdCommand.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
            strQuequan = cbbQueQuan.SelectedValue.ToString();
            cmdCommand.Parameters.AddWithValue("@QueQuan", strQuequan);
            cmdCommand.Parameters.AddWithValue("@NgayVaoDang", dtpNgayVaoDang.Value);
            cmdCommand.Parameters.AddWithValue("@DVChinhThuc", dtpNgayChinhThuc.Value);
            cmdCommand.Parameters.AddWithValue("@NoiCuTru", txtDiaChi.Text.Trim());
            cmdCommand.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());

            // Lưu dữ liệu về Server
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            // Xóa dữ liệu cũ và nhận lại dữ liệu cho DataSet
            int curRow = dgvDanhSachDangVien.CurrentRow.Index;
            dsDangVien.Clear();
            ThemSua = 0;
            NhanDuLieu();
            if (cbbQueQuan.SelectedIndex == ViTriTinh)
                dgvDanhSachDangVien.CurrentCell = dgvDanhSachDangVien[0, curRow];
            else
                cbbQueQuan.SelectedIndex = ViTriTinh;
            if (dvDangVien.Count > 0)
                dgvDanhSachDangVien.CurrentCell = dgvDanhSachDangVien[0, 0];
            DieuKhienKhiBinhThuong();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMSDV.Text.Trim().Length > 5)
            {
                MessageBox.Show("Mã số Đảng viên gồm 5 kí tự", "Lỗi", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMSDV.Focus();
                return;
            }
            if (txtMSDV.Text == "")
            {
                MessageBox.Show("Chưa nhập mã số Đảng viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSDV.Focus();
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (txtSDT.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSDT.Focus();
                return;
            }
            if (txtHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ cư trú", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDiaChi.Focus();
                return;
            }
            if ((ThemSua == 1) && (MyPublics.TonTaiKhoaChinh(txtMSDV.Text, "MSDV", "DangVien")))
            {
                MessageBox.Show("Mã số Đảng viên đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMSDV.Focus();
                txtMSDV.Clear();
            }
            else
            {
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
            if (MyPublics.TonTaiKhoaChinh(txtMSDV.Text, "MSDV", "DVDangCuTru"))
                MessageBox.Show("Phải xóa các thông tin liên quan của Đảng viên trước !");
            else
            {
                DialogResult blnDongY;
                blnDongY = MessageBox.Show("Bạn thật sự muốn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (blnDongY == DialogResult.Yes)
                {
                    string strDelete = "Delete DangVien Where MSDV = @MSDV";
                    if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                        MyPublics.conMyConnection.Open();
                    SqlCommand cmdCommand = new SqlCommand(strDelete, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@MSDV", txtMSDV.Text);
                    // Lưu dữ liệu về Server
                    cmdCommand.ExecuteNonQuery();
                    MyPublics.conMyConnection.Close();
                    // Cập nhật dữ liệu cho DataSet
                    int curRow = dgvDanhSachDangVien.CurrentRow.Index;
                    dvDangVien.Delete(curRow);
                    GanDuLieu();
                    MessageBox.Show("Thao tác thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            DieuKhienKhiBinhThuong();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThongTinKhac fr = new frmThongTinKhac();
            fr.ShowDialog();
        }

        private void cbbQueQuan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if ((cbbQueQuan.SelectedIndex != -1) && (ThemSua == 0))
            {
                dvDangVien.RowFilter = "Quequan like '" + cbbQueQuan.SelectedValue + "'";
                dgvDanhSachDangVien.DataSource = dvDangVien;
                GanDuLieu();
            }
            else
            {
                dvDangVien.RowFilter = "Quequan like '" + cbbQueQuan.SelectedValue + "'";
                dgvDanhSachDangVien.DataSource = dvDangVien;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
