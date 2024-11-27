CREATE QUEUE [dbo].[SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

