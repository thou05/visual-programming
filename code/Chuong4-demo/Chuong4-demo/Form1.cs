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

namespace Chuong4_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.AddExtension = true;
            //if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
            //    try
            //    {
            //        writer.Write(textBox1.Text);
            //        MessageBox.Show("Thành công");
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Thất bại!!");
            //    }
            //    writer.Close();
            //}
            SaveFileDialog dlgSave = new SaveFileDialog();

            dlgSave.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            dlgSave.InitialDirectory = @"D:\Document";
            dlgSave.FilterIndex = 2;
            dlgSave.Title = "Chọn File để lưu";
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                try
                {
                    writer.Write(textBox1.Text);
                    MessageBox.Show("Thành công");
                }
                catch
                {
                    MessageBox.Show("Lỗi ghi file!!");
                }
                writer.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã thoát");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.BackColor = colorDialog1.Color;
            }
            else
            {
                MessageBox.Show("You clicked Cancel", "Color Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            string rd = "";
            openFileDialog1.Title = "Chọn file: ";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                while(rd != null)
                {
                    rd = reader.ReadLine();
                    if(rd != null)
                    {
                        textBox1.Text += rd;
                    }
                }
                reader.Close();
            }
            else
            {
                MessageBox.Show("Bạn đã thoát");
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
            else
            {
                MessageBox.Show("You clicked Cancel", "Font Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
