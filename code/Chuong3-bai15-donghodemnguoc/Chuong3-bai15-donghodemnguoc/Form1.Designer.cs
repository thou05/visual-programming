namespace Chuong3_bai15_donghodemnguoc
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
            this.components = new System.ComponentModel.Container();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnChay = new System.Windows.Forms.Button();
            this.btnTamDung = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtMinute
            // 
            this.txtMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinute.Location = new System.Drawing.Point(91, 103);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(81, 35);
            this.txtMinute.TabIndex = 0;
            this.txtMinute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtSecond
            // 
            this.txtSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecond.Location = new System.Drawing.Point(206, 103);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(85, 35);
            this.txtSecond.TabIndex = 1;
            this.txtSecond.TextChanged += new System.EventHandler(this.txtSecond_TextChanged);
            this.txtSecond.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "(phút)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(219, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "(giây)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = ":";
            // 
            // btnChay
            // 
            this.btnChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnChay.Location = new System.Drawing.Point(55, 173);
            this.btnChay.Name = "btnChay";
            this.btnChay.Size = new System.Drawing.Size(82, 29);
            this.btnChay.TabIndex = 5;
            this.btnChay.Text = "Chạy";
            this.btnChay.UseVisualStyleBackColor = true;
            this.btnChay.Click += new System.EventHandler(this.btnChay_Click);
            // 
            // btnTamDung
            // 
            this.btnTamDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTamDung.Location = new System.Drawing.Point(161, 173);
            this.btnTamDung.Name = "btnTamDung";
            this.btnTamDung.Size = new System.Drawing.Size(82, 29);
            this.btnTamDung.TabIndex = 6;
            this.btnTamDung.Text = "Tạm dừng";
            this.btnTamDung.UseVisualStyleBackColor = true;
            this.btnTamDung.Click += new System.EventHandler(this.btnTamDung_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnKetThuc.Location = new System.Drawing.Point(272, 173);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(82, 29);
            this.btnKetThuc.TabIndex = 7;
            this.btnKetThuc.Text = "Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = true;
            this.btnKetThuc.Click += new System.EventHandler(this.btnKetThuc_Click);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(465, 306);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnTamDung);
            this.Controls.Add(this.btnChay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtMinute);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnChay;
        private System.Windows.Forms.Button btnTamDung;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Timer tmrCountDown;
    }
}

