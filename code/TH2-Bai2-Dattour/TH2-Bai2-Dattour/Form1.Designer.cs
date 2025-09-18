namespace TH2_Bai2_Dattour
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
            this.cboSoLuong = new System.Windows.Forms.ComboBox();
            this.btnThemmoi = new System.Windows.Forms.Button();
            this.btnThemDS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDoUong = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGiaduthuyen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoNuaNgay = new System.Windows.Forms.RadioButton();
            this.rdoCaNgay = new System.Windows.Forms.RadioButton();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstKhachhang = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSoLuong);
            this.groupBox1.Controls.Add(this.btnThemmoi);
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTien);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboDoUong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGiaduthuyen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoNuaNgay);
            this.groupBox1.Controls.Add(this.rdoCaNgay);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(43, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin khách hàng đặt tour";
            // 
            // cboSoLuong
            // 
            this.cboSoLuong.FormattingEnabled = true;
            this.cboSoLuong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboSoLuong.Location = new System.Drawing.Point(149, 215);
            this.cboSoLuong.Name = "cboSoLuong";
            this.cboSoLuong.Size = new System.Drawing.Size(62, 21);
            this.cboSoLuong.TabIndex = 16;
            this.cboSoLuong.SelectedIndexChanged += new System.EventHandler(this.cboSoLuong_SelectedIndexChanged);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(177, 256);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 15;
            this.btnThemmoi.Text = "Thê&m mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            this.btnThemmoi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThemmoi_KeyDown);
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(46, 256);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(91, 23);
            this.btnThemDS.TabIndex = 14;
            this.btnThemDS.Text = "Thêm vào ds";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "$";
            // 
            // txtTien
            // 
            this.txtTien.Location = new System.Drawing.Point(247, 216);
            this.txtTien.Name = "txtTien";
            this.txtTien.ReadOnly = true;
            this.txtTien.Size = new System.Drawing.Size(89, 20);
            this.txtTien.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(157, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Số lượng";
            // 
            // cboDoUong
            // 
            this.cboDoUong.FormattingEnabled = true;
            this.cboDoUong.Items.AddRange(new object[] {
            "Coca cola",
            "Pepsi",
            "Seven up"});
            this.cboDoUong.Location = new System.Drawing.Point(22, 216);
            this.cboDoUong.Name = "cboDoUong";
            this.cboDoUong.Size = new System.Drawing.Size(101, 21);
            this.cboDoUong.TabIndex = 8;
            this.cboDoUong.SelectedIndexChanged += new System.EventHandler(this.cboDoUong_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chọn đồ uống";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "$";
            // 
            // txtGiaduthuyen
            // 
            this.txtGiaduthuyen.Location = new System.Drawing.Point(111, 132);
            this.txtGiaduthuyen.Name = "txtGiaduthuyen";
            this.txtGiaduthuyen.ReadOnly = true;
            this.txtGiaduthuyen.Size = new System.Drawing.Size(100, 20);
            this.txtGiaduthuyen.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá du thuyền";
            // 
            // rdoNuaNgay
            // 
            this.rdoNuaNgay.AutoSize = true;
            this.rdoNuaNgay.Location = new System.Drawing.Point(161, 83);
            this.rdoNuaNgay.Name = "rdoNuaNgay";
            this.rdoNuaNgay.Size = new System.Drawing.Size(71, 17);
            this.rdoNuaNgay.TabIndex = 3;
            this.rdoNuaNgay.TabStop = true;
            this.rdoNuaNgay.Text = "Nửa ngày";
            this.rdoNuaNgay.UseVisualStyleBackColor = true;
            this.rdoNuaNgay.CheckedChanged += new System.EventHandler(this.rdoNuaNgay_CheckedChanged);
            // 
            // rdoCaNgay
            // 
            this.rdoCaNgay.AutoSize = true;
            this.rdoCaNgay.Location = new System.Drawing.Point(26, 83);
            this.rdoCaNgay.Name = "rdoCaNgay";
            this.rdoCaNgay.Size = new System.Drawing.Size(64, 17);
            this.rdoCaNgay.TabIndex = 2;
            this.rdoCaNgay.TabStop = true;
            this.rdoCaNgay.Text = "Cả ngày";
            this.rdoCaNgay.UseVisualStyleBackColor = true;
            this.rdoCaNgay.CheckedChanged += new System.EventHandler(this.rdoCaNgay_CheckedChanged);
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(72, 42);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(148, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstKhachhang);
            this.groupBox2.Location = new System.Drawing.Point(420, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 301);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng đặt tour";
            // 
            // lstKhachhang
            // 
            this.lstKhachhang.FormattingEnabled = true;
            this.lstKhachhang.Location = new System.Drawing.Point(24, 51);
            this.lstKhachhang.Name = "lstKhachhang";
            this.lstKhachhang.Size = new System.Drawing.Size(298, 212);
            this.lstKhachhang.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(637, 402);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(73, 22);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "T&hoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThoat_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdoNuaNgay;
        private System.Windows.Forms.RadioButton rdoCaNgay;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemmoi;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDoUong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaduthuyen;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboSoLuong;
        private System.Windows.Forms.ListBox lstKhachhang;
    }
}

