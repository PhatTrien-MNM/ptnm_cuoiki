##File  Database Quản lý phòng họp
<ul>Bảng PHONGHOP (Phòng họp)
 
 use QLPH
  go
    create table PHONGHOP
      (
         MaPhong varchar(10) primary key,
         Tang nvarchar(50) not null,
         Size nvarchar(50) not null
      )
</ul>
<ul> Bảng THIETBI (Thiết Bị)
  
  use QLPH
   go
       create table THIETBI
        (
         MaTB varchar(10) primary key,
         TenTB nvarchar(50) not null
        )
</ul>
<ul>Bảng TBPHONG (Thiết Bị Phòng)
  use QLPH
   go
     create table TBPHONG
      (
        MaTB varchar(10) not null,
        MaPhong varchar(10) not null,
        SoLuong int,
        DonViTinh nvarchar(50) not null,
        CONSTRAINT Ma PRIMARY KEY (MaTB, MaPhong)
       );
</ul>
<ul>Bảng THANHVIEN (Thành Viên)
  use QLPH
   go
     create table THANHVIEN
      (
        MaTV varchar(10) primary key,
        HoTenTV nvarchar(50) not null,
        GioiTinh bit,
        DiaChi nvarchar(50) not null,
        Email nvarchar(50) not null,
        SDT int
      );
</ul>
<ul>Bảng NGUOIDUNG (Người Dùng)
   use QLPH
    go
      create table NGUOIDUNG
         (
             MaND varchar(10) primary key,
             HoTenND nvarchar(50) not null,
             GioiTinh bit,
             DiaChi nvarchar(50) not null,
             Email nvarchar(50) not null,
             SDT int,
             FOREIGN KEY (MaPhong) REFERENCES PHONGHOP(MaPhong)

           );
</ul>



