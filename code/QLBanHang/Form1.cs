using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        Classes.ConnectDataBase dtBases = new Classes.ConnectDataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtKH = dtBases.ReadData("Select * from tblKhachHang");
            dgvKhachHang.DataSource = dtKH;
            dgvKhachHang.Columns[0].HeaderText = "Mã khách";
            dgvKhachHang.Columns[1].HeaderText = "Tên khách";
            dgvKhachHang.Columns[2].HeaderText = "Số ĐT";
            dgvKhachHang.Columns[3].HeaderText = "Địa chỉ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Kiểm tra nhập đủ dữ liệu
            if(txtMaKhach.Text=="")
            {
                MessageBox.Show("Bạn phải nhập mã khách");
                txtMaKhach.Focus();
                return;
            }
            //.....
            //Kiểm tra trùng khóa chính
            DataTable dtKH = dtBases.ReadData("Select * from tblKhachHang where MaKhach='" + txtMaKhach.Text + "'");
            if (dtKH.Rows.Count > 0)
            {
                MessageBox.Show("Mã khách này đã có. Mời bạn nhập mã khác");
                txtMaKhach.Focus();
                return;
            }
            //Thêm vào CSDL
            dtBases.UpdateData("insert into tblKhachHang values('"+
                txtMaKhach.Text+"',N'"+txtTenKhach.Text+
                "','"+txtSoDT.Text+"',N'"+txtDiaChi.Text+"')");
            //Load lại dữ liệu
            Form1_Load(sender,e);
            ResetValue();
        }
        void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtMaKhach.Focus();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaKhach.Text = dgvKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKhach.Text= dgvKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSoDT.Text= dgvKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text= dgvKhachHang.CurrentRow.Cells[3].Value.ToString();
        }

        private void txtMaKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
