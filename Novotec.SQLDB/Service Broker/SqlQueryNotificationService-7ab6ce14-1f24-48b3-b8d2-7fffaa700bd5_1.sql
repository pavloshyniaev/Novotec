CREATE SERVICE [SqlQueryNotificationService-7ab6ce14-1f24-48b3-b8d2-7fffaa700bd5]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-7ab6ce14-1f24-48b3-b8d2-7fffaa700bd5]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

