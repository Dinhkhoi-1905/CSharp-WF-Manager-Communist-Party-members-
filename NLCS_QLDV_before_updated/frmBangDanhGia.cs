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
    public partial class frmBangDanhGia : Form
    {
        public frmBangDanhGia()
        {
            InitializeComponent();
        }
        SqlDataReader drDV;
        void ConvertRB(RadioButton rb1, RadioButton rb2, RadioButton rb3, int i)
        {
            if (int.Parse(drDV[i].ToString()) == 1)
            {
                rb1.Checked = true;
            }
            else if (int.Parse(drDV[i].ToString()) == 2)
            {
                rb2.Checked = true;
            }
            else { rb3.Checked = true; }
        }
        void DieuKhienBinhThuong()
        {
            txtHoTen.ReadOnly = true;
            txtMSDV.ReadOnly = true;
            panel1.Enabled = false;
            panel2.Enabled = false;
            panel3.Enabled = false;
            panel4.Enabled = false;
            panel5.Enabled = false;
            panel6.Enabled = false;
            //button
            btnChinhSua.Enabled = true;
            btnLuu.Enabled = false;
            btnKhongLuu.Enabled = false;
            btnThoat.Enabled = true;
        }
        void GanDuLieu()
        {
            txtMSDV.Text = MyPublics.strMSDV;
            txtHoTen.Text = MyPublics.strHoTen;
            SqlCommand cmdCommand = new SqlCommand();
            cmdCommand.Connection = MyPublics.conMyConnection;
            cmdCommand.CommandText = "select Tieuchi1,Tieuchi2,Tieuchi3,Tieuchi4,Tieuchi5,Tieuchi6 from BangDanhGiaCuaPLL where MSPLL = '" + MyPublics.strMSPLL + "'";
            MyPublics.conMyConnection.Open();
            drDV = cmdCommand.ExecuteReader();
            //MessageBox.Show("Mã số Đảng viên này đã có rồi!" + MyPublics.strMSPLL);
            while (drDV.Read())
            {
                ConvertRB(rbTC11, rbTC12, rbTC13, 0);
                ConvertRB(rbTC21, rbTC22, rbTC23, 1);
                ConvertRB(rbTC31, rbTC32, rbTC33, 2);
                ConvertRB(rbTC41, rbTC42, rbTC43, 3);
                ConvertRB(rbTC51, rbTC52, rbTC53, 4);
                ConvertRB(rbTC61, rbTC62, rbTC63, 5);
            }
            drDV.Close();
            MyPublics.conMyConnection.Close();
        }
        private void frmBangDanhGia_Load(object sender, EventArgs e)
        {
            //giao dien
            panel1.BackColor = Color.FromArgb(125, Color.White);
            panel2.BackColor = Color.FromArgb(125, Color.White);
            panel3.BackColor = Color.FromArgb(125, Color.White);
            panel4.BackColor = Color.FromArgb(125, Color.White);
            panel5.BackColor = Color.FromArgb(125, Color.White);
            panel6.BackColor = Color.FromArgb(125, Color.White);
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ControlBox = false;

            GanDuLieu();
            DieuKhienBinhThuong();
        }
        void DieuKhienKhiChinhSua()
        {
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            //button
            btnChinhSua.Enabled = false;
            btnKhongLuu.Enabled = true;
            btnLuu.Enabled = true;
            btnThoat.Enabled = false;
        }
        int ReverseRB(RadioButton rb1, RadioButton rb2, RadioButton rb3)
        {
            if (rb1.Checked == true)
                return 1;
            else if (rb2.Checked == true)
                return 2;
            else return 3;
        }
        void ThucThiLuu()
        {
            string strSql;
            strSql = "Update BangDanhGiaCuaPLL Set Tieuchi1 = @tc1,Tieuchi2 = @tc2,Tieuchi3 = @tc3,Tieuchi4= @tc4,Tieuchi5 = @tc5,Tieuchi6 = @tc6 Where MSPLL = @MSPLL";
            if (MyPublics.conMyConnection.State == ConnectionState.Closed)
                MyPublics.conMyConnection.Open();
            SqlCommand cmdCommand = new SqlCommand(strSql, MyPublics.conMyConnection);
            cmdCommand.Parameters.AddWithValue("@MSPLL", MyPublics.strMSPLL);

            cmdCommand.Parameters.AddWithValue("@tc1", ReverseRB(rbTC11,rbTC12,rbTC13));
            cmdCommand.Parameters.AddWithValue("@tc2", ReverseRB(rbTC21, rbTC22, rbTC23));
            cmdCommand.Parameters.AddWithValue("@tc3", ReverseRB(rbTC31, rbTC32, rbTC33));
            cmdCommand.Parameters.AddWithValue("@tc4", ReverseRB(rbTC41, rbTC42, rbTC43));
            cmdCommand.Parameters.AddWithValue("@tc5", ReverseRB(rbTC51, rbTC52, rbTC53));
            cmdCommand.Parameters.AddWithValue("@tc6", ReverseRB(rbTC61, rbTC62, rbTC63));

            // Lưu dữ liệu về Server
            cmdCommand.ExecuteNonQuery();
            MyPublics.conMyConnection.Close();
            DieuKhienBinhThuong();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DieuKhienKhiChinhSua();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ThucThiLuu();
            MessageBox.Show("Thay đổi thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKhongLuu_Click(object sender, EventArgs e)
        {
            DieuKhienBinhThuong();
        }
    }
}
