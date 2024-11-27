CREATE QUEUE [dbo].[SqlQueryNotificationService-d0bc5c83-078c-4fda-95ce-43d5ef393651]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-d0bc5c83-078c-4fda-95ce-43d5ef393651], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

