--ra đồ án
CREATE TABLE DOAN
(
	MaDoAn int identity PRIMARY KEY,	
	TenDoAn nvarchar(50) not null,
	--MoTa nvarchar(300) not null,
	SLSV_ToiDa int not null,
	NgayKTDK date not null,
	NgayNop date not null,
	--LoaiDoAn nvarchar(20),
	MaMon char(7) not null
	CHECK (LoaiDoAn IN (N'Bài tập cộng điểm', N'Giữa Kỳ', N'Cuối Kỳ'));
)
CREATE PROC GRANT_PROJECT
@TenDoAn nvarchar(50),
@MoTa nvarchar(300),
@SLSV_ToiDa int,
@NgayKTDK date,
@LoaiDoAn nvarchar(20),
@MaMon char(7)
AS
BEGIN
	INSERT INTO DOAN(TenDoAn,MoTa,SLSV_ToiDa,NgayKTDK,LoaiDoAn,MaMon)
	VALUES (@TenDoAn, @MoTa,@SLSV_ToiDa, @NgayKTDK, @LoaiDoAn, @MaMon)
END

--update Deadline,...
CREATE PROC update_deadline
@NgayNop date
@SLSV_ToiDa int
@SLN_ToiDa int 
@MaDoAn
AS
BEGIN
	update DOAN
		if(@NgayNop!= NULL)set NgayNop = @NgayNop
		if(@SLSV_ToiDa!=NULL)set SLSV_ToiDa = @SLSV_ToiDa
		if(@SLN_ToiDa!=NULL)set SLN_ToiDa = @SLN_ToiDa
		WHERE MaDoAn = @MaDoAn

END

--XEM THÔNG TIN ĐĂNG KÍ ĐỒ ÁN CỦA 1 MÔN HỌC
CREATE PROC VIEW_REGISTER_A_PROJECT
@MaMon
AS
BEGIN
 SELECT nh.MaNhom,nh.TenNhom,sv.mssv, sv.TenSV
 	FROM
 		 DOAN da,
 		 NHOM nh,
 		 CHITIET_NHOM ctn,
 		 SINHVIEN sv
 		 WHERE
 		       da.MaMon= @MaMon
 		  	   AND
 		  	   nh.MaDA = da.MaDoAn	
 		  	   AND
 		  	   ctn.MaNhom = nh.MaNhom
 		  	   AND
 		  	   sv.mssv = ctn.MaSV
 		ORDER BY nh.MaNhom

END
--XEM THÔNG TIN ĐĂNG KÍ 1 ĐỒ ÁN
CREATE PROC VIEW_REGISTER_A_PROJECT
@MaDoAn
AS
BEGIN
 SELECT nh.MaNhom,nh.TenNhom,sv.mssv, sv.TenSV
 	FROM DOAN da,
 		 NHOM nh,
 		 CHITIET_NHOM ctn,
 		 SINHVIEN sv
 		 WHERE da.MaDoAn= 1
 		  	   AND
 		  	   nh.MaDA = 1
 		  	   AND
 		  	   ctn.MaNhom = nh.MaNhom
 		  	   AND
 		  	   sv.mssv = ctn.MaSV
 		ORDER BY nh.MaNhom

END
