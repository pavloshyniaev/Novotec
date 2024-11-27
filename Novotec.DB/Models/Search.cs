using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Search
{
    public long Seident { get; set; }

    public DateTime? Sedate { get; set; }

    public long Sewho { get; set; }

    public int Selisttype { get; set; }

    public string Sesql { get; set; } = null!;

    public string Secap { get; set; } = null!;

    public byte Seprog { get; set; }

    public byte Seauto { get; set; }

    public string Sememo { get; set; } = null!;
}
