--Laays danh sach mon hoc
CREATE PRO_GET_ALL_STUDENT
--ĐĂNG NHẬP
CREATE PROC STUDENT_LOGIN
@id char(7),
@pwd nvarchar(50),
--@KQ int OUTPUT,
@stringKQ nvarchar(50) OUT
AS 
Begin
	IF EXISTS (Select MSSV FROM SINHVIEN Where MSSV = @id)
		Begin
			SET stringKQ = (
							Select TENSV 
								FROM SINHVIEN
									 Where
									 		MSSV = @id 
									 		AND
									 		PasswordHash = HASHBYTES('SHA2_512', @pwd+CAST(Salt AS NVARCHAR(36)))
							)
			IF(stringKQ is NULL)
				SET stringKQ='Incorrect Password'
			ELSE
				--SET @KQ=1
		End
	ELSE
		SET stringKQ = 'Invalid Login'
END
--/ĐĂNG NHẬP
--tạo tài khoản
CREATE PROC STUDENT_ACCOUNT
@id char(7),
@pwd nvarchar(50),
--@KQ int OUTPUT,
@KQ int OUT
AS 
Begin
DECLARE @salt UNIQUEIDENTIFIER=NEWID()
	UPDATE SINHVIEN
		SET salt = @salt,
			PasswordHash = HASHBYTES('SHA2_512', @pwd+CAST(@salt AS NVARCHAR(36)))
			WHERE MSSV = @id
END
CREATE PROC STUDENT_ALREADY_HAS_ACCOUNT
@id char(7),
--@KQ int OUTPUT,
@KQ int out 
AS 
Begin
DECLARE @PasswordHash BINARY(64)
set @PasswordHash = (Select * FROM SINHVIEN WHERE MSSV = @id)
			IF(@PasswordHash == NULL) SET @KQ=-2
			ELSE SET @KQ=1
END
--tạo tài khoản

--Trưởng nhóm tạo nhóm
CREATE PROC CREATE_GROUP
@MaDA int
@TenNhom nvarchar(50)
@TruongNhom char(7)
@MaDe int
AS
BEGIN
	Insert into NHOM(MaDA,TenNhom,TruongNhom,MaDe)
	VALUES(@MaDA, @TenNhom, @TruongNhom , @MaDe)
END
--/Trưởng nhóm tạo nhóm

CREATE PROC CHECK_IS_LEADER_GROUP
@

--huywr đồ án
CREATE PROC DESELECT_PROJECT
@MaDA int
@TenNhom nvarchar(50)
@TruongNhom char(7)
@MaDe int
AS
BEGIN
	UPDATE NHOM
	SET MaDA=0, MaDe=0
	Where @MaNhom = 
	Insert into NHOM(MaDA,TenNhom,TruongNhom,MaDe)
	VALUES(@MaDA, @TenNhom, @TruongNhom , @MaDe)
END
--/huywr đồ án



--LÀM TRƯỞNG NHÓM
CREATE PROC_SET_LEADER_GROUP
@IDnhom int,
@IDDA int,
@mssv char(7)
AS
BEGIN
	update NHOM
		set TruongNhom = @mssv
	 Where MaNhom = @IDDA 
	 		AND
	 		MaDA = @IDDA
END
--Hủy làm trưởng nhóm
CREATE PROC_RESIGN_LEADER_GROUP
@IDnhom int,
@IDDA int,
@mssv char(7)
AS
BEGIN
	update NHOM
		set TruongNhom = ''
	 Where MaNhom = @IDDA 
	 		AND
	 		MaDA = @IDDA
END
--Kiểm tra đã thuộc nhóm nào chưa
CREATE PROC CHECK_STUDENT_ALREADY_IN_A_GROUP
@IDnhom int,
@IDDA int,
@mssv char(7)
@KQ int OUTPUT
AS
BEGIN

	IF EXISTS (Select MaSV FROM CHITIET_NHOM CT Where MaNhom = @IDnhom AND MaDA = @IDDA AND MaSV = @mssv)
		SET KQ = 1
	ELSE 
		SET KQ = -1
END

	
--Đăng kí nhóm
CREATE PROC STUDENT_REGISTER_GROUP
@IDnhom int,
@IDDA int,
@mssv char(7)
AS
BEGIN
	Insert into NHOM(MaNhom, MaDA, MaSV)
		VALUES(@IDnhom, @IDDA, @mssv)
END
--rời nhóm
CREATE PROC STUDENT_LEAVE_GROUP
@IDnhom int,
@IDDA int,
@mssv char(7)
AS
BEGIN
	delete FROM CHITIET_NHOM
		Where MaNhom = @IDnhom 
			  AND
			  MaDA = @IDDA
			  AND
			  MaSV = @mssv
END
--lấy ds môn
Select MaMon, TenMon FROM MONHOC mh, SINHVIEN_MONHOC svmh WHERE svmh.mssv = '' AND svmh.MaMon = mh.MaMOn
--lây danh sách đồ án theo môn
