
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 06.08.2014
      -- Description:	prevents double entry
      -- Light version for TRA data check  CONSOLE only
      -- =============================================
      CREATE PROCEDURE [dbo].[checkDoubleHIAfromCONSOLE]
        @HIAUIDENT bigint
      ,	@HITRDATE  datetime
      ,	@HIPROT    bigint
      ,	@HILPRICE  numeric(10,4)
      , @HIPBIDENT bigint
      , @HIQUANT   numeric(10,3)
      , @HIDIAL1   varchar(MAX)
      , @HIIDENT   bigint OUTPUT
      AS
      BEGIN
      SET NOCOUNT ON;

      -- check if the data are already existing
      select @HIIDENT=HIIDENT from HIA
      where HIAUIDENT=@HIAUIDENT
      and HITRDATE=@HITRDATE
      and HIPROT=@HIPROT
      and HILPRICE=@HILPRICE
      and HIPBIDENT=@HIPBIDENT
      and HIQUANT=@HIQUANT
      and HIDIAL1=@HIDIAL1
      END
    