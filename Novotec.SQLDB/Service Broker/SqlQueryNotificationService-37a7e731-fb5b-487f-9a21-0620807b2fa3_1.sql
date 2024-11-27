CREATE SERVICE [SqlQueryNotificationService-37a7e731-fb5b-487f-9a21-0620807b2fa3]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-37a7e731-fb5b-487f-9a21-0620807b2fa3]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

