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
ALTER TABLE [dbo].[Requests]  WITH CHECK ADD  CONSTRAINT [FK_Requests_Reservation] FOREIGN KEY([ReservationID])
REFERENCES [dbo].[Reservations] ([ReservationID])
GO

ALTER TABLE [dbo].[Requests] CHECK CONSTRAINT [FK_Requests_Reservation]