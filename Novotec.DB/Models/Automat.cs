using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Automat
{
    public long Auident { get; set; }

    public DateTime? Audate { get; set; }

    public long Auwho { get; set; }

    public string Aunumber { get; set; } = null!;

    public string Autitle { get; set; } = null!;

    public int Aurelease { get; set; }

    public int Aurelsub { get; set; }

    public long Auagident { get; set; }

    public long Aufuident { get; set; }

    public byte Autype { get; set; }

    public byte Auautype { get; set; }

    public string Aumemo { get; set; } = null!;

    public string Ausysno { get; set; } = null!;

    public byte Auactive { get; set; }

    public string Auseries { get; set; } = null!;

    public string Auintern1 { get; set; } = null!;

    public string Auintern2 { get; set; } = null!;

    public long Auifsfaiid { get; set; }

    public string Aucashregisterid { get; set; } = null!;
}
