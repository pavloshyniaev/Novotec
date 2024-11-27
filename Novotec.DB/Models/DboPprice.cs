using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboPprice
{
    public sbyte? Ppident { get; set; }

    public string? Ppdate { get; set; }

    public sbyte? Ppwho { get; set; }

    public sbyte? Pppbident { get; set; }

    public sbyte? Pptype { get; set; }

    public decimal? Ppprice { get; set; }

    public string? Ppeffdate { get; set; }

    public decimal? Ppvat { get; set; }

    public sbyte? Ppvaident { get; set; }

    public sbyte? Ppfuident { get; set; }
}
