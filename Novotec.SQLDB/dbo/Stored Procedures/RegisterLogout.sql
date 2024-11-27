
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 14.12.2009
      -- Description:	free the entry when exiting program
      -- =============================================
      CREATE PROCEDURE [dbo].[RegisterLogout]
      @WSIDENT bigint
      AS
      BEGIN
         SET NOCOUNT ON;
         UPDATE WSTATION SET WSWS='' where WSIDENT=@WSIDENT
      END
    