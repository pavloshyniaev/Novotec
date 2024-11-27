CREATE QUEUE [dbo].[SqlQueryNotificationService-7ab6ce14-1f24-48b3-b8d2-7fffaa700bd5]
    WITH POISON_MESSAGE_HANDLING(STATUS = OFF), ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-7ab6ce14-1f24-48b3-b8d2-7fffaa700bd5], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

