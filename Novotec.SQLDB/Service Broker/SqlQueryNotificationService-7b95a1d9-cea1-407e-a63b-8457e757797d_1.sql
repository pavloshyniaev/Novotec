CREATE SERVICE [SqlQueryNotificationService-7b95a1d9-cea1-407e-a63b-8457e757797d]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-7b95a1d9-cea1-407e-a63b-8457e757797d]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

