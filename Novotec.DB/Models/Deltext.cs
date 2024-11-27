using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Deltext
{
    public long Dtident { get; set; }

    public DateTime? Dtdate { get; set; }

    public long Dtwho { get; set; }

    public int Dttype { get; set; }

    public string Dttext { get; set; } = null!;
}
