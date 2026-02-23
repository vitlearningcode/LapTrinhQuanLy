Use Master
GO
    IF exists(Select name From sys.databases Where name='QLNV' )
    DROP Database QLNV
GO
    Create Database QLNV
GO

USE QLNV;

CREATE TABLE chucvu(
	macv nvarchar(5) primary key,
	tencv nvarchar(50) not null,
	hsphucap float
) 
GO

CREATE TABLE nhanvien(
	manv nvarchar(5) primary key,
	holot nvarchar(50) not null,
	tennv nvarchar(10) not null,
	phai nvarchar(3),
	ngaysinh smalldatetime,
	macv nvarchar(5) not null foreign key(macv) references chucvu(macv)
) 
GO
CREATE TABLE quatrinhluong(
	manv nvarchar(5) not null foreign key(manv) references nhanvien(manv),
	ngaybd smalldatetime,
	hsluong float not null,
	ghichu bit,
	primary key(manv,ngaybd)
)
GO
CREATE TABLE nguoidung(
	ten nvarchar(30) not null primary key,
	matkhau varchar(50),
	quyen tinyint
)
GO

-- Dữ liệu bảng nguoidung
INSERT INTO nguoidung VALUES(N'quantri','e99a18c428cb38d5f260853678922e03',1);	/* Mật khẩu abc123 */
INSERT INTO nguoidung VALUES(N'nhanvien','a906449d5769fa7361d7ecc6aa3f6d28',2);	/* Mật khẩu 123abc */

-- Dữ liệu bảng chucvu
INSERT INTO chucvu VALUES(N'TP',N'Trưởng phòng',0.5);
INSERT INTO chucvu VALUES(N'PP',N'Phó trưởng phòng',0.45);
INSERT INTO chucvu VALUES(N'CV',N'Chuyên viên',0.3);
INSERT INTO chucvu VALUES(N'KT',N'Kế toán',0.25);
INSERT INTO chucvu VALUES(N'LX',N'Lái xe cơ quan',0.25);

-- Dữ liệu bảng nhanvien 
INSERT INTO nhanvien VALUES(N'NV001',N'Nguyễn Phước Minh',N'Tân',N'Nam','1975-04-19',N'TP');
INSERT INTO nhanvien VALUES(N'NV002',N'Hà Thị Thanh',N'Nhàn',N'Nữ','1964-03-09',N'PP');
INSERT INTO nhanvien VALUES(N'NV003',N'Văn Minh',N'Tú',N'Nam','1960-02-15',N'CV');
INSERT INTO nhanvien VALUES(N'NV004',N'Lý Văn',N'Sang',N'Nam','1970-12-21',N'CV');
INSERT INTO nhanvien VALUES(N'NV005',N'Nguyễn Thị Thu',N'An',N'Nữ','1981-08-22',N'PP');
INSERT INTO nhanvien VALUES(N'NV006',N'Nguyễn Thanh',N'Tùng',N'Nam','1977-07-07',N'LX');
INSERT INTO nhanvien VALUES(N'NV007',N'Trần Văn',N'Sơn',N'Nam','1979-07-08',N'CV');
INSERT INTO nhanvien VALUES(N'NV008',N'Cao Thị Ngọc',N'Nhung',N'Nữ','1980-06-19',N'KT');
INSERT INTO nhanvien VALUES(N'NV009',N'Lê Thành',N'Tấn',N'Nam','1984-12-05',N'CV');
INSERT INTO nhanvien VALUES(N'NV010',N'Phan Thị Thủy',N'Tiên',N'Nữ','1987-10-25',N'KT');
GO
-- Dữ liệu bảng qtluong
INSERT INTO quatrinhluong VALUES(N'NV003','2001/01/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2001/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV002','2001/01/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2001/01/01',1.86,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2002/06/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2003/01/01',2.06,0);
INSERT INTO quatrinhluong VALUES(N'NV003','2004/01/01',2.67,0);
INSERT INTO quatrinhluong VALUES(N'NV002','2004/01/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2004/01/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2005/01/01',2.26,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2005/06/01',2.67,0);
INSERT INTO quatrinhluong VALUES(N'NV005','2005/06/01',4.4,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2005/06/01',2.05,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2007/01/01',2.46,0);
INSERT INTO quatrinhluong VALUES(N'NV009','2007/01/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV003','2007/01/01',3,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2007/01/01',5.08,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2007/06/01',2.23,0);
INSERT INTO quatrinhluong VALUES(N'NV005','2008/06/01',4.74,0);
INSERT INTO quatrinhluong VALUES(N'NV004','2008/06/01',3,0);
INSERT INTO quatrinhluong VALUES(N'NV010','2008/06/01',1.86,0);
INSERT INTO quatrinhluong VALUES(N'NV007','2008/06/01',2.34,0);
INSERT INTO quatrinhluong VALUES(N'NV008','2009/01/01',2.66,0);
INSERT INTO quatrinhluong VALUES(N'NV006','2009/06/01',2.41,0);
INSERT INTO quatrinhluong VALUES(N'NV001','2010/01/01',5.42,1);
INSERT INTO quatrinhluong VALUES(N'NV009','2010/01/01',2.67,1);
INSERT INTO quatrinhluong VALUES(N'NV010','2010/06/01',2.06,1);
INSERT INTO quatrinhluong VALUES(N'NV008','2011/01/01',2.86,1);
INSERT INTO quatrinhluong VALUES(N'NV005','2011/06/01',5.08,1);
INSERT INTO quatrinhluong VALUES(N'NV007','2011/06/01',2.67,1);
INSERT INTO quatrinhluong VALUES(N'NV006','2011/06/01',2.59,1);
INSERT INTO quatrinhluong VALUES(N'NV004','2011/06/01',3.33,1);

select * from quatrinhluong;

/*
-- Hướng dẫn Bài tập 1 
-- a. Các nv có mã chức vụ "CV"
select * 
from nhanvien 
where macv=N'CV';

-- b. Các nv tên có ký tự "t"
select * 
from nhanvien 
where tennv like '%t%';

-- c. Các nv sinh trong tháng 8
select * 
from nhanvien
where MONTH(ngaysinh)=8; 

-- d. Các nv có hệ số lương < 3.00
select * 
from nhanvien n, quatrinhluong q
where n.manv = q.manv 
and q.ghichu = 1
and q.hsluong<3;

-- e. Các nv hiện nay không còn công tác nữa
select * 
from nhanvien
where manv not in (	select manv 
					from quatrinhluong
					where ghichu=1 );
					
-- f. Các nv được nâng lương trong năm 2009, 2010
select holot + ' ' + tennv as hoten, hsluong, str(MONTH(ngaybd)) + '-' + str(YEAR(ngaybd),4) as thangnam 
from nhanvien n, quatrinhluong q
where n.manv = q.manv
and (YEAR(ngaybd) = 2009
or YEAR(ngaybd) = 2010);

--g. Tính lương 
select holot + ' ' + tennv as hoten, phai, hsluong*1150000 as tienluong, hsluong*1150000*hsphucap as phucap, hsluong*1150000+hsluong*1150000*hsphucap as thuclinh
from nhanvien n, quatrinhluong q, chucvu c
where n.manv = q.manv and n.macv = c.macv
and ghichu=1;

--h
select tencv, COUNT(*) as sonv
from nhanvien n, chucvu c
where n.macv = c.macv
group by tencv;

--i. Các nhân viên có tuổi nhỏ hơn độ tuổi trung bình
select * 
from nhanvien
where (YEAR(GETDATE())-YEAR(ngaysinh)) < (	select AVG(YEAR(GETDATE())-YEAR(ngaysinh)) 
											from nhanvien);
											
--j. Tổng nv nam, tổng nv nữ
select phai, COUNT(*) as sonv
from nhanvien
group by phai;

--k. Các nhân viên đã được nâng lương >= 3 lần
select * 
from nhanvien
where manv in (	select manv 
				from quatrinhluong 
				group by manv 
				having COUNT(*)>=3);

--l. Sửa tên chức vụ có mã "CV" thành "Nhân viên chuyên trách"
update chucvu
set tencv=N'Nhân viên chuyên trách'
where macv=N'CV';

--k. Xóa các nv hiện nay không còn công tác 
-- (do ràng buộc khóa ngoại nên xóa ở bảng quatrinhluong trước, rồi xóa ở bảng nhanvien sau)  
delete from quatrinhluong
where manv not in (	select manv from quatrinhluong where ghichu=1 );
GO
delete from nhanvien
where manv not in (	select manv from quatrinhluong);
GO
select * from nhanvien;
*/