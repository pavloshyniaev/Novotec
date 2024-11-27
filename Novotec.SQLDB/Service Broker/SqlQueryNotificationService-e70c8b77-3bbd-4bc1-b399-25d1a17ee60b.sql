CREATE QUEUE [dbo].[SqlQueryNotificationService-e70c8b77-3bbd-4bc1-b399-25d1a17ee60b]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-e70c8b77-3bbd-4bc1-b399-25d1a17ee60b], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

