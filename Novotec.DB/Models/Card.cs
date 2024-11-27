using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Card
{
    public long Caident { get; set; }

    public DateTime? Cadate { get; set; }

    public long Cawho { get; set; }

    public string Cano { get; set; } = null!;

    public string Cano2 { get; set; } = null!;

    public byte Catype { get; set; }

    public long Caleident { get; set; }

    public long Cacoident { get; set; }

    public long Caveident { get; set; }

    public long Caemident { get; set; }

    public long Cafcident { get; set; }

    public long Castident { get; set; }

    public long Capuident { get; set; }
}
