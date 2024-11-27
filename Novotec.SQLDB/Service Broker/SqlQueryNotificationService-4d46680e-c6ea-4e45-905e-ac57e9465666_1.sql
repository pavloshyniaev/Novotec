CREATE SERVICE [SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-4d46680e-c6ea-4e45-905e-ac57e9465666]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

