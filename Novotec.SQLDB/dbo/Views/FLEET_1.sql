
      CREATE VIEW [dbo].[FLEET_1]
      AS
      SELECT
      dbo.FLEET.FENO,        dbo.FLEET.FETITLE,     dbo.CARDS.CANO,         dbo.CARDS.CADATE,     dbo.CARDS.CAFCIDENT,  dbo.FCUNO.FCTYPE,
      dbo.FCUNO.FCNO,        dbo.FCUNO.FCIDENT
      FROM
      dbo.FLEET                                                             LEFT  OUTER JOIN
      dbo.FCUNO  ON          dbo.FLEET.FENO      = dbo.FCUNO.FCTYPE         RIGHT OUTER JOIN
      dbo.CARDS  ON          dbo.CARDS.CAFCIDENT = dbo.FCUNO.FCIDENT        
      WHERE     (NOT (dbo.FLEET.FENO IS NULL))
    