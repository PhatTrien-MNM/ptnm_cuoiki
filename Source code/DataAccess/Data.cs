using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

// kết nối cơ sở dữ liệu và thực thi lệnh sql
// lệnh sql có 2 dạng
// dạng 1: không trả về bảng(không trả về kết quả   như insert update delete)
// dạng 2 trả về một bản ( select)

namespace DataAccess
{
    public class Data
    {
         public SqlConnection getConnect()
        {
            return new SqlConnection(@"Data Source=TAN\SQLEXPRESS;Initial Catalog=qlph;Integrated Security=True");
        }



        // lenh sql tra ve mot ban 
        public DataTable getTable(string sql)
        {
            SqlConnection con = getConnect();
            SqlDataAdapter ad = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return (dt);
        }
        // lenh sql khong tra ve

        public void ExcuteNonQuery(string sql)
        {
            SqlConnection con = getConnect();
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            con.Close();
        }
        // lam xong nho build
    }
    
}
