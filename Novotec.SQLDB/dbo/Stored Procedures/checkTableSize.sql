
      CREATE PROCEDURE [dbo].[checkTableSize]
      AS
      SET NOCOUNT ON;

      if OBJECT_ID('tempdb..#largetable') is not null
      drop table #LARGETABLES

      create table #LARGETABLES
      (Table_Name varchar(100) null,Row_Count bigint null)

      insert into #LARGETABLES (Table_Name, Row_Count)
      exec sp_msforeachtable 'select ''?'', count(1) from ? with (nolock)'

      select * from #LARGETABLES
      order by Row_Count desc

      if OBJECT_ID('tempdb..#LARGETABLES') is not null
      drop table #LARGETABLES
    