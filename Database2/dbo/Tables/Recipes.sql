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
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Ingredient] FOREIGN KEY([IngredientID])
REFERENCES [dbo].[Inventory] ([IngredientID])
GO

ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Ingredient]
GO
ALTER TABLE [dbo].[Recipes]  WITH CHECK ADD  CONSTRAINT [FK_Recipes_Item] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Menu] ([ItemID])
GO

ALTER TABLE [dbo].[Recipes] CHECK CONSTRAINT [FK_Recipes_Item]