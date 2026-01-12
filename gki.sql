create database ktgk

use ktgk

create table tblMonHoc(
	MaMon varchar(10) not null primary key,
	TenMon nvarchar(100) not null,
	SoTin int
)


insert into tblMonHoc values
('TRR', N'Toán rời rạc', 3),
('GT1', N'Giải tích 1', 3),
('CTDL', N'Cấu trúc dữ liệu', 3),
('LTTQ', N'Lập trình trực quan', 3),
('TKCSDL', N'Thiết kế cơ sở dữ liệu', 3),
('TTUD', N'Thuật toán ứng dụng', 2)

