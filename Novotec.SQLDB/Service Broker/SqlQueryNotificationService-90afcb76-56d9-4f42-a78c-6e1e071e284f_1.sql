CREATE SERVICE [SqlQueryNotificationService-90afcb76-56d9-4f42-a78c-6e1e071e284f]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-90afcb76-56d9-4f42-a78c-6e1e071e284f]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

