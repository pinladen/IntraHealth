USE [NGO]
GO
/****** Object:  Table [dbo].[AccountN]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountN](
	[idUser] [int] IDENTITY(1,1) NOT NULL,
	[usernameUser] [varchar](250) NULL,
	[passwordUser] [varchar](250) NULL,
	[fistNameUser] [varchar](250) NULL,
	[lastNameUser] [varchar](250) NULL,
	[nicknameUser] [varchar](250) NULL,
	[emailUser] [varchar](250) NULL,
	[avatarUser] [varchar](250) NULL,
	[phoneUser] [int] NULL,
	[brithdayUser] [date] NULL,
	[timeCreateUser] [datetime] NULL,
	[idRole] [int] NULL,
	[statusUser] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[idCategory] [int] IDENTITY(1,1) NOT NULL,
	[nameCategory] [varchar](250) NULL,
	[statusCategory] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategory] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContractUsN]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractUsN](
	[idContractUs] [int] IDENTITY(1,1) NOT NULL,
	[dateCreate] [datetime] NULL,
	[details] [varchar](500) NULL,
	[idUser] [int] NULL,
	[statusContratcus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idContractUs] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donate]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donate](
	[idDonate] [int] IDENTITY(1,1) NOT NULL,
	[amoutDonate] [money] NULL,
	[quantityDonate] [int] NULL,
	[timeDonate] [datetime] NULL,
	[noteDonate] [varchar](550) NULL,
	[idUser] [int] NULL,
	[idEvent] [int] NULL,
	[statusDonate] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idDonate] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventN]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventN](
	[idEvent] [int] IDENTITY(1,1) NOT NULL,
	[nameEvent] [varchar](250) NULL,
	[contentEvent] [varchar](500) NULL,
	[timeCreateEvent] [datetime] NULL,
	[startDateEvent] [date] NULL,
	[endDateEvent] [date] NULL,
	[moutEvent] [money] NULL,
	[amoutAchievedEvent] [money] NULL,
	[addressEvent] [varchar](250) NULL,
	[authorEvent] [varchar](250) NULL,
	[photoEvent] [varchar](250) NULL,
	[statusEvent] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NotificationN]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NotificationN](
	[idNotification] [int] IDENTITY(1,1) NOT NULL,
	[fromAdmin] [varchar](250) NULL,
	[idUser] [int] NULL,
	[textNotification] [varchar](500) NULL,
	[sendTimeNotification] [datetime] NULL,
	[statusNotification] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idNotification] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OtherNGO]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtherNGO](
	[idNGO] [int] IDENTITY(1,1) NOT NULL,
	[nameNGO] [varchar](250) NULL,
	[urlNGO] [varchar](100) NULL,
	[inforNGO] [varchar](100) NULL,
	[joinDateNGO] [date] NULL,
	[statusNGO] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idNGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OtherPartners]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtherPartners](
	[idPartner] [int] IDENTITY(1,1) NOT NULL,
	[logoPt] [varchar](150) NULL,
	[namePT] [varchar](250) NULL,
	[companyPt] [varchar](250) NULL,
	[phonePt] [int] NULL,
	[emailPt] [varchar](250) NULL,
	[joinDatePt] [date] NULL,
	[statusPt] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPartner] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pages]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pages](
	[idPage] [int] IDENTITY(1,1) NOT NULL,
	[namePage] [varchar](250) NULL,
	[titlePage] [varchar](250) NULL,
	[authorPage] [varchar](100) NULL,
	[timeCreatePage] [datetime] NULL,
	[contentPage] [varchar](max) NULL,
	[photoPage] [varchar](250) NULL,
	[idCategory] [int] NULL,
	[statusPage] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPage] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 7/8/2021 12:17:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[idRole] [int] IDENTITY(1,1) NOT NULL,
	[nameRole] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AccountN] ON 

INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (1, N'admin123', N'$2b$10$LTquvEZNY43XczuD3.na6uWHPFo8RRGhhrXiv/kHXprkNCdcTdPZG', N'admin', N'admin', NULL, N'admin@gmail.com', N'283c24c69b5642e68ac7e1b2e7f9ec22.png', 123456789, NULL, CAST(N'2021-07-02T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (16, N'user123', N'$2b$10$vvuI3SB7RsFb/A3UC93Ju./Rn650ixDV3lBbgdIQcbinKWuqo9TU2', N'User', N'New ', N'biden', N'user123@gmail.com', N'33b0e0c94f894ca0bf20cec0b9fca31a.jpeg', 98989898, CAST(N'2001-04-07' AS Date), CAST(N'2021-07-06T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (17, N'userbest123', N'$2b$10$uf0o562O2ZOL9SxWdXx2M.bENDNiiPU22Hn5VenCgwjvHmsuxAE.O', N'UserBest', N'HAwai', NULL, N'userbest@gmail.com', N'no-user1.png', 333333333, NULL, CAST(N'2021-07-06T00:00:00.000' AS DateTime), 1, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (18, N'aptech123', N'$2b$10$cA3OwPTS70YIIIXVnIaUjOEs.ADUU3BgpqjyQmJiucTPCORzyeMhS', NULL, NULL, NULL, N'aptech123@gmail.com', N'no-user1.png', NULL, NULL, CAST(N'2021-07-06T18:00:36.613' AS DateTime), 2, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (19, N'newuser123', N'$2b$10$3dT8AAS0OHgpal71t41m7u6Adak4ItH6QK5dXGJHeiTwqCejE3EAq', NULL, NULL, NULL, N'newuser123@gmail.com', N'no-user1.png', NULL, NULL, CAST(N'2021-07-07T15:30:35.003' AS DateTime), 2, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (20, N'nhattruong123', N'$2b$10$gUNgUZ80me/m58.mg72EGusQpaSaamFj2.KFXUe/IoBHXc9CvvWT2', N'Truong', N'Nhat', N'bon bon', N'nhattruong@gmail.com', N'no-user1.png', 989898989, CAST(N'2001-06-21' AS Date), CAST(N'2021-07-07T00:00:00.000' AS DateTime), 2, 1)
INSERT [dbo].[AccountN] ([idUser], [usernameUser], [passwordUser], [fistNameUser], [lastNameUser], [nicknameUser], [emailUser], [avatarUser], [phoneUser], [brithdayUser], [timeCreateUser], [idRole], [statusUser]) VALUES (21, N'hasythien123', N'$2b$10$w8yH4NE1RglcjaW1MhnbU.cFEqRfbkYeKdmIiTR86K2yqTC.//SpG', N'Sy Thien', N'Ha', N'thien style', N'hathien123@gmail.com', N'42efb373792043a59a60de1306c6f9d0.jpeg', 123456789, CAST(N'2001-02-23' AS Date), CAST(N'2021-07-07T00:00:00.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[AccountN] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([idCategory], [nameCategory], [statusCategory]) VALUES (2, N'About us', 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
SET IDENTITY_INSERT [dbo].[ContractUsN] ON 

INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (1, CAST(N'2021-07-06T17:55:09.507' AS DateTime), N'how are you ?', 17, NULL)
INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (2, CAST(N'2021-07-06T17:55:12.483' AS DateTime), N'how are you ?', 17, NULL)
INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (4, CAST(N'2021-07-06T18:02:13.170' AS DateTime), N'hello', 1, NULL)
INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (5, CAST(N'2021-07-07T11:54:29.077' AS DateTime), N'Hello', 16, NULL)
INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (6, CAST(N'2021-07-07T11:58:15.207' AS DateTime), N'I want donate more', 16, NULL)
INSERT [dbo].[ContractUsN] ([idContractUs], [dateCreate], [details], [idUser], [statusContratcus]) VALUES (7, CAST(N'2021-07-07T15:40:05.983' AS DateTime), N'toi muon gap ban', 20, NULL)
SET IDENTITY_INSERT [dbo].[ContractUsN] OFF
SET IDENTITY_INSERT [dbo].[Donate] ON 

INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (7, 100.0000, 1, CAST(N'2021-07-06T15:25:42.910' AS DateTime), NULL, 1, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (8, 100.0000, 1, CAST(N'2021-07-06T15:57:13.877' AS DateTime), NULL, 1, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (9, 10.0000, 1, CAST(N'2021-07-06T15:57:41.703' AS DateTime), NULL, 1, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (10, 100.0000, 1, CAST(N'2021-07-06T15:58:06.317' AS DateTime), NULL, 1, 2, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (12, 100.0000, 1, CAST(N'2021-07-06T17:52:07.633' AS DateTime), NULL, 17, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (13, 100.0000, 1, CAST(N'2021-07-07T11:38:22.847' AS DateTime), NULL, 16, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (14, 100.0000, 1, CAST(N'2021-07-07T12:35:43.503' AS DateTime), NULL, 16, 4, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (15, 50.0000, 1, CAST(N'2021-07-07T15:28:09.200' AS DateTime), NULL, 16, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (16, 5.0000, 1, CAST(N'2021-07-07T15:39:38.720' AS DateTime), NULL, 20, 1, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (17, 100.0000, 1, CAST(N'2021-07-07T20:23:26.920' AS DateTime), NULL, 1, 16, 1)
INSERT [dbo].[Donate] ([idDonate], [amoutDonate], [quantityDonate], [timeDonate], [noteDonate], [idUser], [idEvent], [statusDonate]) VALUES (18, 100.0000, 1, CAST(N'2021-07-07T21:54:29.593' AS DateTime), NULL, 21, 1, 1)
SET IDENTITY_INSERT [dbo].[Donate] OFF
SET IDENTITY_INSERT [dbo].[EventN] ON 

INSERT [dbo].[EventN] ([idEvent], [nameEvent], [contentEvent], [timeCreateEvent], [startDateEvent], [endDateEvent], [moutEvent], [amoutAchievedEvent], [addressEvent], [authorEvent], [photoEvent], [statusEvent]) VALUES (1, N'Covid-19 2021', N'IntraHealth is calling for and taking urgent action to protect frontline health workers from the on-the-job dangers posed by the COVID-19 pandemic. ', CAST(N'2021-07-03T00:00:00.000' AS DateTime), CAST(N'2021-07-31' AS Date), CAST(N'2021-08-31' AS Date), 50000.0000, 965.0000, N'Ho Chi Minh', N'admin', N'177ac982b14d458ea5baf88c629ec88a.gif', 1)
INSERT [dbo].[EventN] ([idEvent], [nameEvent], [contentEvent], [timeCreateEvent], [startDateEvent], [endDateEvent], [moutEvent], [amoutAchievedEvent], [addressEvent], [authorEvent], [photoEvent], [statusEvent]) VALUES (2, N'HIV & AIDS', N'We’re committed to achieving an AIDS-free generation by 2030—and we believe health workers are the k', CAST(N'2021-07-03T00:00:00.000' AS DateTime), CAST(N'2021-07-25' AS Date), CAST(N'2021-07-23' AS Date), 3000.0000, 100.0000, N'Sai Gon', N'admin', N'36a835df555e46179e15d8d638841c6c.jpeg', 1)
INSERT [dbo].[EventN] ([idEvent], [nameEvent], [contentEvent], [timeCreateEvent], [startDateEvent], [endDateEvent], [moutEvent], [amoutAchievedEvent], [addressEvent], [authorEvent], [photoEvent], [statusEvent]) VALUES (4, N'Global health security', N'IntraHealth is calling for and taking urgent action? in response to the 2019 Novel Coronavirus (COVID-19).', CAST(N'2021-07-05T00:00:00.000' AS DateTime), CAST(N'2021-07-31' AS Date), CAST(N'2021-07-31' AS Date), 10000.0000, 100.0000, N'World', N'admin', N'c2ab31bdb2684fbab633eb1f8db742fd.gif', 1)
INSERT [dbo].[EventN] ([idEvent], [nameEvent], [contentEvent], [timeCreateEvent], [startDateEvent], [endDateEvent], [moutEvent], [amoutAchievedEvent], [addressEvent], [authorEvent], [photoEvent], [statusEvent]) VALUES (16, N'Quy tu thien nhi dong', N'Thank', CAST(N'2021-07-07T00:00:00.000' AS DateTime), CAST(N'2021-07-21' AS Date), CAST(N'2021-07-24' AS Date), 10000.0000, 100.0000, N'Ho Chi Minh', N'admin', N'93a4a65b716c4c87a2b96aedbe98046b.jpeg', 1)
SET IDENTITY_INSERT [dbo].[EventN] OFF
SET IDENTITY_INSERT [dbo].[NotificationN] ON 

INSERT [dbo].[NotificationN] ([idNotification], [fromAdmin], [idUser], [textNotification], [sendTimeNotification], [statusNotification]) VALUES (1, NULL, 17, N'sao vay', CAST(N'2021-07-06T18:37:00.810' AS DateTime), 1)
INSERT [dbo].[NotificationN] ([idNotification], [fromAdmin], [idUser], [textNotification], [sendTimeNotification], [statusNotification]) VALUES (2, N'Admin', 16, N'yes you can', CAST(N'2021-07-07T11:58:38.563' AS DateTime), 1)
INSERT [dbo].[NotificationN] ([idNotification], [fromAdmin], [idUser], [textNotification], [sendTimeNotification], [statusNotification]) VALUES (3, N'Admin', 20, N'khong , ban khong the', CAST(N'2021-07-07T15:40:28.400' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[NotificationN] OFF
SET IDENTITY_INSERT [dbo].[OtherPartners] ON 

INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (1, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (2, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (3, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (4, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (5, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (6, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), 1)
INSERT [dbo].[OtherPartners] ([idPartner], [logoPt], [namePT], [companyPt], [phonePt], [emailPt], [joinDatePt], [statusPt]) VALUES (7, N'redcross.png', N'Red cross', N'red', 114, N'redcross@gmail.com', CAST(N'2021-07-08' AS Date), NULL)
SET IDENTITY_INSERT [dbo].[OtherPartners] OFF
SET IDENTITY_INSERT [dbo].[Pages] ON 

INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (19, N'What we do', N'What we do ', N'admin', CAST(N'2021-07-07T17:28:45.087' AS DateTime), N'We believe everyone everywhere should have the health care they need to thrive. That’s why we work every day to improve the performance of health workers around the world and strengthen the systems in which they work.', N'intrahealth_covid19_tanzania-bu8a0123.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (20, N'Our mission', N'Our mission', N'admin', CAST(N'2021-07-07T17:30:47.413' AS DateTime), N'Our programs span four decades and over 100 countries. And every year, the longstanding relationships we’ve built with government agencies, private-sector partners, and members of civil society become stronger and more effective.

Our programs are designed with a deep understanding of and appreciation for the context of human rights, gender equality and discrimination, economic empowerment, and changing populations.

We listen, analyze, and collaborate to develop the most effective programs in the industry—always specific to their contexts and relevant to the people we serve.', N'no-image.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (21, N'Our team', N'Our team', N'admin', CAST(N'2021-07-07T17:34:33.363' AS DateTime), N'Team White (2020)
Ho Ngoc Duc , 19t , Leader
Tran Hu Nhat Truong , 19t
Ha Sy Thien , 19t

', N'no-image.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (22, N'Career with us', N'Career with us', N'admin', CAST(N'2021-07-07T00:00:00.000' AS DateTime), N'Humans are the most valuable resources we have when it comes to fighting disease and improving health. They can be nimble, efficient, and brilliant. But they can also be overworked, undersupervised, and lacking in up-to-date knowledge and skills. That’s why we use strong human resources management and efficient processes to make sure skilled, motivated health workers are in the right place, at the right time.', N'no-image.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (23, N'Our achievements', N'Our achievements', N'admin', CAST(N'2021-07-07T17:38:05.670' AS DateTime), N'Chúng tôi dã làm vi?c t?i hon 100 qu?c gia k? t? nam 1979. Và chúng tôi h?p tác v?i nh?ng qu?c gia m?i hàng nam. Các chuong trình c?a chúng tôi xây d?ng m?i quan h? lâu dài và nang l?c m?nh m? ? b?t c? noi nào chúng tôi làm vi?c.', N'no-image.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (24, N'Our spporters', N'Our spporters', N'admin', CAST(N'2021-07-07T17:41:35.227' AS DateTime), N'Marianne Vermeer

Chair, IntraHealth International Board of Directors, and Principal, Vermeer Consulting Group LLC
Marianne Vermeer has over 20 years of experience working with growing companies, professional services firms, educational institutions, and non-profit organizations, both in the US and overseas. 

These experiences include roles as chief executive officer, founder, chief financial officer, chief operating officer, board member, consultant, and executive director in industries including pharmaceuticals, health care, medical devices, education, financial services, child development, and manufacturing. Most recently, she has worked with several community development financial institutions (CDFIs) in the US as strategic consultant, financial analyst, and researcher as well as serving in interim management roles and as a strategic consultant with multiple companies in the health care industry.

Her international work has focused primarily in South Asia and East Africa in recent years, though she started her career as a teacher of English as a second language in Cairo, Egypt. 

Her prior work with Acumen and with CDFIs has brought her into the world of social enterprise as consultant and staff member. For the past six years, she has served on the board and as chair of two board committees of ImpactMakers, LLC, a rapidly growing IT services company focused on a social mission based in Virginia. Other board service has included six years on the board of Richmond Metropolitan Habitat for Humanity, seven years on the Venture Forum board (a Richmond-based group focused on entrepreneurial development), and six years on the Sessions (boards of directors) of two Presbyterian Churches. She also recently joined the board of the National Foundation for Ectodermal Dysplasias, an organization that supports families around the world affected by a rare genetic condition.

Vermeer holds a BS Degree from Colorado State University and an MBA from the Wharton School at the University of Pennsylvania.', N'no-image.jpg', 2, 1)
INSERT [dbo].[Pages] ([idPage], [namePage], [titlePage], [authorPage], [timeCreatePage], [contentPage], [photoPage], [idCategory], [statusPage]) VALUES (25, N'Read About us', N'Read About us', N'admin', CAST(N'2021-07-07T00:00:00.000' AS DateTime), N'IntraHealth International is a global health nonprofit that has worked in over 100 countries since 1979. We improve the performance of health workers and strengthen the systems in which they work so that everyone everywhere has the health care they need to thrive.

Because next-generation challenges in global health call for new and extraordinary partnerships, IntraHealth joins forces with governments, businesses, technologists, artists, activists, and more to cultivate local solutions with lasting results. IntraHealth’s programs generate long-term social and economic impact to keep communities around the world healthy, strong, and prosperous.

We focus on health workers. Without them, health care doesn''t happen.

Our Values
Accountability: We set ambitious goals and take ownership to deliver on commitments we undertake individually and collectively.

Equity, diversity, & inclusion: We aim to create and foster a workforce that reflects and contributes to the diverse global community in which we work.

Innovation: We pioneer catalytic solutions, tools, and technologies to address persistent and emerging health challenges.

Learning: We learn from our experiences and adapt accordingly to elevate our organization’s performance, value, and impact.

Partnership: We listen to and partner with diverse constituencies to codesign and implement locally relevant and sustainable results.

Our Story
IntraHealth was born in 1979 as Intrah, the Program for International Training in Health, at the University of North Carolina at Chapel Hill School of Medicine. From the beginning, our focus was on health workers and their role in improving the health of women and their families. IntraHealth incorporated as an independent nonprofit organization in 2003 and now has a staff of over 800 employees working in 37 countries in Africa, the Americas, and Asia.

Our Code of Ethics
To ensure the highest level of honesty and integrity in our work, IntraHealth embraces and adheres to the ten ethical standards outlined in this Code.
', N'no-image.jpg', 2, 1)
SET IDENTITY_INSERT [dbo].[Pages] OFF
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (1, N'admin')
INSERT [dbo].[Roles] ([idRole], [nameRole]) VALUES (2, N'user')
SET IDENTITY_INSERT [dbo].[Roles] OFF
ALTER TABLE [dbo].[AccountN]  WITH CHECK ADD FOREIGN KEY([idRole])
REFERENCES [dbo].[Roles] ([idRole])
GO
ALTER TABLE [dbo].[ContractUsN]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [dbo].[AccountN] ([idUser])
GO
ALTER TABLE [dbo].[Donate]  WITH CHECK ADD FOREIGN KEY([idEvent])
REFERENCES [dbo].[EventN] ([idEvent])
GO
ALTER TABLE [dbo].[Donate]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [dbo].[AccountN] ([idUser])
GO
ALTER TABLE [dbo].[NotificationN]  WITH CHECK ADD FOREIGN KEY([idUser])
REFERENCES [dbo].[AccountN] ([idUser])
GO
ALTER TABLE [dbo].[Pages]  WITH CHECK ADD FOREIGN KEY([idCategory])
REFERENCES [dbo].[Category] ([idCategory])
GO
