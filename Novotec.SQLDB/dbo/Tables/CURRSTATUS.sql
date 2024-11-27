CREATE TABLE [dbo].[CURRSTATUS] (
    [CUIDENT]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [CUDATE]     DATETIME      CONSTRAINT [DF_CURRSTATUS_CUDATE] DEFAULT (getdate()) NOT NULL,
    [CUTYPE]     INT           NOT NULL,
    [CUPINFO]    VARCHAR (150) NOT NULL,
    [CUSTATION]  VARCHAR (150) NOT NULL,
    [CUPROGNO]   INT           NOT NULL,
    [CUMESSID]   INT           NOT NULL,
    [CUMESSAGE]  VARCHAR (MAX) NOT NULL,
    [CUMEMO]     VARCHAR (MAX) NOT NULL,
    [CUCRITICAL] INT           NOT NULL,
    CONSTRAINT [PK_CURRSTATUS] PRIMARY KEY CLUSTERED ([CUIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CURRSTATUS';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'CURRSTATUS';

