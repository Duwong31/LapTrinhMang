using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectNhom
{
    class Modify
    {
        public Modify()
        {

        }
        SqlCommand sqlCommand;//dung de truy van cac cau lenh insert, update, delete,...
        SqlDataReader datareader;//dung de doc du lieu trong bang
        public List<TaiKhoan> TaiKhoans(string query)
        {
            List<TaiKhoan> taikhoans = new List<TaiKhoan>();
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                datareader = sqlCommand.ExecuteReader();
                while (datareader.Read()) 
                {
                    taikhoans.Add(new TaiKhoan(datareader.GetString(0), datareader.GetString(1)));
                }
                sqlConnection.Close();
            }
                return taikhoans;
        }
        public void Command(string query)
        {//đăng ký tài khoản
            using (SqlConnection sqlConnection = Connection.GetSqlConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();//thực thi câu truy vấn
                sqlConnection.Close();
            }
        }
    }
}
