using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboLevel
{
    public short? Leident { get; set; }

    public string? Ledate { get; set; }

    public sbyte? Lewho { get; set; }

    public sbyte? Lelevel { get; set; }

    public string? Letext { get; set; }

    public sbyte? Letype { get; set; }

    public sbyte? Lemenu { get; set; }
}
