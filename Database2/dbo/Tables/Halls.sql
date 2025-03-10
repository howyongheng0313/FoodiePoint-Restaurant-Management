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
ALTER TABLE [dbo].[Halls] ADD  DEFAULT ('Available') FOR [Availability]