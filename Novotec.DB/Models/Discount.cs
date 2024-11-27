using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Discount
{
    public long Diident { get; set; }

    public DateTime? Didate { get; set; }

    public long Diwho { get; set; }

    public string Dititle { get; set; } = null!;

    public int Ditype { get; set; }
}
