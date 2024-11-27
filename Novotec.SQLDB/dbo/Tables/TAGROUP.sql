CREATE TABLE [dbo].[TAGROUP] (
    [TAIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [TAWHO]   BIGINT       CONSTRAINT [DF_TAGROUP_TAWHO] DEFAULT ((0)) NOT NULL,
    [TADATE]  DATETIME     CONSTRAINT [DF_TAGROUP_TADATE] DEFAULT (getdate()) NULL,
    [TANO]    INT          CONSTRAINT [DF_TAGROUP_TANO] DEFAULT ((0)) NOT NULL,
    [TATITLE] VARCHAR (50) CONSTRAINT [DF_TAGROUP_TATITLE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_TAGROUP] PRIMARY KEY CLUSTERED ([TAIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TAGROUP';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TAGROUP';

