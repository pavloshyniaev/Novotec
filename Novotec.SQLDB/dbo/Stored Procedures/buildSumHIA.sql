
      -- =============================================
      -- Author:		  Ralf Buddenhagen
      -- Create date: 23.03.2018
      -- Description:	build sums per vehicle per month
      -- Changed:
      -- =============================================
      CREATE PROCEDURE [dbo].[buildSumHIA]
      @veident     BIGINT,
      @year        INT,
      @month       INT,
      @sumQuantity DECIMAL(12,3) OUTPUT,
      @sumAVG      DECIMAL(12,2) OUTPUT,
      @numOfRecs   INT           OUTPUT
      AS
      BEGIN
      SET NOCOUNT ON;

      DECLARE hiaCursor SCROLL CURSOR
      FOR
      SELECT SUM (HIQUANT), SUM(HICON100), COUNT(*) from hia
      where hiveident=@veident AND YEAR(HITRDATSTA)=@year AND MONTH(HITRDATSTA)=@month;
      OPEN hiaCursor;

      FETCH NEXT FROM hiaCursor INTO @sumQuantity, @sumAVG, @numOfRecs;

      if @numOfRecs > 0
      BEGIN
      if  @sumAVG > 0
      SET @sumAVG = @sumAVG/@numOfRecs;
      END

      CLOSE hiaCursor;
      DEALLOCATE hiaCursor;

      END
    