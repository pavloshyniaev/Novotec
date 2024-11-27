CREATE SERVICE [SqlQueryNotificationService-64fb0c7b-bc04-471f-b540-44d63f33694a]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-64fb0c7b-bc04-471f-b540-44d63f33694a]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

