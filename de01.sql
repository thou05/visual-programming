CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE VatLieu (
    MaVL NVARCHAR(10) PRIMARY KEY,
    TenVatLieu NTEXT NOT NULL,
    DonViTinh NVARCHAR(8) NOT NULL,
    GiaNhap NVARCHAR(8) NOT NULL,
    GiaBan NVARCHAR(8) NOT NULL,
    SoLuong INT,
    Anh NTEXT NULL,
    GhiChu NTEXT
);

INSERT INTO VatLieu (MaVL, TenVatLieu, DonViTinh, GiaNhap, GiaBan, SoLuong, Anh, GhiChu)
VALUES 
('VL00001', N'Xi Măng', N'Bao', '99710', '144000', 130900, N'ximang.jpg', N'Xi măng'),
('VL00002', N'Cát', N'M3', '99940', '120000', 109000, N'cat.jpg', N'Cát'),
('VL00003', N'Gạch', N'Viên', '24200', '25000', 12730, N'gach.jpg', N'Gạch');

select * from VatLieu