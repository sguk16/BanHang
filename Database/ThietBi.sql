USE [ThietBi]
GO
/****** Object:  Table [dbo].[ThietBi]    Script Date: 02/28/2019 22:37:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ThietBi](
	[id] [char](10) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[gia] [int] NOT NULL,
	[soluong] [int] NOT NULL,
	[loai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 02/28/2019 22:37:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KhachHang](
	[id] [char](10) NOT NULL,
	[ten] [nvarchar](100) NOT NULL,
	[diachi] [nvarchar](100) NULL,
	[sdt] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 02/28/2019 22:37:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HoaDon](
	[id] [char](10) NOT NULL,
	[idkhanghang] [char](10) NOT NULL,
	[ngay] [datetime] NOT NULL,
	[tongtien] [int] NOT NULL,
	[diachigiao] [nvarchar](100) NULL,
	[giaohang] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CTHoaDon]    Script Date: 02/28/2019 22:37:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CTHoaDon](
	[id] [char](10) NOT NULL,
	[idthietbi] [char](10) NOT NULL,
	[soluong] [int] NULL,
 CONSTRAINT [machitiet] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[idthietbi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF__HoaDon__tongtien__0CBAE877]    Script Date: 02/28/2019 22:37:06 ******/
ALTER TABLE [dbo].[HoaDon] ADD  DEFAULT ((0)) FOR [tongtien]
GO
/****** Object:  Default [DF__KhachHang__ten__07F6335A]    Script Date: 02/28/2019 22:37:06 ******/
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT (N'Unknown') FOR [ten]
GO
/****** Object:  Default [DF__ThietBi__ten__014935CB]    Script Date: 02/28/2019 22:37:06 ******/
ALTER TABLE [dbo].[ThietBi] ADD  DEFAULT (N'Unknown') FOR [ten]
GO
/****** Object:  Default [DF__ThietBi__gia__023D5A04]    Script Date: 02/28/2019 22:37:06 ******/
ALTER TABLE [dbo].[ThietBi] ADD  DEFAULT ((0)) FOR [gia]
GO
/****** Object:  Default [DF__ThietBi__soluong__03317E3D]    Script Date: 02/28/2019 22:37:06 ******/
ALTER TABLE [dbo].[ThietBi] ADD  DEFAULT ((0)) FOR [soluong]
GO
