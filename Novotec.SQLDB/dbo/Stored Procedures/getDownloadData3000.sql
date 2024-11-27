
      -- =============================================
      -- Author:		  Ralf Buddenhagen
      -- Create date: 12.10.2012
	  -- Update date: 24.08.2020 (more fields)
      -- Description:	get NSC card data for download
      --
      -- =============================================
      CREATE PROCEDURE [dbo].[getDownloadData3000]
      @REAUIDENT bigint
      ,@RECAIDENT  bigint
      AS
      BEGIN
      SET NOCOUNT ON;

      -- retrieve the data
      IF (@RECAIDENT > 0)
        BEGIN
          SELECT cano,catype,
		  caemident, caveident, cacoident, caleident, castident,
          recaident, retype, relock, 
          reoffgroup, recrident, revalid, reexpire, reapident, reapgroup, recc, relimit, requant, relock, redial, 
          reprivate, repin, redialog, recolstate, resecond, recodensc, relex, redown,
          crnumber
          FROM reference
          LEFT OUTER JOIN cards ON recaident=caident
          LEFT OUTER JOIN crange ON recrident=crident 
          WHERE reauident=@reauident
          AND   recaident=@recaident
  	  AND   catype > 99
        END
      ELSE
        BEGIN
          SELECT cano,catype,
		  caemident, caveident, cacoident, caleident, castident,
          recaident, retype, relock, 
          reoffgroup, recrident, revalid, reexpire, reapident, reapgroup, recc, relimit, requant, relock, redial, 
          reprivate, repin, redialog, recolstate, resecond, recodensc, relex, redown,
          crnumber
          FROM reference
          LEFT OUTER JOIN cards ON recaident=caident
          LEFT OUTER JOIN crange ON recrident=crident 
          WHERE reauident=@reauident
  	  AND   catype > 99
        END
     END
    