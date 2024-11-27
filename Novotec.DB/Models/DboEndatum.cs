using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboEndatum
{
    public short? Enident { get; set; }

    public string? Endate { get; set; }

    public sbyte? Enauident { get; set; }

    public sbyte? Enlineno { get; set; }

    public string? Enline { get; set; }
}
