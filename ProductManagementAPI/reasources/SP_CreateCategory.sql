USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_CreateCategory]    Script Date: 15/12/2024 7:39:32 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_CreateCategory]
    @Name NVARCHAR(100)
AS
BEGIN
    INSERT INTO Category (Name) 
    VALUES (@Name);
END;
GO

