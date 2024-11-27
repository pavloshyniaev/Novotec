using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Enfuel
{
    public long Efident { get; set; }

    public DateTime Efdate { get; set; }

    public long Efauident { get; set; }

    public int Eflineno { get; set; }

    public string Efline { get; set; } = null!;
}
