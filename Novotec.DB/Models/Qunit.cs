using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Qunit
{
    public long Quident { get; set; }

    public DateTime? Qudate { get; set; }

    public long Quwho { get; set; }

    public string Qutitle { get; set; } = null!;

    public string Qunumber { get; set; } = null!;

    public string Qumemo { get; set; } = null!;

    public int Qufltype { get; set; }
}
