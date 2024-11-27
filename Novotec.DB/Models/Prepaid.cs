using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Prepaid
{
    public long Peident { get; set; }

    public DateTime? Pedate { get; set; }

    public long Pewho { get; set; }

    public decimal Peact { get; set; }

    public DateTime? Peactdate { get; set; }

    public decimal Pechange { get; set; }

    public long Pecaident { get; set; }

    public int Pedownload { get; set; }
}
