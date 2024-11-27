CREATE SERVICE [SqlQueryNotificationService-a9ca31c1-e7ad-4124-9bf2-e1a4641109f5]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-a9ca31c1-e7ad-4124-9bf2-e1a4641109f5]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

