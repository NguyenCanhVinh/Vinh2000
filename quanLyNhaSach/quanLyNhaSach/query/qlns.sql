create database QuanLyNhaSach
go
use QuanLyNhaSach
go
create table NhanVien(
	MaNV varchar(15) NOT NULL primary key,
	HoTen nvarchar(50) not null,
	NgaySinh date check(NgaySinh <= getdate()),
	GioiTinh char(1) default 'M' check (GioiTinh in ('M' , 'F','K')),
	ChucVu nvarchar(50),
	Diachi nvarchar(100),
)
go
create table ThuNgan(
	MaNV varchar(15) NOT NULL primary key,
	TenDN varchar(50) not null,
	MatKhau varchar(50) not null,
	CONSTRAINT FK_TN_NV FOREIGN KEY(MaNV) REFERENCES NhanVien
)
go 
create table TacGia(
	MaTG varchar(15) not null primary key,
	TenTG nvarchar(50),
	LienHe nvarchar(100),
)
go 
create table NhaXuatBan(
	MaNXB varchar(15) not null primary key,
	TenNXB nvarchar(100) not null,
	DiaChiNXB nvarchar(200),
	DienThoai numeric(10,0),
)
go

create table KhachHang(
	MaKH varchar(15)  primary key,
	TenKH nvarchar(50) ,
	GioiTinh char(1) default 'M' check (GioiTinh in ('M' , 'F','K')),
	MaSoThue varchar(15),
	DiaChi nvarchar(100),
	DienThoai numeric(10,0),
)
go 
create table TheLoai(
	MaTL varchar(15) not null primary key,
	TenTL nvarchar(50) not null,
)
go
create table PhieuNhap(
	MaPN varchar(15) not null primary key,
	NgayNhap date check( NgayNhap <= getdate()),
	MaNXB varchar(15),
)
go
create table HoaDon(
	SoHD varchar(15) not null primary key,
	NgayBan date check (NgayBan <= getdate()),
)
go 
create table Sach(
	MaSach varchar(15) not null primary key,
	TenSach nvarchar(100) not null,
	MaTG  varchar(15),
	MaNXB varchar(15),
	MaTL  varchar (15),
	SoLuong int,
	DonGia numeric(10,0)
	CONSTRAINT FK_Sach_MaNXB FOREIGN KEY(MaNXB) REFERENCES NhaXuatBan,
	CONSTRAINT FK_Sach_MaTG FOREIGN KEY(MaTG) REFERENCES TacGia,
	CONSTRAINT FK_Sach_MaTL FOREIGN KEY(MaTL) REFERENCES TheLoai
	ON DELETE CASCADE
	ON UPDATE CASCADE
)
go 
create table ChiTietPhieuNhap(
	MaPN varchar(15),
	MaSach varchar(15),
	SoLuongNhap int,
	GiaNhap numeric(10,0),
	CONSTRAINT FK_ChiTietPhieuNhap_MaPN FOREIGN KEY(MaPN) REFERENCES PhieuNhap,
	CONSTRAINT FK_ChiTietPhieuNhap_MaSach FOREIGN KEY(MaSach) REFERENCES Sach
	ON DELETE CASCADE
	ON UPDATE CASCADE
)
go 
create table ChiTietHoaDon(
	SoHD varchar(15),
	MaSach varchar(15),
	SoLuongBan int,
	GiaBan numeric(10,0),
	
	CONSTRAINT FK_ChiTietHoaDon_SoHD FOREIGN KEY(SoHD) REFERENCES HoaDon,
	CONSTRAINT FK_ChiTietHoaDon_MaSach FOREIGN KEY(MaSach) REFERENCES Sach,

	ON DELETE CASCADE
	ON UPDATE CASCADE
)
go 
create table SachBan(
	MaSach varchar(15) not null ,
	MaNV varchar(15),
	MaKH varchar( 15),
	SoHD varchar(15),
	SoLuongTonKho int,
	SoLuongSachBan int,
	GiaBan numeric(10,0),
	GiamGia int,
	TongTien numeric(10,0),
	CONSTRAINT FK_SachBan_MaSach FOREIGN KEY(Masach) REFERENCES Sach,
	CONSTRAINT FK_SachBan_MaKH FOREIGN KEY(MaKH) REFERENCES KhachHang,
	CONSTRAINT FK_SachBan_MaNV FOREIGN KEY(MaNV) REFERENCES NhanVien,
	CONSTRAINT FK_SachBan_SoHD FOREIGN KEY(SoHD) REFERENCES HoaDon
	ON DELETE CASCADE
	ON UPDATE CASCADE
)
go 
--thêm dữ liệu vào bảng nhân viên
insert into NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, Diachi)
values('17DC029',N'Lê Ngọc Bảo','07/02/1998','M',N'Quản Lý',N'09 Ngô Tất Tố, Nha Trang, Khánh Hòa')

insert into NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, Diachi)
values('17DC011',
N'Nguyễn Văn Quân',
'05/25/1999',
'M',
N'Quản Lý',
N'07 Mai Xuân Thưởng, Nha Trang, Khánh Hòa')


insert into NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, Diachi)
values('17DC016',
N'Nguyễn Minh Thông',
'06/19/1999',
'M',
N'Nhân Viên',
N'09 Đoàn Trần Nghiệp, Nha Trang, Khánh Hòa')

insert into NhanVien(MaNV, HoTen, NgaySinh, GioiTinh, ChucVu, Diachi)
values('17DC007',
N'Vũ Ngọc Thạch',
'09/07/1999',
'M',
N'Nhân Viên',
N'07 Lê Hồng Phong, Nha Trang, Khánh Hòa')

-- thêm dữ liệu vào bảng thu ngân

insert into ThuNgan(MaNV, TenDN, MatKhau)
values('17DC029', 'bao1910','19101999')

insert into ThuNgan(MaNV, TenDN, MatKhau)
values('17DC011','anhquantr123','anhquantr123')

insert into ThuNgan(MaNV, TenDN, MatKhau)
values('17DC016','minhthong','123456')

insert into ThuNgan(MaNV, TenDN, MatKhau)
values('17DC007','ngocthach','123456')
--thêm dữ liệu vào bảng khách hàng
insert into KhachHang(MaKH, TenKH, GioiTinh, MaSoThue, DiaChi, DienThoai)
values ('KH0000056789',N'Lê Thị Phương Thảo','F','TH00045',N'10 Nguyễn Thị Định, Nha Trang, Khánh Hòa',0987123256)
go 
create trigger capnhatsachban
on SachBan for insert as update Sach
		set Sach.SoLuong = Sach.SoLuong - inserted.SoLuongSachBan
		from Sach inner join inserted 
		on Sach.MaSach = inserted.MaSach
go 
alter table ChiTietHoaDon
add MaKH varchar(15);

go alter table ChiTietHoaDon
add constraint fk_khachhang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH);

go 
create trigger capnhatsoluong
on ChiTietPhieuNhap for insert as update Sach
		set Sach.SoLuong = Sach.SoLuong + inserted.SoLuongNhap
		from Sach inner join inserted 
		on Sach.MaSach = inserted.MaSach
go 

