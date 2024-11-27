CREATE TABLE [dbo].[LEVELDATA] (
    [LDIDENT]   BIGINT   IDENTITY (1, 1) NOT NULL,
    [LDDATE]    DATETIME CONSTRAINT [DF_LEVELDATA_LDDATE] DEFAULT (getdate()) NULL,
    [LDDATE2]   DATETIME CONSTRAINT [DF_LEVELDATA_LDDATE2] DEFAULT (getdate()) NULL,
    [LDPROBE]   INT      NOT NULL,
    [LDAUIDENT] BIGINT   NOT NULL,
    [LDTEMP]    INT      NOT NULL,
    [LDPLEVEL]  INT      NOT NULL,
    [LDWLEVEL]  INT      NOT NULL,
    [LDDENSITY] INT      NOT NULL,
    CONSTRAINT [PK_LEVELDATA] PRIMARY KEY CLUSTERED ([LDIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LEVELDATA';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LEVELDATA';

