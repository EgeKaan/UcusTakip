USE [UcusTakip]
GO
/****** Object:  Table [dbo].[HarekatSB_Komutan]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HarekatSB_Komutan](
	[KisiID] [int] IDENTITY(1,1) NOT NULL,
	[KisiAdi] [nvarchar](50) NULL,
	[KisiSoyadi] [nvarchar](50) NULL,
	[KisiUnvani] [nvarchar](40) NULL,
	[KisiRutbesi] [nvarchar](40) NULL,
 CONSTRAINT [PK_HarekatSB_Komutan] PRIMARY KEY CLUSTERED 
(
	[KisiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HavaAracları]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HavaAracları](
	[HavaAraciNo] [int] IDENTITY(1,1) NOT NULL,
	[HavaAraciTipi] [nchar](10) NULL,
	[HavaAraciAdi] [nchar](10) NULL,
 CONSTRAINT [PK_HavaAracları] PRIMARY KEY CLUSTERED 
(
	[HavaAraciNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[KullanıcıID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelID] [int] NOT NULL,
	[RolID] [int] NOT NULL,
	[KullaniciAdi] [nvarchar](30) NULL,
	[Sifre] [nchar](30) NULL,
 CONSTRAINT [PK_Kullanici] PRIMARY KEY CLUSTERED 
(
	[KullanıcıID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kurs]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kurs](
	[KursNo] [int] IDENTITY(1,1) NOT NULL,
	[KursAdi] [nvarchar](30) NULL,
 CONSTRAINT [PK_Kurs] PRIMARY KEY CLUSTERED 
(
	[KursNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[PersonelNo] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](max) NULL,
	[Soyad] [nvarchar](max) NULL,
	[SinifRutbesi] [nvarchar](30) NULL,
	[SicilNo] [int] NULL,
	[BroveNo] [int] NULL,
	[DogumTarihi] [date] NULL,
	[Birligi] [nvarchar](25) NULL,
	[UcusBirligi] [nvarchar](25) NULL,
	[IlkUcusTarihi] [date] NULL,
	[TemelKursBitirmeTarihi] [date] NULL,
	[ToplamUcusYılı] [int] NULL,
	[GorevDurumu] [nchar](10) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[PersonelNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelAracYetki]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelAracYetki](
	[PersonelAracYetkiID] [int] IDENTITY(1,1) NOT NULL,
	[HavaAraciNo] [int] NULL,
	[PersonelNo] [int] NULL,
	[YetkisiVar] [bit] NULL,
	[AracToplamUcusSuresi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelAracYetkiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelKomutanı]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelKomutanı](
	[PersonelKomutanıID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelNo] [int] NULL,
	[KisiID] [int] NULL,
	[PKTarih] [date] NULL,
	[KisiAciklamasi] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelKomutanıID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelKurs]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelKurs](
	[PersonelKursID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelNo] [int] NULL,
	[KursNo] [int] NULL,
	[KursTarihi] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PersonelKursID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[RolID] [int] IDENTITY(1,1) NOT NULL,
	[RolAdi] [nchar](10) NULL,
	[RolKod] [nchar](10) NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[RolID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarih]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarih](
	[TarihID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelNo] [int] NOT NULL,
	[UcakStanSonTarihi] [date] NULL,
	[HeliStanSonTarih] [date] NULL,
	[YillikSaglik] [date] NULL,
	[YillikSaglikSon] [date] NULL,
	[BesYillikSaglik] [date] NULL,
	[BesYillikSaglikSon] [date] NULL,
 CONSTRAINT [PK_Tarih] PRIMARY KEY CLUSTERED 
(
	[TarihID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UcusBilgileri]    Script Date: 5/20/2020 3:31:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UcusBilgileri](
	[UcusNo] [int] IDENTITY(1,1) NOT NULL,
	[PersonelNo] [int] NOT NULL,
	[HavaAraciNo] [int] NOT NULL,
	[UcusTarihi] [date] NULL,
	[UcusTipi] [nvarchar](50) NULL,
	[UcusDakikası] [int] NULL,
 CONSTRAINT [PK_UcusBilgileri] PRIMARY KEY CLUSTERED 
(
	[UcusNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[HarekatSB_Komutan] ON 

INSERT [dbo].[HarekatSB_Komutan] ([KisiID], [KisiAdi], [KisiSoyadi], [KisiUnvani], [KisiRutbesi]) VALUES (1, N'Mustafa', N'YALÇIN', N'KOMUTAN', N'Pilot ')
INSERT [dbo].[HarekatSB_Komutan] ([KisiID], [KisiAdi], [KisiSoyadi], [KisiUnvani], [KisiRutbesi]) VALUES (2, N'Mehmet', N'YILMAZ', N'HAREKAT SUBAYI', N'Teknisyen')
SET IDENTITY_INSERT [dbo].[HarekatSB_Komutan] OFF
SET IDENTITY_INSERT [dbo].[HavaAracları] ON 

INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (1, N'Helikopter', N'UH-1H     ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (2, N'Uçak      ', N'T-182 T   ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (3, N'Uçak      ', N'T-41      ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (4, N'Uçak      ', N'T-42      ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (5, N'Uçak      ', N'U-17      ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (6, N'Uçak      ', N'C-421     ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (7, N'Helikopter', N'AS-532    ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (8, N'Helikopter', N'AH-1P     ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (9, N'Helikopter', N'AH-1W     ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (12, N'Helikopter', N'asd       ')
INSERT [dbo].[HavaAracları] ([HavaAraciNo], [HavaAraciTipi], [HavaAraciAdi]) VALUES (13, N'Uçak      ', N'123       ')
SET IDENTITY_INSERT [dbo].[HavaAracları] OFF
SET IDENTITY_INSERT [dbo].[Kullanici] ON 

INSERT [dbo].[Kullanici] ([KullanıcıID], [PersonelID], [RolID], [KullaniciAdi], [Sifre]) VALUES (1, 1, 1, N'ege', N'123                           ')
INSERT [dbo].[Kullanici] ([KullanıcıID], [PersonelID], [RolID], [KullaniciAdi], [Sifre]) VALUES (2, 2, 2, N'sato', N'26                            ')
INSERT [dbo].[Kullanici] ([KullanıcıID], [PersonelID], [RolID], [KullaniciAdi], [Sifre]) VALUES (3, 9, 2, N'deneme3', N'123                           ')
INSERT [dbo].[Kullanici] ([KullanıcıID], [PersonelID], [RolID], [KullaniciAdi], [Sifre]) VALUES (4, 10, 1, N'personel5', N'asd                           ')
SET IDENTITY_INSERT [dbo].[Kullanici] OFF
SET IDENTITY_INSERT [dbo].[Kurs] ON 

INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (1, N'GÖVDE')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (2, N'MOTOR')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (3, N'SİLAH SİST.')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (4, N'ROTOR')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (5, N'HİDROLİK')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (6, N'AVİONİK')
INSERT [dbo].[Kurs] ([KursNo], [KursAdi]) VALUES (7, N'ELEKTRİK')
SET IDENTITY_INSERT [dbo].[Kurs] OFF
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([PersonelNo], [Ad], [Soyad], [SinifRutbesi], [SicilNo], [BroveNo], [DogumTarihi], [Birligi], [UcusBirligi], [IlkUcusTarihi], [TemelKursBitirmeTarihi], [ToplamUcusYılı], [GorevDurumu]) VALUES (1, N'Ege', N'Kaan', N'Teknisyen', 2020, 2020, CAST(N'2000-03-31' AS Date), N'Eskişehir', N'Eskişehir', CAST(N'2020-03-03' AS Date), CAST(N'2020-03-03' AS Date), 0, N'Kıt''a     ')
INSERT [dbo].[Personel] ([PersonelNo], [Ad], [Soyad], [SinifRutbesi], [SicilNo], [BroveNo], [DogumTarihi], [Birligi], [UcusBirligi], [IlkUcusTarihi], [TemelKursBitirmeTarihi], [ToplamUcusYılı], [GorevDurumu]) VALUES (2, N'Satılmış', N'ŞAHAN', N'Pilot', 2006, 2006, CAST(N'1987-08-10' AS Date), N'Hava Karacılık', N'Hava Karacılık', CAST(N'2006-06-06' AS Date), CAST(N'2006-06-06' AS Date), 14, N'Kurum/Kh. ')
INSERT [dbo].[Personel] ([PersonelNo], [Ad], [Soyad], [SinifRutbesi], [SicilNo], [BroveNo], [DogumTarihi], [Birligi], [UcusBirligi], [IlkUcusTarihi], [TemelKursBitirmeTarihi], [ToplamUcusYılı], [GorevDurumu]) VALUES (9, N'deneme1', N'deneme1', N'Teknisyen', 2010, 2010, CAST(N'2010-02-02' AS Date), N'deneme1', N'deneme1', CAST(N'2010-02-01' AS Date), CAST(N'2010-02-01' AS Date), 10, N'Kıt''a     ')
INSERT [dbo].[Personel] ([PersonelNo], [Ad], [Soyad], [SinifRutbesi], [SicilNo], [BroveNo], [DogumTarihi], [Birligi], [UcusBirligi], [IlkUcusTarihi], [TemelKursBitirmeTarihi], [ToplamUcusYılı], [GorevDurumu]) VALUES (10, N'Personel5', N'Personel5', N'Pilot', 2017, 2017, CAST(N'1999-03-28' AS Date), N'Isparta', N'Isparta', CAST(N'2019-12-05' AS Date), CAST(N'2019-12-04' AS Date), 0, N'Kurum/Kh. ')
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[PersonelAracYetki] ON 

INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (1, 1, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (2, 2, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (3, 3, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (4, 4, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (5, 5, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (6, 6, 2, 1, NULL)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (7, 3, 1, 0, 32)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (8, 7, 1, 1, 54)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (9, 8, 1, 1, 45)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (10, 9, 1, 1, 894)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (11, 7, 2, 1, 54)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (12, 4, 9, 0, 100)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (13, 7, 9, 1, 45)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (14, 7, 9, 1, 15)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (15, 3, 9, 1, 46)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (16, 2, 10, 1, 12)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (17, 1, 10, 1, 15)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (18, 1, 9, 1, 25)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (19, 3, 9, 1, 36)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (20, 5, 10, 1, 44)
INSERT [dbo].[PersonelAracYetki] ([PersonelAracYetkiID], [HavaAraciNo], [PersonelNo], [YetkisiVar], [AracToplamUcusSuresi]) VALUES (21, 6, 10, 1, 78)
SET IDENTITY_INSERT [dbo].[PersonelAracYetki] OFF
SET IDENTITY_INSERT [dbo].[PersonelKomutanı] ON 

INSERT [dbo].[PersonelKomutanı] ([PersonelKomutanıID], [PersonelNo], [KisiID], [PKTarih], [KisiAciklamasi]) VALUES (1, 2, 1, NULL, N'Uçak Bölük Komutanı ')
INSERT [dbo].[PersonelKomutanı] ([PersonelKomutanıID], [PersonelNo], [KisiID], [PKTarih], [KisiAciklamasi]) VALUES (2, 2, 2, NULL, N'Uçuş Kontrol Komutanı')
INSERT [dbo].[PersonelKomutanı] ([PersonelKomutanıID], [PersonelNo], [KisiID], [PKTarih], [KisiAciklamasi]) VALUES (3, 1, 1, CAST(N'2019-12-26' AS Date), N'Komutan')
SET IDENTITY_INSERT [dbo].[PersonelKomutanı] OFF
SET IDENTITY_INSERT [dbo].[PersonelKurs] ON 

INSERT [dbo].[PersonelKurs] ([PersonelKursID], [PersonelNo], [KursNo], [KursTarihi]) VALUES (1, 1, 1, CAST(N'2019-12-27' AS Date))
INSERT [dbo].[PersonelKurs] ([PersonelKursID], [PersonelNo], [KursNo], [KursTarihi]) VALUES (2, 2, 2, CAST(N'2019-12-28' AS Date))
INSERT [dbo].[PersonelKurs] ([PersonelKursID], [PersonelNo], [KursNo], [KursTarihi]) VALUES (3, 10, 7, CAST(N'2020-01-01' AS Date))
INSERT [dbo].[PersonelKurs] ([PersonelKursID], [PersonelNo], [KursNo], [KursTarihi]) VALUES (4, 9, 5, CAST(N'2019-09-07' AS Date))
SET IDENTITY_INSERT [dbo].[PersonelKurs] OFF
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([RolID], [RolAdi], [RolKod]) VALUES (1, N'Yönetici  ', N'Yonetici  ')
INSERT [dbo].[Rol] ([RolID], [RolAdi], [RolKod]) VALUES (2, N'Personel  ', N'Personel  ')
SET IDENTITY_INSERT [dbo].[Rol] OFF
SET IDENTITY_INSERT [dbo].[Tarih] ON 

INSERT [dbo].[Tarih] ([TarihID], [PersonelNo], [UcakStanSonTarihi], [HeliStanSonTarih], [YillikSaglik], [YillikSaglikSon], [BesYillikSaglik], [BesYillikSaglikSon]) VALUES (1, 2, CAST(N'2017-10-24' AS Date), CAST(N'2017-10-24' AS Date), NULL, CAST(N'2017-02-23' AS Date), CAST(N'2017-08-10' AS Date), CAST(N'2017-08-10' AS Date))
INSERT [dbo].[Tarih] ([TarihID], [PersonelNo], [UcakStanSonTarihi], [HeliStanSonTarih], [YillikSaglik], [YillikSaglikSon], [BesYillikSaglik], [BesYillikSaglikSon]) VALUES (5, 10, CAST(N'2020-01-02' AS Date), CAST(N'2020-01-03' AS Date), NULL, CAST(N'2019-12-27' AS Date), NULL, CAST(N'2024-12-27' AS Date))
SET IDENTITY_INSERT [dbo].[Tarih] OFF
SET IDENTITY_INSERT [dbo].[UcusBilgileri] ON 

INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (3, 9, 2, CAST(N'2019-12-05' AS Date), NULL, 10)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (6, 9, 3, CAST(N'2019-12-25' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 22)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (7, 10, 1, CAST(N'2019-12-26' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 30)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (8, 10, 1, CAST(N'2019-12-25' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 20)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (11, 10, 7, CAST(N'2019-12-27' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 122)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (12, 9, 3, CAST(N'2020-05-23' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 60)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (13, 9, 3, CAST(N'2020-03-19' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 25)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (35, 2, 1, CAST(N'2019-12-05' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 15)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (36, 2, 2, CAST(N'2019-12-25' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 25)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (37, 2, 3, CAST(N'2019-12-26' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 26)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (38, 2, 4, CAST(N'2019-12-25' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 28)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (39, 2, 5, CAST(N'2019-12-27' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 75)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (40, 2, 6, CAST(N'2020-05-23' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 68)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (41, 1, 7, CAST(N'2020-03-19' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 53)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (42, 1, 8, CAST(N'2019-12-06' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 45)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (43, 1, 9, CAST(N'2019-06-25' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 78)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (44, 1, 7, CAST(N'2019-08-26' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 23)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (45, 2, 7, CAST(N'2019-11-25' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 45)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (46, 9, 7, CAST(N'2019-05-27' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 78)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (47, 9, 7, CAST(N'2020-04-23' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 69)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (48, 9, 9, CAST(N'2020-03-19' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 15)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (49, 9, 3, CAST(N'2019-02-05' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 54)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (50, 10, 2, CAST(N'2019-01-02' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 98)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (51, 10, 1, CAST(N'2019-03-26' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 58)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (52, 9, 1, CAST(N'2019-04-05' AS Date), N'GÖREREK UÇUŞ KURALLARI (GUK)', 47)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (53, 9, 3, CAST(N'2019-06-07' AS Date), N'GECE UÇUŞ KURALLARI  (GECE)', 25)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (54, 10, 5, CAST(N'2020-05-02' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 26)
INSERT [dbo].[UcusBilgileri] ([UcusNo], [PersonelNo], [HavaAraciNo], [UcusTarihi], [UcusTipi], [UcusDakikası]) VALUES (55, 10, 6, CAST(N'2020-03-09' AS Date), N'GECE GÖRÜŞ GÖZLÜĞÜ (GGG)', 52)
SET IDENTITY_INSERT [dbo].[UcusBilgileri] OFF
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Personel] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Personel]
GO
ALTER TABLE [dbo].[Kullanici]  WITH CHECK ADD  CONSTRAINT [FK_Kullanici_Rol] FOREIGN KEY([RolID])
REFERENCES [dbo].[Rol] ([RolID])
GO
ALTER TABLE [dbo].[Kullanici] CHECK CONSTRAINT [FK_Kullanici_Rol]
GO
ALTER TABLE [dbo].[PersonelAracYetki]  WITH CHECK ADD FOREIGN KEY([HavaAraciNo])
REFERENCES [dbo].[HavaAracları] ([HavaAraciNo])
GO
ALTER TABLE [dbo].[PersonelAracYetki]  WITH CHECK ADD FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[PersonelKomutanı]  WITH CHECK ADD FOREIGN KEY([KisiID])
REFERENCES [dbo].[HarekatSB_Komutan] ([KisiID])
GO
ALTER TABLE [dbo].[PersonelKomutanı]  WITH CHECK ADD FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[PersonelKurs]  WITH CHECK ADD FOREIGN KEY([KursNo])
REFERENCES [dbo].[Kurs] ([KursNo])
GO
ALTER TABLE [dbo].[PersonelKurs]  WITH CHECK ADD FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[Tarih]  WITH CHECK ADD  CONSTRAINT [FK_Tarih_Personel] FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[Tarih] CHECK CONSTRAINT [FK_Tarih_Personel]
GO
ALTER TABLE [dbo].[UcusBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_UcusBilgileri_HavaAracları] FOREIGN KEY([HavaAraciNo])
REFERENCES [dbo].[HavaAracları] ([HavaAraciNo])
GO
ALTER TABLE [dbo].[UcusBilgileri] CHECK CONSTRAINT [FK_UcusBilgileri_HavaAracları]
GO
ALTER TABLE [dbo].[UcusBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_UcusBilgileri_Personel] FOREIGN KEY([PersonelNo])
REFERENCES [dbo].[Personel] ([PersonelNo])
GO
ALTER TABLE [dbo].[UcusBilgileri] CHECK CONSTRAINT [FK_UcusBilgileri_Personel]
GO
