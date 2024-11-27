using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Tstatus
{
    public long Tsident { get; set; }

    public long Tswho { get; set; }

    public DateTime? Tsdate { get; set; }

    public int Tsid { get; set; }

    public string Tscolor { get; set; } = null!;

    public string Tstext { get; set; } = null!;

    public string Tsmemo { get; set; } = null!;

    public string Tstype { get; set; } = null!;
}
