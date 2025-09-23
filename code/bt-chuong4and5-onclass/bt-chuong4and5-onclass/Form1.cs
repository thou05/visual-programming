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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bt_chuong4and5_onclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Rich Text File (*.rtf)|*.rtf|Word Document|*.docx|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                rtbText.LoadFile(openFile.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Rich Text File (*.rtf)|*.rtf|Word Document|*.docx|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                rtbText.SaveFile(saveFile.FileName, RichTextBoxStreamType.RichText);
            }


        }

        private void btnFont_Click(object sender, EventArgs e)
        {

            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                rtbText.Font = fontDialog.Font;
                rtbText.ForeColor = fontDialog.Color;
            }
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            btnFont_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            btnClose_Click(sender, e);
        }

        private void mnuNew_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
            rtbText.Focus();
            rtbText.BackColor = Color.White;
            rtbText.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);

        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            btnSave_Click(sender, e);
        }

        private void mnuBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                rtbText.BackColor = colorDialog.Color;
            }
        }
    }
}
