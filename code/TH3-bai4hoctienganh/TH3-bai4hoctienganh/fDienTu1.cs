using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH3_bai4hoctienganh
{
    public partial class fDienTu1 : Form
    {
        private BaiTapDienTu bt;
       

        public fDienTu1(BaiTapDienTu baitap)
        {
            InitializeComponent();
            bt = baitap;
            txtDeBai.Text = bt.Debai;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void fDienTu1_Load(object sender, EventArgs e)
        {
            BaiTapDienTu br = new BaiTapDienTu();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
            int score = 0;
            List<TextBox> txtList = new List<TextBox> { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };

            for (int i = 0; i < txtList.Count; i++)
            {
                string userAns = txtList[i].Text.Trim().ToLower();
                string correctAns = bt.Dapantungcau[i].ToLower();

                if (userAns == correctAns)
                {
                    score++;
                    txtList[i].BackColor = Color.LightGreen; // đúng → xanh
                }
                else
                {
                    txtList[i].BackColor = Color.LightPink;  // sai → hồng
                }
            }

            MessageBox.Show("Bạn được " + score + "/10 điểm", "Kết quả");
        }

        private void btnDapAn_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt.Dapan;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtDeBai.Text = bt.Debai;
            List<TextBox> txtList = new List<TextBox> { txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10 };
            txtList.ForEach(txt => 
            {
                txt.Text = "";
                txt.BackColor = Color.White; 
            });
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDeBai_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
