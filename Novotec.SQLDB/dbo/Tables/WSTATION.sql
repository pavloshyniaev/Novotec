CREATE TABLE [dbo].[WSTATION] (
    [WSIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [WSDATE]  DATETIME     CONSTRAINT [DF_WSTATION_WSDATE] DEFAULT (getdate()) NOT NULL,
    [WSWS]    VARCHAR (50) CONSTRAINT [DF_WSTATION_WSWS] DEFAULT ('') NOT NULL,
    [WSWHO]   BIGINT       CONSTRAINT [DF_WSTATION_WSWHO] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_WSTATION] PRIMARY KEY CLUSTERED ([WSIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WSTATION';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'WSTATION';

