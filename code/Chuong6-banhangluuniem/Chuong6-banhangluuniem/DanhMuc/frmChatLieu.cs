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
    public partial class frmChatLieu : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.Function ft = new Classes.Function();
        public frmChatLieu()
        {
            InitializeComponent();
        }

        private void frmChatLieu_Load(object sender, EventArgs e)
        {
            DataTable dtChatLieu = dtBase.DocBang("select * from tblChatLieu");
            dgvChatLieu.DataSource = dtChatLieu;

            dgvChatLieu.Columns[0].HeaderText = "Mã chất liệu";
            dgvChatLieu.Columns[1].HeaderText = "Tên chất liệu";
            dgvChatLieu.Columns[0].Width = 100;
            dgvChatLieu.Columns[1].Width = 150;
            dgvChatLieu.BackgroundColor = Color.LightBlue;
            dtChatLieu.Dispose();

            //khi load chi click dc them thoat
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void ResetValue()
        {
            txtMaChatLieu.Text = "";
            txtTenChatLieu.Text = "";
            txtMaChatLieu.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaChatLieu.Focus();
                return;
            }

            if (txtTenChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenChatLieu.Focus();
                return;
            }

            //them moi va cap nhat
            if (btnThem.Enabled)
            {
                //ktra trung ma
                DataTable dtCL = dtBase.DocBang("select MaChatLieu from tblChatLieu where MaChatLieu = '" + txtMaChatLieu.Text + "'");
                if(dtCL.Rows.Count > 0)
                {
                    MessageBox.Show("Mã chất liệu này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaChatLieu.Focus();
                    return;
                }
                string strInsert = "insert into tblChatLieu values('" + txtMaChatLieu.Text + "',N'" + txtTenChatLieu.Text + "')";
                dtBase.CapNhatDuLieu(strInsert);
            }

            if (btnSua.Enabled)
            {
                string sqlUpdate = "update tblChatLieu set TenChatLieu = N'" + txtTenChatLieu.Text + "' where MaChatLieu = '" + txtMaChatLieu.Text + "'";

                dtBase.CapNhatDuLieu(sqlUpdate);
            }

            //load du lieu len dgv
            DataTable dt = dtBase.DocBang("select * from tblChatLieu");
            dgvChatLieu.DataSource = dt;

            //dua form ve trang thai ban dau
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled=false;
            btnXoa.Enabled=false;
            btnLuu.Enabled=true;
            btnBoQua.Enabled=true;
        }

        private void dgvChatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled=true;
            btnBoQua.Enabled = true;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;

            txtMaChatLieu.Text = dgvChatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenChatLieu.Text = dgvChatLieu.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa chất liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete tblChatLieu where MaChatLieu = '" + txtMaChatLieu.Text + "'");
                dgvChatLieu.DataSource = dtBase.DocBang("select * from tblChatLieu");
            }

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            ResetValue();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled=false;
            btnBoQua.Enabled=false;
            ResetValue() ;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled=true;
            btnLuu.Enabled=true;
            btnBoQua.Enabled=true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            ResetValue();
        }
    }
}
