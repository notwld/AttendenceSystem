USE [master]
GO
/** Object:  Database [InstituteAttendenceSystem]    Script Date: 12/20/2022 2:56:37 PM **/
CREATE DATABASE [InstituteAttendenceSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InstituteAttendenceSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\InstituteAttendenceSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InstituteAttendenceSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\InstituteAttendenceSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [InstituteAttendenceSystem] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InstituteAttendenceSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET  MULTI_USER 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InstituteAttendenceSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InstituteAttendenceSystem] SET QUERY_STORE = OFF
GO
USE [InstituteAttendenceSystem]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [InstituteAttendenceSystem]
GO
/** Object:  Table [dbo].[tbl_course]    Script Date: 12/20/2022 2:56:37 PM **/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseCode] [nvarchar](50) NOT NULL,
	[CourseName] [nvarchar](50) NOT NULL,
	[CourseShortName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tbl_course] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_course] ON 
GO
INSERT [dbo].[tbl_course] ([CourseId], [CourseCode], [CourseName], [CourseShortName]) VALUES (1, N'E1001', N'Interactive Design and Multimedia', N'IDAM')
GO
INSERT [dbo].[tbl_course] ([CourseId], [CourseCode], [CourseName], [CourseShortName]) VALUES (2, N'M1001', N'Desktop Web & Mobile Application', N'DWMAD')
GO
INSERT [dbo].[tbl_course] ([CourseId], [CourseCode], [CourseName], [CourseShortName]) VALUES (3, N'E1002', N'Digital Media & Enterpreneurship', N'DME')
GO
SET IDENTITY_INSERT [dbo].[tbl_course] OFF
GO
USE [master]
GO
ALTER DATABASE [InstituteAttendenceSystem] SET  READ_WRITE 
GO