﻿CREATE TABLE [dbo].[SVACCINP] (
    [SIIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [SIIPIDENT] BIGINT CONSTRAINT [DF_SVACCINP_SIIPIDENT] DEFAULT ((0)) NOT NULL,
    [SIAUIDENT] BIGINT CONSTRAINT [DF_SVACCINP_SIAUIDENT] DEFAULT ((0)) NOT NULL,
    [SIACCOUNT] INT    CONSTRAINT [DF_SVACCINP_SIACCOUNT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_SVACCINP] PRIMARY KEY CLUSTERED ([SIIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SVACCINP';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SVACCINP';
