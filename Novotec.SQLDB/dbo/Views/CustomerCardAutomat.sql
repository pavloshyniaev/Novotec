﻿
      CREATE VIEW [dbo].[CustomerCardAutomat]
      WITH  VIEW_METADATA
      AS
      SELECT DISTINCT
      dbo.COMPANY.COCONO1, dbo.COMPANY.COCONO2, dbo.COMPANY.COTITLE1, dbo.COMPANY.COTITLE2, dbo.COMPANY.COTITLE3,
      dbo.ADDRESS.ADLOC,   dbo.ADDRESS.ADZIP,   dbo.ADDRESS.ADCTRY,
      dbo.ADDRESS.ADSTR,   dbo.ADDRESS.ADHP,    dbo.ADDRESS.ADPB,     dbo.ADDRESS.ADFNAME1, dbo.ADDRESS.ADLNAME1, dbo.ADDRESS.ADTITLE1, dbo.ADDRESS.ADGEN1, dbo.ADDRESS.ADTEL1,
      dbo.ADDRESS.ADTEL2,  dbo.ADDRESS.ADFAX1,  dbo.ADDRESS.ADEMAIL1,
      dbo.CARDS.CANO,      dbo.CARDS.CAIDENT,   dbo.CARDS.CANO2,
      dbo.AUTOMAT.AUNUMBER, dbo.AUTOMAT.AUTITLE, dbo.COMPANY.COIDENT
      FROM            dbo.COMPANY
      INNER JOIN dbo.ADDRESS   ON dbo.COMPANY.COADIDENT   = dbo.ADDRESS.ADIDENT
      INNER JOIN dbo.CARDS     ON dbo.COMPANY.COIDENT     = dbo.CARDS.CACOIDENT
      INNER JOIN dbo.REFERENCE ON dbo.CARDS.CAIDENT       = dbo.REFERENCE.RECAIDENT
      INNER JOIN dbo.AUTOMAT   ON dbo.REFERENCE.REAUIDENT = dbo.AUTOMAT.AUIDENT
      WITH CHECK OPTION
    