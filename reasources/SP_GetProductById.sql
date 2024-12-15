USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetProductById]    Script Date: 15/12/2024 7:42:00 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetProductById]
    @Id INT
AS
BEGIN
    SELECT * 
    FROM Product 
    WHERE Id = @Id
END

GO

