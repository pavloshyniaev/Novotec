﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-79639761-7edf-45ce-8d10-57f9722f0d4e] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e') > 0)   DROP SERVICE [SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e]; if (OBJECT_ID('SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-79639761-7edf-45ce-8d10-57f9722f0d4e]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-79639761-7edf-45ce-8d10-57f9722f0d4e]; END COMMIT TRANSACTION; END