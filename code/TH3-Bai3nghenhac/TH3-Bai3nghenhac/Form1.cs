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

namespace TH3_Bai3nghenhac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboODia_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DriveInfo[] drives = DriveInfo.GetDrives();
            //foreach (DriveInfo drive in drives)
            //{
            //    cboODia.Items.Add(drive.Name);
            //}
            cboThuMuc.Items.Clear();
            try
            {
                string[] dirs = Directory.GetDirectories(cboODia.Text);
                foreach (var d in dirs)
                {
                    cboThuMuc.Items.Add(d);
                }
            }
            catch { }
        }

        private void cboThuMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //DirectoryInfo dir = new DirectoryInfo(cboThuMuc.Text);
            //DirectoryInfo[] dirs = dir.GetDirectories("*.*");
            //FileInfo[] files = dir.GetFiles("*.mp3");
            //foreach (DirectoryInfo d in dirs)
            //{
            //    cboThuMuc.Items.Add(d.Name);
            //}

            lstTapTin.Items.Clear();
            try
            {
                string[] files = Directory.GetFiles(cboThuMuc.Text, "*.mp3");
                foreach (var f in files)
                {
                    lstTapTin.Items.Add(f);
                }
            }
            catch { }
        }

        private void lstTapTin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lstTapTin.Items.Clear();
            //rtbLoiBaiHat.Text = "";
            //string[] files = Directory.GetFiles(cboODia.Text + cboThuMuc.Text);
            //foreach (var d in files)
            //{
            //    lstTapTin.Items.Add(d);
            //}
            if (lstTapTin.SelectedItem == null) return;

            string filePath = lstTapTin.SelectedItem.ToString();
            axWindowsMediaPlayer1.URL = filePath;

            // Tìm file lời
            string lyricTxt = Path.ChangeExtension(filePath, ".txt");
            string lyricRtf = Path.ChangeExtension(filePath, ".rtf");

            if (File.Exists(lyricTxt))
            {
                rtbLoiBaiHat.Text = File.ReadAllText(lyricTxt, Encoding.UTF8);
            }
            else if (File.Exists(lyricRtf))
            {
                rtbLoiBaiHat.LoadFile(lyricRtf, RichTextBoxStreamType.RichText);
            }
            else
            {
                rtbLoiBaiHat.Text = "Không tìm thấy lời bài hát.";
            }

        }

        private void rtbLoiBaiHat_TextChanged(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("TinhEmDaiDuong.txt", FileMode.Open);
            //StreamReader rd = new StreamReader(fs, Encoding.UTF8);
            //String giatri = rd.ReadToEnd();
            //rtbLoiBaiHat.Text = giatri;
            //axWindowsMediaPlayer1.URL = lstTapTin.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboODia.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drive in drives)
            {
                cboODia.Items.Add(drive.Name);
            }

        }
    }
}
