using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Pgroup
{
    public long Pgident { get; set; }

    public DateTime? Pgdate { get; set; }

    public long Pgwho { get; set; }

    public string Pgtitle { get; set; } = null!;

    public string Pgnumber { get; set; } = null!;

    public string Pgmemo { get; set; } = null!;

    public int Pgfltype { get; set; }

    public decimal Pgco2 { get; set; }
}
