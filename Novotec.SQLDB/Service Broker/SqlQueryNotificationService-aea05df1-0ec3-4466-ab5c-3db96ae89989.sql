CREATE QUEUE [dbo].[SqlQueryNotificationService-aea05df1-0ec3-4466-ab5c-3db96ae89989]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-aea05df1-0ec3-4466-ab5c-3db96ae89989], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

