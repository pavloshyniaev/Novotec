﻿CREATE PROCEDURE [SqlQueryNotificationStoredProcedure-2b6760e6-7015-404b-b77d-f06f2fc748e5] AS BEGIN BEGIN TRANSACTION; RECEIVE TOP(0) conversation_handle FROM [SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5]; IF (SELECT COUNT(*) FROM [SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5] WHERE message_type_name = 'http://schemas.microsoft.com/SQL/ServiceBroker/DialogTimer') > 0 BEGIN DROP SERVICE [SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5]; DROP QUEUE [SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5]; DROP PROCEDURE [SqlQueryNotificationStoredProcedure-2b6760e6-7015-404b-b77d-f06f2fc748e5]; END COMMIT TRANSACTION; END