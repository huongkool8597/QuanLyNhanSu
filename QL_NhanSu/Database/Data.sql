﻿-- CREATE DATABASE
CREATE DATABASE TT_QLNV
GO
-- USE Database
USE TT_QLNV
GO

--------------------------------------------------------- Create Table ------------------------------------------------------
CREATE TABLE PHONGBAN(
	MAPB INT IDENTITY(1,1) NOT NULL,
	TENPB NVARCHAR(50),
	MATB INT,
	NGNHANCHUC DATE
)
GO
CREATE TABLE NHANVIEN(
	MANV INT IDENTITY(1,1) NOT NULL,
	HOTEN NVARCHAR(100),
	NGSINH DATE,
	DIACHI NVARCHAR(100),
	GIOITINH NVARCHAR(4),
	SDT CHAR(10),
	LUONG INT,
	MAPB INT 
)
GO
CREATE TABLE THANNHAN(
	MANV INT,
	HOTENTN NVARCHAR(100),
	GIOITINH NVARCHAR(4),
	NGSINH DATE,
	QUANHE NVARCHAR(10)
)
GO
CREATE TABLE TRALUONG(
	MANV INT,
	LUONG INT,
	NGNHAN DATE
)
GO
CREATE TABLE LAMTHEM(
	MANV INT,
	SOBUOI INT,
	TONGTIEN INT
)
GO
CREATE TABLE DUAN(
	MADA INT IDENTITY(1,1) NOT NULL,
	TENDA NVARCHAR(50),
	DIADIEM NVARCHAR(100),
	MAPB INT
)
GO
CREATE TABLE PHANCONG(
	MADA INT,
	MANV INT,
	SOGIO INT
)
GO
ALTER TABLE dbo.NHANVIEN ADD CONSTRAINT PK_MANV PRIMARY KEY(MANV)
ALTER TABLE dbo.PHONGBAN ADD CONSTRAINT PK_MAPB PRIMARY KEY(MAPB)
ALTER TABLE dbo.DUAN ADD CONSTRAINT PK_DUAN PRIMARY KEY(MADA)
ALTER TABLE dbo.NHANVIEN ADD CONSTRAINT FK_MANV_NV_PB FOREIGN KEY (MAPB) REFERENCES dbo.PHONGBAN (MAPB)
ALTER TABLE dbo.THANNHAN ADD CONSTRAINT FK_MANV_TN_NV FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN (MANV)
ALTER TABLE dbo.TRALUONG ADD CONSTRAINT FK_MANV_TL_NV FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN (MANV)
ALTER TABLE dbo.LAMTHEM ADD CONSTRAINT FK_MANV_LT_NV FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN (MANV)
ALTER TABLE dbo.PHANCONG ADD CONSTRAINT FK_MANV_PC_NV FOREIGN KEY (MANV) REFERENCES dbo.NHANVIEN (MANV)
ALTER TABLE dbo.PHANCONG ADD CONSTRAINT FK_MANV_PC_DA FOREIGN KEY (MADA) REFERENCES dbo.DUAN (MADA)
ALTER TABLE dbo.DUAN ADD CONSTRAINT FK_MAPB_DA_PB FOREIGN KEY (MAPB) REFERENCES dbo.PHONGBAN (MAPB)
GO

-----------------------------------------------------------------INSERT Dữ liệu------------------------------------------

-- 1. Phòng ban
INSERT dbo.NHANVIEN
        ( HOTEN, NGSINH, DIACHI, SDT, LUONG, MAPB , GIOITINH )
VALUES  ( N'Nguyễn Đức Hậu', -- HOTEN - nvarchar(100)
          '19980918', -- NGSINH - date
          N'Hà Nội', -- DIACHI - nvarchar(100)
          '0364086543', -- SDT - char(10)
          1000000, -- LUONG - int
          1,  -- MAPB - int
		  'Nam'
          )
		INSERT dbo.NHANVIEN
		          ( HOTEN ,
		            NGSINH ,
		            DIACHI ,
		            GIOITINH ,
		            SDT ,
		            LUONG ,
		            MAPB
		          )
		  VALUES  ( N'Ngô Thảo Ly' , -- HOTEN - nvarchar(100)
		            '19980906' , -- NGSINH - date
		            N'Hà Nội' , -- DIACHI - nvarchar(100)
		            N'Nữ' , -- GIOITINH - nvarchar(4)
		            '0348456324' , -- SDT - char(10)
		            1000000 , -- LUONG - int
		            1  -- MAPB - int
		          )

INSERT dbo.PHONGBAN
        ( TENPB, MATB, NGNHANCHUC )
VALUES  ( N'Phòng tài chính', -- TENPB - nvarchar(50)
          1, -- MATB - int
          GETDATE()  -- NGNHANCHUC - date
          )
INSERT dbo.PHONGBAN
        ( TENPB, MATB, NGNHANCHUC )
VALUES  ( N'Phòng nhân sự', -- TENPB - nvarchar(50)
          NULL, -- MATB - int
          GETDATE()  -- NGNHANCHUC - date
          )
UPDATE dbo.NHANVIEN SET GIOITINH = 'Nam'
GO
-------------------------------
CREATE PROC USP_GetDSNV AS SELECT MANV,HOTEN,NGSINH,DIACHI,GIOITINH,SDT,LUONG,NHANVIEN.MAPB,TENPB FROM dbo.NHANVIEN JOIN dbo.PHONGBAN ON PHONGBAN.MAPB = NHANVIEN.MAPB
EXEC USP_GetDSNV
GO
-------------------------------
CREATE PROC USP_InsertNv
	@hoten NVARCHAR(100),
	@ngsinh DATE,
	@diachi NVARCHAR(100),
	@gioitinh NVARCHAR(4),
	@sdt CHAR(10),
	@luong INT,
	@mapb INT 
AS
BEGIN
	INSERT dbo.NHANVIEN
	        ( HOTEN ,
	          NGSINH ,
	          DIACHI ,
	          GIOITINH ,
	          SDT ,
	          LUONG ,
	          MAPB
	        )
	VALUES  ( @hoten , -- HOTEN - nvarchar(100)
	          @ngsinh , -- NGSINH - date
	          @diachi , -- DIACHI - nvarchar(100)
	          @gioitinh , -- GIOITINH - nvarchar(4)
	          @sdt , -- SDT - char(10)
	          @luong , -- LUONG - int
	          @mapb  -- MAPB - int
	        )
END
GO
------------------------------
CREATE PROC USP_UpdateNV
	@manv INT,
	@hoten NVARCHAR(100),
	@ngsinh DATE,
	@diachi NVARCHAR(100),
	@gioitinh NVARCHAR(4),
	@sdt CHAR(10),
	@luong INT,
	@mapb INT
AS
BEGIN
	UPDATE dbo.NHANVIEN SET HOTEN=@hoten,NGSINH=@ngsinh,DIACHI=@diachi,GIOITINH=@gioitinh,SDT=@sdt,LUONG=@luong,MAPB=@mapb WHERE MANV=@manv
END
GO
-------------------------------
CREATE PROC USP_DeleteNv
@manv INT
AS
BEGIN
	DELETE dbo.NHANVIEN WHERE MANV=@manv
END
GO


CREATE PROC USP_SearchNv
@search NVARCHAR(100)
AS
BEGIN
	SELECT MANV,HOTEN,NGSINH,DIACHI,GIOITINH,SDT,LUONG,NHANVIEN.MAPB,TENPB FROM dbo.NHANVIEN, dbo.PHONGBAN 
	WHERE (PHONGBAN.MAPB = NHANVIEN.MAPB) AND  (MANV LIKE N'%' + @search + '%' OR HOTEN LIKE  N'%' + @search + '%' 
	OR  NGSINH LIKE  N'%' + @search + '%' OR  DIACHI LIKE  N'%' + @search + '%' OR GIOITINH LIKE  N'%' + @search + '%'
	OR SDT LIKE  N'%' + @search + '%' OR LUONG LIKE  N'%' + @search + '%' OR NHANVIEN.MAPB LIKE  N'%' + @search + '%'
	OR TENPB LIKE  N'%' + @search + '%')
END
\