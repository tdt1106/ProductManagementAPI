USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllCategory]    Script Date: 15/12/2024 7:41:11 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllCategory]
AS
BEGIN
    SELECT * FROM Category;
END;
GO

