using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Sthistory
{
    public long Shident { get; set; }

    public DateTime? Shdate { get; set; }

    public long Shwho { get; set; }

    public DateTime Shvaldate { get; set; }

    public long Shsrident { get; set; }

    public long Shcoident { get; set; }

    public long Shveident { get; set; }
}
