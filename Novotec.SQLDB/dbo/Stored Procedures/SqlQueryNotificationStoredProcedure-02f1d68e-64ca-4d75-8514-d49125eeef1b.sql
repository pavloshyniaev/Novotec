﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-02f1d68e-64ca-4d75-8514-d49125eeef1b] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN DROP SERVICE [SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b]; DROP QUEUE [SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-02f1d68e-64ca-4d75-8514-d49125eeef1b]; END COMMIT TRANSACTION; END