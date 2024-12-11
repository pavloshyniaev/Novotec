using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Card
{
    public long Caident { get; set; } // card id

    public DateTime? Cadate { get; set; }

    public long Cawho { get; set; }

    public string Cano { get; set; } = null!; // card number

    public string Cano2 { get; set; } = null!; // card number

    public byte Catype { get; set; } // 0 - vehicle, 1 - employee

    public long Caleident { get; set; }

    public long Cacoident { get; set; }

    public long Caveident { get; set; } // vehicle id

    public long Caemident { get; set; } // employee id

    public long Cafcident { get; set; }

    public long Castident { get; set; }

    public long Capuident { get; set; }
}
