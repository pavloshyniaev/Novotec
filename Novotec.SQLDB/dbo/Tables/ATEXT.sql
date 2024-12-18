﻿CREATE TABLE [dbo].[ATEXT] (
    [ATIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [ATDATE]    DATETIME      CONSTRAINT [DF_ATEXT_ATDATE] DEFAULT (getdate()) NULL,
    [ATWHO]     BIGINT        CONSTRAINT [DF_ATEXT_ATWHO] DEFAULT ((0)) NOT NULL,
    [ATAUIDENT] BIGINT        CONSTRAINT [DF_ATEXT_ATAUIDENT] DEFAULT ((0)) NOT NULL,
    [ATLINENO]  TINYINT       CONSTRAINT [DF_ATEXT_ATLINENO] DEFAULT ((0)) NOT NULL,
    [ATLINE]    VARCHAR (100) CONSTRAINT [DF_ATEXT_ATLINE] DEFAULT ('') NOT NULL,
    [ATBOLD]    TINYINT       CONSTRAINT [DF_ATEXT_ATBOLD] DEFAULT ((0)) NOT NULL,
    [ATTYPE]    TINYINT       CONSTRAINT [DF_ATEXT_ATTYPE] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ATEXT] PRIMARY KEY CLUSTERED ([ATIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ATEXT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ATEXT';

