using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboError
{
    public sbyte? Erident { get; set; }

    public sbyte? Erwho { get; set; }

    public string? Erdate { get; set; }

    public sbyte? Ertype { get; set; }

    public sbyte? Ernum { get; set; }

    public sbyte? Erauident { get; set; }

    public sbyte? Eraiident { get; set; }

    public string? Ermemo { get; set; }
}
