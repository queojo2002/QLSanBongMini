USE [QLSanBongFinal]
GO
/****** Object:  Table [dbo].[ChiTietLichDat_SanBong]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietLichDat_SanBong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_LDSB] [int] NULL,
	[ID_KVSB] [int] NULL,
	[ID_KH] [int] NULL,
	[NgayDat] [date] NULL,
	[KhungGio_BatDat] [time](7) NULL,
	[KhungGio_KetThuc] [time](7) NULL,
	[GhiChu] [nvarchar](200) NULL,
	[TrangThai] [smallint] NULL,
 CONSTRAINT [PK_ChiTietLichDat_SanBong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FWA]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FWA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDLoaiFWA] [int] NULL,
	[TenFWA] [nvarchar](100) NULL,
	[GiaTien] [int] NULL,
	[image] [varchar](max) NULL,
 CONSTRAINT [PK_FWA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NULL,
	[SDT] [varchar](15) NULL,
	[FB] [varchar](50) NULL,
	[SoLanDat] [int] NULL,
	[Loai_KH] [nvarchar](20) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuVuc_SanBong]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuVuc_SanBong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nvarchar](100) NULL,
	[GiaTien] [int] NULL,
	[KhungGio_BatDau] [time](7) NULL,
	[KhungGio_KetThuc] [time](7) NULL,
 CONSTRAINT [PK_KhuVuc_SanBong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichDat_SanBong]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichDat_SanBong](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_KVSB] [int] NULL,
	[ID_KH] [int] NULL,
	[NgayDat_BatDau] [date] NULL,
	[NgayDat_KetThuc] [date] NULL,
	[KhungGioDat_BatDau] [time](7) NULL,
	[KhungGioDat_KetThuc] [time](7) NULL,
 CONSTRAINT [PK_LichDat_SanBong] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiFWA]    Script Date: 7/13/2022 5:00:53 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiFWA](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiFWA] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiFWA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KhachHang] ADD  CONSTRAINT [DF_KhachHang_SoLanDat]  DEFAULT ((0)) FOR [SoLanDat]
GO
