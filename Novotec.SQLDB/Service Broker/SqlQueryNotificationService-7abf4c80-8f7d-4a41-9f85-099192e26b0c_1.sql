CREATE SERVICE [SqlQueryNotificationService-7abf4c80-8f7d-4a41-9f85-099192e26b0c]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-7abf4c80-8f7d-4a41-9f85-099192e26b0c]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

