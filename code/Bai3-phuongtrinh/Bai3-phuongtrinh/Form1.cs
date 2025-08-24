using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3_phuongtrinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtA.Text) || string.IsNullOrEmpty(txtB.Text) || string.IsNullOrEmpty(txtC.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ các hệ số a, b, c!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double a, b, c;
            if (!double.TryParse(txtA.Text, out a))
            {
                MessageBox.Show("Nhập số cho a", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtA.Focus();
                return;
            }
            if (!double.TryParse(txtB.Text, out b))
            {
                MessageBox.Show("Nhập số cho b", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtB.Focus();
                return;
            }
            if (!double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Nhập số cho c", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtC.Focus();
                return;
            }
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        txtKQ.Text = "Phương trình có vô số nghiệm.";
                    }
                    else
                    {
                        txtKQ.Text = "Phương trình vô nghiệm.";
                    }
                }
                else
                {
                    double x = -c / b;
                    txtKQ.Text = "Phương trình có một nghiệm: x = " + x;
                }
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    txtKQ.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    txtKQ.Text = "Phương trình có nghiệm kép: x1 = x2 = " + x;
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    txtKQ.Text = "Phương trình có hai nghiệm phân biệt: x1 = " + x1 + ", x2 = " + x2;
                }
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            txtKQ.Text = "";
            txtA.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnGiaiPT_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.G)
            {
                btnGiaiPT.PerformClick();
            }
        }

        private void btnLamLai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.L)
            {
                btnLamLai.PerformClick();
            }
        }

        private void btnThoat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.T)
            {
                btnThoat.PerformClick();
            }
        }
    }
}
