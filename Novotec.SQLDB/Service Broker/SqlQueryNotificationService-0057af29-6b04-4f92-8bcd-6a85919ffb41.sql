CREATE QUEUE [dbo].[SqlQueryNotificationService-0057af29-6b04-4f92-8bcd-6a85919ffb41]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-0057af29-6b04-4f92-8bcd-6a85919ffb41], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

