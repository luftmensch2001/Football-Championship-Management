CREATE DATABASE NFCM
GO

USE NFCM
GO

SET DATEFORMAT DMY
GO

------------------------------------------
CREATE TABLE PhanMem
(
	A INT,
	B INT,
	C INT,
	Language INT,
	X INT,
	Y INT,
	Z INT
)
GO


CREATE TABLE MuaGiai
(
	IDMG INT IDENTITY(1,1) PRIMARY KEY,
	TenMG NVARCHAR(50),
	Nam INT,
)
GO

ALTER TABLE MuaGiai
ADD MuaGiaiHienTai BIT
GO

CREATE TABLE QuyDinh
(
	IDMG INT,
	SLDB INT,
	SLVD INT,
	TuoiTT INT,
	TuoiTD INT
)
GO

ALTER TABLE QuyDinh
ADD SLTT INT
GO

ALTER TABLE QuyDinh
ADD SLTD INT
GO

ALTER TABLE QuyDinh
ADD CONSTRAINT DF_QD_SLTT DEFAULT(15) FOR SLTT
GO

ALTER TABLE QuyDinh
ADD CONSTRAINT DF_QD_SLTD DEFAULT(25) FOR SLTD
GO

ALTER TABLE QuyDinh
ADD CONSTRAINT DF_QD_TuoiTT DEFAULT(16) FOR TuoiTT
GO

ALTER TABLE QuyDinh
ADD CONSTRAINT DF_QD_TuoiTD DEFAULT(40) FOR TuoiTD
GO

CREATE TABLE LoaiCauThu
(
	IDLCT INT IDENTITY(1,1) PRIMARY KEY,
	TenLCT NVARCHAR(50),
	IDMG INT,
	SLTD INT,

	CONSTRAINT FK_LCT_IDMG FOREIGN KEY (IDMG) REFERENCES MuaGiai(IDMG)
)
GO

CREATE TABLE CauThu
(
	IDCT INT IDENTITY(1,1) PRIMARY KEY,
	IDLCT INT,
	Ten NVARCHAR(50),
	GioiTinh NVARCHAR(30),
	QuocTich NVARCHAR(50),
	NgaySinh SMALLDATETIME,
	GhiChu NVARCHAR(1000),

	CONSTRAINT FK_CT_IDLCT FOREIGN KEY (IDLCT) REFERENCES LoaiCauThu(IDLCT)
)
GO

<<<<<<< Updated upstream
ALTER TABLE CauThu
ADD IDDB INT
GO
=======

>>>>>>> Stashed changes

CREATE TABLE DSDoiBong
(
	IDDB INT IDENTITY(1,1) PRIMARY KEY,
	TenDB NVARCHAR(50)
)
GO

AlTER TABLE DSDoiBong
ADD TenHLV NVARCHAR(50)
GO

ALTER TABLE DSDoiBong
ADD SanNha NVARCHAR(50)
GO

<<<<<<< Updated upstream
=======
ALTER TABLE CauThu 
ADD IDDB INT
GO

ALTER TABLE CauThu 
ADD CONSTRAINT FK_CT_IDDB FOREIGN KEY(IDDB) REFERENCES DSDoiBong(IDDB)
GO

>>>>>>> Stashed changes
CREATE TABLE LichThiDau
(
	IDMG INT,
	IDTranDau INT IDENTITY(1,1) PRIMARY KEY,
	VongDau INT,
	Doi1 INT,
	Doi2 INT,
	Ngay SMALLDATETIME,
	GIO SMALLDATETIME,
	SanVanDong NVARCHAR(50),

	CONSTRAINT FK_LTD_IDMG FOREIGN KEY (IDMG) REFERENCES MuaGiai(IDMG),
	CONSTRAINT FK_LTD_Doi1 FOREIGN KEY (Doi1) REFERENCES DSDoiBong(IDDB),
	CONSTRAINT FK_LTD_Doi2 FOREIGN KEY (Doi2) REFERENCES DSDoiBong(IDDB)
)
GO

CREATE TABLE KetQuaThiDau
(
	IDTranDau INT,
	KQDoi1 INT,
	KQDoi2 INT,
	LuanLuu BIT,
	KQLL1 INT,
	KQLL2 INT,

	CONSTRAINT FK_KQTD_IDTranDau FOREIGN KEY (IDTranDau) REFERENCES LichThiDau(IDTranDau)
)
GO

CREATE TABLE LoaiBanThang
(
	IDLBT INT IDENTITY(1,1) PRIMARY KEY,
	TenLBT NVARCHAR(50),
)
GO

CREATE TABLE GhiBan
(
	IDTranDau INT,
	IDCT INT,
	IDDB INT,
	IDLBT INT,
	ThoiDiem VARCHAR(10),

	CONSTRAINT FK_GB_IDTranDau FOREIGN KEY (IDTranDau) REFERENCES LichThiDau(IDTranDau),
	CONSTRAINT FK_GB_IDCT FOREIGN KEY (IDCT) REFERENCES CauThu(IDCT),
	CONSTRAINT FK_GB_IDDB FOREIGN KEY (IDDB) REFERENCES DSDoiBong(IDDB),
	CONSTRAINT FK_GB_IDLBT FOREIGN KEY (IDLBT) REFERENCES LoaiBanThang(IDLBT)
)
GO

CREATE TABLE QuyDinhDiemSo
(
	THANG INT DEFAULT 3,
	HOA INT DEFAULT 1,
	THUA INT DEFAULT 0
)
GO

CREATE TABLE QuyDinhXepHang
(
	IDXH INT IDENTITY(1,1) PRIMARY KEY,
	Ten NVARCHAR(100),
	ThuTuUuTien INT
)
GO

