using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH2_VD1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSoTienGui_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = "";
            txtHoTenKH.Text = "";
            txtDiaChi.Text = "";
            txtSoTienGui.Text = "";
            txtNgayGui.Text = "";
            cboThoiGianGui.Text = "";
            cboThoiGianGui.SelectedIndex = -1;
            rdoThuong.Checked = false;
            rdoPhatLoc.Checked = false;
            txtMaKH.Focus();
        }

        private void btnThemMoi_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.Alt && e.KeyCode == Keys.M)
            //{
            //    btnThemMoi.PerformClick();
            //}
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThoat_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Alt && e.KeyCode == Keys.H)
            {
                btnThoat.PerformClick();
            }
        }

        private void btnThemVao_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (txtMaKH.TextLength != 6)
            {
                MessageBox.Show("Mã khách hàng phải có đúng 6 chữ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTenKH.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Họ tên và địa chỉ không được để trống!");
                check = false;
            }

            if(!DateTime.TryParse(txtNgayGui.Text, out DateTime ngaygui))
            {
                MessageBox.Show("Ngày gửi không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                check = false;
            }

            double sotiengui = double.Parse(txtSoTienGui.Text);
            int thoigian = int.Parse(cboThoiGianGui.SelectedItem.ToString());
            double laisuat = 0;

            if (check)
            {
                switch (thoigian)
                {
                    case 1: laisuat = 0.06; break;
                    case 3: laisuat = 0.07; break;
                    case 6: laisuat = 0.08; break;
                    case 12: laisuat = 0.09; break;
                }
                if(rdoPhatLoc.Checked) laisuat += 0.01;

                double tienlai = sotiengui * laisuat * thoigian / 12;
                string thongTin = txtMaKH.Text + " | " + txtHoTenKH.Text + " | " + txtDiaChi.Text + " | " +
                                txtNgayGui.Text + " | " + txtSoTienGui.Text + " | "
                                + cboThoiGianGui.Text + " tháng | " + laisuat;


                lstKhachHang.Items.Add(thongTin);

                List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
                listNguoiGuis.Add(new NguoiGui(Convert.ToInt32(txtMaKH.Text), txtHoTenKH.Text,
                txtDiaChi.Text, Convert.ToInt32(txtSoTienGui.Text),
                txtNgayGui.Text, cboThoiGianGui.Text, tienlai
                ));
                StaticData._NguoiGui = listNguoiGuis;

            }
            

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //CACH 1
            //string maKH = "";
            //using (Form inputForm = new Form())
            //{
            //    inputForm.Width = 350;
            //    inputForm.Height = 150;
            //    inputForm.Text = "Tìm kiếm";
            //    Label lblPrompt = new Label() { Left = 10, Top = 20, Text = "Nhập mã khách hàng cần tìm:", AutoSize = true };
            //    TextBox txtInput = new TextBox() { Left = 10, Top = 50, Width = 300 };
            //    Button btnOk = new Button() { Text = "OK", Left = 220, Width = 90, Top = 80, DialogResult = DialogResult.OK };
            //    inputForm.Controls.Add(lblPrompt);
            //    inputForm.Controls.Add(txtInput);
            //    inputForm.Controls.Add(btnOk);
            //    inputForm.AcceptButton = btnOk;

            //    if (inputForm.ShowDialog() == DialogResult.OK)
            //    {
            //        maKH = txtInput.Text;
            //    }
            //}

            //bool timThay = false;
            //foreach (var item in lstKhachHang.Items)
            //{
            //    if (item.ToString().Contains(maKH))
            //    {
            //        MessageBox.Show("Tìm thấy: " + item.ToString());
            //        timThay = true;
            //        break;
            //    }
            //}
            //if (!timThay)
            //{
            //    MessageBox.Show($"Khách hàng có mã {maKH} hiện chưa có trong danh sách.");
            //}

            //CACH 2
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
