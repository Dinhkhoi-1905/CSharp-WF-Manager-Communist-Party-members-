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
    public partial class frmDangNhap : Form
    {
        private frmMain fMain;
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(frmMain fm)
            : this()
        {
            fMain = fm;
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            lbDangNhap.BackColor = Color.Transparent;
            lbMatKhau.BackColor = Color.Transparent;
            lbTaiKhoan.BackColor = Color.Transparent;
            this.ControlBox = false;
            txtMatKhau.PasswordChar = '*';
            txtTaiKhoan.Focus();
            txtTaiKhoan.Text = "admin";
            txtMatKhau.Text = "123";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            SqlCommand cmdCommand;
            SqlDataReader drReader;
            string sqlSelect;
            try
            {
                MyPublics.ConnectDatabase();
                if (MyPublics.conMyConnection.State == ConnectionState.Open)
                {
                    //MyPublics.strMaCB = txtTaiKhoan.Text;
                    //strPasswordSV = myPublics.MaHoaPassword(txtMatKhau.Text);
                    sqlSelect = "Select username, password From QuanTriVien Where Username = @username And Password = @password";
                    cmdCommand = new SqlCommand(sqlSelect, MyPublics.conMyConnection);
                    cmdCommand.Parameters.AddWithValue("@username", txtTaiKhoan.Text);
                    cmdCommand.Parameters.AddWithValue("@password", txtMatKhau.Text);
                    drReader = cmdCommand.ExecuteReader();
                    if (drReader.HasRows)
                    {
                        //drReader.Read();
                        //MyPublics.strMaDV = drReader.GetString(0);
                        //MyPublics.strQuyenSD = drReader.GetString(1);
                        //drReader.Close();

                        MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyPublics.conMyConnection.Close();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTaiKhoan.Clear();
                        txtMatKhau.Clear();
                        txtTaiKhoan.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Kết nối không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi thực hiện kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
