using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Svaccdriv
{
    public long Saident { get; set; }

    public long Saemident { get; set; }

    public long Saauident { get; set; }

    public int Saaccount { get; set; }

    public string Sadrvno { get; set; } = null!;

    public int Sapin { get; set; }
}
