using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Vfattrib
{
    public long Vfident { get; set; }

    public DateTime? Vfdate { get; set; }

    public long Vfwho { get; set; }

    public string Vftitle { get; set; } = null!;

    public string Vfmemo { get; set; } = null!;
}
