using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Tlabel
{
    public long Tlident { get; set; }

    public long Tlwho { get; set; }

    public DateTime? Tldate { get; set; }

    public int Tlid { get; set; }

    public string Tlcolor { get; set; } = null!;

    public string Tltext { get; set; } = null!;

    public string Tlmemo { get; set; } = null!;

    public int Tlstype { get; set; }
}
