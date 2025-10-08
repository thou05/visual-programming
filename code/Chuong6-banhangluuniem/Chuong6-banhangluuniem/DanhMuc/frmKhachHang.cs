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
    public partial class frmKhachHang : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.Function ft = new Classes.Function();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            DataTable dtKH = dtBase.DocBang("select * from tblKhach");
            dgvKH.DataSource = dtKH;

            dgvKH.Columns[0].HeaderText = "Mã khách";
            dgvKH.Columns[1].HeaderText = "Tên khách";
            dgvKH.Columns[2].HeaderText = "Địa chỉ";
            dgvKH.Columns[3].HeaderText = "Điện thoại";
            dgvKH.Columns[0].Width = 100;
            dgvKH.Columns[1].Width = 150;
            dgvKH.Columns[2].Width = 200;
            dgvKH.Columns[3].Width = 100;
            dgvKH.BackgroundColor = Color.LightBlue;
            dtKH.Dispose();

            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void ResetValue()
        {
            txtMaKhach.Text = "";
            txtTenKhach.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            txtMaKhach.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            
            ResetValue();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhach.Focus();
                return;
            }
            if (txtTenKhach.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên khách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenKhach.Focus();
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

            if(btnThem.Enabled)
            {
                DataTable dtKH = dtBase.DocBang("select MaKhach from tblKhach where MaKhach = N'" + txtMaKhach.Text + "'");
                if(dtKH.Rows.Count > 0)
                {
                    MessageBox.Show("Mã khách này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaKhach.Focus();
                    return;
                }
                string strInsert = "insert into tblKhach(MaKhach, TenKhach, DiaChi, DienThoai) values (N'" + txtMaKhach.Text + "', N'" + txtTenKhach.Text + "', N'" + txtDiaChi.Text + "', N'" + txtDienThoai.Text + "')";
                dtBase.CapNhatDuLieu(strInsert);
                
            }
            if (btnSua.Enabled)
            {
                string strUpdate = "update tblKhach set TenKhach = N'" + txtTenKhach.Text + "', DiaChi = N'" + txtDiaChi.Text + "', DienThoai = N'" + txtDienThoai.Text + "' where MaKhach = N'" + txtMaKhach.Text + "'";
                dtBase.CapNhatDuLieu(strUpdate);
                
            }

            DataTable dt = dtBase.DocBang("select * from tblKhach");
            dgvKH.DataSource = dt;
            
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            ResetValue();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "delete tblKhach where MaKhach = N'" + txtMaKhach.Text + "'";
                dgvKH.DataSource = dtBase.DocBang("select * from tblKhach");
            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            ResetValue();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = false;

            txtMaKhach.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txtTenKhach.Text = dgvKH.CurrentRow.Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKH.CurrentRow.Cells[2].Value.ToString();
            txtDienThoai.Text = dgvKH.CurrentRow.Cells[3].Value.ToString();

        }
    }

}
