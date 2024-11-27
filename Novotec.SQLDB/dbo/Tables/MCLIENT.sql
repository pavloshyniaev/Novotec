CREATE TABLE [dbo].[MCLIENT] (
    [MCIDENT] SMALLINT      IDENTITY (1, 1) NOT NULL,
    [MCDATE]  DATETIME      NULL,
    [MCTITLE] VARCHAR (30)  CONSTRAINT [DF_MCLIENT_MCTITLE] DEFAULT ('') NOT NULL,
    [MCMEMO]  VARCHAR (MAX) CONSTRAINT [DF_MCLIENT_MCMEMO] DEFAULT ('') NOT NULL,
    [MCNUM]   INT           CONSTRAINT [DF_MCLIENT_MCNUM] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_MCLIENT] PRIMARY KEY CLUSTERED ([MCIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MCLIENT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'MCLIENT';

