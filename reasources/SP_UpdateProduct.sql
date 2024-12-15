USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateProduct]    Script Date: 15/12/2024 7:42:34 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_UpdateProduct]
    @Id INT,
    @Name NVARCHAR(100),
    @CategoryId INT,
    @Price DECIMAL(18, 2),
    @UpdateBy NVARCHAR(100),
    @UpdateDate DATETIME
AS
BEGIN
    UPDATE Product
    SET Name = @Name, 
        Price = @Price,
        UpdateBy = @UpdateBy,
        UpdateDate = @UpdateDate
    WHERE Id = @Id
END

GO

