using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Ovsort
{
    public long Osident { get; set; }

    public DateTime? Osdate { get; set; }

    public long Osusident { get; set; }

    public int Osovnum { get; set; }

    public string Ostitle { get; set; } = null!;

    public string Ossort1 { get; set; } = null!;

    public string Ossort2 { get; set; } = null!;

    public string Ossort3 { get; set; } = null!;

    public string Ossort4 { get; set; } = null!;

    public string Ossort5 { get; set; } = null!;

    public int Osfilter { get; set; }
}
