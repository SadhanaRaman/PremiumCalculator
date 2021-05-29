USE [PremiumCalculatorTAL]
GO

/*Populate Ratings*/

INSERT INTO [dbo].[Ratings] ([Rating],[Factor],[Created])VALUES('Professional','1', GETDATE())
GO
INSERT INTO [dbo].[Ratings] ([Rating],[Factor],[Created])VALUES('White Collar','1.25', GETDATE())
GO
INSERT INTO [dbo].[Ratings] ([Rating],[Factor],[Created])VALUES('Light Manual','1.5', GETDATE())
GO
INSERT INTO [dbo].[Ratings] ([Rating],[Factor],[Created])VALUES('Heavy Manual','1.75', GETDATE())
GO


/*Populate Occupations*/

INSERT INTO [dbo].[Occupations] ([Occupation],[RatingID],[Created]) VALUES ('Cleaner',3, GETDATE())
GO
INSERT INTO [dbo].[Occupations]([Occupation],[RatingID],[Created])VALUES('Doctor',1, GETDATE())
GO
INSERT INTO [dbo].[Occupations]([Occupation],[RatingID],[Created])VALUES('Author',2, GETDATE())
GO
INSERT INTO [dbo].[Occupations]([Occupation],[RatingID],[Created])VALUES('Farmer',4, GETDATE())
GO
INSERT INTO [dbo].[Occupations]([Occupation],[RatingID],[Created])VALUES('Mechanic',4, GETDATE())
GO
INSERT INTO [dbo].[Occupations]([Occupation],[RatingID],[Created])VALUES('Florist',3, GETDATE())
GO
