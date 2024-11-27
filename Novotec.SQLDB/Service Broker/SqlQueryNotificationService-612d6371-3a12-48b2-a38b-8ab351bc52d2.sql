CREATE QUEUE [dbo].[SqlQueryNotificationService-612d6371-3a12-48b2-a38b-8ab351bc52d2]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-612d6371-3a12-48b2-a38b-8ab351bc52d2], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

