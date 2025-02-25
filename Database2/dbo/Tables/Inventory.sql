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
ALTER TABLE [dbo].[Inventory] ADD  DEFAULT ((0)) FOR [QuantityInStock]