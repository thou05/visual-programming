using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong3_bai2_dayso
{
    public partial class Form1 : Form
    {
        int n;
        int[] arr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //phai nhap so nguyen
        private void txtNhapN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            //cach 1
            //if (string.IsNullOrEmpty(txtNhapN.Text))
            //{
            //    MessageBox.Show("Vui long nhap so phan tu");
            //    return;
            //}

            //if (!int.TryParse(txtNhapN.Text, out int value))
            //{
            //    MessageBox.Show("Vui long nhap so nguyen");
            //    return;
            //}

            //cach2
            if(txtNhapN.Text.Trim() == "")
            {
                MessageBox.Show("Vui long nhap so phan tu");
                txtNhapN.Focus();
                return;
            }

            lblDaySo.Text = "Dãy số: ";

            n = int.Parse(txtNhapN.Text);
            arr = new int[n];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(1, 100);
                //lblDaySo.Text += arr[i].ToString() + "  ";
                lblDaySo.Text += "  " + arr[i];
            }
            
            //lblDaySo.Text = string.Join("  ", arr);

        }

        private void lblTong_Click(object sender, EventArgs e)
        {

        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            lblTong.Text = "Tổng: " + sum.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            Array.Sort(arr);
            lblSapXep.Text = "Dãy tăng dần: ";
            for(int i = 0; i < n; i++)
            {
                lblSapXep.Text += "  " + arr[i];
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtNhapN.Text="";
            lblDaySo.Text = "";
            lblTong.Text = "";
            lblSapXep.Text = "";
            txtNhapN.Focus();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Lựa chọn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void lsFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lsFont.SelectedItem == null) return;
                
                this.Font = new Font(lsFont.SelectedItem.ToString(), this.Font.Size);

            } catch { 
            }
        }

        private void lsFont_DoubleClick(object sender, EventArgs e)
        {
            int index = lsFont.SelectedIndex;
            if(index == -1)
            {
                MessageBox.Show("Ban chua chon phan tu nao");
                return;
            }
            if (MessageBox.Show("Ban co muon xoa font " + lsFont.Text, "chon", 
                MessageBoxButtons))
        }

        private void cboFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Font = new Font(this.Font.Name, int.Parse(cboFontSize.Text));
        }
    }
}
