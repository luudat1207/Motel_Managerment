USE [master]
GO
/****** Object:  Database [DBNhaTro]    Script Date: 7/31/2022 9:32:53 AM ******/
CREATE DATABASE [DBNhaTro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBNhaTro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBNhaTro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBNhaTro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\DBNhaTro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DBNhaTro] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBNhaTro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBNhaTro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBNhaTro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBNhaTro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBNhaTro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBNhaTro] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBNhaTro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DBNhaTro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBNhaTro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBNhaTro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBNhaTro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBNhaTro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBNhaTro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBNhaTro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBNhaTro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBNhaTro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DBNhaTro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBNhaTro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBNhaTro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBNhaTro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBNhaTro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBNhaTro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DBNhaTro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBNhaTro] SET RECOVERY FULL 
GO
ALTER DATABASE [DBNhaTro] SET  MULTI_USER 
GO
ALTER DATABASE [DBNhaTro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBNhaTro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBNhaTro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBNhaTro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBNhaTro] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DBNhaTro', N'ON'
GO
ALTER DATABASE [DBNhaTro] SET QUERY_STORE = OFF
GO
USE [DBNhaTro]
GO
/****** Object:  Table [dbo].[CHUNHA]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUNHA](
	[IDCN] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_CHUNHA] PRIMARY KEY CLUSTERED 
(
	[IDCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHOADON]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHOADON](
	[IDHD] [int] NOT NULL,
	[MaDV] [int] NOT NULL,
	[SoLuong] [float] NULL,
	[GiaTien] [float] NULL,
 CONSTRAINT [PK_CTHOADON] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC,
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDV] [int] IDENTITY(1,1) NOT NULL,
	[TenDV] [nvarchar](50) NULL,
	[SoTien] [float] NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[IDHD] [int] IDENTITY(1,1) NOT NULL,
	[IDCN] [int] NULL,
	[IDTT] [int] NULL,
	[SoHopDong] [nvarchar](50) NULL,
	[NgayLap] [date] NULL,
	[TienGiam] [float] NULL,
	[TienPhat] [float] NULL,
	[SoTienTra] [float] NULL,
	[TongTien] [float] NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[IDHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[SoHopDong] [nvarchar](50) NOT NULL,
	[IDCN] [int] NULL,
	[CCCD] [nvarchar](50) NULL,
	[MaPhong] [nvarchar](50) NULL,
	[GiaThue] [float] NULL,
	[TuNgay] [date] NULL,
	[DuKienTra] [date] NULL,
	[NgayTra] [date] NULL,
	[DaKetThuc] [bit] NULL,
 CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[SoHopDong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHTHUE]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHTHUE](
	[CCCD] [nvarchar](50) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SDT] [nvarchar](50) NULL,
	[QueQuan] [nvarchar](500) NULL,
	[DiaChi] [nvarchar](500) NULL,
	[ThongTinKhac] [nvarchar](500) NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_KHACHTHUE] PRIMARY KEY CLUSTERED 
(
	[CCCD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGTRO]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGTRO](
	[MaPhong] [nvarchar](50) NOT NULL,
	[MaTinhTrang] [int] NULL,
	[ThongTin] [nvarchar](500) NULL,
	[GiaPhong] [float] NULL,
	[GhiChu] [nvarchar](500) NULL,
 CONSTRAINT [PK_PHONGTRO] PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THANHTOAN]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THANHTOAN](
	[IDTT] [int] IDENTITY(1,1) NOT NULL,
	[LoaiThanhToan] [nvarchar](500) NULL,
 CONSTRAINT [PK_THANHTOAN] PRIMARY KEY CLUSTERED 
(
	[IDTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TINHTRANG]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TINHTRANG](
	[MaTinhTrang] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrang] [nvarchar](50) NULL,
 CONSTRAINT [PK_TINHTRANG] PRIMARY KEY CLUSTERED 
(
	[MaTinhTrang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USER]    Script Date: 7/31/2022 9:32:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER](
	[USERNAME] [nvarchar](50) NOT NULL,
	[PASSWORD] [nvarchar](50) NOT NULL,
	[ROLE] [int] NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[USERNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHUNHA] ON 

INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (1, N'Lưu Bách Thanh ', N'0912631061', N'Bằng B, Hoàng Liệt , Hoàng Mai, Hà Nội ', N'Chủ nhà')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (2, N'Đàm Hạnh ', N'0919400335', N'Bằng B, Hoàng Liệt , Hoàng Mai, Hà Nội ', N'Chủ nhà')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (3, N'Tiến Đạt', N'0941891908', N'Thạch Thất, Hòa lạc', N'Kế Toán')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (4, N'Nguyễn Hiền', N'8022278905', N'Tây Hồ, Hà nội', N'Bảo trì thang máy')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (5, N'Nguyễn Bích', N'8443863050', N'Tam Hiệp, Thanh Trì', N'Vệ Sinh')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (6, N'Minh Quân', N'2923589159', N'Bằng B, Hoàng Liệt , Hoàng Mai, Hà Nội ', N'Camera & Cửa vân tay')
INSERT [dbo].[CHUNHA] ([IDCN], [HoTen], [SDT], [DiaChi], [GhiChu]) VALUES (8, N'Minh Thu', N'0387575925', N'Kham Thien, Ha Noi', N'Vo ke toan')
SET IDENTITY_INSERT [dbo].[CHUNHA] OFF
GO
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (6, 1, 13, 3.5)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (6, 2, 13, 2)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (6, 5, 13, 10)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (6, 6, 13, 5000)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (7, 1, 12, 35000)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (7, 2, 14, 2500)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (7, 5, 1, 10000)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (7, 6, 3, 5000000)
INSERT [dbo].[CTHOADON] ([IDHD], [MaDV], [SoLuong], [GiaTien]) VALUES (7, 8, 1, 50000)
GO
SET IDENTITY_INSERT [dbo].[DICHVU] ON 

INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (1, N'Tiền Nước', 35000, N'Giá Nước Sạch (/Khối) ')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (2, N'Tiền Điện Bậc 1 (0-50)', 2500, N'Giá điện bậc 1(/Số)')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (3, N'Tiền Điện Bậc 2 (51 - 100)', 3000, N'Giá điện bậc 2 (/Số)')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (4, N'Tiền Điện Bậc 3 (101 - 200)', 3500, N'Giá điện bậc 3 (/Số)')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (5, N'Tiền Vệ Sinh', 10000, N'Giá Vệ Sinh (/Phòng)')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (6, N'Tiền Gửi Xe Oto', 5000000, N'Giá gửi xe (/Xe)')
INSERT [dbo].[DICHVU] ([MaDV], [TenDV], [SoTien], [GhiChu]) VALUES (8, N'Tiền Wifi', 50000, N'Giá tiền Wifi (/Tháng)')
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([IDHD], [IDCN], [IDTT], [SoHopDong], [NgayLap], [TienGiam], [TienPhat], [SoTienTra], [TongTien], [GhiChu]) VALUES (6, NULL, 1, N'00000000001', CAST(N'2022-07-22' AS Date), 0, 0, 0, 1065201.5, N'fdg')
INSERT [dbo].[HOADON] ([IDHD], [IDCN], [IDTT], [SoHopDong], [NgayLap], [TienGiam], [TienPhat], [SoTienTra], [TongTien], [GhiChu]) VALUES (7, NULL, 1, N'0000000002', CAST(N'2022-07-22' AS Date), 0, 0, 0, 15525000, N'')
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
INSERT [dbo].[HOPDONG] ([SoHopDong], [IDCN], [CCCD], [MaPhong], [GiaThue], [TuNgay], [DuKienTra], [NgayTra], [DaKetThuc]) VALUES (N'00000000001', 1, N'1546709169', N'101', 1000000, CAST(N'2022-01-01' AS Date), CAST(N'2022-01-10' AS Date), NULL, 0)
INSERT [dbo].[HOPDONG] ([SoHopDong], [IDCN], [CCCD], [MaPhong], [GiaThue], [TuNgay], [DuKienTra], [NgayTra], [DaKetThuc]) VALUES (N'0000000002', 8, N'311327708666', N'104', 10000, CAST(N'2022-07-21' AS Date), NULL, NULL, 0)
INSERT [dbo].[HOPDONG] ([SoHopDong], [IDCN], [CCCD], [MaPhong], [GiaThue], [TuNgay], [DuKienTra], [NgayTra], [DaKetThuc]) VALUES (N'0000000003', 8, N'3113277086', N'104', 10000, CAST(N'2022-07-21' AS Date), CAST(N'2023-07-21' AS Date), CAST(N'2022-07-21' AS Date), 1)
INSERT [dbo].[HOPDONG] ([SoHopDong], [IDCN], [CCCD], [MaPhong], [GiaThue], [TuNgay], [DuKienTra], [NgayTra], [DaKetThuc]) VALUES (N'0000000004', 3, N'311327708666', N'103', 1800000, CAST(N'2022-07-22' AS Date), CAST(N'2023-07-22' AS Date), NULL, 0)
GO
INSERT [dbo].[KHACHTHUE] ([CCCD], [HoTen], [SDT], [QueQuan], [DiaChi], [ThongTinKhac], [GhiChu]) VALUES (N'1546709169', N'Jacques Pinel', N'3389596569', N'Sunbrook', N'2 6th Junction', N'.', N'.')
INSERT [dbo].[KHACHTHUE] ([CCCD], [HoTen], [SDT], [QueQuan], [DiaChi], [ThongTinKhac], [GhiChu]) VALUES (N'3113277086', N'Frants Venny', N'0046663789', N'Dwight', N'69275 Bartillon Way', N'.', N'.')
INSERT [dbo].[KHACHTHUE] ([CCCD], [HoTen], [SDT], [QueQuan], [DiaChi], [ThongTinKhac], [GhiChu]) VALUES (N'311327708666', N'Tommy Xiaomi', N'2362346346', N'Russia', N'afad', N'dgsdg', N'gdasgdg')
INSERT [dbo].[KHACHTHUE] ([CCCD], [HoTen], [SDT], [QueQuan], [DiaChi], [ThongTinKhac], [GhiChu]) VALUES (N'7203194272', N'Grover Bassham', N'6032916081', N'Pankratz', N'867 Continental Trail', N'.', N'.')
INSERT [dbo].[KHACHTHUE] ([CCCD], [HoTen], [SDT], [QueQuan], [DiaChi], [ThongTinKhac], [GhiChu]) VALUES (N'8772932759', N'Rosita Richin', N'9382458263', N'Vahlen', N'397 Dapin Circle
', N'lam ', N'.')
GO
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaTinhTrang], [ThongTin], [GiaPhong], [GhiChu]) VALUES (N'101', 1, N'Điều Hòa, Nóng lạnh, Máy giặt chung, Thảm, Kệ để đồ... Để xe FREE, Giờ giấc đi lại thoải mái, Camera an ninh 24/24,Nhà dọn vệ sinh hàng tuần nên rất sạch sẽ', 3000000, N'.')
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaTinhTrang], [ThongTin], [GiaPhong], [GhiChu]) VALUES (N'102', 2, N'phòng ngủ + bếp, full giường,tủ,nóng lạnh,điều hoà ,cửa sổ thoáng,tủ lạnh,lọc nước,bàn ăn,ti vi,bàn làm việc,nhà có thang máy.', 2700000, N'.')
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaTinhTrang], [ThongTin], [GiaPhong], [GhiChu]) VALUES (N'103', 3, N'Tiện ích cơ bản: điều hoà, nóng lạnh, máy giặt, khu bếp,...
Có người dọn vệ sinh hàng ngày
Chỗ để xe Free, camera 24/24
Không chung chủ, giờ giấc thoải mái, không khép kín', 1800000, N'.')
INSERT [dbo].[PHONGTRO] ([MaPhong], [MaTinhTrang], [ThongTin], [GiaPhong], [GhiChu]) VALUES (N'104', 1, N'Có phòng trọ cho thuê DT 15-17m2, vệ sinh khép kín có gác xép,nhà ở sạch xẽ thoáng mát, an ninh tốt,
giá thuê: 1tr6-1tr8', 5000000, N'.')
GO
SET IDENTITY_INSERT [dbo].[THANHTOAN] ON 

INSERT [dbo].[THANHTOAN] ([IDTT], [LoaiThanhToan]) VALUES (1, N'Chưa thanh toán ')
INSERT [dbo].[THANHTOAN] ([IDTT], [LoaiThanhToan]) VALUES (3, N'Đã Thanh Toán')
SET IDENTITY_INSERT [dbo].[THANHTOAN] OFF
GO
SET IDENTITY_INSERT [dbo].[TINHTRANG] ON 

INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (1, N'Phòng mới')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (2, N'Phòng trung bình')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (3, N'Phòng cũ')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (4, N'Phòng đang cho thuê')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (5, N'Phòng đã có người đặt thuê')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (6, N'Phòng hỏng ')
INSERT [dbo].[TINHTRANG] ([MaTinhTrang], [TinhTrang]) VALUES (8, N'Chưa thanh toán')
SET IDENTITY_INSERT [dbo].[TINHTRANG] OFF
GO
INSERT [dbo].[USER] ([USERNAME], [PASSWORD], [ROLE]) VALUES (N'admin', N'admin',1)
GO
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_DICHVU] FOREIGN KEY([MaDV])
REFERENCES [dbo].[DICHVU] ([MaDV])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_DICHVU]
GO
ALTER TABLE [dbo].[CTHOADON]  WITH CHECK ADD  CONSTRAINT [FK_CTHOADON_HOADON] FOREIGN KEY([IDHD])
REFERENCES [dbo].[HOADON] ([IDHD])
GO
ALTER TABLE [dbo].[CTHOADON] CHECK CONSTRAINT [FK_CTHOADON_HOADON]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_THANHTOAN] FOREIGN KEY([IDTT])
REFERENCES [dbo].[THANHTOAN] ([IDTT])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_THANHTOAN]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_CHUNHA] FOREIGN KEY([IDCN])
REFERENCES [dbo].[CHUNHA] ([IDCN])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_CHUNHA]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_KHACHTHUE] FOREIGN KEY([CCCD])
REFERENCES [dbo].[KHACHTHUE] ([CCCD])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_KHACHTHUE]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_PHONGTRO] FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGTRO] ([MaPhong])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_PHONGTRO]
GO
ALTER TABLE [dbo].[PHONGTRO]  WITH CHECK ADD  CONSTRAINT [FK_PHONGTRO_TINHTRANG] FOREIGN KEY([MaTinhTrang])
REFERENCES [dbo].[TINHTRANG] ([MaTinhTrang])
GO
ALTER TABLE [dbo].[PHONGTRO] CHECK CONSTRAINT [FK_PHONGTRO_TINHTRANG]
GO
USE [master]
GO
ALTER DATABASE [DBNhaTro] SET  READ_WRITE 
GO
