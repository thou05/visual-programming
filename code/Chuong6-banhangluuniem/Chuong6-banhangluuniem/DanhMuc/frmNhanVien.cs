using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong6_banhangluuniem.DanhMuc
{
    public partial class frmNhanVien : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.Function ft = new Classes.Function();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dtNV = dtBase.DocBang("select * from tblNhanvien");
            dgvNV.DataSource = dtNV;

            dgvNV.Columns[0].HeaderText = "Mã NV";
            dgvNV.Columns[1].HeaderText = "Tên NV";
            dgvNV.Columns[2].HeaderText = "Giới tính";
            dgvNV.Columns[3].HeaderText = "Địa chỉ";
            dgvNV.Columns[4].HeaderText = "Điện thoại";
            dgvNV.Columns[5].HeaderText = "Ngày sinh";

            dgvNV.Columns[0].Width = 70;
            dgvNV.Columns[1].Width = 150;
            dgvNV.Columns[2].Width = 70;
            dgvNV.Columns[3].Width = 150;
            dgvNV.Columns[4].Width = 100;
            dgvNV.Columns[5].Width = 80;
            dgvNV.BackgroundColor = Color.LightBlue;
            dtNV.Dispose();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ResetValue()
        {
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            mtbNgaySinh.Text = "";
            rdoNam.Checked = false;
            rdoNu.Checked = false;
            txtMaNV.Focus();
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoQua.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;


            txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvNV.CurrentRow.Cells[1].Value.ToString();

            if (dgvNV.CurrentRow.Cells[2].Value.ToString() == "Nam")
                rdoNam.Checked = true;
            else
                rdoNu.Checked = true;

            txtDiaChi.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
            txtDienThoai.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();

            if (DateTime.TryParse(dgvNV.CurrentRow.Cells[5].Value.ToString(), out DateTime ngaySinh))
                mtbNgaySinh.Text = ngaySinh.ToString("MM/dd/yyyy");
            else
                mtbNgaySinh.Text = "";


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
        }

        

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNV.Focus();
                return;
            }
            if (txtTenNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenNV.Focus();
                return;
            }
            if (rdoNam.Checked == false && rdoNu.Checked == false)
            {
                MessageBox.Show("Bạn phải chọn giới tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiaChi.Focus();
                return;
            }
            if (txtDienThoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienThoai.Focus();
                return;
            }
            if (mtbNgaySinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mtbNgaySinh.Focus();
                return;
            }

            if (btnThem.Enabled)
            {
                DataTable dtNV = dtBase.DocBang("select MaNhanVien from tblNhanvien where MaNhanVien = N'" + txtMaNV.Text + "'");
                if (dtNV.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return;
                }
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                string strInsert = "insert into tblNhanvien values (N'" + txtMaNV.Text + "', N'" + txtTenNV.Text + "', N'" + gioiTinh + "', N'" + txtDiaChi.Text + "', N'" + txtDienThoai.Text + "', '" + mtbNgaySinh.Text + "')";
                dtBase.CapNhatDuLieu(strInsert);

            }

            if (btnSua.Enabled)
            {
                string gioiTinh = rdoNam.Checked ? "Nam" : "Nữ";
                string strUpdate = "update tblNhanvien set TenNhanVien = N'" + txtTenNV.Text + "', GioiTinh = N'" + gioiTinh + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = N'" + txtDienThoai.Text + "', NgaySinh = '" + mtbNgaySinh.Text + "' where MaNhanVien = N'" + txtMaNV.Text + "'";
                dtBase.CapNhatDuLieu(strUpdate);
            }
            
            DataTable dt = dtBase.DocBang("select * from tblNhanVien");
            dgvNV.DataSource = dt;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            ResetValue();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete from tblNhanVien where MaNV = N'" + txtMaNV.Text + "'");
                dgvNV.DataSource = dtBase.DocBang("select * from tblNhanvien");
            }

            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            ResetValue();

        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            ResetValue();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
