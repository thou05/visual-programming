using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Buoi3_eventcontrol
{
    public partial class Form1 : Form
    {
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            if (btnTrangThai.Text.Trim() == "Hide")
            {
                textBox1.Visible = false;
                btnTrangThai.Text = "Show";
            }
            else if (btnTrangThai.Text.Trim() == "Show")
            {
                textBox1.Show();
                btnTrangThai.Text = "Hide";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.Icon = null;
            //this.Icon = Icon.
            //this.Icon = new Icon(Application.StartupPath + "\\Icon\\icon1.ico");
            count = 0;
            btnTrangThai.Enabled = false;
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 3 == 1) this.BackColor = Color.Green;
            else if(count % 3 == 2) this.BackColor = Color.Yellow;
            else if (count % 3 == 0) this.BackColor = Color.Red;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() =="")
            {
                btnTrangThai.Enabled = false;
            }
            else
            {
                btnTrangThai.Enabled = true;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Aqua;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) == false && !char.IsControl(e.KeyChar) && e.KeyChar!='/')
            {
                MessageBox.Show("Có biết số là gì không???");
                e.Handled = true;
            }
                
        }
    }
}
