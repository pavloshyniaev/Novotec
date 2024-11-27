using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Vcharac
{
    public long Vcident { get; set; }

    public DateTime? Vcdate { get; set; }

    public long Vcwho { get; set; }

    public string Vcnumber { get; set; } = null!;

    public string Vctitle { get; set; } = null!;

    public string Vcmemo { get; set; } = null!;

    public long Vcvfident { get; set; }
}
