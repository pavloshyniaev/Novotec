CREATE QUEUE [dbo].[SqlQueryNotificationService-58777832-6636-43ef-bff4-7e99b3cbff88]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-58777832-6636-43ef-bff4-7e99b3cbff88], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

