USE [Proizvodi]
GO
/****** Object:  Table [dbo].[Proizvod]    Script Date: 9/13/2018 7:38:32 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proizvod](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [nvarchar](50) NOT NULL,
	[Opis] [nvarchar](100) NOT NULL,
	[Kategorija] [nvarchar](50) NOT NULL,
	[Proizvodjac] [nvarchar](50) NOT NULL,
	[Cena] [decimal](12, 3) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Proizvod] ON 

INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (1, N'Laptop Dell Inspiron N4050', N'Inspiron N4050 Celeron B815 1,60 Ghz, 2GB DDR3/320GB 14 HD WLED, DVD-RW Wlan + BT, Inte HD graphics', N'Laptop', N'Dell', CAST(30999.250 AS Decimal(12, 3)))
INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (3, N'Acer Aspire laptop E5-521G-47DX', N'Laptop Acer Aspire E5-521-49QU 15.6",AMD QC A4-6210/4GB/500GB/AMD Radeon R3', N'Laptop', N'Acer', CAST(41989.990 AS Decimal(12, 3)))
INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (4, N'Acer tablet B1-730HD', N'Acer tablet B1-730HD 8GB', N'Tablet', N'Acer', CAST(11999.300 AS Decimal(12, 3)))
INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (5, N'Asus tablet MeMO Pad 7', N'Asus tablet MeMO Pad 7 ME70C-1A003A', N'Tablet', N'Asus', CAST(12999.900 AS Decimal(12, 3)))
INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (6, N'Goclever tablet', N'Goclever tablet ORION 70 L KB', N'Tablet', N'Goclever', CAST(5699.450 AS Decimal(12, 3)))
INSERT [dbo].[Proizvod] ([Id], [Naziv], [Opis], [Kategorija], [Proizvodjac], [Cena]) VALUES (1007, N'p780', N'Mobilni telefon Lenovo p780', N'Mobilni telefon', N'Lenovo', CAST(29000.000 AS Decimal(12, 3)))
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
