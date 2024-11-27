﻿
      CREATE VIEW [dbo].[VehicleCardAutomat]
      WITH  VIEW_METADATA
      AS
      SELECT DISTINCT
      dbo.VEHICLE.VEPLATE,  dbo.VEHICLE.VEVEHNO, dbo.VEHICLE.VEINTNO,
      dbo.CARDS.CANO,       dbo.CARDS.CAVEIDENT, dbo.CARDS.CANO2,
      dbo.AUTOMAT.AUNUMBER, dbo.AUTOMAT.AUTITLE, dbo.VEHICLE.VECOIDENT
      FROM  dbo.VEHICLE
      INNER JOIN dbo.CARDS     ON dbo.VEHICLE.VEIDENT     = dbo.CARDS.CAVEIDENT
      INNER JOIN dbo.REFERENCE ON dbo.CARDS.CAIDENT       = dbo.REFERENCE.RECAIDENT
      INNER JOIN dbo.AUTOMAT   ON dbo.REFERENCE.REAUIDENT = dbo.AUTOMAT.AUIDENT
      WITH CHECK OPTION
    