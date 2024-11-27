using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboPgroup
{
    public sbyte? Pgident { get; set; }

    public string? Pgdate { get; set; }

    public sbyte? Pgwho { get; set; }

    public string? Pgtitle { get; set; }

    public string? Pgnumber { get; set; }

    public string? Pgmemo { get; set; }

    public sbyte? Pgfltype { get; set; }

    public decimal? Pgco2 { get; set; }
}
