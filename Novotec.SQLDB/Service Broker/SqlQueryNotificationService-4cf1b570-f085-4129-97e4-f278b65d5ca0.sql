CREATE QUEUE [dbo].[SqlQueryNotificationService-4cf1b570-f085-4129-97e4-f278b65d5ca0]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-4cf1b570-f085-4129-97e4-f278b65d5ca0], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

