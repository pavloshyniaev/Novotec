﻿CREATE TABLE [dbo].[STRUCTURE] (
    [SRIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [SRDATE]    DATETIME      CONSTRAINT [DF_STRUCTURE_SRDATE] DEFAULT (getdate()) NULL,
    [SRWHO]     BIGINT        CONSTRAINT [DF_STRUCTURE_SRWHO] DEFAULT ((0)) NOT NULL,
    [SRNUMBER]  VARCHAR (20)  CONSTRAINT [DF_STRUCTURE_SRNUMBER] DEFAULT ('') NOT NULL,
    [SRTITLE]   VARCHAR (50)  CONSTRAINT [DF_STRUCTURE_SRTITLE] DEFAULT ('') NOT NULL,
    [SRMEMO]    VARCHAR (MAX) CONSTRAINT [DF_STRUCTURE_SRMEMO] DEFAULT ('') NOT NULL,
    [SRADIDENT] BIGINT        CONSTRAINT [DF_STRUCTURE_SRADIDENT] DEFAULT ((0)) NOT NULL,
    [SRSRIDENT] BIGINT        CONSTRAINT [DF_STRUCTURE_SRSRIDENT] DEFAULT ((0)) NOT NULL,
    [SRLEVEL]   INT           CONSTRAINT [DF_STRUCTURE_SRLEVEL] DEFAULT ((0)) NOT NULL,
    [SRIMAGE]   INT           CONSTRAINT [DF_STRUCTURE_SRIMAGE] DEFAULT ((0)) NOT NULL,
    [SRHLEVEL]  INT           CONSTRAINT [DF_STRUCTURE_SRHLEVEL] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_STRUCTURE] PRIMARY KEY CLUSTERED ([SRIDENT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [INDEX_STRUCTURE_SRLEVEL]
    ON [dbo].[STRUCTURE]([SRLEVEL] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STRUCTURE';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STRUCTURE';

