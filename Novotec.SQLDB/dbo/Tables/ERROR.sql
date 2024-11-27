CREATE TABLE [dbo].[ERROR] (
    [ERIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [ERWHO]     BIGINT        CONSTRAINT [DF_ERROR_ERWHO] DEFAULT ((0)) NOT NULL,
    [ERDATE]    DATETIME      NULL,
    [ERTYPE]    INT           CONSTRAINT [DF_ERROR_ERTYPE] DEFAULT ((0)) NOT NULL,
    [ERNUM]     INT           CONSTRAINT [DF_ERROR_ERNUM] DEFAULT ((0)) NOT NULL,
    [ERAUIDENT] BIGINT        CONSTRAINT [DF_ERROR_ERAUIDENT] DEFAULT ((0)) NOT NULL,
    [ERAIIDENT] BIGINT        CONSTRAINT [DF_ERROR_ERAIIDENT] DEFAULT ((0)) NOT NULL,
    [ERMEMO]    VARCHAR (MAX) CONSTRAINT [DF_ERROR_ERMEMO] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_ERROR] PRIMARY KEY CLUSTERED ([ERIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ERROR';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ERROR';

