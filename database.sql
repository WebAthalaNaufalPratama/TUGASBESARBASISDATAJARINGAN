USE [master]
GO
/****** Object:  Database [db_hotel]    Script Date: 03/07/2023 13:47:35 ******/
CREATE DATABASE [db_hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_hotel', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_hotel.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_hotel_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_hotel_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_hotel] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [db_hotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_hotel] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_hotel] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_hotel', N'ON'
GO
USE [db_hotel]
GO
/****** Object:  User [mine]    Script Date: 03/07/2023 13:47:35 ******/
CREATE USER [mine] FOR LOGIN [mine] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [mine]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [mine]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [mine]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [mine]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [mine]
GO
ALTER ROLE [db_datareader] ADD MEMBER [mine]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [mine]
GO
ALTER ROLE [db_denydatareader] ADD MEMBER [mine]
GO
ALTER ROLE [db_denydatawriter] ADD MEMBER [mine]
GO
/****** Object:  Table [dbo].[tb_kamar]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_kamar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipe_kamar] [varchar](100) NOT NULL,
	[harga] [varchar](100) NOT NULL,
	[status] [varchar](100) NOT NULL,
	[tersedia] [varchar](20) NOT NULL,
	[id_pegawai] [int] NOT NULL,
	[fasilitas] [text] NOT NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_tb_kamar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_keuangan]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_keuangan](
	[id] [int] NOT NULL,
	[total_pengeluaran] [decimal](18, 0) NOT NULL,
	[deskripsi] [text] NOT NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_logs]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_logs](
	[no] [int] IDENTITY(1,1) NOT NULL,
	[user] [varchar](100) NOT NULL,
	[action] [varchar](255) NOT NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_pegawai]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_pegawai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](100) NOT NULL,
	[username] [varchar](100) NOT NULL,
	[email] [varchar](100) NOT NULL,
	[password] [varchar](255) NOT NULL,
	[level] [varchar](100) NOT NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_tb_pegawai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_reservasi]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_reservasi](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tamu] [int] NOT NULL,
	[id_kamar] [int] NOT NULL,
	[tanggal_checkin] [date] NOT NULL,
	[tanggal_checkout] [date] NOT NULL,
	[jam_checkin] [time](7) NULL,
	[jam_checkout] [time](7) NULL,
	[checkin] [int] NULL,
	[checkout] [int] NULL,
	[tagihan] [decimal](18, 0) NOT NULL,
	[id_pegawai] [int] NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_tb_reservasi] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tb_tamu]    Script Date: 03/07/2023 13:47:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_tamu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama] [varchar](100) NOT NULL,
	[notelp] [varchar](100) NOT NULL,
	[noktp] [varchar](100) NOT NULL,
	[email] [varchar](100) NULL,
	[id_pegawai] [int] NOT NULL,
	[updated_at] [datetime] NULL,
	[created_at] [datetime] NOT NULL,
 CONSTRAINT [PK_tb_tamu] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_pegawai] ON 

GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (1, N'admin', N'admin', N'admin@admin.com', N'$2y$10$YR1FJDOWE.I8acOF9BGFoObdn2uL13E2ES/eySm7f7/IrJ6t4k9Fu', N'admin', NULL, CAST(N'2023-06-19 17:25:14.020' AS DateTime))
GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (2, N'fawatashi', N'fawatashi', N'fawatashi@keren.com', N'$2a$11$bHi/zWybXGUzluP4N5HRH.PWcPKBCI9w971QABzRS1bysPv.zS8C2', N'pegawai', CAST(N'2023-06-24 15:32:01.387' AS DateTime), CAST(N'2023-06-23 02:53:19.320' AS DateTime))
GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (3, N'user', N'user', N'user@jancok.com', N'$2a$11$wV4SdcMWWmEd5rfRGITFp.6tanWpdsBmwITazXiOmxsk/JJ3GGq9a', N'pegawai', CAST(N'2023-06-23 03:08:59.480' AS DateTime), CAST(N'2023-06-23 03:08:38.737' AS DateTime))
GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (4, N'kami', N'kami', N'kami@kami.com', N'$2a$11$kGrwGFyx0OY/23sEU1Is2.l2RWLp7/WP21Iz71w3aqlW1PpIYMfXO', N'pegawai', NULL, CAST(N'2023-06-23 14:14:23.377' AS DateTime))
GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (6, N'kamu', N'kamu', N'kamu@kamu.com', N'$2a$11$CqctXdxQqOGVjfLSkPoqFunP//LkGrs7Zlr4E0TXS6tPuAoLKnajK', N'pegawai', NULL, CAST(N'2023-06-24 01:43:05.263' AS DateTime))
GO
INSERT [dbo].[tb_pegawai] ([id], [nama], [username], [email], [password], [level], [updated_at], [created_at]) VALUES (7, N'fawwazskizo', N'fawwazskizo', N'fawwazskizo@gmail.com', N'$2a$11$UWOVgNVb9MKmTzHQsuanU.hfArfg2GnmnWqtHzFBaW89/YfZjE2f6', N'admin', NULL, CAST(N'2023-06-30 09:39:23.373' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tb_pegawai] OFF
GO
/****** Object:  Index [IX_tb_kamar]    Script Date: 03/07/2023 13:47:35 ******/
CREATE NONCLUSTERED INDEX [IX_tb_kamar] ON [dbo].[tb_kamar]
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_tb_tamu_1]    Script Date: 03/07/2023 13:47:35 ******/
ALTER TABLE [dbo].[tb_tamu] ADD  CONSTRAINT [IX_tb_tamu_1] UNIQUE NONCLUSTERED 
(
	[noktp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_tb_tamu]    Script Date: 03/07/2023 13:47:35 ******/
CREATE NONCLUSTERED INDEX [IX_tb_tamu] ON [dbo].[tb_tamu]
(
	[id_pegawai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_logs] ADD  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[tb_kamar]  WITH CHECK ADD  CONSTRAINT [FK_tb_kamar_tb_pegawai] FOREIGN KEY([id_pegawai])
REFERENCES [dbo].[tb_pegawai] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_kamar] CHECK CONSTRAINT [FK_tb_kamar_tb_pegawai]
GO
ALTER TABLE [dbo].[tb_tamu]  WITH CHECK ADD  CONSTRAINT [FK_tb_tamu_tb_pegawai] FOREIGN KEY([id_pegawai])
REFERENCES [dbo].[tb_pegawai] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[tb_tamu] CHECK CONSTRAINT [FK_tb_tamu_tb_pegawai]
GO
USE [master]
GO
ALTER DATABASE [db_hotel] SET  READ_WRITE 
GO
