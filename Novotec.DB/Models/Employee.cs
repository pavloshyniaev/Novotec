using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Employee
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
}
