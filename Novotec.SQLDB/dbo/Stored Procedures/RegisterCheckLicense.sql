
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 01.12.2009
      -- Description:	checks the number of entries
      -- =============================================
      CREATE PROCEDURE [dbo].[RegisterCheckLicense]
      @WSWHO		bigint
      ,@Number	int
      AS
      BEGIN
      DECLARE @num int;

      -- SET NOCOUNT ON added to prevent extra result sets from
      -- interfering with SELECT statements.
      SET NOCOUNT ON;

      -- Insert statements for procedure here
      LABEL1:
      SELECT @num=COUNT (*) FROM [dbo].[WSTATION];

      if (@num <> @Number )
      BEGIN
         IF @num < @Number
  	     BEGIN
		        INSERT INTO [dbo].[WSTATION] (WSWHO) VALUES (@WSWHO);
		        GOTO LABEL1;
		     END
		     IF @num > @Number
		     BEGIN
			      DELETE from WSTATION  WHERE WSIDENT IN (SELECT TOP(1) WSIDENT FROM WSTATION);
			      GOTO LABEL1;
		     END
	     END
     END
    