create database banhangluuniem
go
use banhangluuniem

CREATE TABLE tblChatlieu (
    MaChatLieu NVARCHAR(10) PRIMARY KEY,
    TenChatLieu NVARCHAR(50)
);

CREATE TABLE tblHang (
    MaHang NVARCHAR(10) PRIMARY KEY,
    TenHang NVARCHAR(50),
    MaChatLieu NVARCHAR(10),
    SoLuong INT,
    DonGiaNhap FLOAT,
    DonGiaBan FLOAT,
    Anh NVARCHAR(255),
    GhiChu NVARCHAR(200),
    FOREIGN KEY (MaChatLieu) REFERENCES tblChatlieu(MaChatLieu)
);

CREATE TABLE tblNhanvien (
    MaNhanVien NVARCHAR(10) PRIMARY KEY,
    TenNhanVien NVARCHAR(50),
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(100),
    DienThoai NVARCHAR(20),
    NgaySinh DATE
);

CREATE TABLE tblKhach (
    MaKhach NVARCHAR(10) PRIMARY KEY,
    TenKhach NVARCHAR(50),
    DiaChi NVARCHAR(100),
    DienThoai NVARCHAR(20)
);

CREATE TABLE tblHDBan (
    MaHDBan NVARCHAR(10) PRIMARY KEY,
    MaNhanVien NVARCHAR(10),
    NgayBan DATE,
    MaKhach NVARCHAR(10),
    TongTien FLOAT,
    FOREIGN KEY (MaNhanVien) REFERENCES tblNhanVien(MaNhanVien),
    FOREIGN KEY (MaKhach) REFERENCES tblKhach(MaKhach)
);

CREATE TABLE tblChitietHDBan (
    MaHDBan NVARCHAR(10),
    MaHang NVARCHAR(10),
    SoLuong INT,
    GiaMua FLOAT,
    ThanhTien FLOAT,
    PRIMARY KEY (MaHDBan, MaHang),
    FOREIGN KEY (MaHDBan) REFERENCES tblHDBan(MaHDBan),
    FOREIGN KEY (MaHang) REFERENCES tblHang(MaHang)
);


INSERT INTO tblChatlieu (MaChatLieu, TenChatLieu) VALUES
('CL01', N'Gỗ'),
('CL02', N'Sứ'),
('CL03', N'Nhựa'),
('CL04', N'Thủy tinh');

INSERT INTO tblHang (MaHang, TenHang, MaChatLieu, SoLuong, DonGiaNhap, DonGiaBan, Anh, GhiChu) VALUES
('H001', N'Tượng gỗ nhỏ', 'CL01', 50, 50000, 85000, NULL, N'Hàng thủ công'),
('H002', N'Ly sứ in logo', 'CL02', 30, 30000, 60000, NULL, N'Hàng bán chạy'),
('H003', N'Móc khóa nhựa', 'CL03', 100, 8000, 15000, NULL, NULL),
('H004', N'Chai thủy tinh quà tặng', 'CL04', 20, 40000, 75000, NULL, NULL);

INSERT INTO tblNhanvien (MaNhanVien, TenNhanVien, GioiTinh, DiaChi, DienThoai, NgaySinh) VALUES
('NV01', N'Nguyễn Văn An', N'Nam', N'Hà Nội', '0988000111', '1998-03-15'),
('NV02', N'Trần Thị Bình', N'Nữ', N'Hải Phòng', '0911222333', '1999-07-20');

INSERT INTO tblKhach (MaKhach, TenKhach, DiaChi, DienThoai) VALUES
('KH01', N'Phạm Minh Tuấn', N'Hà Nội', '0905123456'),
('KH02', N'Lê Thu Hằng', N'Quảng Ninh', '0987654321');

INSERT INTO tblHDBan (MaHDBan, MaNhanVien, NgayBan, MaKhach, TongTien) VALUES
('HD01', 'NV01', '2024-10-01', 'KH01', 245000),
('HD02', 'NV02', '2024-10-02', 'KH02', 150000);

INSERT INTO tblChitietHDBan (MaHDBan, MaHang, SoLuong, GiaMua, ThanhTien) VALUES
('HD01', 'H001', 2, 85000, 170000),
('HD01', 'H003', 5, 15000, 75000),
('HD02', 'H002', 2, 60000, 120000),
('HD02', 'H004', 1, 75000, 75000);