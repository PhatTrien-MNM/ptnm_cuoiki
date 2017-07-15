<ul>
// Hàm hiển thị từ bảng thietbi
 public DataTable hienthi()
        {
            string sql = " select * from thietbi";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;

        }
</ul>
<ul>
//Hàm xóa mã thiết bị từ bảng thietbi
 public void delete(string matb)
        {
            string sql = " delete thietbi where matb = '" + matb + "' ";
            da.ExcuteNonQuery(sql);
        }
</ul>
<ul>
//Hàm sữa tên thiết bị trong bảng thiết bi
 public void sua(string tentb, string matb)
        {
            string sql = "update thietbi set tentb = '" + tentb + "'where matb= '" + matb + "'";
            da.ExcuteNonQuery(sql);
        }
</ul>
<ul>
//Hàm thêm  mã thiết bị và tên thiết bị vào bảng thiebi
 public void them(string matb, string tentb)
        {
            string sql = "insert into thietbi values('" + matb + "','" + tentb + "')";
            da.ExcuteNonQuery(sql);
        }
</ul>