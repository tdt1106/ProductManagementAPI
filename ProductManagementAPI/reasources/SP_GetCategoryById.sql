USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetCategoryById]    Script Date: 15/12/2024 7:41:47 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetCategoryById]
    @Id INT
AS
BEGIN
    SELECT * FROM Category WHERE Id = @Id;
END;
GO

