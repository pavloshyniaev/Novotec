CREATE SERVICE [SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b]
    AUTHORIZATION [dbo]
    ON QUEUE [dbo].[SqlQueryNotificationService-02f1d68e-64ca-4d75-8514-d49125eeef1b]
    ([http://schemas.microsoft.com/SQL/Notifications/PostQueryNotification]);

