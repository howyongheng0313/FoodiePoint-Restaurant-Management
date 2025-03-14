USE [master]
GO
/****** Object:  Database [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF]    Script Date: 23/2/2025 10:28:57 PM ******/
CREATE DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FoodiePoint', FILENAME = N'C:\Users\heeth\OneDrive - Asia Pacific University\Degree 1st Year (Sem 2)\Object-oriented\Chef\Chef\Database\FoodiePoint.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FoodiePoint_log', FILENAME = N'C:\Users\heeth\OneDrive - Asia Pacific University\Degree 1st Year (Sem 2)\Object-oriented\Chef\Chef\Database\FoodiePoint_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ARITHABORT OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET AUTO_SHRINK ON 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET  ENABLE_BROKER 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET  MULTI_USER 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET DB_CHAINING OFF 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET QUERY_STORE = OFF
GO
USE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[FeedbackID] [nvarchar](10) NOT NULL,
	[OrderID] [nvarchar](10) NOT NULL,
	[Feedback] [nvarchar](max) NULL,
	[Rating] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FeedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Halls]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Halls](
	[HallID] [nvarchar](10) NOT NULL,
	[HallName] [nvarchar](100) NOT NULL,
	[HallPartyType] [nvarchar](50) NOT NULL,
	[HallCapacity] [int] NOT NULL,
	[Availability] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[HallID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[IngredientID] [nvarchar](10) NOT NULL,
	[IngredientName] [nvarchar](100) NOT NULL,
	[QuantityInStock] [int] NULL,
	[Unit] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ItemID] [nvarchar](10) NOT NULL,
	[ItemName] [nvarchar](100) NOT NULL,
	[ItemPrice] [decimal](10, 2) NULL,
	[ItemCategory] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItem]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItem](
	[OrderID] [nvarchar](10) NOT NULL,
	[ItemID] [nvarchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [nvarchar](10) NOT NULL,
	[UserID] [nvarchar](10) NOT NULL,
	[DateTime] [datetime] NOT NULL,
	[OrderStatus] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Recipes]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recipes](
	[ItemID] [nvarchar](10) NOT NULL,
	[IngredientID] [nvarchar](10) NOT NULL,
	[Quantity] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[IngredientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Requests]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Requests](
	[RequestID] [nvarchar](10) NOT NULL,
	[ReservationID] [nvarchar](10) NOT NULL,
	[UserRequest] [nvarchar](max) NULL,
	[Reply] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reservations]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservations](
	[ReservationID] [nvarchar](10) NOT NULL,
	[HallID] [nvarchar](10) NOT NULL,
	[UserID] [nvarchar](10) NOT NULL,
	[ReservationDate] [datetime] NOT NULL,
	[ReservationType] [nvarchar](50) NOT NULL,
	[ReservationStatus] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ReservationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23/2/2025 10:28:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [nvarchar](10) NOT NULL,
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Role] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Feedbacks] ADD  DEFAULT ((3)) FOR [Rating]
GO
ALTER TABLE [dbo].[Halls] ADD  DEFAULT ('Available') FOR [Availability]
GO
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT ((0)) FOR [QuantityInStock]
GO
ALTER TABLE [dbo].[Menu] ADD  DEFAULT ((10.00)) FOR [ItemPrice]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ('Pending') FOR [OrderStatus]
GO
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT ('Pending') FOR [ReservationStatus]
GO
ALTER TABLE [dbo].[Users] ADD  DEFAULT ('Customer') FOR [Role]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedbacks_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedbacks_Order]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Menu] ([ItemID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Item]
GO
ALTER TABLE [dbo].[OrderItem]  WITH CHECK ADD  CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItem] CHECK CONSTRAINT [FK_OrderItem_Order]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_User]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Ingredient] FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Inventory] ([IngredientID])
GO
ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Ingredient]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Menu] ([ItemID])
GO
ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Item]
GO
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[Reservations] ([ReservationID])
GO
ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Reservation]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_Hall] FOREIGN KEY([HallID])
REFERENCES [dbo].[Halls] ([HallID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_Hall]
GO
ALTER TABLE [dbo].[Reservations]  WITH CHECK ADD  CONSTRAINT [FK_Reservations_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
GO
ALTER TABLE [dbo].[Reservations] CHECK CONSTRAINT [FK_Reservations_User]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD CHECK  (([Rating]>=(1) AND [Rating]<=(5)))
GO
USE [master]
GO
ALTER DATABASE [C:\USERS\HEETH\ONEDRIVE - ASIA PACIFIC UNIVERSITY\DEGREE 1ST YEAR (SEM 2)\OBJECT-ORIENTED\CHEF\CHEF\DATABASE\FOODIEPOINT.MDF] SET  READ_WRITE 
GO
