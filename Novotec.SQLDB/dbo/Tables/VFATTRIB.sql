CREATE TABLE [dbo].[VFATTRIB] (
    [VFIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [VFDATE]  DATETIME      CONSTRAINT [DF_VFATTRIB_VFDATE] DEFAULT (getdate()) NULL,
    [VFWHO]   BIGINT        CONSTRAINT [DF_VFATTRIB_VFWHO] DEFAULT ((0)) NOT NULL,
    [VFTITLE] VARCHAR (50)  CONSTRAINT [DF_VFATTRIB_VFTITLE] DEFAULT ('') NOT NULL,
    [VFMEMO]  VARCHAR (MAX) CONSTRAINT [DF_VFATTRIB_VFMEMO] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_VFATTRIB] PRIMARY KEY CLUSTERED ([VFIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'VFATTRIB';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'VFATTRIB';

