---- Tạo database ----
CREATE DATABASE ThietBi
GO

USE ThietBi
GO

CREATE TABLE ThietBi
(
	id CHAR(10) PRIMARY KEY,
	ten NVARCHAR(100) NOT NULL DEFAULT N'Unknown',
	gia INT NOT NULL DEFAULT 0,
	soluong INT NOT NULL DEFAULT 0
)
GO
CREATE TABLE KhachHang
(
	id CHAR(10) PRIMARY KEY,
	ten NVARCHAR (100) NOT NULL DEFAULT N'Unknown',
	diachi NVARCHAR(100) NULL,
	sdt CHAR(10) NULL
)
GO
CREATE TABLE HoaDon
(
	id CHAR(10) PRIMARY KEY,
	idkhanghang CHAR(10) NOT NULL,
	ngay DATETIME NOT NULL,
	tongtien INT NOT NULL DEFAULT 0,
	diachigiao NVARCHAR(100),
	giaohang BIT
)
GO
CREATE TABLE CTHoaDon
(
	id CHAR(10),
	idthietbi CHAR(10),
	soluong INT,

	CONSTRAINT machitiet PRIMARY KEY (id,idthietbi)
)
GO