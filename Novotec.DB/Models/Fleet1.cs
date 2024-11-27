using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Fleet1
{
    public int? Feno { get; set; }

    public string? Fetitle { get; set; }

    public string Cano { get; set; } = null!;

    public DateTime? Cadate { get; set; }

    public long Cafcident { get; set; }

    public int? Fctype { get; set; }

    public string? Fcno { get; set; }

    public long? Fcident { get; set; }
}
