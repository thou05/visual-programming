using Chuong6_banhangluuniem.DanhMuc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong6_banhangluuniem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSanPham frmSanPham = new frmSanPham();
            //frmSanPham.MdiParent = this;
            frmSanPham.ShowDialog();
            this.Show();

        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChatLieu frmChatLieu = new frmChatLieu();
            frmChatLieu.ShowDialog();
            this.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frmNhanVien = new frmNhanVien();
            frmNhanVien.ShowDialog();
            this.Show();

        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKhachHang frmKhachHang = new frmKhachHang();
            frmKhachHang.ShowDialog();
            this.Show();
        }
    }
}
