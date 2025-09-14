using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong3_bai13_doimaunen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void lblRed_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_Scroll(object sender, ScrollEventArgs e)
        {
            int red = hsbRed.Value;
            int green = hsbGreen.Value;
            int blue = hsbBlue.Value;

            textBox1.BackColor = Color.FromArgb(red, green, blue);

            lblRed.Text = red.ToString();
            lblGreen.Text = green.ToString();
            lblBlue.Text = blue.ToString();
        }
    }
}
