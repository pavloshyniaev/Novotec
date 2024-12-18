﻿CREATE TABLE [dbo].[SSTRUCTURE] (
    [SSIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [SSHIIDENT] BIGINT CONSTRAINT [DF_SSTRUCTURE_SSHIIDENT] DEFAULT ((0)) NOT NULL,
    [SSSRIDENT] BIGINT CONSTRAINT [DF_SSTRUCTURE_SSSRIDENT] DEFAULT ((0)) NOT NULL,
    [SSCOIDENT] BIGINT CONSTRAINT [DF_SSTRUCTURE_SSCOIDENT] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_SSTRUCTURE] PRIMARY KEY CLUSTERED ([SSIDENT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [INDEX_SSTRUCTURE_SSSRIDENT]
    ON [dbo].[SSTRUCTURE]([SSSRIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_SSTRUCTURE_SSHIIDENT]
    ON [dbo].[SSTRUCTURE]([SSHIIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_SSTRUCTURE_SCOIDENT]
    ON [dbo].[SSTRUCTURE]([SSCOIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_SSTRUCTURE_HISRIDENT]
    ON [dbo].[SSTRUCTURE]([SSHIIDENT] ASC)
    INCLUDE([SSSRIDENT]);


GO
CREATE NONCLUSTERED INDEX [INDEX_SSTRUCTURE_HICOIDENT]
    ON [dbo].[SSTRUCTURE]([SSHIIDENT] ASC)
    INCLUDE([SSCOIDENT]);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SSTRUCTURE';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'SSTRUCTURE';

