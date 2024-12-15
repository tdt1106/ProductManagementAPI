USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteProduct]    Script Date: 15/12/2024 7:41:00 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteProduct]
    @Id INT
AS
BEGIN
    DELETE FROM Product
    WHERE Id = @Id
END

GO

