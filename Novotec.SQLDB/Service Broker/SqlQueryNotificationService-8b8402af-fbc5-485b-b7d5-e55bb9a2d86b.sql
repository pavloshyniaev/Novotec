CREATE QUEUE [dbo].[SqlQueryNotificationService-8b8402af-fbc5-485b-b7d5-e55bb9a2d86b]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-8b8402af-fbc5-485b-b7d5-e55bb9a2d86b], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

