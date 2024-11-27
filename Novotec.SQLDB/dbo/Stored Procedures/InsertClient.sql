
-- =============================================
-- Author:		Ralf Buddenhagen
-- Create date: 14.05.2008
-- Description:	Inserts a new customer account 
-- =============================================
CREATE PROCEDURE [dbo].[InsertClient]
	@MCTITLE varchar(30)
,	@MCMEMO varchar(MAX)
,	@MCNUM int
,	@USWHO bigint
,   @MCIDENT bigint OUTPUT
AS

DECLARE @Mandant AS bigint

SET NOCOUNT ON

BEGIN TRANSACTION insertData

SET @MCIDENT=-1

-- =============================================
-- create a new customer
-- =============================================
INSERT INTO dbo.MCLIENT (
	MCTITLE
,	MCDATE
,	MCMEMO
,	MCNUM

)
VALUES (
	@MCTITLE
,	getDate()
,	@MCMEMO
,   @MCNUM
)

IF @@ERROR != 0
BEGIN
	ROLLBACK TRANSACTION insertData
	SELECT USIDENT = 0
END
-- =============================================
-- create a local admin account
-- =============================================
ELSE
	BEGIN
	SET @Mandant=@@IDENTITY
	SET @MCIDENT=@@IDENTITY
	INSERT INTO dbo.USLOG (
		USWHO
	,	USMCIDENT
	,	USBRIDENT
	,	USPW
	,	USNAME
	,	USADMIN
	,	USVALDATE
	,	USSKIN
	,	USLANG
	,	USLAYOUT
	,	USBKCOLOR
	,	USOVCOLOR
	,	USOVSEPS
	,   USSTART
	,   USCTRL1
	,   USCTRL2
	,   USREFRESH
	)
	VALUES (
		@USWHO
	,	@@IDENTITY
	,	0
	,	CAST(@MCNUM AS varchar)
	,	@MCTITLE
	,	'2'
	,	(CONVERT([datetime],'9999-31-12 23:59:59',0))
	,	0
	,	0
	,	0
	,	0
	,	0
	,	0
	,   0
	,   1
	,   0
	,   0
	)

	IF @@ERROR != 0
	    BEGIN
			ROLLBACK TRANSACTION insertData
			SELECT USIDENT = 0
		END		
-- =============================================
-- create a system admin account for that client
-- =============================================
	ELSE
		BEGIN

			INSERT INTO dbo.USLOG (
				USWHO
			,	USMCIDENT
			,	USBRIDENT
			,	USPW
			,	USNAME
			,	USADMIN
			,	USVALDATE
			,	USSKIN
			,	USLANG
			,	USLAYOUT
			,	USBKCOLOR
			,	USOVCOLOR
			,	USOVSEPS
			,   USSTART
			,   USCTRL1
			,   USCTRL2
			,   USREFRESH
			)
			VALUES (
				@USWHO
			,	@MCIDENT
			,	0
			,	'##15089_7##'
			,	CAST(@MCNUM AS varchar)
			,	'1'
			,	(CONVERT([datetime],'9999-31-12 23:59:59',0))
			,	0
			,	0
			,	0
			,	0
			,	0
			,	0
			,   0
			,   1
			,   0
			,   0
			)

			IF @@ERROR != 0
				BEGIN
					ROLLBACK TRANSACTION insertData
					SELECT USIDENT = 0
				END		
			ELSE
				BEGIN
					COMMIT  TRANSACTION insertData
					SELECT USIDENT = @@IDENTITY
				END
		END
	END	
    