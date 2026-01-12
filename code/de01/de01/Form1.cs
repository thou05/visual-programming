using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de01
{
    public partial class Form1 : Form
    {

        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        string fileAnh = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            DataTable dt = dtBase.DocBang("select * from VatLieu");
            dgvVatLieu.DataSource = dt;

            dgvVatLieu.Columns[0].HeaderText = "Mã Vật Liệu";
            dgvVatLieu.Columns[1].HeaderText = "Tên Vật Liệu";
            dgvVatLieu.Columns[2].HeaderText = "Đơn Vị Tính";
            dgvVatLieu.Columns[3].HeaderText = "Giá nhập";
            dgvVatLieu.Columns[4].HeaderText = "Giá bán";
            dgvVatLieu.Columns[5].HeaderText = "Số Lượng";
            dgvVatLieu.Columns[6].HeaderText = "File ảnh";
            dgvVatLieu.Columns[7].HeaderText = "Ghi Chú";

            dgvVatLieu.Columns[0].Width = 100;
            dgvVatLieu.Columns[1].Width = 100;
            dgvVatLieu.Columns[2].Width = 100;
            dgvVatLieu.Columns[3].Width = 70;
            dgvVatLieu.Columns[4].Width = 70;
            dgvVatLieu.Columns[5].Width = 50;
            dgvVatLieu.Columns[6].Width = 100;
            dgvVatLieu.Columns[7].Width = 150;

            dgvVatLieu.BackgroundColor = Color.LightBlue;
            //dgvVatLieu.Dispose();

            //cam click cac nut sua, xoa, luu, bo qua
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;

            ResetValue();
        }

        private void ResetValue()
        {
            txtMaVL.Text = "";
            txtTenVL.Text = "";
            txtDonViTinh.Text = "";
            txtSoLuong.Text = "";
            txtGiaNhap.Text = "";
            txtGiaBan.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtMaVL.Focus();
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

                // Lấy tên file ảnh
                string[] str = dlgAnh.FileName.Split('\\');
                fileAnh = str[str.Length - 1].ToString();

                // Tạo đường dẫn đích
                string imagesPath = Application.StartupPath + "\\Images\\";
                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                string destFile = Path.Combine(imagesPath, fileAnh);

                // Nếu ảnh chưa tồn tại thì copy vào thư mục Images
                if (!File.Exists(destFile))
                {
                    File.Copy(dlgAnh.FileName, destFile, true);
                }
            }
        }

        private void OnlyNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaVL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập mã vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVL.Focus();
                return;
            }
            if (txtTenVL.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập tên vật liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenVL.Focus();
                return;
            }

            if (txtDonViTinh.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đơn vị tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDonViTinh.Focus();
                return;
            }

            if (txtGiaNhap.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaNhap.Focus();
                return;
            }

            if (txtGiaBan.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập giá bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaBan.Focus();
                return;
            }

            if (txtSoLuong.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSoLuong.Focus();
                return;
            }

            //ktra trung ma
            DataTable dtVL = dtBase.DocBang("select MaVL from VatLieu where MaVL ='" + txtMaVL.Text + "'");
            if (dtVL.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaVL.Focus();
                return;
            }
            string sqlInsert = "INSERT INTO VatLieu (MaVL, TenVatLieu, DonViTinh, GiaNhap, GiaBan, SoLuong, Anh, GhiChu) " +
                                "VALUES (N'" + txtMaVL.Text + "', N'" + txtTenVL.Text + "', N'" + txtDonViTinh.Text + "', " +
                                float.Parse(txtGiaNhap.Text) + ", " + float.Parse(txtGiaBan.Text) + ", " +
                                int.Parse(txtSoLuong.Text) + ", N'" + fileAnh + "', N'" + txtGhiChu.Text + "')";
            dtBase.CapNhatDuLieu(sqlInsert);


            //load du lieu len dgvHang
            DataTable dt = dtBase.DocBang("select * from VatLieu");
            dgvVatLieu.DataSource = dt;

            //dua form ve trang thai ban dau
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValue();


        }

        private void dgvVatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            
            txtMaVL.Text = dgvVatLieu.CurrentRow.Cells[0].Value.ToString();
            txtTenVL.Text = dgvVatLieu.CurrentRow.Cells[1].Value.ToString();
            txtDonViTinh.Text = dgvVatLieu.CurrentRow.Cells[2].Value.ToString();
            txtGiaNhap.Text = dgvVatLieu.CurrentRow.Cells[3].Value.ToString();
            txtGiaBan.Text = dgvVatLieu.CurrentRow.Cells[4].Value.ToString();
            txtSoLuong.Text = dgvVatLieu.CurrentRow.Cells[5].Value.ToString();

            try
            {
                picAnh.Image = Image.FromFile("Images\\" + dgvVatLieu.CurrentRow.Cells[6].Value.ToString());
            }
            catch
            {
                picAnh.Image = null;
            }
            txtGhiChu.Text = dgvVatLieu.CurrentRow.Cells[7].Value.ToString();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataTable dtVL = dtBase.DocBang("select MaVL from VatLieu where MaVL ='" + txtMaVL.Text + "'");
            //thuc hien sua du lieu
            if (btnSua.Enabled == true)
            {
                string sqlUpdate = "UPDATE VatLieu SET " +
                   "TenVatLieu = N'" + txtTenVL.Text + "', " +
                   "DonViTinh = N'" + txtDonViTinh.Text + "', " +
                   "GiaNhap = N'" + txtGiaNhap.Text + "', " +
                   "GiaBan = N'" + txtGiaBan.Text + "', " +
                   "SoLuong = " + txtSoLuong.Text + ", " +
                   "Anh = N'" + fileAnh + "', " +
                   "GhiChu = N'" + txtGhiChu.Text + "' " +
                   "WHERE MaVL = N'" + txtMaVL.Text + "'";
                dtBase.CapNhatDuLieu(sqlUpdate);
            }

            //load du lieu len dgvHang
            DataTable dt = dtBase.DocBang("select * from VatLieu");
            dgvVatLieu.DataSource = dt;

            //dua form ve trang thai ban dau
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValue();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa vật liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtBase.CapNhatDuLieu("delete VatLieu where MaVL = '" + txtMaVL.Text + "'");
                dgvVatLieu.DataSource = dtBase.DocBang("select * from VatLieu");
            }

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnBoQua.Enabled = true;
            ResetValue();
        }
    }
}
