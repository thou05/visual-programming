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

namespace Chuong6_banhangluuniem.HoaDon
{
    public partial class frmHoaDonBan : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        Classes.Function ft = new Classes.Function();
        public frmHoaDonBan()
        {
            InitializeComponent();
        }

        private void loadChiTietHoaDonTheoMa()
        {
            DataTable dt = dtBase.DocBang("SELECT c.MaHang, TenHang, DonGiaBan,  c.SoLuong, GiamGia, ThanhTien FROM tblChitietHDBan c JOIN tblHang h ON c.MaHang = h.MaHang where MaHD = '" + txtMaHoaDon.Text + "'"); ;
            dgvHang.DataSource = dt;
        }

        private void TinhTongTien()
        {
            double tongTien = 0;
            for(int i = 0; i < dgvHang.Rows.Count - 1; i++)
            {
                tongTien += Convert.ToDouble(dgvHang.Rows[i].Cells[5].Value);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //so dien thoai chi duoc nhap so nguyen
            //kiem tra neu nhan enter thi se tim khach hang theo sdt
            if(e.KeyChar == (char)Keys.Enter)
            {
                string sdt = txtDienThoai.Text.Trim();
                DataTable dtKH = dtBase.DocBang("select * from tblKhachHang where DienThoai = '" + sdt + "'");
                if(dtKH.Rows.Count > 0)
                {
                    cboMaHang.Text = dtKH.Rows[0]["MaKhach"].ToString();
                    txtTenKhachHang.Text = dtKH.Rows[0]["TenKhach"].ToString();
                    txtDiaChi.Text = dtKH.Rows[0]["DienThoai"].ToString();
                }
                else
                {
                    //them moi khach hang
                    if(MessageBox.Show("Khách hàng này chưa có trong danh sách, bạn có muốn thêm mới không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //ft.ThemMoiKhachHang(sdt);
                        ////load lai khach hang
                        //DataTable dtKH1 = dtBase.DocBang("select * from tblKhachHang where DienThoai = '" + sdt + "'");
                        //if (dtKH1.Rows.Count > 0)
                        //{
                        //    cboMaHang.Text = dtKH1.Rows[0]["MaKhach"].ToString();
                        //    txtTenKhachHang.Text = dtKH1.Rows[0]["TenKhach"].ToString();
                        //    txtDiaChi.Text = dtKH1.Rows[0]["DienThoai"].ToString();
                        //}
                        //dtKH1.Dispose();
                    }
                }
            }
        }

        private void cboMaHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHoaDon_Click(object sender, EventArgs e)
        {
            cboMaHoaDon.DataSource = null;
            ft.FillCombox(cboMaHoaDon, dtBase.DocBang("select MaHDBan from tblHDBan"), "MaHDBan", "MaHDBan");
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(cboMaHoaDon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã hóa đơn để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string maHD = cboMaHoaDon.Text.Trim();
            DataTable dtHD = dtBase.DocBang("select * from tblHDBan where MaHDBan = '" + cboMaHoaDon.Text + "'");
            if(dtHD.Rows.Count > 0)
            {
                txtMaHoaDon.Text = dtHD.Rows[0]["MaHDBan"].ToString();
                cboMaNhanVien.Text = dtHD.Rows[0]["MaNhanVien"].ToString();
                DataTable dtNV = dtBase.DocBang("select TenNhanVien from tblNhanVien where MaNhanVien = '" + cboMaNhanVien.Text + "'");
                if (dtNV.Rows.Count > 0)
                {
                    txtTenNhanVien.Text = dtNV.Rows[0]["TenNhanVien"].ToString();
                }
                cboMaKhachHang.Text = dtHD.Rows[0]["MaKhach"].ToString();

                DataTable dtKH = dtBase.DocBang("select TenKhach, DiaChi, DienThoai from tblKhach where MaKhach = '" + cboMaKhachHang.Text + "'");
                if (dtKH.Rows.Count > 0)
                {
                    txtTenKhachHang.Text = dtKH.Rows[0]["TenKhach"].ToString();
                    txtDiaChi.Text = dtKH.Rows[0]["DiaChi"].ToString();
                    txtDienThoai.Text = dtKH.Rows[0]["DienThoai"].ToString();
                }

                loadChiTietHoaDonTheoMa();




            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            //DataTable dtHD = dtBase.DocBang("SELECT c.MaHang, TenHang, DonGiaBan,  c.SoLuong, GiamGia, ThanhTien FROM tblChitietHDBan c JOIN tblHang h ON c.MaHang = h.MaHang where MaHD = '" + txtMaHoaDon + "'"); ;
            //dgvHang.DataSource = dtHD;

            //dgvHang.Columns[0].HeaderText = "Mã hàng";
            //dgvHang.Columns[1].HeaderText = "Tên hàng";
            //dgvHang.Columns[2].HeaderText = "Đơn giá bán";
            //dgvHang.Columns[3].HeaderText = "Số lượng";
            //dgvHang.Columns[4].HeaderText = "Giảm giá";
            //dgvHang.Columns[5].HeaderText = "Thành tiền";
            DataTable dtEmpty = new DataTable();
            dtEmpty.Columns.Add("MaHang");
            dtEmpty.Columns.Add("TenHang");
            dtEmpty.Columns.Add("DonGiaBan");
            dtEmpty.Columns.Add("SoLuong");
            dtEmpty.Columns.Add("GiamGia");
            dtEmpty.Columns.Add("ThanhTien");
            dgvHang.DataSource = dtEmpty;

            // Các phần setup cột như cũ
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Đơn giá bán";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Giảm giá";
            dgvHang.Columns[5].HeaderText = "Thành tiền";

            dgvHang.Columns[0].Width = 100;
            dgvHang.Columns[1].Width = 150;

            dgvHang.Columns[2].Width = 100;
            dgvHang.Columns[3].Width = 50;
            dgvHang.Columns[4].Width =50;
            dgvHang.Columns[5].Width = 100;

            btnLuu.Enabled = false;
            txtMaHoaDon.Enabled = false;
            txtTenNhanVien.Enabled = false;
            txtTenKhachHang.Enabled = false;
            txtDiaChi.Enabled = false;
            //txtDienThoai.Enabled = false;
            txtTenHang.Enabled = false;
            txtDonGia.Enabled = false;
            txtThanhTien.Enabled = false;
            txtTongTien.Enabled = false;

            ft.FillCombox(cboMaNhanVien, dtBase.DocBang("select MaNhanVien from tblNhanVien"), "MaNhanVien", "MaNhanVien");
           
            cboMaNhanVien.SelectedIndex = -1;

            ft.FillCombox(cboMaKhachHang, dtBase.DocBang("select MaKhach from tblKhach"), "MaKhach", "MaKhach");
            cboMaKhachHang.SelectedIndex = -1;

            ft.FillCombox(cboMaHang, dtBase.DocBang("select MaHang from tblHang"), "MaHang", "MaHang");
            cboMaHang.SelectedIndex = -1;

        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cboMaHang.Text = dgvHang.CurrentRow.Cells[0].Value.ToString();
            //txtTenHang.Text = dgvHang.CurrentRow.Cells[1].Value.ToString();
            //txtDonGia.Text = dgvHang.CurrentRow.Cells[2].Value.ToString();
            //txtSoLuong.Text = dgvHang.CurrentRow.Cells[3].Value.ToString();
            //txtGiamGia.Text = dgvHang.CurrentRow.Cells[4].Value.ToString();

            //double donGia = Convert.ToDouble(txtDonGia.Text);
            //double soLuong = Convert.ToDouble(txtSoLuong.Text);
            //double giamGia = string.IsNullOrEmpty(txtGiamGia.Text) ? 0 : Convert.ToDouble(txtGiamGia.Text);
            //double thanhTien = soLuong * donGia - (soLuong * donGia * giamGia / 100);
            //txtThanhTien.Text = thanhTien.ToString();

        }

        private void dgvHang_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (MessageBox.Show("Bạn có chắc muốn xóa mặt hàng này?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes) return;

            if (e.RowIndex >= 0)
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;

            txtMaHoaDon.Text = "";
            dtpNgayBan.Value = DateTime.Now;
            cboMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cboMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";

            cboMaHang.Text = "";
            txtTenHang.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            txtGiamGia.Text = "";
            txtThanhTien.Text = "";

            txtDienThoai.Enabled = true;

            string today = DateTime.Now.ToString("ddMMyyyy");
            DataTable dt = dtBase.DocBang("select MaHDBan from tblHDBan where MaHDBan like N'HDB_" + today + "% order by MaHDBan desc'");
            int nextNumber = 1;
            if(dt.Rows.Count > 0)
            {
                string lastCode = dt.Rows[0]["MaHDBan"].ToString();
                int lastNumber = int.Parse(lastCode.Substring(lastCode.Length - 3));
                nextNumber = lastNumber + 1;
            }
            string newCode = $"HDB_{today}{nextNumber.ToString("000")}";
            txtMaHoaDon.Text = newCode;


        }

        private void cboMaHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboMaHang.SelectedIndex == -1)
            {
                txtTenHang.Text = "";
                txtDonGia.Text = "";
            }
            string maHang = cboMaHang.Text.Trim();
            DataTable dtHang = dtBase.DocBang("select TenHang, DonGiaBan from tblHang where MaHang = '" + maHang + "'");
            if (dtHang.Rows.Count > 0)
            {
                txtTenHang.Text = dtHang.Rows[0]["TenHang"].ToString();
                txtDonGia.Text = dtHang.Rows[0]["DonGiaBan"].ToString();
            }
        }

        private void TinhThanhTien()
        {
            //double donGia = 0, soLuong = 0, giamGia = 0;
            //double.TryParse(txtDonGia.Text, out donGia);
            //double.TryParse(txtSoLuong.Text, out soLuong);
            //double.TryParse(txtGiamGia.Text, out giamGia);
            //double thanhTien = soLuong * donGia - (soLuong * donGia * giamGia / 100);
            //txtThanhTien.Text = thanhTien.ToString();
            try
            {
                double DonGia, GiamGia, SoLuong;
                if (txtGiamGia.Text == "")
                {
                    GiamGia = 0;
                }
                else
                {
                    GiamGia = Convert.ToDouble(txtGiamGia.Text);
                }

                if (txtSoLuong.Text == "")
                {
                    SoLuong = 0;
                }
                else
                {
                    SoLuong = Convert.ToDouble(txtSoLuong.Text);
                }

                DonGia = Convert.ToDouble(txtDonGia.Text);
                txtThanhTien.Text = (SoLuong * DonGia - SoLuong * DonGia * GiamGia / 100).ToString();
            }
            catch
            {

            }

        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)
        {
            TinhThanhTien();
        }

        private void txtMaHoaDon_TextChanged(object sender, EventArgs e)
        {
            if(txtMaHoaDon.Text != "")
            {
                loadChiTietHoaDonTheoMa();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //string sql = "insert into tblHDBan values ('" + txtMaHoaDon.Text + "', '" + dtpNgayBan.Value.ToString("yyyy-MM-dd") + "', N'" + cboMaNhanVien.Text + "', N'" + cboMaKhachHang.Text + "')";
            string sqlHD = "insert into tblHDBan values ('" + txtMaHoaDon.Text + "', '" + cboMaNhanVien + "', '" + dtpNgayBan.Value.ToString("yyyy-MM-dd") + "', '" + cboMaKhachHang.Text + "', '" + txtTongTien + "')";
            dtBase.CapNhatDuLieu(sqlHD);
            string sqlCTHD = "insert into tblChitietHDBan values ('" + txtMaHoaDon.Text + "', '" + cboMaHang.Text + "', '" + txtSoLuong.Text + "', '" + txtGiamGia.Text + "', '" + txtThanhTien.Text + "')";
            dtBase.CapNhatDuLieu(sqlCTHD);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            TinhTongTien();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                Excel.Application xlApp = new Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel không được cài đặt");
                    return;
                }
                Excel.Workbook wb = xlApp.Workbooks.Add();
                Excel.Worksheet ws = (Excel.Worksheet)wb.Worksheets[1];

                // Header
                ws.Range["A1"].Value = "HÓA ĐƠN BÁN";
                ws.Range["A2"].Value = "Mã HĐ: " + txtMaHoaDon.Text;
                ws.Range["A3"].Value = "Ngày: " + dtpNgayBan.Value.ToString("yyyy-MM-dd");
                ws.Range["A4"].Value = "NV: " + cboMaNhanVien.Text + " - " + txtTenNhanVien.Text;
                ws.Range["A5"].Value = "KH: " + cboMaKhachHang.Text + " - " + txtTenKhachHang.Text;

                // Columns
                ws.Range["A7"].Value = "Mã hàng";
                ws.Range["B7"].Value = "Tên hàng";
                ws.Range["C7"].Value = "Đơn giá";
                ws.Range["D7"].Value = "Số lượng";
                ws.Range["E7"].Value = "Giảm giá";
                ws.Range["F7"].Value = "Thành tiền";

                int rowStart = 8;
                foreach (DataGridViewRow row in dgvHang.Rows)
                {
                    if (row.IsNewRow) continue;
                    ws.Cells[rowStart, 1] = row.Cells["MaHang"].Value?.ToString();
                    ws.Cells[rowStart, 2] = row.Cells["TenHang"].Value?.ToString();
                    ws.Cells[rowStart, 3] = row.Cells["DonGiaBan"].Value?.ToString();
                    ws.Cells[rowStart, 4] = row.Cells["SoLuong"].Value?.ToString();
                    ws.Cells[rowStart, 5] = row.Cells["GiamGia"].Value?.ToString();
                    ws.Cells[rowStart, 6] = row.Cells["ThanhTien"].Value?.ToString();
                    rowStart++;
                }

                ws.Cells[rowStart + 1, 5] = "TỔNG:";
                ws.Cells[rowStart + 1, 6] = txtTongTien.Text;

                xlApp.Visible = true;
                wb.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi in Excel: " + ex.Message);
            }
        }
    }
}
