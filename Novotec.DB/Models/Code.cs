using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Code
{
    public long Cdident { get; set; }

    public DateTime Cddate { get; set; }

    public long Cdauident { get; set; }

    public long Cdcano { get; set; }

    public int Cdcode { get; set; }
}
