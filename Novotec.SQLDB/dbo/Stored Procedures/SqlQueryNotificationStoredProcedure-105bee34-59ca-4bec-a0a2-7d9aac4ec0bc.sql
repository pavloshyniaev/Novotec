﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN if ((SELECT COUNT(*) FROM sys.services WHERE name = 'SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc') > 0)   DROP SERVICE [SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc]; if (OBJECT_ID('SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc', 'SQ') IS NOT NULL)   DROP QUEUE [SqlQueryNotificationService-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-105bee34-59ca-4bec-a0a2-7d9aac4ec0bc]; END COMMIT TRANSACTION; END