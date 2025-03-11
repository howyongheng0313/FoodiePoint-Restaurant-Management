DROP TABLE IF EXISTS [dbo].[Requests];
DROP TABLE IF EXISTS [dbo].[Reservations];
DROP TABLE IF EXISTS [dbo].[Halls];

DROP TABLE IF EXISTS [dbo].[Feedbacks];
DROP TABLE IF EXISTS [dbo].[OrderItem];
DROP TABLE IF EXISTS [dbo].[Orders];
DROP TABLE IF EXISTS [dbo].[Users];

DROP TABLE IF EXISTS [dbo].[Recipes];
DROP TABLE IF EXISTS [dbo].[Inventory];
DROP TABLE IF EXISTS [dbo].[Menu];

-- MENU-INVENTORY Branch
CREATE TABLE [dbo].[Menu]
(
    [ID]           INT IDENTITY(1,1),
    [ItemID]       AS CAST('I' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [ItemName]     NVARCHAR(100) NOT NULL,
    [ItemPrice]    DECIMAL(10,2) NOT NULL DEFAULT 10.00,
    [ItemCategory] NVARCHAR(50)  NOT NULL
);

CREATE TABLE [dbo].[Inventory]
(
    [ID]              INT IDENTITY(1,1),
    [IngredientID]    AS CAST('ING' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [IngredientName]  NVARCHAR(100) NOT NULL,
    [QuantityInStock] FLOAT         NOT NULL DEFAULT 0,
    [Unit]            NVARCHAR(20)  NOT NULL
);

CREATE TABLE [dbo].[Recipes]
(
    [ItemID]       NVARCHAR(10) NOT NULL,
    [IngredientID] NVARCHAR(10) NOT NULL,
    [Quantity]     FLOAT        NOT NULL,
    PRIMARY KEY (ItemID, IngredientID),
    CONSTRAINT FK_Recipes_Item
        FOREIGN KEY (ItemID) REFERENCES [dbo].[Menu] (ItemID) ON DELETE CASCADE,
    CONSTRAINT FK_Recipes_Ingredient
        FOREIGN KEY (IngredientID) REFERENCES [dbo].[Inventory] (IngredientID) ON DELETE CASCADE
);

-- USER Branch (using MENU)
CREATE TABLE [dbo].[Users]
(
    [ID]       INT IDENTITY(1,1),
    [UserID]   AS CAST('U' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [Username] NVARCHAR(50)  NOT NULL UNIQUE,
    [Password] NVARCHAR(50)  NOT NULL,
    [FullName] NVARCHAR(100) NOT NULL,
    [Email]    NVARCHAR(100) NOT NULL UNIQUE,
    [Role]     NVARCHAR(50)  NOT NULL DEFAULT 'Customer' 
);

CREATE TABLE [dbo].[Orders]
(
    [ID]          INT IDENTITY(1,1),
    [OrderID]     AS CAST('OD' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [UserID]      NVARCHAR(10) NOT NULL,
    [DateTime]    DATETIME     NOT NULL,
    [OrderStatus] NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_Orders_User
        FOREIGN KEY (UserID) REFERENCES [dbo].[Users] (UserID) ON DELETE CASCADE
);

CREATE TABLE [dbo].[OrderItem]
(
    [OrderID]  NVARCHAR(10) NOT NULL,
    [ItemID]   NVARCHAR(10) NOT NULL,
    [Quantity] INT          NOT NULL,
    PRIMARY KEY (OrderID, ItemID),
    CONSTRAINT FK_OrderItem_Order
        FOREIGN KEY (OrderID) REFERENCES [dbo].[Orders] (OrderID) ON DELETE CASCADE,
    CONSTRAINT FK_OrderItem_Item
        FOREIGN KEY (ItemID) REFERENCES [dbo].[Menu] (ItemID)
);

CREATE TABLE [dbo].[Feedbacks]
(
    [ID]         INT IDENTITY(1,1),
    [FeedbackID] AS CAST('F' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [OrderID]    NVARCHAR(10) NOT NULL,
    [Feedback]   NVARCHAR(MAX),
    [Rating]     INT          NOT NULL DEFAULT 3 CHECK (Rating BETWEEN 1 AND 5),
    CONSTRAINT FK_Feedbacks_Order
        FOREIGN KEY (OrderID) REFERENCES [dbo].[Orders] (OrderID)
);

-- HALL Branch (using USER)
CREATE TABLE [dbo].[Halls]
(
    [ID]            INT IDENTITY(1,1),
    [HallID]        AS CAST('H' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [HallName]      NVARCHAR(100) NOT NULL,
    [HallPartyType] NVARCHAR(50)  NOT NULL,
    [HallCapacity]  INT           NOT NULL,
    [Availability]  NVARCHAR(20)  NOT NULL DEFAULT 'Available'
);

CREATE TABLE [dbo].[Reservations]
(
    [ID]                INT IDENTITY(1,1),
    [ReservationID]     AS CAST('RS' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [HallID]            NVARCHAR(10),
    [UserID]            NVARCHAR(10) NOT NULL,
    [GuestCount]        INT          NOT NULL,
    [ReservationDate]   DATETIME     NOT NULL,
    [ReservationType]   NVARCHAR(50) NOT NULL,
    [ReservationStatus] NVARCHAR(20) NOT NULL DEFAULT 'Pending',
    CONSTRAINT FK_Reservations_Hall
        FOREIGN KEY (HallID) REFERENCES [dbo].[Halls] (HallID),
    CONSTRAINT FK_Reservations_User
        FOREIGN KEY (UserID) REFERENCES [dbo].[Users] (UserID)
);

CREATE TABLE [dbo].[Requests]
(
    [ID]            INT IDENTITY(1,1),
    [RequestID]     AS CAST('RQ' + RIGHT('000' + CAST([ID] AS VARCHAR),3) AS NVARCHAR(10)) PERSISTED PRIMARY KEY,
    [ReservationID] NVARCHAR(10) NOT NULL,
    [UserRequest]   NVARCHAR(MAX),
    [Reply]         NVARCHAR(MAX),
    CONSTRAINT FK_Requests_Reservation
        FOREIGN KEY (ReservationID) REFERENCES [dbo].[Reservations] (ReservationID) ON DELETE CASCADE
);
