using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class VehicleCardAutomat
{
    public string Veplate { get; set; } = null!;

    public string Vevehno { get; set; } = null!;

    public string Veintno { get; set; } = null!;

    public string Cano { get; set; } = null!;

    public long Caveident { get; set; }

    public string Cano2 { get; set; } = null!;

    public string Aunumber { get; set; } = null!;

    public string Autitle { get; set; } = null!;

    public long Vecoident { get; set; }
}
