using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Company
{
    public long Coident { get; set; }

    public DateTime? Codate { get; set; }

    public long Cowho { get; set; }

    public byte Cotype { get; set; }

    public string Cocono1 { get; set; } = null!;

    public string Cocono2 { get; set; } = null!;

    public string Cotitle1 { get; set; } = null!;

    public string Cotitle2 { get; set; } = null!;

    public string Cotitle3 { get; set; } = null!;

    public string Comemo { get; set; } = null!;

    public long Coadident { get; set; }

    public DateTime? Coend { get; set; }

    public string Costate { get; set; } = null!;

    public long Coieident { get; set; }

    public string Comanager1 { get; set; } = null!;

    public string Comanager2 { get; set; } = null!;

    public string Comanager3 { get; set; } = null!;

    public string Coregcourt { get; set; } = null!;

    public string Coname { get; set; } = null!;

    public string Couci { get; set; } = null!;

    public long Copuident { get; set; }
}
