use banhangluuniem

drop table tblChitietHDBan

create table tblChitietHDBan(
	MaHD NVARCHAR(10) NOT NULL,
    MaHang NVARCHAR(10) NOT NULL,
    SoLuong INT NOT NULL,
    GiamGia DECIMAL(5,2) DEFAULT 0,
    ThanhTien DECIMAL(18,2),

    CONSTRAINT PK_tblChiTietHD PRIMARY KEY (MaHD, MaHang),
    CONSTRAINT FK_tblChiTietHD_HoaDon FOREIGN KEY (MaHD) REFERENCES tblHDBan(MaHDBan),
    CONSTRAINT FK_tblChiTietHD_Hang FOREIGN KEY (MaHang) REFERENCES tblHang(MaHang)
);

INSERT INTO tblChitietHDBan (MaHD, MaHang, SoLuong, GiamGia, ThanhTien)
VALUES
('HD01', 'H001', 2, 10, null),  -- 180000
('HD01', 'H002',  1, 0, null),      -- 50000
('HD02', 'H003',  3, 5, null);    -- 285000