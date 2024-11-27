CREATE SERVICE [SqlQueryNotificationService-c9b8c19f-15cd-450d-a0c0-8dff5d8cc7f1]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-c9b8c19f-15cd-450d-a0c0-8dff5d8cc7f1]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

