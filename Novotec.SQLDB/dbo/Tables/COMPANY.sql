﻿CREATE TABLE [dbo].[COMPANY] (
    [COIDENT]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [CODATE]     DATETIME      CONSTRAINT [DF_COMPANY_CODATE] DEFAULT (getdate()) NULL,
    [COWHO]      BIGINT        CONSTRAINT [DF_COMPANY_COWHO] DEFAULT ((0)) NOT NULL,
    [COTYPE]     TINYINT       CONSTRAINT [DF_COMPANY_COTYPE] DEFAULT ((0)) NOT NULL,
    [COCONO1]    VARCHAR (50)  CONSTRAINT [DF_COMPANY_COCONO1] DEFAULT ('') NOT NULL,
    [COCONO2]    VARCHAR (50)  CONSTRAINT [DF_COMPANY_COCONO2] DEFAULT ('') NOT NULL,
    [COTITLE1]   VARCHAR (50)  CONSTRAINT [DF_COMPANY_COTITLE1] DEFAULT ('') NOT NULL,
    [COTITLE2]   VARCHAR (50)  CONSTRAINT [DF_COMPANY_COTITLE2] DEFAULT ('') NOT NULL,
    [COTITLE3]   VARCHAR (50)  CONSTRAINT [DF_COMPANY_COTITLE3] DEFAULT ('') NOT NULL,
    [COMEMO]     VARCHAR (MAX) CONSTRAINT [DF_COMPANY_COMEMO] DEFAULT ('') NOT NULL,
    [COADIDENT]  BIGINT        CONSTRAINT [DF_COMPANY_COADIDENT] DEFAULT ((0)) NOT NULL,
    [COEND]      DATETIME      NULL,
    [COSTATE]    VARCHAR (50)  CONSTRAINT [DF_COMPANY_COSTATE] DEFAULT ((0)) NOT NULL,
    [COIEIDENT]  BIGINT        CONSTRAINT [DF_COMPANY_COIEIDENT] DEFAULT ((0)) NOT NULL,
    [COMANAGER1] VARCHAR (50)  CONSTRAINT [DF_COMPANY_COMANAGER1] DEFAULT ('') NOT NULL,
    [COMANAGER2] VARCHAR (50)  CONSTRAINT [DF_COMPANY_COMANAGER2] DEFAULT ('') NOT NULL,
    [COMANAGER3] VARCHAR (50)  CONSTRAINT [DF_COMPANY_COMANAGER3] DEFAULT ('') NOT NULL,
    [COREGCOURT] VARCHAR (50)  CONSTRAINT [DF_COMPANY_COREGCOURT] DEFAULT ('') NOT NULL,
    [CONAME]     VARCHAR (150) CONSTRAINT [DF_COMPANY_CONAME] DEFAULT ('') NOT NULL,
    [COUCI]      VARCHAR (35)  CONSTRAINT [DF_COMPANY_COUCI] DEFAULT ('') NOT NULL,
    [COPUIDENT]  BIGINT        CONSTRAINT [DF_COMPANY_COPUIDENT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_COMPANY] PRIMARY KEY CLUSTERED ([COIDENT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [INDEX_COMPANY_CODATE]
    ON [dbo].[COMPANY]([CODATE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_COMPANY_COWHO]
    ON [dbo].[COMPANY]([COWHO] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_COMPANY_COTITLE1]
    ON [dbo].[COMPANY]([COTITLE1] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_COMPANY_COCONO1]
    ON [dbo].[COMPANY]([COCONO1] ASC);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'COMPANY';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'COMPANY';

