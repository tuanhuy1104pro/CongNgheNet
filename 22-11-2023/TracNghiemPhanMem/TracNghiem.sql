use master
create database CauHoiTracNghiem
use CauHoiTracNghiem

create table CauHoi
(
	MaCauHoi int identity primary key,
	CauHoi nvarchar(100)
)
create table KetQua
(
	MaCauHoi int foreign key references CauHoi primary key,
	KetQua char(1)
)
