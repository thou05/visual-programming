using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl
{
    public partial class Form1 : Form
    {
        int n;
        int[] a;
        int count;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = null;
            this.Icon = new Icon(Application.StartupPath.ToString() + "\\Icon\\icon1.ico");
            count = 0;
            
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 3 == 1)
                this.BackColor = Color.Green;
            if (count % 3 == 2)
                this.BackColor = Color.Pink;
            if (count % 3 == 0)
                this.BackColor = Color.Yellow;
        }

        

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            if(txtN.Text.Trim()=="")
            {
                MessageBox.Show("Bạn phải nhập n là số phần tử của dãy");
                txtN.Focus(); //Đặt con trỏ vào ô nhập N
                return;
            }
            n = int.Parse(txtN.Text);
            //Cấp phát bộ nhớ cho dãy
            a = new int[n];
            //Sinh n số nguyên ngẫu nhiên từ 1 đến 100
            lblDaySo.Text = "Dãy số: ";
            Random rd = new Random();
            for(int i=0;i<n;i++)
            {
                a[i] = rd.Next(1, 100);
                lblDaySo.Text = lblDaySo.Text + "  " + a[i];
            }    
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Sum = 0;
            for (int i = 0; i < n; i++)
                Sum = Sum + a[i];
            lblTong.Text ="Tổng dãy: "+  Sum.ToString();
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            lblSapXep.Text = "Dãy tăng dần:";
            for(int i=0;i<n;i++)
            {
                lblSapXep.Text = lblSapXep.Text + "   " + a[i];
            }    

        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            lblDaySo.Text = "";
            lblTong.Text = "";
            lblSapXep.Text = "";
            txtN.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không", "Lựa chọn",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                this.Close();
        }
    }
}
