using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thao le xinh dep");
        }


        private void button3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = " ";
            txtDisplay.BackColor = Color.White;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clickOnDisplay(object sender, EventArgs e)
        {
            txtDisplay.Text = "sophia here";
            txtDisplay.BackColor = Color.Thistle;
        }
    }
}
