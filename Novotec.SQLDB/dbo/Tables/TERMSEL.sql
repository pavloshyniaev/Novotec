CREATE TABLE [dbo].[TERMSEL] (
    [TEIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [TEUSIDENT] BIGINT NOT NULL,
    [TEAUIDENT] BIGINT NOT NULL,
    CONSTRAINT [PK_TERMSEL] PRIMARY KEY CLUSTERED ([TEIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TERMSEL';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TERMSEL';

