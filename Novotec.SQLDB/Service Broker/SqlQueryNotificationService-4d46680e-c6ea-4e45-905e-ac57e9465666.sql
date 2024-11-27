CREATE QUEUE [dbo].[SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-4d46680e-c6ea-4e45-905e-ac57e9465666], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

