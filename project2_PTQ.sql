create database project2_PTQ
go
use project2_PTQ
drop database project2_PTQ
CREATE TABLE NHANVIEN (
    Ma_NV CHAR(10) NOT NULL PRIMARY KEY,
    Ho_Ten NCHAR(50) NOT NULL,
    Ngay_Sinh DATE NOT NULL,
    Gioi_Tinh BIT NOT NULL,
    Ma_Phong CHAR(10) NOT NULL,
    SDT CHAR(11) NULL,
    Dia_Chi NCHAR(50) NULL,
    Email NCHAR(50) NOT NULL,
    Ngay_Lam DATE NOT NULL,
    Ma_chuc_vu INT NULL,
    FOREIGN KEY (Ma_Phong) REFERENCES PHONGBAN(Ma_phong),
    FOREIGN KEY (Ma_chuc_vu) REFERENCES CHUCVU(Ma_CV)
);
CREATE TABLE PHONGBAN (
    Ma_phong CHAR(10) NOT NULL PRIMARY KEY,
    Ten_Phong NCHAR(100) NOT NULL,
    Ma_QL INT NULL,
   
);
CREATE TABLE CHUCVU (
    Ma_CV INT NOT NULL PRIMARY KEY,
    Ten_CV CHAR(100) NOT NULL,
    Luong_CB DECIMAL(10,2) NOT NULL
);
CREATE TABLE TAIKHOAN (
    Ma_TK INT NOT NULL PRIMARY KEY,
    Ten_Dang_Nhap VARCHAR(50) NOT NULL,
    Mat_Khau VARCHAR(255) NOT NULL,
    Ma_NV CHAR(10) NOT NULL,
    Ma_VT INT NOT NULL,
    FOREIGN KEY (Ma_NV) REFERENCES NHANVIEN(Ma_NV),
    FOREIGN KEY (Ma_VT) REFERENCES VAITRO_QUYEN(Ma_VT)
);
CREATE TABLE VAITRO_QUYEN (
    Ma_VT INT NOT NULL PRIMARY KEY,
    Ten_VT VARCHAR(50) NOT NULL,
    Ma_Quyen INT NOT NULL
);

select*from NHANVIEN;
select*from PHONGBAN;
select*from CHUCVU;
select*from VAITRO_QUYEN;
select*from TAIKHOAN;

drop table NHANVIEN;
drop table PHONGBAN;
drop table VAITRO_QUYEN;
drop table CHUCVU;
drop table TAIKHOAN;

INSERT INTO PHONGBAN (Ma_phong, Ten_Phong, Ma_QL)VALUES 
	('P001', N'Phòng Nhân Sự', NULL),
	('P002', N'Phòng Kế Toán', NULL),
	('P003', N'Phòng IT', NULL);
INSERT INTO CHUCVU (Ma_CV, Ten_CV, Luong_CB)VALUES 
	(1, N'Nhân Viên', 5000000),
	(2, N'Trưởng Phòng', 10000000),
	(3, N'Giám Đốc', 20000000);
INSERT INTO VAITRO_QUYEN (Ma_VT, Ten_VT, Ma_Quyen)VALUES 
	(1, N'Quản trị viên', 101),
	(2, N'Người dùng', 102),
	(3, N'Khách', 103);
INSERT INTO NHANVIEN (Ma_NV, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_Phong, SDT, Dia_Chi, Email, Ngay_Lam, Ma_chuc_vu)VALUES 
	('NV001', N'Phạm Thế Quyền', '2004-11-14', 1, 'P001', '0123456789', N'123 Đường nguyễn trãi, TP. HCM', N'thequyen700@gmail.com', '2020-01-15', 1),
	('NV002', N'Lê Thị Bích Phương', '1985-11-20', 0, 'P002', '0987654321', N'456 Đường lê trọng tấn, Hà Nội', N'lephuong@gmail.com', '2019-03-12', 2),
	('NV003', N'Trần Văn Cảnh', '1992-07-22', 1, 'P003', '0912345678', N'789 Đường lê duẩn, Đà Nẵng', N'trancanh@gmail.com', '2021-06-20', 3);
INSERT INTO TAIKHOAN (Ma_TK, Ten_Dang_Nhap, Mat_Khau, Ma_NV, Ma_VT)VALUES 
	(1, 'phamthequyen', 'password123', 'NV001', 1),
	(2, 'lethibichphuong', 'password456', 'NV002', 2),
	(3, 'tranvancanh', 'password789', 'NV003', 3);


	