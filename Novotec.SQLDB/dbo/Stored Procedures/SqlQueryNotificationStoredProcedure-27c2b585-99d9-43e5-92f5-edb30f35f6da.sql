﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-27c2b585-99d9-43e5-92f5-edb30f35f6da] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN DROP SERVICE [SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da]; DROP QUEUE [SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-27c2b585-99d9-43e5-92f5-edb30f35f6da]; END COMMIT TRANSACTION; END