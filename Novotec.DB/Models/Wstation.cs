using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Wstation
{
    public long Wsident { get; set; }

    public DateTime Wsdate { get; set; }

    public string Wsws { get; set; } = null!;

    public long Wswho { get; set; }
}
