using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
namespace BusinessLogic
{
     public  class ThietBiPhong2
    {
         Data da = new Data();

         public DataTable hienthi()
         {
             string sql = " select * from tbphong";
             DataTable dt = new DataTable();
             dt = da.getTable(sql);
             return dt;

         }
         public void delete(string matb)
         {
             string sql = " delete tbphong where matb = '" + matb + "' ";
             da.ExcuteNonQuery(sql);
         }
         public void sua( string matb, string maphong ,int soluong,string donvitinh,string matbp)
         {
             string sql = "update tbphong set matb = '" + matb + "', maphong = '" + maphong + "',soluong = '" + soluong + "',donvitinh = '" + donvitinh + "' where matbp= '" + matbp + "'";
             da.ExcuteNonQuery(sql);
         }
         public DataTable combox()
         {
             string sql = " select * from phonghop";
             DataTable dk = new DataTable();
             dk = da.getTable(sql);
             return dk;

         }
         public DataTable comboxTB()
         {
             string sql = " select * from thietbi";
             DataTable db = new DataTable();
             db = da.getTable(sql);
             return db;

         }
         public void them( string matbp, string matb, string maphong, int soluong, string donvitinh)
         {
             string sql = "insert into tbphong values('" + matbp + "','" + matb + "','" + maphong + "','" + soluong + "','" + donvitinh + "')";
             da.ExcuteNonQuery(sql);
         }
    }
}
 