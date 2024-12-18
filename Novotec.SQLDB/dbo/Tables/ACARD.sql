﻿CREATE TABLE [dbo].[ACARD] (
    [ACIDENT]   BIGINT   IDENTITY (1, 1) NOT NULL,
    [ACDATE]    DATETIME CONSTRAINT [DF_ACARD_ACDATE] DEFAULT (getdate()) NOT NULL,
    [ACWHO]     BIGINT   CONSTRAINT [DF_ACARD_ACWHO] DEFAULT ((0)) NOT NULL,
    [ACAUIDENT] BIGINT   CONSTRAINT [DF_ACARD_ACAUIDENT] DEFAULT ((0)) NOT NULL,
    [ACTYPE]    INT      CONSTRAINT [DF_ACARD_ACTYPE] DEFAULT ((0)) NOT NULL,
    [ACCAIDENT] BIGINT   CONSTRAINT [DF_ACARD_ACCAIDENT] DEFAULT ((0)) NOT NULL,
    [ACIDIDENT] BIGINT   CONSTRAINT [DF_ACARD_ACIDIDENT] DEFAULT ((0)) NOT NULL,
    [ACZVIDENT] BIGINT   CONSTRAINT [DF_ACARD_ACZVIDENT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ACARD] PRIMARY KEY CLUSTERED ([ACIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ACARD';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ACARD';

