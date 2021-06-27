USE NFCM
GO

-- Mô tả
--CREATE PROCEDURE /*Name*/
/*
*/

-- Get table DoiBong
CREATE PROC USP_GetTeamList
AS SELECT * FROM DoiBong

GO

-- Get Team List By IDMG
CREATE PROC USP_GetTeamListByIDMG
@idmg INT
AS
BEGIN
	SELECT * FROM DoiBong WHERE IDMG = @idmg
END


GO

-- Get Player List by IDDB

CREATE PROC USP_GetPlayerListByIDDB
@iddb INT
AS
BEGIN
	SELECT IDCT as [Số thứ tự], Ten as [Họ tên], GioiTinh as [Giới tính], 
	QuocTich as [Quốc tịch], NgaySinh as [Ngày sinh], GhiChu as [Ghi chú]
	FROM CauThu
	WHERE IDDB = @iddb
END

GO

-- Change Team Information by IDDB

CREATE PROC USP_ChangeTeamInforByIDDB
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

-- Count of Player By IDDB

CREATE PROC USP_CountOfPlayer
@iddb INT
AS
BEGIN
	SELECT COUNT(IDCT) AS SL 
	FROM CauThu
	WHERE IDDB = @iddb
END
GO

-- Count of Team By IDMG

CREATE PROC USP_CountOfTeam
@idmg INT
AS
BEGIN
	SELECT COUNT(IDDB) AS SL 
	FROM DoiBong
	WHERE IDMG = @idmg
END
GO


-- Update player information

CREATE PROC USP_UpdatePlayerInfor
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

-- Get count of players have idlct in team, except this idct   
CREATE PROC USP_GetCountPlayerByIDLCT 
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

--Get player type list by IDMG
CREATE PROC USP_GetPlayerTypeListByIDMG
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

-- Insert a match
CREATE PROC USP_InsertMatch
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

-- Get All Matches

CREATE PROC USP_GetAllMatches 
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


-- Get matches by Vong dau

CREATE PROC USP_GetMatchesByVongDau 
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

-- ResultMatch--------------------------------------------------------------------------------------------
CREATE proc USP_LoadResultMatch
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
 -- Resutl Match By Name 2 Team
 CREATE proc USP_LoadResultMatchByName
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

CREATE PROC USP_GetNewIdTranDau
@MuaGiai int
AS
BEGIN
	SELECT TOP(1) IDTRANDAU
	FROM TRANDAU
	where idmg = @MuaGiai
	ORDER BY IDTRANDAU DESC	
END
GO



-- Goal ------------------------------------------------------------------------------------------------------

CREATE PROC USP_LOADGOALS
@IDTRANDAU INT 
AS
BEGIN
	SELECT * FROM BANTHANG 
	WHERE IDTranDau = @IDTRANDAU
END
GO


CREATE PROC USP_UPDATEGOAL 
@IDBANTHANG INT ,@IDCAUTHU INT,@IDLOAIBANTHANG INT,@THOIDIEM NVARCHAR(10)
AS BEGIN
	UPDATE BANTHANG
	SET IDCT=@IDCAUTHU, IDLBT = @IDLOAIBANTHANG,ThoiDiem = @THOIDIEM
	WHERE IDBT = @IDBANTHANG
END
GO

CREATE PROC USP_DELETEGOAL
@IDBANTHANG INT
AS
BEGIN
	DELETE BANTHANG
	WHERE IDBT = @IDBANTHANG
END
GO

--- Bổ xung team -----------------------------------------------
CREATE PROC USP_GetTeamListByIDMGAndIDDoiBong
@idmg INT,
@idDoiBong INT
AS
BEGIN
	SELECT * FROM DoiBong 
	WHERE IDMG = @idmg AND IdDb = @idDoiBong
END
GO



--- Bổ xung Player ---------------------------------------------

CREATE PROC USP_GetListPlayerByIDDB
@IDDB int
AS
BEGIN
	SELECT * FROM CauThu
	WHERE CauThu.IDDB = @IDDB
END
GO

CREATE PROC USP_GetListIdAndNamePlayerByIDDB
@IDDB int
AS
BEGIN
	SELECT IDCT,CauThu.Ten
	FROM CauThu
	WHERE CauThu.IDDB = @IDDB
END
GO
Alter PROC USP_GetListIdAndNamePlayerByIDDB
@IDDB int
AS
BEGIN
	SELECT IDCT,CauThu.Ten,TONGBANTHANG
	FROM CauThu
	WHERE CauThu.IDDB = @IDDB
END
GO


CREATE PROC USP_GetListPlayerExceptImage
@iddb int
AS
BEGIN
	SELECT IDCT, CauThu.Ten, CauThu.IDDB, CauThu.IDLCT, CauThu.TONGBANTHANG
	FROM CauThu
	where IDDB = @iddb
	ORDER BY IDDB
END
GO

 -- Get Rules By IDMG

CREATE PROC USP_GetRules_By_IDMG
@idmg INT
AS
BEGIN
	SELECT * FROM QuyDinh WHERE IDMG = @idmg
END
GO

 -- Update Rules By IDMG

 CREATE PROC USP_UpdateRules_By_IDMG
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

 -- Update Score Rule By IMGD

 CREATE PROC USP_UpdateScoreRule_By_IDMG
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

-- Get Score Rule

CREATE PROC USP_GetScoreRule_By_IDMG
 @idmg INT
 AS
 BEGIN
	SELECT * FROM QuyDinhDiemSo 
	WHERE IDMG = @idmg
END
GO

 -- Get Priority Rank

 CREATE PROC USP_GetPriorityRankList_By_IDMG
 @idmg INT
 AS
 BEGIN
	SELECT * FROM QuyDinhXepHang
	WHERE IDMG = @idmg
END
GO

-- Update PriorityRank
CREATE PROC USP_UpdatePriorityRankList_By_ThuTuUuTien
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

Create PROC USP_GETNAMEANDDoBCAUTHU
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