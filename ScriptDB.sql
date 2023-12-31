USE [QuanLyThiTracNghiem]
GO
/****** Object:  UserDefinedTableType [dbo].[type_chiTietKetQuaThi]    Script Date: 19/07/2023 11:32:01 CH ******/
CREATE TYPE [dbo].[type_chiTietKetQuaThi] AS TABLE(
	[iMaKetQuaThi] [int] NULL,
	[iMaCauHoi] [int] NULL,
	[iCauTraLoi] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[type_deThi]    Script Date: 19/07/2023 11:32:01 CH ******/
CREATE TYPE [dbo].[type_deThi] AS TABLE(
	[iMaDethi] [int] NULL,
	[iMaCauHoi] [int] NULL
)
GO
/****** Object:  UserDefinedTableType [dbo].[type_maCauHoi]    Script Date: 19/07/2023 11:32:01 CH ******/
CREATE TYPE [dbo].[type_maCauHoi] AS TABLE(
	[iMaCauHoi] [int] NULL
)
GO
/****** Object:  Table [dbo].[tblSinhVien]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSinhVien](
	[vcMaSinhVien] [varchar](12) NOT NULL,
	[nvcTenSinhVien] [nvarchar](30) NOT NULL,
	[dtNgaySinh] [datetime] NOT NULL,
	[nvcGioiTinh] [nvarchar](5) NOT NULL,
	[vcMaLopHanhChinh] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vcMaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKetQuaThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKetQuaThi](
	[iMaKetQuaThi] [int] IDENTITY(1,1) NOT NULL,
	[vcMaMonThi] [varchar](5) NOT NULL,
	[iMaDeThi] [int] NOT NULL,
	[vcMaSinhVien] [varchar](12) NOT NULL,
	[iSoCauDung] [int] NOT NULL,
	[iSoCauSai] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaKetQuaThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_ketQuaThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_ketQuaThi]
as
select  iMaKetQuaThi N'Mã kết quả',vcMaMonThi N'Mã môn thi',iMaDeThi N'Mã đề',
	tblKetQuaThi.vcMaSinhVien N'Mã SV',tblSinhVien.nvcTenSinhVien N'Họ tên'
	,tblSinhVien.vcMaLopHanhChinh N'Lớp HC',Round((10*iSoCauDung)/(iSoCauDung+iSoCauSai),1) N'Điểm'
	from tblKetQuaThi,tblSinhVien
	where tblKetQuaThi.vcMaSinhVien=tblSinhVien.vcMaSinhVien
GO
/****** Object:  Table [dbo].[tblChiTietKetQuaThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChiTietKetQuaThi](
	[iMaKetQuaThi] [int] NOT NULL,
	[iMaCauHoi] [int] NOT NULL,
	[iCauTraLoi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaKetQuaThi] ASC,
	[iMaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChuong]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChuong](
	[vcMaMonThi] [varchar](5) NOT NULL,
	[nvcTenChuong] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[nvcTenChuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDanhSachThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDanhSachThi](
	[vcMaMonThi] [varchar](5) NOT NULL,
	[vcMaSinhVien] [varchar](12) NOT NULL,
	[bTrangThaiThi] [bit] NOT NULL,
	[vcMaXacNhan] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vcMaMonThi] ASC,
	[vcMaSinhVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDeThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDeThi](
	[iMaCauHoi] [int] NOT NULL,
	[iMaDeThi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaDeThi] ASC,
	[iMaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhoCauHoi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhoCauHoi](
	[iMaCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[nvcNoiDung] [nvarchar](max) NOT NULL,
	[nvcDapAnA] [nvarchar](max) NOT NULL,
	[nvcDapAnB] [nvarchar](max) NOT NULL,
	[nvcDapAnC] [nvarchar](max) NOT NULL,
	[nvcDapAnD] [nvarchar](max) NOT NULL,
	[iDapAnDung] [int] NOT NULL,
	[iDoKho] [int] NOT NULL,
	[vcMaMonThi] [varchar](5) NOT NULL,
	[nvcTenChuong] [nvarchar](30) NULL,
	[nvcDuongDanFileAnh] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLopHanhChinh]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLopHanhChinh](
	[vcMaLopHanhChinh] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[vcMaLopHanhChinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMaDeThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMaDeThi](
	[vcMaMonThi] [varchar](5) NOT NULL,
	[iMaDeThi] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[iMaDeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblMonThi]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMonThi](
	[vcMaMonThi] [varchar](5) NOT NULL,
	[nvcTenMonThi] [nvarchar](50) NOT NULL,
	[iSoTinChi] [int] NOT NULL,
	[iSoCauHoi] [int] NOT NULL,
	[nvcHocKy] [nvarchar](30) NOT NULL,
	[dtNgayBatDauThi] [date] NOT NULL,
	[tThoiGianThi] [time](0) NULL,
PRIMARY KEY CLUSTERED 
(
	[vcMaMonThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaiKhoan]    Script Date: 19/07/2023 11:32:01 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaiKhoan](
	[vcTenDangNhap] [varchar](30) NOT NULL,
	[vcMatKhau] [varchar](20) NOT NULL,
	[iQuyenTruyCap] [int] NOT NULL,
	[vcMaSinhVien] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[vcTenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 72, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 109, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 110, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 111, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 114, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 116, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 119, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 120, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 122, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (17, 127, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 149, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 150, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 151, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 152, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 153, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 154, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 155, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 156, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 157, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (18, 158, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 181, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 182, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 183, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 184, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 185, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 186, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 187, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 188, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 189, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (19, 190, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 133, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 137, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 138, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 148, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 157, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 158, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 164, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 170, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 180, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (20, 190, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 181, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 182, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 183, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 184, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 185, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 186, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 187, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 188, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 189, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (21, 190, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 72, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 73, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 74, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 75, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 76, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 77, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 78, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 79, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 80, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (22, 81, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 82, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 83, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 84, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 85, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 86, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 87, 4)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 88, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 89, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 90, 2)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (23, 91, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 72, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 109, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 110, 1)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 111, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 114, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 116, 3)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 119, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 120, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 122, 0)
INSERT [dbo].[tblChiTietKetQuaThi] ([iMaKetQuaThi], [iMaCauHoi], [iCauTraLoi]) VALUES (24, 127, 0)
GO
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'MANG', N'chương 1')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'chương 1 1930-1945')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'TRR', N'chương 1- logic mệnh đề')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'XSTK', N'chương 1-xác suất cổ điển')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'MANG', N'chương 2')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'chương 2 1945-1975')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'MANG', N'chương 3')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'chương 3 1976-1986')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'MANG', N'chương 4')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'chương 4 1986-2011')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'MANG', N'chương 5')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'chương 5 2011-2021')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'GT1', N'giới hạn hàm số')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'LSÐ', N'Giới thiệu')
INSERT [dbo].[tblChuong] ([vcMaMonThi], [nvcTenChuong]) VALUES (N'TA1', N'Unit 1')
GO
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'GT1', N'21A100100416', 0, N'7F979')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'LSÐ', N'21A100100100', 1, N'C9QJ8')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'LSÐ', N'21A100100414', 1, N'3Y4K7')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'LSÐ', N'21A100100415', 1, N'FGUKR')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'LSÐ', N'21A100100416', 1, N'M5XH1')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'MANG', N'21A100100100', 1, N'5XEIH')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'MANG', N'21A100100414', 1, N'VATTL')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'MANG', N'21A100100415', 1, N'NGKPT')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'MANG', N'21A100100416', 1, N'MU5XN')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'TA1', N'21A100100416', 0, N'3Y4K7')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'TA2', N'21A100100416', 0, N'C9QJ8')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'TRR', N'21A100100416', 0, N'KL9WZ')
INSERT [dbo].[tblDanhSachThi] ([vcMaMonThi], [vcMaSinhVien], [bTrangThaiThi], [vcMaXacNhan]) VALUES (N'XSTK', N'21A100100416', 0, N'DRNUM')
GO
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (72, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (73, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (74, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (85, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (92, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (97, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (98, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (103, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (107, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (132, 100)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (72, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (109, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (110, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (111, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (114, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (116, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (119, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (120, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (122, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (127, 101)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (72, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (73, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (74, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (75, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (76, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (77, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (78, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (79, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (80, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (81, 102)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (82, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (83, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (84, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (85, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (86, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (87, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (88, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (89, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (90, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (91, 103)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (133, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (137, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (138, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (148, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (157, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (158, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (164, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (170, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (180, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (190, 200)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (149, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (150, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (151, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (152, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (153, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (154, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (155, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (156, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (157, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (158, 201)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (136, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (137, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (138, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (139, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (140, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (141, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (142, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (143, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (144, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (145, 202)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (181, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (182, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (183, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (184, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (185, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (186, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (187, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (188, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (189, 203)
INSERT [dbo].[tblDeThi] ([iMaCauHoi], [iMaDeThi]) VALUES (190, 203)
GO
SET IDENTITY_INSERT [dbo].[tblKetQuaThi] ON 

INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (17, N'LSÐ', 101, N'21A100100416', 3, 7)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (18, N'MANG', 201, N'21A100100414', 7, 3)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (19, N'MANG', 203, N'21A100100415', 1, 9)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (20, N'MANG', 200, N'21A100100100', 6, 4)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (21, N'MANG', 203, N'21A100100416', 3, 7)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (22, N'LSÐ', 102, N'21A100100414', 0, 10)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (23, N'LSÐ', 103, N'21A100100100', 4, 6)
INSERT [dbo].[tblKetQuaThi] ([iMaKetQuaThi], [vcMaMonThi], [iMaDeThi], [vcMaSinhVien], [iSoCauDung], [iSoCauSai]) VALUES (24, N'LSÐ', 101, N'21A100100415', 0, 10)
SET IDENTITY_INSERT [dbo].[tblKetQuaThi] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKhoCauHoi] ON 

INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (72, N'Đối tượng nghiên cứu của khoa học Lịch sử Đảng Cộng sản Việt Nam là:', N'Các cán bộ, đảng viên Đảng Cộng sản Việt Nam', N'Những mặt hạn chế trong quá trình lãnh đạo của Đảng', N'Sự ra đời, phát triển và hoạt động lãnh đạo của Đảng qua các thời kỳ lịchsử', N'Các văn kiện của Đảng chuẩn bị được lưu hành', 3, 1, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (73, N'Là một ngành của khoa học lịch sử, Lịch sử Đảng Cộng sản Việt Nam có cácchức năng, nhiệm vụ của khoa học lịch sử, đồng thời còn có thêm các chức năngnổi bật khác là:', N'Chức năng nhận thức, điều tiết, chọn lọc và tìm kiếm', N'Chức năng nhận thức, giáo dục, dự báo và phê phán', N'Chức năng tuyên truyền, phổ cập, giáo huấn và phổ quát', N'Chức năng giáo dục, sàng lọc, tuyên truyền và tìm kiếm', 2, 2, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (74, N'Một trong những nhiệm vụ hàng đầu khi nghiên cứu khoa học Lịch sử ĐảngCộng sản Việt Nam là:', N'Khẳng định, chứng minh giá trị khoa học của những mục tiêu chiến lược vàsách lược cách mạng mà Đảng đề ra trong cương lĩnh', N'Làm cho người học hiểu được quyền lực của Đảng, từ đó thêm trung thành vớiđường lối lãnh đạo của Đảng', N'Chọn lọc ra những sự kiện lịch sử nổi bật để tái hiện lại sự thành công trong quátrình lãnh đạo của Đảng', N'Tìm hiểu về lịch sử ra đời của đảng cộng sản trên thế giới', 1, 2, N'LSÐ', N'Giới thiệu', N'D:\ảnh nền\8g9wB.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (75, N'Trong phương pháp nghiên cứu, học tập môn học Lịch sử Đảng Cộng sản ViệtNam cần phải dựa trên phương pháp luận khoa học mác-xít, đồng thời phải nắmvững chủ nghĩa nào dưới đây để xem xét và nhận thức lịch sử một cách kháchquan, trung thực và đúng quy luật?', N'Chủ nghĩa duy vật biện chứng và chủ nghĩa duy vật lịch sử', N'Chủ nghĩa duy vật và chủ nghĩa duy tâm', N'Chủ nghĩa duy lý và chủ nghĩa duy vật biện chứng', N'Chủ nghĩa duy lý và chủ nghĩa duy vật lịch sử', 1, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (76, N'Tại sao khi nghiên cứu, học tập Lịch sử Đảng Cộng sản Việt Nam lại cần phảinhận thức và vận dụng chủ nghĩa duy vật lịch sử?', N'Để thấy được sự ưu việt của Đảng Cộng sản Việt Nam so với các đảng phái ởphương Tây', N'Để nhận thức tiến trình cách mạng do Đảng Cộng sản Việt Nam lãnh đạo', N'Để hiểu được sứ mệnh lịch sử của giai cấp nông dân trong lãnh đạo cách mạng', N'Để hiểu vì sao cách mạng giải phóng dân tộc ở Việt Nam đi theo con đường tưsản', 2, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (77, N'Trong nghiên cứu Lịch sử Đảng Cộng sản Việt Nam, khi xem xét, đối chiếu cáchiện tượng lịch sử trong hình thức tổng quát nhằm mục đích vạch ra bản chất, quyluật, khuynh hướng chung trong sự vận động của sự vật thì đó là cách nghiên cứudựa trên:', N'Phương pháp lịch sử', N'Phương pháp chọn lọc', N'Phương pháp làm việc nhóm', N'Phương pháp logic', 4, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (78, N'Cần phải coi trọng phương pháp tổng kết thực tiễn lịch sử gắn với nghiên cứu lýluận trong nghiên cứu Lịch sử Đảng Cộng sản Việt Nam để:', N'Làm rõ kinh nghiệm, bài học, quy luật phát triển của cách mạng Việt Nam', N'Làm hài lòng người dân trong quá trình lãnh đạo cách mạng của Đảng', N'Dễ dàng thống kê những thành tựu mà Đảng đạt được trong lãnh đạo cách mạng', N'Chứng tỏ sự linh hoạt trong các bước đề ra đường lối, chủ trương của Đảng', 1, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (79, N'Việc tiến hành thảo luận, trao đổi các vấn đề do giảng viên đưa ra để có thể hiểurõ hơn nội dung của môn học Lịch sử Đảng Cộng sản Việt Nam thì được gọi là:', N'Phương pháp làm việc khách quan', N'Phương pháp làm việc nhóm', N'Phương pháp làm việc chủ quan', N'Phương pháp làm việc biện chứng', 2, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (80, N'Một trong những ý nghĩa của việc nghiên cứu, học tập môn học Lịch sử ĐảngCộng sản Việt Nam đối với sinh viên là:', N'Tích cực cổ vũ, tham gia vào quá trình “tự diễn biến”, “tự chuyển hoá” trongĐảng', N'Giáo dục lý tưởng, truyền thống đấu tranh của Đảng, bồi đắp niềm tin vàosự lãnh đạo của Đảng', N'Tin vào sự lãnh đạo của Đảng đưa đất nước tiến nhanh, mạnh, vững chắc theocon đường tư bản chủ nghĩa', N'Tham gia xây dựng cải cách, cải tổ Đảng theo mô hình của Đông Âu và Liên Xônhằm làm cho Đảng thêm vững mạnh', 2, 3, N'LSÐ', N'Giới thiệu', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (81, N'Mâu thuẫn cơ bản của xã hội Việt Nam kể từ khi Pháp xâm lược là gì?', N'Mâu thuẫn giữa dân tộc ta với thực dân Pháp, mâu thuẫn giữa nông dânvới địa chủ phong kiến', N'Mâu thuẫn giữa công nhân với tư bản, mâu thuẫn giữa nông dân với địa chủphong kiến', N'Mâu thuẫn giữa nông dân với địa chủ phong kiến, mâu thuẫn giữa tư sản với vôsản', N'Mâu thuẫn giữa nông dân, công nhân với địa chủ phong kiến', 1, 1, N'LSÐ', N'Giới thiệu', N'D:\ẢNH MÀN HÌNH\0b549b82e4d3c640ead42f9b66697d92.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (82, N'Ở Việt Nam, giai cấp mới nào đã ra đời dưới tác động của cuộc khai thác thuộcđịa lần thứ nhất (1897 - 1914) của thực dân Pháp?', N'Tư sản', N'Nông dân', N'Công nhân', N'Tiểu tư sản', 3, 2, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (83, N'Trước khi thực dân Pháp nổ súng xâm lược (1858), xã hội Việt Nam có nhữnggiai cấp cơ bản nào?', N'Địa chủ phong kiến và nông dân', N'Địa chủ phong kiến và công nhân', N'Công nhân và nông dân', N'Nông dân và tri thức', 1, 2, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (84, N'Các phong trào yêu nước ở Việt Nam trước khi có Đảng Cộng sản lãnh đạo cóđiểm chung là:', N'Không nhận được sự ủng hộ của người dân, đặc biệt là giai cấp công - nông', N'Không thông qua ý kiến của Quốc tế Cộng sản, đặc biệt Đảng Cộng sản Liên Xô', N'Không có đường lối rõ ràng dẫn đến thất bại và bị thực dân Pháp đàn ápmột cách nặng nề', N'Không có đủ tiềm lực tài chính và người đứng đầu lãnh đạo cách mạng', 3, 2, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (85, N'Thực dân Pháp đã thực hiện chính sách gì về văn hoá xã hội để cai trị nước ta?', N'Ngu dân', N'Bế quan toả cảng', N'Đốt sách chôn Nho', N'Chia để trị', 1, 1, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (86, N'Tầng lớp tư sản mại bản của Việt Nam dưới thời Pháp thuộc có đặc điểm là:', N'Có sự tham gia vào đời sống chính trị, kinh tế của chính quyền thực dânPháp', N'Có tiềm lực kinh tế mạnh, là giai cấp đông đảo nhất trong xã hội', N'Không có tư liệu sản xuất, phải bán sức lao động trong các nhà máy, xí nghiệp', N'Chịu ba tầng áp bức, bóc lột: đế quốc, phong kiến và tư sản dân tộc', 1, 3, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (87, N'Vì sao tầng lớp tiểu tư sản lại không thể là lực lượng lãnh đạo cách mạngchống Pháp?', N'Vì địa vị kinh tế, chính trị của họ gắn chặt với Pháp', N'Vì lực lượng này hoàn toàn không có mâu thuẫn về quyền lợi với thực dân Pháp', N'Vì địa vị kinh tế của họ bấp bênh, thái độ hay dao động', N'Vì lực lượng này nhận được nhiều cảm tình của thực dân Pháp', 3, 3, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (88, N'Cuối thế kỷ XIX - đầu thế kỷ XX, nhiệm vụ hàng đầu cần phải được giải quyếtcấp thiết của cách mạng Việt Nam là:', N'Giải phóng dân tộc', N'Đấu tranh giai cấp', N'Canh tân đất nước', N'Chia lại ruộng đất', 1, 2, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (89, N'Sự kiện nào đã đánh dấu phong trào công nhân Việt Nam hoàn toàn trở thànhmột phong trào tự giác?', N'Năm 1920, khi tổ chức công hội ở Sài Gòn được thành lập', N'Năm 1925, khi cuộc bãi công ở nhà máy Ba Son diễn ra rầm rộ', N'Năm 1929, khi có sự ra đời của ba tổ chức cộng sản', N'Năm 1930, khi Đảng Cộng sản Việt Nam ra đời', 4, 2, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (90, N'Sự kiện nào được Nguyễn Ái Quốc đánh giá “như chim én nhỏ báo hiệu mùaxuân”?', N'Cách mạng Tháng Mười Nga bùng nổ và thắng lợi (1917)', N'Sự thành lập Đảng Cộng sản Pháp (1920)', N'Vụ mưu sát viên toàn quyền Méc-Lanh của Phạm Hồng Thái (1924)', N'Sự ra đời của Hội Việt Nam cách mạng Thanh niên (1925)', 3, 4, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (91, N'Phong trào đình công, bãi công của công nhân Việt Nam trong những năm1926 - 1929 thuộc khuynh hướng nào?', N'Khuynh hướng phong kiến', N'Khuynh hướng dân chủ tư sản', N'Khuynh hướng vô sản', N'Khuynh hướng dân chủ', 3, 4, N'LSÐ', N'chương 1 1930-1945', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (92, N'Ai là người đại diện cho chủ trương đánh đuổi thực dân Pháp giành độc lập dântộc, khôi phục chủ quyền quốc gia bằng biện pháp bạo động?', N'Bùi Quang Chiêu', N'Phan Châu Trinh', N'Phan Bội Châu', N'Nguyễn Ái Quốc', 3, 1, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (93, N'Sự kiện nào đánh dấu bước ngoặt trong cuộc đời hoạt động cách mạng củaNguyễn Ái Quốc - từ người yêu nước trở thành người cộng sản?', N'Bỏ phiếu tán thành việc gia nhập Quốc tế III và tham gia thành lập ĐảngCộng sản Pháp', N'Đọc bản Sơ thảo lần thứ nhất những luận cương về vấn đề dân tộc và vấn đềthuộc địa của Lênin', N'Gửi Bản yêu sách của nhân dân An Nam tới Hội nghị Véc-xây', N'Ra đi tìm đường cứu nước', 1, 2, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (94, N'Hội Liên hiệp các dân tộc thuộc địa có cơ quan ngôn luận là tờ báo nào?', N'Thanh niên', N'Cờ đỏ', N'Độc lập', N'Người cùng khổ', 4, 2, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (95, N'Nguyễn Ái Quốc đã đọc bản Sơ thảo lần thứ nhất những luận cương về vấn đềdân tộc và vấn đề thuộc địa của Lênin đăng trên báo Nhân đạo vào năm:', N'1919', N'1920', N'1921', N'1922', 2, 2, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (96, N'Phong trào cách mạng Việt Nam vào cuối năm 1928, đầu năm 1929 đã hìnhthành làn sóng cách mạng nào dưới đây?', N'Cách mạng tư sản dân quyền', N'Cách mạng dân tộc, dân chủ', N'Cách mạng văn hoá', N'Cách mạng tư sản', 2, 2, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (97, N'Khẩu hiệu “Không thành công thì cũng thành nhân” được sử dụng trong cuộckhởi nghĩa nào dưới đây?', N'Ba Đình', N'Bãi Sậy', N'Yên Bái', N'Hương Khê', 3, 3, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (98, N'Tác phẩm nào của Nguyễn Ái Quốc đã vạch rõ âm mưu và thủ đoạn của chủnghĩa đế quốc che giấu tội ác dưới cái vỏ bọc “khai hoá văn minh”?', N'Bản án chế độ thực dân Pháp', N'Đường Kách mệnh', N'Nhật ký trong tù', N'Con rồng tre', 1, 3, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (99, N'Hoạt động nào dưới đây của Nguyễn Ái Quốc có ý nghĩa là sự chuẩn bị về mặttổ chức cho việc thành lập Đảng Cộng sản Việt Nam?', N'Mở các lớp huấn luyện chính trị nhằm đào tạo cán bộ cho cách mạng Việt Nam(từ năm 1925 -1927)', N'Chủ trì Hội nghị hợp nhất các tổ chức cộng sản (2/1930)', N'Tham gia sáng lập Đảng Cộng sản Pháp (12/1920)', N'Thành lập Hội Việt Nam Cách mạng Thanh niên (6/1925)', 4, 3, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (100, N'Cơ quan ngôn luận của Hội Việt Nam Cách mạng Thanh niên là tờ báo nào?', N'Người cùng khổ', N'Lao động', N'Công nhân', N'Thanh niên', 4, 3, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (101, N'Sự kiện nào đánh dấu giai cấp công nhân Việt Nam đã bước đầu đi vào đấutranh tự giác?', N'Bãi công của công nhân thợ nhuộm Sài Gòn - Chợ Lớn (1922)', N'Tổng bãi công của công nhân Bắc Kỳ (1922)', N'Bãi công của thợ máy xưởng Ba Son cảng Sài Gòn (1925)', N'Bãi công của công nhân nhà máy sợi Nam Định (1930)', 3, 4, N'LSÐ', N'chương 2 1945-1975', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (102, N'Tác phẩm nào dưới đây của Nguyễn Ái Quốc đã đề cập đến những vấn đề cơbản của một cương lĩnh chính trị, chuẩn bị về tư tưởng, chính trị cho việc thành lậpĐảng?', N'Bản án chế độ thực dân Pháp (1925)', N'Đường Kách mệnh (1927)', N'Đông Dương (1924)', N'Nhật ký trong tù (1943)', 2, 1, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (103, N'Tính chất và nhiệm vụ của cách mạng Việt Nam được thể hiện trong tác phẩm“Đường Kách mệnh” của Nguyễn Ái Quốc là:', N'Cách mạng giải phóng dân tộc mở đường tiến lên chủ nghĩa xã hộ', N'Tư sản dân quyền và thổ địa cách mạng để đi tới xã hội cộng sản', N'Canh tân đất nước theo xu hướng của Minh Trị duy tân ở Nhật', N'Cách mạng xã hội chủ nghĩa để đi lên xã hội cộng sản', 1, 2, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (104, N'Chi bộ Cộng sản thành lập ở Bắc Kỳ tháng 3/1929 nhằm mục đích gì?', N'Củng cố ảnh hưởng của Hội Việt Nam Cách mạng Thanh niên', N'Xây dựng đội ngũ cán bộ cho cách mạng, chuẩn bị Đại hội Đảng', N'Thành lập Đội Việt Nam tuyên truyền giải phóng quân', N'Chuẩn bị thành lập một đảng cộng sản thay thế Hội Việt Nam Cách mạngThanh niên', 4, 2, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (105, N'Tổ chức nào được Nguyễn Ái Quốc thành lập tại Quảng Châu (Trung Quốc)vào tháng 6/1925?', N'Tâm tâm xã', N'Hội Việt Nam Cách mạng đồng minh', N'Hội Liên hiệp thuộc địa', N'Hội Việt Nam Cách mạng Thanh niên', 4, 2, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (106, N'Tổ chức cộng sản nào ra đời đầu tiên ở Việt Nam?', N'Hội Việt Nam Cách mạng Thanh niên', N'Đông Dương Cộng sản Đảng', N'An Nam Cộng sản Đảng', N'Đông Dương Cộng sản Liên đoàn', 2, 2, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (107, N'Ý nghĩa của phong trào Vô sản hoá do Hội Việt Nam Cách mạng Thanh niênphát động vào năm 1928 là:', N'Truyền bá tư tưởng vô sản, xây dựng, phát triển tổ chức của công nhân', N'Khuyến khích công nhân mít-tinh, biểu tình, đập phá máy móc, nhà xưởng', N'Truyền bá chủ nghĩa Mác - Lênin vào trong giai cấp nông dân', N'Giúp cho giai cấp nông dân nhận ra sứ mệnh lãnh đạo cách mạng của mình', 2, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (108, N'Sự ra đời của ba tổ chức cộng sản diễn ra trong vòng nửa cuối năm 1929 đãkhẳng định điều gì?', N'Cách mạng Việt Nam đã có bước phát triển về chất, phù hợp với yêu cầucủa lịch sử', N'Cách mạng Việt Nam đã vượt qua khủng hoảng về đường lối lãnh đạo', N'Cách mạng Việt Nam đã đủ mạnh để đương đầu với thực dân Pháp', N'Cách mạng Việt Nam đã trở thành một bộ phận của cách mạng thế giới', 1, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (109, N'Trước tình hình các tổ chức cộng sản hoạt động biệt lập, bài xích lẫn nhau đãdẫn đến một yêu cầu bức thiết cho cách mạng Việt Nam lúc đó là:', N'Giải tán các tổ chức cộng sản', N'Giảng hoà sự bài xích, biệt lập giữa các tổ chức cộng sản', N'Thống nhất các tổ chức cộng sản', N'Kiểm điểm nghiêm túc các tổ chức cộng sản', 3, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (110, N'Trong Cương lĩnh chính trị đầu tiên, Đảng xác định “mục tiêu chiến lược củacách mạng Việt Nam là ……và thổ địa cách mạng để đi tới xã hội cộng sản.” Từcòn thiếu trong chỗ trống là:', N'Xã hội chủ nghĩa', N'Dân quyền cách mạng', N'Dân tộc dân chủ', N'Dân tộc dân chủ nhân dân', 2, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (111, N'Cương lĩnh chính trị đầu tiên của Đảng được thông qua tại Hội nghị thành lậpĐảng Cộng sản Việt Nam ngày 3/2/1930 đã xác định giai cấp nào là lực lượng lãnhđạo cách mạng?', N'Giai cấp tư sản', N'Giai cấp công nhân', N'Giai cấp nông dân', N'Giai cấp địa chủ', 2, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (112, N'Sự kiện nào được Nguyễn Ái Quốc đánh giá “giai cấp vô sản ta đã trưởngthành và đủ sức lãnh đạo cách mạng”?', N'Hội nghị Thành lập Đảng Cộng sản Việt Nam (1930)', N'Chi bộ Cộng sản đầu tiên của Việt Nam ra đời (1929)', N'Thành lập tổ chức Công hội đỏ Bắc Kỳ (1929)', N'Sự ra đời của ba tổ chức Cộng sản (1929)', 1, 3, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (113, N'Hai văn kiện nào dưới đây được coi như là Cương lĩnh chính trị đầu tiên củaĐảng Cộng sản Việt Nam?', N'Chánh cương vắn tắt và Lời kêu gọi của Đảng', N'Sách lược vắn tắt và Lời kêu gọi của Đảng', N'Chánh cương vắn tắt và Sách lược vắn tắt của Đảng', N'Sách lược vắn tắt và Chương trình tóm tắt của Đảng', 3, 4, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (114, N'Nội dung nào sau đây nằm trong Cương lĩnh chính trị đầu tiên của Đảng?', N'Đánh đổ đế quốc Pháp và phong kiến, làm cho nước Nam hoàn toàn độc lập', N'Tư sản dân quyền cách mạng là thời kỳ dự bị để làm xã hội cách mạng', N'Chỉ có giải phóng giai cấp vô sản thì mới giải phóng được dân tộc', N'Giai cấp nông dân là lực lượng lãnh đạo cách mạng', 1, 4, N'LSÐ', N'chương 3 1976-1986', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (115, N'Đại hội VII của Quốc tế Cộng sản (7/1935) đã vạch ra nhiệm vụ trước mắt củagiai cấp công nhân và nhân dân lao động thế giới là:', N'Giành lại ruộng đất cho nông dân từ tay giai cấp tư sản ở các nước thuộc địa', N'Đấu tranh chống chủ nghĩa phát-xít, chống chiến tranh, bảo vệ dân chủ vàhòa bình', N'Đấu tranh chống lại nạn bóc lột sức lao động trẻ em ở các nước thuộc địa', N'Loại bỏ giai cấp tư sản ra khỏi lực lượng cách mạng', 2, 1, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (116, N'Trong Văn kiện “Chung quanh vấn đề chính sách mới” (10/1936), Đảng nêuquan điểm: “Cuộc dân tộc giải phóng không nhất thiết phải kết hợp chặt chẽ với…… Nghĩa là không thể nói rằng muốn đánh đổ đế quốc cần phải phát triển……Lý thuyết ấy có chỗ chưa xác đáng.” Từ còn thiếu trong các chỗ trống trên là:', N'Cách mạng điền địa', N'Cách mạng dân tộc dân chủ nhân dân', N'Cách mạng tư sản', N'Cách mạng vô sản', 1, 1, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (117, N'Điều kiện nào tạo ra khả năng đấu tranh công khai, hợp pháp cho phong tràocách mạng Đông Dương giai đoạn 1936 - 1939?', N'Sự xuất hiện chủ nghĩa tư bản và nguy cơ Chiến tranh Thế giới thứ nhất', N'Đảng Cộng sản Pháp giao quyền cai trị Việt Nam cho Nhật', N'Mặt trận nhân dân Pháp lên cầm quyền ở Đông Dương', N'Chiến tranh Thế giới thứ hai kết thúc, phe phát-xít lên cầm quyền ở ĐôngDương', 3, 2, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (118, N'Nhiệm vụ của cách mạng Việt Nam được Đảng ta xác định trong thời kỳ 1936 -1939 là:', N'Đánh đuổi quân đội Tưởng Giới Thạch và các phe phái phản động ở trong nước', N'Tịch thu ruộng đất của địa chủ phong kiến chia cho dân cày', N'Chống phát-xít, chống chiến tranh đế quốc, chống bọn phản động thuộc địa,đòi tự do, dân chủ, cơm áo hòa bình', N'Đàm phán thông qua ngoại giao với thực dân Pháp để giành lại độc lập dân tộc', 3, 2, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (119, N'Hình thức đấu tranh mới xuất hiện trong phong trào dân chủ 1936 - 1939 ở ViệtNam là:', N'Mít-tinh biểu tình', N'Đấu tranh nghị trường', N'Đấu tranh chính trị', N'Bãi khoá, bãi công', 2, 2, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (120, N'Chủ trương và nhận thức mới của Đảng trong những năm 1936 - 1939 đã xácđịnh kẻ thù nguy hại trước mắt của nhân dân Đông Dương là:', N'Chủ nghĩa phát-xít và phong kiến tay sai', N'Chủ nghĩa đế quốc và phong kiến', N'Phong kiến và tư sản mại bản', N'Phản động thuộc địa và bè lũ tay sai', 4, 2, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (121, N'Một trong những ý nghĩa của phong trào vận động dân chủ 1936 - 1939 là:a. Thực dân Pháp phải chấp nhận tất cả những yêu sách dân chủ', N'Thực dân Pháp phải chấp nhận tất cả những yêu sách dân chủ', N'Giúp cán bộ, đảng viên của Đảng được rèn luyện và trưởng thành', N'Thực dân Pháp rút quân ra khỏi lãnh thổ Việt Nam', N'Đưa các cán bộ của Đảng gia nhập vào Nghị trường Pháp', 2, 3, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (122, N'Tháng 3/1938, Đảng quyết định thành lập tổ chức nào để tập hợp rộng rãi lựclượng đông đảo nhân dân chống phát-xít và tay sai phản động?', N'Mặt trận Liên Việt', N'Mặt trận Thống nhất Dân tộc phản đế Đông Dương', N'Mặt trận Nhân dân phản đế Đông Dương', N'Mặt trận Dân chủ Đông Dương', 4, 3, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (123, N'Từ việc theo dõi diễn biến của cuộc Chiến tranh Thế giới thứ hai và căn cứ vàotình hình trong nước, Ban Chấp hành Trung ương Đảng xác định nhiệm vụ trungtâm cách mạng Việt Nam trong giai đoạn 1939 - 1945 là:', N'Chuẩn bị khởi nghĩa vũ trang', N'Giành lại ruộng đất cho dân cày nghèo', N'Phá kho thóc Nhật để cứu đói', N'Thành lập Mặt trận Việt Minh', 1, 3, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (124, N'Trong giai đoạn 1939 - 1945, nhiệm vụ của cách mạng Việt Nam được Đảng tađưa lên hàng đầu là gì?', N'Đòi quyền dân chủ', N'Giải phóng dân tộc', N'Đánh đổ phong kiến', N'Đánh đổ tư sản', 2, 3, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (125, N'Khi Chiến tranh Thế giới Thứ hai bùng nổ, Đảng đã tiến hành hoạt động gì đểthích ứng với tình hình mới?', N'Tuyên bố tự giải tán, chỉ để lại một bộ phận rất nhỏ hoạt động ngầm ở các thànhphố', N'Hợp tác với quân đội Pháp để đảo chính Nhật', N'Rút vào hoạt động bí mật, chuyển trọng tâm công tác về nông thôn', N'Tăng cường các hoạt động chống phát-xít ở các thành phố lớn', 3, 4, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (126, N'Khi chiến tranh Thế giới Thứ hai bùng nổ, thực dân Pháp đã thi hành chínhsách gì ở Việt Nam?', N'Kinh tế thời chiến', N'Kinh tế thuộc địa thời chiến', N'Kinh tế chỉ huy', N'Kinh tế hàng hoá', 3, 4, N'LSÐ', N'chương 4 1986-2011', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (127, N'Chính sách nào của Nhật - Pháp đã gây ra nạn đói lớn ở Việt Nam cuối năm1944 - đầu năm 1945?', N'Xuất khẩu các nguyên liệu chiến lược sang Nhật Bản', N'Bắt người dân nhổ lúa, trồng đay lấy nguyên liệu phục vụ chiến tranh', N'Đầu tư vào những ngành công nghiệp phục vụ quân sự', N'Kiểm soát toàn bộ hệ thống đường sá', 2, 1, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (128, N'Điền từ còn thiếu vào chỗ trống về nhận định của Đảng ta tại Hội nghị Trungương 5/1941: “Cuộc cách mạng Đông Dương trong giai đoạn hiện tại là một cuộccách mạng ……”', N'Tư sản dân quyền', N'Dân chủ tư sản', N'Xã hội chủ nghĩa', N'Dân tộc giải phóng', 4, 2, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (129, N'Nguyễn Ái Quốc về nước trực tiếp lãnh đạo cách mạng Việt Nam vào năm', N'1930', N'1935', N'1941', N'1945', 3, 3, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (130, N'Tại Hội Nghị Trung ương Đảng lần thứ VIII (5/1941), Nguyễn Ái Quốc đã chủtrương thành lập mặt trận nào?', N'Mặt trận Liên Việt', N'Mặt trận Đồng Minh', N'Mặt trận Việt Minh', N'Mặt trận Dân tộc thống nhất phản đế Đông Dương', 3, 4, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (131, N'Để làm tiền đề cho cuộc Tổng khởi nghĩa Tháng 8/1945, chỉ thị “Nhật - Phápbắn nhau và hành động của chúng ta” đã đề ra chủ trương nào dưới đây?', N'Phát động tổng khởi nghĩa', N'Phát động khởi nghĩa từng phần', N'Phát động cao trào kháng Nhật cứu nước', N'Phát động phong trào kháng chiến kiến quốc', 3, 3, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (132, N'Điểm mới của Hội nghị lần thứ VIII (5/1941) so với Hội nghị lần thứ VI(11/1939) của ban Chấp hành Trung ương Đảng là:', N'Mở rộng hình thức tập hợp lực lượng và thành lập Mặt trận Dân chủ ĐôngDương', N'Đề cao hơn nữa nhiệm vụ giải phóng dân tộc', N'Đặt ra vấn đề giải phóng dân tộc trong từng nước Đông Dương', N'Chú trọng đấu tranh vũ trang để giải phóng dân tộc', 3, 4, N'LSÐ', N'chương 5 2011-2021', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (133, N'Lớp truy cập mạng trong mô hình giao thức TCP/IP tương ứng với lớp/cụm các lớp nào trong mô hình OSI?', N'Lớp vật lý', N'Là Lớp vật lý, lớp liên kết dữ liệu', N'Lớp mạng', N'D.Lớp vật lý, lớp lien kết dữ liệu, lớp mạng', 2, 1, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (134, N'Chức năng của lớp mạng trong mô hình TCP/IP là?', N'Đóng gói dữ liệu IP vào khung', N'Điểu khiển luồng', N'C.Là Định tuyến', N'D.Ánh xạ địa chỉ IP sang địa chỉ vật lý', 3, 1, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (135, N'Kỹ thuật SCMA/CD thì mỗi nút mạng sẽ thử truy cập ngẫu nhiên và đợi trong khoảng thời gian là bao lâu?', N'102.2µs', N'Là Bằng số ngẫu nhiên với khe thời gian', N'51.2 µs', N'52.1 µs', 2, 1, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (136, N'Kỹ thuật chuyển thẻ bài được sử dụng trong cấu trúc mạng nào?', N'Là Cấu trúc Ring', N'Cấu trúc Bus', N'Cấu trúc Mesh', N'Cấu trúc Star', 1, 1, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (137, N'Định dạng đơn vị thông tin tại lớp truy nhập mạng là?', N'Đoạn dữ liệu', N'Gói dữ liệu', N'Bản tin', N'Là Khung dữ liệu', 4, 2, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (138, N'Định dạng đơn vị thông tin tại lớp liên mạng là?', N'Là Gói dữ liệu', N'Đoạn dữ liệu', N'Bản tin', N'Là Khung dữ liệu', 1, 2, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (139, N'Định dạng đơn vị thông tin tại lớp ứng dụng là?', N'Là Bản tin', N'Khung dữ liệu', N'Đoạn dữ liệu', N'Gói dữ liệu', 1, 2, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (140, N'Giao thức IP hoạt động tại lớp nào trong mô hình TCP/IP?', N'Lớp truy nhập mạng', N'Là Lớp liên mạng', N'Lớp phiên', N'Lớp truyền tải', 2, 2, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (141, N'Chức năng của giao thức IP là?', N'Là Định nghĩa cơ chế định địa chỉ trong mạng Internet', N'Phân đoạn và tái tạo dữ liệu', N'Định hướng đường cho các đơn vị dữ liệu đến các host ở xa', N'Phân đoạn', 1, 3, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (142, N'Chức năng của giao thức thức bản tin điều khiển (ICMP- lệnh ping) là?', N'Định tuyến lại', N'Điều khiển luồng, phát hiện sự không đến đích', N'Là Kiểm tra các host ở xa có hoạt động hay không', N'Điều khiển luồng', 1, 3, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (143, N'Chọn phát biểu ĐÚNG về đặc tính của mnagj LAN?', N'Tốc độ dữ liệu không cao, phạm vi địa lý không giới hạn và ít lỗi', N'Tốc độ dữ liệu không cao, phạm vi địa lý bị giới hạn và ít lỗi', N'Tốc độ truyền dữ liệu cao, không giới hạn phạm vi và ít lỗi', N'Là Tốc độ dữ liệu cao, phạm vi địa lý bị giới hạn và ít lỗi', 4, 3, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (144, N'Lớp nào (Layer) trong mô hình OSI chịu trách nhiệm mã hóa (encryption) dữ liệu?', N'Là Presentation', N'Application', N'Session', N'Transport', 1, 3, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (145, N'Card mạng (NIC) thuộc tầng nào trong mô hình OSI?', N'Layer 3', N'Layer 5', N'Là Layer 2', N'Layer 4', 3, 4, N'MANG', N'chương 1', N'D:\ảnh gundam\GearVN_Gundam_-8-1920x916.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (146, N'Routers định tuyến gói dữ liệu ở tầng nào trong mô hình TCP/IP?', N'Layer 3', N'Layer 1', N'Layer 4', N'Layer 2', 1, 4, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (147, N'Công nghệ LAN nào sử dụng CSMA/CD?', N'Là Ethernet', N'Các phương án khác đều đúng', N'Token Ring', N'FDDI', 1, 4, N'MANG', N'chương 1', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (148, N'Trang thiết bị mạng nào làm giảm bớt sự va chạm (collisions)?', N'Là Switch', N'Hub', N'NIC', N'Các phương án khác đều đúng', 1, 1, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (149, N'Công nghệ mạng LAN nào đươc sử dụng rộng rãi nhất hiện nay?', N'Token Ring', N'là Ethernet', N'ArcNet', N'FDDI', 2, 1, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (150, N'Phần nào trong địa chỉ IP được ROUTER sử dụng khi tìm đường đi?', N'Router address (Địa chỉ của ROUTER)', N'Là Network address (Địa chỉ mạng)', N'FDDI', N'Host address', 2, 1, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (151, N'Trong HEADER của IP PACKET có chứa?', N'Là Source and Destination addresses', N'Source address', N'Không chứa địa chỉ nào cả', N'Destination address', 1, 1, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (152, N'Tầng nào trong mo hình TCP/IP đóng gói dữ liệu kèm theo IP HEADER?', N'Là Layer 3', N'Layer 4', N'Layer 1', N'Layer 2', 1, 2, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (153, N'Độ dài địa chỉ MAC là?', N'24 bits', N'8 bits', N'36 bits', N'Là 48 bits', 4, 2, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (154, N'Thiết bị mạng nào sau đây là không thể thiếu được trong mạng Internet (Là thành phần cơ bản tạo lên mạng Internet)?', N'Hub', N'Switch', N'Router', N'Brigde', 3, 2, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (155, N'Chuẩn IEEE sử dụng cho Ethernet là?', N'802.3', N'802.6', N'802.5', N'802.4', 1, 2, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (156, N'Router là thiết bị hoạt động tại tầng?', N'Vật lý (Physical)', N'Liên kết dữ liệu (Data-link)', N'Mạng (Network)', N'Giao vận (Transport)', 3, 3, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (157, N'Router thực hiện chức năng?', N'Là Chọn đường đi và chuyển  gói', N'Lọc và nén dữ liệu', N'Sửa lỗi', N'Mã hóa dữ liệu', 1, 3, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (158, N'Địa chỉ MAC sử dụng tại tầng?', N'Là Liên kết dữ liệu (Data-link)', N'Mạng (Network)', N'Vật lý (Physical)', N'Ứng dụng (Application)', 1, 3, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (159, N'Trình tự đóng gói dữ liệu khi tuyền từ máy A sang máy B là?', N'Data, packet, segment, frame, bit', N'Data, segment, frame, packet, bit', N'Data, frame, packet, segment, bit', N'Data, segment, packet, frame, bit', 4, 3, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (160, N'Dữ liệu truyền từ máy tính A đến máy tính B phải trải qua quá trình nào sau đây?', N'Là Nén và đóng gói dữ liệu', N'Kiểm tra dữ liệu', N'Lọc dữ liệu', N'Phân tích dữ liệu', 1, 4, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (161, N'Đơn vị dữ liệu tại tầng Application là?', N'Frame', N'Segment', N'Packet', N'Data', 4, 4, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (162, N'Giao thức dùng để phân giải từ địa chỉ IP sang địa chỉ MAC là?', N'ARP', N'ICMP', N'RARP', N'TCP', 1, 4, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (163, N'Đơn vị cơ bản dùng để đo tốc độ truyền dữ liệu là?', N'Byte', N'Bps', N'Bit', N'Hz', 2, 4, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (164, N'Địa chỉ IP nào bên dưới có cùng địa chỉ mạng với địa chỉ 192.168.1.10/24?', N'192.168.11.12/24', N'192.168.10.1/24', N'192.168.1.32/24', N'192.168.1.256/24', 3, 1, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (165, N'Thứ tự các lớp từ cao đến thấp trong mô hình TCP/IP?', N'Application – Transport – Network Access – Internet', N'Application – Internet – Transport – Network Access', N'Application – Transport – Internet – Network Access', N'Application – Network Access – Internet – Transport', 3, 1, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (166, N'Các giao thức hoạt đọng tại tầng Transport?', N'FTP, HTTP', N'SMTP, FTP', N'TCP, UDP', N'DNS, TFTP', 3, 1, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (167, N'TCP là giao thức?', N'Phi kết nối (Connectionless)', N'Hướng kết nối (Connection-oriented)', N'Định tuyến (Routing)', N'Không tin cậy', 2, 1, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (168, N'UDP là giao thức?', N'Phi kết nối (Connectionless)', N'Hướng kết nối (Connection-oriented)', N'Định tuyến (Routing)', N'Không tin cậy', 1, 2, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (169, N'DNS sử dụng cổng?', N'21', N'20', N'53', N'69', 3, 2, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (170, N'DNS dùng để?', N'Định tuyến', N'Duyệt Web', N'Cấp phát IP', N'Phân giải tên miền', 4, 2, N'MANG', N'chương 3', NULL)
GO
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (171, N'Bộ giao thức TCP/IP gồm những lớp nào?', N'Lớp vật lý, lớp liên mạng, lớp giao vận, lớp ứng dụng', N'Lớp truy nhập mạng, lớp liên kết dữ liệu, lớp giao vận', N'Lớp truy nhập mạng, lớp liên mạng, lớp giao vận, lớp ứng dụng', N'Lớp truy nhập mạng, lớp mạng, lớp giao vận, lớp ứng dụng', 4, 2, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (172, N'Lớp ứng dụng trong mô hình giao thức TCP/IP tương ứng với lớp/cụm các lớp nào trong mô hình OSI?', N'Lớp phiên', N'Lớp ứng dụng, lớp trình diễn, lớp phiên', N'Lớp ứng dung', N'Lớp ứng dụng, lớp trình diễn', 2, 3, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (173, N'WPA là viết tắt của?', N'Wireless Privacy Agent', N'Wired Privacy Adaptive', N'Wifi Protected Access', N'Wireless Protected Access', 3, 3, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (174, N'Thuật toán nào được sử dụng trong WPA2?', N'TKIP/AES', N'DES', N'RSA', N'CRC', 1, 3, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (175, N'SSID là viết tắt của?', N'Session Services Identifier', N'Service Set Identifier', N'Session Set Identifier', N'Security Service Identifier', 2, 4, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (176, N'Phương thức bảo mật nào sau đây thường không có sẵn trong các AP?', N'MAC Filter', N'Hidden SSID', N'WEP', N'RADIUS', 1, 4, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (177, N'Giá trị IV trong gói tin WEP được dùng để?', N'Tạo ra mã khóa cho gói tin', N'Mã hóa gói tin', N'Kiểm tra gói tin', N'Xác thực gói tin', 1, 4, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (178, N'Trong mô hình OSI giao thức IP nằm ở tầng thứ mấy?', N'2', N'3', N'4', N'5', 2, 4, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (179, N'Giao thức nào dùng để nhận mail server?', N'POP', N'SMTP', N'Telnet', N'HTTP', 1, 4, N'MANG', N'chương 3', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (180, N'Những tiêu chí nào sau đây không thuộc đặc điểm của giao thức TCP?', N'Connection – oriented', N'Reliable', N'No flow control', N'Re-sends anything not received', 3, 1, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (181, N'Những giao thức nào sau đây thuộc nhóm connectionless?', N'TCP', N'UDP', N'IP', N'HTTP', 2, 1, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (182, N'Các máy trạm sử dụng địa chỉ tầng Data link để làm gì?', N'Remote delivery', N'Local and remote delivery', N'Local delivery', N'Remote delivery using routers', 3, 2, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (183, N'Thuật ngũ nào sau đây không đề cập tới mô hình quản trị mạng?', N'Peer-to-Peer', N'Client/Server', N'Hybrid', N'Shared Network', 4, 2, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (184, N'Đâu là ưu điểm của mô hình Peer-to-Peer so với hình Client/Server?', N'Quản lý được nhiều máy hơn', N'Không cần đào tạo', N'Không tốn máy chủ', N'Dễ chia sẻ hơn', 4, 2, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (185, N'Mô hình quản trị tập trung thường thấy ở các máy chủ sử dụng?', N'Windows Server', N'Linux', N'Unix', N'Sun Solaris', 1, 3, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (186, N'Đâu là ưu điểm của hệ điều hành mạng so với hệ điều hành thông thường?', N'Đa nhiệm', N'Đa người dùng', N'Đa tiến trình', N'Đa vi xử lý', 4, 3, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (187, N'Vị trí của Firewall trong hệ thống mạng?', N'Trong mạng LAN', N'Trong mạng WAN', N'Ở giữa mạng LAN và mạng WAN', N'Giữa mạng LAN và Internet', 3, 3, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (188, N'Vị trí của Firewall trong hệ thống mạng?', N'Trong mạng LAN', N'Trong mạng WAN', N'Ở giữa mạng LAN và mạng WAN', N'Giữa mạng LAN và Internet', 3, 3, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (189, N'Đặc điểm nào sau đây không phải là đặc điểm của Firewall', N'Có thể là phần cứng', N'Có thể là phền mềm', N'Ngăn chặn các kết nối không hợp lệ', N'Giúp vào mạng nhanh hơn', 4, 4, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (190, N'Firewall sử dựng cơ chế gì để kiểm soát kết nối?', N'Packet Filter', N'Proxy', N'Tunneling', N'Encryption', 1, 4, N'MANG', N'chương 4', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (192, N'VPN là viết tắt của?', N'Virtual Packet Network', N'Virtual Private Network', N'Vice Packet Network', N'Void Protocol Network', 2, 1, N'MANG', N'chương 2', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (193, N'Giao thức cổng ngoại BGP là viết tắt của?', N'Bit Group Protocol', N'Border Gateway Protocol', N'Best Gateway Protocol', N'Block Group Protocol', 2, 4, N'TA1', N'Unit 1', N'D:\ảnh nền\GearVN_Gundam_-3-2048x1280.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (194, N'Giao thức cổng ngoại BGP là viết tắt của?', N'Bit Group Protocol', N'Border Gateway Protocol', N'Best Gateway Protocol', N'Block Group Protocol', 2, 4, N'MANG', N'chương 4', N'D:\ảnh nền\GearVN_Gundam_-3-2048x1280.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (195, N'Cơ chế nào sau đây được sử dụng trong mạng VPN?', N'Đường hầm', N'Đường truyền riêng', N'Đổi địa chỉ', N'Mapping IP D', 1, 4, N'MANG', N'chương 5', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (196, N'Các chuẩn JPEG, TIFF, ASCII, EBCDIC do tầng nào của mô hình OSI định nghĩa?', N'Transport', N'Network', N'Application', N'Presentation', 4, 2, N'MANG', N'chương 4', N'D:\ảnh nền\hinh-nen-hai-huoc-cho-may-tinh-19.jpg')
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (197, N'F=A+AB+ABC=?', N'A', N'AC', N'AB', N'ABC', 1, 1, N'TRR', N'chương 1- logic mệnh đề', NULL)
INSERT [dbo].[tblKhoCauHoi] ([iMaCauHoi], [nvcNoiDung], [nvcDapAnA], [nvcDapAnB], [nvcDapAnC], [nvcDapAnD], [iDapAnDung], [iDoKho], [vcMaMonThi], [nvcTenChuong], [nvcDuongDanFileAnh]) VALUES (198, N'Gọi A là biến cố “Có yêu cầu bộ xử lý tốc độ cao”; B là biến cố “Có yêu 
cầu bộ nhớ mở rộng”. Hãy tính xác suất: P(A)?', N'0,37', N'0,4', N'0,38', N'0,2', 3, 2, N'XSTK', N'chương 1-xác suất cổ điển', N'D:\Screenshot 2023-05-31 183534.png')
SET IDENTITY_INSERT [dbo].[tblKhoCauHoi] OFF
GO
INSERT [dbo].[tblLopHanhChinh] ([vcMaLopHanhChinh]) VALUES (N'2110A04')
INSERT [dbo].[tblLopHanhChinh] ([vcMaLopHanhChinh]) VALUES (N'2110A05')
GO
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'LSÐ', 100)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'LSÐ', 101)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'LSÐ', 102)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'LSÐ', 103)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'MANG', 200)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'MANG', 201)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'MANG', 202)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'MANG', 203)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'TA1', 300)
INSERT [dbo].[tblMaDeThi] ([vcMaMonThi], [iMaDeThi]) VALUES (N'TA1', 301)
GO
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'a', N'gresgse', 1, 20, N'wtwttw', CAST(N'2023-05-29' AS Date), CAST(N'04:36:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'b', N'd', 1, 10, N'd', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'bm', N'v', 1, 10, N'c', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'DSHGT', N'Đại số hình giải tích', 1, 10, N'2022-2023', CAST(N'2023-05-31' AS Date), CAST(N'15:31:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'f', N'g', 1, 10, N'g', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'GT1', N'giải tích 1', 1, 20, N'2022-2023', CAST(N'2023-05-25' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'gt2', N'giải tích 2', 3, 30, N'2022-2023', CAST(N'2023-05-30' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'i', N'o', 1, 10, N'p', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'j', N'k', 1, 10, N'm', CAST(N'2023-05-05' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'LSÐ', N'Lịch Sử Đảng', 2, 10, N'2022-2023', CAST(N'2023-04-25' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'LTHSK', N'LẬP TRÌNH HƯỚNG SỰ KIỆN', 4, 20, N'2022-2023', CAST(N'2023-05-23' AS Date), CAST(N'14:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'MANG', N'Mạng và Truyền Thông', 3, 10, N'2022-2023', CAST(N'2023-04-22' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'o', N'g', 1, 10, N'g', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'q', N'w', 1, 10, N'e', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'TA1', N'Tiếng anh 1', 3, 10, N'2022-2023', CAST(N'2023-05-13' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'TA2', N'Tiếng anh 2', 3, 10, N'2022-2023', CAST(N'2023-05-14' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'TA3', N'tiếng anh 3', 3, 20, N'2022-2023', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'TRR', N'TOAN ROI RAC', 1, 10, N'1', CAST(N'2023-05-23' AS Date), CAST(N'14:00:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'XSTK', N'Xác suất thống kê', 3, 20, N'2022-2023', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'y', N'ut', 1, 10, N't', CAST(N'2023-05-04' AS Date), CAST(N'07:30:00' AS Time))
INSERT [dbo].[tblMonThi] ([vcMaMonThi], [nvcTenMonThi], [iSoTinChi], [iSoCauHoi], [nvcHocKy], [dtNgayBatDauThi], [tThoiGianThi]) VALUES (N'z', N'q', 1, 10, N'w', CAST(N'2023-05-21' AS Date), CAST(N'07:30:00' AS Time))
GO
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100100', N'Nguyễn Ánh Ngọc', CAST(N'2003-11-11T00:00:00.000' AS DateTime), N'Nữ', N'2110A04')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100111', N'Phạm Đình Tân', CAST(N'2003-10-11T00:00:00.000' AS DateTime), N'Nam', N'2110A04')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100112', N'Nguyễn Hồng Sơn', CAST(N'2003-12-11T00:00:00.000' AS DateTime), N'Nam', N'2110A04')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100410', N'Nguyễn Thúy Hằng', CAST(N'2003-05-15T00:00:00.000' AS DateTime), N'Nữ', N'2110A05')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100411', N'Phạm Duy Thắng', CAST(N'2003-07-20T00:00:00.000' AS DateTime), N'Nam', N'2110A05')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100414', N'Nguyễn Viết Tuấn', CAST(N'2003-05-14T00:00:00.000' AS DateTime), N'Nam', N'2110A05')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100415', N'Phạm Quốc Tuấn', CAST(N'2003-05-19T00:00:00.000' AS DateTime), N'Nam', N'2110A05')
INSERT [dbo].[tblSinhVien] ([vcMaSinhVien], [nvcTenSinhVien], [dtNgaySinh], [nvcGioiTinh], [vcMaLopHanhChinh]) VALUES (N'21A100100416', N'Vũ Anh Tuấn', CAST(N'2003-07-19T00:00:00.000' AS DateTime), N'Nam', N'2110A05')
GO
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'a', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'admin', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'admin1', N'2', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'admin2', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'giangvien1', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'giangvien5', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'giaovien', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'giaovien2', N'2', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'giaovien3', N'1', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'nguyenanhngoc', N'1', 2, N'21A100100100')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'nguyenhongson', N'1', 2, N'21A100100112')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'nguyenthuyhang', N'1', 2, N'21A100100410')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'nguyenviettuan', N'1', 2, N'21A100100414')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'phamdinhtan', N'1', 2, N'21A100100111')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'phamduythang', N'1', 2, N'21A100100411')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'phamquoctuan', N'1', 2, N'21A100100415')
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'tuananhvund031', N'19072003', 1, NULL)
INSERT [dbo].[tblTaiKhoan] ([vcTenDangNhap], [vcMatKhau], [iQuyenTruyCap], [vcMaSinhVien]) VALUES (N'vuanhtuan', N'1', 2, N'21A100100416')
GO
ALTER TABLE [dbo].[tblDanhSachThi] ADD  DEFAULT ((0)) FOR [bTrangThaiThi]
GO
ALTER TABLE [dbo].[tblChiTietKetQuaThi]  WITH CHECK ADD  CONSTRAINT [fk_tblChiTietKetQuaThi_tblKetQuaThi] FOREIGN KEY([iMaKetQuaThi])
REFERENCES [dbo].[tblKetQuaThi] ([iMaKetQuaThi])
GO
ALTER TABLE [dbo].[tblChiTietKetQuaThi] CHECK CONSTRAINT [fk_tblChiTietKetQuaThi_tblKetQuaThi]
GO
ALTER TABLE [dbo].[tblChiTietKetQuaThi]  WITH CHECK ADD  CONSTRAINT [fk_tblChiTietKetQuaThi_tblKhoCauHoi] FOREIGN KEY([iMaCauHoi])
REFERENCES [dbo].[tblKhoCauHoi] ([iMaCauHoi])
GO
ALTER TABLE [dbo].[tblChiTietKetQuaThi] CHECK CONSTRAINT [fk_tblChiTietKetQuaThi_tblKhoCauHoi]
GO
ALTER TABLE [dbo].[tblChuong]  WITH CHECK ADD  CONSTRAINT [fk_tblChuong_tblMonThi] FOREIGN KEY([vcMaMonThi])
REFERENCES [dbo].[tblMonThi] ([vcMaMonThi])
GO
ALTER TABLE [dbo].[tblChuong] CHECK CONSTRAINT [fk_tblChuong_tblMonThi]
GO
ALTER TABLE [dbo].[tblDanhSachThi]  WITH CHECK ADD  CONSTRAINT [fk_tblDanhSachThi_tblMonThi] FOREIGN KEY([vcMaMonThi])
REFERENCES [dbo].[tblMonThi] ([vcMaMonThi])
GO
ALTER TABLE [dbo].[tblDanhSachThi] CHECK CONSTRAINT [fk_tblDanhSachThi_tblMonThi]
GO
ALTER TABLE [dbo].[tblDanhSachThi]  WITH CHECK ADD  CONSTRAINT [fk_tblDanhSachThi_tblSinhVien] FOREIGN KEY([vcMaSinhVien])
REFERENCES [dbo].[tblSinhVien] ([vcMaSinhVien])
GO
ALTER TABLE [dbo].[tblDanhSachThi] CHECK CONSTRAINT [fk_tblDanhSachThi_tblSinhVien]
GO
ALTER TABLE [dbo].[tblDeThi]  WITH CHECK ADD  CONSTRAINT [fk_tblDeThi_tblKhoCauHoi] FOREIGN KEY([iMaCauHoi])
REFERENCES [dbo].[tblKhoCauHoi] ([iMaCauHoi])
GO
ALTER TABLE [dbo].[tblDeThi] CHECK CONSTRAINT [fk_tblDeThi_tblKhoCauHoi]
GO
ALTER TABLE [dbo].[tblDeThi]  WITH CHECK ADD  CONSTRAINT [fk_tblDeThi_tblMonThi] FOREIGN KEY([iMaDeThi])
REFERENCES [dbo].[tblMaDeThi] ([iMaDeThi])
GO
ALTER TABLE [dbo].[tblDeThi] CHECK CONSTRAINT [fk_tblDeThi_tblMonThi]
GO
ALTER TABLE [dbo].[tblKetQuaThi]  WITH CHECK ADD  CONSTRAINT [fk_tblKetQuaThi_tblMaDeThi] FOREIGN KEY([iMaDeThi])
REFERENCES [dbo].[tblMaDeThi] ([iMaDeThi])
GO
ALTER TABLE [dbo].[tblKetQuaThi] CHECK CONSTRAINT [fk_tblKetQuaThi_tblMaDeThi]
GO
ALTER TABLE [dbo].[tblKetQuaThi]  WITH CHECK ADD  CONSTRAINT [fk_tblKetQuaThi_tblMonThi] FOREIGN KEY([vcMaMonThi])
REFERENCES [dbo].[tblMonThi] ([vcMaMonThi])
GO
ALTER TABLE [dbo].[tblKetQuaThi] CHECK CONSTRAINT [fk_tblKetQuaThi_tblMonThi]
GO
ALTER TABLE [dbo].[tblKetQuaThi]  WITH CHECK ADD  CONSTRAINT [fk_tblKetQuaThi_tblSinhVien] FOREIGN KEY([vcMaSinhVien])
REFERENCES [dbo].[tblSinhVien] ([vcMaSinhVien])
GO
ALTER TABLE [dbo].[tblKetQuaThi] CHECK CONSTRAINT [fk_tblKetQuaThi_tblSinhVien]
GO
ALTER TABLE [dbo].[tblKhoCauHoi]  WITH CHECK ADD  CONSTRAINT [fk_tblKhoCauHoi_tblChuong] FOREIGN KEY([nvcTenChuong])
REFERENCES [dbo].[tblChuong] ([nvcTenChuong])
GO
ALTER TABLE [dbo].[tblKhoCauHoi] CHECK CONSTRAINT [fk_tblKhoCauHoi_tblChuong]
GO
ALTER TABLE [dbo].[tblKhoCauHoi]  WITH CHECK ADD  CONSTRAINT [fk_tblKhoCauHoi_tblMonThi] FOREIGN KEY([vcMaMonThi])
REFERENCES [dbo].[tblMonThi] ([vcMaMonThi])
GO
ALTER TABLE [dbo].[tblKhoCauHoi] CHECK CONSTRAINT [fk_tblKhoCauHoi_tblMonThi]
GO
ALTER TABLE [dbo].[tblMaDeThi]  WITH CHECK ADD  CONSTRAINT [fk_tblMaDeThi_tblMonThi] FOREIGN KEY([vcMaMonThi])
REFERENCES [dbo].[tblMonThi] ([vcMaMonThi])
GO
ALTER TABLE [dbo].[tblMaDeThi] CHECK CONSTRAINT [fk_tblMaDeThi_tblMonThi]
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD  CONSTRAINT [fk_tblSinhVien_tblLopHanhChinh] FOREIGN KEY([vcMaLopHanhChinh])
REFERENCES [dbo].[tblLopHanhChinh] ([vcMaLopHanhChinh])
GO
ALTER TABLE [dbo].[tblSinhVien] CHECK CONSTRAINT [fk_tblSinhVien_tblLopHanhChinh]
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD  CONSTRAINT [fk_tblTaiKhoan_tblSinhVien] FOREIGN KEY([vcMaSinhVien])
REFERENCES [dbo].[tblSinhVien] ([vcMaSinhVien])
GO
ALTER TABLE [dbo].[tblTaiKhoan] CHECK CONSTRAINT [fk_tblTaiKhoan_tblSinhVien]
GO
ALTER TABLE [dbo].[tblKhoCauHoi]  WITH CHECK ADD CHECK  (([iDapAnDung]>=(1) AND [iDapAnDung]<=(4)))
GO
ALTER TABLE [dbo].[tblKhoCauHoi]  WITH CHECK ADD CHECK  (([iDoKho]>=(1) AND [iDoKho]<=(4)))
GO
ALTER TABLE [dbo].[tblSinhVien]  WITH CHECK ADD CHECK  (([nvcGioiTinh]=N'Nữ' OR [nvcGioiTinh]=N'Nam'))
GO
ALTER TABLE [dbo].[tblTaiKhoan]  WITH CHECK ADD CHECK  (([iQuyenTruyCap]=(2) OR [iQuyenTruyCap]=(1)))
GO
/****** Object:  StoredProcedure [dbo].[sp_dangKiTaiKhoan]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dangKiTaiKhoan]
@vcTenDangNhap varchar(30), @vcMatKhau varchar(20), @iQuyenTruyCap int, @vcMaSinhVien varchar(12)
as
begin
	insert into tblTaiKhoan
	values(@vcTenDangNhap, @vcMatKhau, @iQuyenTruyCap, @vcMaSinhVien)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_dangNhap]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_dangNhap]
@vcTenDangNhap varchar(30),@vcMatKhau varchar(20)
as
begin
	select * from tblTaiKhoan 
	where vcTenDangNhap COLLATE Latin1_General_CS_AS =@vcTenDangNhap and vcMatKhau COLLATE Latin1_General_CS_AS =@vcMatKhau
end
GO
/****** Object:  StoredProcedure [dbo].[sp_danhSachCauHoiTheoMaDeThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_danhSachCauHoiTheoMaDeThi]
	@iMaDeThi int
AS
BEGIN
	SELECT * 
	FROM tblKhoCauHoi
	WHERE iMaCauHoi
	IN (SELECT iMaCauHoi FROM tblDeThi WHERE iMaDeThi = @iMaDeThi)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_danhSachLichThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_danhSachLichThi]
@vcMaSinhVien varchar(12)
as	
begin
	select tblMonThi.vcMaMonThi N'Mã môn thi'
	,tblMonThi.nvcTenMonThi N'Tên môn thi'
	,tblMonThi.[dtNgayBatDauThi] N'Ngày thi'
	,tblMonThi.tThoiGianThi N'Thời gian'
	,vcMaXacNhan
	from tblMonThi inner join tblDanhSachThi
	on tblDanhSachThi.vcMaMonThi=tblMonThi.vcMaMonThi
	where tblDanhSachThi.vcMaSinhVien=@vcMaSinhVien and tblDanhSachThi.bTrangThaiThi=0
end
GO
/****** Object:  StoredProcedure [dbo].[sp_danhSachMaDeTheoMonThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_danhSachMaDeTheoMonThi]
	@vcMaMonThi varchar(5)
AS
BEGIN
	SELECT iMaDeThi
	FROM tblMaDeThi
	WHERE vcMaMonThi=@vcMaMonThi
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ketQuaThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ketQuaThi]
as
begin
	select  iMaKetQuaThi N'Mã kết quả',vcMaMonThi N'Mã môn thi',iMaDeThi N'Mã đề',
	tblKetQuaThi.vcMaSinhVien N'Mã SV',tblSinhVien.nvcTenSinhVien N'Họ tên'
	,tblSinhVien.vcMaLopHanhChinh N'Lớp HC',Round((10*iSoCauDung)/(iSoCauDung+iSoCauSai),1) N'Điểm'
	from tblKetQuaThi,tblSinhVien
	where tblKetQuaThi.vcMaSinhVien=tblSinhVien.vcMaSinhVien
end
GO
/****** Object:  StoredProcedure [dbo].[sp_khoCauHoi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_khoCauHoi]
as
begin
	select * from tblKhoCauHoi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaCauHoi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_suaCauHoi]
@iMaCauHoi int ,@nvcNoiDung nvarchar(max),@nvcDapAnA nvarchar(max),@nvcDapAnB nvarchar(max),@nvcDapAnC nvarchar(max),@nvcDapAnD nvarchar(max)
,@iDapAnDung int,@iDoKho int ,@vcMaMonThi varchar(5),@nvcTenChuong nvarchar(30),@nvcDuongDanFileAnh nvarchar(max)
as
begin
	update tblKhoCauHoi
	set
	nvcNoiDung=@nvcNoiDung,
	nvcDapAnA=@nvcDapAnA,
	nvcDapAnB=@nvcDapAnB,
	nvcDapAnC=@nvcDapAnC,
	nvcDapAnD=@nvcDapAnD,
	iDapAnDung=@iDapAnDung,
	iDoKho=@iDoKho,
	vcMaMonThi=@vcMaMonThi,
	nvcTenChuong=@nvcTenChuong,
	nvcDuongDanFileAnh=@nvcDuongDanFileAnh
	where
	iMaCauHoi=@iMaCauHoi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_suaMonThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_suaMonThi]
@vcMaMonThi varchar(5),@nvcTenMonThi nvarchar(50),@iSoTinChi int,@iSoCauHoi int,@nvcHocKy nvarchar(30),@dtNgayBatDauThi datetime,@tThoiGianThi time
as
begin
	update tblMonThi
	set 
	nvcTenMonThi=@nvcTenMonThi,
	iSoTinChi=@iSoTinChi,
	iSoCauHoi=@iSoCauHoi,
	nvcHocKy=@nvcHocKy,
	dtNgayBatDauThi=@dtNgayBatDauThi,
	tThoiGianThi =@tThoiGianThi
	where vcMaMonThi=@vcMaMonThi
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themCauHoi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themCauHoi]
@nvcNoiDung nvarchar(max),@nvcDapAnA nvarchar(max),@nvcDapAnB nvarchar(max),@nvcDapAnC nvarchar(max),@nvcDapAnD nvarchar(max),@iDapAnDung int,@iDoKho int,@vcMaMonThi varchar(5),@nvcDuongDanFileAnh nvarchar(max),@nvcTenChuong nvarchar(30)
as
begin
	insert into tblKhoCauHoi
	values(@nvcNoiDung,@nvcDapAnA,@nvcDapAnB,@nvcDapAnC,@nvcDapAnD,@iDapAnDung,@iDoKho,@vcMaMonThi,@nvcTenChuong,@nvcDuongDanFileAnh)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themCauHoiVaoDeThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themCauHoiVaoDeThi]
@tbl type_deThi readonly
as
begin
	insert into tblDeThi
	select * from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themChiTietKetQuaThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themChiTietKetQuaThi]
@tbl type_chiTietKetQuaThi readonly
as
begin
	insert into tblChiTietKetQuaThi
	select * from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themChuong]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themChuong]
@vcMaMonThi varchar(5),@nvcTenChuong nvarchar(30)
as
begin
insert into tblChuong(vcMaMonThi,nvcTenChuong)
values(@vcMaMonThi,@nvcTenChuong)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themKetQuaThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themKetQuaThi]
@vcMaMonThi varchar(5),@vcMaSinhVien varchar(12),@iMaDeThi int,@iSoCauDung int,@iSoCauSai int
as
begin
	declare @tbl table(i int);
	insert into tblKetQuaThi(vcMaMonThi,vcMaSinhVien,iMaDeThi,iSoCauDung,iSoCauSai)
	output inserted.iMaKetQuaThi into @tbl(i)
	values(@vcMaMonThi,@vcMaSinhVien,@iMaDeThi,@iSoCauDung,@iSoCauSai)

	select i from @tbl
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themMaDeThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themMaDeThi]
@vcMaMonThi varchar(5),@iMaDeThi int
as
begin
insert into tblMaDeThi(vcMaMonThi,iMaDeThi)
values(@vcMaMonThi,@iMaDeThi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themMonThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_themMonThi]
@vcMaMonThi varchar(5),@nvcTenMonThi nvarchar(50),@iSoTinChi int,@iSoCauHoi int,@nvcHocKy nvarchar(30),@dtNgayBatDauThi datetime,@tThoiGianThi time
as
begin
	insert into tblMonThi
	values(@vcMaMonThi,@nvcTenMonThi,@iSoTinChi,@iSoCauHoi,@nvcHocKy,@dtNgayBatDauThi,@tThoiGianThi)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_themSinhVienVaoDanhSachThi]    Script Date: 19/07/2023 11:32:02 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_themSinhVienVaoDanhSachThi]
@vcMaMonThi varchar(5),@vcMaSinhVien varchar(12),@vcMaXacNhan varchar(5)
as
begin
insert into tblDanhSachThi(vcMaMonThi,vcMaSinhVien,vcMaXacNhan)
values(@vcMaMonThi,@vcMaSinhVien,@vcMaXacNhan)
end
GO
