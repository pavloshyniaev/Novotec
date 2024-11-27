using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Crange
{
    public long Crident { get; set; }

    public long Crwho { get; set; }

    public DateTime Crdate { get; set; }

    public string Crtitle { get; set; } = null!;

    public int Crnumber { get; set; }

    public int Crtype { get; set; }

    public int Crmaxval { get; set; }

    public int Crminval { get; set; }

    public int Crcorr { get; set; }

    public int Crrep { get; set; }

    public string Crmemo { get; set; } = null!;
}
