﻿USE NFCM
GO


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

  -- Get Rules By IDMG

CREATE PROC USP_GetRules_By_IDMG
@idmg INT
AS
BEGIN
	SELECT * FROM QuyDinh WHERE IDMG = @idmg
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