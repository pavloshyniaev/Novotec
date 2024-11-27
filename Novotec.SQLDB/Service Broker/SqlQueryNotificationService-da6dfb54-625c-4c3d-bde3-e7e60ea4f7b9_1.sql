CREATE SERVICE [SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-da6dfb54-625c-4c3d-bde3-e7e60ea4f7b9]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

