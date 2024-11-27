using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Alimit
{
    public long Alident { get; set; }

    public DateTime? Aldate { get; set; }

    public long Alwho { get; set; }

    public long Alauident { get; set; }

    public byte Altype { get; set; }

    public int Allimit1 { get; set; }

    public int Allimit2 { get; set; }

    public int Allimit3 { get; set; }

    public int Allimit4 { get; set; }

    public int Allimit5 { get; set; }

    public int Allimit6 { get; set; }

    public int Allimit7 { get; set; }
}
