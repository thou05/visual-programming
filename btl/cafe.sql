
--DB UPDATED

drop database QLCafe

CREATE DATABASE QLCafe;
GO
USE banhangluuniem;
USE QLCafe;
GO

-- Bảng Loại (Danh mục sản phẩm)
CREATE TABLE Loai (
    MaLoai INT PRIMARY KEY,
    TenLoai NVARCHAR(255)
);

-- Bảng Nhà Cung Cấp
CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY,
    TenNCC NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SDT VARCHAR(15)
);

-- Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(200),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT VARCHAR(15)
);

-- Bảng Nguyên Liệu
CREATE TABLE NguyenLieu (
    MaNL INT PRIMARY KEY,
    TenNL NVARCHAR(255),
    SoLuong INT,
    HanSuDung DATE,
    DonGia DECIMAL(10, 2)
);

-- Bảng Sản Phẩm
CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(255),
    GiaBan DECIMAL(10, 2),
    MoTa NVARCHAR(MAX),
    MaLoai INT,
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai)
);

-- Bảng Tài Khoản
CREATE TABLE TaiKhoan (
    MaTK INT PRIMARY KEY,         -- Mã tài khoản
    Ten NVARCHAR(255),             -- Tên người dùng
    TenDangNhap VARCHAR(255),     -- Tên đăng nhập
    MatKhau VARCHAR(255),         -- Mật khẩu
    LoaiTaiKhoan NVARCHAR(50)      -- Loại tài khoản (ví dụ: Admin, User)
);

-- Bảng Khách Hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
	TenKH NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SDT VARCHAR(15)
    
);

-- Bảng Bàn
CREATE TABLE Ban (
    MaBan INT PRIMARY KEY,
    TenBan NVARCHAR(255),
    GioVao TIME,
    GioRa TIME,
    TrangThaiThanhToan NVARCHAR(50)
);

-- Bảng Hóa Đơn Bán
CREATE TABLE HoaDonBan (
    MaHDB INT PRIMARY KEY,
    NgayBan DATE,
    TongTien DECIMAL(10, 2),
    PhuongThucThanhToan NVARCHAR(50),
    MaNV INT,
    MaKH INT,
    MaBan INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
);

-- Bảng Chi Tiết HDB
CREATE TABLE ChiTietHDB (
    MaSP INT,
    MaHDB INT,
    SoLuong INT,
    ThanhTien DECIMAL(10, 2),
    KhuyenMai DECIMAL(5, 2),
    PRIMARY KEY (MaSP, MaHDB),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP),
    FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB)
);

-- Bảng Hóa Đơn Nhập
CREATE TABLE HoaDonNhap (
    MaHDN INT PRIMARY KEY,
    NgayNhap DATE,
    TongTien DECIMAL(10, 2),
    MaNV INT,
    MaNCC INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- Bảng Chi Tiết HDN
CREATE TABLE ChiTietHDN (
    MaHDN INT,
    MaNL INT,
    SoLuong INT,
    ThanhTien DECIMAL(10, 2),
    KhuyenMai DECIMAL(5, 2),
    PRIMARY KEY (MaHDN, MaNL),
    FOREIGN KEY (MaHDN) REFERENCES HoaDonNhap(MaHDN),
    FOREIGN KEY (MaNL) REFERENCES NguyenLieu(MaNL)
);


-- Dữ liệu mẫu cho bảng Loại (Danh mục sản phẩm)
INSERT INTO Loai (MaLoai, TenLoai)
VALUES (1, N'Cà phê'),
       (2, N'Trà'),
       (3, N'Đồ ăn nhẹ'),
       (4, N'Nước ép');

-- Dữ liệu mẫu cho bảng Sản Phẩm
INSERT INTO SanPham (MaSP, TenSP, GiaBan, MoTa, MaLoai)
VALUES (1, N'Cà phê đen', 25000, N'Cà phê đen nguyên chất', 1),
       (2, N'Cà phê sữa đá', 30000, N'Cà phê đen với sữa đá', 1),
       (3, N'Trà sữa', 35000, N'Trà sữa thơm ngon', 2),
       (4, N'Bánh mì', 20000, N'Bánh mì kẹp thịt nướng', 3),
       (5, N'Nước cam', 25000, N'Nước ép cam tươi', 4),
       (6, N'Bánh ngọt', 18000, N'Bánh ngọt mới ra lò', 3);

-- Dữ liệu mẫu cho bảng Nhân Viên
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, GioiTinh, NgaySinh, SDT)
VALUES (1, N'Nguyễn Văn A', N'12 Đường ABC, Quận 1', N'Nam', '1990-06-15', '0912345678'),
       (2, N'Trần Thị B', N'34 Đường DEF, Quận 2', N'Nữ', '1995-09-25', '0987654321'),
       (3, N'Lê Minh C', N'56 Đường GHI, Quận 3', N'Nam', '1988-03-10', '0922334455');

 -- Dữ liệu mẫu cho bảng Khách Hàng
INSERT INTO KhachHang (MaKH, DiaChi, SDT, TenKH)
VALUES (1, N'123 Đường 1, Quận 1', N'0901234567', N'Phạm Thị D'),
       (2, N'789 Đường 2, Quận 3', N'0912345678', N'Vũ Minh E'),
       (3, N'456 Đường 3, Quận 4', N'0922334455', N'Nguyễn Hoàng F');

-- Dữ liệu mẫu cho bảng NhaCungCap (Nhà cung cấp)
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT)
VALUES (1, N'Công ty Cung cấp Cafe ABC', N'123 Đường ABC, Quận 1', N'0987654321'),
       (2, N'Công ty Cung cấp Nguyên liệu XYZ', N'456 Đường DEF, Quận 2', N'0123456789');

-- Dữ liệu mẫu cho bảng NguyenLieu (Nguyên liệu)
INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, HanSuDung, DonGia)
VALUES (1, N'Nguyên liệu 1', 500, '2025-12-31', 2500),
       (2, N'Nguyên liệu 2', 300, '2025-12-31', 1000);

-- Dữ liệu mẫu cho bảng Bàn
INSERT INTO Ban (MaBan, TenBan, GioVao, GioRa, TrangThaiThanhToan)
VALUES (1, N'Bàn 1', '10:00', '12:00', N'Chưa thanh toán'),
       (2, N'Bàn 2', '11:00', '13:00', N'Đã thanh toán'),
       (3, N'Bàn 3', '09:00', '11:00', N'Chưa thanh toán'),
       (4, N'Bàn 4', NULL, NULL, NULL),
       (5, N'Bàn 5', NULL, NULL, NULL),
       (6, N'Bàn 6', NULL, NULL, NULL),
       (7, N'Bàn 7', NULL, NULL, NULL);

-- Dữ liệu mẫu cho bảng Hóa Đơn Bán
INSERT INTO HoaDonBan (MaHDB, NgayBan, TongTien, PhuongThucThanhToan, MaNV, MaKH, MaBan)
VALUES (1, '2025-10-10', 85000, N'Tiền mặt', 1, 1, 1),
       (2, '2025-10-10', 65000, N'Thẻ tín dụng', 2, 2, 2),
       (3, '2025-10-11', 120000, N'Tiền mặt', 3, 3, 3);

-- Dữ liệu mẫu cho bảng Chi Tiết HDB
INSERT INTO ChiTietHDB (MaSP, MaHDB, SoLuong, ThanhTien, KhuyenMai)
VALUES (1, 1, 2, 50000, 0), -- Cà phê đen x 2
       (2, 1, 1, 30000, 0), -- Cà phê sữa đá x 1
       (3, 2, 1, 35000, 0), -- Trà sữa x 1
       (4, 2, 1, 20000, 0), -- Bánh mì x 1
       (5, 3, 3, 75000, 0), -- Nước cam x 3
       (6, 3, 2, 36000, 0); -- Bánh ngọt x 2

-- Dữ liệu mẫu cho bảng Hóa Đơn Nhập
INSERT INTO HoaDonNhap (MaHDN, NgayNhap, TongTien, MaNV, MaNCC)
VALUES (1, '2025-10-09', 500000, 1, 1),
       (2, '2025-10-08', 300000, 2, 2);

-- Dữ liệu mẫu cho bảng Chi Tiết HDN
INSERT INTO ChiTietHDN (MaHDN, MaNL, SoLuong, ThanhTien, KhuyenMai)
VALUES (1, 1, 100, 250000, 0), -- Nguyên liệu 1
       (2, 2, 50, 50000, 0);    -- Nguyên liệu 2

--==============================


-- Select tất cả dữ liệu từ bảng Loai (Danh mục sản phẩm)
SELECT * FROM Loai;

-- Select tất cả dữ liệu từ bảng NhaCungCap (Nhà cung cấp)
SELECT * FROM NhaCungCap;

-- Select tất cả dữ liệu từ bảng NhanVien (Nhân viên)
SELECT * FROM NhanVien;

-- Select tất cả dữ liệu từ bảng NguyenLieu (Nguyên liệu)
SELECT * FROM NguyenLieu;

-- Select tất cả dữ liệu từ bảng SanPham (Sản phẩm)
SELECT * FROM SanPham;

-- Select tất cả dữ liệu từ bảng TaiKhoan (Tài khoản)
SELECT * FROM TaiKhoan;

-- Select tất cả dữ liệu từ bảng KhachHang (Khách hàng)
SELECT * FROM KhachHang;

-- Select tất cả dữ liệu từ bảng Ban (Bàn)
SELECT * FROM Ban;

-- Select tất cả dữ liệu từ bảng HoaDonBan (Hóa đơn bán)
SELECT * FROM HoaDonBan;

-- Select tất cả dữ liệu từ bảng ChiTietHDB (Chi tiết hóa đơn bán)
SELECT * FROM ChiTietHDB;

-- Select tất cả dữ liệu từ bảng HoaDonNhap (Hóa đơn nhập)
SELECT * FROM HoaDonNhap;

-- Select tất cả dữ liệu từ bảng ChiTietHDN (Chi tiết hóa đơn nhập)
SELECT * FROM ChiTietHDN;


--===================================================
--================================================
-- Dữ liệu mẫu cho bảng Nhà Cung Cấp
INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SDT)
VALUES (1, 'Công Ty ABC', '123 Đường ABC, Quận 1', '0123456789');

-- Dữ liệu mẫu cho bảng Nhân Viên
INSERT INTO NhanVien (MaNV, TenNV, DiaChi, GioiTinh, NgaySinh, SDT)
VALUES (1, 'Nguyễn Văn A', '456 Đường DEF, Quận 2', 'Nam', '1990-05-15', '0987654321');

-- Dữ liệu mẫu cho bảng Nguyên Liệu
INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, HanSuDung, DonGia)
VALUES (1, 'Gạo', 1000, '2025-12-31', 20.5);

-- Dữ liệu mẫu cho bảng Sản Phẩm
INSERT INTO SanPham (MaSP, TenSP, GiaBan, MoTa, MaLoai)
VALUES (1, 'Bánh mì', 15.5, 'Bánh mì tươi ngon', 1);

-- Dữ liệu mẫu cho bảng Loại
INSERT INTO Loai (MaLoai, TenLoai)
VALUES (1, 'Thực phẩm');

-- Dữ liệu mẫu cho bảng Tài Khoản
INSERT INTO TaiKhoan (MaTK, Ten, TenDangNhap, MatKhau, LoaiTaiKhoan)
VALUES (1, 'Nguyễn Văn A', 'admin', '123', 'Admin');

-- Dữ liệu mẫu cho bảng Khách Hàng
INSERT INTO KhachHang (MaKH, DiaChi, SDT, TenKH)
VALUES (1, '789 Đường GHI, Quận 3', '0912345678', 'Trần Thị B');

-- Dữ liệu mẫu cho bảng Bàn
INSERT INTO Ban (MaBan, TenBan, GioVao, GioRa, TrangThaiThanhToan)
VALUES (1, 'Bàn 1', '10:00', '12:00', 'Đã thanh toán');

-- Dữ liệu mẫu cho bảng Hóa Đơn Bán
INSERT INTO HoaDonBan (MaHDB, NgayBan, TongTien, PhuongThucThanhToan, MaNV, MaKH, MaBan)
VALUES (1, '2025-10-10', 100.0, 'Tiền mặt', 1, 1, 1);

-- Dữ liệu mẫu cho bảng Chi Tiết HDB
INSERT INTO ChiTietHDB (MaSP, MaHDB, SoLuong, ThanhTien, KhuyenMai)
VALUES (1, 1, 10, 155.0, 0.1);

-- Dữ liệu mẫu cho bảng Hóa Đơn Nhập
INSERT INTO HoaDonNhap (MaHDN, NgayNhap, TongTien, MaNV, MaNCC)
VALUES (1, '2025-10-09', 500.0, 1, 1);

-- Dữ liệu mẫu cho bảng Chi Tiết HDN
INSERT INTO ChiTietHDN (MaHDN, MaNL, SoLuong, ThanhTien, KhuyenMai)
VALUES (1, 1, 50, 1025.0, 0.05);





--=========================================================



-- Xóa bảng con (phụ thuộc) trước
DROP TABLE IF EXISTS ChiTietHDB;
DROP TABLE IF EXISTS HoaDonBan;
DROP TABLE IF EXISTS ChiTietHDN;
DROP TABLE IF EXISTS HoaDonNhap;

-- Xóa bảng trung gian / tham chiếu
DROP TABLE IF EXISTS SanPham;
DROP TABLE IF EXISTS Loai;
DROP TABLE IF EXISTS CongDung;

-- Xóa bảng danh mục / thông tin phụ
DROP TABLE IF EXISTS KhachHang;
DROP TABLE IF EXISTS NhanVien;
DROP TABLE IF EXISTS NhaCungCap;
DROP TABLE IF EXISTS Que;
DROP TABLE IF EXISTS TaiKhoan;
DROP TABLE IF EXISTS Ban;


CREATE DATABASE QLCafe;
use QLCafe

-- ======================
-- 1. BẢNG TÀI KHOẢN
-- ======================
CREATE TABLE TaiKhoan (
    MaTK CHAR(10) PRIMARY KEY,
    Ten NVARCHAR(100),
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(100),
    Type NVARCHAR(20) CHECK (Type IN ('Admin', 'NhanVien'))
);


-- ======================
-- 3. BẢNG NHÂN VIÊN
-- ======================
CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100),
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT CHAR(15),
    MaTK CHAR(10),
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);

-- ======================
-- 4. BẢNG NHÀ CUNG CẤP
-- ======================
CREATE TABLE NhaCungCap (
    MaNCC CHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT CHAR(15)
);

-- ======================
-- 5. BẢNG LOẠI
-- ======================
CREATE TABLE Loai (
    MaLoai CHAR(10) PRIMARY KEY,
    TenLoai NVARCHAR(100)
);



-- ======================
-- 7. BẢNG SẢN PHẨM
-- ======================
CREATE TABLE SanPham (
    MaSP CHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(100),
    GiaNhap DECIMAL(10,2),
    GiaBan DECIMAL(10,2),
    SoLuong INT,
    HinhAnh NVARCHAR(200),
    MaLoai CHAR(10),
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai)
);

-- ======================
-- 8. BẢNG HÓA ĐƠN NHẬP
-- ======================
CREATE TABLE HoaDonNhap (
    MaHDN CHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    TongTien DECIMAL(12,2),
    MaNV CHAR(10),
    MaNCC CHAR(10),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- ======================
-- 9. BẢNG CHI TIẾT HÓA ĐƠN NHẬP
-- ======================
CREATE TABLE ChiTietHDN (
    MaHDN CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    DonGia DECIMAL(10,2),
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(100),
    PRIMARY KEY (MaHDN, MaSP),
    FOREIGN KEY (MaHDN) REFERENCES HoaDonNhap(MaHDN),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ======================
-- 10. BẢNG KHÁCH HÀNG
-- ======================
CREATE TABLE KhachHang (
    MaKH CHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT CHAR(15)
);

-- ======================
-- 11. BẢNG BÀN
-- ======================
CREATE TABLE Ban (
    MaBan CHAR(10) PRIMARY KEY,
    TenBan NVARCHAR(50),
    TrangThai BIT CHECK (TrangThai IN (0, 1))
);


-- ======================
-- 12. BẢNG HÓA ĐƠN BÁN
-- ======================
CREATE TABLE HoaDonBan (
    MaHDB CHAR(10) PRIMARY KEY,
    NgayBan DATE,
    TongTien DECIMAL(12,2),
    PhuongThucThanhToan NVARCHAR(50),
    TrangThaiThanhToan NVARCHAR(30),
    MaNV CHAR(10),
    MaKH CHAR(10),
    MaBan CHAR(10),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
);

-- ======================
-- 13. BẢNG CHI TIẾT HÓA ĐƠN BÁN
-- ======================
CREATE TABLE ChiTietHDB (
    MaHDB CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(100),
    PRIMARY KEY (MaHDB, MaSP),
    FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);





-- Tài khoản
INSERT INTO TaiKhoan VALUES
('TK01', N'Nguyễn Văn A', 'admin', '123', 'Admin'),
('TK02', N'Lê Thị B', 'nvb', '123', 'NhanVien');

-- Nhân viên
INSERT INTO NhanVien VALUES
('NV01', N'Nguyễn Văn A', N'Hà Nội', N'Nam', '2000-02-15', '0912345678', 'Q01', 'TK01'),
('NV02', N'Lê Thị B', N'Đà Nẵng', N'Nữ', '1999-08-20', '0987654321', 'Q02', 'TK02');

-- Nhà cung cấp
INSERT INTO NhaCungCap VALUES
('NCC01', N'Công ty Vinacafe', N'Hà Nội', '0988123456'),
('NCC02', N'Công ty Trung Nguyên', N'Buôn Ma Thuột', '0978123456');

-- Loại
INSERT INTO Loai VALUES
('L01', N'Cà phê'),
('L02', N'Sinh tố'),
('L03', N'Trà sữa');

-- Công dụng
INSERT INTO CongDung VALUES
('CD01', N'Giúp tỉnh táo'),
('CD02', N'Cung cấp vitamin'),
('CD03', N'Giải khát');

-- Sản phẩm
INSERT INTO SanPham VALUES
('SP01', N'Cà phê sữa', 15000, 25000, 100, 'caphe_sua.jpg', 'CD01', 'L01'),
('SP02', N'Sinh tố xoài', 20000, 35000, 50, 'sinhto_xoai.jpg', 'CD02', 'L02'),
('SP03', N'Trà sữa trân châu', 18000, 30000, 70, 'trasua_tc.jpg', 'CD03', 'L03');

-- Bàn
INSERT INTO Ban VALUES
('B01', N'Bàn 1', 0),
('B02', N'Bàn 2', 1);

-- Khách hàng
INSERT INTO KhachHang VALUES
('KH01', N'Trần Minh Cường', N'Hà Nội', '0912345678'),
('KH02', N'Nguyễn Thị Lan', N'Hồ Chí Minh', '0988888888');

-- Hóa đơn nhập
INSERT INTO HoaDonNhap VALUES
('HDN01', '2025-10-01', 500000, 'NV01', 'NCC01'),
('HDN02', '2025-10-02', 350000, 'NV02', 'NCC02');

-- Chi tiết HDN
INSERT INTO ChiTietHDN VALUES
('HDN01', 'SP01', 20, 15000, 300000, N'Không'),
('HDN01', 'SP02', 10, 20000, 200000, N'Giảm 5%');

-- Hóa đơn bán
INSERT INTO HoaDonBan VALUES
('HDB01', '2025-10-03', 75000, N'Tiền mặt', N'Đã thanh toán', 'NV01', 'KH01', null),
('HDB02', '2025-10-04', 60000, N'Chuyển khoản', N'Đã thanh toán', 'NV02', 'KH02', 'B02');

-- Chi tiết HDB
INSERT INTO ChiTietHDB VALUES
('HDB01', 'SP01', 2, 50000, N'Không'),
('HDB01', 'SP02', 1, 25000, N'Giảm 10%'),
('HDB02', 'SP03', 2, 60000, N'Không');







--DB UPDATED

drop database QuanLyCafe

CREATE DATABASE QuanLyCafe;
GO
USE banhangluuniem;
GO

-- ======================
-- 1. BẢNG TÀI KHOẢN
-- ======================
CREATE TABLE TaiKhoan (
    MaTK CHAR(10) PRIMARY KEY,
    Ten NVARCHAR(100),
    Username NVARCHAR(50) UNIQUE,
    Password NVARCHAR(100),
    Type NVARCHAR(20) CHECK (Type IN ('Admin', 'NhanVien'))
);

-- ======================
-- 2. BẢNG QUÊ
-- ======================
CREATE TABLE Que (
    MaQue CHAR(10) PRIMARY KEY,
    TenQue NVARCHAR(100)
);

-- ======================
-- 3. BẢNG NHÂN VIÊN
-- ======================
CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100),
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT CHAR(15),
    MaQue CHAR(10),
    MaTK CHAR(10),
    FOREIGN KEY (MaQue) REFERENCES Que(MaQue),
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);

-- ======================
-- 4. BẢNG NHÀ CUNG CẤP
-- ======================
CREATE TABLE NhaCungCap (
    MaNCC CHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT CHAR(15)
);

-- ======================
-- 5. BẢNG LOẠI
-- ======================
CREATE TABLE Loai (
    MaLoai CHAR(10) PRIMARY KEY,
    TenLoai NVARCHAR(100)
);

-- ======================
-- 6. BẢNG CÔNG DỤNG
-- ======================
CREATE TABLE CongDung (
    MaCongDung CHAR(10) PRIMARY KEY,
    TenCongDung NVARCHAR(200)
);

-- ======================
-- 7. BẢNG SẢN PHẨM
-- ======================
CREATE TABLE SanPham (
    MaSP CHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(100),
    GiaNhap DECIMAL(10,2),
    GiaBan DECIMAL(10,2),
    SoLuong INT,
    HinhAnh NVARCHAR(200),
    MaCongDung CHAR(10),
    MaLoai CHAR(10),
    FOREIGN KEY (MaCongDung) REFERENCES CongDung(MaCongDung),
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai)
);

-- ======================
-- 8. BẢNG HÓA ĐƠN NHẬP
-- ======================
CREATE TABLE HoaDonNhap (
    MaHDN CHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    TongTien DECIMAL(12,2),
    MaNV CHAR(10),
    MaNCC CHAR(10),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- ======================
-- 9. BẢNG CHI TIẾT HÓA ĐƠN NHẬP
-- ======================
CREATE TABLE ChiTietHDN (
    MaHDN CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    DonGia DECIMAL(10,2),
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(100),
    PRIMARY KEY (MaHDN, MaSP),
    FOREIGN KEY (MaHDN) REFERENCES HoaDonNhap(MaHDN),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- ======================
-- 10. BẢNG KHÁCH HÀNG
-- ======================
CREATE TABLE KhachHang (
    MaKH CHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT CHAR(15)
);

-- ======================
-- 11. BẢNG BÀN
-- ======================
CREATE TABLE Ban (
    MaBan CHAR(10) PRIMARY KEY,
    TenBan NVARCHAR(50),
    TrangThai BIT CHECK (TrangThai IN (0, 1))
);



-- ======================
-- 12. BẢNG HÓA ĐƠN BÁN
-- ======================
CREATE TABLE HoaDonBan (
    MaHDB CHAR(10) PRIMARY KEY,
    NgayBan DATE,
    TongTien DECIMAL(12,2),
    PhuongThucThanhToan NVARCHAR(50),
    TrangThaiThanhToan NVARCHAR(30),
    MaNV CHAR(10),
    MaKH CHAR(10),
    MaBan CHAR(10),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
);

-- ======================
-- 13. BẢNG CHI TIẾT HÓA ĐƠN BÁN
-- ======================
CREATE TABLE ChiTietHDB (
    MaHDB CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(100),
    PRIMARY KEY (MaHDB, MaSP),
    FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);



INSERT INTO Que VALUES
('Q01', N'Hà Nội'),
('Q02', N'Đà Nẵng'),
('Q03', N'Hồ Chí Minh');

-- Tài khoản
INSERT INTO TaiKhoan VALUES
('TK01', N'Nguyễn Văn A', 'admin', '123', 'Admin'),
('TK02', N'Lê Thị B', 'nvb', '123', 'NhanVien');

-- Nhân viên
INSERT INTO NhanVien VALUES
('NV01', N'Nguyễn Văn A', N'Hà Nội', N'Nam', '2000-02-15', '0912345678', 'Q01', 'TK01'),
('NV02', N'Lê Thị B', N'Đà Nẵng', N'Nữ', '1999-08-20', '0987654321', 'Q02', 'TK02');

-- Nhà cung cấp
INSERT INTO NhaCungCap VALUES
('NCC01', N'Công ty Vinacafe', N'Hà Nội', '0988123456'),
('NCC02', N'Công ty Trung Nguyên', N'Buôn Ma Thuột', '0978123456');

-- Loại
INSERT INTO Loai VALUES
('L01', N'Cà phê'),
('L02', N'Sinh tố'),
('L03', N'Trà sữa');

-- Công dụng
INSERT INTO CongDung VALUES
('CD01', N'Giúp tỉnh táo'),
('CD02', N'Cung cấp vitamin'),
('CD03', N'Giải khát');

-- Sản phẩm
INSERT INTO SanPham VALUES
('SP01', N'Cà phê sữa', 15000, 25000, 100, 'caphe_sua.jpg', 'CD01', 'L01'),
('SP02', N'Sinh tố xoài', 20000, 35000, 50, 'sinhto_xoai.jpg', 'CD02', 'L02'),
('SP03', N'Trà sữa trân châu', 18000, 30000, 70, 'trasua_tc.jpg', 'CD03', 'L03');

-- Bàn
INSERT INTO Ban VALUES
('B01', N'Bàn 1', 0),
('B02', N'Bàn 2', 1);

-- Khách hàng
INSERT INTO KhachHang VALUES
('KH01', N'Trần Minh Cường', N'Hà Nội', '0912345678'),
('KH02', N'Nguyễn Thị Lan', N'Hồ Chí Minh', '0988888888');

-- Hóa đơn nhập
INSERT INTO HoaDonNhap VALUES
('HDN01', '2025-10-01', 500000, 'NV01', 'NCC01'),
('HDN02', '2025-10-02', 350000, 'NV02', 'NCC02');

-- Chi tiết HDN
INSERT INTO ChiTietHDN VALUES
('HDN01', 'SP01', 20, 15000, 300000, N'Không'),
('HDN01', 'SP02', 10, 20000, 200000, N'Giảm 5%');

-- Hóa đơn bán
INSERT INTO HoaDonBan VALUES
('HDB01', '2025-10-03', 75000, N'Tiền mặt', N'Đã thanh toán', 'NV01', 'KH01', null),
('HDB02', '2025-10-04', 60000, N'Chuyển khoản', N'Đã thanh toán', 'NV02', 'KH02', 'B02');

-- Chi tiết HDB
INSERT INTO ChiTietHDB VALUES
('HDB01', 'SP01', 2, 50000, N'Không'),
('HDB01', 'SP02', 1, 25000, N'Giảm 10%'),
('HDB02', 'SP03', 2, 60000, N'Không');



-- Nhà cung cấp
SELECT * FROM NhaCungCap;

-- Hóa đơn nhập
SELECT * FROM HoaDonNhap;

-- Chi tiết hóa đơn nhập
SELECT * FROM ChiTietHDN;

-- Loại sản phẩm
SELECT * FROM Loai;

-- Công dụng sản phẩm
SELECT * FROM CongDung;

-- Sản phẩm
SELECT * FROM SanPham;

-- Quê quán
SELECT * FROM Que;

-- Tài khoản
SELECT * FROM TaiKhoan;

-- Nhân viên
SELECT * FROM NhanVien;

-- Bàn
SELECT * FROM Ban;

-- Khách hàng
SELECT * FROM KhachHang;

-- Hóa đơn bán
SELECT * FROM HoaDonBan;

-- Chi tiết hóa đơn bán
SELECT * FROM ChiTietHDB;













--DB MAU CU CUA CO


-- Bảng Nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNCC CHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(100),
    DiaChi NVARCHAR(200),
    SDT CHAR(15)
);

-- Bảng Loại
CREATE TABLE Loai (
    MaLoai CHAR(10) PRIMARY KEY,
    TenLoai NVARCHAR(50)
);

-- Bảng Quê
CREATE TABLE Que (
    MaQue CHAR(10) PRIMARY KEY,
    TenQue NVARCHAR(50)
);

-- Bảng Công dụng
CREATE TABLE CongDung (
    MaCongDung CHAR(10) PRIMARY KEY,
    TenCongDung NVARCHAR(100)
);

-- Bảng Sản phẩm
CREATE TABLE SanPham (
    MaSP CHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(100),
    GiaNhap DECIMAL(10,2),
    GiaBan DECIMAL(10,2),
    SoLuong INT,
    MaLoai CHAR(10),
    MaCongDung CHAR(10),
    HinhAnh NVARCHAR(200),
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai),
    FOREIGN KEY (MaCongDung) REFERENCES CongDung(MaCongDung)
);

-- Bảng Khách hàng
CREATE TABLE KhachHang (
    MaKH CHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(100),
    DiaChi NVARCHAR(200)
);

-- Bảng Nhân viên
CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(100),
    DiaChi NVARCHAR(200),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    MaQue CHAR(10),
    SDT CHAR(15),
    FOREIGN KEY (MaQue) REFERENCES Que(MaQue)
);

-- Bảng Hóa đơn bán
CREATE TABLE HoaDonBan (
    MaHDB CHAR(10) PRIMARY KEY,
    NgayBan DATE,
    MaNV CHAR(10),
    MaKH CHAR(10),
    TongTien DECIMAL(12,2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

-- Bảng Chi tiết Hóa đơn bán
CREATE TABLE ChiTietHDB (
    MaHDB CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(50),
    PRIMARY KEY (MaHDB, MaSP),
    FOREIGN KEY (MaHDB) REFERENCES HoaDonBan(MaHDB),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);

-- Bảng Hóa đơn nhập
CREATE TABLE HoaDonNhap (
    MaHDN CHAR(10) PRIMARY KEY,
    NgayNhap DATE,
    MaNV CHAR(10),
    MaNCC CHAR(10),
    TongTien DECIMAL(12,2),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

-- Bảng Chi tiết Hóa đơn nhập
CREATE TABLE ChiTietHDN (
    MaHDN CHAR(10),
    MaSP CHAR(10),
    SoLuong INT,
    DonGia DECIMAL(10,2),
    ThanhTien DECIMAL(12,2),
    KhuyenMai NVARCHAR(50),
    PRIMARY KEY (MaHDN, MaSP),
    FOREIGN KEY (MaHDN) REFERENCES HoaDonNhap(MaHDN),
    FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP)
);


-- Dữ liệu bảng Quê
INSERT INTO Que VALUES
('Q01', N'Hà Nội'),
('Q02', N'Đà Nẵng'),
('Q03', N'Hồ Chí Minh');

-- Dữ liệu bảng Loại
INSERT INTO Loai VALUES
('L01', N'Cà phê'),
('L02', N'Sinh tố'),
('L03', N'Nước ép'),
('L04', N'Trà sữa');

-- Dữ liệu bảng Công dụng
INSERT INTO CongDung VALUES
('CD01', N'Giúp tỉnh táo'),
('CD02', N'Cung cấp vitamin'),
('CD03', N'Giải khát');

-- Dữ liệu bảng Nhà cung cấp
INSERT INTO NhaCungCap VALUES
('NCC01', N'Công ty Vinacafe', N'Hà Nội', '0988123456'),
('NCC02', N'Công ty Trung Nguyên', N'Buôn Ma Thuột', '0978123456');

-- Dữ liệu bảng Nhân viên
INSERT INTO NhanVien VALUES
('NV01', N'Nguyễn Văn A', N'Hà Nội', N'Nam', '2000-02-15', 'Q01', '0912345678'),
('NV02', N'Lê Thị B', N'Đà Nẵng', N'Nữ', '1999-08-20', 'Q02', '0987654321');

-- Dữ liệu bảng Khách hàng
INSERT INTO KhachHang VALUES
('KH01', N'Trần Minh Cường', N'Hà Nội'),
('KH02', N'Nguyễn Thị Lan', N'Hồ Chí Minh');

-- Dữ liệu bảng Sản phẩm
INSERT INTO SanPham VALUES
('SP01', N'Cà phê sữa', 15000, 25000, 100, 'L01', 'CD01', 'caphe_sua.jpg'),
('SP02', N'Sinh tố xoài', 20000, 35000, 50, 'L02', 'CD02', 'sinhto_xoai.jpg'),
('SP03', N'Trà sữa trân châu', 18000, 30000, 70, 'L04', 'CD03', 'trasua_tc.jpg');

-- Dữ liệu bảng Hóa đơn nhập
INSERT INTO HoaDonNhap VALUES
('HDN01', '2025-10-01', 'NV01', 'NCC01', 500000),
('HDN02', '2025-10-02', 'NV02', 'NCC02', 350000);

-- Dữ liệu bảng Chi tiết Hóa đơn nhập
INSERT INTO ChiTietHDN VALUES
('HDN01', 'SP01', 20, 15000, 300000, N'Không'),
('HDN01', 'SP02', 10, 20000, 200000, N'Giảm 5%');

-- Dữ liệu bảng Hóa đơn bán
INSERT INTO HoaDonBan VALUES
('HDB01', '2025-10-03', 'NV01', 'KH01', 75000),
('HDB02', '2025-10-04', 'NV02', 'KH02', 60000);

-- Dữ liệu bảng Chi tiết Hóa đơn bán
INSERT INTO ChiTietHDB VALUES
('HDB01', 'SP01', 2, 50000, N'Không'),
('HDB01', 'SP02', 1, 25000, N'Giảm 10%'),
('HDB02', 'SP03', 2, 60000, N'Không');


SELECT * FROM SanPham;
SELECT * FROM HoaDonBan;
SELECT * FROM ChiTietHDB;




