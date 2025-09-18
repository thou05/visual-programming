using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2_Bai2_Dattour
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThoat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.H)
            {
                btnThoat.PerformClick();
            }
        }

        private void btnThemmoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.M)
            {
                btnThemmoi.PerformClick();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = string.Empty;
            txtGiaduthuyen.Text = string.Empty;
            txtTien.Text = string.Empty;
            rdoCaNgay.Checked = false;
            rdoNuaNgay.Checked = false;
            cboDoUong.SelectedIndex = -1;
            cboSoLuong.SelectedIndex = -1;

            txtHoTen.Focus();
        }

        private void rdoCaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCaNgay.Checked) 
            {
                txtGiaduthuyen.Text = "200";
            }
        }

        private void rdoNuaNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNuaNgay.Checked)
            {
                txtGiaduthuyen.Text = "100";
            }
        }

        private void cboDoUong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTienDoUong();
        }

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            tinhTienDoUong();
        }
        
        private void tinhTienDoUong()
        {
            if (cboDoUong.SelectedIndex == -1 || cboSoLuong.SelectedIndex == -1) return;
            double gia = 0;
            switch (cboDoUong.SelectedItem.ToString())
            {
                case "Coca cola": gia = 0.5; break;
                case "Pepsi": gia = 0.8; break;
                case "Seven up": gia = 1.0; break;
            }

            int soluong = int.Parse(cboSoLuong.SelectedItem.ToString());
            double tien = gia * soluong;
            txtTien.Text = tien.ToString();
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;

            }

            if (!rdoCaNgay.Checked && !rdoNuaNgay.Checked)
            {
                MessageBox.Show("Vui lòng chọn thời gian thuê!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboDoUong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn đồ uống!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboSoLuong.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn số lượng đồ uống!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string item = txtHoTen.Text + " | ";

            if (rdoCaNgay.Checked) item += "Cả ngày | ";
            else if (rdoNuaNgay.Checked) item += "Nủa ngày | ";

            item += txtGiaduthuyen.Text + "$ | ";
            

            item += "Đồ uống " + txtTien.Text + "$ |";

            double tong = double.Parse(txtGiaduthuyen.Text) + double.Parse(txtTien.Text);
            item += "Tông " + tong.ToString();


            lstKhachhang.Items.Add(item);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.H)
            {
                btnThoat.PerformClick();
            }
            else if (e.Alt && e.KeyCode == Keys.M)
            {
                btnThemmoi.PerformClick();
            }
        }
    }
}
