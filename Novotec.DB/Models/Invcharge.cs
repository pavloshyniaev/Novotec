using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invcharge
{
    public long Icident { get; set; }

    public long Icwho { get; set; }

    public DateTime? Icdate { get; set; }

    public string Ictitle1 { get; set; } = null!;

    public decimal Icvalue1 { get; set; }

    public string Ictitle2 { get; set; } = null!;

    public decimal Icvalue2 { get; set; }

    public string Ictitle3 { get; set; } = null!;

    public decimal Icvalue3 { get; set; }

    public string Ictitle4 { get; set; } = null!;

    public decimal Icvalue4 { get; set; }

    public string Ictitle5 { get; set; } = null!;

    public decimal Icvalue5 { get; set; }

    public long Icpbident { get; set; }
}
