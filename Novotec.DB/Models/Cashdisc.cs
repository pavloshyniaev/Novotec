using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Cashdisc
{
    public long Ciident { get; set; }

    public long Ciwho { get; set; }

    public DateTime? Cidate { get; set; }

    public string Cititle1 { get; set; } = null!;

    public decimal Civalue1 { get; set; }

    public string Cititle2 { get; set; } = null!;

    public decimal Civalue2 { get; set; }

    public string Cititle3 { get; set; } = null!;

    public decimal Civalue3 { get; set; }

    public string Cititle4 { get; set; } = null!;

    public decimal Civalue4 { get; set; }

    public string Cititle5 { get; set; } = null!;

    public decimal Civalue5 { get; set; }
}
