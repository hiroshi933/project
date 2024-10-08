USE [CommunicationBD]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 13.09.2024 14:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[NumberPhone] [varchar](20) NOT NULL,
	[IdTarif] [int] NOT NULL,
	[LastName] [nvarchar](30) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[PatronymicName] [nvarchar](30) NULL,
	[DateBirthday] [date] NULL,
	[PassportSerial] [nvarchar](4) NULL,
	[PassportNumber] [nvarchar](6) NULL,
	[DatePassport] [date] NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[NumberPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Services]    Script Date: 13.09.2024 14:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Services](
	[CodeServies] [varchar](3) NOT NULL,
	[ServiceName] [nvarchar](20) NULL,
	[SalaryService] [decimal](10, 3) NULL,
	[ConnectPrice] [decimal](10, 3) NULL,
 CONSTRAINT [PK_Services] PRIMARY KEY CLUSTERED 
(
	[CodeServies] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tariffs]    Script Date: 13.09.2024 14:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tariffs](
	[IdTarif] [int] IDENTITY(1,1) NOT NULL,
	[TarifName] [nvarchar](50) NULL,
	[Internet] [nchar](10) NULL,
	[CountMinutes] [int] NULL,
	[CountSMS] [int] NULL,
	[Salary] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Tariffs] PRIMARY KEY CLUSTERED 
(
	[IdTarif] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UsingService]    Script Date: 13.09.2024 14:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsingService](
	[Id] [int] NOT NULL,
	[CodeService] [varchar](3) NULL,
	[DateConnection] [date] NULL,
	[NumberPhone] [varchar](20) NULL,
 CONSTRAINT [PK_UsingService] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Clients] ([NumberPhone], [IdTarif], [LastName], [FirstName], [PatronymicName], [DateBirthday], [PassportSerial], [PassportNumber], [DatePassport]) VALUES (N'+79027654389', 1, N'Сидоров', N'Матвей', N'Анатольевич', CAST(N'1976-12-03' AS Date), N'2345', N'123456', CAST(N'1990-12-26' AS Date))
INSERT [dbo].[Clients] ([NumberPhone], [IdTarif], [LastName], [FirstName], [PatronymicName], [DateBirthday], [PassportSerial], [PassportNumber], [DatePassport]) VALUES (N'+79824576256', 2, N'Андреев', N'Федор', N'Сергеевич', CAST(N'1982-06-11' AS Date), N'7547', N'345675', CAST(N'1996-06-27' AS Date))
INSERT [dbo].[Clients] ([NumberPhone], [IdTarif], [LastName], [FirstName], [PatronymicName], [DateBirthday], [PassportSerial], [PassportNumber], [DatePassport]) VALUES (N'+79996548734', 2, N'Степанов', N'Сидор', N'Николаевич', CAST(N'1970-08-05' AS Date), N'3645', N'356735', CAST(N'1984-08-30' AS Date))
GO
INSERT [dbo].[Services] ([CodeServies], [ServiceName], [SalaryService], [ConnectPrice]) VALUES (N'111', N'Любимые номера', CAST(0.372 AS Decimal(10, 3)), CAST(0.686 AS Decimal(10, 3)))
INSERT [dbo].[Services] ([CodeServies], [ServiceName], [SalaryService], [ConnectPrice]) VALUES (N'160', N'Срочный безлимит', CAST(0.707 AS Decimal(10, 3)), CAST(0.000 AS Decimal(10, 3)))
INSERT [dbo].[Services] ([CodeServies], [ServiceName], [SalaryService], [ConnectPrice]) VALUES (N'305', N'4G-бокс', CAST(1.105 AS Decimal(10, 3)), CAST(0.000 AS Decimal(10, 3)))
INSERT [dbo].[Services] ([CodeServies], [ServiceName], [SalaryService], [ConnectPrice]) VALUES (N'306', N'Smart-box', CAST(2.189 AS Decimal(10, 3)), CAST(0.000 AS Decimal(10, 3)))
GO
SET IDENTITY_INSERT [dbo].[Tariffs] ON 

INSERT [dbo].[Tariffs] ([IdTarif], [TarifName], [Internet], [CountMinutes], [CountSMS], [Salary]) VALUES (1, N'Наш Smart', N'1000      ', 1500, 1500, CAST(990.00 AS Decimal(18, 2)))
INSERT [dbo].[Tariffs] ([IdTarif], [TarifName], [Internet], [CountMinutes], [CountSMS], [Salary]) VALUES (2, N'Тарифище', N'50        ', 700, 700, CAST(650.00 AS Decimal(18, 2)))
INSERT [dbo].[Tariffs] ([IdTarif], [TarifName], [Internet], [CountMinutes], [CountSMS], [Salary]) VALUES (3, N'Smart', N'5         ', 250, 250, CAST(450.00 AS Decimal(18, 2)))
INSERT [dbo].[Tariffs] ([IdTarif], [TarifName], [Internet], [CountMinutes], [CountSMS], [Salary]) VALUES (4, N'Мой Smart', N'10        ', 400, 400, CAST(500.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Tariffs] OFF
GO
INSERT [dbo].[UsingService] ([Id], [CodeService], [DateConnection], [NumberPhone]) VALUES (1, N'111', CAST(N'2020-05-12' AS Date), N'+79027654389')
INSERT [dbo].[UsingService] ([Id], [CodeService], [DateConnection], [NumberPhone]) VALUES (2, N'111', CAST(N'2020-09-20' AS Date), N'+79027654389')
INSERT [dbo].[UsingService] ([Id], [CodeService], [DateConnection], [NumberPhone]) VALUES (3, N'160', CAST(N'2020-07-16' AS Date), N'+79824576256')
GO
ALTER TABLE [dbo].[Clients]  WITH CHECK ADD  CONSTRAINT [FK_Clients_Tariffs] FOREIGN KEY([IdTarif])
REFERENCES [dbo].[Tariffs] ([IdTarif])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Clients] CHECK CONSTRAINT [FK_Clients_Tariffs]
GO
ALTER TABLE [dbo].[UsingService]  WITH CHECK ADD  CONSTRAINT [FK_UsingService_Clients] FOREIGN KEY([NumberPhone])
REFERENCES [dbo].[Clients] ([NumberPhone])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsingService] CHECK CONSTRAINT [FK_UsingService_Clients]
GO
ALTER TABLE [dbo].[UsingService]  WITH CHECK ADD  CONSTRAINT [FK_UsingService_Services] FOREIGN KEY([CodeService])
REFERENCES [dbo].[Services] ([CodeServies])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UsingService] CHECK CONSTRAINT [FK_UsingService_Services]
GO
