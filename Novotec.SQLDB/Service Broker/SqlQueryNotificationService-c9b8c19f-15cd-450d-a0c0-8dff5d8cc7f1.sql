CREATE QUEUE [dbo].[SqlQueryNotificationService-c9b8c19f-15cd-450d-a0c0-8dff5d8cc7f1]
    WITH POISON_MESSAGE_HANDLING(STATUS = OFF), ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-c9b8c19f-15cd-450d-a0c0-8dff5d8cc7f1], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

