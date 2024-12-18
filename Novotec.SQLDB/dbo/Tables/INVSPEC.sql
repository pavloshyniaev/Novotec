﻿CREATE TABLE [dbo].[INVSPEC] (
    [IEIDENT]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [IEWHO]      BIGINT        CONSTRAINT [DF_INVSPEC_IEWHO] DEFAULT ((0)) NOT NULL,
    [IEDATE]     DATETIME      CONSTRAINT [DF_INVSPEC_IEDATE] DEFAULT (getdate()) NULL,
    [IETITLE]    VARCHAR (150) CONSTRAINT [DF_INVSPEC_IETITLE] DEFAULT ('') NOT NULL,
    [IEINTYPE]   INT           CONSTRAINT [DF_INVSPEC_IEINTYPE] DEFAULT ((0)) NOT NULL,
    [IETARDAYS]  INT           CONSTRAINT [DF_INVSPEC_IETARDAYS] DEFAULT ((0)) NOT NULL,
    [IEPAYMENT]  INT           CONSTRAINT [DF_INVSPEC_IEPAYMENT] DEFAULT ((0)) NOT NULL,
    [IEPAYTEXT]  VARCHAR (150) NOT NULL,
    [IEPRINT]    INT           CONSTRAINT [DF_INVSPEC_IEPRINT] DEFAULT ((0)) NOT NULL,
    [IETYPE]     INT           NOT NULL,
    [IECHARGE]   INT           CONSTRAINT [DF_INVSPEC_IECHARGE] DEFAULT ((0)) NOT NULL,
    [IECDISC]    INT           CONSTRAINT [DF_INVSPEC_IECDISC] DEFAULT ((0)) NOT NULL,
    [IECDISCTAR] INT           CONSTRAINT [DF_INVSPEC_IECDISCTAR] DEFAULT ((0)) NOT NULL,
    [IEPRIDENT]  BIGINT        CONSTRAINT [DF_INVSPEC_IEPRIDENT] DEFAULT ((0)) NOT NULL,
    [IEDIIDENT]  BIGINT        CONSTRAINT [DF_INVSPEC_IEDIIDENT] DEFAULT ((0)) NOT NULL,
    [IEINTERN]   INT           CONSTRAINT [DF_INVSPEC_IEINTERN] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_INVSPEC] PRIMARY KEY CLUSTERED ([IEIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INVSPEC';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'INVSPEC';

