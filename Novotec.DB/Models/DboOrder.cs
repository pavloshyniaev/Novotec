using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboOrder
{
    public int? Orident { get; set; }

    public string? Ordate { get; set; }

    public sbyte? Orauident { get; set; }

    public sbyte? Orstate { get; set; }

    public short? Orrqno { get; set; }

    public short? Ordata { get; set; }

    public sbyte? Orerror { get; set; }

    public sbyte? Orprogno { get; set; }

    public sbyte? Orcnt { get; set; }

    public sbyte? Orwho { get; set; }

    public string? Orstart { get; set; }
}
