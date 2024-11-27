CREATE TABLE [dbo].[FCUNO] (
    [FCIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FCWHO]   BIGINT       CONSTRAINT [DF_FCUNO_FCWHO] DEFAULT ((0)) NOT NULL,
    [FCDATE]  DATETIME     CONSTRAINT [DF_FCUNO_FCDATE] DEFAULT (getdate()) NOT NULL,
    [FCTYPE]  INT          CONSTRAINT [DF_FCUNO_FCTYPE] DEFAULT ((0)) NOT NULL,
    [FCNO]    VARCHAR (30) CONSTRAINT [DF_FCUNO_FCNO] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_FCUNO] PRIMARY KEY CLUSTERED ([FCIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FCUNO';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FCUNO';

