--1
CREATE TABLE MONHOC
(
	MaMon char(7) PRIMARY KEY ,
	TenMon nvarchar(50) not null,
	SoTinChi int not null,
	NgayDB date not null,
	NgayKT date not null,
)
ALTER TABLE dbo.[MONHOC] ADD DisableFrom date
ALTER TABLE dbo.[MONHOC] ADD DisableTo date 
--2
CREATE TABLE GIAOVIEN
(
	MaGV char(7) PRIMARY KEY ,
	TenGV nvarchar(50) not null,
	SDT varchar(11) not null,
	PasswordHash BINARY(64) NOT NULL,
)
ALTER TABLE dbo.[GIAOVIEN] ADD Salt UNIQUEIDENTIFIER 
ALTER TABLE dbo.[GIAOVIEN] ADD PassRAW nvarchar(50)
--3
CREATE TABLE SINHVIEN
(
	MSSV char(7) PRIMARY KEY,
	TENSV nvarchar(50) not null,
	SDT varchar(11) not null,
	PasswordHash BINARY(64) NOT NULL,
	Salt nvarchar(36) not null
)
ALTER TABLE dbo.[SINHVIEN] ADD Salt UNIQUEIDENTIFIER 

CREATE TABLE SINHVIEN_MONHOC
(
	MSSV char(7) not null,
	MaMon char(7) not null,
	PRIMARY KEY(MSSV, MaMon)
)
ALTER TABLE SINHVIEN_MONHOC add constraint FK_SINHVIEN_MONHOC_MSSV FOREIGN KEY(MSSV)
REFERENCES SINHVIEN(MSSV)
ALTER TABLE SINHVIEN_MONHOC add constraint FK_SINHVIEN_MONHOC_MaMon FOREIGN KEY(MaMon)
REFERENCES MONHOC(MaMon)
CREATE TABLE QUANTRIVIEN
(
	ad_name nvarchar(50) NOT NULL UNIQUE,
	PasswordHash BINARY(64) NOT NULL,
	Salt UNIQUEIDENTIFIER 
)

--ALTER TABLE dbo.[QUANTRIVIEN] ADD Salt UNIQUEIDENTIFIER 
--ALTER TABLE dbo.[QUANTRIVIEN] ADD ad_name nvarchar(50) NOT NULL UNIQUE

--4
CREATE TABLE NHOM
(
	MaNhom int identity(1,1) not null,
	MaDA int not null, --them maDA vào làm khóa chính với MaNhom
	TenNhom nvarchar(50) not null,
	TruongNhom char(7) not null,
	PRIMARY KEY (MaNhom, MaDA)
)
--9 chi tiết nhóm
CREATE TABLE CHITIET_NHOM
(
	MaNhom int not null,
	MaDA int not null,
	MaSV char(7) not null,
	--Diem float,
	PRIMARY KEY (MaNhom, MaDA)
)
ALTER TABLE CHITIET_NHOM ADD Diem float
ALTER TABLE dbo.CHITIET_NHOM
ADD CONSTRAINT CHK_Diem CHECK (Diem>=0.0 AND Diem <=10.0)
--5
CREATE TABLE GV_PHUTRACH_MON
(
	MaGV char(7) not null,
	MaMon char(7) not null,
	PRIMARY KEY (MaGV, MaMon)
 )

--6
CREATE TABLE DOAN
(
	MaDoAn int identity PRIMARY KEY,	
	TenDoAn nvarchar(50) not null,
	--MoTa nvarchar(300) not null,
	SLSV_ToiDa int not null,
	SLN_ToiDa int not null,
	NgayKTDK date not null,
	NgayNop date not null,
	--LoaiDoAn nvarchar(20),
	MaMon char(7) not null
	CHECK (LoaiDoAn IN (N'Bài tập cộng điểm', N'Giữa Kỳ', N'Cuối Kỳ'));
)
ALTER TABLE DOAN ADD SLN_ToiDa int not null
ALTER TABLE DOAN ADD MoTa nvarchar(50) not null
ALTER TABLE DOAN ADD LoaiDoAn nvarchar(20) not null CHECK (LoaiDoAn IN (N'Bài tập cộng điểm', N'Giữa Kỳ', N'Cuối Kỳ'))
--7
-- CREATE TABLE DE
-- (
-- 	MaDe int identity(1,1) PRIMARY KEY,
-- 	MaDoAn int not null,
-- 	TenDe nvarchar(50) not null,
-- 	MoTa nvarchar(50) not null
-- )

--8
CREATE TABLE GV_PHUTRACH_DA
(
	MaGV char(7) not null,
	MaDoAn int not null,
	PRIMARY KEY (MaGV, MaDoAn)
)



--10
-- CREATE TABLE TAIKHOAN
-- (
-- 	Id char(7) PRIMARY KEY,
-- 	--Pass char not null,
-- 	PasswordHash BINARY(64) NOT NULL,
-- 	Salt nvarchar(36) not null,
-- 	PhanQuyen int not null,
-- )

ALTER TABLE NHOM add constraint FK_TruongNhom FOREIGN KEY(TruongNhom)
REFERENCES SINHVIEN(MSSV)
ALTER TABLE NHOM add constraint FK_NHOM_MADA FOREIGN KEY(MaDA)
REFERENCES DOAN(MaDoAn)
ALTER TABLE GV_PHUTRACH_MON add constraint FK_GV_PHUTRACH_MON_MAGV FOREIGN KEY(MaGV)
REFERENCES GIAOVIEN(MaGV)
ALTER TABLE GV_PHUTRACH_MON add constraint FK_GV_PHUTRACH_MON_MAMON FOREIGN KEY(MaMon)
REFERENCES MONHOC(MaMon)
ALTER TABLE DOAN add constraint FK_DOAN_MAMON FOREIGN KEY(MaMon)
REFERENCES MONHOC(MaMon)
-- ALTER TABLE DE add constraint FK_DE_DoAN FOREIGN KEY(MaDoAn)
-- REFERENCES DOAN(MaDoAn)
ALTER TABLE GV_PHUTRACH_DA add constraint FK_GV_PHUTRACH_MaGV FOREIGN KEY(MaGV)
REFERENCES GIAOVIEN(MaGV)
ALTER TABLE GV_PHUTRACH_DA add constraint FK_GV_PHUTRACH_MaDoAn FOREIGN KEY(MaDoAn)
REFERENCES DOAN(MaDoAn)
ALTER TABLE CHITIET_NHOM add constraint FK_CHITIET_NHOM_NHOM_DOAN FOREIGN KEY(MaNhom, MaDA)
REFERENCES NHOM(MaNhom, MaDA)
ALTER TABLE CHITIET_NHOM add constraint FK_CHITIET_NHOM_NHOM_MaSV FOREIGN KEY(MaSV)
REFERENCES SINHVIEN(MSSV)
