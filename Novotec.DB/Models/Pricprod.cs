using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Pricprod
{
    public long Piident { get; set; }

    public DateTime? Pidate { get; set; }

    public long Piwho { get; set; }

    public long Piprident { get; set; }

    public long Pipbident { get; set; }

    public int Pitype { get; set; }

    public int Pivaltype { get; set; }

    public decimal Pivalue { get; set; }

    public DateTime Pivaldat { get; set; }
}
