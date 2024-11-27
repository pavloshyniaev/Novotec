CREATE TABLE [dbo].[ENDATA] (
    [ENIDENT]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [ENDATE]    DATETIME      CONSTRAINT [DF_ENDATA_ENDATE] DEFAULT (getdate()) NOT NULL,
    [ENAUIDENT] BIGINT        CONSTRAINT [DF_ENDATA_ENAUIDENT] DEFAULT ((0)) NOT NULL,
    [ENLINENO]  INT           CONSTRAINT [DF_ENDATA_ENLINENO] DEFAULT ((0)) NOT NULL,
    [ENLINE]    VARCHAR (MAX) CONSTRAINT [DF_ENDATA_ENLINE] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_ENDATA] PRIMARY KEY CLUSTERED ([ENIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ENDATA';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'ENDATA';

