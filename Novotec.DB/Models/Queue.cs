using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Queue
{
    public long Qeident { get; set; }

    public DateTime? Qedate { get; set; }

    public long Qeorident { get; set; }

    public long Qeauident { get; set; }

    public int Qestate { get; set; }

    public long Qerqno { get; set; }

    public string Qedata { get; set; } = null!;

    public int Qecnt { get; set; }

    public long Qeblockno { get; set; }
}
