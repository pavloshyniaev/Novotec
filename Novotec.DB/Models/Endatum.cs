using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Endatum
{
    public long Enident { get; set; }

    public DateTime Endate { get; set; }

    public long Enauident { get; set; }

    public int Enlineno { get; set; }

    public string Enline { get; set; } = null!;
}
