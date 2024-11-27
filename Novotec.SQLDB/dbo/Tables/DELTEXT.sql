CREATE TABLE [dbo].[DELTEXT] (
    [DTIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [DTDATE]  DATETIME      CONSTRAINT [DF_DELTEXT_DTDATE] DEFAULT (getdate()) NULL,
    [DTWHO]   BIGINT        CONSTRAINT [DF_DELTEXT_DTWHO] DEFAULT ((0)) NOT NULL,
    [DTTYPE]  INT           CONSTRAINT [DF_DELTEXT_DTTYPE] DEFAULT ((0)) NOT NULL,
    [DTTEXT]  VARCHAR (150) CONSTRAINT [DF_DELTEXT_DTTEXT] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_DELTEXT] PRIMARY KEY CLUSTERED ([DTIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'DELTEXT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'DELTEXT';

