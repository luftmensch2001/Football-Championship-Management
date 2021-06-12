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