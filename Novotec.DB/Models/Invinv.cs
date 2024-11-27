using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invinv
{
    public long Iiident { get; set; }

    public long Iiwho { get; set; }

    public DateTime Iidate { get; set; }

    public decimal Iigross { get; set; }

    public decimal Iinet { get; set; }

    public decimal Iidisc { get; set; }

    public decimal Iivat { get; set; }

    public int Iicnt { get; set; }

    public DateTime? Iidtadate { get; set; }

    public int Iibdisk { get; set; }
}
