CREATE DATABASE QLTHIETBI
GO

USE QLTHIETBI
GO

-- Tạo bảng KhuVuc
CREATE TABLE KhuVuc (
  MaKhuVuc varchar(10) PRIMARY KEY,
  TenKhuVuc VARCHAR(25)
);

-- Tạo bảng ToaNha
CREATE TABLE ToaNha (
  MaToaNha varchar(10) PRIMARY KEY,
  TenToaNha VARCHAR(25),
  MaKhuVuc varchar(10),
  FOREIGN KEY (MaKhuVuc) REFERENCES KhuVuc(MaKhuVuc)
);

-- Tạo bảng Tang
CREATE TABLE Tang (
  MaTang varchar(10) PRIMARY KEY,
  TenTang VARCHAR(25),
  MaToaNha varchar(10),
  FOREIGN KEY (MaToaNha) REFERENCES ToaNha(MaToaNha)
);

-- Tạo bảng PhongHoc
CREATE TABLE PhongHoc (
  MaPhongHoc varchar(10) PRIMARY KEY,
  TenPhongHoc VARCHAR(25),
  MaTang varchar(10),
  FOREIGN KEY (MaTang) REFERENCES Tang(MaTang)
);

-- Tạo bảng ThietBi
CREATE TABLE ThietBi (
  MaThietBi varchar(10) PRIMARY KEY,
  TenThietBi NVARCHAR(25),
  MaPhongHoc varchar(10),
  TinhTrang NVARCHAR(25),
  NgayCapNhatNhanVien DATE,
  ThongBaoGiaoVien NVARCHAR(25),
  NgayCapNhatGiaoVien DATE,
  FOREIGN KEY (MaPhongHoc) REFERENCES PhongHoc(MaPhongHoc)
);

-- Tạo bảng PhanMem
CREATE TABLE PhanMem (
  MaPhanMem varchar(10) PRIMARY KEY,
  TenPhanMem VARCHAR(25)
);

-- Tạo bảng MayTinh
CREATE TABLE MayTinh (
  MaThietBi varchar(10) PRIMARY KEY,
  Window VARCHAR(255),
  PhanCung1 VARCHAR(25),
  PhanCung2 VARCHAR(25),
  PhanCung3 VARCHAR(25),
  FOREIGN KEY (MaThietBi) REFERENCES ThietBi(MaThietBi)
);

-- Tạo bảng MayTinh_PhanMem
CREATE TABLE MayTinh_PhanMem (
  MaThietBi varchar(10),
  MaPhanMem varchar(10),
  PhienBan varchar(10),
  PRIMARY KEY (MaThietBi, MaPhanMem),
  FOREIGN KEY (MaThietBi) REFERENCES MayTinh(MaThietBi),
  FOREIGN KEY (MaPhanMem) REFERENCES PhanMem(MaPhanMem)
);

-- Tạo bảng TaiKhoan
CREATE TABLE TaiKhoan (
  TenTaiKhoan VARCHAR(10) PRIMARY KEY, 
  MatKhau VARCHAR(25),
  LoaiTaiKhoan VARCHAR(20)
);

-- Tạo bảng GiaoVien
CREATE TABLE GiaoVien (
  ID varchar(10) PRIMARY KEY,
  Ten VARCHAR(25),
  SDT VARCHAR(20),
  Email VARCHAR(25),
  TenTaiKhoan VARCHAR(10),
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
  ID varchar(10) PRIMARY KEY,
  Ten VARCHAR(25),
  SDT VARCHAR(20),
  Email VARCHAR(25),
  TenTaiKhoan VARCHAR(10), 
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)
);

-- Tạo bảng QuanLy
CREATE TABLE QuanLy (
  ID varchar(10) PRIMARY KEY,
  Ten VARCHAR(25),
  SDT VARCHAR(20),
  Email VARCHAR(255),
  TenTaiKhoan VARCHAR(10), 
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan)
);

-- Tạo bảng QuyenTruyCap cho GV
CREATE TABLE QuyenTruyCapGV (
  TenTaiKhoan varchar(10),
  MaPhongHoc varchar(10),
  LoaiTaiKhoan varchar(20),
  PRIMARY KEY (TenTaiKhoan, MaPhongHoc),
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan),
  FOREIGN KEY (MaPhongHoc) REFERENCES PhongHoc(MaPhongHoc)
);

-- Tạo bảng QuyenTruyCap cho NV
CREATE TABLE QuyenTruyCapNV (
  TenTaiKhoan varchar(10),
  MaToaNha varchar(10),
  LoaiTaiKhoan varchar(20),
  PRIMARY KEY (TenTaiKhoan, MaToaNha),
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan),
  FOREIGN KEY (MaToaNha) REFERENCES ToaNha(MaToaNha)
);


-- Tạo bảng YeuCauThietBi
CREATE TABLE YeuCauThietBi (
  MaYeuCau varchar(10) PRIMARY KEY,
  TenThietBi NVARCHAR(25),
  MaPhongHoc varchar(10),
  TinhTrang NVARCHAR(25),
  NgayCapYeuCau DATE,
  Window VARCHAR(255),
  PhanCung1 VARCHAR(25),
  PhanCung2 VARCHAR(25),
  PhanCung3 VARCHAR(25),
  TenPhanMem VARCHAR(25),
  TenTaiKhoan VARCHAR(10), 
  FOREIGN KEY (TenTaiKhoan) REFERENCES TaiKhoan(TenTaiKhoan),
  FOREIGN KEY (MaPhongHoc) REFERENCES PhongHoc(MaPhongHoc)
);


CREATE TABLE TamGhiNho (
  TenTaiKhoan VARCHAR(10) PRIMARY KEY,
  MatKhau VARCHAR(25),
);


-- Dữ liệu cho bảng KhuVuc
INSERT INTO KhuVuc (MaKhuVuc, TenKhuVuc) VALUES

('B', 'Khu B'),
('N', 'Khu N');

-- Dữ liệu cho bảng ToaNha
INSERT INTO ToaNha (MaToaNha, TenToaNha, MaKhuVuc) VALUES

('B1', 'B1', 'B'),
('B2', 'B2', 'B'),
('N1', 'N1', 'N');


-- Dữ liệu cho bảng Tang
INSERT INTO Tang (MaTang, TenTang, MaToaNha) VALUES
('B1.1', 'Tầng B1.1', 'B1'),
('B1.2', 'Tầng B1.2', 'B1'),
('B2.1', 'Tầng B2.1', 'B2'),
('B2.2', 'Tầng B2.2', 'B2'),
('N1.1', 'Tầng N1.1', 'N1');



-- Dữ liệu cho bảng PhongHoc
-- Tầng B1.1
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc, MaTang) 
VALUES
('B1.101', 'Phòng B1.101', 'B1.1'),
('B1.102', 'Phòng B1.102', 'B1.1');


-- Tầng B1.2
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc, MaTang) 
VALUES
('B1.201', 'Phòng B1.201', 'B1.2'),
('B1.202', 'Phòng B1.202', 'B1.2');


-- Tầng B2.1
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc, MaTang) 
VALUES
('B2.101', 'Phòng B2.101', 'B2.1'),
('B2.102', 'Phòng B2.102', 'B2.1');


-- Tầng B2.2
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc, MaTang) 
VALUES
('B2.201', 'Phòng B2.201', 'B2.2'),
('B2.202', 'Phòng B2.202', 'B2.2');


-- Tầng N1.1
INSERT INTO PhongHoc (MaPhongHoc, TenPhongHoc, MaTang) 
VALUES
('N1.101', 'Phòng N1.101', 'N1.1'),
('N1.102', 'Phòng N1.102', 'N1.1');

-- Chèn dữ liệu vào bảng PhanMem
INSERT INTO PhanMem (MaPhanMem, TenPhanMem) 
VALUES
('PM1', N'Matlab'),
('PM2', 'Android Studio'),
('PM3', 'Android Studio Code'),
('PM4', 'SQL manager'),
('PM5', 'Orange');


-- Phòng B1.101
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B1.101.MIC', N'Micro', 'B1.101', N'Hoạt động', '2023-12-11', N' ', null),
('B1.101.ML1', N'Máy lạnh 1', 'B1.101', N'Hoạt động', '2023-12-11', N' ', null),
('B1.101.ML2', N'Máy lạnh 2', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.MC', N'Máy chiếu 1', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.01', N'Máy tính 1', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.02', N'Máy tính 2', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.03', N'Máy tính 3', 'B1.101', N'Bảo trì', '2024-01-01', N'', null),
('B1.101.04', N'Máy tính 4', 'B1.101', N'Sữa chữa', '2023-12-11', N'', '2024-03-12'),
('B1.101.05', N'Máy tính 5', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.06', N'Máy tính 6', 'B1.101', N'Hoạt động', '2023-12-11', N'', null),
('B1.101.07', N'Máy tính 7', 'B1.101',  N'Sữa chữa', '2023-12-11', N'', '2024-03-12'),
('B1.101.08', N'Máy tính 8', 'B1.101', N'Hoạt động', '2023-12-11', N'', null);


-- Chèn dữ liệu vào bảng ThietBi
-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B1.101.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.02', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.03', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.04', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.05', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.06', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.07', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.101.08', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');



-- Phòng B1.102
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B1.102.MIC', N'Micro', 'B1.102',  N'Hoạt động', '2023-12-11', '', null),
('B1.102.ML1', N'Máy lạnh 1', 'B1.102',  N'Hoạt động', '2023-12-11', '', null),
('B1.102.ML2', N'Máy lạnh 2', 'B1.102',  N'Hoạt động', '2023-12-11', '', null),
('B1.102.MC', N'Máy chiếu 1', 'B1.102',  N'Hoạt động', '2023-12-11', '', null),
('B1.102.01', N'Máy tính 1', 'B1.102',  N'Hoạt động', '2023-12-11', '', null);
-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B1.102.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');



-- Phòng B1.201
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B1.201.MIC', N'Micro', 'B1.201',  N'Hoạt động', '2023-12-11', '', null),
('B1.201.ML1', N'Máy lạnh 1', 'B1.201',  N'Hoạt động', '2023-12-11', '', null),
('B1.201.ML2', N'Máy lạnh 2', 'B1.201',  N'Hoạt động', '2023-12-11', '', null),
('B1.201.MC', N'Máy chiếu 1', 'B1.201',  N'Hoạt động', '2023-12-11', '', null),
('B1.201.01', N'Máy tính 1', 'B1.201',  N'Hoạt động', '2023-12-11', '', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B1.201.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');


-- Phòng B1.202
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES
('B1.202.MIC', N'Micro', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.ML1', N'Máy lạnh 1', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.ML2', N'Máy lạnh 2', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.MC', N'Máy chiếu 1', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.01', N'Máy tính 1', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.02', N'Máy tính 2', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.03', N'Máy tính 3', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.04', N'Máy tính 4', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.05', N'Máy tính 5', 'B1.202', N'Sữa chữa', '2023-12-11', N'', '2024-03-12'),
('B1.202.06', N'Máy tính 6', 'B1.202',  N'Sữa chữa', '2023-12-11', N'', '2024-03-12'),
('B1.202.07', N'Máy tính 7', 'B1.202',  N'Hoạt động', '2023-12-11', '', null),
('B1.202.08', N'Máy tính 8', 'B1.202',  N'Hoạt động', '2023-12-11', '', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B1.202.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.02', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.03', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.04', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.05', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.06', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.07', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B1.202.08', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');

-- Phòng B2.101
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B2.101.MIC', N'Micro', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.ML1', N'Máy lạnh 1', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.ML2', N'Máy lạnh 2', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.MC', N'Máy chiếu 1', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.01', N'Máy tính 1', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.02', N'Máy tính 2', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.03', N'Máy tính 3', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.04', N'Máy tính 4', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.05', N'Máy tính 5', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.06', N'Máy tính 6', 'B2.101', N'Hoạt động', '2023-12-11', '', null),
('B2.101.07', N'Máy tính 7', 'B2.101', N'Sữa chữa', '2023-12-11', N'', '2024-03-12'),
('B2.101.08', N'Máy tính 8', 'B2.101', N'Hoạt động', '2023-12-11', '', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B2.101.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.02', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.03', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.04', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.05', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.06', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.07', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('B2.101.08', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');

-- Phòng B2.102
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B2.102.MIC', N'Micro', 'B2.102', N'Hoạt động', '2023-12-11', '', null),
('B2.102.ML1', N'Máy lạnh 1', 'B2.102', N'Hoạt động', '2023-12-11', '', null),
('B2.102.ML2', N'Máy lạnh 2', 'B2.102', N'Hoạt động', '2023-12-11', '', null),
('B2.102.MC', N'Máy chiếu 1', 'B2.102', N'Hoạt động', '2023-12-11', '', null),
('B2.102.01', N'Máy tính 1', 'B2.102', N'Hoạt động', '2023-12-11', '', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B2.102.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');








-- Dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, LoaiTaiKhoan) VALUES
('GV001', N'Matkhau', 'GiaoVien'),
('GV002', N'Matkhau', 'GiaoVien'),
('GV003', N'Matkhau', 'GiaoVien'),
('GV004', N'Matkhau', 'GiaoVien'),
('GV005', N'Matkhau', 'GiaoVien'),
('NV001', N'Matkhau', 'NhanVien'),
('NV002', N'Matkhau', 'NhanVien'),
('NV003', N'Matkhau', 'NhanVien'),
('QL001', N'Matkhau', 'QuanLy');

-- Dữ liệu cho bảng GiaoVien
INSERT INTO GiaoVien (ID, Ten, SDT, Email, TenTaiKhoan) VALUES
('GV001', 'Giao Vien 1', '123456789', 'giaovien1@example.com', 'GV001'),
('GV002', 'Giao Vien 2', '987654321', 'giaovien2@example.com', 'GV002'),
('GV003', 'Giao Vien 3', '111223344', 'giaovien3@example.com', 'GV003'),
('GV004', 'Giao Vien 4', '555666777', 'giaovien4@example.com', 'GV004'),
('GV005', 'Giao Vien 5', '888999000', 'giaovien5@example.com', 'GV005');

-- Dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (ID, Ten, SDT, Email, TenTaiKhoan) VALUES
('NV001', 'Nhan Vien 1', '111000111', 'nhanvien1@example.com', 'NV001'),
('NV002', 'Nhan Vien 2', '222333444', 'nhanvien2@example.com', 'NV002'),
('NV003', 'Nhan Vien 3', '444555666', 'nhanvien3@example.com', 'NV003');

-- Dữ liệu cho bảng QuanLy
INSERT INTO QuanLy (ID, Ten, SDT, Email, TenTaiKhoan) VALUES
('QL001', 'Quan Ly 1', '999888777', 'quanly1@example.com', 'QL001');


-- Dữ liệu vào bảng QuyenTruyCapGV
INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV001', 'B1.101', 'GiaoVien');
INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV001', 'B1.102', 'GiaoVien');

INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV002', 'B2.101', 'GiaoVien');
INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV002', 'B2.102', 'GiaoVien');

INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV003', 'B2.102', 'GiaoVien');
INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan)
VALUES ('GV003', 'B2.101', 'GiaoVien');


-- Dữ liệu vào bảng QuyenTruyCapNV
INSERT INTO QuyenTruyCapNV (TenTaiKhoan, MaToaNha, LoaiTaiKhoan)
VALUES ('NV002', 'B1', 'NhanVien');
INSERT INTO QuyenTruyCapNV (TenTaiKhoan, MaToaNha, LoaiTaiKhoan)
VALUES ('NV001', 'B2', 'NhanVien');
INSERT INTO QuyenTruyCapNV (TenTaiKhoan, MaToaNha, LoaiTaiKhoan)
VALUES ('NV003', 'N1', 'NhanVien');



-- Phòng B1.201
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B1.201.MIC', N'Micro', 'B1.201', N'Hoạt động', '2023-12-11', N'', null),
('B1.201.ML1', N'Máy lạnh 1', 'B1.201', N'Hoạt động', '2023-12-11', N'', null),
('B1.201.ML2', N'Máy lạnh 2', 'B1.201', N'Hoạt động', '2023-12-11', N'', null),
('B1.201.MC', N'Máy chiếu 1', 'B1.201', N'Sửa chữa', '2023-12-11', N'bị hư', '2024-03-27'),
('B1.201.01', N'Máy tính 1', 'B1.201', N'Hoạt động', '2023-12-11', N'', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B1.201.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');





-- Phòng B2.201
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B2.201.MIC', N'Micro', 'B2.201', N'Hoạt động', '2023-12-11', N'', null),
('B2.201.ML1', N'Máy lạnh 1', 'B2.201', N'Hoạt động', '2023-12-11', N'', null),
('B2.201.ML2', N'Máy lạnh 2', 'B2.201', N'Hoạt động', '2023-12-11', N'', null),
('B2.201.MC', N'Máy chiếu 1', 'B2.201', N'Hoạt động', '2023-12-11', N'', null),
('B2.201.01', N'Máy tính 1', 'B2.201', N'Hoạt động', '2023-12-11', N'', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B2.201.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');



-- Phòng B2.202
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('B2.202.MIC', N'Micro', 'B2.202', N'Hoạt động', '2023-12-11', N'', null),
('B2.202.ML1', N'Máy lạnh 1', 'B2.202', N'Hoạt động', '2023-12-11', N'', null),
('B2.202.ML2', N'Máy lạnh 2', 'B2.202', N'Hoạt động', '2023-12-11', N'', null),
('B2.202.MC', N'Máy chiếu 1', 'B2.202', N'Hoạt động', '2023-12-11', N'', null),
('B2.202.01', N'Máy tính 1', 'B2.202', N'Hoạt động', '2023-12-11', N'', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('B2.202.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');


-- Phòng N1.101
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES
('N1.101.MIC', N'Micro', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.ML1', N'Máy lạnh 1', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.ML2', N'Máy lạnh 2', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.MC', N'Máy chiếu 1', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.01', N'Máy tính 1', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.02', N'Máy tính 2', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.03', N'Máy tính 3', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.04', N'Máy tính 4', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.05', N'Máy tính 5', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.06', N'Máy tính 6', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.07', N'Máy tính 7', 'N1.101', N'Hoạt động', '2023-12-11', N'', null),
('N1.101.08', N'Máy tính 8', 'N1.101', N'Hoạt động', '2023-12-11', N'', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('N1.101.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.02', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.03', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.04', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.05', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.06', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.07', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB'),
('N1.101.08', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');




-- Phòng N1.102
-- Chèn dữ liệu vào bảng ThietBi
INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien)
VALUES 
('N1.102.MIC', N'Micro', 'N1.102', N'Hoạt động', '2023-12-11', N'', null),
('N1.102.ML1', N'Máy lạnh 1', 'N1.102', N'Hoạt động', '2023-12-11', N'', null),
('N1.102.ML2', N'Máy lạnh 2', 'N1.102', N'Hoạt động', '2023-12-11', N'', null),
('N1.102.MC', N'Máy chiếu 1', 'N1.102', N'Hoạt động', '2023-12-11', N'', null),
('N1.102.01', N'Máy tính 1', 'N1.102', N'Hoạt động', '2023-12-11', N'', null);

-- Chèn dữ liệu vào bảng MayTinh
INSERT INTO MayTinh (MaThietBi, Window, PhanCung1, PhanCung2, PhanCung3)
VALUES
('N1.102.01', 'Windows 10', 'CPU Intel i7', 'RAM 8GB', 'Ổ cứng 256GB');



-- Chèn dữ liệu vào bảng MayTinh_PhanMem cho tất cả các thiết bị với các phiên bản khác nhau của phần mềm
INSERT INTO MayTinh_PhanMem (MaThietBi, MaPhanMem, PhienBan)
SELECT mt.MaThietBi, pm.MaPhanMem, 
    CASE pm.MaPhanMem
        WHEN 'PM1' THEN '2.0' -- Phiên bản cho PhanMem có MaPhanMem = 'PM1'
        WHEN 'PM2' THEN '3.0' -- Phiên bản cho PhanMem có MaPhanMem = 'PM2'
        WHEN 'PM3' THEN '1.5' -- Phiên bản cho PhanMem có MaPhanMem = 'PM3'
        ELSE '1.0' -- Phiên bản mặc định cho các PhanMem khác
    END AS PhienBan
FROM MayTinh mt, PhanMem pm;



-- Chèn một bản ghi mới vào bảng YeuCauThietBi
INSERT INTO YeuCauThietBi (MaYeuCau, TenThietBi, MaPhongHoc, TinhTrang, NgayCapYeuCau, Window, PhanCung1, PhanCung2, PhanCung3, TenPhanMem, TenTaiKhoan)
VALUES ('YC001', N'Máy chiếu', 'B1.102', N'Chờ xử lý', '2024-03-21', '', '', '', '', '', 'GV001'),
       ('YC002', N'Máy lạnh', 'B1.102', N'Chờ xử lý', '2024-03-22', '', '', '', '', '', 'GV002');




SELECT DISTINCT PhongHoc.MaPhongHoc, PhongHoc.TenPhongHoc
FROM PhongHoc
JOIN Tang ON PhongHoc.MaTang = Tang.MaTang
JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha
JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha
WHERE QuyenTruyCapNV.TenTaiKhoan = 'NV001';

Select *FROM TaiKhoan