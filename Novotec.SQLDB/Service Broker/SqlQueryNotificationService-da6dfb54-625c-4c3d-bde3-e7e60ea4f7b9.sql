CREATE QUEUE [dbo].[SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]
    WITH POISON_MESSAGE_HANDLING(STATUS = OFF), ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

