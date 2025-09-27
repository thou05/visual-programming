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
    public partial class fMenu : Form
    {
        public fMenu()
        {
            InitializeComponent();
        }

        private void mnuDienTu1_Click(object sender, EventArgs e)
        {
            BaiTapDienTu bt = new BaiTapDienTu();
          
            bt.Debai = "My grandfather was born in China. He came from a very poor family and was (1) _____ of seven children. His parents lived (2) _____ a small farm. He didn’t have a very good education. " +
                "At the age of 17 he (3) _____ home. First he went to Shanghai and (4) _____ he went to Hong Kong. He worked (5) _____ a waiter and then as a cook. When he was 21, he (6) _____ my grandmother and had four children. " +
                "My mother was (7) _____ oldest. My grandmother died recently, and my grandfather lives alone now. He is almost 80, (8) _____ he is still very active and interested in everything (9) _____ is going on. " +
                "He reads the papers and (10) _____ television even though his eyesight is fairly poor.";
           
            bt.Dapan = "My grandfather was born in China. He came from a very poor family and was (1) one of seven children. " +
                "His parents lived (2) on a small farm. He didn’t have a very good education. At the age of 17 he (3) left home. First he went to Shanghai and (4) then he went to Hong Kong. " +
                "He worked (5) as a waiter and then as a cook. When he was 21, he (6) married my grandmother and had four children. My mother was (7) the oldest. My grandmother died recently, and my grandfather lives alone now. " +
                "He is almost 80, (8) but he is still very active and interested in everything (9) that is going on. " +
                "He reads the papers and (10) watches television even though his eyesight is fairly poor.";


            List<string> lists = new List<string>
                {
                    "one","on","left","then","as","married","the","but","that","watches"
                };
            bt.Dapantungcau = lists;

            fDienTu1 f1 = new fDienTu1(bt);
            f1.ShowDialog();
        }

        private void fMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
