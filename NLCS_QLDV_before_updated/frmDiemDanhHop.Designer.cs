
namespace NLCS_QLDV
{
    partial class frmDiemDanhHop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiemDanhHop));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDiemDanh = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTenCH = new System.Windows.Forms.TextBox();
            this.txtMSDV = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbThamGia = new System.Windows.Forms.GroupBox();
            this.rbVangCP = new System.Windows.Forms.RadioButton();
            this.rbVang = new System.Windows.Forms.RadioButton();
            this.rbCo = new System.Windows.Forms.RadioButton();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnKhongLuu = new System.Windows.Forms.Button();
            this.btnDongForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).BeginInit();
            this.gbThamGia.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 32);
            this.label1.TabIndex = 118;
            this.label1.Text = "Thông tin điểm danh";
            // 
            // dgvDiemDanh
            // 
            this.dgvDiemDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemDanh.Location = new System.Drawing.Point(153, 341);
            this.dgvDiemDanh.Name = "dgvDiemDanh";
            this.dgvDiemDanh.RowHeadersWidth = 51;
            this.dgvDiemDanh.RowTemplate.Height = 24;
            this.dgvDiemDanh.Size = new System.Drawing.Size(504, 404);
            this.dgvDiemDanh.TabIndex = 119;
            this.dgvDiemDanh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiemDanh_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(88, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 25);
            this.label2.TabIndex = 120;
            this.label2.Text = "Mã số Đảng viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(153, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 121;
            this.label3.Text = "Họ và tên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(120, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 122;
            this.label4.Text = "Tên cuộc họp:";
            // 
            // txtTenCH
            // 
            this.txtTenCH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtTenCH.Location = new System.Drawing.Point(288, 39);
            this.txtTenCH.Name = "txtTenCH";
            this.txtTenCH.Size = new System.Drawing.Size(225, 31);
            this.txtTenCH.TabIndex = 123;
            this.txtTenCH.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMSDV
            // 
            this.txtMSDV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMSDV.Location = new System.Drawing.Point(288, 76);
            this.txtMSDV.Name = "txtMSDV";
            this.txtMSDV.Size = new System.Drawing.Size(225, 31);
            this.txtMSDV.TabIndex = 124;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.Location = new System.Drawing.Point(288, 113);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(225, 31);
            this.txtHoTen.TabIndex = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(156, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 25);
            this.label5.TabIndex = 126;
            this.label5.Text = "Tham gia:";
            // 
            // gbThamGia
            // 
            this.gbThamGia.Controls.Add(this.rbVangCP);
            this.gbThamGia.Controls.Add(this.rbVang);
            this.gbThamGia.Controls.Add(this.rbCo);
            this.gbThamGia.Location = new System.Drawing.Point(288, 159);
            this.gbThamGia.Name = "gbThamGia";
            this.gbThamGia.Size = new System.Drawing.Size(224, 57);
            this.gbThamGia.TabIndex = 127;
            this.gbThamGia.TabStop = false;
            // 
            // rbVangCP
            // 
            this.rbVangCP.AutoSize = true;
            this.rbVangCP.Location = new System.Drawing.Point(139, 30);
            this.rbVangCP.Name = "rbVangCP";
            this.rbVangCP.Size = new System.Drawing.Size(84, 21);
            this.rbVangCP.TabIndex = 2;
            this.rbVangCP.TabStop = true;
            this.rbVangCP.Text = "Vắng CP";
            this.rbVangCP.UseVisualStyleBackColor = true;
            // 
            // rbVang
            // 
            this.rbVang.AutoSize = true;
            this.rbVang.Location = new System.Drawing.Point(63, 30);
            this.rbVang.Name = "rbVang";
            this.rbVang.Size = new System.Drawing.Size(62, 21);
            this.rbVang.TabIndex = 1;
            this.rbVang.TabStop = true;
            this.rbVang.Text = "Vắng";
            this.rbVang.UseVisualStyleBackColor = true;
            // 
            // rbCo
            // 
            this.rbCo.AutoSize = true;
            this.rbCo.Location = new System.Drawing.Point(6, 30);
            this.rbCo.Name = "rbCo";
            this.rbCo.Size = new System.Drawing.Size(46, 21);
            this.rbCo.TabIndex = 0;
            this.rbCo.TabStop = true;
            this.rbCo.Text = "Có";
            this.rbCo.UseVisualStyleBackColor = true;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.DarkRed;
            this.btnChinhSua.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.Gold;
            this.btnChinhSua.Location = new System.Drawing.Point(95, 775);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(152, 58);
            this.btnChinhSua.TabIndex = 128;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DarkRed;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Gold;
            this.btnLuu.Location = new System.Drawing.Point(253, 775);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(152, 58);
            this.btnLuu.TabIndex = 129;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnKhongLuu
            // 
            this.btnKhongLuu.BackColor = System.Drawing.Color.DarkRed;
            this.btnKhongLuu.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhongLuu.ForeColor = System.Drawing.Color.Gold;
            this.btnKhongLuu.Location = new System.Drawing.Point(411, 775);
            this.btnKhongLuu.Name = "btnKhongLuu";
            this.btnKhongLuu.Size = new System.Drawing.Size(152, 58);
            this.btnKhongLuu.TabIndex = 130;
            this.btnKhongLuu.Text = "Không lưu";
            this.btnKhongLuu.UseVisualStyleBackColor = false;
            this.btnKhongLuu.Click += new System.EventHandler(this.btnKhongLuu_Click);
            // 
            // btnDongForm
            // 
            this.btnDongForm.BackColor = System.Drawing.Color.DarkRed;
            this.btnDongForm.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongForm.ForeColor = System.Drawing.Color.Gold;
            this.btnDongForm.Location = new System.Drawing.Point(569, 775);
            this.btnDongForm.Name = "btnDongForm";
            this.btnDongForm.Size = new System.Drawing.Size(139, 58);
            this.btnDongForm.TabIndex = 131;
            this.btnDongForm.Text = "Đóng form";
            this.btnDongForm.UseVisualStyleBackColor = false;
            this.btnDongForm.Click += new System.EventHandler(this.btnDongForm_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenCH);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMSDV);
            this.panel1.Controls.Add(this.gbThamGia);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(100, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 239);
            this.panel1.TabIndex = 132;
            // 
            // frmDiemDanhHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 890);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDongForm);
            this.Controls.Add(this.btnKhongLuu);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.dgvDiemDanh);
            this.Controls.Add(this.label1);
            this.Name = "frmDiemDanhHop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điểm danh cuộc họp";
            this.Load += new System.EventHandler(this.frmDiemDanhHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemDanh)).EndInit();
            this.gbThamGia.ResumeLayout(false);
            this.gbThamGia.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDiemDanh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTenCH;
        private System.Windows.Forms.TextBox txtMSDV;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbThamGia;
        private System.Windows.Forms.RadioButton rbVangCP;
        private System.Windows.Forms.RadioButton rbVang;
        private System.Windows.Forms.RadioButton rbCo;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnKhongLuu;
        private System.Windows.Forms.Button btnDongForm;
        private System.Windows.Forms.Panel panel1;
    }
}