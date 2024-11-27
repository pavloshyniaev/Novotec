CREATE QUEUE [dbo].[SqlQueryNotificationService-67bbf5e5-d0a8-4433-aed9-be8f28bb899e]
    WITH POISON_MESSAGE_HANDLING(STATUS = OFF), ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-67bbf5e5-d0a8-4433-aed9-be8f28bb899e], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

