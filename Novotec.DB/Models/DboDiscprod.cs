using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboDiscprod
{
    public sbyte? Dpident { get; set; }

    public string? Dpdate { get; set; }

    public sbyte? Dpwho { get; set; }

    public sbyte? Dpdiident { get; set; }

    public short? Dppbident { get; set; }

    public sbyte? Dptype { get; set; }

    public sbyte? Dpvaltype { get; set; }

    public decimal? Dpquant { get; set; }

    public decimal? Dpvalue { get; set; }

    public string? Dpvaldat { get; set; }
}
