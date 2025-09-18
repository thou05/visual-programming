namespace TH2_VD1
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKhachHang = new System.Windows.Forms.ListBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtSoTienGui = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTenKH = new System.Windows.Forms.TextBox();
            this.txtNgayGui = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoThuong = new System.Windows.Forms.RadioButton();
            this.rdoPhatLoc = new System.Windows.Forms.RadioButton();
            this.btnThemVao = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboThoiGianGui = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboThoiGianGui);
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnThemVao);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.txtNgayGui);
            this.groupBox1.Controls.Add(this.txtHoTenKH);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtSoTienGui);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(44, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 395);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng gửi tiết kiệm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên KH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số tiền gửi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thời gian gửi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày gửi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKhachHang);
            this.groupBox2.Location = new System.Drawing.Point(386, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(368, 335);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // lstKhachHang
            // 
            this.lstKhachHang.FormattingEnabled = true;
            this.lstKhachHang.Location = new System.Drawing.Point(27, 28);
            this.lstKhachHang.Name = "lstKhachHang";
            this.lstKhachHang.Size = new System.Drawing.Size(327, 277);
            this.lstKhachHang.TabIndex = 0;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(100, 37);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(108, 20);
            this.txtMaKH.TabIndex = 6;
            this.txtMaKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            this.txtMaKH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaKH_KeyPress);
            // 
            // txtSoTienGui
            // 
            this.txtSoTienGui.Location = new System.Drawing.Point(100, 154);
            this.txtSoTienGui.Name = "txtSoTienGui";
            this.txtSoTienGui.Size = new System.Drawing.Size(108, 20);
            this.txtSoTienGui.TabIndex = 7;
            this.txtSoTienGui.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoTienGui_KeyPress);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(100, 109);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(108, 20);
            this.txtDiaChi.TabIndex = 8;
            // 
            // txtHoTenKH
            // 
            this.txtHoTenKH.Location = new System.Drawing.Point(100, 74);
            this.txtHoTenKH.Name = "txtHoTenKH";
            this.txtHoTenKH.Size = new System.Drawing.Size(108, 20);
            this.txtHoTenKH.TabIndex = 9;
            // 
            // txtNgayGui
            // 
            this.txtNgayGui.Location = new System.Drawing.Point(100, 189);
            this.txtNgayGui.Name = "txtNgayGui";
            this.txtNgayGui.Size = new System.Drawing.Size(108, 20);
            this.txtNgayGui.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoPhatLoc);
            this.groupBox3.Controls.Add(this.rdoThuong);
            this.groupBox3.Location = new System.Drawing.Point(34, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 51);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Loại tiết kiệm";
            // 
            // rdoThuong
            // 
            this.rdoThuong.AutoSize = true;
            this.rdoThuong.Location = new System.Drawing.Point(16, 19);
            this.rdoThuong.Name = "rdoThuong";
            this.rdoThuong.Size = new System.Drawing.Size(62, 17);
            this.rdoThuong.TabIndex = 0;
            this.rdoThuong.TabStop = true;
            this.rdoThuong.Text = "Thường";
            this.rdoThuong.UseVisualStyleBackColor = true;
            // 
            // rdoPhatLoc
            // 
            this.rdoPhatLoc.AutoSize = true;
            this.rdoPhatLoc.Location = new System.Drawing.Point(115, 20);
            this.rdoPhatLoc.Name = "rdoPhatLoc";
            this.rdoPhatLoc.Size = new System.Drawing.Size(64, 17);
            this.rdoPhatLoc.TabIndex = 1;
            this.rdoPhatLoc.TabStop = true;
            this.rdoPhatLoc.Text = "Phát lộc";
            this.rdoPhatLoc.UseVisualStyleBackColor = true;
            // 
            // btnThemVao
            // 
            this.btnThemVao.Location = new System.Drawing.Point(47, 349);
            this.btnThemVao.Name = "btnThemVao";
            this.btnThemVao.Size = new System.Drawing.Size(75, 23);
            this.btnThemVao.TabIndex = 12;
            this.btnThemVao.Text = "&Thêm vào";
            this.btnThemVao.UseVisualStyleBackColor = true;
            this.btnThemVao.Click += new System.EventHandler(this.btnThemVao_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Location = new System.Drawing.Point(175, 347);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 13;
            this.btnThemMoi.Text = "Thêm &mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            this.btnThemMoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThemMoi_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(561, 405);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(656, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThoat_KeyDown);
            // 
            // cboThoiGianGui
            // 
            this.cboThoiGianGui.FormattingEnabled = true;
            this.cboThoiGianGui.Items.AddRange(new object[] {
            "1",
            "3",
            "6",
            "12"});
            this.cboThoiGianGui.Location = new System.Drawing.Point(110, 229);
            this.cboThoiGianGui.Name = "cboThoiGianGui";
            this.cboThoiGianGui.Size = new System.Drawing.Size(77, 21);
            this.cboThoiGianGui.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemVao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoPhatLoc;
        private System.Windows.Forms.RadioButton rdoThuong;
        private System.Windows.Forms.TextBox txtNgayGui;
        private System.Windows.Forms.TextBox txtHoTenKH;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoTienGui;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstKhachHang;
        private System.Windows.Forms.ComboBox cboThoiGianGui;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThoat;
    }
}

