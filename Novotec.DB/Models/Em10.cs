using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Em10
{
    public long Emident { get; set; }

    public DateTime? Emdate { get; set; }

    public long Emwho { get; set; }

    public string Empersno { get; set; } = null!;

    public string Emdrivno { get; set; } = null!;

    public DateTime? Emstart { get; set; }

    public DateTime? Emend { get; set; }

    public byte Emtype { get; set; }

    public long Emleident { get; set; }

    public long Emcoident { get; set; }

    public long Emadident { get; set; }

    public string Emmemo { get; set; } = null!;

    public string Emstate { get; set; } = null!;

    public long Emadcomp { get; set; }

    public byte Emiscust { get; set; }

    public long? Emcoid { get; set; }

    public string Emcocode { get; set; } = null!;

    public string Emho { get; set; } = null!;

    public string Emdivision { get; set; } = null!;

    public string Emdivabbr { get; set; } = null!;

    public string Emgroup { get; set; } = null!;

    public long? Usident { get; set; }

    public DateTime? Usdate { get; set; }

    public long? Uswho { get; set; }

    public string? Usname { get; set; }

    public byte? Usadmin { get; set; }

    public DateTime? Usvaldate { get; set; }

    public byte? Usovseps { get; set; }

    public long? Adident { get; set; }

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

    public long? Ofadident { get; set; }

    public string? Ofadtel1 { get; set; }

    public string? Ofadtel2 { get; set; }

    public string? Ofadfax1 { get; set; }

    public string? Ofademail1 { get; set; }

    public string? Cotitle1 { get; set; }

    public string? Cotitle2 { get; set; }

    public string? Cotitle3 { get; set; }

    public string? Cocono1 { get; set; }

    public string? Cocono2 { get; set; }

    public string? Srtitle { get; set; }
}
