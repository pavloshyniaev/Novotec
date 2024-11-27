CREATE TABLE [dbo].[FLEET] (
    [FEIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FENO]    INT          CONSTRAINT [DF_FLEET_FENO] DEFAULT ((0)) NOT NULL,
    [FETITLE] VARCHAR (50) CONSTRAINT [DF_FLEET_FETITLE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_FLEET] PRIMARY KEY CLUSTERED ([FEIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FLEET';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FLEET';

