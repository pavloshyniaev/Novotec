
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 14.11.2008
      -- Description:	check login
      -- =============================================
      CREATE PROCEDURE [dbo].[RegisterCheck]
      @WSIDENT bigInt OUTPUT
      ,@WSWS varChar (50)
      AS
      BEGIN
      SET NOCOUNT ON;
      SELECT @WSIDENT=WSIDENT from WSTATION where WSIDENT=@WSIDENT and WSWS=@WSWS;
      END
    