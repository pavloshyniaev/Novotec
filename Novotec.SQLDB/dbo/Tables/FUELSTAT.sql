﻿CREATE TABLE [dbo].[FUELSTAT] (
    [FUIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [FUDATE]    DATETIME      CONSTRAINT [DF_FUELSTAT_FUDATE] DEFAULT (getdate()) NULL,
    [FUWHO]     BIGINT        CONSTRAINT [DF_FUELSTAT_FUWHO] DEFAULT ((0)) NOT NULL,
    [FUTITLE]   VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUTITLE] DEFAULT ('') NOT NULL,
    [FUTITLE2]  VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUTITLE2] DEFAULT ('') NOT NULL,
    [FUTITLE3]  VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUTITLE3] DEFAULT ('') NOT NULL,
    [FUTYPE]    TINYINT       CONSTRAINT [DF_FUELSTAT_FUTYPE] DEFAULT ((0)) NOT NULL,
    [FUNUMBER]  VARCHAR (20)  CONSTRAINT [DF_FUELSTAT_FUNUMBER] DEFAULT ('') NOT NULL,
    [FUADIDENT] BIGINT        CONSTRAINT [DF_FUELSTAT_FUADIDENT] DEFAULT ((0)) NOT NULL,
    [FUMEMO]    VARCHAR (MAX) CONSTRAINT [DF_FUELSTAT_FUMEMO] DEFAULT ('') NOT NULL,
    [FUINTNO]   VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUINTNO] DEFAULT ('') NOT NULL,
    [FUINTNO2]  VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUINTNO2] DEFAULT ('') NOT NULL,
    [FUINTNO3]  VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUINTNO3] DEFAULT ('') NOT NULL,
    [FUINTNO4]  VARCHAR (50)  CONSTRAINT [DF_FUELSTAT_FUINTNO4] DEFAULT ('') NOT NULL,
    [FUSRIDENT] BIGINT        CONSTRAINT [DF_FUELSTAT_FUSRIDENT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_FUELSTAT] PRIMARY KEY CLUSTERED ([FUIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FUELSTAT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FUELSTAT';

