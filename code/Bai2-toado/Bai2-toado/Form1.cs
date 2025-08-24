using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_toado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void TxtHeSoGoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            TxtHeSoGoc.Text = ((double.Parse(y2.Text) - double.Parse(y1.Text)) / (double.Parse(x2.Text) - double.Parse(x1.Text))).ToString();
            TxtKhoangCach.Text = Math.Sqrt(Math.Pow((double.Parse(x2.Text) - double.Parse(x1.Text)), 2) + Math.Pow((double.Parse(y2.Text) - double.Parse(y1.Text)), 2)).ToString();
        }
    }
}
