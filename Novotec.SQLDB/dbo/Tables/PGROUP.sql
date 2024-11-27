﻿CREATE TABLE [dbo].[PGROUP] (
    [PGIDENT]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [PGDATE]   DATETIME       CONSTRAINT [DF_PGROUP_PGDATE] DEFAULT (getdate()) NULL,
    [PGWHO]    BIGINT         CONSTRAINT [DF_PGROUP_PGWHO] DEFAULT ((0)) NOT NULL,
    [PGTITLE]  VARCHAR (50)   CONSTRAINT [DF_PGROUP_PGTITLE] DEFAULT ('') NOT NULL,
    [PGNUMBER] VARCHAR (20)   CONSTRAINT [DF_PGROUP_PGNUMBER] DEFAULT ('') NOT NULL,
    [PGMEMO]   VARCHAR (MAX)  CONSTRAINT [DF_PGROUP_PGMEMO] DEFAULT ('') NOT NULL,
    [PGFLTYPE] INT            CONSTRAINT [DF_PGROUP_PGFLTYPE] DEFAULT ((0)) NOT NULL,
    [PGCO2]    DECIMAL (5, 3) CONSTRAINT [DF_PGROUP_PGCO2] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_PGROUP] PRIMARY KEY CLUSTERED ([PGIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PGROUP';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PGROUP';

