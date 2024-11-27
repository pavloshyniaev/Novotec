CREATE SERVICE [SqlQueryNotificationService-e70c8b77-3bbd-4bc1-b399-25d1a17ee60b]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-e70c8b77-3bbd-4bc1-b399-25d1a17ee60b]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

