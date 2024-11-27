using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboQueue
{
    public int? Qeident { get; set; }

    public string? Qedate { get; set; }

    public int? Qeorident { get; set; }

    public sbyte? Qeauident { get; set; }

    public sbyte? Qestate { get; set; }

    public short? Qerqno { get; set; }

    public string? Qedata { get; set; }

    public sbyte? Qecnt { get; set; }

    public sbyte? Qeblockno { get; set; }
}
