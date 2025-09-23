using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong5_onclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void cmnuCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContext.SelectedText);
        }

        private void cmnuCut_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContext.SelectedText);
            txtContext.SelectedText = "";
        }

        private void cmnuPaste_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtContext.SelectedText);

        }
    }
}
