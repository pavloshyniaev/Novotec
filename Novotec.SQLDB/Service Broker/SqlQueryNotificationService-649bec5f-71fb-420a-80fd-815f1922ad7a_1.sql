CREATE SERVICE [SqlQueryNotificationService-649bec5f-71fb-420a-80fd-815f1922ad7a]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-649bec5f-71fb-420a-80fd-815f1922ad7a]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

