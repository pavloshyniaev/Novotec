CREATE QUEUE [dbo].[SqlQueryNotificationService-37a7e731-fb5b-487f-9a21-0620807b2fa3]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-37a7e731-fb5b-487f-9a21-0620807b2fa3], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

