CREATE SERVICE [SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-27c2b585-99d9-43e5-92f5-edb30f35f6da]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

