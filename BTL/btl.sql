create database QuanLyHocSinh
use QuanLyHocSinh
create table MonHoc
(
	maMon nvarchar(10) primary key not null,
	tenMon nvarchar(30) not null,
	soTiet float not null 
)
--mon
insert into MonHoc values ('MH001',N'Lập trình window',85)
insert into MonHoc values ('MH002',N'Lập trình nhúng',45)
insert into MonHoc values ('MH003',N'Lập trình web',55)
insert into MonHoc values ('MH004',N'Lập trình android',40)
insert into MonHoc values ('MH005',N'Lập trình app',45)
--test
select * from MonHoc

create table CanBoGiaoVien
(
	maCBGV nvarchar(10) primary key not null,
	hoTen nvarchar(30) not null,
	diaChi nvarchar(30) not null,
	soDienThoai nvarchar(30) not null,
	taiKhoan nvarchar(30) not null,
	matKhau nvarchar(30) not null,
	loaiTaiKhoan nvarchar(30) not null
	
)
--can bo giao vien
insert into CanBoGiaoVien values ('GV001',N'Nguyễn Văn An',N'Hà Nội','012345678','vanan','1','gv')
insert into CanBoGiaoVien values ('GV002',N'Nguyễn Đức Anh',N'Thái Bình','012345678','ducanh','1','gv')
insert into CanBoGiaoVien values ('GV003',N'Nguyễn Văn Canh',N'Hải Dưwong','098765432','admin','admin','admin')
--test
select * from CanBoGiaoVien

create table Lop
(
	maLop nvarchar(10) primary key not null,
	tenLop nvarchar(30) not null,
	nienKhoa nvarchar(10) not null,
	siSo int not null,
	maCBGV nvarchar(10) not null,
	constraint FK1 Foreign Key(maCBGV) references CanBoGiaoVien(maCBGV) on update cascade on delete cascade
)
--Lop
insert into Lop values ('L001',N'Công nghệ thông tin','10',35,'GV001')
insert into Lop values ('L002',N'Khoa học máy tính ','11',23,'GV002')
insert into Lop values ('L003',N'Ky thuật phần mềm','10',50,'GV001')
insert into Lop values ('L004',N'Điện tử','11',60,'GV002')
insert into Lop values ('L005',N'Tự động hoá','10',80,'GV002')
insert into Lop values ('L006',N'Tiếng anh','12',32,'GV001')
--test
select * from Lop

create table HoSoHocSinh
(
	maHocSinh nvarchar(10) primary key not null,
	hoTen nvarchar(30) not null,
	ngaySinh date not null,
	gioiTinh nvarchar(10) not null,
	diaChi nvarchar(30) not null,
	diemVaoTruong float not null,
	hoTenBoMe nvarchar(30),
	soDienThoai nvarchar(30),
	maLop nvarchar(10),
	constraint FK2 Foreign Key(maLop) references Lop(maLop) on update cascade on delete cascade

)
select * from HoSoHocSinh
insert into HoSoHocSinh values ('HS001',N'Đỗ Đức Vinh','12/02/1997','Nam',N'Thái Bình',23,N'Đỗ Văn Linh','01696437653','L001')
insert into HoSoHocSinh values ('HS002',N'Nguyễn Đức Anh','12/20/1997','Nam',N'Hà Nam',25,N'Nguyễn Văn Cừ','01696437653','L002')
insert into HoSoHocSinh values ('HS003',N'Nguyễn Dục Bá','12/20/1997','Nam',N'Hải Dương',29,N'Nguyeẽn Thị Sen ','01696437653','L001')
insert into HoSoHocSinh values ('HS004',N'Đỗ Văn Bằng','12/20/1997','Nam',N'Hà Đông',15,N'Đỗ Thị Sào','01696437653','L004')
insert into HoSoHocSinh values ('HS005',N'Đào Đức Ngao','12/20/1997','Nam',N'Hải Phòng',21,N'Đào Đức Ngán','01696437653','L003')
insert into HoSoHocSinh values ('HS006',N'Vũ Trọng Bảo','8/20/1997',N'Nữ',N'Hà Nội',18,N'Đỗ Văn HẢI','01696437653','L005')
insert into HoSoHocSinh values ('HS007',N'Đỗ Văn Cừ','12/20/1997','Nam',N'Hà Nội',19,N'Vũ Thị Biệt','01696437653','L003')
--test
select * from HoSoHocSinh


create table PhanCongGiangDay
(
	maLop nvarchar(10) not null,
	maMon nvarchar(10) not null,
	maCBGV nvarchar(10) not null,
	ngayPhanCong date not null,
	constraint PK1 primary key(maLop,maMon,maCBGV),
	constraint FK3 Foreign Key(maLop) references Lop(maLop) on update cascade on delete cascade,
	constraint FK4 Foreign Key(maMon) references MonHoc(maMon) on update cascade on delete cascade,
	constraint FK5 Foreign Key(maCBGV) references CanBoGiaoVien(maCBGV) 
)
insert into PhanCongGiangDay values ('L001','MH001','GV001','2/22/2016')
insert into PhanCongGiangDay values ('L002','MH005','GV002','8/13/2016')
insert into PhanCongGiangDay values ('L003','MH004','GV002','12/7/2016')
insert into PhanCongGiangDay values ('L004','MH002','GV001','11/2/2016')
insert into PhanCongGiangDay values ('L005','MH003','GV001','5/8/2016')
--test
select * from PhanCongGiangDay

create table diem
(
	maHocSinh nvarchar(10),
	maMon nvarchar(10),
	diemTBKy1 float,
	diemTBky2 float,
	constraint PK2 primary key(maHocSinh,maMon),
	constraint FK6 Foreign Key(maMon) references MonHoc(maMon) on update cascade on delete cascade,
	constraint FK7 Foreign Key(maHocSinh) references HoSoHocSinh(maHocSinh) on update cascade on delete cascade
)

insert into diem values ('HS001','MH001',7,0)
insert into diem values ('HS002','MH001',10,8)
insert into diem values ('hS003','MH002',2,10)
insert into diem values ('hS003','MH001',2,null)
insert into diem values ('HS004','MH003',9,10)
insert into diem values ('HS002','MH002',10,10)
insert into diem values ('HS003','MH004',10,10)
insert into diem values ('HS004','MH002',10,3)
insert into diem values ('HS005','MH002',6,10)
insert into diem values ('HS005','MH003',null,null)
--test
delete from diem
where maHocSinh='HS005' and maMon='MH003'

create view v1
as
(
	select maHocSinh,hoTen,gioiTinh,diaChi,hoTenBoMe, soDienThoai,maLop
	from HoSoHocSinh 
)
alter view v2
as
(
	select CanBoGiaoVien.maCBGV,hoTen,tenMon,ngayPhanCong,soDienThoai,maLop
	from CanBoGiaoVien inner join PhanCongGiangDay on CanBoGiaoVien.maCBGV =PhanCongGiangDay.maCBGV
	inner join MonHoc on MonHoc.maMon=PhanCongGiangDay.maMon
)