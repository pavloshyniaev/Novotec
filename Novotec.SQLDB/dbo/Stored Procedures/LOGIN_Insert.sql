
      /* -----------------------------------------------------------------------------
      author : Ralf Buddenhagen
      --------------------------------------------------------------------------------
      when		who		what
      --------------------------------------------------------------------------------
      2008-04-15	 RB      	FPI.net
      --------------------------------------------------------------------------------*/
      CREATE PROCEDURE [dbo].[LOGIN_Insert]
      @LOWHO bigint
      ,	@LOADMIN char(1)
      ,	@LOTYPE char(1)
      ,	@LOPROG char(10)
      , @LODATE datetime
      AS

      SET NOCOUNT ON

      INSERT INTO dbo.LOGIN (
      LOWHO
      ,	LOADMIN
      ,	LOTYPE
      ,	LOPROG
      , LODATE
      )
      VALUES (
      @LOWHO
      ,	@LOADMIN
      ,	@LOTYPE
      ,	@LOPROG
      , @LODATE
      )

      SELECT LOIDENT = @@IDENTITY

      SET NOCOUNT OFF
    