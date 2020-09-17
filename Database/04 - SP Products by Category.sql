USE MMTShop
GO
-- =====================================================
-- Author:		Marcos Roig
-- Create date: 2020-09-16
-- Description:	Get all products for a given category

-- Execute dbo.Products_ByCategory 1
-- =====================================================
CREATE PROCEDURE Products_ByCategory 
(
   @CategoryId INT
)	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT Sku, 
	       [Name], 
		   [Description], 
		   Price, 
		   CategoryId
	FROM dbo.Product
	WHERE CategoryId = @CategoryId

END
GO