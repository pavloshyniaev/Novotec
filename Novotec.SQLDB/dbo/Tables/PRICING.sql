CREATE TABLE [dbo].[PRICING] (
    [PRIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [PRDATE]  DATETIME      CONSTRAINT [DF_PRICING_PRDATE] DEFAULT (getdate()) NULL,
    [PRWHO]   BIGINT        CONSTRAINT [DF_PRICING_PRWHO] DEFAULT ((0)) NOT NULL,
    [PRTITLE] VARCHAR (150) CONSTRAINT [DF_PRICING_PRTITLE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_PRICING] PRIMARY KEY CLUSTERED ([PRIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PRICING';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'PRICING';

