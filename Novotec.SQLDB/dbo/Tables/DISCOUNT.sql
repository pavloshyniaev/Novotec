CREATE TABLE [dbo].[DISCOUNT] (
    [DIIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [DIDATE]  DATETIME      CONSTRAINT [DF_DISCOUNT_DIDATE] DEFAULT (getdate()) NULL,
    [DIWHO]   BIGINT        CONSTRAINT [DF_DISCOUNT_DIWHO] DEFAULT ((0)) NOT NULL,
    [DITITLE] VARCHAR (150) CONSTRAINT [DF_DISCOUNT_DITITLE] DEFAULT ('') NOT NULL,
    [DITYPE]  INT           CONSTRAINT [DF_DISCOUNT_DITYPE] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_DISCOUNT] PRIMARY KEY CLUSTERED ([DIIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'DISCOUNT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'DISCOUNT';

