using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Aprod
{
    public long Apident { get; set; }

    public DateTime? Apdate { get; set; }

    public long Apwho { get; set; }

    public long Apauident { get; set; }

    public long Appbident { get; set; }

    public int Apintern { get; set; }

    public long Apstident { get; set; }

    public byte Aptank { get; set; }

    public byte Approbe { get; set; }
}
