##File  Database Quản lý phòng họp
<li>
Bảng PHONGHOP (Phòng họp)
</li>
 <ul>
use QLPH
  go
    create table PHONGHOP
      (
         MaPhong varchar(10) not null primary key,
         Tang nvarchar(50) not null,
         Size nvarchar(50) not null
      );
</ul>
<li>
Bảng THIETBI (Thiết Bị)
</li>
<ul>
use QLPH
   go
       create table THIETBI
        (
         MaTB varchar(10) not null primary key,
         TenTB nvarchar(50) not null
        );
</ul>
<li>
Bảng TBPHONG (Thiết Bị Phòng)
</li>
<ul>
use QLPH
   go
     create table TBPHONG
      (
        MaTBP varchar(10) not null primary key,
        MaTB varchar(10) not null,
        MaPhong varchar(10) not null,
        SoLuong int,
        DonViTinh nvarchar(50) not null,
        FOREIGN KEY (MaTB) REFERENCES THIETBI(MaTB) 
        FOREIGN KEY (MaPhong) REFERENCES PHONGHOP(MaPhong)
        );
</ul>
<li>
Bảng THANHVIEN (Thành Viên)
</li>
<ul>
use QLPH
   go
     create table THANHVIEN
      (
        MaTV varchar(10) not null primary key,
        HoTenTV nvarchar(50) not null,
        GioiTinh bit,
        DiaChi nvarchar(50) not null,
        Email nvarchar(50) not null,
        SDT int
      );
</ul>
<li>
Bảng NGUOIDUNG (Người Dùng)
</li>
<ul>
use QLPH
    go
      create table NGUOIDUNG
         (
             MaND varchar(10) not null primary key,
             HoTenND nvarchar(50) not null,
             GioiTinh bit,
             DiaChi nvarchar(50) not null,
             Email nvarchar(50) not null,
             SDT int,
             FOREIGN KEY (MaPhong) REFERENCES PHONGHOP(MaPhong)

           );
</ul>



