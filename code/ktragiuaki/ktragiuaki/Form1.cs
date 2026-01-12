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

namespace ktragiuaki
{
    public partial class Form1 : Form
    {
        Classes.DataProcesser dtBase = new Classes.DataProcesser();
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSoTin_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTin.Text.Length > 2)
            {
                MessageBox.Show("Không được quá 2 số");
                txtSoTin.Text = "";
                txtSoTin.Focus();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim();
            DataTable dt = dtBase.DocBang("select * from tblMonHoc where MaMon = '" + txtMaMon.Text + "'");
            if (dt.Rows.Count > 0)
            {
                txtMaMon.Text = dt.Rows[0]["MaMon"].ToString();
                txtTenMon.Text = dt.Rows[1]["TenMon"].ToString();
                txtSoTin.Text = dt.Rows[2]["SoTin"].ToString();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = dtBase.DocBang("select * from tblMonHoc");
            dgvMon.DataSource = dt;

            dgvMon.Columns[0].HeaderText = "Mã môn";
            dgvMon.Columns[1].HeaderText = "Tên môn";
            dgvMon.Columns[2].HeaderText = "Số tín chỉ";
            dgvMon.Columns[0].Width = 100;
            dgvMon.Columns[1].Width = 150;
            dgvMon.Columns[2].Width = 100;
            dgvMon.BackgroundColor = Color.LightBlue;
            dt.Dispose();
        }

        private void txtMaMon_Enter(object sender, EventArgs e)
        {
            txtMaMon.BackColor = Color.Yellow;
        }

        private void txtMaMon_Leave(object sender, EventArgs e)
        {
            txtMaMon.BackColor = Color.White;
        }

        private void txtTenMon_Enter(object sender, EventArgs e)
        {
            txtTenMon.BackColor = Color.Yellow;
        }

        private void txtTenMon_Leave(object sender, EventArgs e)
        {
            txtTenMon.BackColor= Color.White;
        }

        private void txtSoTin_Enter(object sender, EventArgs e)
        {
            txtSoTin.BackColor = Color.Yellow; 
        }

        private void txtSoTin_Leave(object sender, EventArgs e)
        {
            txtSoTin.BackColor= Color.White;
        }

        private void txtTenMon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoTin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && !char.IsControl(e.KeyChar)){
                MessageBox.Show("Phải nhập số!!");
                e.Handled = true;
            }
                   
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvMon.Rows.Count < 0) {
                MessageBox.Show("Không có thông tin môn học nào");
                return;
            }
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1];  
        
            tenTruong.Range["B2"].Font.Size = 25;
            tenTruong.Range["B2"].Font.Name = "Times New Roman";
            tenTruong.Range["B2"].Value = "DANH SÁCH MÔN HỌC";

            tenTruong.Range["A4:C4"].Font.Size = 13;
            tenTruong.Range["A4:C4"].Font.Name = "Times New Roman";
            tenTruong.Range["A4:C4"].Font.Color = Color.Black;
            tenTruong.Range["A4:C4"].Font.Bold = true;
            tenTruong.Range["A4"].Value = "Mã môn";
            tenTruong.Range["B4"].Value = "Tên môn";
            tenTruong.Range["C4"].Value = "Số tín chỉ";
            

            int hang = 5;
            for (int i = 0; i < dgvMon.Rows.Count - 1; i++)
            {
                tenTruong.Range["A" + hang.ToString()].Value = dgvMon.Rows[i].Cells[0].Value.ToString();
                tenTruong.Range["B" + hang.ToString()].Value = dgvMon.Rows[i].Cells[1].Value.ToString();
                tenTruong.Range["C" + hang.ToString()].Value = dgvMon.Rows[i].Cells[2].Value.ToString();
               
                hang++;
            }

            exSheet.Name = "DSMON";

            exBook.Activate();

            SaveFileDialog dlgLuu = new SaveFileDialog();
            if (dlgLuu.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(dlgLuu.FileName.ToString());
            }
            exApp.Quit();
        }
    }
}
