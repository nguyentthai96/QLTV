USE [master]
GO
/****** Object:  Database [QLTV]    Script Date: 05/24/2016 21:07:31 ******/
CREATE DATABASE [QLTV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLTV', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLTV.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLTV_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLTV_log.ldf' , SIZE = 5696KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLTV] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLTV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLTV] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLTV', N'ON'
GO
USE [QLTV]
GO
/****** Object:  Table [dbo].[tbl_CTPHIEUMUON]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_CTPHIEUMUON](
	[maPhieu] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[hanTra] [date] NOT NULL,
	[tienCoc] [bigint] NULL,
 CONSTRAINT [PK_tbl_CTPHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[maPhieu] ASC,
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NGONNGU]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NGONNGU](
	[maNN] [int] IDENTITY(1,1) NOT NULL,
	[tenNN] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_NGONNGHU] PRIMARY KEY CLUSTERED 
(
	[maNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NHANVIEN]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_NHANVIEN](
	[maNV] [int] IDENTITY(1,1) NOT NULL,
	[tenNV] [nvarchar](50) NOT NULL,
	[gioiTinhNV] [bit] NOT NULL,
	[ngaySinhNV] [date] NULL,
	[dienThoaiNV] [varchar](11) NOT NULL,
	[diaChiNV] [nvarchar](100) NULL,
	[emailNV] [nchar](100) NOT NULL,
	[ngayVaoLam] [date] NOT NULL,
	[matKhau] [char](30) NOT NULL,
 CONSTRAINT [PK_tbl_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[maNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_NHAXUATBAN]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_NHAXUATBAN](
	[maNXB] [int] IDENTITY(1,1) NOT NULL,
	[tenNXB] [nvarchar](200) NOT NULL,
	[diaChiNXB] [nvarchar](100) NULL,
	[dienThoaiNXB] [char](11) NULL,
	[websiteNXB] [char](100) NULL,
 CONSTRAINT [PK_tbl_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[maNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_PHIEUMUON]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_PHIEUMUON](
	[maPhieu] [int] IDENTITY(1,1) NOT NULL,
	[maSV] [char](10) NOT NULL,
	[ngayMuon] [date] NOT NULL,
	[maNV] [int] NOT NULL,
 CONSTRAINT [PK_tbl_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[maPhieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_SACH]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SACH](
	[maSach] [int] IDENTITY(1,1) NOT NULL,
	[tenSach] [nvarchar](50) NOT NULL,
	[soTrang] [int] NOT NULL,
	[gia] [bigint] NOT NULL,
	[soLuong] [int] NOT NULL,
	[ngayNhap] [date] NULL,
	[maNXB] [int] NOT NULL,
	[maTL] [int] NOT NULL,
	[maTG] [int] NOT NULL,
	[maNN] [int] NOT NULL,
	[tinhTrang] [bit] NULL,
 CONSTRAINT [PK_tbl_SACH] PRIMARY KEY CLUSTERED 
(
	[maSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_SINHVIEN]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_SINHVIEN](
	[maSV] [char](10) NOT NULL,
	[hoTenSV] [nvarchar](50) NOT NULL,
	[gioiTinhSV] [bit] NOT NULL,
	[ngaySinhSV] [date] NOT NULL,
	[lopSV] [char](20) NOT NULL,
	[ngayLamThe] [date] NOT NULL,
	[ngayHetHan] [date] NOT NULL,
 CONSTRAINT [PK_tbl_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[maSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_TACGIA]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TACGIA](
	[maTG] [int] IDENTITY(1,1) NOT NULL,
	[hoTenTG] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_TACGIA] PRIMARY KEY CLUSTERED 
(
	[maTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_THELOAI]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_THELOAI](
	[maTL] [int] IDENTITY(1,1) NOT NULL,
	[tenTL] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tbl_THELOAI] PRIMARY KEY CLUSTERED 
(
	[maTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_TRASACH]    Script Date: 05/24/2016 21:07:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_TRASACH](
	[STT] [int] IDENTITY(1,1) NOT NULL,
	[maPhieu] [int] NOT NULL,
	[maSach] [int] NOT NULL,
	[maNV] [int] NOT NULL,
	[ngayTra] [date] NOT NULL,
	[phatHuHong] [bigint] NULL,
	[phatQuaHan] [bigint] NULL,
	[thanhToan] [bigint] NULL,
 CONSTRAINT [PK_tbl_TRASACH] PRIMARY KEY CLUSTERED 
(
	[STT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (1, 1, CAST(0x183B0B00 AS Date), 1000)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (1, 2, CAST(0x183B0B00 AS Date), 5000)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (1, 8, CAST(0x183B0B00 AS Date), 0)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (1, 12, CAST(0x183B0B00 AS Date), 0)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (1, 42, CAST(0x183B0B00 AS Date), 0)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (2, 4, CAST(0x443A0B00 AS Date), NULL)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (2, 9, CAST(0x443A0B00 AS Date), NULL)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (3, 18, CAST(0x613A0B00 AS Date), NULL)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (4, 21, CAST(0x7A380B00 AS Date), NULL)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (23, 12, CAST(0x743B0B00 AS Date), 0)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (25, 19, CAST(0x813B0B00 AS Date), 1234)
INSERT [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach], [hanTra], [tienCoc]) VALUES (26, 15, CAST(0x6F3B0B00 AS Date), 7000)
SET IDENTITY_INSERT [dbo].[tbl_NGONNGU] ON 

INSERT [dbo].[tbl_NGONNGU] ([maNN], [tenNN]) VALUES (1, N'Tiếng Việt')
INSERT [dbo].[tbl_NGONNGU] ([maNN], [tenNN]) VALUES (2, N'Tiếng Anh')
INSERT [dbo].[tbl_NGONNGU] ([maNN], [tenNN]) VALUES (3, N'Tiếng Pháp')
INSERT [dbo].[tbl_NGONNGU] ([maNN], [tenNN]) VALUES (4, N'Tiếng Trung')
SET IDENTITY_INSERT [dbo].[tbl_NGONNGU] OFF
SET IDENTITY_INSERT [dbo].[tbl_NHANVIEN] ON 

INSERT [dbo].[tbl_NHANVIEN] ([maNV], [tenNV], [gioiTinhNV], [ngaySinhNV], [dienThoaiNV], [diaChiNV], [emailNV], [ngayVaoLam], [matKhau]) VALUES (1, N'Nguyễn Thị Thuý', 0, CAST(0xD1FF0A00 AS Date), N'01649346165', N'Hà Nội', N'thuthuy@gmail.com                                                                                   ', CAST(0x35300B00 AS Date), N'ADMIN                         ')
INSERT [dbo].[tbl_NHANVIEN] ([maNV], [tenNV], [gioiTinhNV], [ngaySinhNV], [dienThoaiNV], [diaChiNV], [emailNV], [ngayVaoLam], [matKhau]) VALUES (2, N'Nguyễn Trần Thanh Trúc', 0, CAST(0x040E0B00 AS Date), N'0912458762', N'Nam Định', N'thanhtruc@gmail.com                                                                                 ', CAST(0x2F330B00 AS Date), N'ADMIN                         ')
INSERT [dbo].[tbl_NHANVIEN] ([maNV], [tenNV], [gioiTinhNV], [ngaySinhNV], [dienThoaiNV], [diaChiNV], [emailNV], [ngayVaoLam], [matKhau]) VALUES (3, N'Nguyễn Văn Tùng', 1, CAST(0x01FD0A00 AS Date), N'00000', N'Vĩnh Phúc', N'vantung@gmail.com                                                                                   ', CAST(0x202A0B00 AS Date), N'ADMIN                         ')
INSERT [dbo].[tbl_NHANVIEN] ([maNV], [tenNV], [gioiTinhNV], [ngaySinhNV], [dienThoaiNV], [diaChiNV], [emailNV], [ngayVaoLam], [matKhau]) VALUES (4, N'Nguyễn Văn Hiếu', 1, CAST(0x801F0B00 AS Date), N'01649346164', N'Hà Nội', N'admin                                                                                               ', CAST(0x603B0B00 AS Date), N'admin                         ')
SET IDENTITY_INSERT [dbo].[tbl_NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[tbl_NHAXUATBAN] ON 

INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (1, N'Chính trị Quốc gia', N'22-24 Quang Trung, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (2, N'Đại học Bách Khoa', N'Khán đài B, sân vận động Tạ Quang Bửu', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (3, N'Đại học Kinh tế quốc dân', N'207 đường Giải Phóng, Hà Nội', N'0241543412 ', N'                                                                                                    ')
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (4, N'Đại học Quốc gia Hà Nội', N'16 Hàng Chuối, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (5, N'Đại học Quốc gia Tp. Hồ Chí Minh', N'3 Công trường Quốc tế, Q.3, Tp. Hồ Chí Minh', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (6, N'Đại học Sư phạm', N'136 Xuân Thuỷ, Cầu giấy, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (7, N'Giáo dục', N'81 Trần Hưng Đạo, Hà Nội', N'0145555555 ', N'                                                                                                    ')
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (8, N'Nhà xuất bản Hà Nội', N'6 4 Tống Duy Tân, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (9, N'Khoa học xã hội', N'61 Phan Chu Trinh, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (10, N'Kim Đồng', N'55 Quang Trung, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (11, N'Nông nghiệp', N'D14, Phương Mai, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (12, N'Thanh niên', N'62, Bà Triệu, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (13, N'Văn học', N'18, Nguyễn Trường Tộ, Hà Nội', NULL, NULL)
INSERT [dbo].[tbl_NHAXUATBAN] ([maNXB], [tenNXB], [diaChiNXB], [dienThoaiNXB], [websiteNXB]) VALUES (14, N'Trẻ', N'161B, Lý Chính Thắng, Q.3, Tp. Hồ Chí Minh', NULL, NULL)
SET IDENTITY_INSERT [dbo].[tbl_NHAXUATBAN] OFF
SET IDENTITY_INSERT [dbo].[tbl_PHIEUMUON] ON 

INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (1, N'1181020074', CAST(0xDB3A0B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (2, N'1481310001', CAST(0x6E390B00 AS Date), 2)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (3, N'1481310002', CAST(0x423A0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (4, N'1481310002', CAST(0x2D390B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (5, N'1481310004', CAST(0x603B0B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (6, N'1481310004', CAST(0x603B0B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (7, N'1481310004', CAST(0x603B0B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (8, N'1381730014', CAST(0x603B0B00 AS Date), 2)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (9, N'1381310001', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (10, N'1581210024', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (11, N'1581210011', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (12, N'1381310023', CAST(0x603B0B00 AS Date), 2)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (13, N'1481310001', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (14, N'1381310029', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (15, N'1381310029', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (16, N'1381720003', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (17, N'1381310029', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (18, N'1381720003', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (19, N'1481310017', CAST(0x603B0B00 AS Date), 4)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (20, N'1381720003', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (21, N'1381310029', CAST(0x603B0B00 AS Date), 2)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (23, N'1581210011', CAST(0x603B0B00 AS Date), 1)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (24, N'1381310029', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (25, N'1481310001', CAST(0x603B0B00 AS Date), 3)
INSERT [dbo].[tbl_PHIEUMUON] ([maPhieu], [maSV], [ngayMuon], [maNV]) VALUES (26, N'1581210002', CAST(0x653B0B00 AS Date), 4)
SET IDENTITY_INSERT [dbo].[tbl_PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[tbl_SACH] ON 

INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (1, N'Toán Cao Cấp 1', 152, 15000, 158, CAST(0x2C310B00 AS Date), 7, 1, 1, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (2, N'Toán Cao Cấp 2', 148, 14500, 208, CAST(0x7C2E0B00 AS Date), 1, 1, 2, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (4, N'Xác Suất Thống Kê', 207, 25000, 158, CAST(0xA6320B00 AS Date), 1, 1, 3, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (5, N'Nhập Môn Tin Học', 380, 35000, 145, CAST(0x6E390B00 AS Date), 2, 9, 4, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (6, N'Lập Trình Web với HTML5', 450, 60000, 120, CAST(0x9F350B00 AS Date), 2, 9, 5, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (7, N'Nhập môn thương mai điện tử', 300, 36000, 25, CAST(0x423A0B00 AS Date), 2, 9, 6, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (8, N'Tư tưởn Hồ Chí Minh', 480, 25000, 300, CAST(0xE3320B00 AS Date), 1, 7, 7, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (9, N'Đường Lối đảng cộng sản VN', 386, 24000, 165, CAST(0xC4320B00 AS Date), 1, 7, 6, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (12, N'Nguyên lí Mac-Lenin II', 430, 25000, 15, CAST(0xFB350B00 AS Date), 1, 7, 8, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (14, N'Trên con đường xưa', 285, 39000, 17, CAST(0x6E390B00 AS Date), 13, 12, 9, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (15, N'Bài học đầu tiên', 360, 45000, 28, CAST(0xFE2B0B00 AS Date), 13, 12, 9, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (17, N'Tôi tài giỏi, bạn cũng thê', 325, 60000, 18, CAST(0x6E390B00 AS Date), 12, 11, 10, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (18, N'Trên đường băng', 452, 85000, 10, CAST(0xDB3A0B00 AS Date), 12, 11, 11, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (19, N'Java tutorial', 600, 152000, 8, CAST(0x1A360B00 AS Date), 14, 9, 4, 2, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (20, N'SQL sever', 425, 120000, 3, CAST(0x6E390B00 AS Date), 14, 9, 12, 2, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (21, N'Vật lí đại cương', 150, 15000, 352, CAST(0x9F350B00 AS Date), 7, 10, 13, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (22, N'Bài tập vật lí đại cương', 250, 27000, 148, CAST(0x9F350B00 AS Date), 7, 10, 13, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (23, N'Hóa học đại cương', 180, 19000, 123, CAST(0x1A360B00 AS Date), 7, 13, 14, 1, 1)
INSERT [dbo].[tbl_SACH] ([maSach], [tenSach], [soTrang], [gia], [soLuong], [ngayNhap], [maNXB], [maTL], [maTG], [maNN], [tinhTrang]) VALUES (42, N'Lịch Sử', 158, 25000, 250, CAST(0x413B0B00 AS Date), 8, 4, 10, 3, NULL)
SET IDENTITY_INSERT [dbo].[tbl_SACH] OFF
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1181020074', N'Bùi Thị Bích Phương', 0, CAST(0xC01F0B00 AS Date), N'D9CODT              ', CAST(0xDB3A0B00 AS Date), CAST(0x90400B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381310001', N'Đỗ Thị Ngọc Anh', 0, CAST(0x001D0B00 AS Date), N'D8TMDT              ', CAST(0x94360B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381310003', N'Nguyên Viết Tuân', 1, CAST(0x3A1C0B00 AS Date), N'D8KT1               ', CAST(0x94360B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381310007', N'Trần Việt Long', 1, CAST(0xEC1C0B00 AS Date), N'D8KT1               ', CAST(0x94360B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381310023', N'Đỗ Thị Hà', 0, CAST(0x131D0B00 AS Date), N'D8KT1               ', CAST(0x94360B00 AS Date), CAST(0x94360B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381310029', N'Hà Thị Nhung', 0, CAST(0xF01D0B00 AS Date), N'D8KT1               ', CAST(0x94360B00 AS Date), CAST(0x94360B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381720003', N'Hoàng Thị Trang Anh', 0, CAST(0xA41B0B00 AS Date), N'D8TMDT              ', CAST(0x01380B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1381730014', N'Lê Thị Hồng', 0, CAST(0xC21D0B00 AS Date), N'D8TMDT              ', CAST(0xDB3A0B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1481310001', N'Nguyễn Tuấn Anh', 1, CAST(0x101D0B00 AS Date), N'D9CNPM              ', CAST(0x94360B00 AS Date), CAST(0xB63D0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1481310002', N'Nguyễn Đức Tuấn Anh', 1, CAST(0xB51F0B00 AS Date), N'D9CNPM              ', CAST(0x01380B00 AS Date), CAST(0x233F0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1481310004', N'Nguyễn Bảo Châu', 0, CAST(0xAF1E0B00 AS Date), N'D9CNPM              ', CAST(0x01380B00 AS Date), CAST(0x233F0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1481310017', N'Phạm Xuân Duy', 1, CAST(0x191F0B00 AS Date), N'D9CNPM              ', CAST(0x01380B00 AS Date), CAST(0x233F0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1581210002', N'Lê Thị Lan', 0, CAST(0xE8200B00 AS Date), N'D10CNPM             ', CAST(0x6E390B00 AS Date), CAST(0x233F0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1581210005', N'Nguyễn Ngọc Minh Châu', 1, CAST(0xDF1F0B00 AS Date), N'D10ANM              ', CAST(0x6E390B00 AS Date), CAST(0x90400B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1581210011', N'Trần Quốc Đạt', 1, CAST(0x691E0B00 AS Date), N'D10TMDT             ', CAST(0x66380B00 AS Date), CAST(0x233F0B00 AS Date))
INSERT [dbo].[tbl_SINHVIEN] ([maSV], [hoTenSV], [gioiTinhSV], [ngaySinhSV], [lopSV], [ngayLamThe], [ngayHetHan]) VALUES (N'1581210024', N'Lưu Quang Lực', 1, CAST(0xD61F0B00 AS Date), N'D10QLNN             ', CAST(0xDB3A0B00 AS Date), CAST(0x90400B00 AS Date))
SET IDENTITY_INSERT [dbo].[tbl_TACGIA] ON 

INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (1, N'Nguyễn Văn Huyên')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (2, N'Nguyễn Thi Minh')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (3, N'Trần Thị Liên')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (4, N'Nguyễn Đức Minh')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (5, N'Phạm Văn Ất')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (6, N'Bùi Thị Hiền')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (7, N'Trần Đăng Khoa')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (8, N'Bùi Văn Trung')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (9, N'Nguyễn Thị Huyên')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (10, N'Đưc Tiến')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (11, N'Minh Ngọc')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (12, N'Hoàng Văn Nam')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (13, N'Đăng Phương Nam')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (14, N'Đinh Mạnh Tường')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (16, N'Lê Minh Hoàng')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (17, N'Nguyễn Huy')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (18, N'Hoàng Nam')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (19, N'Văn Đức')
INSERT [dbo].[tbl_TACGIA] ([maTG], [hoTenTG]) VALUES (20, N'Minh Ngọc')
SET IDENTITY_INSERT [dbo].[tbl_TACGIA] OFF
SET IDENTITY_INSERT [dbo].[tbl_THELOAI] ON 

INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (1, N'Toán')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (2, N'Văn Học')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (4, N'Lịch Sử')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (5, N'Âm nhạc')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (6, N'Công Nghệ')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (7, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (8, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (9, N'Tin Học')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (10, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (11, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (12, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (13, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (14, N'đúng')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (15, N'sai')
INSERT [dbo].[tbl_THELOAI] ([maTL], [tenTL]) VALUES (16, N'sai')
SET IDENTITY_INSERT [dbo].[tbl_THELOAI] OFF
SET IDENTITY_INSERT [dbo].[tbl_TRASACH] ON 

INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (2, 1, 1, 1, CAST(0x173B0B00 AS Date), 0, 0, 0)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (3, 1, 2, 1, CAST(0x173B0B00 AS Date), 0, 0, 0)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (5, 1, 8, 1, CAST(0x173B0B00 AS Date), 0, 0, 0)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (7, 2, 4, 2, CAST(0x443A0B00 AS Date), 0, 0, 0)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (8, 2, 9, 2, CAST(0x443A0B00 AS Date), 0, 0, 0)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (10, 3, 18, 3, CAST(0x643A0B00 AS Date), 0, 3000, 3000)
INSERT [dbo].[tbl_TRASACH] ([STT], [maPhieu], [maSach], [maNV], [ngayTra], [phatHuHong], [phatQuaHan], [thanhToan]) VALUES (11, 4, 21, 1, CAST(0x7D380B00 AS Date), 25000, 3000, 28000)
SET IDENTITY_INSERT [dbo].[tbl_TRASACH] OFF
ALTER TABLE [dbo].[tbl_CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CTPHIEUMUON_tbl_PHIEUMUON] FOREIGN KEY([maPhieu])
REFERENCES [dbo].[tbl_PHIEUMUON] ([maPhieu])
GO
ALTER TABLE [dbo].[tbl_CTPHIEUMUON] CHECK CONSTRAINT [FK_tbl_CTPHIEUMUON_tbl_PHIEUMUON]
GO
ALTER TABLE [dbo].[tbl_CTPHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_tbl_CTPHIEUMUON_tbl_SACH1] FOREIGN KEY([maSach])
REFERENCES [dbo].[tbl_SACH] ([maSach])
GO
ALTER TABLE [dbo].[tbl_CTPHIEUMUON] CHECK CONSTRAINT [FK_tbl_CTPHIEUMUON_tbl_SACH1]
GO
ALTER TABLE [dbo].[tbl_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PHIEUMUON_tbl_NHANVIEN] FOREIGN KEY([maNV])
REFERENCES [dbo].[tbl_NHANVIEN] ([maNV])
GO
ALTER TABLE [dbo].[tbl_PHIEUMUON] CHECK CONSTRAINT [FK_tbl_PHIEUMUON_tbl_NHANVIEN]
GO
ALTER TABLE [dbo].[tbl_PHIEUMUON]  WITH CHECK ADD  CONSTRAINT [FK_tbl_PHIEUMUON_tbl_SINHVIEN] FOREIGN KEY([maSV])
REFERENCES [dbo].[tbl_SINHVIEN] ([maSV])
GO
ALTER TABLE [dbo].[tbl_PHIEUMUON] CHECK CONSTRAINT [FK_tbl_PHIEUMUON_tbl_SINHVIEN]
GO
ALTER TABLE [dbo].[tbl_SACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SACH_tbl_NGONNGHU] FOREIGN KEY([maNN])
REFERENCES [dbo].[tbl_NGONNGU] ([maNN])
GO
ALTER TABLE [dbo].[tbl_SACH] CHECK CONSTRAINT [FK_tbl_SACH_tbl_NGONNGHU]
GO
ALTER TABLE [dbo].[tbl_SACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SACH_tbl_NHAXUATBAN] FOREIGN KEY([maNXB])
REFERENCES [dbo].[tbl_NHAXUATBAN] ([maNXB])
GO
ALTER TABLE [dbo].[tbl_SACH] CHECK CONSTRAINT [FK_tbl_SACH_tbl_NHAXUATBAN]
GO
ALTER TABLE [dbo].[tbl_SACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SACH_tbl_TACGIA] FOREIGN KEY([maTG])
REFERENCES [dbo].[tbl_TACGIA] ([maTG])
GO
ALTER TABLE [dbo].[tbl_SACH] CHECK CONSTRAINT [FK_tbl_SACH_tbl_TACGIA]
GO
ALTER TABLE [dbo].[tbl_SACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SACH_tbl_THELOAI] FOREIGN KEY([maTL])
REFERENCES [dbo].[tbl_THELOAI] ([maTL])
GO
ALTER TABLE [dbo].[tbl_SACH] CHECK CONSTRAINT [FK_tbl_SACH_tbl_THELOAI]
GO
ALTER TABLE [dbo].[tbl_TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TRASACH_tbl_CTPHIEUMUON] FOREIGN KEY([maPhieu], [maSach])
REFERENCES [dbo].[tbl_CTPHIEUMUON] ([maPhieu], [maSach])
GO
ALTER TABLE [dbo].[tbl_TRASACH] CHECK CONSTRAINT [FK_tbl_TRASACH_tbl_CTPHIEUMUON]
GO
ALTER TABLE [dbo].[tbl_TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TRASACH_tbl_NHANVIEN] FOREIGN KEY([maNV])
REFERENCES [dbo].[tbl_NHANVIEN] ([maNV])
GO
ALTER TABLE [dbo].[tbl_TRASACH] CHECK CONSTRAINT [FK_tbl_TRASACH_tbl_NHANVIEN]
GO
ALTER TABLE [dbo].[tbl_TRASACH]  WITH CHECK ADD  CONSTRAINT [FK_tbl_TRASACH_tbl_SACH] FOREIGN KEY([maSach])
REFERENCES [dbo].[tbl_SACH] ([maSach])
GO
ALTER TABLE [dbo].[tbl_TRASACH] CHECK CONSTRAINT [FK_tbl_TRASACH_tbl_SACH]
GO
USE [master]
GO
ALTER DATABASE [QLTV] SET  READ_WRITE 
GO
