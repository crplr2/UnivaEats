USE [UnivaEats]
GO

/****** Object:  StoredProcedure [dbo].[Login]    Script Date: 8/3/2019 2:55:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[Login] 
	-- Add the parameters for the stored procedure here
	@Matricula int,
	@Password nvarchar(50),
	@Tipo nvarchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT COUNT(*) FROM Usuarios WHERE Usuario_Matricula = @Matricula and Usuario_Password = @Password and Usuario_Tipo = @Tipo
END
GO
