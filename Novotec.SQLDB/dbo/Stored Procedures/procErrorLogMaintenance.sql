
      CREATE Procedure [dbo].[procErrorLogMaintenance]
      (
      @MaxFileSize int = 526000
      )
      AS
      Declare @CurrentLogFileSize bigint
      Create Table #LogFileInfo
      (
      [Archive #] tinyint,
      [Date] varchar(20),
      [Log File Size (Byte)] bigint
      )
      Insert #LogFileInfo Exec xp_enumerrorlogs
      Select @CurrentLogFileSize = [Log File Size (Byte)]
      From #LogFileInfo
      Where [Archive #] = 0
      If @CurrentLogFileSize > @MaxFileSize
      Exec sp_cycle_errorlog
      Drop Table #LogFileInfo
    