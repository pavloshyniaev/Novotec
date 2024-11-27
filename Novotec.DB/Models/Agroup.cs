using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Agroup
{
    public long Agident { get; set; }

    public DateTime? Agdate { get; set; }

    public long Agwho { get; set; }

    public string Agtitle { get; set; } = null!;

    public string Agnumber { get; set; } = null!;

    public string Agmemo { get; set; } = null!;
}
