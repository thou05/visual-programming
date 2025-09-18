using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong3_bai15_donghodemnguoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChay_Click(object sender, EventArgs e)
        {
            int m, s;
            if(txtMinute.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số phút");
                txtMinute.Focus();
                return;

            }
            if (txtSecond.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số giây");
                txtSecond.Focus(); 
                return;
            }
            //if (!int.TryParse(txtMinute.Text.Trim(), out m))
            //{
            //    MessageBox.Show("Phút phải là số nguyên!!");
            //    txtMinute.Focus(); return;
            //}
            //if (!int.TryParse(txtSecond.Text.Trim(), out s))
            //{
            //    MessageBox.Show("Giây phải là số nguyên!!");
            //    txtSecond.Focus(); return;
            //}

            tmrCountDown.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSecond_TextChanged(object sender, EventArgs e)
        {

        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            int m, s;
            m = int.Parse(txtMinute.Text);
            s = int.Parse(txtSecond.Text);
            if(s > 0 && s <= 59)
            {
                s -= 1;
            }
            else
            {
                if(m > 0 && s == 0)
                {
                    s = 59;
                    m -= 1;
                }
                if(m == 0 && s == 0)
                {
                    tmrCountDown.Stop();
                    MessageBox.Show("Hết giờ!!");
                }
               
            }
            txtMinute.Text = m.ToString();
            txtSecond.Text = s.ToString();
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            tmrCountDown.Stop();
            txtMinute.Text = "0";
            txtMinute.Focus();
            txtSecond.Text = "0";
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Có biết số là gì không???");
                e.Handled = true;
            }
        }

        private void btnTamDung_Click(object sender, EventArgs e)
        {
            tmrCountDown.Stop();
        }
    }
}
