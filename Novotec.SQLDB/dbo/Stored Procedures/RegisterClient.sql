
-- =============================================
-- Author:		Ralf Buddenhagen
-- Create date: 14.11.2008
-- Description:	login 
-- =============================================
CREATE PROCEDURE  [dbo].[RegisterClient]
	@WSWS varchar(50)
,   @WSIDENT bigint OUTPUT
AS
BEGIN
--	SET NOCOUNT ON;

	DECLARE @ident bigint;
	SET @ident = -1;
	SET @WSIDENT=-1;

-- =============================================
-- free all unused records first
-- =============================================
	UPDATE [dbo].[WSTATION]  SET WSWS ='' where (DATEDIFF(day, WSDATE, GetDate()) != 0 or  DATEDIFF(month, WSDATE, GetDate()) != 0 or 
												DATEDIFF(year,WSDATE, GetDate()) != 0 or  DateDiff(hour,  WSDATE, GetDate()) != 0 or
												DATEDIFF(minute,WSDATE, GetDate()) > 2);
  
-- =============================================
-- try to select a free record
-- =============================================
	SELECT top(1) @WSIDENT=WSIDENT FROM [dbo].[WSTATION] WHERE (LEN(RTRIM(WSWS))= 0 or WSWS=@WSWS);

-- =============================================
-- register working station
-- =============================================
	IF @@ERROR = 0
	BEGIN
		SET @ident= @WSIDENT;
		IF (@ident > 0)
		BEGIN
			UPDATE [dbo].[WSTATION]  SET WSWS =@WSWS, WSDATE=GetDate() where WSIDENT=@ident;
			IF @@ERROR = 0
			BEGIN
				SET @WSIDENT=@ident;
			END	
		END
	END
END
    