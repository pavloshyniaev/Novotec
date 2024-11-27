CREATE SERVICE [SqlQueryNotificationService-d0bc5c83-078c-4fda-95ce-43d5ef393651]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-d0bc5c83-078c-4fda-95ce-43d5ef393651]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

