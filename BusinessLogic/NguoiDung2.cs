using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BusinessLogic
{
   public class NguoiDung2
    {
       Data da = new Data();
      // hàm hiển thị người dùng
       public DataTable hienthi()
       {
           string sql = " select * from nguoidung";
           DataTable dt = new DataTable();
           dt = da.getTable(sql);
           return dt;

       }
       // hàm xóa một dòng trong bảng người dùng
       public void delete(string mand)
       {
           string sql = " delete nguoidung where mand = '" + mand + "' ";
           da.ExcuteNonQuery(sql);
       }

       // hiển thị lên combbox
       public DataTable combox()
       {
           string sql = " select * from phonghop";
           DataTable dk = new DataTable();
           dk = da.getTable(sql);
           return dk;

       }










    }
}
