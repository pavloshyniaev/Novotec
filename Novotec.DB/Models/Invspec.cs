using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invspec
{
    public long Ieident { get; set; }

    public long Iewho { get; set; }

    public DateTime? Iedate { get; set; }

    public string Ietitle { get; set; } = null!;

    public int Ieintype { get; set; }

    public int Ietardays { get; set; }

    public int Iepayment { get; set; }

    public string Iepaytext { get; set; } = null!;

    public int Ieprint { get; set; }

    public int Ietype { get; set; }

    public int Iecharge { get; set; }

    public int Iecdisc { get; set; }

    public int Iecdisctar { get; set; }

    public long Ieprident { get; set; }

    public long Iediident { get; set; }

    public int Ieintern { get; set; }
}
