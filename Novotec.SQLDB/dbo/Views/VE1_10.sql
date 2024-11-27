﻿
      CREATE VIEW [dbo].[VE1_10]
      WITH  VIEW_METADATA
      AS
      SELECT     dbo.VEHICLE.VEIDENT,
      dbo.VEHICLE.VEDATE, dbo.VEHICLE.VEWHO, dbo.VEHICLE.VEINTNO, dbo.VEHICLE.VEPLATE, dbo.VEHICLE.VEMEMO,
      dbo.VEHICLE.VEPBIDENT, dbo.VEHICLE.VEPGIDENT, dbo.VEHICLE.VESTART, dbo.VEHICLE.VEEND, dbo.VEHICLE.VELEIDENT, dbo.VEHICLE.VECOIDENT,
      dbo.VEHICLE.VECC, dbo.VEHICLE.VEEMIDENT, dbo.VEHICLE.VESTOC, dbo.VEHICLE.VESRIDENT, dbo.VEHICLE.VEMILES, dbo.VEHICLE.VEHOURS,
      dbo.VEHICLE.VETYPE, dbo.VEHICLE.VEKMOFFSET, dbo.VEHICLE.VEHHOFFSET, dbo.VEHICLE.VEOFFDATE, dbo.VEHICLE.VEKMSTART, dbo.VEHICLE.VEHHSTART,
      dbo.VEHICLE.VEPLATE2, dbo.VEHICLE.VESTATE,   dbo.VEHICLE.VECOCODE,  dbo.VEHICLE.VEHO,      dbo.VEHICLE.VEDIVISION,dbo.VEHICLE.VEDIVABBR, dbo.VEHICLE.VEGROUP, dbo.VEHICLE.VECAT,
      dbo.VTECH.VTIDENT,
      dbo.VTECH.VTTANK, dbo.VTECH.VTNORM, dbo.VTECH.VTPOS,dbo.VTECH.VTNEG,
      dbo.USLOG.USIDENT,
      dbo.USLOG.USDATE, dbo.USLOG.USWHO, dbo.USLOG.USPW, dbo.USLOG.USNAME, dbo.USLOG.USADMIN, dbo.USLOG.USVALDATE,
      dbo.PBASE.PBIDENT,
      dbo.PBASE.PBDATE, dbo.PBASE.PBWHO, dbo.PBASE.PBTITLE, dbo.PBASE.PBNUMBER, dbo.PBASE.PBMEMO, dbo.PBASE.PBPGIDENT, dbo.PBASE.PBPTIDENT,
      dbo.PBASE.PBEXTERN, dbo.PBASE.PBEAN, dbo.PBASE.PBDISPL, dbo.PBASE.PBVAIDENT,
      dbo.PGROUP.PGIDENT,
      dbo.PGROUP.PGDATE, dbo.PGROUP.PGWHO,dbo.PGROUP.PGTITLE, dbo.PGROUP.PGNUMBER, dbo.PGROUP.PGMEMO,
      dbo.STRUCTURE.SRNUMBER,
      dbo.STRUCTURE.SRTITLE, dbo.STRUCTURE.SRMEMO, dbo.STRUCTURE.SRADIDENT,
      dbo.ADDRESS.ADIDENT,
      dbo.ADDRESS.ADWHO, dbo.ADDRESS.ADDATE, dbo.ADDRESS.ADTYPE, dbo.ADDRESS.ADLOC, dbo.ADDRESS.ADZIP,
      dbo.ADDRESS.ADCTRY, dbo.ADDRESS.ADSTR, dbo.ADDRESS.ADHP, dbo.ADDRESS.ADPB, dbo.ADDRESS.ADFNAME1, dbo.ADDRESS.ADLNAME1,
      dbo.ADDRESS.ADTITLE1, dbo.ADDRESS.ADGEN1, dbo.ADDRESS.ADTEL1, dbo.ADDRESS.ADTEL2, dbo.ADDRESS.ADFAX1, dbo.ADDRESS.ADEMAIL1,
      dbo.ADDRESS.ADFNAME2, dbo.ADDRESS.ADLNAME2, dbo.ADDRESS.ADTITLE2, dbo.ADDRESS.ADGEN2, dbo.ADDRESS.ADTEL3, dbo.ADDRESS.ADTEL4,
      dbo.ADDRESS.ADFAX2, dbo.ADDRESS.ADEMAIL2, dbo.ADDRESS.ADBANK1, dbo.ADDRESS.ADROUTNO1, dbo.ADDRESS.ADIBAN1, dbo.ADDRESS.ADACC1,
      dbo.ADDRESS.ADIBC1, dbo.ADDRESS.ADBANK2, dbo.ADDRESS.ADROUTNO2, dbo.ADDRESS.ADIBAN2, dbo.ADDRESS.ADACC2, dbo.ADDRESS.ADIBC2,
      dbo.ADDRESS.ADXXIDENT, dbo.ADDRESS.ADVATID,
      dbo.COMPANY.COIDENT,
      dbo.COMPANY.CODATE, dbo.COMPANY.COWHO, dbo.COMPANY.COTYPE, dbo.COMPANY.COCONO1, dbo.COMPANY.COCONO2, dbo.COMPANY.COTITLE1, dbo.COMPANY.COTITLE2, dbo.COMPANY.COTITLE3,
      dbo.COMPANY.COMEMO, dbo.COMPANY.COADIDENT, dbo.COMPANY.COEND, dbo.COMPANY.COSTATE
      FROM
      dbo.VEHICLE LEFT OUTER JOIN
      dbo.VTECH      ON dbo.VEHICLE.VEIDENT     = dbo.VTECH.VTIDENT     LEFT OUTER JOIN
      dbo.USLOG      ON dbo.VEHICLE.VEWHO       = dbo.USLOG.USIDENT     LEFT OUTER JOIN
      dbo.STRUCTURE  ON dbo.VEHICLE.VELEIDENT   = dbo.STRUCTURE.SRIDENT LEFT OUTER JOIN
      dbo.ADDRESS    ON dbo.STRUCTURE.SRADIDENT = dbo.ADDRESS.ADIDENT   LEFT OUTER JOIN
      dbo.PBASE      ON dbo.VEHICLE.VEPBIDENT   = dbo.PBASE.PBIDENT     LEFT OUTER JOIN
      dbo.PGROUP     ON dbo.VEHICLE.VEPGIDENT   = dbo.PGROUP.PGIDENT    LEFT OUTER JOIN
      dbo.COMPANY    ON dbo.VEHICLE.VECOIDENT   = dbo.COMPANY.COIDENT
      WITH CHECK OPTION
    