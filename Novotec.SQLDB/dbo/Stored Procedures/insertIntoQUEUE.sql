
      -- =============================================
      -- Author:		  Ralf Buddenhagen
      -- Create date: 12.10.2012
      -- Description:	inserts order into queue table
      -- Changed:     06.08.2014: QEDATA -> MAX (prev. 200)
      -- =============================================
      CREATE PROCEDURE [dbo].[insertIntoQUEUE]
      @QEAUIDENT bigint,
      @QEORIDENT bigint,
      @QERQNO    bigint,
      @QEDATA    varchar (MAX),
      @QESTATE   int
      AS
      BEGIN
      SET NOCOUNT ON;

      -- qedate is set  to the actual date/time by default
      -- qecnt is set to zero by default
      -- qeblockno is set to -1 by default
      
      INSERT INTO queues (QEAUIDENT, QEORIDENT, QERQNO, QEDATA, QESTATE)
      VALUES
      (@QEAUIDENT, @QEORIDENT, @QERQNO, @QEDATA, @QESTATE)
      
      END
    