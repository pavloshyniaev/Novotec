
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 01.12.2009
      -- Description:	prevents double entry 
      -- Light version for TRA data check only
      -- =============================================
      CREATE PROCEDURE [dbo].[checkDoubleHIAfromTA]
        @HIAUIDENT bigint
      ,	@HITRDATE  datetime
      ,	@HIPROT    bigint
      ,	@HISTIDENT bigint
      , @HIPBIDENT bigint
      , @HIQUANT   numeric(10,3)
      , @HIIDENT   bigint OUTPUT
      AS
      BEGIN
      SET NOCOUNT ON;

      -- check if the data are already existing
      select @HIIDENT=HIIDENT from HIA
      where HIAUIDENT=@HIAUIDENT
      and HITRDATE=@HITRDATE
      and HIPROT=@HIPROT
      and HISTIDENT=@HISTIDENT
      and HIPBIDENT=@HIPBIDENT
      and HIQUANT=@HIQUANT
      END
    