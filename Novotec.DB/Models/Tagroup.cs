using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Tagroup
{
    public long Taident { get; set; }

    public long Tawho { get; set; }

    public DateTime? Tadate { get; set; }

    public int Tano { get; set; }

    public string Tatitle { get; set; } = null!;
}
