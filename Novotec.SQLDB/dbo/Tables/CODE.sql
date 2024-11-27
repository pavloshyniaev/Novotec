CREATE TABLE [dbo].[CODE] (
    [CDIDENT]   BIGINT   IDENTITY (1, 1) NOT NULL,
    [CDDATE]    DATETIME CONSTRAINT [DF_CODE_CDDATE] DEFAULT (getdate()) NOT NULL,
    [CDAUIDENT] BIGINT   CONSTRAINT [DF_CODE_CDAUIDENT] DEFAULT ((0)) NOT NULL,
    [CDCANO]    BIGINT   CONSTRAINT [DF_CODE_CDCANO] DEFAULT ((0)) NOT NULL,
    [CDCODE]    INT      CONSTRAINT [DF_CODE_CDCODE] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_CODE] PRIMARY KEY CLUSTERED ([CDIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CODE';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CODE';

