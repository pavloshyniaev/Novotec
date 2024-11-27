using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Aactive
{
    public long Aaident { get; set; }

    public long Aaauident { get; set; }

    public byte Aastate { get; set; }

    public DateTime? Aastart { get; set; }

    public int Aaidle { get; set; }

    public int Aalstart { get; set; }

    public int Aalend { get; set; }

    public DateTime Aadstart { get; set; }

    public DateTime Aadend { get; set; }
}
