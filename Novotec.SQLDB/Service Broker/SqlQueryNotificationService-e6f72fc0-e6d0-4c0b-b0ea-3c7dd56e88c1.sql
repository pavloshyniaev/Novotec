CREATE QUEUE [dbo].[SqlQueryNotificationService-e6f72fc0-e6d0-4c0b-b0ea-3c7dd56e88c1]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-e6f72fc0-e6d0-4c0b-b0ea-3c7dd56e88c1], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

