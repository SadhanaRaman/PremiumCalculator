USE [PremiumCalculator]
GO

/****** Object:  Table [dbo].[Occupation]    Script Date: 29/05/2021 3:05:58 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Occupation](
	[OccupationID] [int] IDENTITY(1,1) NOT NULL,
	[Occupation] [varchar](100) NOT NULL,
	[RatingID] [int] NOT NULL,
 CONSTRAINT [PK_Occupation] PRIMARY KEY CLUSTERED 
(
	[OccupationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Occupation]  WITH CHECK ADD  CONSTRAINT [FK_Occupation_Ratings_RatingId] FOREIGN KEY([RatingID])
REFERENCES [dbo].[Ratings] ([RatingID])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Occupation] CHECK CONSTRAINT [FK_Occupation_Ratings_RatingId]
GO


