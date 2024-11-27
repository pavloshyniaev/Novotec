using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboInvcharge
{
    public sbyte? Icident { get; set; }

    public sbyte? Icwho { get; set; }

    public string? Icdate { get; set; }

    public string? Ictitle1 { get; set; }

    public decimal? Icvalue1 { get; set; }

    public string? Ictitle2 { get; set; }

    public decimal? Icvalue2 { get; set; }

    public string? Ictitle3 { get; set; }

    public decimal? Icvalue3 { get; set; }

    public string? Ictitle4 { get; set; }

    public decimal? Icvalue4 { get; set; }

    public string? Ictitle5 { get; set; }

    public decimal? Icvalue5 { get; set; }

    public short? Icpbident { get; set; }
}
