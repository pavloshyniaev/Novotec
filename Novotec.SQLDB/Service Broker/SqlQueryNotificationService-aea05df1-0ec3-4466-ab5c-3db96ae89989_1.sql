CREATE SERVICE [SqlQueryNotificationService-aea05df1-0ec3-4466-ab5c-3db96ae89989]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-aea05df1-0ec3-4466-ab5c-3db96ae89989]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

