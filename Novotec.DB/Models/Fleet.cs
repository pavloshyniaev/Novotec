using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Fleet
{
    public long Feident { get; set; }

    public int Feno { get; set; }

    public string Fetitle { get; set; } = null!;
}
