using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Order
{
    public long Orident { get; set; }

    public DateTime? Ordate { get; set; }

    public long Orauident { get; set; }

    public byte Orstate { get; set; }

    public long Orrqno { get; set; }

    public string Ordata { get; set; } = null!;

    public int Orerror { get; set; }

    public int Orprogno { get; set; }

    public int Orcnt { get; set; }

    public long? Orwho { get; set; }

    public DateTime? Orstart { get; set; }
}
