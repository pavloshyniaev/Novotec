using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Ptype
{
    public long Ptident { get; set; }

    public DateTime? Ptdate { get; set; }

    public long Ptwho { get; set; }

    public string Pttitle { get; set; } = null!;

    public string Ptnumber { get; set; } = null!;

    public string Ptmemo { get; set; } = null!;

    public long Ptquident { get; set; }

    public int Pttype { get; set; }

    public int Ptfltype { get; set; }
}
