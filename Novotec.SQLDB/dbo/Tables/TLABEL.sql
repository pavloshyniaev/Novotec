CREATE TABLE [dbo].[TLABEL] (
    [TLIDENT] BIGINT        IDENTITY (1, 1) NOT NULL,
    [TLWHO]   BIGINT        CONSTRAINT [DF_TLABEL_TLWHO] DEFAULT ((0)) NOT NULL,
    [TLDATE]  DATETIME      CONSTRAINT [DF_TLABEL_TLDATE] DEFAULT (getdate()) NULL,
    [TLID]    INT           NOT NULL,
    [TLCOLOR] VARCHAR (30)  NOT NULL,
    [TLTEXT]  VARCHAR (100) NOT NULL,
    [TLMEMO]  VARCHAR (MAX) NOT NULL,
    [TLSTYPE] INT           CONSTRAINT [DF_TLABEL_TLSTYPE] DEFAULT ((1)) NOT NULL,
    CONSTRAINT [PK_TLABEL] PRIMARY KEY CLUSTERED ([TLIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TLABEL';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'TLABEL';

