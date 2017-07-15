**Mã nguồn được tổ chức và chú thích**
<ul>
Mã nguồn được tổ chức theo mô hình 3 lớp.
Gồm:
<li>Lớp thứ nhất: Presentation(hiển thị các thành phần giao diện để tương tác với người dùng như tiếp nhận thông tin, thông báo lỗi)
</li>
<li>
Lớp thứ hai:Business Logic Layer(thực hiện các hành động nghiệp vụ của phần mềm như tính toán, đánh giá tính hợp lệ của thông tin,.. Tầng này còn di chuyển, xử lí thông tin giữa 2 tầng dưới)
</li>
<li>
Lớp thứ ba:Data Access Layer(nơi lưu trữ và trích xuất dữ liệu từ các hệ quản trọ CSDL hay các file trng hệ thống. cho Phép tầng Business Logic Layer thực hiện truy vấn dữ liệu)
</li>
</ul>

<ul>
Chú thích
</ul>
<ul>
<li>
DataTable là dùng để lưu trữ dữ liệu.
</li>
<li>ExcuteNonQuery dùng để thực thi các câu truy vấn như INSERT, DELETE, UPDATE. nó trả về kiểu int chính là số dòng trong table của database bị thay đổi bởi 3 lệnh trên</li>
<li>
DataGridview là control dùng để hiển thị dữ liệu lên trên giao diện
</li>
</ul>

