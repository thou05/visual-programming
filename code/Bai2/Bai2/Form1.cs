using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBanKinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtChuVi_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDienTich_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            TxtChuVi.Text = (2 * 3.14 * double.Parse(TxtBanKinh.Text)).ToString();
            TxtDienTich.Text = (3.14 * double.Parse(TxtBanKinh.Text) * double.Parse(TxtBanKinh.Text)).ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            TxtChuVi.Text = "";
            TxtDienTich.Text = "";
            TxtBanKinh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
