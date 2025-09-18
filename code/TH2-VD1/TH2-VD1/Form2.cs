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
    public partial class Form2 : Form
    {
        List<NguoiGui> listNguoiGuis = new List<NguoiGui>();
        public Form2()
        {
            InitializeComponent();
            listNguoiGuis = StaticData._NguoiGui;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int timthay = 0;
            foreach (NguoiGui i in listNguoiGuis)
            {
                if (i.MaKH1 == Convert.ToInt32(txtTimMa.Text))
                {
                    timthay = 1;
                    lblKetQua.Text += "Khách hàng " + i.TenKH1 + "phải trả"
                    + i.Tien1 + " nghìn đồng";
                }
            }
            if (timthay == 0)
            {
                lblKetQua.Text += "Khách hàng " + txtTimMa.Text + " không có trong danh sách"; 
            }
        }
    }
}
