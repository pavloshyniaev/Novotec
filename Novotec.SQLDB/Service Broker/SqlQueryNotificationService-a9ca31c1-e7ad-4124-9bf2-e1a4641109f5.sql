CREATE QUEUE [dbo].[SqlQueryNotificationService-a9ca31c1-e7ad-4124-9bf2-e1a4641109f5]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-a9ca31c1-e7ad-4124-9bf2-e1a4641109f5], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

