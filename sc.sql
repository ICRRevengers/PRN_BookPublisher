USE [master]
GO
/****** Object:  Database [BookPublisher]    Script Date: 7/12/2022 1:31:34 AM ******/
CREATE DATABASE [BookPublisher] ON  PRIMARY 
( NAME = N'BookPublisher', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookPublisher.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BookPublisher_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BookPublisher_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BookPublisher].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BookPublisher] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BookPublisher] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BookPublisher] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BookPublisher] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BookPublisher] SET ARITHABORT OFF 
GO
ALTER DATABASE [BookPublisher] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BookPublisher] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BookPublisher] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BookPublisher] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BookPublisher] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BookPublisher] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BookPublisher] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BookPublisher] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BookPublisher] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BookPublisher] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BookPublisher] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BookPublisher] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BookPublisher] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BookPublisher] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BookPublisher] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BookPublisher] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BookPublisher] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BookPublisher] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BookPublisher] SET  MULTI_USER 
GO
ALTER DATABASE [BookPublisher] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BookPublisher] SET DB_CHAINING OFF 
GO
USE [BookPublisher]
GO
/****** Object:  Table [dbo].[AccountUser]    Script Date: 7/12/2022 1:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountUser](
	[UserID] [nvarchar](20) NOT NULL,
	[UserPassword] [nvarchar](90) NOT NULL,
	[UserFullName] [nvarchar](100) NULL,
	[UserRole] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 7/12/2022 1:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookID] [nvarchar](20) NOT NULL,
	[BookName] [nvarchar](150) NOT NULL,
	[Quantity] [int] NULL,
	[AuthorName] [nvarchar](150) NULL,
	[PublisherID] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 7/12/2022 1:31:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [nvarchar](20) NOT NULL,
	[PublisherName] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
USE [master]
GO
ALTER DATABASE [BookPublisher] SET  READ_WRITE 
GO
