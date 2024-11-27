using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboPtype
{
    public sbyte? Ptident { get; set; }

    public string? Ptdate { get; set; }

    public sbyte? Ptwho { get; set; }

    public string? Pttitle { get; set; }

    public string? Ptnumber { get; set; }

    public string? Ptmemo { get; set; }

    public sbyte? Ptquident { get; set; }

    public sbyte? Pttype { get; set; }

    public sbyte? Ptfltype { get; set; }
}
