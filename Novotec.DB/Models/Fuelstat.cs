using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Fuelstat
{
    public long Fuident { get; set; }

    public DateTime? Fudate { get; set; }

    public long Fuwho { get; set; }

    public string Futitle { get; set; } = null!;

    public string Futitle2 { get; set; } = null!;

    public string Futitle3 { get; set; } = null!;

    public byte Futype { get; set; }

    public string Funumber { get; set; } = null!;

    public long Fuadident { get; set; }

    public string Fumemo { get; set; } = null!;

    public string Fuintno { get; set; } = null!;

    public string Fuintno2 { get; set; } = null!;

    public string Fuintno3 { get; set; } = null!;

    public string Fuintno4 { get; set; } = null!;

    public long Fusrident { get; set; }
}
