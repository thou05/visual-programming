namespace Bai2
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
            this.TxtBanKinh = new System.Windows.Forms.TextBox();
            this.TxtChuVi = new System.Windows.Forms.TextBox();
            this.TxtDienTich = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtBanKinh
            // 
            this.TxtBanKinh.Location = new System.Drawing.Point(208, 104);
            this.TxtBanKinh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtBanKinh.Name = "TxtBanKinh";
            this.TxtBanKinh.Size = new System.Drawing.Size(380, 29);
            this.TxtBanKinh.TabIndex = 0;
            this.TxtBanKinh.TextChanged += new System.EventHandler(this.TxtBanKinh_TextChanged);
            // 
            // TxtChuVi
            // 
            this.TxtChuVi.BackColor = System.Drawing.SystemColors.Info;
            this.TxtChuVi.Enabled = false;
            this.TxtChuVi.Location = new System.Drawing.Point(208, 173);
            this.TxtChuVi.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtChuVi.Name = "TxtChuVi";
            this.TxtChuVi.Size = new System.Drawing.Size(365, 29);
            this.TxtChuVi.TabIndex = 1;
            this.TxtChuVi.TextChanged += new System.EventHandler(this.TxtChuVi_TextChanged);
            // 
            // TxtDienTich
            // 
            this.TxtDienTich.BackColor = System.Drawing.SystemColors.Info;
            this.TxtDienTich.Enabled = false;
            this.TxtDienTich.Location = new System.Drawing.Point(208, 244);
            this.TxtDienTich.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TxtDienTich.Name = "TxtDienTich";
            this.TxtDienTich.Size = new System.Drawing.Size(393, 29);
            this.TxtDienTich.TabIndex = 2;
            this.TxtDienTich.TextChanged += new System.EventHandler(this.TxtDienTich_TextChanged);
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(19, 333);
            this.btnTinh.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(143, 37);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(226, 333);
            this.btnLamLai.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(158, 37);
            this.btnLamLai.TabIndex = 4;
            this.btnLamLai.Text = "Làm lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(433, 333);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(189, 37);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "THẢO LÊ XINH GÁI VÔ CÙNG\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhập bán kính (r):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 176);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Chu vi:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Diện tích:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 465);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.TxtDienTich);
            this.Controls.Add(this.TxtChuVi);
            this.Controls.Add(this.TxtBanKinh);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Bài tập về hình trònn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBanKinh;
        private System.Windows.Forms.TextBox TxtChuVi;
        private System.Windows.Forms.TextBox TxtDienTich;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

