using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chuong6_banhangluuniem.DangNhap;

namespace Chuong6_banhangluuniem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool loginSuccess = false;
            while (!loginSuccess)
            {
                frmLogin frmLogin = new frmLogin();

                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    loginSuccess = true;
                    Application.Run(new frmMain());
                }
                else
                {
                    //DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?",
                    //                                     "Xác nhận",
                    //                                     MessageBoxButtons.YesNo,
                    //                                     MessageBoxIcon.Question);
                    //if (result == DialogResult.Yes)
                    //{
                    //    return; // Thoát chương trình
                    //}
                    return;
                }

            }

            
        }
    }
}
