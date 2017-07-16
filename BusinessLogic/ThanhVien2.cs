using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
    
    public class ThanhVien2
    {
        Data da = new Data();

        public DataTable hienthi()
        {
            string sql = " select * from thanhvien";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;

        }
        public void delete(string matv)
        {
            string sql = " delete thanhvien where matv = '" + matv + "' ";
            da.ExcuteNonQuery(sql);
        }

        public void sua(string hotentv, string gioitinh ,string diachi, string email,int sdt, string matv)
        {
            
            string sql = "update thanhvien set hotentv = '" + hotentv + "',gioitinh = '" + gioitinh + "',diachi = '" + diachi + "',email = '" + email + "', sdt = '" + sdt + "' where matv= '" + matv + "'";
            da.ExcuteNonQuery(sql);
        }
        public void them(string matv, string hotentv, string gioitinh, string diachi, string email, int sdt)
        {
            string sql = "insert into thanhvien values('" + matv + "','" + hotentv + "','" + gioitinh + "','" + diachi + "','" + email + "','" + sdt + "')";
            da.ExcuteNonQuery(sql);
        }



    }

}
