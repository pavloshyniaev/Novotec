CREATE SERVICE [SqlQueryNotificationService-58777832-6636-43ef-bff4-7e99b3cbff88]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-58777832-6636-43ef-bff4-7e99b3cbff88]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

