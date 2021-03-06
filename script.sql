USE [master]
GO
/****** Object:  Database [StadiumMS]    Script Date: 12/6/2018 11:04:53 AM ******/
CREATE DATABASE [StadiumMS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'StadiumMS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StadiumMS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'StadiumMS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\StadiumMS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [StadiumMS] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [StadiumMS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [StadiumMS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [StadiumMS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [StadiumMS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [StadiumMS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [StadiumMS] SET ARITHABORT OFF 
GO
ALTER DATABASE [StadiumMS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [StadiumMS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [StadiumMS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [StadiumMS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [StadiumMS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [StadiumMS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [StadiumMS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [StadiumMS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [StadiumMS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [StadiumMS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [StadiumMS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [StadiumMS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [StadiumMS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [StadiumMS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [StadiumMS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [StadiumMS] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [StadiumMS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [StadiumMS] SET RECOVERY FULL 
GO
ALTER DATABASE [StadiumMS] SET  MULTI_USER 
GO
ALTER DATABASE [StadiumMS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [StadiumMS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [StadiumMS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [StadiumMS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [StadiumMS] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'StadiumMS', N'ON'
GO
ALTER DATABASE [StadiumMS] SET QUERY_STORE = OFF
GO
USE [StadiumMS]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/6/2018 11:04:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 12/6/2018 11:04:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TransactionNumber] [nvarchar](450) NOT NULL,
	[TransactionDate] [datetime2](7) NOT NULL,
	[ClientName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[TransactionType] [nvarchar](max) NULL,
	[Categories] [nvarchar](50) NOT NULL,
	[Quantity] [bigint] NOT NULL,
	[Amount] [bigint] NOT NULL,
	[Email] [nvarchar](max) NULL,
	[no] [bigint] IDENTITY(1,1) NOT NULL,
	[gameno] [nchar](10) NULL,
 CONSTRAINT [PK_Account_1] PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Audience]    Script Date: 12/6/2018 11:04:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Audience](
	[Date] [datetime2](7) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Type] [nvarchar](max) NULL,
	[SeatNo] [nvarchar](max) NULL,
	[gameno] [nvarchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 12/6/2018 11:04:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [bigint] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Designation] [nvarchar](max) NULL,
	[JoiningDate] [datetime2](7) NOT NULL,
	[Salary] [bigint] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GameSchedule]    Script Date: 12/6/2018 11:04:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameSchedule](
	[GameNo] [bigint] IDENTITY(1,1) NOT NULL,
	[Tournament] [nvarchar](max) NULL,
	[TourGameNo] [nvarchar](max) NULL,
	[GameTime] [datetime2](7) NOT NULL,
	[FirstTeam] [nvarchar](max) NULL,
	[SecondTeam] [nvarchar](max) NULL,
	[Cnt] [int] NULL,
 CONSTRAINT [PK_GameSchedule] PRIMARY KEY CLUSTERED 
(
	[GameNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 12/6/2018 11:04:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Data] [varbinary](max) NULL,
	[Length] [int] NOT NULL,
	[Width] [int] NOT NULL,
	[Height] [int] NOT NULL,
	[ContentType] [nvarchar](max) NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 12/6/2018 11:04:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Actor] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vendor]    Script Date: 12/6/2018 11:04:55 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vendor](
	[RegistrationNo] [nvarchar](450) NOT NULL,
	[OrganizationName] [nvarchar](max) NULL,
	[OrganizationEmail] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[OrganizationRegNO] [nvarchar](max) NULL,
	[ContactDuration] [datetime2](7) NOT NULL,
	[ServiceType] [nvarchar](max) NULL,
	[ServiceComment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Vendor] PRIMARY KEY CLUSTERED 
(
	[RegistrationNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([TransactionNumber], [TransactionDate], [ClientName], [Phone], [TransactionType], [Categories], [Quantity], [Amount], [Email], [no], [gameno]) VALUES (N'#xaas123sddsd', CAST(N'2018-12-06T10:31:00.0000000' AS DateTime2), N'Shahir', N'0161234000', N'Online', N'VIP', 1, 0, N'16303039@iubat.edu', 5, NULL)
SET IDENTITY_INSERT [dbo].[Account] OFF
INSERT [dbo].[Audience] ([Date], [Name], [Phone], [Type], [SeatNo], [gameno]) VALUES (CAST(N'2018-12-06T10:30:00.0000000' AS DateTime2), N'Shahir', N'0161234000', N'VIP', N'a2', N'Match 2')
INSERT [dbo].[Audience] ([Date], [Name], [Phone], [Type], [SeatNo], [gameno]) VALUES (CAST(N'2018-12-06T10:31:00.0000000' AS DateTime2), N'Shahir', N'0161234000', N'VIP', N'a3', N'Match 2')
INSERT [dbo].[Employee] ([EmployeeId], [Name], [Email], [Phone], [Designation], [JoiningDate], [Salary]) VALUES (16303039, N'Topu', N'16303039@iubat.edu', N'123', N'Manager', CAST(N'2008-12-10T12:00:00.0000000' AS DateTime2), 656565)
SET IDENTITY_INSERT [dbo].[GameSchedule] ON 

INSERT [dbo].[GameSchedule] ([GameNo], [Tournament], [TourGameNo], [GameTime], [FirstTeam], [SecondTeam], [Cnt]) VALUES (4, N'UEFA', N'Match 16', CAST(N'2018-12-07T22:45:00.0000000' AS DateTime2), N'Real Madrid', N'Arsenal', 0)
SET IDENTITY_INSERT [dbo].[GameSchedule] OFF
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([ID], [Email], [Password], [Actor]) VALUES (1, N'1', N'1', N'Admin')
INSERT [dbo].[Login] ([ID], [Email], [Password], [Actor]) VALUES (2, N'16303039@iubat.edu', N'123', N'Employee')
INSERT [dbo].[Login] ([ID], [Email], [Password], [Actor]) VALUES (3, N'123@gmail', N'0161234000', N'Employee')
SET IDENTITY_INSERT [dbo].[Login] OFF
INSERT [dbo].[Vendor] ([RegistrationNo], [OrganizationName], [OrganizationEmail], [Phone], [OrganizationRegNO], [ContactDuration], [ServiceType], [ServiceComment]) VALUES (N'12323sad22323', N'PRAN-RFL', N'mktg@prangroup.com', N'88028835546', N'51233548545', CAST(N'2020-12-03T23:59:00.0000000' AS DateTime2), N'Plastic Materials', N'Active')
USE [master]
GO
ALTER DATABASE [StadiumMS] SET  READ_WRITE 
GO
