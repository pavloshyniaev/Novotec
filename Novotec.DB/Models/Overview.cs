using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Overview
{
    public long Ovident { get; set; }

    public DateTime? Ovdate { get; set; }

    public long Ovusident { get; set; }

    public int Ovnum { get; set; }

    public int Ovcolnum { get; set; }

    public string Ovcoltitle { get; set; } = null!;

    public string Ovcolustitle { get; set; } = null!;

    public int Ovcolsize { get; set; }
}
