﻿CREATE TABLE [dbo].[STORAGE] (
    [STIDENT]      BIGINT          IDENTITY (1, 1) NOT NULL,
    [STDATE]       DATETIME        CONSTRAINT [DF_STORAGE_STDATE] DEFAULT (getdate()) NULL,
    [STWHO]        BIGINT          CONSTRAINT [DF_STORAGE_STWHO] DEFAULT ((0)) NOT NULL,
    [STTITLE]      VARCHAR (50)    CONSTRAINT [DF_STORAGE_STTITLE] DEFAULT ('') NOT NULL,
    [STNUMBER]     VARCHAR (20)    CONSTRAINT [DF_STORAGE_STNUMBER] DEFAULT ('') NOT NULL,
    [STMEMO]       VARCHAR (MAX)   CONSTRAINT [DF_STORAGE_STMEMO] DEFAULT ('') NOT NULL,
    [STPBIDENT]    BIGINT          CONSTRAINT [DF_STORAGE_STPBIDENT] DEFAULT ((0)) NOT NULL,
    [STMIN]        DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STMIN] DEFAULT ((0)) NOT NULL,
    [STMAX]        DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STMAX] DEFAULT ((0)) NOT NULL,
    [STORDER]      DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STORDER] DEFAULT ((0)) NOT NULL,
    [STUNIT]       DECIMAL (10, 2) CONSTRAINT [DF_STORAGE_STUNIT] DEFAULT ((0)) NOT NULL,
    [STMINORDER]   DECIMAL (10, 2) CONSTRAINT [DF_STORAGE_STMINORDER] DEFAULT ((0)) NOT NULL,
    [STORDERED]    TINYINT         CONSTRAINT [DF_STORAGE_STORDERED] DEFAULT ((0)) NOT NULL,
    [STORDATE]     DATETIME        NULL,
    [STINV]        DATETIME        NULL,
    [STAUTO]       TINYINT         CONSTRAINT [DF_STORAGE_STAUTO] DEFAULT ((0)) NOT NULL,
    [STAMOUNT]     DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STAMOUNT] DEFAULT ((0)) NOT NULL,
    [STAMAUTO]     DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STAMAUTO] DEFAULT ((0)) NOT NULL,
    [STAMDATE]     DATETIME        NULL,
    [STPROBE]      TINYINT         CONSTRAINT [DF_STORAGE_STPROBE] DEFAULT ((0)) NOT NULL,
    [STMEASURE]    DECIMAL (12, 2) CONSTRAINT [DF_STORAGE_STMEASURE] DEFAULT ((0)) NOT NULL,
    [STMEDATE]     DATETIME        NULL,
    [STPOS]        TINYINT         CONSTRAINT [DF_STORAGE_STPOS] DEFAULT ((0)) NOT NULL,
    [STSHOW]       TINYINT         CONSTRAINT [DF_STORAGE_STSHOW] DEFAULT ((0)) NOT NULL,
    [STNSCNUM]     INT             CONSTRAINT [DF_STORAGE_STNSCNUM] DEFAULT ((0)) NOT NULL,
    [STNSCINVMON]  INT             CONSTRAINT [DF_STORAGE_STNSCINVMON] DEFAULT ((0)) NOT NULL,
    [STNSCINVWEEK] INT             CONSTRAINT [DF_STORAGE_STNSCINVWEEK] DEFAULT ((0)) NOT NULL,
    [STNSCTIME]    INT             CONSTRAINT [DF_STORAGE_STNSCTIME] DEFAULT ((0)) NOT NULL,
    [STLARGEQU]    TINYINT         CONSTRAINT [DF_STORAGE_STLARGEQU] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_STORAGE] PRIMARY KEY CLUSTERED ([STIDENT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [INDEX_STORAGE_WHO]
    ON [dbo].[STORAGE]([STWHO] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_STORAGE_NAME]
    ON [dbo].[STORAGE]([STTITLE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_STORAGE_NUMBER]
    ON [dbo].[STORAGE]([STNUMBER] ASC) WHERE ([STNUMBER]<>'');


GO
CREATE NONCLUSTERED INDEX [INDEX_STORAGE_PRODUCT]
    ON [dbo].[STORAGE]([STPBIDENT] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STORAGE';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'STORAGE';

