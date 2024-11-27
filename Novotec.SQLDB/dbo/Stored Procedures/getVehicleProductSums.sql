
      -- =============================================
      -- Author:		  Ralf Buddenhagen
      -- Create date: 23.03.2018
      -- Description:	 calculates product sums per vehicle per month, starting with January of the given year
      -- Changed:
      -- =============================================
      CREATE PROCEDURE [dbo].[getVehicleProductSums]
            @startYear int
            AS
            BEGIN
            SET NOCOUNT ON;

            DECLARE @count    int;
            SET     @count = 0;

            DECLARE @help     bigint;

            DECLARE @month    int;
            DECLARE @year     int;
            DECLARE @currentYear int;
            Select  @currentYear = YEAR(GETDATE());
            DECLARE @currentMonth int;
            Select  @currentMonth = MONTH(GETDATE());


            -- create the result table
            IF  EXISTS (SELECT * FROM sysobjects WHERE xtype='u' and name ='VehProdSums')
            DROP TABLE [dbo].[VehProdSums];

            CREATE TABLE VehProdSums(
            [veident]	        bigint			  NULL,
            [veyear]				  int				    NULL,
            [vemonth]				  int				    NULL,
            [veplate]   	    varchar(50)   NULL,
            [veintno]         varchar(50)   NULL,
            [vestoc]          varchar(50)   NULL,
            [vecc]            varchar(50)   NULL,
            [vequant]				  decimal(12,3)	NULL,
            [veavg]				    decimal(12,2)	NULL,
            [vepbident]			  bigint			  NULL,
            [vepbtitle]		    varchar(50)		NULL,
            [vepgident]			  bigint			  NULL,
            [vepgtitle]		    varchar(50)		NULL
            ) ON [PRIMARY];

            DECLARE @veident		bigint;
            DECLARE @veyear		  int;
            DECLARE @vemonth		int;
            DECLARE @veplate   	varchar(50);
            DECLARE @veintno    varchar(50);
            DECLARE @vestoc     varchar(50);
            DECLARE @vecc       varchar(50);
            DECLARE @vequant		decimal(12,3);
            DECLARE @veavg			decimal(12,2);
            DECLARE @vepbident	bigint;
            DECLARE @vepbtitle	varchar(50);
            DECLARE @vepgident	bigint;
            DECLARE @vepgtitle	varchar(50);

            DECLARE @quant		  decimal(12,3);
            DECLARE @avg			  decimal(12,2);


            -- get all the vehicles and machines which are not out of order
            DECLARE vehCursor SCROLL CURSOR
            FOR
            SELECT  veident, veplate, veintno,vestoc,vecc, VEPBIDENT, pbtitle, VEPGIDENT, pgtitle from vehicle LEFT OUTER JOIN pbase ON vepbident=pbident LEFT OUTER JOIN pgroup ON vepgident=pgident where VEEND IS NULL  order by veident;

            OPEN vehCursor;
            FETCH NEXT FROM vehCursor INTO @veident, @veplate, @veintno, @vestoc, @vecc, @vepbident, @vepbtitle, @vepgident, @vepgtitle;

            WHILE @@FETCH_STATUS = 0
            BEGIN
            SET @month = 1;
            SET @year  = @startYear;
            SET @count = 0;
            SET @avg   = 0;
            SET @quant = 0;
            SET @veavg   = 0;
            SET @vequant = 0;


            WHILE (@year <= @currentYear)
            BEGIN
            WHILE (@month <= 12)
            BEGIN

            EXECUTE dbo.buildSumHIA @veident, @year,@month,
            @vequant OUTPUT,
            @veavg OUTPUT,
            @count OUTPUT;

            if @count > 0
            BEGIN
            SET @veavg = @veavg / @count;
            INSERT INTO VehProdSums(
            [veident],
            [veyear],
            [vemonth],
            [veplate],
            [veintno],
            [vestoc],
            [vecc],
            [vequant],
            [veavg],
            [vepbident],
            [vepbtitle],
            [vepgident],
            [vepgtitle])
            VALUES
            (
            @veident,
            @year,
            @month,
            @veplate,
            @veintno,
            @vestoc,
            @vecc,
            @vequant,
            @veavg,
            @vepbident,
            @vepbtitle,
            @vepgident,
            @vepgtitle
            );
            END
            SET @month = @month +1;
            SET @count = 0;
            SET @avg   = 0;
            SET @quant = 0;
            END
            SET @year = @year + 1;
            SET @month = 1;
            END
            FETCH NEXT FROM vehCursor INTO @veident, @veplate, @veintno, @vestoc, @vecc, @vepbident, @vepbtitle, @vepgident, @vepgtitle;
            END

            CLOSE vehCursor;

            DEALLOCATE vehCursor;

            SELECT * FROM VehProdSums;


            DROP TABLE [dbo].[VehProdSums];

            END

          