using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboOverview
{
    public short? Ovident { get; set; }

    public string? Ovdate { get; set; }

    public sbyte? Ovusident { get; set; }

    public int? Ovnum { get; set; }

    public sbyte? Ovcolnum { get; set; }

    public string? Ovcoltitle { get; set; }

    public string? Ovcolustitle { get; set; }

    public short? Ovcolsize { get; set; }
}
