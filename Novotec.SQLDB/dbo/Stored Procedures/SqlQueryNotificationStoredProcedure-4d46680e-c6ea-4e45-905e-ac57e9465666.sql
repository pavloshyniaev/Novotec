﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-4d46680e-c6ea-4e45-905e-ac57e9465666] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN DROP SERVICE [SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]; DROP QUEUE [SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-4d46680e-c6ea-4e45-905e-ac57e9465666]; END COMMIT TRANSACTION; END