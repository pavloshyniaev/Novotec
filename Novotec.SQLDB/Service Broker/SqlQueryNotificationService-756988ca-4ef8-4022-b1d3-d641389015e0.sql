﻿CREATE QUEUE [dbo].[SqlQueryNotificationService-756988ca-4ef8-4022-b1d3-d641389015e0]
    WITH ACTIVATION (STATUS = ON, PROCEDURE_NAME = [dbo].[SqlQueryNotificationStoredProcedure-756988ca-4ef8-4022-b1d3-d641389015e0], MAX_QUEUE_READERS = 1, EXECUTE AS OWNER);

