using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Discprod
{
    public long Dpident { get; set; }

    public DateTime? Dpdate { get; set; }

    public long Dpwho { get; set; }

    public long Dpdiident { get; set; }

    public long Dppbident { get; set; }

    public int Dptype { get; set; }

    public int Dpvaltype { get; set; }

    public decimal Dpquant { get; set; }

    public decimal Dpvalue { get; set; }

    public DateTime Dpvaldat { get; set; }
}
