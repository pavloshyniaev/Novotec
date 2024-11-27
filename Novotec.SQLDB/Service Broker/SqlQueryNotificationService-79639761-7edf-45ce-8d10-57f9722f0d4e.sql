CREATE QUEUE [dbo].[SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-79639761-7edf-45ce-8d10-57f9722f0d4e], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

