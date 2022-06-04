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
    public partial class frmPLLTheoCuocHop : Form
    {
        public frmPLLTheoCuocHop()
        {
            InitializeComponent();
        }
        DataSet dsDV = new DataSet();
        DataView dvDV = new DataView();
        DataSet dsCuocHop = new DataSet();
        SqlDataReader drDV;
        void GanDuLieu()
        {
            if (dvDV.Count > 0)
            {
                txtMSDV.Text = dgvDSDV[0, dgvDSDV.CurrentRow.Index].Value.ToString();
                txtMSPLL.Text = dgvDSDV[1, dgvDSDV.CurrentRow.Index].Value.ToString();

                //txtHoTen.Text = dgvDSDV[1, dgvDanhSachDangVien.CurrentRow.Index].Value.ToString();

                //Gan du lieu ten dang vien
                SqlCommand cmdCommand = new SqlCommand();
                cmdCommand.Connection = MyPublics.conMyConnection;
                cmdCommand.CommandText = "select Hoten from DangVien where MSDV = '" + txtMSDV.Text + "'";
                MyPublics.conMyConnection.Open();
                drDV = cmdCommand.ExecuteReader();
                while (drDV.Read())
                {
                    txtHoTen.Text = drDV[0].ToString();
                }
                drDV.Close();
                MyPublics.conMyConnection.Close();

                MyPublics.strHoTen = txtHoTen.Text;
                MyPublics.strMSDV = txtMSDV.Text;
                MyPublics.strMSPLL = txtMSPLL.Text;
            }
            else
            {
                txtMSDV.Clear();
                txtHoTen.Clear();
                txtMSPLL.Clear();
            }
        }
        void DieuKhienBinhThuong()
        {
            txtMSPLL.ReadOnly = true;
            txtMSDV.ReadOnly = true;
            txtHoTen.ReadOnly = true;
            txtHoTen.BackColor = Color.White;
            txtMSDV.BackColor = Color.White;
            txtMSPLL.BackColor = Color.White;
        }
        void NhanDuLieu()
        {
            // Nhận danh sách Đảng viên
            string strSelect = "Select MSDV, MSPLL, MSCH From PhieuLienLac";
            MyPublics.OpenData(strSelect, dsDV, "PhieuLienLac");
        }
        private void frmPLLTheoCuocHop_Load(object sender, EventArgs e)
        {
            //Giao dien
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;

            //
            NhanDuLieu();
            //combobox Cuộc họp:
            string strSelect = "Select distinct MSCH, Tencuochop From CuocHop";
            MyPublics.OpenData(strSelect, dsCuocHop, "PhieuLienLac");
            cbbCuocHop.DataSource = dsCuocHop.Tables["PhieuLienLac"];
            cbbCuocHop.DisplayMember = "Tencuochop";
            cbbCuocHop.ValueMember = "MSCH";
            cbbCuocHop.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbbCuocHop.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Gán dữ liệu cho dataview và lọc ĐV theo cuộc họp
            dvDV.Table = dsDV.Tables["PhieuLienLac"];
            dvDV.RowFilter = "MSCH like '" + cbbCuocHop.SelectedValue + "'";
            dgvDSDV.DataSource = dvDV;

            dgvDSDV.AllowUserToAddRows = false;
            dgvDSDV.AllowUserToDeleteRows = false;
            dgvDSDV.Width = 320;
            dgvDSDV.Columns[0].Width = 100;
            dgvDSDV.Columns[0].HeaderText = "Mã ĐV";
            dgvDSDV.Columns[1].Width = 75;
            dgvDSDV.Columns[1].HeaderText = "Mã PLL";
            dgvDSDV.Columns[2].Width = 75;
            dgvDSDV.Columns[2].HeaderText = "Mã CH";
            dgvDSDV.AllowUserToAddRows = false;
            dgvDSDV.AllowUserToDeleteRows = false;
            dgvDSDV.EditMode = DataGridViewEditMode.EditProgrammatically;
            GanDuLieu();
            DieuKhienBinhThuong();
        }

        private void cbbCuocHop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbCuocHop.SelectedIndex != -1)
            {
                dvDV.RowFilter = "MSCH like '" + cbbCuocHop.SelectedValue + "'";
                dgvDSDV.DataSource = dvDV;
                GanDuLieu();
            }
            else
            {
                dvDV.RowFilter = "Quequan like '" + cbbCuocHop.SelectedValue + "'";
                dgvDSDV.DataSource = dvDV;
            }
        }

        private void dgvDSDV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GanDuLieu();
        }

        private void btnDongForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBangDanhGia_Click(object sender, EventArgs e)
        {
            frmBangDanhGia fr = new frmBangDanhGia();
            fr.ShowDialog();
        }
    }
}
