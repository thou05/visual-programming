namespace bai11_danhsachmathang
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
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMatHang = new System.Windows.Forms.ListBox();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.rdoTinDung = new System.Windows.Forms.RadioButton();
            this.rdoSec = new System.Windows.Forms.RadioButton();
            this.rdoTienMat = new System.Windows.Forms.RadioButton();
            this.grpLienLac = new System.Windows.Forms.GroupBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkFax = new System.Windows.Forms.CheckBox();
            this.chkDienThoai = new System.Windows.Forms.CheckBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lstHangMua = new System.Windows.Forms.ListBox();
            this.grpThanhToan.SuspendLayout();
            this.grpLienLac.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Location = new System.Drawing.Point(29, 41);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(39, 13);
            this.lbl_hoten.TabIndex = 0;
            this.lbl_hoten.Text = "Họ tên";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(133, 20);
            this.txtName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Điện thoại";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(392, 36);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 20);
            this.txtPhone.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danh sách các mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hàng đã đặt mua";
            // 
            // lstMatHang
            // 
            this.lstMatHang.FormattingEnabled = true;
            this.lstMatHang.Items.AddRange(new object[] {
            "Kỹ thuật lập trình c#",
            "Tự học Visual C# trong 21 ngày",
            ".NET toàn tập - tập 1",
            ".NET toàn tập - tập 2",
            ".NET toàn tập - tập 3",
            ".NET toàn tập - tập 4",
            ".NET toàn tập - tập 5",
            ".NET toàn tập - tập 6",
            "Tin học căn bản SQL Server",
            "Cơ bản về XML",
            "Phân tích thiết kế hệ thống",
            "Sử dụng Dreamwever 8.0",
            "Đến với word 2003"});
            this.lstMatHang.Location = new System.Drawing.Point(42, 149);
            this.lstMatHang.Name = "lstMatHang";
            this.lstMatHang.Size = new System.Drawing.Size(200, 147);
            this.lstMatHang.TabIndex = 6;
            this.lstMatHang.SelectedIndexChanged += new System.EventHandler(this.lstMatHang_SelectedIndexChanged);
            this.lstMatHang.DoubleClick += new System.EventHandler(this.lstMatHang_DoubleClick);
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.rdoTinDung);
            this.grpThanhToan.Controls.Add(this.rdoSec);
            this.grpThanhToan.Controls.Add(this.rdoTienMat);
            this.grpThanhToan.Location = new System.Drawing.Point(52, 340);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(211, 100);
            this.grpThanhToan.TabIndex = 8;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Phương thức thanh toán";
            this.grpThanhToan.Enter += new System.EventHandler(this.grpThanhToan_Enter);
            // 
            // rdoTinDung
            // 
            this.rdoTinDung.AutoSize = true;
            this.rdoTinDung.Location = new System.Drawing.Point(23, 73);
            this.rdoTinDung.Name = "rdoTinDung";
            this.rdoTinDung.Size = new System.Drawing.Size(87, 17);
            this.rdoTinDung.TabIndex = 2;
            this.rdoTinDung.TabStop = true;
            this.rdoTinDung.Text = "Thẻ tín dụng";
            this.rdoTinDung.UseVisualStyleBackColor = true;
            // 
            // rdoSec
            // 
            this.rdoSec.AutoSize = true;
            this.rdoSec.Location = new System.Drawing.Point(23, 50);
            this.rdoSec.Name = "rdoSec";
            this.rdoSec.Size = new System.Drawing.Size(44, 17);
            this.rdoSec.TabIndex = 1;
            this.rdoSec.TabStop = true;
            this.rdoSec.Text = "Sec";
            this.rdoSec.UseVisualStyleBackColor = true;
            // 
            // rdoTienMat
            // 
            this.rdoTienMat.AutoSize = true;
            this.rdoTienMat.Location = new System.Drawing.Point(23, 27);
            this.rdoTienMat.Name = "rdoTienMat";
            this.rdoTienMat.Size = new System.Drawing.Size(66, 17);
            this.rdoTienMat.TabIndex = 0;
            this.rdoTienMat.TabStop = true;
            this.rdoTienMat.Text = "Tiền mặt";
            this.rdoTienMat.UseVisualStyleBackColor = true;
            // 
            // grpLienLac
            // 
            this.grpLienLac.Controls.Add(this.chkEmail);
            this.grpLienLac.Controls.Add(this.chkFax);
            this.grpLienLac.Controls.Add(this.chkDienThoai);
            this.grpLienLac.Location = new System.Drawing.Point(346, 343);
            this.grpLienLac.Name = "grpLienLac";
            this.grpLienLac.Size = new System.Drawing.Size(191, 96);
            this.grpLienLac.TabIndex = 9;
            this.grpLienLac.TabStop = false;
            this.grpLienLac.Text = "Hình thức liên lạc";
            // 
            // chkEmail
            // 
            this.chkEmail.AutoSize = true;
            this.chkEmail.Location = new System.Drawing.Point(28, 69);
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.Size = new System.Drawing.Size(51, 17);
            this.chkEmail.TabIndex = 2;
            this.chkEmail.Text = "Email";
            this.chkEmail.UseVisualStyleBackColor = true;
            // 
            // chkFax
            // 
            this.chkFax.AutoSize = true;
            this.chkFax.Location = new System.Drawing.Point(28, 46);
            this.chkFax.Name = "chkFax";
            this.chkFax.Size = new System.Drawing.Size(43, 17);
            this.chkFax.TabIndex = 1;
            this.chkFax.Text = "Fax";
            this.chkFax.UseVisualStyleBackColor = true;
            // 
            // chkDienThoai
            // 
            this.chkDienThoai.AutoSize = true;
            this.chkDienThoai.Location = new System.Drawing.Point(28, 23);
            this.chkDienThoai.Name = "chkDienThoai";
            this.chkDienThoai.Size = new System.Drawing.Size(74, 17);
            this.chkDienThoai.TabIndex = 0;
            this.chkDienThoai.Text = "Điện thoại";
            this.chkDienThoai.UseVisualStyleBackColor = true;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(187, 453);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 28);
            this.btnDongY.TabIndex = 10;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(319, 455);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(82, 25);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lstHangMua
            // 
            this.lstHangMua.FormattingEnabled = true;
            this.lstHangMua.Location = new System.Drawing.Point(319, 147);
            this.lstHangMua.Name = "lstHangMua";
            this.lstHangMua.Size = new System.Drawing.Size(204, 147);
            this.lstHangMua.TabIndex = 12;
            this.lstHangMua.SelectedIndexChanged += new System.EventHandler(this.lstHangMua_SelectedIndexChanged);
            this.lstHangMua.DoubleClick += new System.EventHandler(this.lstHangMua_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.lstHangMua);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.grpLienLac);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.lstMatHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl_hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.grpLienLac.ResumeLayout(false);
            this.grpLienLac.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMatHang;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.RadioButton rdoTinDung;
        private System.Windows.Forms.RadioButton rdoSec;
        private System.Windows.Forms.RadioButton rdoTienMat;
        private System.Windows.Forms.GroupBox grpLienLac;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkFax;
        private System.Windows.Forms.CheckBox chkDienThoai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ListBox lstHangMua;
    }
}

