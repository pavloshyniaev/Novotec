using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Login
{
    public long Loident { get; set; }

    public DateTime? Lodate { get; set; }

    public long Lowho { get; set; }

    public string Loadmin { get; set; } = null!;

    public string Lotype { get; set; } = null!;

    public string Loprog { get; set; } = null!;
}
