namespace TH2_Bai1
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
            this.btnThemDS = new System.Windows.Forms.Button();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.txtSoTin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTenMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTongTin = new System.Windows.Forms.TextBox();
            this.txtTongDiem = new System.Windows.Forms.TextBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemDS);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.txtSoTin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboTenMon);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(339, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // btnThemDS
            // 
            this.btnThemDS.Location = new System.Drawing.Point(73, 238);
            this.btnThemDS.Name = "btnThemDS";
            this.btnThemDS.Size = new System.Drawing.Size(164, 41);
            this.btnThemDS.TabIndex = 6;
            this.btnThemDS.Text = "Thêm vào &ds";
            this.btnThemDS.UseVisualStyleBackColor = true;
            this.btnThemDS.Click += new System.EventHandler(this.btnThemDS_Click);
            this.btnThemDS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnThemDS_KeyDown);
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(106, 154);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(79, 20);
            this.txtDiem.TabIndex = 5;
            this.txtDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiem_KeyPress);
            // 
            // txtSoTin
            // 
            this.txtSoTin.Location = new System.Drawing.Point(106, 115);
            this.txtSoTin.Name = "txtSoTin";
            this.txtSoTin.ReadOnly = true;
            this.txtSoTin.Size = new System.Drawing.Size(79, 20);
            this.txtSoTin.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Điểm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số tín chỉ";
            // 
            // cboTenMon
            // 
            this.cboTenMon.FormattingEnabled = true;
            this.cboTenMon.Items.AddRange(new object[] {
            "Tin học đại cương",
            "Giải tích F1",
            "Tiếng Anh A0",
            "Triết học Mác – Lênin",
            "Vật lý F1"});
            this.cboTenMon.Location = new System.Drawing.Point(27, 74);
            this.cboTenMon.Name = "cboTenMon";
            this.cboTenMon.Size = new System.Drawing.Size(255, 21);
            this.cboTenMon.TabIndex = 1;
            this.cboTenMon.SelectedIndexChanged += new System.EventHandler(this.cboTenMon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên môn học";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstMonHoc);
            this.groupBox2.Location = new System.Drawing.Point(415, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các môn học";
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.FormattingEnabled = true;
            this.lstMonHoc.Location = new System.Drawing.Point(25, 33);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.Size = new System.Drawing.Size(294, 121);
            this.lstMonHoc.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tổng số tín chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(611, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng số đếm";
            // 
            // txtTongTin
            // 
            this.txtTongTin.Location = new System.Drawing.Point(520, 236);
            this.txtTongTin.Name = "txtTongTin";
            this.txtTongTin.ReadOnly = true;
            this.txtTongTin.Size = new System.Drawing.Size(63, 20);
            this.txtTongTin.TabIndex = 4;
            // 
            // txtTongDiem
            // 
            this.txtTongDiem.Location = new System.Drawing.Point(702, 239);
            this.txtTongDiem.Name = "txtTongDiem";
            this.txtTongDiem.ReadOnly = true;
            this.txtTongDiem.Size = new System.Drawing.Size(63, 20);
            this.txtTongDiem.TabIndex = 5;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(520, 298);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.ReadOnly = true;
            this.txtDiemTB.Size = new System.Drawing.Size(77, 20);
            this.txtDiemTB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Điểm trung bình";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(442, 354);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 8;
            this.btnTinh.Text = "&Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            this.btnTinh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnTinh_KeyDown);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(629, 354);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
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
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDiemTB);
            this.Controls.Add(this.txtTongDiem);
            this.Controls.Add(this.txtTongTin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTenMon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThemDS;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.TextBox txtSoTin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMonHoc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTongTin;
        private System.Windows.Forms.TextBox txtTongDiem;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnThoat;
    }
}

