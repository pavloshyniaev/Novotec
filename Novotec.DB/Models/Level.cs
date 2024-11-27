using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Level
{
    public long Leident { get; set; }

    public DateTime? Ledate { get; set; }

    public long Lewho { get; set; }

    public int Lelevel { get; set; }

    public string Letext { get; set; } = null!;

    public int Letype { get; set; }

    public byte Lemenu { get; set; }
}
