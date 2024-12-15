USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_CreateProduct]    Script Date: 15/12/2024 7:39:44 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CreateProduct]
    @Name NVARCHAR(100),
    @CategoryId INT,
    @Price DECIMAL(18, 2),
    @CreatedBy NVARCHAR(100),
    @CreatedDate DATETIME
AS
BEGIN
    INSERT INTO Product (Name, Price, CreatedBy, CreatedDate)
    VALUES (@Name, @Price, @CreatedBy, @CreatedDate)
END

GO

