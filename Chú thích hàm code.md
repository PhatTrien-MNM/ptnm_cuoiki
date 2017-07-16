<ul>
// Hàm hiển thị từ bảng thietbi
 <ul>
public DataTable hienthi()
        {
            string sql = " select * from thietbi";
            DataTable dt = new DataTable();
            dt = da.getTable(sql);
            return dt;

        }
</ul>
</ul>
<ul>
//Hàm xóa mã thiết bị từ bảng thietbi
 <ul>
public void delete(string matb)
        {
            string sql = " delete thietbi where matb = '" + matb + "' ";
            da.ExcuteNonQuery(sql);
        }
</ul>
</ul>
<ul>
//Hàm sữa tên thiết bị trong bảng thiết bi
 <ul>
public void sua(string tentb, string matb)
        {
            string sql = "update thietbi set tentb = '" + tentb + "'where matb= '" + matb + "'";
            da.ExcuteNonQuery(sql);
        }
</ul>
</ul>
<ul>
//Hàm thêm  mã thiết bị và tên thiết bị vào bảng thiebi
 <ul>
public void them(string matb, string tentb)
        {
            string sql = "insert into thietbi values('" + matb + "','" + tentb + "')";
            da.ExcuteNonQuery(sql);
        }
</ul>
</ul>
<ul>
//Hàm load mã phòng từ bảng PHONGHOP lên combobox.
</ul>
private void NguoiDung_Load(object sender, EventArgs e)
<ul>
{
DataTable dt = new DataTable();
dt = newnguoidung.hienthi();
dtgNguoiDung.DataSource = dt;
DataTable dk = new DataTable();
dk = newnguoidung.combox();
CboMaPhong.DisplayMember = "maphong";
CboMaPhong.ValueMember = "maphong";
CboMaPhong.DataSource = dk;

}
</ul>
