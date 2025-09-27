namespace TH3_Bai3nghenhac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboODia = new System.Windows.Forms.ComboBox();
            this.cboThuMuc = new System.Windows.Forms.ComboBox();
            this.lstTapTin = new System.Windows.Forms.ListBox();
            this.rtbLoiBaiHat = new System.Windows.Forms.RichTextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ổ đĩa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thư mục";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tập tin";
            // 
            // cboODia
            // 
            this.cboODia.FormattingEnabled = true;
            this.cboODia.Location = new System.Drawing.Point(107, 27);
            this.cboODia.Name = "cboODia";
            this.cboODia.Size = new System.Drawing.Size(121, 21);
            this.cboODia.TabIndex = 3;
            this.cboODia.SelectedIndexChanged += new System.EventHandler(this.cboODia_SelectedIndexChanged);
            // 
            // cboThuMuc
            // 
            this.cboThuMuc.FormattingEnabled = true;
            this.cboThuMuc.Location = new System.Drawing.Point(107, 69);
            this.cboThuMuc.Name = "cboThuMuc";
            this.cboThuMuc.Size = new System.Drawing.Size(121, 21);
            this.cboThuMuc.TabIndex = 4;
            this.cboThuMuc.SelectedIndexChanged += new System.EventHandler(this.cboThuMuc_SelectedIndexChanged);
            // 
            // lstTapTin
            // 
            this.lstTapTin.FormattingEnabled = true;
            this.lstTapTin.Location = new System.Drawing.Point(34, 142);
            this.lstTapTin.Name = "lstTapTin";
            this.lstTapTin.Size = new System.Drawing.Size(205, 147);
            this.lstTapTin.TabIndex = 5;
            this.lstTapTin.SelectedIndexChanged += new System.EventHandler(this.lstTapTin_SelectedIndexChanged);
            // 
            // rtbLoiBaiHat
            // 
            this.rtbLoiBaiHat.Location = new System.Drawing.Point(328, 27);
            this.rtbLoiBaiHat.Name = "rtbLoiBaiHat";
            this.rtbLoiBaiHat.Size = new System.Drawing.Size(314, 428);
            this.rtbLoiBaiHat.TabIndex = 6;
            this.rtbLoiBaiHat.Text = "";
            this.rtbLoiBaiHat.TextChanged += new System.EventHandler(this.rtbLoiBaiHat_TextChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(37, 314);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(264, 170);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.rtbLoiBaiHat);
            this.Controls.Add(this.lstTapTin);
            this.Controls.Add(this.cboThuMuc);
            this.Controls.Add(this.cboODia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboODia;
        private System.Windows.Forms.ComboBox cboThuMuc;
        private System.Windows.Forms.ListBox lstTapTin;
        private System.Windows.Forms.RichTextBox rtbLoiBaiHat;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

