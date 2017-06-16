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


ALTEr PROC ADMIN_LOGIN
@ad_name varchar(20),
@pwd nvarchar(50),
--@KQ int OUTPUT,
@KQ int OUT
AS 
BEGIN
DECLARE @adName VARCHAR(50)
	IF EXISTS (Select ad_name FROM QUANTRIVIEN Where ad_name = @ad_name)
		Begin
			SET @adName = (
							Select ad_name
								FROM dbo.QUANTRIVIEN
									 Where
									 		ad_name = @ad_name
									 		AND
									 		PasswordHash = HASHBYTES('SHA2_512', @pwd+CAST(Salt AS NVARCHAR(36)))
							)
			IF(@adName is not  NULL)
				SET @KQ=1
			ELSE
				SET @KQ=0
		End
	ELSE
		SET @KQ = -1
END
--/ĐĂNG NHẬP
--THÊM MÔN HỌC
CREATE PROC CREATE_SUBJECT
@MaMon char(7),
@TenMon nvarchar(50),
@SoTinChi int,
@NgayDB DATE,
@NgayKT date
AS
BEGIN
 Insert into MONHOC(MaMon, TenMon, SoTinChi, NgayDB, NgayKT)
 	VALUES (@MaMon, @TenMon, @SoTinChi, @NgayDB, @NgayKT)
END
--Sửa môn học
CREATE PROC UPDATE_SUBJECT
@MaMon char(7),
@TenMon nvarchar(50),
@SoTinChi int,
@NgayDB DATE,
@NgayKT date
AS
BEGIN
 UPDATE MONHOC
 SET TenMon = @TenMon, 
 	 SoTinChi = @SoTinChi,
 	 NgayDB = @NgayDB,
 	 NgayKT = @NgayKT
 Where MaMon = @MaMon
END
--Xóa Môn
CREATE PROC REMOVE_SUBJECT
@MaMon CHAR(7)
AS
BEGIN
 Delete FROM MONHOC Where MaMon = @MaMon
END
--lấy ds môn học
CREATE PROC SELECT_ALL_SUBJECT
AS
BEGIN
 Select * FROM MONHOC
 END