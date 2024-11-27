CREATE SERVICE [SqlQueryNotificationService-1c4fd12a-1b65-4188-8d44-dd71ce954bd7]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-1c4fd12a-1b65-4188-8d44-dd71ce954bd7]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

