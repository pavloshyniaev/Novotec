CREATE QUEUE [dbo].[SqlQueryNotificationService-7abf4c80-8f7d-4a41-9f85-099192e26b0c]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-7abf4c80-8f7d-4a41-9f85-099192e26b0c], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

