CREATE TABLE [dbo].[TSTATUS] (
    [TSIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [TSWHO]   BIGINT        CONSTRAINT [DF_TSTATUS_TSWHO] DEFAULT ((0)) NOT NULL,
    [TSDATE]  DATETIME      CONSTRAINT [DF_TSTATUS_TSDATE] DEFAULT (getdate()) NULL,
    [TSID]    INT           NOT NULL,
    [TSCOLOR] VARCHAR (30)  NOT NULL,
    [TSTEXT]  VARCHAR (100) NOT NULL,
    [TSMEMO]  VARCHAR (MAX) NOT NULL,
    [TSTYPE]  VARCHAR (30)  NOT NULL,
    CONSTRAINT [PK_TSTATUS] PRIMARY KEY CLUSTERED ([TSIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSTATUS';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TSTATUS';

