using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Pricing
{
    public long Prident { get; set; }

    public DateTime? Prdate { get; set; }

    public long Prwho { get; set; }

    public string Prtitle { get; set; } = null!;
}
