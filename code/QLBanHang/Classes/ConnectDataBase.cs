using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QLBanHang.Classes
{
    
    internal class ConnectDataBase
    {
        SqlConnection sqlConnect=null;
        string connectStr = "Data Source=DESKTOP-L6IMGKE\\SQLEXPRESS;Initial Catalog=QLBanHang;Integrated Security=True";
        //open a Connection to  DataBase
        void OpenConnect()
        {
            sqlConnect=new SqlConnection(connectStr);
            if(sqlConnect.State!=ConnectionState.Open ) 
                sqlConnect.Open();
        }
        //Close a Connection to DataBase
        void CloseConnect()
        {
            if(sqlConnect.State!=ConnectionState.Closed)
            {
                sqlConnect.Close();
                sqlConnect.Dispose();
            }    
        }
        //excute a Select SQL and return a DataTable
        public DataTable ReadData(string sqlSelect)
        {
            DataTable dt = new DataTable();
            //B1: Khai báo chuỗi kết nối,
            //B2: Mở kết nối
            OpenConnect();
            //B3: khai báo lệnh sql -->Tham số của method
            //B4: Thực hiện lệnh SQL
            SqlDataAdapter dataAdapter=new SqlDataAdapter(sqlSelect,sqlConnect);
            dataAdapter.Fill(dt); //Đổ dữ liệu lên DataTable
            //B5: Đóng kết nối và hủy đối tượng
            CloseConnect();
            dataAdapter.Dispose();
            return dt;
        }
        //excute a sql includes: insert, update, delete
        public void UpdateData(string sql)
        {
            //B1: Khai báo chuỗi kết nối,
            //B2: Mở kết nối
            OpenConnect();
            //B3: khai báo lệnh sql -->Tham số của method
            //B4: Thực hiện lệnh SQL
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = sqlConnect;
            cmd.ExecuteNonQuery();
            //B5: Đóng kết nối và hủy đối tượng
            CloseConnect();
            cmd.Dispose();
            
        }
    }
}
