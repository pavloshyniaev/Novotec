using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Error
{
    public long Erident { get; set; }

    public long Erwho { get; set; }

    public DateTime? Erdate { get; set; }

    public int Ertype { get; set; }

    public int Ernum { get; set; }

    public long Erauident { get; set; }

    public long Eraiident { get; set; }

    public string Ermemo { get; set; } = null!;
}
