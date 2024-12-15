USE [ProductManagementAPI]
GO

/****** Object:  StoredProcedure [dbo].[SP_DeleteCategory]    Script Date: 15/12/2024 7:40:45 CH ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SP_DeleteCategory]
    @Id INT
AS
BEGIN
    DELETE FROM Category WHERE Id = @Id;
END;
GO

