-----------------------
-- Populate tables
-----------------------

USE [MMTShop]
GO

-- Insert Categories 
INSERT INTO dbo.Category ([Name]) VALUES ('Home')
INSERT INTO dbo.Category ([Name]) VALUES ('Garden')
INSERT INTO dbo.Category ([Name]) VALUES ('Electronics')
INSERT INTO dbo.Category ([Name]) VALUES ('Fitness')
INSERT INTO dbo.Category ([Name]) VALUES ('Toys')
GO

-- Insert Products
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Chair' ,'Chair description' ,25 ,1)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Table' ,'Table description' ,30 ,1)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Garden chair' ,'Garden chair description' ,28 ,2)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Garden table' ,'Garden table description' ,32 ,2)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Notebook Dell' ,'Notebook Dell description' , 800 ,3)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Iphone 11' ,'Iphone 11 description' ,1100 ,3)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Spinning bike' ,'Spinning bike description' ,250 ,4)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Treadmill' ,'Treadmill description' ,300 ,4)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Electric car' ,'Electric car description' ,120 ,5)
INSERT INTO dbo.Product ([Name], [Description] ,Price ,CategoryId) VALUES ('Lego' ,'Lego description' ,200 ,5)
GO
