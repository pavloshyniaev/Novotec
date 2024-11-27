CREATE TABLE [dbo].[ENFUEL] (
    [EFIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [EFDATE]    DATETIME      CONSTRAINT [DF_ENFUEL_EFDATE] DEFAULT (getdate()) NOT NULL,
    [EFAUIDENT] BIGINT        CONSTRAINT [DF_ENFUEL_EFAUIDENT] DEFAULT ((0)) NOT NULL,
    [EFLINENO]  INT           CONSTRAINT [DF_ENFUEL_EFLINENO] DEFAULT ((0)) NOT NULL,
    [EFLINE]    VARCHAR (MAX) CONSTRAINT [DF_ENFUEL_EFLINE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_ENFUEL] PRIMARY KEY CLUSTERED ([EFIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ENFUEL';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ENFUEL';

