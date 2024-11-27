CREATE TABLE [dbo].[LOGIN] (
    [LOIDENT] BIGINT    IDENTITY (1, 1) NOT NULL,
    [LODATE]  DATETIME  CONSTRAINT [DF_LOGIN_LODATE] DEFAULT (getdate()) NULL,
    [LOWHO]   BIGINT    CONSTRAINT [DF_LOGIN_LOWHO] DEFAULT ((0)) NOT NULL,
    [LOADMIN] CHAR (1)  CONSTRAINT [DF_LOGIN_LOADMIN] DEFAULT ('') NOT NULL,
    [LOTYPE]  CHAR (1)  CONSTRAINT [DF_LOGIN_LOTYPE] DEFAULT ('') NOT NULL,
    [LOPROG]  CHAR (25) CONSTRAINT [DF_LOGIN_LOPROG] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_LOGIN] PRIMARY KEY CLUSTERED ([LOIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LOGIN';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'LOGIN';

