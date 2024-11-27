using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Zvt
{
    public long Zvident { get; set; }

    public DateTime Zvdate { get; set; }

    public string Zvtitle { get; set; } = null!;

    public int Zvtype { get; set; }

    public int Zvshow { get; set; }
}
