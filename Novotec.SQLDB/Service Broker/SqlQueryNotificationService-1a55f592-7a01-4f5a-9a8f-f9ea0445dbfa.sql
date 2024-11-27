CREATE QUEUE [dbo].[SqlQueryNotificationService-1a55f592-7a01-4f5a-9a8f-f9ea0445dbfa]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-1a55f592-7a01-4f5a-9a8f-f9ea0445dbfa], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

