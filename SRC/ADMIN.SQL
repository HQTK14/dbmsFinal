--Thêm sinh viên
CREATE PROC CREATE_STUDENT
@MSSV char(7),
@TENSV nvarchar(50),
@SDT varchar(11),
@Password nvarchar(50)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	Insert INTO SINHVIEN(MSSV, TENSV, SDT, salt, PasswordHash)
		VALUES(@MSSV, @TENSV, @SDT,@salt,HASHBYTES('SHA2_512', @Password+CAST(@salt AS NVARCHAR(36))))
END

--thêm giáo viên
CREATE PROC CREATE_TEACHER
@MaGV char(7),
@TENGV nvarchar(50),
@SDT varchar(11),
@Password nvarchar(50)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	Insert INTO dbo.GIAOVIEN
	(
	    MaGV,
	    TenGV,
	    SDT,
	    Salt,
		PasswordHash
	)
		VALUES(@MaGV, @TENGV, @SDT,@salt,HASHBYTES('SHA2_512', @Password+CAST(@salt AS NVARCHAR(36))))
END

--thêm admin
CREATE PROC CREATE_ADMIN
@ad_name nvarchar(50),
@Password nvarchar(50)
AS
BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	Insert INTO QUANTRIVIEN(ad_name, salt, PasswordHash)
		VALUES(@ad_name, @salt, HASHBYTES('SHA2_512', @Password+CAST(@salt AS NVARCHAR(36))))
END

--admin vô hiệu môn học
CREATE PROC DISABLE_SUBJECT
@disablefrom date,
@disableto date,
@MaMon Char(7)
AS
BEGIN
 UPDATE MONHOC
 	SET disablefrom = @disablefrom,
 		disableto = @disablefrom
 	where MaMon = @MaMon
END

CREATE PROC ENABLE_SUBJECT
@MaMon Char(7)
AS
BEGIN
 UPDATE MONHOC
 	SET disablefrom = NULL,
 		disableto = NULL
 	where MaMon = @MaMon
END