using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Sysprop
{
    public long Soident { get; set; }

    public DateTime Sodate { get; set; }

    public long Sowho { get; set; }

    public string Sotitle { get; set; } = null!;

    public string Soval { get; set; } = null!;
}
