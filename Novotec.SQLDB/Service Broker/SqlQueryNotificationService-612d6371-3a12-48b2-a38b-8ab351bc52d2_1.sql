CREATE SERVICE [SqlQueryNotificationService-612d6371-3a12-48b2-a38b-8ab351bc52d2]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-612d6371-3a12-48b2-a38b-8ab351bc52d2]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

