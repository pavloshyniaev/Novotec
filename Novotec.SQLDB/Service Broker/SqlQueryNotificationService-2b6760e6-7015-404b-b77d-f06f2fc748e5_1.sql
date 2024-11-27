CREATE SERVICE [SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-2b6760e6-7015-404b-b77d-f06f2fc748e5]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

