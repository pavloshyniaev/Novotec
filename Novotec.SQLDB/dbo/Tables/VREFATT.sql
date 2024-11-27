CREATE TABLE [dbo].[VREFATT] (
    [VRIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [VRVCIDENT] BIGINT CONSTRAINT [DF_VREFATT_VRVCIDENT] DEFAULT ((0)) NOT NULL,
    [VRVEIDENT] BIGINT CONSTRAINT [DF_VREFATT_VRVEIDENT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_VREFATT] PRIMARY KEY CLUSTERED ([VRIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'VREFATT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'VREFATT';

