using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Cash
{
    public long Csident { get; set; }

    public long Cswho { get; set; }

    public DateTime? Csdate { get; set; }

    public long? Csprident { get; set; }

    public decimal Csquant { get; set; }

    public decimal Csprice { get; set; }

    public decimal Cslprice { get; set; }

    public int Cscatype { get; set; }

    public int Csrecn1 { get; set; }

    public int Csrecn2 { get; set; }

    public int Csprotno { get; set; }

    public long Csaiident { get; set; }

    public long Csauident { get; set; }

    public long Csstident { get; set; }
}
