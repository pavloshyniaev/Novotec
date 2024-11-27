CREATE TABLE [dbo].[FCOUNTRY] (
    [FOIDENT] BIGINT       IDENTITY (1, 1) NOT NULL,
    [FONO]    INT          CONSTRAINT [DF_FCOUNTRY_FONO] DEFAULT ((0)) NOT NULL,
    [FOCODE]  VARCHAR (10) CONSTRAINT [DF_FCOUNTRY_FOCODE] DEFAULT ('') NOT NULL,
    [FOCTRY]  VARCHAR (30) CONSTRAINT [DF_FCOUNTRY_FOCTRY] DEFAULT ('') NOT NULL,
    CONSTRAINT [PK_FCOUNTRY] PRIMARY KEY CLUSTERED ([FOIDENT] ASC)
);


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FCOUNTRY';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'FCOUNTRY';

