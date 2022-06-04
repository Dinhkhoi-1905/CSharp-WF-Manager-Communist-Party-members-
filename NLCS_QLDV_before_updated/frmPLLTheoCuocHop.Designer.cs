
namespace NLCS_QLDV
{
    partial class frmPLLTheoCuocHop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPLLTheoCuocHop));
            this.cbbCuocHop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSDV = new System.Windows.Forms.TextBox();
            this.txtMSPLL = new System.Windows.Forms.TextBox();
            this.dgvDSDV = new System.Windows.Forms.DataGridView();
            this.btnDongForm = new System.Windows.Forms.Button();
            this.btnBangDanhGia = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbCuocHop
            // 
            this.cbbCuocHop.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.cbbCuocHop.FormattingEnabled = true;
            this.cbbCuocHop.Location = new System.Drawing.Point(238, 31);
            this.cbbCuocHop.Name = "cbbCuocHop";
            this.cbbCuocHop.Size = new System.Drawing.Size(273, 33);
            this.cbbCuocHop.TabIndex = 23;
            this.cbbCuocHop.SelectedIndexChanged += new System.EventHandler(this.cbbCuocHop_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(124, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 22;
            this.label6.Text = "Cuộc họp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Phiếu liên lạc theo cuộc họp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Họ tên Đảng viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(55, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã số Đảng viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(117, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Mã số PLL:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtHoTen.Location = new System.Drawing.Point(238, 70);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(273, 31);
            this.txtHoTen.TabIndex = 125;
            // 
            // txtMSDV
            // 
            this.txtMSDV.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMSDV.Location = new System.Drawing.Point(238, 107);
            this.txtMSDV.Name = "txtMSDV";
            this.txtMSDV.Size = new System.Drawing.Size(273, 31);
            this.txtMSDV.TabIndex = 126;
            // 
            // txtMSPLL
            // 
            this.txtMSPLL.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.txtMSPLL.Location = new System.Drawing.Point(238, 144);
            this.txtMSPLL.Name = "txtMSPLL";
            this.txtMSPLL.Size = new System.Drawing.Size(273, 31);
            this.txtMSPLL.TabIndex = 127;
            // 
            // dgvDSDV
            // 
            this.dgvDSDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDV.Location = new System.Drawing.Point(159, 264);
            this.dgvDSDV.Name = "dgvDSDV";
            this.dgvDSDV.RowHeadersWidth = 51;
            this.dgvDSDV.RowTemplate.Height = 24;
            this.dgvDSDV.Size = new System.Drawing.Size(392, 234);
            this.dgvDSDV.TabIndex = 128;
            this.dgvDSDV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSDV_CellClick);
            // 
            // btnDongForm
            // 
            this.btnDongForm.BackColor = System.Drawing.Color.DarkRed;
            this.btnDongForm.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongForm.ForeColor = System.Drawing.Color.Gold;
            this.btnDongForm.Location = new System.Drawing.Point(375, 520);
            this.btnDongForm.Name = "btnDongForm";
            this.btnDongForm.Size = new System.Drawing.Size(176, 57);
            this.btnDongForm.TabIndex = 129;
            this.btnDongForm.Text = "Đóng form";
            this.btnDongForm.UseVisualStyleBackColor = false;
            this.btnDongForm.Click += new System.EventHandler(this.btnDongForm_Click);
            // 
            // btnBangDanhGia
            // 
            this.btnBangDanhGia.BackColor = System.Drawing.Color.DarkRed;
            this.btnBangDanhGia.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangDanhGia.ForeColor = System.Drawing.Color.Gold;
            this.btnBangDanhGia.Location = new System.Drawing.Point(159, 520);
            this.btnBangDanhGia.Name = "btnBangDanhGia";
            this.btnBangDanhGia.Size = new System.Drawing.Size(210, 57);
            this.btnBangDanhGia.TabIndex = 130;
            this.btnBangDanhGia.Text = "Bảng đánh giá";
            this.btnBangDanhGia.UseVisualStyleBackColor = false;
            this.btnBangDanhGia.Click += new System.EventHandler(this.btnBangDanhGia_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbbCuocHop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMSPLL);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtMSDV);
            this.panel1.Controls.Add(this.txtHoTen);
            this.panel1.Location = new System.Drawing.Point(76, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 200);
            this.panel1.TabIndex = 131;
            // 
            // frmPLLTheoCuocHop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBangDanhGia);
            this.Controls.Add(this.btnDongForm);
            this.Controls.Add(this.dgvDSDV);
            this.Controls.Add(this.label1);
            this.Name = "frmPLLTheoCuocHop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu liên lạc theo cuộc họp";
            this.Load += new System.EventHandler(this.frmPLLTheoCuocHop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbCuocHop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSDV;
        private System.Windows.Forms.TextBox txtMSPLL;
        private System.Windows.Forms.DataGridView dgvDSDV;
        private System.Windows.Forms.Button btnDongForm;
        private System.Windows.Forms.Button btnBangDanhGia;
        private System.Windows.Forms.Panel panel1;
    }
}