USE [TEST]
GO
/****** Object:  Table [dbo].[Chapter]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chapter](
	[IdSubject] [varchar](5) NULL,
	[NameChapter] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NameChapter] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[UserName] [varchar](30) NOT NULL,
	[PassWord_] [varchar](20) NOT NULL,
	[Type_] [int] NOT NULL,
	[IdStudent] [varchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblClass]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblClass](
	[IdClass] [varchar](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblExam]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExam](
	[IdExam] [int] NOT NULL,
	[IdQuestion] [int] NOT NULL,
 CONSTRAINT [pk] PRIMARY KEY CLUSTERED 
(
	[IdExam] ASC,
	[IdQuestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblExamCode]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblExamCode](
	[IdExam] [int] NOT NULL,
	[IdSubject] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdExam] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblQUESTION]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblQUESTION](
	[IdQuestion] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[AnswerA] [nvarchar](max) NOT NULL,
	[AnswerB] [nvarchar](max) NOT NULL,
	[AnswerC] [nvarchar](max) NOT NULL,
	[AnswerD] [nvarchar](max) NOT NULL,
	[LocationCorrect] [int] NULL,
	[LevelOfDifficult] [int] NULL,
	[IdSubject] [varchar](5) NULL,
	[NameChapter] [nvarchar](30) NULL,
	[PathImage] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdQuestion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblResult]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblResult](
	[IdStudent] [varchar](12) NOT NULL,
	[IdSubject] [varchar](5) NOT NULL,
	[IdExam] [int] NOT NULL,
	[Point] [float] NULL,
 CONSTRAINT [pktblResult] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC,
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStudent]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStudent](
	[IdStudent] [varchar](12) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[Sex] [bit] NOT NULL,
	[IdClass] [varchar](7) NULL,
	[_PassWord] [varchar](20) NULL,
	[_Type] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSUBJECT]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSUBJECT](
	[IdSubject] [varchar](5) NOT NULL,
	[NameSubj] [nvarchar](30) NOT NULL,
	[NumCredits] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Chapter] ([IdSubject], [NameChapter]) VALUES (N'GT2', N'chương 1')
INSERT [dbo].[Chapter] ([IdSubject], [NameChapter]) VALUES (N'GT1', N'Chuong 1-Gi?i h?n hàm s?')
INSERT [dbo].[Chapter] ([IdSubject], [NameChapter]) VALUES (N'GT2', N'Chuong 1-hàm nhi?u bi?n')
INSERT [dbo].[Chapter] ([IdSubject], [NameChapter]) VALUES (N'GT1', N'chương 2')
GO
INSERT [dbo].[tblAccount] ([UserName], [PassWord_], [Type_], [IdStudent]) VALUES (N'giaovien1', N'234', 1, NULL)
INSERT [dbo].[tblAccount] ([UserName], [PassWord_], [Type_], [IdStudent]) VALUES (N'giaovien2', N'234', 1, NULL)
INSERT [dbo].[tblAccount] ([UserName], [PassWord_], [Type_], [IdStudent]) VALUES (N'sinhvien1', N'123', 2, N'21A100100416')
INSERT [dbo].[tblAccount] ([UserName], [PassWord_], [Type_], [IdStudent]) VALUES (N'sinhvien2', N'123', 2, N'21A100100414')
GO
INSERT [dbo].[tblClass] ([IdClass]) VALUES (N'2110A05')
GO
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (111, 1)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (111, 2)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (111, 3)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (112, 1)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (112, 2)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (112, 4)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (113, 2)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (113, 3)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (113, 4)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (113, 5)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (113, 6)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 1)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 2)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 3)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 4)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 5)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 6)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 8)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 9)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 10)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 11)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 12)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 13)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 14)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 15)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 16)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 17)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 19)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 20)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 21)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (114, 22)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (120, 27)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (120, 29)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (120, 40)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (120, 41)
INSERT [dbo].[tblExam] ([IdExam], [IdQuestion]) VALUES (211, 7)
GO
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (111, N'GT2')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (112, N'GT2')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (113, N'GT2')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (114, N'GT2')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (119, N'GT2')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (120, N'GT1')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (211, N'GT1')
INSERT [dbo].[tblExamCode] ([IdExam], [IdSubject]) VALUES (222, N'GT1')
GO
SET IDENTITY_INSERT [dbo].[tblQUESTION] ON 

INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (1, N'1000+100=?', N'1100', N'1111', N'4311', N'1234', 1, 1, N'GT1', N'Chuong 1-Gi?i h?n hàm s?', N'D:\thiết kế web\banh-xe-mau-sac-696x473.png')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (2, N'1+1=?', N'5', N'2', N'3', N'0', 2, 1, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (3, N'1+3=?', N'5', N'2', N'3', N'4', 4, 1, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (4, N'F=A+AB?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 3, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (5, N'erqwrwerew', N'rewqrqwer', N'1324124', N'33333', N'44434124', 4, 1, N'GT1', N'Chuong 1-Gi?i h?n hàm s?', N'D:\thiết kế web\pngtree-red-neon-lines-glowing-lines-background-ultraviolet-light-laser-show-perform')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (6, N'Đạo hàm của hàm z''=1.3x^3 + y^3 là?', N'dz=3x^2dx + 3y^2 dy', N'dz=x^2dx + 3y^2 dy', N'dz=1x^2dx + 3y^2 dy', N'dz=3x^2dx + 2y^2 dy', 2, 2, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (7, N'1+10=?', N'5', N'2', N'3', N'11', 4, 1, N'GT1', N'chương 2', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (8, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (9, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (10, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (11, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (12, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'F=A+B', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (13, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (14, N'F=A+AB+A?', N'F=A', N'F=B', N'F=AB', N'FFFF', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (15, N'\u222bx=', N'F=1/2x^2', N'F=x', N'F=1', N'F=x^2', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (16, N'\\u222bx=', N'F=1/2x^2', N'F=x', N'F=1', N'F=x^2', 1, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (17, N'Tung 2 con xúc sắc một lần.\nGọi A là sự kiện "được 2 mặt chẵn"\nB là sự kiện "được 2 mặt lẻ"\nC là sự kiện "được 1 chẵn 1 lẻ"\nKhẳng định nào sao đây sai?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (18, N'Tung 2 con xúc sắc một lần.
G?i A là s? ki?n "du?c 2 m?t ch?n"
B là s? ki?n "du?c 2 m?t l?"
C là s? ki?n "du?c 1 ch?n 1 l?"
Kh?ng d?nh nào sao dây sai?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (19, N'Tung 2 con xúc sắc một lần.
Gọi A là sự kiện "được 2 mặt chẵn"
B là sự kiện "được 2 mặt lẻ"
C là sự kiện "được 1 chẵn 1 lẻ"
Khẳng định nào sao đây sai?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (20, N'Tung 2 con xúc sắc một lần.
Gọi A là sự kiện "được 2 mặt chẵn"
B là sự kiện "được 2 mặt lẻ"
C là sự kiện "được 1 chẵn 1 lẻ"
Khẳng định nào sao đây sai?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (21, N'Tung 2 con xúc sắc một lần.
Gọi A là sự kiện "được 2 mặt chẵn"
B là sự kiện "được 2 mặt lẻ"
C là sự kiện "được 1 chẵn 1 lẻ"
Khẳng định nào sao đây sai?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (22, N'Tung 2 con xúc sắc một lần.
Gọi A là sự kiện "được 2 mặt chẵn"
B là sự kiện "được 2 mặt lẻ"
C là sự kiện "được 1 chẵn 1 lẻ"
Khẳng định nào sao đây sai?
Khẳng định nào sao đây saiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii?', N'P(A)+P(B)=P(C)', N'P(A)+P(B)=1', N'P(A)=P(B)', N'P(A)+P(B)+P(C)=1', 2, 4, N'GT2', N'chương 1', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (27, N'pi=?', N'2.14', N'4', N'3.14', N'5', 3, 1, N'GT1', N'chương 2', N'D:\z4175435964150_cbf6dcfcb20bae130702da2e0be179b4.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (28, N'pi=?', N'2.14', N'4', N'3.14', N'5', 3, 1, N'GT1', N'chương 2', N'D:\z4175435964150_cbf6dcfcb20bae130702da2e0be179b4.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (29, N'cho A=1000
       B=10000
C=2A+B
tìm C?', N'10000', N'12000', N'11111', N'20000', 2, 2, N'GT1', N'chương 2', N'D:\Screenshot 2022-06-25 005642.png')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (30, N'Phát biểu nào dưới đây về quản lý vốn huy động là đúng nhất?', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn, phân tích tính thanh khoản của nguồn vốn.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn, phân tích tính thanh', 4, 4, N'GT2', N'chương 1', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (31, N'Phát biểu nào dưới đây về quản lý vốn huy động là đúng nhất?', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn, phân tích tính thanh khoản của nguồn vốn.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn.', N'Quản lý quy mô, cơ cấu, quản lý lãi suất chi trả, quản lý kỳ hạn, phân tích tính thanh', 4, 4, N'GT2', N'chương 1', N'D:\?nh n?n\18941.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (32, N'giải phương trình sau y=x-3=0
x=?', N'2', N'4', N'5', N'3', 4, 2, N'GT1', N'chương 2', N'D:\?nh n?n\GearVN_Gundam_-11.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (33, N'vũ anh tuấn', N'1', N'2', N'3', N'4', 1, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (34, N'xem conan ở kênh youtube nào?', N'ntn vlogs', N'popanime', N'thơ nguyễn', N'phd troll', 2, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (35, N'1', N'2', N'3', N'5', N'4', 1, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (36, N'2', N'3', N'4', N'6', N'5', 1, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (37, N'ánh ngọc', N'1', N'2', N'3', N'4', 1, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (38, N'ánh ngọc xinh đúng hay sai?', N'cũng đúng', N'sai', N'rất đúng', N'quá sai', 3, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (39, N'1234', N'1', N'2', N'3', N'4', 1, 1, N'GT1', N'chương 2', N'D:\?nh n?n\WP_Ironman-2560x1440_00000.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (40, N'12341251', N'1', N'2', N'3', N'4', 3, 1, N'GT1', N'chương 2', N'D:\ảnh nền\WP_Ironman-2560x1440_00000.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (41, N'132412412', N'4', N'5', N'6', N'7', 4, 1, N'GT1', N'chương 2', N'D:\ảnh nền\WP_Ironman-2560x1440_00000.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (42, N'tretretrsetseterters', N'1', N'2', N'4', N'3', 4, 1, N'GT1', N'chương 2', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (43, N'1', N'2', N'3', N'4', N'5', 1, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (44, N'5', N'4', N'3', N'1', N'2', 3, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (45, N'9', N'8', N'7', N'5', N'6', 2, 1, N'GT1', N'chương 2', N'openFileDialog1')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (46, N'1', N'2', N'3', N'4', N'5', 1, 1, N'GT1', N'chương 2', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (47, N'11', N'22', N'33', N'55', N'44', 3, 1, N'GT1', N'chương 2', NULL)
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (48, N'12344141414', N'1', N'2', N'4', N'3', 3, 4, N'GT2', N'chương 1', N'D:\thi?t k? web\KhGmXNq.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (49, N'abcxyz', N'1', N'2', N'4', N'3', 1, 1, N'GT1', N'chương 2', N'D:\thi?t k? web\18q.png')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (50, N'rqwererqewr', N'1', N'2', N'4', N'3', 4, 1, N'GT1', N'chương 2', N'D:\thiết kế web\stand-by-me-doraemon-2014-poster.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (51, N'432141241243124', N'41243124', N'241234143231', N'5314124124', N'343214134', 2, 1, N'GT1', N'chương 2', N'D:\thiết kế web\hinh-anh-dong-chuc-mung-sinh-nhat.gif')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (52, N'132412412', N'4', N'5', N'6', N'7', 2, 1, N'GT1', N'chương 2', N'D:\ảnh nền\WP_Ironman-2560x1440_00000.jpg')
INSERT [dbo].[tblQUESTION] ([IdQuestion], [Content], [AnswerA], [AnswerB], [AnswerC], [AnswerD], [LocationCorrect], [LevelOfDifficult], [IdSubject], [NameChapter], [PathImage]) VALUES (53, N'erqwrwerew', N'rewqrqwer', N'1324124', N'33333', N'44434124', 4, 1, N'GT1', N'Chuong 1-Gi?i h?n hàm s?', N'D:\thiết kế web\pngtree-red-neon-lines-glowing-lines-background-ultraviolet-light-laser-show-perform')
SET IDENTITY_INSERT [dbo].[tblQUESTION] OFF
GO
INSERT [dbo].[tblResult] ([IdStudent], [IdSubject], [IdExam], [Point]) VALUES (N'21A100100414', N'GT2', 114, 2)
INSERT [dbo].[tblResult] ([IdStudent], [IdSubject], [IdExam], [Point]) VALUES (N'21A100100415', N'GT2', 113, 6)
INSERT [dbo].[tblResult] ([IdStudent], [IdSubject], [IdExam], [Point]) VALUES (N'21A100100416', N'GT1', 211, 10)
INSERT [dbo].[tblResult] ([IdStudent], [IdSubject], [IdExam], [Point]) VALUES (N'21A100100416', N'GT2', 114, 10)
GO
INSERT [dbo].[tblStudent] ([IdStudent], [FullName], [Birthday], [Sex], [IdClass], [_PassWord], [_Type]) VALUES (N'21A100100414', N'Phạm Duy Thắng', CAST(N'2003-07-19T00:00:00.000' AS DateTime), 1, N'2110A05', N'123', 2)
INSERT [dbo].[tblStudent] ([IdStudent], [FullName], [Birthday], [Sex], [IdClass], [_PassWord], [_Type]) VALUES (N'21A100100415', N'Phạm Quốc Tuấn', CAST(N'2003-07-19T00:00:00.000' AS DateTime), 1, N'2110A05', N'123', 2)
INSERT [dbo].[tblStudent] ([IdStudent], [FullName], [Birthday], [Sex], [IdClass], [_PassWord], [_Type]) VALUES (N'21A100100416', N'Vu anh tuan', CAST(N'2003-07-19T00:00:00.000' AS DateTime), 1, N'2110A05', N'123', 2)
GO
INSERT [dbo].[tblSUBJECT] ([IdSubject], [NameSubj], [NumCredits]) VALUES (N'GT1', N'Giải Tích 1', 3)
INSERT [dbo].[tblSUBJECT] ([IdSubject], [NameSubj], [NumCredits]) VALUES (N'GT2', N'Giải Tích 2', 3)
GO
ALTER TABLE [dbo].[tblAccount] ADD  DEFAULT ((2)) FOR [Type_]
GO
ALTER TABLE [dbo].[Chapter]  WITH CHECK ADD FOREIGN KEY([IdSubject])
REFERENCES [dbo].[tblSUBJECT] ([IdSubject])
GO
ALTER TABLE [dbo].[tblAccount]  WITH CHECK ADD FOREIGN KEY([IdStudent])
REFERENCES [dbo].[tblStudent] ([IdStudent])
GO
ALTER TABLE [dbo].[tblExam]  WITH CHECK ADD FOREIGN KEY([IdExam])
REFERENCES [dbo].[tblExamCode] ([IdExam])
GO
ALTER TABLE [dbo].[tblExam]  WITH CHECK ADD FOREIGN KEY([IdQuestion])
REFERENCES [dbo].[tblQUESTION] ([IdQuestion])
GO
ALTER TABLE [dbo].[tblExamCode]  WITH CHECK ADD FOREIGN KEY([IdSubject])
REFERENCES [dbo].[tblSUBJECT] ([IdSubject])
GO
ALTER TABLE [dbo].[tblQUESTION]  WITH CHECK ADD FOREIGN KEY([IdSubject])
REFERENCES [dbo].[tblSUBJECT] ([IdSubject])
GO
ALTER TABLE [dbo].[tblQUESTION]  WITH CHECK ADD FOREIGN KEY([NameChapter])
REFERENCES [dbo].[Chapter] ([NameChapter])
GO
ALTER TABLE [dbo].[tblResult]  WITH CHECK ADD  CONSTRAINT [fk] FOREIGN KEY([IdExam])
REFERENCES [dbo].[tblExamCode] ([IdExam])
GO
ALTER TABLE [dbo].[tblResult] CHECK CONSTRAINT [fk]
GO
ALTER TABLE [dbo].[tblResult]  WITH CHECK ADD FOREIGN KEY([IdStudent])
REFERENCES [dbo].[tblStudent] ([IdStudent])
GO
ALTER TABLE [dbo].[tblResult]  WITH CHECK ADD FOREIGN KEY([IdSubject])
REFERENCES [dbo].[tblSUBJECT] ([IdSubject])
GO
ALTER TABLE [dbo].[tblStudent]  WITH CHECK ADD FOREIGN KEY([IdClass])
REFERENCES [dbo].[tblClass] ([IdClass])
GO
ALTER TABLE [dbo].[tblExamCode]  WITH CHECK ADD CHECK  (([IdExam]>=(100) AND [IdExam]<=(999)))
GO
ALTER TABLE [dbo].[tblQUESTION]  WITH CHECK ADD CHECK  (([LevelOfDifficult]>=(1) AND [LevelOfDifficult]<=(4)))
GO
ALTER TABLE [dbo].[tblQUESTION]  WITH CHECK ADD CHECK  (([LocationCorrect]>=(1) AND [LocationCorrect]<=(4)))
GO
ALTER TABLE [dbo].[tblSUBJECT]  WITH CHECK ADD CHECK  (([NumCredits]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_insertquestion]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_insertquestion]
@noidung nvarchar(max),@dapanA nvarchar(max),@dapanB nvarchar(max),@dapanC nvarchar(max),@dapanD nvarchar(max),@dapandung int,@dokho int,@monthi varchar(5),@pathimage nvarchar(100),@chuong nvarchar(30)
as
begin
	insert into tblQUESTION(Content,AnswerA,AnswerB,AnswerC,AnswerD,LocationCorrect,LevelOfDifficult,IdSubject,PathImage,NameChapter)
	values(@noidung,@dapanA,@dapanB,@dapanC,@dapanD,@dapandung,@dokho,@monthi,@pathimage,@chuong)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_insertresult]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_insertresult]
	@IdSubject varchar(5),
	@IdStudent varchar(12),
	@IdExam int,
	@Point int
as
begin
	insert into tblResult
	values(@IdStudent,@IdSubject,@idexam,@Point)
end
GO
/****** Object:  StoredProcedure [dbo].[sp_listexamcode]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_listexamcode]
	@IdSubject varchar(5)
AS
BEGIN
	SELECT IdExam
	FROM tblExamCode
	WHERE IdSubject=@IdSubject
END
GO
/****** Object:  StoredProcedure [dbo].[sp_questionbyexamcode]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_questionbyexamcode]
	@IdExam int
AS
BEGIN
	SELECT * 
	FROM tblQuestion
	WHERE IdQuestion
	IN (SELECT IdQuestion FROM tblExam WHERE IdExam = @IdExam)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_result]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_result]
@idsub varchar(5)
as
begin
	select FullName,Birthday,Sex,IdClass,Point
	from tblResult join tblStudent
	on tblResult.IdStudent=tblStudent.IdStudent
	where IdSubject=@idsub
end
GO
/****** Object:  StoredProcedure [dbo].[sp_sizelistexamcode]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_sizelistexamcode]
	@IdSubject varchar(5)
AS
BEGIN
	SELECT count(IdExam) as 'Quantity'
	FROM tblExamCode
	WHERE IdSubject=@IdSubject
END
GO
/****** Object:  StoredProcedure [dbo].[sp_updatequestion]    Script Date: 19/04/2023 6:52:42 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--STORED PROCEDUCE UPDATE
create proc [dbo].[sp_updatequestion]
@macauhoi int,@noidung nvarchar(max),@dapanA nvarchar(max),@dapanB nvarchar(max),@dapanC nvarchar(max),@dapanD nvarchar(max),@dapandung int,@dokho int,@monthi varchar(5),@pathimage nvarchar(100),@chuong nvarchar(30)
as
begin
	update tblQUESTION
	set Content=@noidung
	,AnswerA=@dapanA
	,AnswerB=@dapanB
	,AnswerC=@dapanC
	,AnswerD=@dapanD
	,LocationCorrect=@dapandung
	,LevelOfDifficult=@dokho
	,IdSubject=@monthi
	,PathImage=@pathimage
	,NameChapter=@chuong
	where IdQuestion=@macauhoi
end
GO
