USE MMTShop
GO
-- =============================================
-- Author:		Marcos Roig
-- Create date: 2020-09-16
-- Description:	Get all categories

-- Execute dbo.Categories_GetAll 
-- =============================================
CREATE PROCEDURE Categories_GetAll 
	
AS
BEGIN
	
	SET NOCOUNT ON;

	SELECT [Id], 
	       [Name]
	FROM dbo.Category

END
GO
