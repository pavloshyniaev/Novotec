
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 14.11.2008
      -- Description:	login
      -- =============================================
      CREATE PROCEDURE [dbo].[RegisterUpdate]
      @WSIDENT bigint
      AS
      BEGIN
        SET NOCOUNT ON;
        UPDATE WSTATION SET WSDATE=GetDate() where WSIDENT=@WSIDENT
     END
    