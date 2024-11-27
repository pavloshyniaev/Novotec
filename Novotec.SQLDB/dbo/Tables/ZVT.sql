CREATE TABLE [dbo].[ZVT] (
    [ZVIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [ZVDATE]  DATETIME     CONSTRAINT [DF_ZVT_ZVDATE] DEFAULT (getdate()) NOT NULL,
    [ZVTITLE] VARCHAR (50) CONSTRAINT [DF_ZVT_ZVTITLE] DEFAULT ('') NOT NULL,
    [ZVTYPE]  INT          CONSTRAINT [DF_ZVT_ZVTYPE] DEFAULT ((0)) NOT NULL,
    [ZVSHOW]  INT          CONSTRAINT [DF_ZVT_ZVSHOW] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_ZVT] PRIMARY KEY CLUSTERED ([ZVIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ZVT';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ZVT';

