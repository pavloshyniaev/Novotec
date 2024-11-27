using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Inventory
{
    public long Inident { get; set; }

    public DateTime? Indate { get; set; }

    public long Inwho { get; set; }

    public long Instident { get; set; }

    public DateTime? Inindate { get; set; }

    public decimal Inquant { get; set; }

    public long Inpbident { get; set; }

    public decimal Inact { get; set; }

    public decimal Inbuyprice { get; set; }

    public decimal Insellprice { get; set; }

    public decimal Inwbp { get; set; }

    public decimal Innewwbp { get; set; }

    public long Incoident { get; set; }

    public byte Incorr { get; set; }

    public string Inmemo { get; set; } = null!;
}
