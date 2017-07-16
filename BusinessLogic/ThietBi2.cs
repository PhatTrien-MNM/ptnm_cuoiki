using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    public class ThietBi2
    {
        Data da = new Data();
        // vieest ham lay thong va dua len datagrivew
        public DataTable hienthi()
        {
            string sql = " select * from thietbi";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;

        }
        public void delete(string matb)
        {
            string sql = " delete thietbi where matb = '" + matb + "' ";
            da.ExcuteNonQuery(sql);
        }
        public void sua(string tentb, string matb)
        {
            string sql = "update thietbi set tentb = '" + tentb + "'where matb= '" + matb + "'";
            da.ExcuteNonQuery(sql);
        }
        public void them(string matb, string tentb)
        {
            string sql = "insert into thietbi values('" + matb + "','" + tentb + "')";
            da.ExcuteNonQuery(sql);
        }
    }
}
