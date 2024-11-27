CREATE TABLE [dbo].[STOSEL] (
    [SOIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [SOUSIDENT] BIGINT NOT NULL,
    [SOSTIDENT] BIGINT NOT NULL,
    [SOPOS]     INT    NOT NULL,
    [SOACTIVE]  INT    NOT NULL,
    CONSTRAINT [PK_STOSEL] PRIMARY KEY CLUSTERED ([SOIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STOSEL';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STOSEL';

