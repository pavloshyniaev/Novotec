CREATE SERVICE [SqlQueryNotificationService-cdafefec-4243-45a4-805f-4b80bf0570ab]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-cdafefec-4243-45a4-805f-4b80bf0570ab]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

