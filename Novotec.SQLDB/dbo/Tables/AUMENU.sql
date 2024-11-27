CREATE TABLE [dbo].[AUMENU] (
    [AEIDENT]   BIGINT IDENTITY (1, 1) NOT NULL,
    [AEAHIDENT] BIGINT CONSTRAINT [DF_AUMENU_AEAHIDENT] DEFAULT ((0)) NOT NULL,
    [AENUM]     INT    CONSTRAINT [DF_AUMENU_AENUM] DEFAULT ((0)) NOT NULL,
    [AETYPE]    INT    CONSTRAINT [DF_AUMENU_AETYPE] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_AUMENU] PRIMARY KEY CLUSTERED ([AEIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AUMENU';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'AUMENU';

