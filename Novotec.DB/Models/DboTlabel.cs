using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboTlabel
{
    public sbyte? Tlident { get; set; }

    public sbyte? Tlwho { get; set; }

    public string? Tldate { get; set; }

    public sbyte? Tlid { get; set; }

    public int? Tlcolor { get; set; }

    public string? Tltext { get; set; }

    public string? Tlmemo { get; set; }

    public sbyte? Tlstype { get; set; }
}
