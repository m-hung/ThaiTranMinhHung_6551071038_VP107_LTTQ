CREATE DATABASE DuLieu;
GO

USE DuLieu;
GO

CREATE TABLE MonHoc(
	MaMonHoc NVARCHAR(10) PRIMARY KEY,
	TenMonHoc NTEXT NOT NULL,
	SoTinChi NVARCHAR(5) NOT NULL
);
GO

INSERT INTO MonHoc(MaMonHoc, TenMonHoc, SoTinChi)
VALUES(N'MH001', N'Lập trình C# cơ bản', N'3'),
	(N'MH002', N'Cơ sở dữ liệu', N'4');
GO