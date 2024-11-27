CREATE QUEUE [dbo].[SqlQueryNotificationService-649bec5f-71fb-420a-80fd-815f1922ad7a]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-649bec5f-71fb-420a-80fd-815f1922ad7a], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

