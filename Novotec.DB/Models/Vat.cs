using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Vat
{
    public long Vaident { get; set; }

    public DateTime? Vadate { get; set; }

    public long Vawho { get; set; }

    public decimal Vavat { get; set; }

    public decimal Vavatchg { get; set; }

    public DateTime? Vavatdat { get; set; }

    public byte Vatype { get; set; }

    public string Vanumber { get; set; } = null!;

    public string Vatitle { get; set; } = null!;

    public string Vamemo { get; set; } = null!;
}
