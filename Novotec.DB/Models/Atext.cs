using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Atext
{
    public long Atident { get; set; }

    public DateTime? Atdate { get; set; }

    public long Atwho { get; set; }

    public long Atauident { get; set; }

    public byte Atlineno { get; set; }

    public string Atline { get; set; } = null!;

    public byte Atbold { get; set; }

    public byte Attype { get; set; }
}
