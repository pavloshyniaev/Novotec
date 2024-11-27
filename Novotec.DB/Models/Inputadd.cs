using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Inputadd
{
    public long Ipident { get; set; }

    public DateTime? Ipdate { get; set; }

    public long Ipwho { get; set; }

    public string Ipnumber { get; set; } = null!;

    public string Iptitle { get; set; } = null!;

    public string Ipmemo { get; set; } = null!;

    public int Iptype { get; set; }
}
