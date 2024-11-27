using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Fcuno
{
    public long Fcident { get; set; }

    public long Fcwho { get; set; }

    public DateTime Fcdate { get; set; }

    public int Fctype { get; set; }

    public string Fcno { get; set; } = null!;
}
