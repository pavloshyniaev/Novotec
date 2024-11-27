CREATE QUEUE [dbo].[SqlQueryNotificationService-cdafefec-4243-45a4-805f-4b80bf0570ab]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-cdafefec-4243-45a4-805f-4b80bf0570ab], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

