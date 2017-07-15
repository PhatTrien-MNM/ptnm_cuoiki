using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class Phong2
    {
        Data da = new Data();
        // vieest ham lay thong va dua len datagrivew
        public DataTable hienthiphong()
        {
            string sql = " select * from phonghop";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;

        }
        public void delete(string maphong)
        {
            string sql = " delete phonghop where maphong = '" + maphong + "' ";
            da.ExcuteNonQuery(sql);
        }
        public void sua(string tang, string size,string maphong)
        {
            string sql = "update phonghop set tang = '" + tang + "',size = '" + size + "'where maphong= '" + maphong + "'";
            da.ExcuteNonQuery(sql);
        }
        public void them(string maphong, string tang, string size)
        {
            string sql = "insert into phonghop values('" + maphong + "','" + tang + "','" + size + "')";
            da.ExcuteNonQuery(sql);
        }

    }
}
