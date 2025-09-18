using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2_Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThoat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.H)
            {
                btnThoat.PerformClick();
            }
        }

        private void btnThemDS_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập điểm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            if(double.Parse(txtDiem.Text) < 0 || double.Parse(txtDiem.Text) > 10)
            {
                MessageBox.Show("Điểm phải từ 0 đến 10!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiem.Focus();
                return;
            }

            string monHoc = cboTenMon.SelectedItem.ToString();
            //foreach(var item in lstMonHoc.Items)
            //{
            //    if(item.ToString().StartsWith(monHoc + "-"))
            //    {
            //        MessageBox.Show("Môn học đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        return;
            //    }
            //}
            bool found = false;

            for(int i = 0; i < lstMonHoc.Items.Count; i++)
            {
                if(lstMonHoc.Items[i].ToString().StartsWith(monHoc + "-"))
                {
                    lstMonHoc.Items.RemoveAt(i);
                    lstMonHoc.Items.Add(monHoc + "-" + txtSoTin.Text + "-" + txtDiem.Text);
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                lstMonHoc.Items.Add(monHoc + "-" + txtSoTin.Text + "-" + txtDiem.Text);
            }

            

        }

        private void btnThemDS_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.D)
            {
                btnThemDS.PerformClick();
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(lstMonHoc.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int tongTin = 0;
            double tongDiem = 0;
            foreach(var item in lstMonHoc.Items)
            {
                string[] parts = item.ToString().Split('-');
                int soTin = int.Parse(parts[1]);
                double diem = double.Parse(parts[2]);
                tongTin += soTin;
                tongDiem += soTin * diem;
            }
            double dtb = tongDiem / tongTin;
            txtTongTin.Text = tongTin.ToString();
            txtTongDiem.Text = tongDiem.ToString();
            txtDiemTB.Text = dtb.ToString("0.0");
        }

        private void btnTinh_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cboTenMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboTenMon.SelectedItem.ToString())
            {
                case "Tin học đại cương":
                case "Triết học Mác – Lênin":
                    txtSoTin.Text = "2";
                    break;
                case "Giải tích F1":
                case "Tiếng Anh A0":
                case "Vật lý F1":
                    txtSoTin.Text = "3";
                    break;

            }
        }

        private void txtDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Có biết số là gì không???");
                e.Handled = true;
            }
        }
    }
}
