DROP DATABASE LifeManager
GO
CREATE DATABASE LifeManager
GO
USE LifeManager
GO
SET DATEFORMAT dmy
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblEvent
(
	Ngay			DATE			,
	Ten				NVARCHAR(20)	,
	GhiChu			NTEXT          	,
	BatDau			TIME			NOT NULL DEFAULT '00:00',
	KetThuc			TIME			NOT NULL DEFAULT '23:59',
	CONSTRAINT PK_tblEvent PRIMARY KEY (Ngay, Ten)
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblAnother
(
	Nhom			NVARCHAR(20)	,
	Ten				NVARCHAR(30)	,
	Chinh			NVARCHAR(40)	DEFAULT N'',
	Phu				NVARCHAR(40)	DEFAULT N'',
	GhiChu			NVARCHAR(70)	,
	The				NVARCHAR(20)	,
	BatDau			DATE			,
	TrangThai		BIT				DEFAULT 0,
	KetThuc			DATE			,
	CONSTRAINT PK_tblAnother PRIMARY KEY (Nhom, Ten, Chinh)
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblHealth
(
	Ngay			DATE,
	Ten				NVARCHAR(20) NOT NULL	DEFAULT N'Bệnh',
	TrieuChung		NVARCHAR(40)			DEFAULT N'Mệt',
	UongThuoc		BIT						DEFAULT 1,
	SoLieu			INT						DEFAULT 0,
	DaUong			INT						DEFAULT 0,
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblHealthDay
(
	Ngay			DATE	,
	CanNang			INT		,
	ChieuCao		INT		,
	CamGiac			NTEXT	,
	CONSTRAINT PK_tblHealthDay PRIMARY KEY (Ngay)
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblMoney
(
	Ngay			DATE			,
	ThoiGian		TIME			,
	Ten				NVARCHAR(30)	,
	ThuChi			CHAR(3)			DEFAULT 'Chi',
	GiaTien			VARCHAR(10)		DEFAULT '0',
	Nhom			NVARCHAR(20)	,
	Vi				NVARCHAR(20)	DEFAULT N'Tiền mặt',
	Voi				NVARCHAR(50)	DEFAULT N'Chỉ mình tôi',
	GhiChu			NVARCHAR(100)	,
	CONSTRAINT PK_tblMoney PRIMARY KEY (Ngay, ThoiGian, Ten, ThuChi, GiaTien)
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblNote
(
	Ten				NVARCHAR(20)	,
	GhiChu			NTEXT			,
	CONSTRAINT PK_tblNote PRIMARY KEY (Ten) 
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblDiary
(
	Ngay			DATE			,
	NhatKy			NTEXT			,
	Hinh			NVARCHAR(100)	,
	CONSTRAINT PK_tblDairy PRIMARY KEY (Ngay) 
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblAlarm
(
	ThoiGian		TIME			,
	Ten				NVARCHAR(20)	,
	GhiChu			NVARCHAR(100)	,
	CONSTRAINT PK_tblAlarm PRIMARY KEY (ThoiGian) 
)
GO
----------------------------------------------------------------------------------------------------------------------------------------
----------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE tblTimeTable
(
	ThoiGian		TIME			,
	Thu2			NVARCHAR(50)	,
	Thu3			NVARCHAR(50)	,
	Thu4			NVARCHAR(50)	,
	Thu5			NVARCHAR(50)	,
	Thu6			NVARCHAR(50)	,
	Thu7			NVARCHAR(50)	,
	ChuNhat			NVARCHAR(50)	,
	CONSTRAINT PK_tblTimeTable PRIMARY KEY (ThoiGian) 
)
GO