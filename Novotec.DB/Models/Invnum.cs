using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invnum
{
    public long Iuident { get; set; }

    public long Iuwho { get; set; }

    public DateTime? Iudate { get; set; }

    public int Iucurr { get; set; }

    public int Iulength { get; set; }

    public int Iutype { get; set; }

    public string Iuvalue { get; set; } = null!;

    public long Iucnt { get; set; }

    public long Iustart { get; set; }

    public int Iuinc { get; set; }

    public DateTime Iuresdate { get; set; }

    public int Iufiller { get; set; }

    public int Iunotype { get; set; }
}
