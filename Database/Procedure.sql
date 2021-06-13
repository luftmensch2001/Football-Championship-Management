USE NFCM
GO

-- Mô tả
CREATE PROCEDURE /*Name*/
/*

*/
GO

-- Get table DSDoiBong
CREATE PROC USP_GetTeamList
AS SELECT * FROM DSDoiBong

GO

-- Get player type list

CREATE PROC USP_GetPlayerTypeList
AS SELECT * FROM LoaiCauThu

GO

-- Get Team List By IDMG

CREATE PROC USP_GetTeamListByIDMG
@idmg INT
AS
BEGIN
	SELECT * FROM DSDoiBong WHERE IDMG = @idmg
END

GO

-- Get player type by IDMG
CREATE PROC USP_GetPlayerTypeByIDMG
@idmg INT
AS
BEGIN
	SELECT * FROM LoaiCauThu WHERE IDMG = @idmg
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
	UPDATE DSDoiBong
	SET TenDB = @name,
		TenHLV = @coach,
		SanNha = @host
	WHERE IDDB = @iddb
END
GO