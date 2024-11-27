using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboLogin
{
    public int? Loident { get; set; }

    public string? Lodate { get; set; }

    public sbyte? Lowho { get; set; }

    public sbyte? Loadmin { get; set; }

    public sbyte? Lotype { get; set; }

    public string? Loprog { get; set; }
}
