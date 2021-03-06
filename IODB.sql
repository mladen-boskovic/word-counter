USE [master]
GO
/****** Object:  Database [IODB]    Script Date: 21-Feb-21 18:50:33 ******/
CREATE DATABASE [IODB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IODB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\IODB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IODB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\IODB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [IODB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IODB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IODB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IODB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IODB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IODB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IODB] SET ARITHABORT OFF 
GO
ALTER DATABASE [IODB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IODB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IODB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IODB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IODB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IODB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IODB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IODB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IODB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IODB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IODB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IODB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IODB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IODB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IODB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IODB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IODB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IODB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IODB] SET  MULTI_USER 
GO
ALTER DATABASE [IODB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IODB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IODB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IODB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [IODB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [IODB] SET QUERY_STORE = OFF
GO
USE [IODB]
GO
/****** Object:  Table [dbo].[Text]    Script Date: 21-Feb-21 18:50:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Text](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Text] ON 

INSERT [dbo].[Text] ([Id], [Content]) VALUES (1, N'This is some
text')
INSERT [dbo].[Text] ([Id], [Content]) VALUES (2, N'This is another text')
INSERT [dbo].[Text] ([Id], [Content]) VALUES (3, N'Test input')
SET IDENTITY_INSERT [dbo].[Text] OFF
USE [master]
GO
ALTER DATABASE [IODB] SET  READ_WRITE 
GO
