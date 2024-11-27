﻿CREATE TABLE [dbo].[SVACCDRIV] (
    [SAIDENT]   BIGINT       IDENTITY (1, 1) NOT NULL,
    [SAEMIDENT] BIGINT       CONSTRAINT [DF_SVACCDRIV_SAEMIDENT] DEFAULT ((0)) NOT NULL,
    [SAAUIDENT] BIGINT       CONSTRAINT [DF_SVACCDRIV_SAAUIDENT] DEFAULT ((0)) NOT NULL,
    [SAACCOUNT] INT          CONSTRAINT [DF_SVACCDRIV_SAACCOUNT] DEFAULT ((0)) NOT NULL,
    [SADRVNO]   VARCHAR (32) CONSTRAINT [DF_SVACCDRIV_SADRVNO] DEFAULT ('') NOT NULL,
    [SAPIN]     INT          CONSTRAINT [DF_SVACCDRIV_SAPIN] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_SVACCDRIV] PRIMARY KEY CLUSTERED ([SAIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SVACCDRIV';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SVACCDRIV';

