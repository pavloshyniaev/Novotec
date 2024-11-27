CREATE QUEUE [dbo].[SqlQueryNotificationService-7b95a1d9-cea1-407e-a63b-8457e757797d]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-7b95a1d9-cea1-407e-a63b-8457e757797d], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

