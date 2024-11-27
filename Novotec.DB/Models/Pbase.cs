using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Pbase
{
    public long Pbident { get; set; }

    public DateTime? Pbdate { get; set; }

    public long Pbwho { get; set; }

    public string Pbtitle { get; set; } = null!;

    public string Pbnumber { get; set; } = null!;

    public string Pbmemo { get; set; } = null!;

    public long Pbpgident { get; set; }

    public long Pbptident { get; set; }

    public string Pbextern { get; set; } = null!;

    public string Pbean { get; set; } = null!;

    public long Pbdispl { get; set; }

    public long Pbvaident { get; set; }

    public int Pbtype { get; set; }

    public byte Pbimport { get; set; }

    public int Pbnscnum { get; set; }

    public string Pbnscrcpt { get; set; } = null!;

    public string Pbnsconlt { get; set; } = null!;

    public string Pbnsconln { get; set; } = null!;

    public int Pbnscptf1 { get; set; }

    public int Pbnscptf2 { get; set; }
}
