using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboVat
{
    public sbyte? Vaident { get; set; }

    public string? Vadate { get; set; }

    public sbyte? Vawho { get; set; }

    public decimal? Vavat { get; set; }

    public decimal? Vavatchg { get; set; }

    public string? Vavatdat { get; set; }

    public sbyte? Vatype { get; set; }

    public sbyte? Vanumber { get; set; }

    public string? Vatitle { get; set; }

    public string? Vamemo { get; set; }
}
