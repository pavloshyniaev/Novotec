CREATE SERVICE [SqlQueryNotificationService-1a55f592-7a01-4f5a-9a8f-f9ea0445dbfa]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-1a55f592-7a01-4f5a-9a8f-f9ea0445dbfa]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

