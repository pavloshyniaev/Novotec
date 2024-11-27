using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboPricprod
{
    public short? Piident { get; set; }

    public string? Pidate { get; set; }

    public sbyte? Piwho { get; set; }

    public sbyte? Piprident { get; set; }

    public short? Pipbident { get; set; }

    public sbyte? Pitype { get; set; }

    public sbyte? Pivaltype { get; set; }

    public decimal? Pivalue { get; set; }

    public string? Pivaldat { get; set; }
}
