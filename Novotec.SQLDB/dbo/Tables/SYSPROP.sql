CREATE TABLE [dbo].[SYSPROP] (
    [SOIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [SODATE]  DATETIME      CONSTRAINT [DF_SYSPROP_SODATE] DEFAULT (getdate()) NOT NULL,
    [SOWHO]   BIGINT        CONSTRAINT [DF_SYSPROP_SOWHO] DEFAULT ((0)) NOT NULL,
    [SOTITLE] VARCHAR (20)  CONSTRAINT [DF_SYSPROP_SOTITLE] DEFAULT ('') NOT NULL,
    [SOVAL]   VARCHAR (100) CONSTRAINT [DF_SYSPROP_SOVAL] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_SYSPROP] PRIMARY KEY CLUSTERED ([SOIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYSPROP';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SYSPROP';

