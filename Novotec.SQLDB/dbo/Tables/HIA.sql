﻿CREATE TABLE [dbo].[HIA] (
    [HIIDENT]       BIGINT          IDENTITY (1, 1) NOT NULL,
    [HITRIDENT]     BIGINT          CONSTRAINT [DF_HIA_HITRIDENT] DEFAULT ((0)) NOT NULL,
    [HIDATE]        DATETIME        NULL,
    [HITRDATE]      DATETIME        NULL,
    [HITRDATSTA]    DATETIME        NULL,
    [HITRDATEND]    DATETIME        NULL,
    [HITRDUR]       INT             CONSTRAINT [DF_HIA_HITRDUR] DEFAULT ((0)) NOT NULL,
    [HITYPE]        INT             CONSTRAINT [DF_HIA_HITYPE] DEFAULT ((0)) NOT NULL,
    [HIPUIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIPUIDENT] DEFAULT ((0)) NOT NULL,
    [HIPUVALUE]     NUMERIC (10, 2) CONSTRAINT [DF_HIA_HIPUVALUE] DEFAULT ((0)) NOT NULL,
    [HIEXPDATE]     DATETIME        NULL,
    [HIAUIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIAUIDENT] DEFAULT ((0)) NOT NULL,
    [HICAIDENT]     BIGINT          CONSTRAINT [DF_HIA_HICAIDENT] DEFAULT ((0)) NOT NULL,
    [HICAIDENT2]    BIGINT          CONSTRAINT [DF_HIA_HICAIDENT2] DEFAULT ((0)) NOT NULL,
    [HIPBIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIPBIDENT] DEFAULT ((0)) NOT NULL,
    [HILPRICE]      NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICE] DEFAULT ((0)) NOT NULL,
    [HILPRICE2]     NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICE2] DEFAULT ((0)) NOT NULL,
    [HILPRICE3]     NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICE3] DEFAULT ((0)) NOT NULL,
    [HILPRICEVN]    NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICEVN] DEFAULT ((0)) NOT NULL,
    [HILPRICEEB]    NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICEEB] DEFAULT ((0)) NOT NULL,
    [HILPRICEEW]    NUMERIC (10, 4) CONSTRAINT [DF_HIA_HILPRICEEW] DEFAULT ((0)) NOT NULL,
    [HIVAIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIVAIDENT] DEFAULT ((0)) NOT NULL,
    [HIQUANT]       NUMERIC (10, 3) CONSTRAINT [DF_HIA_HIQUANT] DEFAULT ((0)) NOT NULL,
    [HITOTAL1]      NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTAL1] DEFAULT ((0)) NOT NULL,
    [HITOTAL2]      NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTAL2] DEFAULT ((0)) NOT NULL,
    [HITOTAL3]      NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTAL3] DEFAULT ((0)) NOT NULL,
    [HITOTALVN]     NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTALVN] DEFAULT ((0)) NOT NULL,
    [HITOTALEB]     NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTALEB] DEFAULT ((0)) NOT NULL,
    [HITOTALEW]     NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTALEW] DEFAULT ((0)) NOT NULL,
    [HITOTALVAT]    NUMERIC (10, 2) CONSTRAINT [DF_HIA_HITOTALVAT] DEFAULT ((0)) NOT NULL,
    [HIINVPBASE]    INT             CONSTRAINT [DF_HIA_HIINVPBASE] DEFAULT ((0)) NOT NULL,
    [HIINVPEXTRA]   INT             CONSTRAINT [DF_HIA_HIINVPEXTRA] DEFAULT ((0)) NOT NULL,
    [HIINVPEXVAL]   NUMERIC (10, 4) CONSTRAINT [DF_HIA_HIINVPEXVAL] DEFAULT ((0)) NOT NULL,
    [HIINVLPRICE]   NUMERIC (10, 4) CONSTRAINT [DF_HIA_HIINVLPRICE] DEFAULT ((0)) NOT NULL,
    [HIINVTOTAL]    NUMERIC (10, 2) CONSTRAINT [DF_HIA_HIINVTOTAL] DEFAULT ((0)) NOT NULL,
    [HIGAINL]       NUMERIC (10, 2) CONSTRAINT [DF_HIA_HIGAINL] DEFAULT ((0)) NOT NULL,
    [HIGAIN]        NUMERIC (10, 2) CONSTRAINT [DF_HIA_HIGAIN] DEFAULT ((0)) NOT NULL,
    [HIPRTYPE]      INT             CONSTRAINT [DF_HIA_HIPRTYPE] DEFAULT ((0)) NOT NULL,
    [HIAIIDENT]     BIGINT          NOT NULL,
    [HIPROT]        BIGINT          CONSTRAINT [DF_HIA_HIPROT] DEFAULT ((0)) NOT NULL,
    [HIRECNO]       BIGINT          CONSTRAINT [DF_HIA_HIRECNO] DEFAULT ((0)) NOT NULL,
    [HISTATE]       INT             CONSTRAINT [DF_HIA_HISTATE] DEFAULT ((0)) NOT NULL,
    [HIINFO]        BIGINT          CONSTRAINT [DF_HIA_HIINFO] DEFAULT ((0)) NOT NULL,
    [HIINFO2]       BIGINT          CONSTRAINT [DF_HIA_HIINFO2] DEFAULT ((0)) NOT NULL,
    [HIIPIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIIPIDENT] DEFAULT ((0)) NOT NULL,
    [HISTIDENT]     BIGINT          CONSTRAINT [DF_HIA_HISTIDENT] DEFAULT ((0)) NOT NULL,
    [HICONLTR]      NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICONLTR] DEFAULT ((0)) NOT NULL,
    [HIHIIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIHIIDENT] DEFAULT ((0)) NOT NULL,
    [HICON100]      NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICON100] DEFAULT ((0)) NOT NULL,
    [HICON1000]     NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICON1000] DEFAULT ((0)) NOT NULL,
    [HICONREV]      NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICONREV] DEFAULT ((0)) NOT NULL,
    [HIMILEAGE]     NUMERIC (18, 3) CONSTRAINT [DF_HIA_HIMILEAGE] DEFAULT ((0)) NOT NULL,
    [HIEMIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIEMIDENT] DEFAULT ((0)) NOT NULL,
    [HIEMCAIDENT]   BIGINT          CONSTRAINT [DF_HIA_HIEMCAIDENT] DEFAULT ((0)) NOT NULL,
    [HIVEIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIVEIDENT] DEFAULT ((0)) NOT NULL,
    [HIVECAIDENT]   BIGINT          CONSTRAINT [DF_HIA_HIVECAIDENT] DEFAULT ((0)) NOT NULL,
    [HIIVIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIIVIDENT] DEFAULT ((0)) NOT NULL,
    [HIINTERN]      INT             CONSTRAINT [DF_HIA_HIINTERN] DEFAULT ((0)) NOT NULL,
    [HIFUIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIFUIDENT] DEFAULT ((0)) NOT NULL,
    [HIFLIDENT]     BIGINT          CONSTRAINT [DF_HIA_HIFLIDENT] DEFAULT ((0)) NOT NULL,
    [HIMEMO]        VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIMEMO] DEFAULT ('') NOT NULL,
    [HICO2AV]       NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICO2AV] DEFAULT ((0)) NOT NULL,
    [HICO2]         NUMERIC (10, 3) CONSTRAINT [DF_HIA_HICO2] DEFAULT ((0)) NOT NULL,
    [HIDIAL1]       VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIDIAL1] DEFAULT ('') NOT NULL,
    [HIDIAL2]       VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIDIAL2] DEFAULT ('') NOT NULL,
    [HIDIAL3]       VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIDIAL3] DEFAULT ('') NOT NULL,
    [HIDIAL4]       VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIDIAL4] DEFAULT ('') NOT NULL,
    [HIDIAL5]       VARCHAR (MAX)   CONSTRAINT [DF_HIA_HIDIAL5] DEFAULT ('') NOT NULL,
    [HITOLLTT]      INT             CONSTRAINT [DF_HIA_HITOLLTT] DEFAULT ((0)) NOT NULL,
    [HITOLLTO]      INT             CONSTRAINT [DF_HIA_HITOLLTO] DEFAULT ((0)) NOT NULL,
    [HITOLLTZ]      INT             CONSTRAINT [DF_HIA_HITOLLTZ] DEFAULT ((0)) NOT NULL,
    [HITOLLTA]      INT             CONSTRAINT [DF_HIA_HITOLLTA] DEFAULT ((0)) NOT NULL,
    [HITOLLTG]      INT             CONSTRAINT [DF_HIA_HITOLLTG] DEFAULT ((0)) NOT NULL,
    [HITOLLTM]      INT             CONSTRAINT [DF_HIA_HITOLLTM] DEFAULT ((0)) NOT NULL,
    [HITOLLIS]      INT             CONSTRAINT [DF_HIA_HITOLLIS] DEFAULT ((0)) NOT NULL,
    [HITOLLTY]      VARCHAR (4)     CONSTRAINT [DF_HIA_HITOLLTY] DEFAULT ('') NOT NULL,
    [HIMAN]         TINYINT         CONSTRAINT [DF_HIA_HIMAN] DEFAULT ((0)) NOT NULL,
    [HILK]          TINYINT         CONSTRAINT [DF_HIA_HILK] DEFAULT ((0)) NOT NULL,
    [HITOTQUANTITY] NUMERIC (14, 3) CONSTRAINT [DF_HIA_HITOTQUANTITY] DEFAULT ((0)) NOT NULL,
    [HITOTAMOUNT]   NUMERIC (14, 3) CONSTRAINT [DF_HIA_HITOTAMOUNT] DEFAULT ((0)) NOT NULL,
    [HINOZZLE]      TINYINT         CONSTRAINT [DF_HIA_HINOZZLE] DEFAULT ((0)) NOT NULL,
    [HITOTQDIFF]    NUMERIC (14, 3) CONSTRAINT [DF_HIA_HITOTQDIFF] DEFAULT ((0)) NOT NULL,
    [HITOTADIFF]    NUMERIC (14, 3) CONSTRAINT [DF_HIA_HITOTADIFF] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_HIA] PRIMARY KEY CLUSTERED ([HIIDENT] ASC)
);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_CARD1]
    ON [dbo].[HIA]([HICAIDENT] ASC) WHERE ([HICAIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_CARD2]
    ON [dbo].[HIA]([HICAIDENT2] ASC) WHERE ([HICAIDENT2]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_TRDATE]
    ON [dbo].[HIA]([HITRDATE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_FLEET]
    ON [dbo].[HIA]([HIFLIDENT] ASC) WHERE ([HIFLIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_TERMINAL]
    ON [dbo].[HIA]([HIAUIDENT] ASC) WHERE ([HIAUIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_STORAGE]
    ON [dbo].[HIA]([HISTIDENT] ASC) WHERE ([HISTIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_EMPLOYEE]
    ON [dbo].[HIA]([HIEMIDENT] ASC) WHERE ([HIEMIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_VEHICLE]
    ON [dbo].[HIA]([HIVEIDENT] ASC) WHERE ([HIVEIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_PRODUCT]
    ON [dbo].[HIA]([HIPBIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_TRIDENT]
    ON [dbo].[HIA]([HITRIDENT] ASC) WHERE ([HITRIDENT]>(0));


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_HITYPE]
    ON [dbo].[HIA]([HITYPE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_HIINTERN]
    ON [dbo].[HIA]([HIINTERN] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_HITRDATE]
    ON [dbo].[HIA]([HITRDATE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_ADISP_NOFILTER]
    ON [dbo].[HIA]([HIAIIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_TERMINAL_NOFILTER]
    ON [dbo].[HIA]([HIAUIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_CARD1_NOFILTER]
    ON [dbo].[HIA]([HICAIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_CARD2_NOFILTER]
    ON [dbo].[HIA]([HICAIDENT2] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_EMPLOYEE_NOFILTER]
    ON [dbo].[HIA]([HIEMIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_FLEET_NOFILTER]
    ON [dbo].[HIA]([HIFLIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_INVOICE_NOFILTER]
    ON [dbo].[HIA]([HIIVIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_VAT_NOFILTER]
    ON [dbo].[HIA]([HIVAIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_VEHICLE_NOFILTER]
    ON [dbo].[HIA]([HIVEIDENT] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_VEHICLE_DATE]
    ON [dbo].[HIA]([HIVEIDENT] ASC, [HITRDATE] ASC);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_VEHICLE_PROD]
    ON [dbo].[HIA]([HIVEIDENT] ASC, [HITRDATE] ASC, [HIMILEAGE] ASC)
    INCLUDE([HIIDENT], [HIPBIDENT]);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_CARDDATE]
    ON [dbo].[HIA]([HICAIDENT] ASC)
    INCLUDE([HIDATE]);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_TYPE]
    ON [dbo].[HIA]([HITYPE] ASC)
    INCLUDE([HITRDATE], [HITOTAL2], [HITOTALVN]);


GO
CREATE NONCLUSTERED INDEX [INDEX_HIA_PREPAID]
    ON [dbo].[HIA]([HIPUIDENT] ASC) WHERE ([HIPUIDENT]>(0));


GO
EXECUTE sp_addextendedproperty @name = N'ENABLE_BROKER', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'HIA';


GO
EXECUTE sp_addextendedproperty @name = N'EVENT NOTIFICATION', @value = N'TRUE', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'HIA';

