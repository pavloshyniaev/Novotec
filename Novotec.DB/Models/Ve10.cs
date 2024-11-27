using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Ve10
{
    public long Veident { get; set; }

    public DateTime? Vedate { get; set; }

    public long Vewho { get; set; }

    public string Veintno { get; set; } = null!;

    public string Veplate { get; set; } = null!;

    public string Vememo { get; set; } = null!;

    public long Vepbident { get; set; }

    public long Vepgident { get; set; }

    public DateTime? Vestart { get; set; }

    public DateTime? Veend { get; set; }

    public long Veleident { get; set; }

    public long Vecoident { get; set; }

    public string Vecc { get; set; } = null!;

    public long Veemident { get; set; }

    public string Vestoc { get; set; } = null!;

    public long Vesrident { get; set; }

    public int Vemiles { get; set; }

    public decimal Vehours { get; set; }

    public byte Vetype { get; set; }

    public int Vekmoffset { get; set; }

    public decimal Vehhoffset { get; set; }

    public DateTime? Veoffdate { get; set; }

    public int Vekmstart { get; set; }

    public decimal Vehhstart { get; set; }

    public string Veplate2 { get; set; } = null!;

    public string Vestate { get; set; } = null!;

    public string Vecocode { get; set; } = null!;

    public string Veho { get; set; } = null!;

    public string Vedivision { get; set; } = null!;

    public string Vedivabbr { get; set; } = null!;

    public string Vegroup { get; set; } = null!;

    public int Vecat { get; set; }

    public long? Usident { get; set; }

    public DateTime? Usdate { get; set; }

    public long? Uswho { get; set; }

    public string? Uspw { get; set; }

    public string? Usname { get; set; }

    public string? Srnumber { get; set; }

    public string? Srtitle { get; set; }

    public string? Srmemo { get; set; }

    public long? Sradident { get; set; }

    public long? Adident { get; set; }

    public long? Adwho { get; set; }

    public DateTime? Addate { get; set; }

    public byte? Adtype { get; set; }

    public string? Adloc { get; set; }

    public string? Adzip { get; set; }

    public string? Adctry { get; set; }

    public string? Adstr { get; set; }

    public string? Adhp { get; set; }

    public string? Adpb { get; set; }

    public string? Adfname1 { get; set; }

    public string? Adlname1 { get; set; }

    public string? Adtitle1 { get; set; }

    public byte? Adgen1 { get; set; }

    public string? Adtel1 { get; set; }

    public string? Adtel2 { get; set; }

    public string? Adfax1 { get; set; }

    public string? Ademail1 { get; set; }

    public string? Adfname2 { get; set; }

    public string? Adlname2 { get; set; }

    public string? Adtitle2 { get; set; }

    public byte? Adgen2 { get; set; }

    public string? Adtel3 { get; set; }

    public string? Adtel4 { get; set; }

    public string? Adfax2 { get; set; }

    public string? Ademail2 { get; set; }

    public string? Adbank1 { get; set; }

    public string? Adroutno1 { get; set; }

    public string? Adiban1 { get; set; }

    public string? Adacc1 { get; set; }

    public string? Adibc1 { get; set; }

    public string? Adbank2 { get; set; }

    public string? Adroutno2 { get; set; }

    public string? Adiban2 { get; set; }

    public string? Adacc2 { get; set; }

    public string? Adibc2 { get; set; }

    public long? Adxxident { get; set; }

    public string? Advatid { get; set; }

    public long? Pbident { get; set; }

    public DateTime? Pbdate { get; set; }

    public long? Pbwho { get; set; }

    public string? Pbtitle { get; set; }

    public string? Pbnumber { get; set; }

    public string? Pbmemo { get; set; }

    public long? Pbpgident { get; set; }

    public long? Pbptident { get; set; }

    public string? Pbextern { get; set; }

    public string? Pbean { get; set; }

    public long? Pbdispl { get; set; }

    public long? Pbvaident { get; set; }

    public long? Pgident { get; set; }

    public DateTime? Pgdate { get; set; }

    public long? Pgwho { get; set; }

    public string? Pgtitle { get; set; }

    public string? Pgnumber { get; set; }

    public string? Pgmemo { get; set; }

    public long? Vtident { get; set; }

    public DateTime? Vtdate { get; set; }

    public long? Vtwho { get; set; }

    public int? Vttank { get; set; }

    public decimal? Vtnorm { get; set; }

    public string? Vttyresiz1 { get; set; }

    public string? Vttyresiz2 { get; set; }

    public string? Vttyresiz3 { get; set; }

    public string? Vttyresiz4 { get; set; }

    public string? Vttyresiz5 { get; set; }

    public string? Vttyresize { get; set; }

    public byte? Vtsteer1 { get; set; }

    public byte? Vtsteer2 { get; set; }

    public byte? Vtsteer3 { get; set; }

    public byte? Vtsteer4 { get; set; }

    public byte? Vtsteer5 { get; set; }

    public byte? Vtlift1 { get; set; }

    public byte? Vtlift2 { get; set; }

    public byte? Vtlift3 { get; set; }

    public byte? Vtlift4 { get; set; }

    public byte? Vtlift5 { get; set; }

    public byte? Vttwin1 { get; set; }

    public byte? Vttwin2 { get; set; }

    public byte? Vttwin3 { get; set; }

    public byte? Vttwin4 { get; set; }

    public byte? Vttwin5 { get; set; }

    public int? Vtgvw { get; set; }

    public int? Vtswl { get; set; }

    public int? Vtret { get; set; }

    public int? Vtunda { get; set; }

    public string? Vtmotor { get; set; }

    public int? Vtmpower { get; set; }

    public int? Vtcyclap { get; set; }

    public int? Vtseats { get; set; }

    public int? Vtstand { get; set; }

    public string? Vtmemo { get; set; }

    public int? Vtloadarea { get; set; }

    public int? Vthold { get; set; }

    public int? Vtloadh { get; set; }

    public int? Vtloadw { get; set; }

    public int? Vtloadl { get; set; }

    public decimal? Vtpos { get; set; }

    public decimal? Vtneg { get; set; }

    public long? Coident { get; set; }

    public DateTime? Codate { get; set; }

    public long? Cowho { get; set; }

    public byte? Cotype { get; set; }

    public string? Cocono1 { get; set; }

    public string? Cocono2 { get; set; }

    public string? Cotitle1 { get; set; }

    public string? Cotitle2 { get; set; }

    public string? Cotitle3 { get; set; }

    public string? Comemo { get; set; }

    public long? Coadident { get; set; }

    public DateTime? Coend { get; set; }

    public string? Costate { get; set; }
}
