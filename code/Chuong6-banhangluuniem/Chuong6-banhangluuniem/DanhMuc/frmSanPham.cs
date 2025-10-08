using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Chuong6_banhangluuniem.DanhMuc
{
    public partial class frmSanPham : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.Function ft = new Classes.Function();
        string fileAnh = "";
        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            //lay du lieu bang chat lieu vao cboChatLieu
            DataTable dtChatLieu = dtBase.DocBang("select * from tblChatLieu");
            ft.FillCombox(cboChatLieu, dtChatLieu, "TenChatLieu", "MaChatLieu");
            cboChatLieu.SelectedIndex = -1;

            //load du lieu
            DataTable dtHang = dtBase.DocBang("select * from tblHang");
            dgvHang.DataSource = dtHang;

            //dinh dang datagrid 
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Mã CL";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Giá nhập";
            dgvHang.Columns[5].HeaderText = "Giá bán";
            dgvHang.Columns[6].HeaderText = "File ảnh";

            dgvHang.Columns[0].Width = 150;
            dgvHang.Columns[1].Width = 250;
            dgvHang.Columns[2].Width = 150;
            dgvHang.Columns[3].Width = 150;
            dgvHang.Columns[4].Width = 150;
            dgvHang.Columns[5].Width = 150;
            dgvHang.Columns[6].Width = 150;

            dgvHang.BackgroundColor = Color.LightBlue;
            dtHang.Dispose(); 

            //cam click cac nut sua, xoa, luu, bo qua
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;

            ResetValue();
        }

        private void btnAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgAnh = new OpenFileDialog();
            dlgAnh.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            //dlgAnh.InitialDirectory = "D:\\";
            dlgAnh.InitialDirectory = Application.StartupPath;
            dlgAnh.FilterIndex = 4;
            dlgAnh.Title = "Chọn ảnh để hiển thị";
            if (dlgAnh.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgAnh.FileName);
                string[] str = dlgAnh.FileName.Split('\\');
                fileAnh = str[str.Length - 1].ToString();
            }
        }
        private void ResetValue()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboChatLieu.SelectedIndex = -1;
            txtSoLuong.Text = "";
            txtDonGiaBan.Text = "";
            txtDonGiaNhap.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtMaHang.Focus();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            //cam click nut sua, xoa
            //click duoc them moi, luu, bo qua
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThemMoi.Enabled = true;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValue();
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            //cam click sua, xoa, luu, bo qua
            //click duoc them moi
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;
            ResetValue();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(txtMaHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboChatLieu.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải chọn chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboChatLieu.Focus();
                return;
            }
            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }
            if (txtDonGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaNhap.Focus();
                return;
            }
            if (txtDonGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonGiaBan.Focus();
                return;
            }

            //thuc hien them moi va cap nhat datagridview
            if (btnThemMoi.Enabled == true)
            {
                //ktra trung ma
                DataTable dtSP = dtBase.DocBang("select MaHang from tblHang where MaHang ='" + txtMaHang.Text+ "'");
                if(dtSP.Rows.Count > 0)
                {
                    MessageBox.Show("Mã hàng này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHang.Focus();
                    return;
                }
                string strInsert = "insert into tblHang(MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) values('" 
                    + txtMaHang.Text + "',N'" + txtTenHang.Text + "','" + cboChatLieu.SelectedValue + "'," + int.Parse(txtSoLuong.Text) + "," 
                    + float.Parse(txtDonGiaNhap.Text) + "," + float.Parse(txtDonGiaBan.Text) + ",'" + fileAnh + "',N'" + txtGhiChu.Text + "')";
                dtBase.CapNhatDuLieu(strInsert);
            }

            //thuc hien sua du lieu
            if(btnSua.Enabled == true)
            {
                string sqlUpdate = "update tblHang set TenHang = N'" + txtTenHang.Text + "', MaChatLieu = '" + cboChatLieu.SelectedValue 
                    + "', SoLuong = " + Convert.ToInt16(txtSoLuong.Text) + ", DonGiaNhap = " + float.Parse(txtDonGiaNhap.Text) 
                    + ", DonGiaBan = " + float.Parse(txtDonGiaBan.Text)  + ", Anh = '" + fileAnh + "', GhiChu = N'" + txtGhiChu.Text 
                    + "' where MaHang = '" + txtMaHang.Text + "'";
                dtBase.CapNhatDuLieu(sqlUpdate);
            }

            //load du lieu len dgvHang
            DataTable dtHang = dtBase.DocBang("select * from tblHang");
            dgvHang.DataSource = dtHang;

            //dua form ve trang thai ban dau
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            btnThemMoi.Enabled = true;
            ResetValue();


        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = true;
            btnThemMoi.Enabled = false;
            btnLuu.Enabled = false;

            //hien thi du lieu chi tiet
            txtMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
            cboChatLieu.SelectedValue = dgvHang.CurrentRow.Cells[2].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells[4].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells[5].Value.ToString();
            try
            {
                picAnh.Image = Image.FromFile("Images\\Hang\\" + dgvHang.CurrentRow.Cells[6].Value.ToString());
            }
            catch
            {
                picAnh.Image = null;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThemMoi.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa mặt hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete tblHang where MaHang = '" + txtMaHang.Text + "'");
                dgvHang.DataSource = dtBase.DocBang("select * from tblHang");
            }

            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            btnThemMoi.Enabled = true;
            ResetValue();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //b3: khai bao va khoi tao cac thanh phan cua doi tuong excel
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1,1];   //dua con tro vao o a1
            //b4: dinh dang file excel
            tenTruong.Range["B2"].Font.Size = 25;
            tenTruong.Range["B2"].Font.Name = "Times New Roman";
            tenTruong.Range["B2"].Font.Color = Color.Red;
            tenTruong.Range["B2"].Value = "DANH SÁCH SẢN PHẨM";

            tenTruong.Range["A4:F4"].Font.Size = 13;
            tenTruong.Range["A4:F4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:F4"].Font.Color = Color.Black;
            tenTruong.Range["A4:F4"].Font.Bold = true;
            tenTruong.Range["A4"].Value = "Mã hàng";
            tenTruong.Range["B4"].Value = "Tên hàng";
            tenTruong.Range["C4"].Value = "Chất liệu";
            tenTruong.Range["D4"].Value = "Số lượng";
            tenTruong.Range["E4"].Value = "Đơn giá nhập";
            tenTruong.Range["F4"].Value = "Đơn giá bán";

            int hang = 5;
            for(int i = 0; i < dgvHang.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + hang.ToString()].Value = dgvHang.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + hang.ToString()].Value = dgvHang.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + hang.ToString()].Value = dgvHang.Rows[i].Cells[2].Value.ToString();
                tenTruong.Range["D" + hang.ToString()].Value = dgvHang.Rows[i].Cells[3].Value.ToString();
                tenTruong.Range["E" + hang.ToString()].Value = dgvHang.Rows[i].Cells[4].Value.ToString();
                tenTruong.Range["F" + hang.ToString()].Value = dgvHang.Rows[i].Cells[5].Value.ToString();
                hang++;
            }

            exSheet.Name = "DSSanPham";

            //b5: kich hoat file excel
            exBook.Activate();  

            //b6: luu file
            SaveFileDialog dlgLuu = new SaveFileDialog();
            if(dlgLuu.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlgLuu.FileName.ToString());
            }

            //b7: thoat khoi ung dung
            exApp.Quit();
        }
    }
}
