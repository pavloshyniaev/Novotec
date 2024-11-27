using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Structure
{
    public long Srident { get; set; }

    public DateTime? Srdate { get; set; }

    public long Srwho { get; set; }

    public string Srnumber { get; set; } = null!;

    public string Srtitle { get; set; } = null!;

    public string Srmemo { get; set; } = null!;

    public long Sradident { get; set; }

    public long Srsrident { get; set; }

    public int Srlevel { get; set; }

    public int Srimage { get; set; }

    public int Srhlevel { get; set; }
}
