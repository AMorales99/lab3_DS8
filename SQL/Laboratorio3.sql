USE [master]
GO
/****** Object:  Database [Laboratorio3]    Script Date: 14/11/2021 21:49:22 ******/
CREATE DATABASE [Laboratorio3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Laboratorio3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Laboratorio3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Laboratorio3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Laboratorio3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Laboratorio3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Laboratorio3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Laboratorio3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Laboratorio3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Laboratorio3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Laboratorio3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Laboratorio3] SET ARITHABORT OFF 
GO
ALTER DATABASE [Laboratorio3] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Laboratorio3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Laboratorio3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Laboratorio3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Laboratorio3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Laboratorio3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Laboratorio3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Laboratorio3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Laboratorio3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Laboratorio3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Laboratorio3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Laboratorio3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Laboratorio3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Laboratorio3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Laboratorio3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Laboratorio3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Laboratorio3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Laboratorio3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Laboratorio3] SET  MULTI_USER 
GO
ALTER DATABASE [Laboratorio3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Laboratorio3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Laboratorio3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Laboratorio3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Laboratorio3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Laboratorio3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Laboratorio3] SET QUERY_STORE = OFF
GO
USE [Laboratorio3]
GO
/****** Object:  User [pedro]    Script Date: 14/11/2021 21:49:22 ******/
CREATE USER [pedro] FOR LOGIN [pedro] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[tbl_cuenta]    Script Date: 14/11/2021 21:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cuenta](
	[id_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[tipo] [int] NOT NULL,
	[saldo] [numeric](18, 2) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
 CONSTRAINT [id_cuenta_PK] PRIMARY KEY CLUSTERED 
(
	[id_cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_datoscliente]    Script Date: 14/11/2021 21:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_datoscliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[telefono_movil] [varchar](50) NULL,
	[direccion] [varchar](150) NOT NULL,
	[fecha_creacion] [datetime] NULL,
	[fecha_modificacion] [datetime] NULL,
 CONSTRAINT [id_cliente_PK] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_movimientos]    Script Date: 14/11/2021 21:49:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_movimientos](
	[id_cuenta] [int] NULL,
	[deposito] [decimal](18, 2) NULL,
	[retiro] [numeric](18, 2) NULL,
	[fecha] [datetime2](7) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_cuenta]  WITH CHECK ADD  CONSTRAINT [id_cliente_tbl_cuenta_FK] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[tbl_datoscliente] ([id_cliente])
GO
ALTER TABLE [dbo].[tbl_cuenta] CHECK CONSTRAINT [id_cliente_tbl_cuenta_FK]
GO
ALTER TABLE [dbo].[tbl_movimientos]  WITH CHECK ADD  CONSTRAINT [id_cuenta_tbl_movimientos_FK] FOREIGN KEY([id_cuenta])
REFERENCES [dbo].[tbl_cuenta] ([id_cuenta])
GO
ALTER TABLE [dbo].[tbl_movimientos] CHECK CONSTRAINT [id_cuenta_tbl_movimientos_FK]
GO
USE [master]
GO
ALTER DATABASE [Laboratorio3] SET  READ_WRITE 
GO
