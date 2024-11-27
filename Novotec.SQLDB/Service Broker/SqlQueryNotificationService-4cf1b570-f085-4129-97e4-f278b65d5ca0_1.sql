CREATE SERVICE [SqlQueryNotificationService-4cf1b570-f085-4129-97e4-f278b65d5ca0]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-4cf1b570-f085-4129-97e4-f278b65d5ca0]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

