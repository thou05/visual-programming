DROP DATABASE QLCafe
GO

CREATE DATABASE QLCafe;
GO
USE QLCafe;
GO

-----------------------------------------------------
-- BẢNG DANH MỤC
-----------------------------------------------------

-- Loại sản phẩm
CREATE TABLE Loai (
    MaLoai INT PRIMARY KEY,
    TenLoai NVARCHAR(255)
);

-- Nhà cung cấp
CREATE TABLE NhaCungCap (
    MaNCC INT PRIMARY KEY,
    TenNCC NVARCHAR(255),
    DiaChi NVARCHAR(255),
    SDT VARCHAR(15)
);

-- Bảng tài khoản (đứng độc lập)
CREATE TABLE TaiKhoan (
    MaTK INT PRIMARY KEY,
    TenDangNhap VARCHAR(255) UNIQUE,
    MatKhau VARCHAR(255),
    LoaiTaiKhoan BIT -- Admin, Nhân viên
);

-- Bảng nhân viên (chứa khóa ngoại đến tài khoản)
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenNV NVARCHAR(200),
    DiaChi NVARCHAR(255),
    GioiTinh NVARCHAR(10),
    NgaySinh DATE,
    SDT VARCHAR(15),
    MaTK INT,
    FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
);


-- Khách hàng
CREATE TABLE KhachHang (
    MaKH INT PRIMARY KEY,
    TenKH NVARCHAR(255),
    SDT VARCHAR(15)
);

-- Nguyên liệu

CREATE TABLE NguyenLieu (
    MaNL INT PRIMARY KEY,
    TenNL NVARCHAR(255),
    SoLuong INT,
    DonViTinh NVARCHAR(50),
    DonGia DECIMAL(10, 2),
    HanSuDung DATE
);

-- Sản phẩm

CREATE TABLE SanPham (
    MaSP INT PRIMARY KEY,
    TenSP NVARCHAR(255),
    GiaBan DECIMAL(10, 2),
    Anh NTEXT NULL,
    MoTa NTEXT,
    MaLoai INT,
    FOREIGN KEY (MaLoai) REFERENCES Loai(MaLoai)
);


-----------------------------------------------------
-- BẢNG HÓA ĐƠN BÁN
-----------------------------------------------------

CREATE TABLE HoaDonBan (
    MaHDB INT PRIMARY KEY,
    NgayBan DATE,
    TongTien DECIMAL(10, 2),
    PhuongThucThanhToan NVARCHAR(50),
    MaNV INT,
    MaKH INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH)
);

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

-----------------------------------------------------
-- BẢNG HÓA ĐƠN NHẬP
-----------------------------------------------------

CREATE TABLE HoaDonNhap (
    MaHDN INT PRIMARY KEY,
    NgayNhap DATE,
    TongTien DECIMAL(10, 2),
    MaNV INT,
    MaNCC INT,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES NhaCungCap(MaNCC)
);

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


-- Loại sản phẩm
INSERT INTO Loai VALUES
(1, N'Cà phê'),
(2, N'Trà'),
(3, N'Matcha'),
(4, N'Bánh ngọt'),
(5, N'Bánh mặn');

-- Nhà cung cấp
INSERT INTO NhaCungCap VALUES
(1, N'Công ty TNHH Coffee Bean', N'45 Lê Lợi, Q.1, TP.HCM', '0909123456'),
(2, N'Công ty TNHH Trà Việt', N'78 Nguyễn Huệ, Q.1, TP.HCM', '0912233445'),
(3, N'Nhà phân phối ABC Foods', N'12 Hai Bà Trưng, Hà Nội', '0933445566'),
(4, N'Công ty Cacao Đắk Lắk', N'89 Nguyễn Văn Cừ, Đắk Lắk', '0977888999'),
(5, N'Công ty Nguyên liệu Miền Bắc', N'102 Kim Mã, Hà Nội', '0988556677');

-- Tài khoản
INSERT INTO TaiKhoan VALUES
(1, 'admin', '123', 0),
(2, 'lethao', '123', 0),
(3, 'staff', '123', 1),
(4, 'linhtm', '123', 1),
(5, 'minhquan', '123', 1),
(6, 'anhduong', '123', 1);

-- Nhân viên
INSERT INTO NhanVien VALUES
(1, N'Quản lý', N'Hà Nội', N'Nữ', '2002-05-20', '0905123456', 1),
(2, N'Lê Thị Thảo', N'15 Kim Liên, Hà Nội', N'Nữ', '2001-12-25', '0902678901', 2),
(3, N'Nguyễn Văn Hùng', N'56 Bạch Mai, Hà Nội', N'Nam', '1998-11-11', '0906234567', 3),
(4, N'Trần Mỹ Linh', N'23 Phan Chu Trinh, Hà Nội', N'Nữ', '2000-08-08', '0907345678', 4),
(5, N'Phạm Minh Quân', N'89 Hoàng Hoa Thám, Hà Nội', N'Nam', '1997-09-19', '0918456789', 5),
(6, N'Lý Anh Dương', N'32 Nguyễn Du, Hà Nội', N'Nam', '1999-03-15', '0939567890', 6);


-- Khách hàng (20 người)
INSERT INTO KhachHang VALUES
(1, N'Phạm Đức Anh', '0911223344'),
(2, N'Vũ Thị Hoa', '0912334455'),
(3, N'Lê Minh Tuấn', '0913445566'),
(4, N'Trần Ngọc Lan', '0914556677'),
(5, N'Nguyễn Văn Bình', '0915667788'),
(6, N'Đặng Thị Mai', '0916778899'),
(7, N'Lưu Hữu Nam', '0917889900'),
(8, N'Phạm Hồng Nhung', '0918990011'),
(9, N'Trần Văn Tùng', '0919001122'),
(10, N'Vũ Thị Thảo', '0910112233'),
(11, N'Nguyễn Hải Anh', '0911223345'),
(12, N'Lý Văn Sơn', '0912334456'),
(13, N'Bùi Thị Hằng', '0913445567'),
(14, N'Phan Quốc Dũng', '0914556678'),
(15, N'Đoàn Thị Phương', '0915667789'),
(16, N'Tạ Văn Nam', '0916778890'),
(17, N'Hồ Minh Tâm', '0917889901'),
(18, N'Vũ Ngọc Tú', '0918990012'),
(19, N'Lê Trọng Nghĩa', '0919001123'),
(20, N'Nguyễn Hồng Hạnh', '0910112234');

-- Nguyên liệu (10)

INSERT INTO NguyenLieu (MaNL, TenNL, SoLuong, DonViTinh, DonGia, HanSuDung) VALUES
(1, N'Hạt cà phê Arabica', 50, N'kg', 150000, '2026-01-31'),
(2, N'Hạt cà phê Robusta', 50, N'kg', 120000, '2026-03-15'),
(3, N'Sữa đặc', 30, N'hộp', 25000, '2025-09-30'),
(4, N'Sữa tươi', 40, N'lít', 20000, '2025-12-31'),
(5, N'Lá trà xanh', 10, N'kg', 80000, '2025-08-15'),
(6, N'Bột cacao', 20, N'kg', 120000, '2025-07-01'),
(7, N'Siro dâu', 10, N'lít', 60000, '2026-01-01'),
(8, N'Đường trắng', 50, N'kg', 15000, '2026-06-01'),
(9, N'Trái cây tươi', 60, N'kg', 40000, '2025-11-15'),
(10, N'Bột bánh', 20, N'kg', 50000, '2026-04-30');

-- Sản phẩm (15)
INSERT INTO SanPham VALUES
(1,  N'Cà phê đen đá',        25000, N'cf_den_da.png',       N'Cà phê nguyên chất pha phin truyền thống', 1),
(2,  N'Cà phê sữa đá',        30000, N'cf_sua_da.png',       N'Cà phê đen với sữa đặc béo ngậy', 1),
(3,  N'Bạc xỉu nóng',         40000, N'bac_xiu_nong.png',    N'chút vị đắng của cà phê kết hợp vị ngọt béo ngậy từ sữa.', 1),

(4,  N'Trà đào cam sả',       40000, N'tra_dao_cam_sa.png',  N'Trà đào tươi với cam và sả thơm', 2),
(5,  N'Trà Sữa Oolong Nướng',    35000, N'tra_sua_oolong.png',      N'Oolong nướng đậm đà quyện cùng sữa thơm béo', 2),

(6,  N'Matcha Latte Tây Bắc',           45000, N'matcha_latte_tay_bac.png',      N'rất phù hợp cho ai muốn nhập môn matcha', 3),
(7,  N'Matcha Latte',          30000, N'matcha-latte.png',     N'Matcha Nhật Bản hảo hạng kết hợp sữa tươi mịn màng, cân bằng vị umami thanh nhẹ và độ béo dịu', 3),
(8,  N'Matcha Tây Bắc Trân Châu Hoàng Kim',      35000, N'matcha-tran-chau.png', N'Matcha kết hợp đường đen Okinawa, sữa béo nhẹ và trân châu hoàng kim mềm dẻo', 3),

(9,  N'Bánh tiramisu',        55000, N'tiramisu.png',   N'Bánh mềm, vị cà phê và cacao', 4),
(10, N'Mochi Kem Chocolate',          25000, N'mochi-choco.png',     N'Bao bọc bởi lớp vỏ Mochi dẻo thơm, bên trong là lớp kem lạnh cùng nhân chocolate độc đáo', 4),
(11, N'Mousse Gấu Chocolate',39000, N'mouse-gau-choco.png', N'hương vị ngọt ngào, thơm béo', 4),

(12, N'Bánh Mì Que Chà Bông Phô Mai Bơ Cay',      30000, N'bmq-cha-bong-pm.png', N'Chà bông tơi mịn đẫm phô mai Mozzarella kéo sợi, cay hít hà. ', 5),
(13, N'Croissant trứng muối',       25000, N'croissant-trung-muoi.png',  N'Croissant trứng muối thơm lừng, bên ngoài vỏ bánh giòn bên trong trứng muối.', 5),
(14, N'Pizza Pepperoni',          35000, N'pizza_pepperoni.png',     N'', 5),
(15, N'Pasta Bò Bằm Xốt Bolognese',         40000, N'bo_bam_xot_bolognese.png',    N'', 5);


-----------------------------------------------------
-- HÓA ĐƠN NHẬP (15 cái)
-----------------------------------------------------


INSERT INTO HoaDonNhap VALUES
(1,'2025-01-10',350000,1,1),
(2,'2025-02-05',400000,2,2),
(3,'2025-03-15',350000,3,3),
(4,'2025-04-12',280000,4,4),
(5,'2025-05-20',450000,5,5),
(6,'2025-06-05',300000,6,1),
(7,'2025-07-18',350000,1,2),
(8,'2025-08-10',420000,2,3),
(9,'2025-09-25',360000,3,4),
(10,'2025-10-05',290000,4,5),
(11,'2025-10-15',310000,5,1),
(12,'2025-10-30',380000,6,2),
(13,'2025-11-01',330000,1,3),
(14,'2025-11-02',340000,2,4),
(15,'2025-11-02',370000,3,5);


INSERT INTO ChiTietHDN VALUES
(1,1,10,25000,0),(1,2,5,80000,0),(1,8,10,30000,0),
(2,3,10,70000,0),(2,5,8,90000,0),
(3,6,6,85000,0),(3,7,10,95000,0),
(4,9,8,70000,0),(4,10,5,40000,0),
(5,4,10,42000,0),(6,8,12,45000,0),
(7,2,8,12000,0),(8,1,5,10000,0),(9,3,6,40000,0),
(10,5,5,60000,0),(11,6,4,90000,0),
(12,7,6,95000,0),(13,8,10,55000,0),
(14,9,8,90000,0),(15,10,6,95000,0);


-----------------------------------------------------
-- HÓA ĐƠN BÁN (50 cái)
-----------------------------------------------------
INSERT INTO HoaDonBan VALUES
(1,'2025-01-03',90000,N'Tiền mặt',1,1),
(2,'2025-01-06',120000,N'Thẻ tín dụng',2,2),
(3,'2025-01-10',145000,N'Chuyển khoản',3,3),
(4,'2025-01-15',85000,N'Thẻ ngân hàng',4,4),
(5,'2025-01-20',155000,N'Tiền mặt',5,5),
(6,'2025-01-25',130000,N'Tiền mặt',6,6),
(7,'2025-02-01',160000,N'Thẻ tín dụng',1,7),
(8,'2025-02-05',100000,N'Tiền mặt',2,8),
(9,'2025-02-10',95000,N'Thẻ ngân hàng',3,9),
(10,'2025-02-15',125000,N'Chuyển khoản',4,10),
(11,'2025-02-20',145000,N'Tiền mặt',5,11),
(12,'2025-03-01',95000,N'Thẻ tín dụng',6,12),
(13,'2025-03-05',155000,N'Tiền mặt',1,13),
(14,'2025-03-10',125000,N'Thẻ ngân hàng',2,14),
(15,'2025-03-15',165000,N'Tiền mặt',3,15),
(16,'2025-03-20',95000,N'Tiền mặt',4,16),
(17,'2025-03-25',145000,N'Thẻ tín dụng',5,17),
(18,'2025-04-01',125000,N'Tiền mặt',6,18),
(19,'2025-04-05',155000,N'Chuyển khoản',1,19),
(20,'2025-04-10',115000,N'Thẻ ngân hàng',2,20),
(21,'2025-04-15',165000,N'Tiền mặt',3,1),
(22,'2025-04-20',90000,N'Thẻ tín dụng',4,2),
(23,'2025-05-01',110000,N'Tiền mặt',5,3),
(24,'2025-05-05',135000,N'Tiền mặt',6,4),
(25,'2025-05-10',145000,N'Thẻ tín dụng',1,5),
(26,'2025-05-15',95000,N'Tiền mặt',2,6),
(27,'2025-06-01',125000,N'Tiền mặt',3,7),
(28,'2025-06-05',150000,N'Thẻ ngân hàng',4,8),
(29,'2025-06-10',155000,N'Chuyển khoản',5,9),
(30,'2025-06-15',135000,N'Tiền mặt',6,10),
(31,'2025-07-01',95000,N'Thẻ tín dụng',1,11),
(32,'2025-07-05',130000,N'Tiền mặt',2,12),
(33,'2025-07-10',145000,N'Tiền mặt',3,13),
(34,'2025-07-15',120000,N'Thẻ ngân hàng',4,14),
(35,'2025-07-20',175000,N'Tiền mặt',5,15),
(36,'2025-08-01',160000,N'Thẻ tín dụng',6,16),
(37,'2025-08-05',125000,N'Tiền mặt',1,17),
(38,'2025-08-10',150000,N'Chuyển khoản',2,18),
(39,'2025-08-15',140000,N'Tiền mặt',3,19),
(40,'2025-08-20',95000,N'Thẻ tín dụng',4,20),
(41,'2025-09-01',135000,N'Tiền mặt',5,1),
(42,'2025-09-05',145000,N'Thẻ tín dụng',6,2),
(43,'2025-09-10',95000,N'Tiền mặt',1,3),
(44,'2025-09-15',125000,N'Tiền mặt',2,4),
(45,'2025-10-01',165000,N'Tiền mặt',3,5),
(46,'2025-10-05',115000,N'Thẻ ngân hàng',4,6),
(47,'2025-10-10',140000,N'Tiền mặt',5,7),
(48,'2025-10-20',155000,N'Tiền mặt',6,8),
(49,'2025-10-25',135000,N'Thẻ tín dụng',1,9),
(50,'2025-11-02',95000,N'Tiền mặt',2,10);



-----------------------------------------------------
-- CHI TIẾT HÓA ĐƠN BÁN (khớp 50 hóa đơn)
-----------------------------------------------------
INSERT INTO ChiTietHDB VALUES
(1,1,2,50000,0),(2,1,1,40000,0),
(3,2,2,80000,0),(5,2,1,40000,0),
(4,3,2,90000,0),(6,3,1,55000,0),
(5,4,1,45000,0),(1,4,1,40000,0),
(7,5,2,90000,0),(8,5,2,65000,0),
(9,6,2,80000,0),(2,6,1,50000,0),
(10,7,2,100000,0),(11,7,1,60000,0),
(12,8,2,60000,0),(13,8,1,40000,0),
(14,9,2,60000,0),(15,9,1,35000,0),
(1,10,2,50000,0),(2,10,1,75000,0),
(3,11,2,90000,0),(5,11,1,55000,0),
(4,12,2,65000,0),(6,12,1,30000,0),
(7,13,3,90000,0),(8,13,1,65000,0),
(9,14,1,55000,0),(10,14,1,70000,0),
(11,15,2,90000,0),(12,15,1,75000,0),
(13,16,2,60000,0),(14,16,1,35000,0),
(15,17,2,95000,0),(1,17,1,50000,0),
(2,18,2,80000,0),(3,18,1,45000,0),
(4,19,2,90000,0),(5,19,1,65000,0),
(6,20,2,65000,0),(7,20,1,50000,0),
(8,21,3,100000,0),(9,21,1,65000,0),
(10,22,1,50000,0),(11,22,1,40000,0),
(12,23,2,70000,0),(13,23,1,40000,0),
(14,24,2,90000,0),(15,24,1,45000,0),
(1,25,2,90000,0),(2,25,1,55000,0),
(3,26,2,70000,0),(4,26,1,25000,0),
(5,27,3,95000,0),(6,27,1,30000,0),
(7,28,2,95000,0),(8,28,1,55000,0),
(9,29,2,90000,0),(10,29,1,65000,0),
(11,30,2,70000,0),(12,30,1,65000,0),
(13,31,2,50000,0),(14,31,1,45000,0),
(15,32,2,90000,0),(1,32,1,40000,0),
(2,33,2,90000,0),(3,33,1,55000,0),
(4,34,2,70000,0),(5,34,1,50000,0),
(6,35,2,95000,0),(7,35,2,80000,0),
(8,36,2,90000,0),(9,36,1,70000,0),
(10,37,2,75000,0),(11,37,1,50000,0),
(12,38,2,100000,0),(13,38,1,50000,0),
(14,39,2,80000,0),(15,39,1,60000,0),
(1,40,2,60000,0),(2,40,1,35000,0),
(3,41,2,90000,0),(4,41,1,45000,0),
(5,42,2,90000,0),(6,42,1,55000,0),
(7,43,2,60000,0),(8,43,1,35000,0),
(9,44,2,75000,0),(10,44,1,50000,0),
(11,45,3,95000,0),(12,45,1,70000,0),
(13,46,2,60000,0),(14,46,1,55000,0),
(15,47,2,95000,0),(1,47,1,45000,0),
(2,48,2,95000,0),(3,48,1,60000,0),
(4,49,2,90000,0),(5,49,1,45000,0),
(6,50,2,65000,0),(7,50,1,30000,0);



-----------------------------------------------------
-- KIỂM TRA DỮ LIỆU
-----------------------------------------------------
SELECT * FROM Loai;
SELECT * FROM SanPham;
SELECT * FROM TaiKhoan;
SELECT * FROM NhanVien;
SELECT * FROM KhachHang;
SELECT * FROM HoaDonBan;
SELECT * FROM ChiTietHDB;
SELECT * FROM HoaDonNhap;
SELECT * FROM ChiTietHDN;
select * from NguyenLieu