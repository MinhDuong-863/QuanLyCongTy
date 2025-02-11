CREATE DATABASE QLCT
GO

USE QLCT
GO

CREATE TABLE dbo.MucLuong(
	MaLuong varchar(10) PRIMARY KEY,
	ChucVu nvarchar(50),
	MucLuong int NOT NULL 
)
GO

INSERT INTO MucLuong VALUES('MLNV01',N'Nhân viên Mới',10000000)--NhanVienMoi
INSERT INTO MucLuong VALUES('MLNV02',N'Nhân viên 5 năm',15000000)--NhanVienVua
INSERT INTO MucLuong VALUES('MLNV03',N'Nhân viên 10 năm',20000000)--NhanVienLauNam
INSERT INTO MucLuong VALUES('MLTP01',N'Trưởng phòng',50000000)--TruongPhong
INSERT INTO MucLuong VALUES('MLQL01',N'Quản lý',40000000)--QuanLy
GO

CREATE TABLE dbo.NhanVien(
	MaNV varchar(10) PRIMARY KEY,
	HoTenNV nvarchar(50),
	DiaChi nvarchar(50) NULL,
	Sdt varchar(12) UNIQUE,	
	NgaySinh date,
	Phai nvarchar(10),
	Cccd varchar(20) UNIQUE,
	Email varchar(25) UNIQUE,
	MaPB varchar(10) NULL,
	MaLuong varchar(10) REFERENCES MucLuong(MaLuong)
)
GO

INSERT INTO NhanVien VALUES('NV000', N'Nguyễn Thành Đạt', 'HCM', '0337433171', '1988-05-01', 'Nam', '066586432890', 'NTD@gmail.com', 'PBHR1', 'MLTP01')

INSERT INTO NhanVien VALUES('NV001', N'Trần Minh Dương', 'HCM', '0967675782', '1988-01-01', 'Nam', '092203232432', 'TMD@gmail.com', 'PBQL1', 'MLTP01')
INSERT INTO NhanVien VALUES('NV002', N'Nguyễn Thanh Tùng', 'HCM', '0966696084', '1989-02-02', 'Nam', '095121551722', 'NTT@gmail.com', 'PBQL1', 'MLQL01')
INSERT INTO NhanVien VALUES('NV003', N'Lê Minh Hùng', 'HCM', '0986810782', '1988-03-03', 'Nam', '093501761895', 'LMH@gmail.com', 'PBQL1', 'MLQL01')

INSERT INTO NhanVien VALUES('NV004', N'Phạm Hoài Sơn', 'HCM', '0923232323', '1989-04-04', 'Nam', '098968366861', 'PHS@gmail.com', 'PBSX1', 'MLTP01')
INSERT INTO NhanVien VALUES('NV005', N'Trần Phương Đài', 'HCM', '0986865482', '1988-05-05', N'Nữ', '098353536799', 'TPD@gmail.com', 'PBSX1', 'MLNV02')
INSERT INTO NhanVien VALUES('NV006', N'Đỗ Đăng Khoa', 'HCM', '0929192796', '1989-06-06', 'Nam', '090107287746', 'DDK@gmail.com', 'PBSX1', 'MLNV01')
INSERT INTO NhanVien VALUES('NV007', N'Đinh Mạnh Ninh', 'HCM', '0917934709', '1988-01-01', 'Nam', '091408184282', 'DMN@gmail.com', 'PBSX1', 'MLNV01')
INSERT INTO NhanVien VALUES('NV008', N'Hà Minh Khôi', 'HCM', '0989886825', '1980-04-11', 'Nam', '094617396327', 'HMK@gmail.com', 'PBSX1', 'MLNV02')

INSERT INTO NhanVien VALUES('NV009', N'Chu Tiểu My', 'HCM', '0986539548', '1988-05-22', N'Nữ', '093461146718', 'CTM@gmail.com', 'PBMK1', 'MLTP01')
INSERT INTO NhanVien VALUES('NV010', N'Phan Diễm My', 'HCM', '0917449142', '1985-12-01', N'Nữ', '092631050324', 'PNM@gmail.com', 'PBMK1', 'MLNV01')
INSERT INTO NhanVien VALUES('NV011', N'Hồ Hoài Anh', 'HCM', '0913632520', '1982-11-21', 'Nam', '093223966609', 'HHA@gmail.com', 'PBMK1', 'MLNV02')

INSERT INTO NhanVien VALUES('NV012', N'Đỗ Hồng Đăng', 'HCM', '0929192790', '1989-06-06', 'Nam', '090107287743', 'DHD@gmail.com', 'PBHC1', 'MLTP01')
INSERT INTO NhanVien VALUES('NV013', N'Đinh Mạnh Quỳnh', 'HCM', '0917934700', '1988-01-01', 'Nam', '091408184283', 'DMQ@gmail.com', 'PBHC1', 'MLNV01')
INSERT INTO NhanVien VALUES('NV014', N'Nguyễn Quang Huy', 'HCM', '0989886820', '1980-04-11', 'Nam', '094617396323', 'NQH@gmail.com', 'PBHC1', 'MLNV01')

INSERT INTO NhanVien VALUES('NV015', N'Chu Hà My', 'HCM', '0986539540', '1988-05-22', N'Nữ', '093461146713', 'CHN@gmail.com', 'PBTK1', 'MLTP01')
INSERT INTO NhanVien VALUES('NV016', N'Phan Diễm Quỳnh', 'HCM', '0917449140', '1985-12-01', N'Nữ', '092631050323', 'PDQ@gmail.com', 'PBTK1', 'MLNV02')
INSERT INTO NhanVien VALUES('NV017', N'Hồ Ngọc Hà', 'HCM', '0913632527', '1982-11-21', 'Nam', '093223966603', 'HNH@gmail.com', 'PBTK1', 'MLNV02')
INSERT INTO NhanVien VALUES('NV018', N'Nguyễn Văn An', 'HCM', '0746073259', '1997-10-31', 'Nam', '154787264396', 'NVA@gmail.com', 'PBTK1', 'MLQL01')

INSERT INTO NhanVien VALUES('NV019', N'Trần Thị Bình', 'HCM', '0889976697', '1988-12-02', N'Nữ', '826935401258', 'TTB@gmail.com', 'PBMK1', 'MLQL01')
INSERT INTO NhanVien VALUES('NV020', N'Lê Thị Cẩm', 'HCM', '0859913781', '1984-03-20', N'Nữ', '712356985210', 'LTC@gmail.com', 'PBMK1', 'MLQL01')

INSERT INTO NhanVien VALUES('NV021', N'Phạm Văn Chung', 'HCM', '0576358267', '1989-06-12', 'Nam', '930176438205', 'PVC@gmail.com', 'PBSX2', 'MLTP01')
INSERT INTO NhanVien VALUES('NV022', N'Đỗ Thị Diệu', 'HCM', '0976678493', '1997-01-18', N'Nữ', '280176490523', 'DTD@gmail.com', 'PBSX2', 'MLNV01')
INSERT INTO NhanVien VALUES('NV023', N'Hoàng Văn Đức', 'HCM', '0620663481', '1995-02-16', 'Nam', '437690231567', 'HVD@gmail.com', 'PBSX2', 'MLNV01')
INSERT INTO NhanVien VALUES('NV024', N'Vũ Thị Dung', 'HCM', '0524552217', '1992-09-20', N'Nữ', '378569103245', 'VTD@gmail.com', 'PBSX2', 'MLNV01')
INSERT INTO NhanVien VALUES('NV025', N'Nguyễn Thanh Giang', 'HCM', '0409534097', '1990-08-21', 'Nam', '609234785019', 'NTG@gmail.com', 'PBSX2', 'MLNV02')

INSERT INTO NhanVien VALUES('NV026', N'Trần Văn Hải', 'HCM', '0455002709', '1991-11-08', 'Nam', '821309486743', 'TVH@gmail.com', 'PBMK2', 'MLTP01')
INSERT INTO NhanVien VALUES('NV027', N'Lê Thị Hoa', 'HCM', '0905942943', '1994-12-10', N'Nữ', '123456789012', 'LTH@gmail.com', 'PBMK2', 'MLNV01')
INSERT INTO NhanVien VALUES('NV028', N'Phạm Văn Hùng', 'HCM', '0347488347', '1986-06-28', 'Nam', '908765432109', 'PVH@gmail.com', 'PBMK2', 'MLNV02')

INSERT INTO NhanVien VALUES('NV029', N'Trần Văn Quyền', 'HCM', '0528481797', '1985-06-27', 'Nam', '345678901234', 'TVQ@gmail.com', 'PBHC2', 'MLTP01')
INSERT INTO NhanVien VALUES('NV030', N'Lê Văn Khanh', 'HCM', '0708491837', '1983-07-10', 'Nam', '987654321098', 'LVK@gmail.com', 'PBHC2', 'MLNV02')
INSERT INTO NhanVien VALUES('NV031', N'Phạm Thị Kim', 'HCM', '0882439281', '1999-04-11', N'Nữ', '567890123456', 'PTK@gmail.com', 'PBHC2', 'MLNV01')

INSERT INTO NhanVien VALUES('NV032', N'Trần Văn Lợi', 'HCM', '0746627117', '1998-10-26', 'Nam', '654321098765', 'TVL@gmail.com', 'PBTK2', 'MLTP01')
INSERT INTO NhanVien VALUES('NV033', N'Đỗ Thị Thu', 'HCM', '0993265811', '1985-01-13', N'Nữ', '876543210987', 'DTT@gmail.com', 'PBTK2', 'MLNV03')
INSERT INTO NhanVien VALUES('NV034', N'Hoàng Văn Thúy', 'HCM', '0387905127', '1978-09-25', N'Nữ', '432109876543', 'HVT@gmail.com', 'PBTK2', 'MLNV03')

CREATE TABLE dbo.LoaiPhongBan(
	MaLPB varchar(10) PRIMARY KEY,
	TenLPB nvarchar(30)
) 

INSERT INTO LoaiPhongBan VALUES('LPBQL', N'Quản Lý')
INSERT INTO LoaiPhongBan VALUES('LPBSX', N'Sản Xuất')
INSERT INTO LoaiPhongBan VALUES('LPBMK', N'Marketing')
INSERT INTO LoaiPhongBan VALUES('LPBHC', N'Hành Chính')
INSERT INTO LoaiPhongBan VALUES('LPBTK', N'Thiết Kế')
INSERT INTO LoaiPhongBan VALUES('LPBHR', N'Nhân Sự')

CREATE TABLE dbo.PhongBan(
	MaPB varchar(10) PRIMARY KEY,
	TenPB nvarchar(30) ,
	MaLPB varchar(10) REFERENCES LoaiPhongBan(MaLPB),
	MaTrPhong varchar(10) REFERENCES NhanVien(MaNV),
	ViTri nvarchar(40) NULL,
)
GO

INSERT INTO PhongBan VALUES('PBQL1', N'Phòng Quản Lý', 'LPBQL','NV001','A5201')
INSERT INTO PhongBan VALUES('PBSX1', N'Phòng Sản Xuất 1','LPBSX','NV004','A5202')
INSERT INTO PhongBan VALUES('PBSX2', N'Phòng Sản Xuất 2','LPBSX','NV021','A5202')
INSERT INTO PhongBan VALUES('PBMK1', N'Phòng Marketing 1','LPBMK','NV009','A5102')
INSERT INTO PhongBan VALUES('PBMK2', N'Phòng Marketing 2','LPBMK','NV026','A5102')
INSERT INTO PhongBan VALUES('PBHC1', N'Phòng Hành Chính 1','LPBHC','NV012','A5302')
INSERT INTO PhongBan VALUES('PBHC2', N'Phòng Hành Chính 2','LPBHC','NV029','A5302')
INSERT INTO PhongBan VALUES('PBTK1', N'Phòng Thiết Kế 1','LPBTK','NV015','A5402')
INSERT INTO PhongBan VALUES('PBTK2', N'Phòng Thiết Kế 2','LPBTK','NV032','A5402')
INSERT INTO PhongBan VALUES('PBHR1', N'Phòng Nhân Sự','LPBHR','NV000','A5000')
GO

ALTER TABLE NhanVien WITH CHECK ADD FOREIGN KEY(MaPB) REFERENCES PhongBan(MaPB)

CREATE TABLE dbo.TaiKhoan(
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	TK varchar(30),
	MK varchar(30),
	PRIMARY KEY(MaNV)
)
GO
INSERT INTO TaiKhoan VALUES('NV000','hr','hr123')
INSERT INTO TaiKhoan VALUES('NV001','tmd','tmd123')
INSERT INTO TaiKhoan VALUES('NV002','ntt','ntt123')
INSERT INTO TaiKhoan VALUES('NV003','lmh','ntt123')
INSERT INTO TaiKhoan VALUES('NV004','phs','phs123')
INSERT INTO TaiKhoan VALUES('NV005','tpd','tpd123')
INSERT INTO TaiKhoan VALUES('NV006','ddk','ddk123')
INSERT INTO TaiKhoan VALUES('NV007','dmn','dmn123')
INSERT INTO TaiKhoan VALUES('NV008','hmk','hmk123')
INSERT INTO TaiKhoan VALUES('NV009','ctm','ctm123')
INSERT INTO TaiKhoan VALUES('NV010','pdm','pdm123')
INSERT INTO TaiKhoan VALUES('NV011','hha','hha123')
INSERT INTO TaiKhoan VALUES('NV012','dhd','dhd123')
INSERT INTO TaiKhoan VALUES('NV013','dmq','dmq123')
INSERT INTO TaiKhoan VALUES('NV014','nqh','nqh123')
INSERT INTO TaiKhoan VALUES('NV015','chn','chn123')
INSERT INTO TaiKhoan VALUES('NV016','pdq','pdq123')
INSERT INTO TaiKhoan VALUES('NV017','hnh','hnh123')

INSERT INTO TaiKhoan VALUES('NV018','nva','nva123')
INSERT INTO TaiKhoan VALUES('NV019','ttb','ttb123')
INSERT INTO TaiKhoan VALUES('NV020','ltc','ltc123')
INSERT INTO TaiKhoan VALUES('NV021','pvc','pvc123')
INSERT INTO TaiKhoan VALUES('NV022','dtd','dtd123')
INSERT INTO TaiKhoan VALUES('NV023','hvd','hvd123')
INSERT INTO TaiKhoan VALUES('NV024','vtd','vdt123')
INSERT INTO TaiKhoan VALUES('NV025','ntg','ntg123')
INSERT INTO TaiKhoan VALUES('NV026','tvh','tvh123')
INSERT INTO TaiKhoan VALUES('NV027','lth','lth123')
INSERT INTO TaiKhoan VALUES('NV028','pvh','pvh123')
INSERT INTO TaiKhoan VALUES('NV029','tvh','tvh123')
INSERT INTO TaiKhoan VALUES('NV030','lvk','lvk123')
INSERT INTO TaiKhoan VALUES('NV031','ptk','ptk123')
INSERT INTO TaiKhoan VALUES('NV032','tvl','tvl123')
INSERT INTO TaiKhoan VALUES('NV033','dtt','dtt123')
INSERT INTO TaiKhoan VALUES('NV034','hvt','hvt123')

GO

CREATE TABLE dbo.Checkin(

	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	NgayCheckin date,
	GioCheckin time,
	PRIMARY KEY(MaNV,NgayCheckin)
)
GO

INSERT INTO Checkin VALUES('NV001','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV001','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV001','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV002','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV003','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV004','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV005','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV006','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV007','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV008','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV009','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV010','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV011','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV012','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV013','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV014','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV015','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV016','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV017','2023-03-03', '07:50:00')


INSERT INTO Checkin VALUES('NV018','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV019','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV020','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV021','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV022','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV023','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV024','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV025','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV026','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV027','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV028','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV029','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV030','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV031','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV032','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV033','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV034','2023-03-01', '07:50:00')
INSERT INTO Checkin VALUES('NV018','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV019','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV020','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV021','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV022','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV023','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV024','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV025','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV026','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV027','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV028','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV029','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV030','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV031','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV032','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV033','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV034','2023-03-02', '07:50:00')
INSERT INTO Checkin VALUES('NV018','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV019','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV020','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV022','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV023','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV024','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV025','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV026','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV027','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV028','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV029','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV030','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV031','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV032','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV033','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV034','2023-03-03', '07:50:00')
INSERT INTO Checkin VALUES('NV021','2023-03-03', '07:50:00')

GO

CREATE TABLE dbo.Checkout(
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	NgayCheckout date,
	GioCheckout time
	PRIMARY KEY(MaNV,NgayCheckout)
)
GO
INSERT INTO Checkout VALUES('NV001','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV001','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV001','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV002','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV003','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV004','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV005','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV006','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV007','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV008','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV009','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV010','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV011','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV012','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV013','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV014','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV015','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV016','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV017','2023-03-03', '17:10:00')

INSERT INTO Checkout VALUES('NV018','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV019','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV020','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV021','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV022','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV023','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV024','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV025','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV026','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV027','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV028','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV029','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV030','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV031','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV032','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV033','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV034','2023-03-01', '17:10:00')
INSERT INTO Checkout VALUES('NV018','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV019','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV020','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV021','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV022','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV023','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV024','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV025','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV026','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV027','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV028','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV029','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV030','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV031','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV032','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV033','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV034','2023-03-02', '17:10:00')
INSERT INTO Checkout VALUES('NV018','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV019','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV020','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV021','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV022','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV023','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV024','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV025','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV026','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV027','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV028','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV029','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV030','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV031','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV032','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV033','2023-03-03', '17:10:00')
INSERT INTO Checkout VALUES('NV034','2023-03-03', '17:10:00')
GO

CREATE TABLE dbo.XinNghi(
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	NgayNghi datetime,
	SoNgayNghi int,
	LyDo nvarchar(100),
	HeSoDuyet int NOT NULL,
	PRIMARY KEY(MaNV,NgayNghi)
)
GO

select *from XinNghi
INSERT INTO XinNghi VALUES('NV004', '2023-04-05', '1', N'Lý do sức khỏe', '-1')
INSERT INTO XinNghi VALUES('NV009', '2023-04-10', '1', N'Chuyển nhà, chuyển trọ', '1')

INSERT INTO XinNghi VALUES('NV010', '2023-04-10', '1', N'Chuyển nhà, chuyển trọ', '0')
INSERT INTO XinNghi VALUES('NV004', '2023-04-10', '1', N'Chuyển nhà, chuyển trọ', '1')
GO

CREATE TABLE dbo.CongViec(
	MaCV varchar(10) PRIMARY KEY,
	TenCV nvarchar(50),
	MaLPB varchar(10) REFERENCES LoaiPhongBan(MaLPB),
)
GO

INSERT INTO CongViec VALUES('CVSX001', N'Kiểm tra hoạt động của máy móc', 'LPBSX')
INSERT INTO CongViec VALUES('CVSX002', N'Lập báo cáo theo dõi, thống kê sản xuất', 'LPBSX')
INSERT INTO CongViec VALUES('CVSX003', N'Quản lý sản xuất', 'LPBSX')
INSERT INTO CongViec VALUES('CVSX004', N'Đánh giá, kiểm định sản phẩm', 'LPBSX')
INSERT INTO CongViec VALUES('CVMK001', N'Nghiên cứu thị trường', 'LPBMK')
INSERT INTO CongViec VALUES('CVMK002', N'Hoạch định sản phẩm, giá', 'LPBMK')
INSERT INTO CongViec VALUES('CVMK003', N'Phân phối sản phẩm', 'LPBMK')
INSERT INTO CongViec VALUES('CVMK004', N'Tiếp thị, quản lý thương hiệu', 'LPBMK')
INSERT INTO CongViec VALUES('CVMK005', N'Sáng tạo thông điệp', 'LPBMK')
INSERT INTO CongViec VALUES('CVHC001', N'Quản lý BHXH, BHYT', 'LPBHC')
INSERT INTO CongViec VALUES('CVHC002', N'Đăng ký bản quyền thương hiệu', 'LPBHC')
INSERT INTO CongViec VALUES('CVHC003', N'Quản lý hồ sơ pháp lý', 'LPBHC')
INSERT INTO CongViec VALUES('CVHC004', N'Tổ chức tuyển dụng', 'LPBHC')
INSERT INTO CongViec VALUES('CVTK001', N'Thiết kế sản phẩm: bao bì, nhãn mác, hình ảnh', 'LPBTK')
INSERT INTO CongViec VALUES('CVTK002', N'Thiết kế logo', 'LPBTK')
INSERT INTO CongViec VALUES('CVTK003', N'Lên ý tưởng thiết kế', 'LPBTK')
INSERT INTO CongViec VALUES('CVTK004', N'Kiểm định thiết kế', 'LPBTK')


CREATE TABLE dbo.DuAn(
	MaDA varchar(10) PRIMARY KEY,
	TenDuAn nvarchar(50),
	MoTa nvarchar(200) NULL,
	MaPB varchar(10) REFERENCES PhongBan(MaPB),
	DiaDiem nvarchar(40) NULL,
	NgayBD date,
	DeadLine date,
	DanhGia nvarchar(200) NULL,
	ChamDiem int NULL,
	Thuong bigint NULL
)
GO

INSERT INTO DuAn
VALUES('DA001',N'Thiết kế nhãn nước trái cây', N'Làm nổi bật vị của nước ngọt'+ CHAR(13)+CHAR(10)+ N'Màu sắc dễ chú ý','PBTK1', N'Công ty','2000-01-15', '2000-03-02',N'Hoàn Thành Tốt',100,10000000)
INSERT INTO DuAn
VALUES('DA002',N'Đăng ký bản quyền nước trái cây', N'Có chữ ký của Ủy bản kiểm định chất lượng sản phẩm ','PBHC1', N'Công ty', '2000-01-15', '2000-03-02',N'Trễ Hạn 1 tháng ',20,0)
INSERT INTO DuAn
VALUES('DA003',N'Thiết kết và thi công dây chuyền SX nước trái cây', N'Kinh phí dưới 10 tỷ'+ CHAR(13)+CHAR(10)+ N'Đáp ứng 10000 chai 1 ngày','PBSX1', N'Nhà máy số 1', '2000-02-15', '2000-08-02',N'Hoàn Thành',80,100000000)
INSERT INTO DuAn
VALUES('DA004',N'Làm video quảng cáo nước trái cây', N'Video đăng trên titok'+ CHAR(13)+CHAR(10)+ N'Thuê tiktoker','PBMK1', N'Công ty', '2000-03-05', '2000-08-02',N'Hoàn Thành Tốt',100,10000000)
INSERT INTO DuAn
VALUES('DA005',N'Chỉnh sửa logo công ty', N'Bo góc logo cũ','PBTK2', N'Công Ty','2023-01-15', '2023-05-03','',-1,0)
INSERT INTO DuAn
VALUES('DA006',N'Quảng bá logo mới', N'Công khai số tiền thiết kế logo là 7 tỷ','PBMK2', N'Công ty', '2023-02-01', '2023-05-03','',-1,0)
GO


CREATE TABLE dbo.PhanCong(
	MaDA varchar(10) REFERENCES DuAn(MaDA) ON DELETE CASCADE,
	MaCV varchar(10) REFERENCES CongViec(MaCV) ON DELETE CASCADE,
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	MoTa nvarchar(200) NULL,
	NgayBD date,
	DeadLine date,
	TienDo int,
	Danhgia nvarchar(50) NULL,
	ChamDiem int NULL,
	TienThuong int NULL,
	PRIMARY KEY(MaDA,MaCV)
)
GO

INSERT INTO PhanCong VALUES('DA001','CVTK003','NV016',N'Làm giao diện', '2000-01-20','2000-01-25',100, N'Hoàn Thành Tốt', 100, 500000)
INSERT INTO PhanCong VALUES('DA001','CVTK001','NV017',N'Tìm kiếm hình ảnh','2000-01-25','2000-02-05',100, N'Hoàn Thành Tốt', 100, 1000000)
INSERT INTO PhanCong VALUES('DA001','CVTK004','NV018',N'Tìm kiếm hình ảnh','2000-02-05','2000-02-07',100, N'Hoàn Thành Tốt', 100,2000000)

INSERT INTO PhanCong VALUES('DA002','CVHC002','NV013',N'Chuẩn bị giấy tờ','2000-01-20','2000-02-20',100, N'Trễ Hạn 2 Ngày', 40, 0)
INSERT INTO PhanCong VALUES('DA002','CVHC003','NV014',N'Đưa đến trung tâm đăng kiểm','2000-02-10','2000-02-20',100, N'Trễ Hạn 1 Ngày', 80,0)

INSERT INTO PhanCong VALUES('DA003','CVSX001','NV005',N'Chuẩn bị nguyên liệu','2000-02-20','2000-02-25',100, N'Hoàn Thành Tốt', 100, 0)
INSERT INTO PhanCong VALUES('DA003','CVSX002','NV006',N'Kiểm tra máy móc','2000-02-25','2000-03-05',100, N'Hoàn Thành Tốt', 100,0)
INSERT INTO PhanCong VALUES('DA003','CVSX003','NV007',N'Điều hành nhân viên','2000-03-05','2000-03-07',100, N'Hoàn Thành Tốt', 100, 0)
INSERT INTO PhanCong VALUES('DA003','CVSX004','NV008',N'Vận hành máy','2000-03-05','2000-03-07',100, N'Trễ Hạn 2 Ngày', 40,0)

INSERT INTO PhanCong VALUES('DA004','CVMK005','NV010',N'Liên hệ đài truyền hình','2000-03-07','2000-03-20',100, N'Hoàn Thành Tốt', 100, 100000)
INSERT INTO PhanCong VALUES('DA004','CVMK004','NV011',N'Liên hệ KOL','2000-03-20','2000-04-25',100, N'Hoàn Thành Tốt', 100,100000)
INSERT INTO PhanCong VALUES('DA004','CVMK003','NV019',N'Làm video quảng cáo','2000-03-20','2000-04-25',100, N'Hoàn Thành Tốt', 100,200000)

INSERT INTO PhanCong VALUES('DA005','CVTK002','NV033',N'Edit video','2023-01-20','2023-02-01',50, '', 0,0)
INSERT INTO PhanCong VALUES('DA005','CVTK004','NV034',N'Demo bản vẽ','2023-02-01','2023-02-02',70, '', 0,0)

INSERT INTO PhanCong VALUES('DA006','CVMK002','NV027',N'Chạy quảng cáo trên Facebook','2023-02-02','2023-02-05',50, '', 0,0)
INSERT INTO PhanCong VALUES('DA006','CVMK004','NV028',N'Chạy quảng cáo trên Tiktok','2023-02-05','2023-02-20',60, '', 0,0)
GO

CREATE TABLE dbo.HoTro(
	MaDA varchar(10) NOT NULL,
	MaCV varchar(10) NOT NULL,
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	FOREIGN KEY(MaDA,MaCV) REFERENCES PhanCong(MaDa,MaCV) ON DELETE CASCADE,
	PRIMARY KEY(MaDA,MaCV,MaNV)
)
GO

INSERT INTO HoTro VALUES('DA002','CVHC003','NV030')
INSERT INTO HoTro VALUES('DA003','CVSX001','NV022')
INSERT INTO HoTro VALUES('DA003','CVSX002','NV023')
INSERT INTO HoTro VALUES('DA003','CVSX003','NV024')
INSERT INTO HoTro VALUES('DA003','CVSX003','NV025')
INSERT INTO HoTro VALUES('DA005','CVTK002','NV017')
GO

CREATE TABLE dbo.Luong(
	MaNV varchar(10) REFERENCES NhanVien(MaNV),
	ThangNam date,
	Luong int,
	PRIMARY KEY(MaNV,ThangNam)
)
GO