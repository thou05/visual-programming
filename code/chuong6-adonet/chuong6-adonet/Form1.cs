using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace chuong6_adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dtLoTrinh = new DataTable();
            //bước 1: tạo kết nối
            string strConnect = "Data Source=LAPTOP-VNJ8Q8JU\\THOU; DataBase=QLVanTai; Integrated Security = True";
            SqlConnection sqlConnect = new SqlConnection(strConnect);

            //bước 2: mở kết nối
            if(sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }

            //b3: tạo lệnh sql
            string sqlSelect = "Select * from LoTrinh";

            //b4: thực hiện lệnh sql
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlSelect, sqlConnect);
            dataAdapter.Fill(dtLoTrinh);

            //b5: đóng kết nối và hủy các đối tượng
            if(sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
            }
            sqlConnect.Dispose();

            //đổ dữ liệu vào datagridview
            dgvLoTrinh.DataSource = dtLoTrinh;
        }
    }
}
