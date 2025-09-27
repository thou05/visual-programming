namespace TH3_bai4hoctienganh
{
    partial class fMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dienTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bienDoiCauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tracNghiemGioiTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datCauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDienTu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.baiDienTu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baiDienTu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dienTuToolStripMenuItem,
            this.bienDoiCauToolStripMenuItem,
            this.tracNghiemGioiTuToolStripMenuItem,
            this.datCauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dienTuToolStripMenuItem
            // 
            this.dienTuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDienTu1,
            this.baiDienTu2ToolStripMenuItem,
            this.baiDienTu3ToolStripMenuItem});
            this.dienTuToolStripMenuItem.Name = "dienTuToolStripMenuItem";
            this.dienTuToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.dienTuToolStripMenuItem.Text = "Dien tu";
            // 
            // bienDoiCauToolStripMenuItem
            // 
            this.bienDoiCauToolStripMenuItem.Name = "bienDoiCauToolStripMenuItem";
            this.bienDoiCauToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bienDoiCauToolStripMenuItem.Text = "Bien doi cau";
            // 
            // tracNghiemGioiTuToolStripMenuItem
            // 
            this.tracNghiemGioiTuToolStripMenuItem.Name = "tracNghiemGioiTuToolStripMenuItem";
            this.tracNghiemGioiTuToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.tracNghiemGioiTuToolStripMenuItem.Text = "Trac nghiem gioi tu";
            // 
            // datCauToolStripMenuItem
            // 
            this.datCauToolStripMenuItem.Name = "datCauToolStripMenuItem";
            this.datCauToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.datCauToolStripMenuItem.Text = "Dat cau";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.thoatToolStripMenuItem.Text = "Thoat";
            // 
            // mnuDienTu1
            // 
            this.mnuDienTu1.Name = "mnuDienTu1";
            this.mnuDienTu1.Size = new System.Drawing.Size(180, 22);
            this.mnuDienTu1.Text = "Bai dien tu 1";
            this.mnuDienTu1.Click += new System.EventHandler(this.mnuDienTu1_Click);
            // 
            // baiDienTu2ToolStripMenuItem
            // 
            this.baiDienTu2ToolStripMenuItem.Name = "baiDienTu2ToolStripMenuItem";
            this.baiDienTu2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baiDienTu2ToolStripMenuItem.Text = "Bai dien tu 2";
            // 
            // baiDienTu3ToolStripMenuItem
            // 
            this.baiDienTu3ToolStripMenuItem.Name = "baiDienTu3ToolStripMenuItem";
            this.baiDienTu3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.baiDienTu3ToolStripMenuItem.Text = "Bai dien tu 3";
            // 
            // fMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMenu";
            this.Text = "Bai Tap Tieng Anh";
            this.Load += new System.EventHandler(this.fMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dienTuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bienDoiCauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tracNghiemGioiTuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datCauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDienTu1;
        private System.Windows.Forms.ToolStripMenuItem baiDienTu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baiDienTu3ToolStripMenuItem;
    }
}

