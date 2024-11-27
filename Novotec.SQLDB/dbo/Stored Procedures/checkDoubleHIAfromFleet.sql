
      -- =============================================
      -- Author:		Ralf Buddenhagen
      -- Create date: 01.12.2009
      -- Description:	prevents double entry
      -- for fleet import data check only
      -- =============================================
      CREATE PROCEDURE [dbo].[checkDoubleHIAfromFleet]
      @HIAUIDENT bigint
      ,	@HITRDATE  datetime
      ,	@HIPROT    bigint
      ,	@HIFUIDENT bigint
      , @HIPBIDENT bigint
      , @HIEMIDENT bigint
      , @HIVEIDENT bigint
      , @HICAIDENT bigint
      , @HIQUANT   numeric(10,3)
      , @HITOTAL1  numeric(10,2)
      , @HIRECNO   bigint
      , @HIIDENT   bigint OUTPUT
      AS
      BEGIN
      SET NOCOUNT ON;

      -- check if the data are already existing
      select @HIIDENT=HIIDENT from HIA
      where HIAUIDENT=@HIAUIDENT
      and HIRECNO=@HIRECNO
      and HITRDATE=@HITRDATE
      and HIPROT=@HIPROT
      and HIVEIDENT=@HIVEIDENT
      and HIEMIDENT=@HIEMIDENT
      and HICAIDENT=@HICAIDENT
      and HIFUIDENT=@HIFUIDENT
      and HIPBIDENT=@HIPBIDENT
      and HITOTAL1=@HITOTAL1
      and HIQUANT=@HIQUANT
      END
    