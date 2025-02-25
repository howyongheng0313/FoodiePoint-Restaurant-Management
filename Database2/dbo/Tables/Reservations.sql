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
ALTER TABLE [dbo].[Reservations] ADD  DEFAULT ('Pending') FOR [ReservationStatus]