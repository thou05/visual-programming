
--drop database QLCafe

CREATE DATABASE QLCafe;
GO
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



select * from Loai