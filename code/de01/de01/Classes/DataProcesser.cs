using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace de01.Classes
{
    internal class DataProcesser
    {
        String strConnect = "Data Source=LAPTOP-VNJ8Q8JU\\THOU;Initial Catalog=DuLieu;Integrated Security=True";
        SqlConnection sqlConnect = null;

        //ham mo ket noi
        private void KetNoiCSDL()
        {
            sqlConnect = new SqlConnection(strConnect);
            if (sqlConnect.State != ConnectionState.Open)
            {
                sqlConnect.Open();
            }
        }

        //ham dong ket noi
        private void DongKetNoiCSDL()
        {
            if (sqlConnect.State != ConnectionState.Closed)
            {
                sqlConnect.Close();
            }
            sqlConnect.Dispose();
        }

        //ham thuc thi cau lenh select tra ve datatable
        public DataTable DocBang(string sql)
        {
            DataTable dtBang = new DataTable();
            KetNoiCSDL();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnect);
            sqlDataAdapter.Fill(dtBang);
            DongKetNoiCSDL();
            return dtBang;
        }

        //ham thuc hien insert, update, delete
        public void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlcommand = new SqlCommand();
            sqlcommand.Connection = sqlConnect;
            sqlcommand.CommandText = sql;
            sqlcommand.ExecuteNonQuery();
            DongKetNoiCSDL();
            sqlcommand.Dispose();
        }
    }
}
