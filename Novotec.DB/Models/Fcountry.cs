using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Fcountry
{
    public long Foident { get; set; }

    public int Fono { get; set; }

    public string Focode { get; set; } = null!;

    public string Foctry { get; set; } = null!;
}
