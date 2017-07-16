**Chú thích thư viện**
<li>
using DataAccess;  // gọi lại lớp Data lớp DataAccess để sử dung.
</li>
<li>
using BusinessLogic;  //gọi lại lớp BusinessLogic để sử dụng.
</li>
<li>
Datatable: là dùng để lưu trữ dữ liệu.
</li>
<li>
ExcuteNonQuery: dùng để thực thi các câu truy vấn như INSERT, DELETE, UPDATE. nó trả về kiểu int chính là số dòng trong table của database bị thay đổi bởi 3 lệnh trên.
</li>
<li>
DataGridview là control dùng để hiển thị dữ liệu lên trên giao diện.
</li>
</li>
**Giải thích một số hàm code**
<li>
// Hàm hiển thị từ bảng thietbi.
</li>
<ul>public DataTable hienthi()</ul>
       <ul> {</ul>
           <ul> string sql = " select * from thietbi";</ul>
            <ul>DataTable dt = new DataTable();</ul>
          <ul>  dt = da.getTable(sql);</ul>
          <ul>  return dt;</ul>
        <ul>}</ul>
<li>
//Hàm xóa mã thiết bị từ bảng thietbi
</li>
<ul>public void delete(string matb)</ul>
       <ul> {</ul>
           <ul> string sql = " delete thietbi where matb = '" + matb + "' ";</ul>
            <ul>da.ExcuteNonQuery(sql);</ul>
       <ul> }</ul>
<li>
//Hàm sữa tên thiết bị trong bảng thiết bi
</li>
 <ul>
public void sua(string tentb, string matb)</ul>
       <ul> {</ul>
            <ul>string sql = "update thietbi set tentb = '" + tentb + "'where matb= '" + matb + "'";</ul>
           <ul> da.ExcuteNonQuery(sql);</ul>
       <ul> }</ul>
<li>
//Hàm thêm  mã thiết bị và tên thiết bị vào bảng thiebi
</li>
<ul>public void them(string matb, string tentb)</ul>
       <ul> {</ul>
           <ul> string sql = "insert into thietbi values('" + matb + "','" + tentb + "')";</ul>
          <ul>  da.ExcuteNonQuery(sql);</ul>
        <ul>}</ul>
<li>
//Hàm load mã phòng từ bảng PHONGHOP lên combobox.
</li>
<ul>private void NguoiDung_Load(object sender, EventArgs e)</ul>
<ul>
{</ul>
<ul>DataTable dt = new DataTable();</ul>
<ul>dt = newnguoidung.hienthi();</ul>
<ul>dtgNguoiDung.DataSource = dt;</ul>
<ul>DataTable dk = new DataTable();</ul>
<ul>dk = newnguoidung.combox();</ul>
<ul>CboMaPhong.DisplayMember = "maphong";</ul>
<ul>CboMaPhong.ValueMember = "maphong";</ul>
<ul>CboMaPhong.DataSource = dk;</ul>

<ul>}
</ul>
