using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Glbsearch
{
    public long Glident { get; set; }

    public DateTime? Gldate { get; set; }

    public long Glwho { get; set; }

    public int Glscope { get; set; }

    public string Glsql { get; set; } = null!;

    public string Gltext { get; set; } = null!;

    public string Glfield { get; set; } = null!;

    public string Glitem { get; set; } = null!;

    public byte Glprog { get; set; }
}
