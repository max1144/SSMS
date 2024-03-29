USE [master]
GO
/****** Object:  Database [lukyanenko]    Script Date: 14.02.2024 10:23:45 ******/
CREATE DATABASE [lukyanenko]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Справочник аптекаря Лукьяненко', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Справочник аптекаря Лукьяненко.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Справочник аптекаря Лукьяненко_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Справочник аптекаря Лукьяненко_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [lukyanenko] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [lukyanenko].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [lukyanenko] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [lukyanenko] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [lukyanenko] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [lukyanenko] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [lukyanenko] SET ARITHABORT OFF 
GO
ALTER DATABASE [lukyanenko] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [lukyanenko] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [lukyanenko] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [lukyanenko] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [lukyanenko] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [lukyanenko] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [lukyanenko] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [lukyanenko] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [lukyanenko] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [lukyanenko] SET  DISABLE_BROKER 
GO
ALTER DATABASE [lukyanenko] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [lukyanenko] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [lukyanenko] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [lukyanenko] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [lukyanenko] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [lukyanenko] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [lukyanenko] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [lukyanenko] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [lukyanenko] SET  MULTI_USER 
GO
ALTER DATABASE [lukyanenko] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [lukyanenko] SET DB_CHAINING OFF 
GO
ALTER DATABASE [lukyanenko] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [lukyanenko] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [lukyanenko] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [lukyanenko] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [lukyanenko] SET QUERY_STORE = OFF
GO
USE [lukyanenko]
GO
/****** Object:  Table [dbo].[аптеки]    Script Date: 14.02.2024 10:23:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[аптеки](
	[код_аптеки] [int] IDENTITY(1,1) NOT NULL,
	[название] [nvarchar](max) NULL,
	[область] [nvarchar](max) NULL,
	[город] [nvarchar](max) NULL,
	[улица] [nvarchar](max) NULL,
	[№_дома] [int] NULL,
 CONSTRAINT [PK_аптеки] PRIMARY KEY CLUSTERED 
(
	[код_аптеки] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[лекарства]    Script Date: 14.02.2024 10:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[лекарства](
	[код_лекарства] [int] IDENTITY(1,1) NOT NULL,
	[название_лекарства] [nvarchar](max) NULL,
	[лекарственная_форма] [nvarchar](50) NULL,
	[фото] [image] NULL,
	[производитель] [nvarchar](max) NULL,
	[цена] [money] NULL,
	[характеристики] [nvarchar](max) NULL,
	[описание] [nvarchar](max) NULL,
	[срок_хранение] [nvarchar](max) NULL,
 CONSTRAINT [PK_лекарства] PRIMARY KEY CLUSTERED 
(
	[код_лекарства] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[нал_лек_в_апт]    Script Date: 14.02.2024 10:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[нал_лек_в_апт](
	[код_аптеки] [int] NULL,
	[код_лекарства] [int] NULL,
	[наличие] [nchar](10) NULL,
	[количество] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[нал_лек_в_склд]    Script Date: 14.02.2024 10:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[нал_лек_в_склд](
	[код_склада] [int] NULL,
	[код_лекарства] [int] NULL,
	[наличие] [nchar](10) NULL,
	[количество] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[подст_лек_фор]    Script Date: 14.02.2024 10:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[подст_лек_фор](
	[тип_лекарств] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_подст_лек_фор] PRIMARY KEY CLUSTERED 
(
	[тип_лекарств] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[склады]    Script Date: 14.02.2024 10:23:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[склады](
	[код_склада] [int] IDENTITY(1,1) NOT NULL,
	[область] [nvarchar](max) NULL,
	[город] [nvarchar](max) NULL,
	[улица] [nvarchar](max) NULL,
	[№_дома] [int] NULL,
 CONSTRAINT [PK_склады] PRIMARY KEY CLUSTERED 
(
	[код_склада] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[лекарства]  WITH CHECK ADD  CONSTRAINT [FK_лекарства_подст_лек_фор] FOREIGN KEY([лекарственная_форма])
REFERENCES [dbo].[подст_лек_фор] ([тип_лекарств])
GO
ALTER TABLE [dbo].[лекарства] CHECK CONSTRAINT [FK_лекарства_подст_лек_фор]
GO
ALTER TABLE [dbo].[нал_лек_в_апт]  WITH CHECK ADD  CONSTRAINT [FK_нал_лек_в_апт_аптеки] FOREIGN KEY([код_аптеки])
REFERENCES [dbo].[аптеки] ([код_аптеки])
GO
ALTER TABLE [dbo].[нал_лек_в_апт] CHECK CONSTRAINT [FK_нал_лек_в_апт_аптеки]
GO
ALTER TABLE [dbo].[нал_лек_в_апт]  WITH CHECK ADD  CONSTRAINT [FK_нал_лек_в_апт_лекарства] FOREIGN KEY([код_лекарства])
REFERENCES [dbo].[лекарства] ([код_лекарства])
GO
ALTER TABLE [dbo].[нал_лек_в_апт] CHECK CONSTRAINT [FK_нал_лек_в_апт_лекарства]
GO
ALTER TABLE [dbo].[нал_лек_в_склд]  WITH CHECK ADD  CONSTRAINT [FK_нал_лек_в_склд_лекарства] FOREIGN KEY([код_лекарства])
REFERENCES [dbo].[лекарства] ([код_лекарства])
GO
ALTER TABLE [dbo].[нал_лек_в_склд] CHECK CONSTRAINT [FK_нал_лек_в_склд_лекарства]
GO
ALTER TABLE [dbo].[нал_лек_в_склд]  WITH CHECK ADD  CONSTRAINT [FK_нал_лек_в_склд_склады] FOREIGN KEY([код_склада])
REFERENCES [dbo].[склады] ([код_склада])
GO
ALTER TABLE [dbo].[нал_лек_в_склд] CHECK CONSTRAINT [FK_нал_лек_в_склд_склады]
GO
USE [master]
GO
ALTER DATABASE [lukyanenko] SET  READ_WRITE 
GO
