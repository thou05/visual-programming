CREATE DATABASE BanHang;
GO

USE BanHang;
GO

CREATE TABLE tblMatHang (
    MaSP    NCHAR(5)       NOT NULL PRIMARY KEY,
    TenSP   NVARCHAR(30)   NOT NULL,
    NgaySX  DATE           NULL,
    NgayHH  DATE           NULL,
    DonVi   NVARCHAR(10)   NULL,
    DonGia  FLOAT          NULL,
    GhiChu  NVARCHAR(200)  NULL
);

INSERT INTO tblMatHang (MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
VALUES 
('SP001', N'Sữa Tươi', '2024-01-01', '2025-01-01', N'Hộp', 15000, N'Hàng mới'),
('SP002', N'Bánh Quy', '2024-03-15', '2025-03-15', N'Gói', 20000, NULL);

INSERT INTO tblMatHang (MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
VALUES
('SP012', N'Sữa Tươi Vinamilk', '2024-02-01', '2025-02-01', N'Hộp', 15000, N'Hàng mới về'),
('SP013', N'Bánh Oreo', '2024-01-15', '2025-01-15', N'Gói', 20000, N'Bán chạy'),
('SP003', N'Nước Ngọt Pepsi', '2024-03-10', '2025-03-10', N'Chai', 12000, NULL),
('SP004', N'Mì Hảo Hảo', '2024-04-05', '2025-04-05', N'Thùng', 95000, N'Hạn sử dụng dài'),
('SP005', N'Kẹo Dẻo Haribo', '2024-05-20', '2025-05-20', N'Gói', 30000, N'Hàng nhập khẩu');
