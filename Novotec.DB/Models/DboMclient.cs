using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboMclient
{
    public sbyte? Mcident { get; set; }

    public string? Mcdate { get; set; }

    public string? Mctitle { get; set; }

    public string? Mcmemo { get; set; }

    public sbyte? Mcnum { get; set; }
}
