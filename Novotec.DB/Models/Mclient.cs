using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Mclient
{
    public short Mcident { get; set; }

    public DateTime? Mcdate { get; set; }

    public string Mctitle { get; set; } = null!;

    public string Mcmemo { get; set; } = null!;

    public int Mcnum { get; set; }
}
