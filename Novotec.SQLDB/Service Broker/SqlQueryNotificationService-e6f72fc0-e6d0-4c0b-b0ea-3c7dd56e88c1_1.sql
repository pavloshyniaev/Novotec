CREATE SERVICE [SqlQueryNotificationService-e6f72fc0-e6d0-4c0b-b0ea-3c7dd56e88c1]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-e6f72fc0-e6d0-4c0b-b0ea-3c7dd56e88c1]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

