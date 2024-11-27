CREATE SERVICE [SqlQueryNotificationService-8b8402af-fbc5-485b-b7d5-e55bb9a2d86b]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-8b8402af-fbc5-485b-b7d5-e55bb9a2d86b]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

