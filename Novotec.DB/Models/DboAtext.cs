using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboAtext
{
    public sbyte? Atident { get; set; }

    public string? Atdate { get; set; }

    public sbyte? Atwho { get; set; }

    public sbyte? Atauident { get; set; }

    public sbyte? Atlineno { get; set; }

    public string? Atline { get; set; }

    public sbyte? Atbold { get; set; }

    public sbyte? Attype { get; set; }
}
