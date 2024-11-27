CREATE SERVICE [SqlQueryNotificationService-756988ca-4ef8-4022-b1d3-d641389015e0]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-756988ca-4ef8-4022-b1d3-d641389015e0]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

