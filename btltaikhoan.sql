use QLCafe

select * from TaiKhoan
select * from NhanVien


INSERT INTO [dbo].[TaiKhoan]
           ([MaTK]
           ,[Ten]
           ,[TenDangNhap]
           ,[MatKhau]
           ,[LoaiTaiKhoan])
     VALUES
           (1, 'Thảo', 'admin', 123, 0),
		   (2, 'Thảo thứ 2', 'staff', 123, 1)
          
GO
