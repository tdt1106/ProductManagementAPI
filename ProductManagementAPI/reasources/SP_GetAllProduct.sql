USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_GetAllProduct]    Script Date: 15/12/2024 7:41:37 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_GetAllProduct]
AS
BEGIN
    SELECT * 
    FROM Product
END

GO

