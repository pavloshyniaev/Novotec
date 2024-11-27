using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Nscspec
{
    public long Nsident { get; set; }

    public DateTime Nsdate { get; set; }

    public long Nswho { get; set; }

    public long Nsauident { get; set; }

    public string Nscalsum { get; set; } = null!;

    public DateTime? Nscaldate { get; set; }

    public string Nscalstr { get; set; } = null!;

    public string Nshwstr { get; set; } = null!;

    public int Nstprice { get; set; }

    public int Nstintern { get; set; }

    public string Nsdial1 { get; set; } = null!;

    public string Nsdial2 { get; set; } = null!;

    public string Nsdial3 { get; set; } = null!;

    public string Nsdial4 { get; set; } = null!;

    public string Nsdial5 { get; set; } = null!;

    public int Nstype1 { get; set; }

    public int Nstype2 { get; set; }

    public int Nstype3 { get; set; }

    public int Nstype4 { get; set; }

    public int Nstype5 { get; set; }

    public int Nsclocktime { get; set; }

    public int Nsnochange { get; set; }
}
