
CREATE DATABASE QLTHUVIEN
GO

USE QLTHUVIEN
GO


CREATE TABLE dbo.ACCOUNT(
	Id	INT NULL,
	username NVARCHAR(20) PRIMARY KEY,
	password	NVARCHAR(20) NULL,
	quyen	NVARCHAR(20) NULL, 
)
GO


CREATE TABLE dbo.donvi(
	Id	INT NULL, 
	donvi_name NVARCHAR(20) PRIMARY KEY default N'Chưa đặt tên',
)
GO

CREATE TABLE dbo.smn(
	smn_id INT NULL, 
	smn_sl INT NULL, 
)
GO

CREATE TABLE dbo.chiaca(
	ca_id INT NOT NULL PRIMARY KEY, 
	nv_id INT NULL,
	ca_name NVARCHAR(20) NULL,
)
GO

CREATE TABLE dbo.phanloai(
	phanloai_id	INT NOT NULL PRIMARY KEY, 
	phanloai_name NVARCHAR(50),
	phanloai_ob NVARCHAR(50),
)
GO

CREATE TABLE dbo.nxb(
	nxb_id	INT NOT NULL PRIMARY KEY,
	nxb_name NVARCHAR(30) NULL default N'Chưa có tên nhen',
	address NVARCHAR(30) NULL default N'Chưa có tên nhen',
	phone NVARCHAR(10) NULL, 
	email NVARCHAR(30) NULL, 
	)
GO

CREATE TABLE dbo.tacgia(
	tacgia_id INT NOT NULL PRIMARY KEY,
	tacgia_name NVARCHAR(30) NULL default N'Chưa có tên nhen',
	address NVARCHAR(30) NULL default N'Chưa có tên nhen',
	Bdate DATETIME NULL,
)
GO
SELECT tacgia_id
FROM tacgia
ORDER BY tacgia_id DESC;
CREATE TABLE dbo.std(
	id INT NOT NULL PRIMARY KEY,
	fname NVARCHAR(20) NULL default N'Chưa có tên nhen',
	lname NVARCHAR(20) NULL default N'Chưa có tên nhen',
	bdate DATETIME NULL,
	gender NVARCHAR(10) NULL default N'Chưa có tên nhen',
	donvi NVARCHAR(10) NULL default N'Chưa có tên nhen',
	address NVARCHAR(30) NULL default N'Chưa có tên nhen',
	phone NVARCHAR(10) NULL, 
	email NVARCHAR(30) NULL,
	pic IMAGE NULL,
)
GO

CREATE TABLE dbo.teacher(
	id INT NOT NULL PRIMARY KEY,
	fname NVARCHAR(20) NULL default N'Chưa có tên nhen',
	lname NVARCHAR(20) NULL default N'Chưa có tên nhen',
	bdate DATETIME NULL,
	gender NVARCHAR(10) NULL default N'Chưa có tên nhen',
	donvi NVARCHAR(10) NULL default N'Chưa có tên nhen',
	address NVARCHAR(30) NULL default N'Chưa có tên nhen',
	phone NVARCHAR(10) NULL, 
	email NVARCHAR(30) NULL,
	pic IMAGE NULL,
)
GO
CREATE TABLE dbo.MUON(
	docgia_id INT not NULL,
	sach_id INT not NULL,
	NgayMuon DATE NULL,
	NgayTra	 DATE NULL,
)
GO
CREATE TABLE dbo.CHOMUON(
	ngcho_id INT not NULL,
	--schonmuon_id INT not NULL,
	schomuon NVARCHAR(10) NULL,
	name_cm NVARCHAR(30) NULL default N'Chưa có tên nhen', 
	theloai NVARCHAR(30) NULL default N'Chưa có tên nhen',
	tacgia NVARCHAR(30) NULL default N'Chưa có tên nhen',
	nxb NVARCHAR(30) NULL default N'Chưa có tên nhen',
	yxb DATETIME NULL,
	date_cm DATE NULL,
	sl_cm INT NULL,
)
GO
SELECT CHOMUON.schomuon, CHOMUON.name_cm, CHOMUON.theloai, CHOMUON.tacgia, CHOMUON.nxb, CHOMUON.yxb, (fname + lname) AS hoten,CHOMUON.date_cm, CHOMUON.sl_cm FROM CHOMUON INNER JOIN teacher on CHOMUON.ngcho_id = teacher.id ORDER BY CHOMUON.schomuon ASC;

SELECT MUON.docgia_id, std.fname, std.lname, sach.name, theloai.theloai, nxb.nxb_name,
                MUON.NgayMuon, MUON.NgayTra FROM MUON INNER JOIN std on MUON.docgia_id = std.id INNER JOIN sach on MUON.sach_id = sach.id INNER JOIN theloai on sach.theloai = theloai.id INNER JOIN nxb on sach.nxb_id =nxb.nxb_id;


UPDATE sach SET con = con - 1 from MUON where sach.id = MUON.sach_id;

SELECT id
FROM sach
ORDER BY id ASC;

CREATE TABLE dbo.sach(
	id INT NOT NULL,
	name NVARCHAR(30) NULL default N'Chưa có tên nhen', 
	theloai INT NULL default N'Chưa có tên nhen',
	tacgia_id INT NULL default N'Chưa có tên nhen',
	nxb_id INT NULL default N'Chưa có tên nhen',
	yxb DATETIME NULL,
	sl INT NULL,
	con INT NULL,
)
GO

CREATE TABLE dbo.theloai(
	id	CHAR(10) NOT NULL PRIMARY KEY,
	theloai NVARCHAR(30) NOT NULL default N'Chưa có tên nhen',
)
GO

CREATE TABLE dbo.nhanvien(
	id_nv INT NOT NULL PRIMARY KEY,
	fn_nv NVARCHAR(20) NULL default N'Chưa có tên nhen',
	ln_nv NVARCHAR(20) NULL default N'Chưa có tên nhen',
	bdate_nv DATETIME NULL,
	gender_nv NVARCHAR(10) NULL default N'Chưa có tên nhen',
	cv_id INT NULL default N'Chưa có tên nhen',
	address_nv NVARCHAR(30) NULL default N'Chưa có tên nhen',
	phone_nv NVARCHAR(10) NULL, 
	email_nv NVARCHAR(30) NULL,
	pic_nv IMAGE NULL,
)
GO
CREATE TABLE dbo.congviec(
	congviec_id	INT NULL, 
	congviec_name NVARCHAR(20) PRIMARY KEY default N'Chưa đặt tên',
)
GO
INSERT INTO congviec VALUES (1,N'Quản thư');
INSERT INTO congviec VALUES (2,N'Nhân viên trao nhận');
INSERT INTO congviec VALUES (3,N'Nhân viên xếp sách');
GO

INSERT INTO ACCOUNT VALUES (1,'c','1', 'Librarian');
INSERT INTO ACCOUNT VALUES (2,'19110055','1', 'Student');
GO

INSERT INTO donvi VALUES (1,'CNTT');
INSERT INTO donvi VALUES (2,'CKM');
GO

INSERT INTO nxb VALUES (1,N'NXB Hoa Mặt Trời', N'Đông Anh - Hà Nội', '0123456960', 'nxbhoammattroi@gmail.com');
INSERT INTO nxb VALUES (2,N'NXB Kim Đồng', N'TP. Hồ Chí Minh', '0562896455','nxbkimdong@gmail.com');
GO


---Test
SELECT COUNT(*) FROM nhanvien INNER JOIN congviec ON cv_id = congviec_id WHERE congviec_name =

SELECT donvi.donvi_name, COUNT(std.id) as meo FROM std INNER JOIN donvi ON std.donvi = donvi.Id GROUP BY std.donvi, donvi.donvi_name;

SELECT COUNT(*) FROM ACCOUNT WHERE quyen = 'Teacher';
SELECT COUNT(*) FROM ACCOUNT WHERE quyen = 'Student';
SELECT COUNT(*) FROM ACCOUNT WHERE quyen = 'Manager';
SELECT COUNT(*) FROM ACCOUNT WHERE quyen = 'Library staff';
SELECT COUNT(*) FROM ACCOUNT WHERE quyen = 'Book stacker';

SELECT donvi.donvi_name, COUNT(teacher.id) as meo FROM teacher INNER JOIN donvi ON teacher.donvi = donvi.Id GROUP BY teacher.donvi, donvi.donvi_name;
SELECT congviec.congviec_name, COUNT(id_nv) as meo FROM nhanvien INNER JOIN congviec ON nhanvien.cv_id = congviec.congviec_id GROUP BY cv_id,congviec.congviec_name;

SELECT std.donvi, teacher.donvi, donvi.donvi_name, sum ((COUNT(std.id) COUNT(teacher.id))
FROM donvi INNER JOIN std ON std.donvi = donvi.Id
INNER JOIN teacher ON teacher.donvi = donvi.Id
GROUP BY std.donvi,teacher.donvi, donvi.donvi_name;

Select (std.fname+' '+std.lname) as meo,count(docgia_id) as gau
from MUON INNER JOIN std on MUON.docgia_id = std.id
GROUP BY std.fname, std.lname ORDER BY count(docgia_id) desc;

Select (teacher.fname+' '+teacher.lname) as meo,count(docgia_id) as gau
from MUON INNER JOIN teacher on MUON.docgia_id = teacher.id
GROUP BY teacher.fname, teacher.lname ORDER BY count(docgia_id) desc;

--cho muon
Select (teacher.fname+' '+teacher.lname) as meo,  sum(CHOMUON.sl_cm) as gau
from teacher INNER JOIN CHOMUON on CHOMUON.ngcho_id = teacher.id
GROUP BY teacher.fname, teacher.lname ORDER BY sum(CHOMUON.sl_cm) desc;




SELECT tacgia.tacgia_name, SUM(sach.sl) as meo
FROM sach INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id
GROUP BY tacgia.tacgia_name;

SELECT nxb.nxb_name, SUM(sach.sl) as meo
                    FROM sach INNER JOIN nxb ON sach.nxb_id = nxb.nxb_id
                    GROUP BY nxb.nxb_name;
SELECT sach.ysb, SUM(sach.sl)
                    FROM sach 
                    GROUP BY sach.ysb;

SELECT * FROM std WHERE id = @id;

Select smn.smn_id as N'MÃ SÁCH', sach.name as N'TÊN SÁCH',tacgia.tacgia_name as N'TÊN TÁC GIẢ', nxb.nxb_name as N'TÊN NHÀ XUẤT BẢN', smn.smn_sl as N'TỔNG SỐ LƯỢT MƯỢN'
FROM smn INNER JOIN sach ON smn.smn_id = sach.id INNER JOIN nxb ON sach.nxb_id = nxb.nxb_id INNER JOIN tacgia ON sach.tacgia_id = tacgia.tacgia_id
WHERE smn.smn_sl >= 1
GROUP BY smn.smn_id, sach.name, tacgia.tacgia_name,nxb.nxb_name,smn.smn_sl  ORDER BY smn.smn_sl desc;

Select sach.name, smn.smn_sl
                FROM smn INNER JOIN sach ON smn.smn_id = sach.id
                WHERE smn.smn_sl >= 1
                GROUP BY smn.smn_id, sach.name, smn.smn_sl  ORDER BY smn.smn_sl desc;
SELECT theloai.theloai, SUM(sach.sl) as meo
                    FROM sach INNER JOIN theloai ON sach.theloai = theloai.id
                    GROUP BY sach.theloai, theloai.theloai