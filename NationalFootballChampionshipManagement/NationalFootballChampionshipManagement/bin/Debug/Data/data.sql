USE [master]
GO
/****** Object:  Database [NFCM]    Script Date: 27/06/2021 14:33:30 PM ******/
CREATE DATABASE [NFCM]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'NFCM', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NFCM.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'NFCM_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\NFCM_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [NFCM] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [NFCM].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [NFCM] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [NFCM] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [NFCM] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [NFCM] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [NFCM] SET ARITHABORT OFF 
GO
ALTER DATABASE [NFCM] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [NFCM] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [NFCM] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [NFCM] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [NFCM] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [NFCM] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [NFCM] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [NFCM] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [NFCM] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [NFCM] SET  ENABLE_BROKER 
GO
ALTER DATABASE [NFCM] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [NFCM] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [NFCM] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [NFCM] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [NFCM] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [NFCM] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [NFCM] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [NFCM] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [NFCM] SET  MULTI_USER 
GO
ALTER DATABASE [NFCM] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [NFCM] SET DB_CHAINING OFF 
GO
ALTER DATABASE [NFCM] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [NFCM] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [NFCM] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [NFCM] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [NFCM] SET QUERY_STORE = OFF
GO
USE [NFCM]
GO
/****** Object:  Table [dbo].[BanThang]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BanThang](
	[IDTranDau] [int] NULL,
	[IDCT] [int] NULL,
	[IDDB] [int] NULL,
	[IDLBT] [int] NULL,
	[ThoiDiem] [varchar](10) NULL,
	[IDBT] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CauThu]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauThu](
	[IDCT] [int] IDENTITY(1,1) NOT NULL,
	[IDLCT] [int] NULL,
	[Ten] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](30) NULL,
	[QuocTich] [nvarchar](50) NULL,
	[NgaySinh] [smalldatetime] NULL,
	[GhiChu] [nvarchar](1000) NULL,
	[IDDB] [int] NULL,
	[TONGBANTHANG] [int] NULL,
	[HinhAnh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoiBong]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiBong](
	[IDDB] [int] IDENTITY(1,1) NOT NULL,
	[TenDB] [nvarchar](50) NULL,
	[TenHLV] [nvarchar](50) NULL,
	[SanNha] [nvarchar](50) NULL,
	[IDMG] [int] NULL,
	[HinhAnh] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KetQuaThiDau]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KetQuaThiDau](
	[IDTranDau] [int] NULL,
	[KQDoi1] [int] NULL,
	[KQDoi2] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiBanThang]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiBanThang](
	[IDLBT] [int] IDENTITY(1,1) NOT NULL,
	[TenLBT] [nvarchar](50) NULL,
	[IDMG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLBT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiCauThu]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiCauThu](
	[IDLCT] [int] IDENTITY(1,1) NOT NULL,
	[TenLCT] [nvarchar](50) NULL,
	[IDMG] [int] NULL,
	[SLTD] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDLCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuaGiai]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuaGiai](
	[IDMG] [int] IDENTITY(1,1) NOT NULL,
	[TenMG] [nvarchar](50) NULL,
	[Nam] [int] NULL,
	[MuaGiaiHienTai] [bit] NULL,
	[Logo] [image] NULL,
	[TrangThai] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDMG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinh]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinh](
	[IDMG] [int] NULL,
	[SLDB] [int] NULL,
	[TuoiTT] [int] NULL,
	[TuoiTD] [int] NULL,
	[SLTT] [int] NULL,
	[SLTD] [int] NULL,
	[TGGBTD] [varchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinhDiemSo]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhDiemSo](
	[THANG] [int] NULL,
	[HOA] [int] NULL,
	[THUA] [int] NULL,
	[IDMG] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyDinhXepHang]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyDinhXepHang](
	[IDXH] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[ThuTuUuTien] [int] NULL,
	[IDMG] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDXH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TranDau]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TranDau](
	[IDMG] [int] NULL,
	[IDTranDau] [int] IDENTITY(1,1) NOT NULL,
	[VongDau] [int] NULL,
	[Doi1] [int] NULL,
	[Doi2] [int] NULL,
	[ThoiGian] [smalldatetime] NULL,
	[SanVanDong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTranDau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CauThu] ADD  DEFAULT ((0)) FOR [TONGBANTHANG]
GO
ALTER TABLE [dbo].[KetQuaThiDau] ADD  CONSTRAINT [DF_KQDOI1]  DEFAULT ((-1)) FOR [KQDoi1]
GO
ALTER TABLE [dbo].[KetQuaThiDau] ADD  CONSTRAINT [DF_KQDOI2]  DEFAULT ((-1)) FOR [KQDoi2]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_SLDB]  DEFAULT ((16)) FOR [SLDB]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_TuoiTT]  DEFAULT ((16)) FOR [TuoiTT]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_TuoiTD]  DEFAULT ((40)) FOR [TuoiTD]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_SLTT]  DEFAULT ((15)) FOR [SLTT]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_SLTD]  DEFAULT ((25)) FOR [SLTD]
GO
ALTER TABLE [dbo].[QuyDinh] ADD  CONSTRAINT [DF_QD_TGGBTD]  DEFAULT ('90') FOR [TGGBTD]
GO
ALTER TABLE [dbo].[QuyDinhDiemSo] ADD  DEFAULT ((3)) FOR [THANG]
GO
ALTER TABLE [dbo].[QuyDinhDiemSo] ADD  DEFAULT ((1)) FOR [HOA]
GO
ALTER TABLE [dbo].[QuyDinhDiemSo] ADD  DEFAULT ((0)) FOR [THUA]
GO
ALTER TABLE [dbo].[TranDau] ADD  DEFAULT (getdate()) FOR [ThoiGian]
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_GB_IDCT] FOREIGN KEY([IDCT])
REFERENCES [dbo].[CauThu] ([IDCT])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_GB_IDCT]
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_GB_IDDB] FOREIGN KEY([IDDB])
REFERENCES [dbo].[DoiBong] ([IDDB])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_GB_IDDB]
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_GB_IDLBT] FOREIGN KEY([IDLBT])
REFERENCES [dbo].[LoaiBanThang] ([IDLBT])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_GB_IDLBT]
GO
ALTER TABLE [dbo].[BanThang]  WITH CHECK ADD  CONSTRAINT [FK_GB_IDTranDau] FOREIGN KEY([IDTranDau])
REFERENCES [dbo].[TranDau] ([IDTranDau])
GO
ALTER TABLE [dbo].[BanThang] CHECK CONSTRAINT [FK_GB_IDTranDau]
GO
ALTER TABLE [dbo].[CauThu]  WITH CHECK ADD  CONSTRAINT [FK_CT_IDDB] FOREIGN KEY([IDDB])
REFERENCES [dbo].[DoiBong] ([IDDB])
GO
ALTER TABLE [dbo].[CauThu] CHECK CONSTRAINT [FK_CT_IDDB]
GO
ALTER TABLE [dbo].[CauThu]  WITH CHECK ADD  CONSTRAINT [FK_CT_IDLCT] FOREIGN KEY([IDLCT])
REFERENCES [dbo].[LoaiCauThu] ([IDLCT])
GO
ALTER TABLE [dbo].[CauThu] CHECK CONSTRAINT [FK_CT_IDLCT]
GO
ALTER TABLE [dbo].[KetQuaThiDau]  WITH CHECK ADD  CONSTRAINT [FK_KQTD_IDTranDau] FOREIGN KEY([IDTranDau])
REFERENCES [dbo].[TranDau] ([IDTranDau])
GO
ALTER TABLE [dbo].[KetQuaThiDau] CHECK CONSTRAINT [FK_KQTD_IDTranDau]
GO
ALTER TABLE [dbo].[LoaiCauThu]  WITH CHECK ADD  CONSTRAINT [FK_LCT_IDMG] FOREIGN KEY([IDMG])
REFERENCES [dbo].[MuaGiai] ([IDMG])
GO
ALTER TABLE [dbo].[LoaiCauThu] CHECK CONSTRAINT [FK_LCT_IDMG]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_LTD_Doi1] FOREIGN KEY([Doi1])
REFERENCES [dbo].[DoiBong] ([IDDB])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_LTD_Doi1]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_LTD_Doi2] FOREIGN KEY([Doi2])
REFERENCES [dbo].[DoiBong] ([IDDB])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_LTD_Doi2]
GO
ALTER TABLE [dbo].[TranDau]  WITH CHECK ADD  CONSTRAINT [FK_LTD_IDMG] FOREIGN KEY([IDMG])
REFERENCES [dbo].[MuaGiai] ([IDMG])
GO
ALTER TABLE [dbo].[TranDau] CHECK CONSTRAINT [FK_LTD_IDMG]
GO
/****** Object:  StoredProcedure [dbo].[USP_ChangeTeamInforByIDDB]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Change Team Information by IDDB

CREATE PROC [dbo].[USP_ChangeTeamInforByIDDB]
@iddb INT,
@name NVARCHAR(50),
@coach NVARCHAR(50),
@host NVARCHAR(50)
AS
BEGIN
	UPDATE DoiBong
	SET TenDB = @name,
		TenHLV = @coach,
		SanNha = @host
	WHERE IDDB = @iddb
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CountOfPlayer]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Count of Player By IDDB

CREATE PROC [dbo].[USP_CountOfPlayer]
@iddb INT
AS
BEGIN
	SELECT COUNT(IDCT) AS SL 
	FROM CauThu
	WHERE IDDB = @iddb
END
GO
/****** Object:  StoredProcedure [dbo].[USP_CountOfTeam]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Count of Team By IDMG

CREATE PROC [dbo].[USP_CountOfTeam]
@idmg INT
AS
BEGIN
	SELECT COUNT(IDDB) AS SL 
	FROM DoiBong
	WHERE IDMG = @idmg
END
GO
/****** Object:  StoredProcedure [dbo].[USP_DELETEGOAL]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_DELETEGOAL]
@IDBANTHANG INT
AS
BEGIN
	DELETE BANTHANG
	WHERE IDBT = @IDBANTHANG
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAllMatches]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Get All Matches

CREATE PROC [dbo].[USP_GetAllMatches] 
@idmg INT
AS
BEGIN
	SELECT 
		IDTranDau as [Số thứ tự],
		VongDau as [Vòng đấu],
		Doi1 as [ID1],
		Doi2 as [ID2],
		SanVanDong as [Đội 1],
		SanVanDong as [Đội 2],
		SanVanDong as [Sân vận động],
		CONVERT(VARCHAR(10),  ThoiGian, 103) AS [Ngày],
		CONVERT(VARCHAR(5),  ThoiGian, 108) AS [Giờ]
	FROM TranDau
	WHERE IDMG = @idmg
	ORDER BY ThoiGian
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetCountPlayerByIDLCT]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Get count of players have idlct in team, except this idct   
CREATE PROC [dbo].[USP_GetCountPlayerByIDLCT] 
@idLCT INT,
@idDB INT,
@idCT INT
AS
BEGIN
	SELECT COUNT(IDCT) AS SL
	FROM CauThu
	WHERE IDLCT = @idLCT AND IDCT <> @idCT AND IDDB = @idDB
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetListIdAndNamePlayerByIDDB]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetListIdAndNamePlayerByIDDB]
@IDDB int
AS
BEGIN
	SELECT IDCT,CauThu.Ten,TONGBANTHANG
	FROM CauThu
	WHERE CauThu.IDDB = @IDDB
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPlayerByIDDB]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--- Bổ xung Player ---------------------------------------------

CREATE PROC [dbo].[USP_GetListPlayerByIDDB]
@IDDB int
AS
BEGIN
	SELECT * FROM CauThu
	WHERE CauThu.IDDB = @IDDB
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetListPlayerExceptImage]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[USP_GetListPlayerExceptImage]
@iddb int
AS
BEGIN
	SELECT IDCT, CauThu.Ten, CauThu.IDDB, CauThu.IDLCT, CauThu.TONGBANTHANG
	FROM CauThu
	where IDDB = @iddb
	ORDER BY IDDB
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetMatchesByVongDau]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Get matches by Vong dau

CREATE PROC [dbo].[USP_GetMatchesByVongDau] 
@idmg INT,
@vongDau INT
AS
BEGIN
	SELECT 
		IDTranDau as [Số thứ tự],
		VongDau as [Vòng đấu],
		Doi1 as [ID1],
		Doi2 as [ID2],
		SanVanDong as [Đội 1],
		SanVanDong as [Đội 2],
		SanVanDong as [Sân vận động],
		CONVERT(VARCHAR(10),  ThoiGian, 103) AS [Ngày],
		CONVERT(VARCHAR(5),  ThoiGian, 108) AS [Giờ]
	FROM TranDau
	WHERE IDMG = @idmg AND VongDau = @vongDau
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GETNAMEANDDoBCAUTHU]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROC [dbo].[USP_GETNAMEANDDoBCAUTHU]
@IDMG INT
AS
BEGIN
	Select CT.IDCT,CT.NgaySinh From
	(
		Select IDDB, IDMG
		From DoiBong
		Where DoiBong.IDMG = @IDMG
	) DB join
	(
		Select IDCT, NgaySinh, IDDB
		From CauThu
	) CT on DB.IDDB = CT.IDDB
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetNewIdTranDau]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_GetNewIdTranDau]
@MuaGiai int
AS
BEGIN
	SELECT TOP(1) IDTRANDAU
	FROM TRANDAU
	where idmg = @MuaGiai
	ORDER BY IDTRANDAU DESC	
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetPlayerListByIDDB]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Get Player List by IDDB

CREATE PROC [dbo].[USP_GetPlayerListByIDDB]
@iddb INT
AS
BEGIN
	SELECT IDCT as [Số thứ tự], Ten as [Họ tên], GioiTinh as [Giới tính], 
	QuocTich as [Quốc tịch], NgaySinh as [Ngày sinh], GhiChu as [Ghi chú]
	FROM CauThu
	WHERE IDDB = @iddb
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetPlayerTypeListByIDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Get player type list by IDMG
CREATE PROC [dbo].[USP_GetPlayerTypeListByIDMG]
@idmg INT
AS
BEGIN
	SELECT 
		IDLCT AS [Số thứ tự],
		TenLCT AS [Tên loại cầu thủ],
		SLTD AS [Số lượng tối đa]
	FROM LoaiCauThu
	WHERE IDMG = @idmg
END

GO
/****** Object:  StoredProcedure [dbo].[USP_GetPriorityRankList_By_IDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 -- Get Priority Rank

 CREATE PROC [dbo].[USP_GetPriorityRankList_By_IDMG]
 @idmg INT
 AS
 BEGIN
	SELECT * FROM QuyDinhXepHang
	WHERE IDMG = @idmg
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetRules_By_IDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 -- Get Rules By IDMG

CREATE PROC [dbo].[USP_GetRules_By_IDMG]
@idmg INT
AS
BEGIN
	SELECT * FROM QuyDinh WHERE IDMG = @idmg
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetScoreRule_By_IDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Get Score Rule

CREATE PROC [dbo].[USP_GetScoreRule_By_IDMG]
 @idmg INT
 AS
 BEGIN
	SELECT * FROM QuyDinhDiemSo 
	WHERE IDMG = @idmg
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetTeamList]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Mô tả
--CREATE PROCEDURE /*Name*/
/*
*/

-- Get table DoiBong
CREATE PROC [dbo].[USP_GetTeamList]
AS SELECT * FROM DoiBong

GO
/****** Object:  StoredProcedure [dbo].[USP_GetTeamListByIDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Get Team List By IDMG
CREATE PROC [dbo].[USP_GetTeamListByIDMG]
@idmg INT
AS
BEGIN
	SELECT * FROM DoiBong WHERE IDMG = @idmg
END


GO
/****** Object:  StoredProcedure [dbo].[USP_GetTeamListByIDMGAndIDDoiBong]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- Bổ xung team -----------------------------------------------
CREATE PROC [dbo].[USP_GetTeamListByIDMGAndIDDoiBong]
@idmg INT,
@idDoiBong INT
AS
BEGIN
	SELECT * FROM DoiBong 
	WHERE IDMG = @idmg AND IdDb = @idDoiBong
END
GO
/****** Object:  StoredProcedure [dbo].[USP_InsertMatch]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Insert a match
CREATE PROC [dbo].[USP_InsertMatch]
@idmg INT,
@vongdau INT,
@id1 INT,
@id2 INT,
@stadium NVARCHAR(50)
AS
BEGIN
	INSERT INTO TranDau(IDMG, VongDau, Doi1, Doi2, SanVanDong) 
	VALUES (@idmg, @vongdau, @id1, @id2 ,@stadium)
END

GO
/****** Object:  StoredProcedure [dbo].[USP_LOADGOALS]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



-- Goal ------------------------------------------------------------------------------------------------------

CREATE PROC [dbo].[USP_LOADGOALS]
@IDTRANDAU INT 
AS
BEGIN
	SELECT * FROM BANTHANG 
	WHERE IDTranDau = @IDTRANDAU
END
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadResultMatch]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ResultMatch--------------------------------------------------------------------------------------------
CREATE proc [dbo].[USP_LoadResultMatch]
@Idmg int 
AS
BEGIN
	SELECT DISTINCT * FROM 
	(
		SELECT KetQuaThiDau.IDTranDau, TranDau.VongDau,TranDau.Doi1 AS IDDOI1,TranDau.Doi2 AS IDDOI2,KQDoi1,KQDoi2,
		TranDau.SanVanDong, TranDau.ThoiGian
		FROM KetQuaThiDau JOIN TranDau 
			ON KetQuaThiDau.IDTranDau=TranDau.IDTranDau
		Where TranDau.IDMG = @Idmg
	) AS KETQUA 
	JOIN (
		SELECT Doi.TenDB AS TENDOI1, Doi.IDDB 
		FROM TranDau JOIN	(Select IDDB,tenDB,hinhanh as HinhAnhDoi1
								from DoiBong) Doi
					 ON Doi.IDDB = TranDau.Doi1
	) DOI1 ON KetQua.IDDOI1 = DOI1.IDDB
	JOIN (
		SELECT Doi.TenDB AS TENDOI2, Doi.IDDB 
		FROM TranDau JOIN	(Select IDDB,tenDB,Hinhanh as HinhAnhDoi2
								from DoiBong) Doi
					 ON Doi.IDDB = TranDau.Doi2
	) DOI2 ON KetQua.IDDOI2 = DOI2.IDDB
	ORDER BY ThoiGian
END
GO
/****** Object:  StoredProcedure [dbo].[USP_LoadResultMatchByName]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 -- Resutl Match By Name 2 Team
 CREATE proc [dbo].[USP_LoadResultMatchByName]
 @idmg INT,
 @TENDOI1 NVARCHAR(50),
 @TENDOI2 NVARCHAR(50)
AS
BEGIN
   SELECT DISTINCT * FROM 
	(
		SELECT KetQuaThiDau.IDTranDau, TranDau.VongDau,TranDau.Doi1 AS IDDOI1,TranDau.Doi2 AS IDDOI2,KQDoi1,KQDoi2,
		TranDau.SanVanDong, TranDau.ThoiGian
		FROM KetQuaThiDau JOIN TranDau 
			ON KetQuaThiDau.IDTranDau=TranDau.IDTranDau
			WHERE TranDau.IDMG = @Idmg
	) AS KETQUA 
	JOIN (
		SELECT Doi.TenDB AS TENDOI1, Doi.IDDB 
		FROM TranDau JOIN	(Select IDDB,tenDB,hinhanh as HinhAnhDoi1
								from DoiBong) Doi
					 ON Doi.IDDB = TranDau.Doi1
	) DOI1 ON KetQua.IDDOI1 = DOI1.IDDB
	JOIN (
		SELECT Doi.TenDB AS TENDOI2, Doi.IDDB 
		FROM TranDau JOIN	(Select IDDB,tenDB,Hinhanh as HinhAnhDoi2
								from DoiBong) Doi
					 ON Doi.IDDB = TranDau.Doi2
	) DOI2 ON KetQua.IDDOI2 = DOI2.IDDB
	WHERE TENDOI1 = @TENDOI1 OR TENDOI2 = @TENDOI2
	ORDER BY ThoiGian
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UPDATEGOAL]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[USP_UPDATEGOAL] 
@IDBANTHANG INT ,@IDCAUTHU INT,@IDLOAIBANTHANG INT,@THOIDIEM NVARCHAR(10)
AS BEGIN
	UPDATE BANTHANG
	SET IDCT=@IDCAUTHU, IDLBT = @IDLOAIBANTHANG,ThoiDiem = @THOIDIEM
	WHERE IDBT = @IDBANTHANG
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePlayerInfor]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- Update player information

CREATE PROC [dbo].[USP_UpdatePlayerInfor]
@idct INT,
@name NVARCHAR(50),
@gender NVARCHAR(30),
@nationality NVARCHAR(50),
@dob SMALLDATETIME,
@note NVARCHAR(1000),
@idLCT INT
AS 
BEGIN
	UPDATE CauThu
	SET Ten = @name, GioiTinh = @gender, NgaySinh = @dob, QuocTich = @nationality, GhiChu = @note, IDLCT = @idLCT
	WHERE IDCT = @idct
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdatePriorityRankList_By_ThuTuUuTien]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Update PriorityRank
CREATE PROC [dbo].[USP_UpdatePriorityRankList_By_ThuTuUuTien]
 @idmg INT,
 @Ten NVARCHAR(100),
 @ThuTuUuTien INT
 AS
 BEGIN
	UPDATE QuyDinhXepHang
	SET Ten = @Ten
	WHERE IDMG = @idmg AND ThuTuUuTien = @ThuTuUuTien
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateRules_By_IDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 -- Update Rules By IDMG

 CREATE PROC [dbo].[USP_UpdateRules_By_IDMG]
@idmg INT,
@SLDB INT,
@TuoiTT INT,
@TuoiTD INT,
@SLTT INT,
@SLTD INT,
@TGGBTD NVARCHAR(10)
AS
BEGIN
	UPDATE QuyDinh
	SET SLDB = @SLDB, TuoiTT = @TuoiTT, TuoiTD = @TuoiTD, SLTT = @SLTT, SLTD = @SLTD, TGGBTD = @TGGBTD
	WHERE IDMG = @idmg
END
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateScoreRule_By_IDMG]    Script Date: 27/06/2021 14:33:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 -- Update Score Rule By IMGD

 CREATE PROC [dbo].[USP_UpdateScoreRule_By_IDMG]
 @idmg INT,
 @THANG INT,
 @HOA INT,
 @THUA INT
 AS
 BEGIN
	UPDATE QuyDinhDiemSo
	SET THANG = @THANG, HOA = @HOA, THUA = @THUA
	WHERE IDMG = @idmg
END
GO
USE [master]
GO
ALTER DATABASE [NFCM] SET  READ_WRITE 
GO
