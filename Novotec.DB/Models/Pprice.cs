using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Pprice
{
    public long Ppident { get; set; }

    public DateTime? Ppdate { get; set; }

    public long Ppwho { get; set; }

    public long Pppbident { get; set; }

    public byte Pptype { get; set; }

    public decimal Ppprice { get; set; }

    public DateTime? Ppeffdate { get; set; }

    public decimal Ppvat { get; set; }

    public long Ppvaident { get; set; }

    public long Ppfuident { get; set; }
}
