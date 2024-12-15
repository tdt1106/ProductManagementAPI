USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_UpdateCategory]    Script Date: 15/12/2024 7:42:24 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_UpdateCategory]
    @Id INT,
    @Name NVARCHAR(100)
AS
BEGIN
    UPDATE Category
    SET Name = @Name
    WHERE Id = @Id;
END;
GO

