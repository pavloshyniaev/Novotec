using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Levelmeter
{
    public long Lmident { get; set; }

    public DateTime? Lmdate { get; set; }

    public long Lmwho { get; set; }

    public string Lmtitle { get; set; } = null!;

    public string Lmnumber { get; set; } = null!;

    public long Lmauident { get; set; }

    public int Lmformat { get; set; }

    public long Lmstident01 { get; set; }

    public long Lmstident02 { get; set; }

    public long Lmstident03 { get; set; }

    public long Lmstident04 { get; set; }

    public long Lmstident05 { get; set; }

    public long Lmstident06 { get; set; }

    public long Lmstident07 { get; set; }

    public long Lmstident08 { get; set; }

    public long Lmstident09 { get; set; }

    public long Lmstident10 { get; set; }

    public int Lmpos01 { get; set; }

    public int Lmpos02 { get; set; }

    public int Lmpos03 { get; set; }

    public int Lmpos04 { get; set; }

    public int Lmpos05 { get; set; }

    public int Lmpos06 { get; set; }

    public int Lmpos07 { get; set; }

    public int Lmpos08 { get; set; }

    public int Lmpos09 { get; set; }

    public int Lmpos10 { get; set; }

    public int Lmbaud { get; set; }

    public int Lmport { get; set; }

    public int Lmactive { get; set; }

    public int Lmprottype { get; set; }

    public int Lmheight { get; set; }
}
