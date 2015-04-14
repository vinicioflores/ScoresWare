USE [master]
GO
/****** Object:  Database [RegistroNotas]    Script Date: 22/03/2015 11:15:26 p.m. ******/
CREATE DATABASE [RegistroNotas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RegistroNotas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RegistroNotas.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'RegistroNotas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\RegistroNotas_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [RegistroNotas] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RegistroNotas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RegistroNotas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RegistroNotas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RegistroNotas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RegistroNotas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RegistroNotas] SET ARITHABORT OFF 
GO
ALTER DATABASE [RegistroNotas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RegistroNotas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RegistroNotas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RegistroNotas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RegistroNotas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RegistroNotas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RegistroNotas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RegistroNotas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RegistroNotas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RegistroNotas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RegistroNotas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RegistroNotas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RegistroNotas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RegistroNotas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RegistroNotas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RegistroNotas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RegistroNotas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RegistroNotas] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RegistroNotas] SET  MULTI_USER 
GO
ALTER DATABASE [RegistroNotas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RegistroNotas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RegistroNotas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RegistroNotas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [RegistroNotas] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RegistroNotas] SET  READ_WRITE 
GO
