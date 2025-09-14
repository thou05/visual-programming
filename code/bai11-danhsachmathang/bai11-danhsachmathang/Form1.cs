using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai11_danhsachmathang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lstMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatHang.SelectedItem != null)
            {
                string matHang = lstMatHang.SelectedItem.ToString();
                if (lstHangMua.Items.Contains(matHang))
                {
                    MessageBox.Show("Bạn đã chọn mua cuốn " + matHang + "rồi!!", "Thông báo");
                }
                else
                {
                    lstHangMua.Items.Add(matHang);
                }
            }
        }

        private void lstMatHang_DoubleClick(object sender, EventArgs e)
        {

            
            
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        string thongbao = "";
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text)) {
                MessageBox.Show("Vui lòng nhập tên!!");
                return;
            }
            if (string.IsNullOrEmpty(txtPhone.Text)){
                MessageBox.Show("Vui lòng nhập số điện thoại!!");
                return;
            }

            string ptThanhToan = "";
            if (rdoTienMat.Checked) ptThanhToan = rdoTienMat.Text;
            else if (rdoSec.Checked) ptThanhToan = rdoSec.Text;
            else if (rdoTinDung.Checked) ptThanhToan = rdoTinDung.Text;

            if(ptThanhToan == "")
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!!");
                return;
            }

            string lienLac = "";

            if (!chkDienThoai.Checked && !chkFax.Checked && !chkEmail.Checked)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một hình thức liên lạc!");
                return;
            }
            if (chkDienThoai.Checked) lienLac += chkDienThoai.Text + " ";
            if (chkFax.Checked) lienLac += chkFax.Text + " ";
            if (chkEmail.Checked) lienLac += chkEmail.Text + " ";


            thongbao = "Họ tên khách: " + txtName.Text + "\n" + "Điện thoại" + txtPhone.Text + "\n";
            thongbao = thongbao + "Danh sách đặt hàng đã mua:\n";
            foreach (string item in lstMatHang.SelectedItems)
            {
                thongbao = thongbao + item + "\n";
            }

            thongbao += "Phương thức thanh toán: " + ptThanhToan + "\n";
            thongbao += "Hình thức liên lạc: " + lienLac;
            //Xóa dấu phẩy và dấu cách thừa ở cuối chuỗi 
            thongbao = thongbao.Remove(thongbao.Length - 2, 2);

            MessageBox.Show(thongbao,
            "Thông báo", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void grpThanhToan_Enter(object sender, EventArgs e)
        {

        }

        private void lstHangMua_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstHangMua_DoubleClick(object sender, EventArgs e)
        {
            if (lstHangMua.SelectedItem != null)
            {
                string mua = lstHangMua.SelectedItem.ToString();
                DialogResult result = MessageBox.Show("Bạn có muốn xóa " + mua + "không??",
                                                        "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    lstHangMua.Items.Remove(lstHangMua.SelectedItem);
                }
            }
        }
    }
}
