CREATE QUEUE [dbo].[SqlQueryNotificationService-1c4fd12a-1b65-4188-8d44-dd71ce954bd7]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-1c4fd12a-1b65-4188-8d44-dd71ce954bd7], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

