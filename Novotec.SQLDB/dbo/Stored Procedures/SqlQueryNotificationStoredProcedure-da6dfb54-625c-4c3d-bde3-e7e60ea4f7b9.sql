﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN DROP SERVICE [SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]; DROP QUEUE [SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]; END COMMIT TRANSACTION; END