USE [PremiumCalculator]
GO

/*Populate Ratings*/

INSERT INTO [dbo].[Ratings ([Ratings],[Factor])VALUES('Professional','1')
GO
INSERT INTO [dbo].[Ratings ([Ratings],[Factor])VALUES('White Collar','1.25')
GO
INSERT INTO [dbo].[Ratings ([Ratings],[Factor])VALUES('Light Manual','1.5')
GO
INSERT INTO [dbo].[Ratings ([Ratings],[Factor])VALUES('Heavy Manual','1.75')
GO


/*Populate Occupations*/

INSERT INTO [dbo].[Occupation] ([Occupation],[RatingID]) VALUES ('Cleaner',3)
GO
INSERT INTO [dbo].[Occupation]([Occupation],[RatingID])VALUES('Doctor',1)
GO
INSERT INTO [dbo].[Occupation]([Occupation],[RatingID])VALUES('Author',2)
GO
INSERT INTO [dbo].[Occupation]([Occupation],[RatingID])VALUES('Farmer',4)
GO
INSERT INTO [dbo].[Occupation]([Occupation],[RatingID])VALUES('Mechanic',4)
GO
INSERT INTO [dbo].[Occupation]([Occupation],[RatingID])VALUES('Florist',3)
GO
