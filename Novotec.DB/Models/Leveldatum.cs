using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Leveldatum
{
    public long Ldident { get; set; }

    public DateTime? Lddate { get; set; }

    public DateTime? Lddate2 { get; set; }

    public int Ldprobe { get; set; }

    public long Ldauident { get; set; }

    public int Ldtemp { get; set; }

    public int Ldplevel { get; set; }

    public int Ldwlevel { get; set; }

    public int Lddensity { get; set; }
}
