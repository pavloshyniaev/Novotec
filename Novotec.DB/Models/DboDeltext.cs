using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboDeltext
{
    public sbyte? Dtident { get; set; }

    public string? Dtdate { get; set; }

    public sbyte? Dtwho { get; set; }

    public sbyte? Dttype { get; set; }

    public string? Dttext { get; set; }
}
