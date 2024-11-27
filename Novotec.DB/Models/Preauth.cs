using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Preauth
{
    public long Paident { get; set; }

    public DateTime? Padate { get; set; }

    public long Pawho { get; set; }

    public int Pacard { get; set; }

    public int Pacar { get; set; }

    public int Patruck { get; set; }

    public long Paauident { get; set; }

    public int Pareceipt { get; set; }
}
