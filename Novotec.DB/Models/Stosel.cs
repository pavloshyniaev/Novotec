using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Stosel
{
    public long Soident { get; set; }

    public long Sousident { get; set; }

    public long Sostident { get; set; }

    public int Sopos { get; set; }

    public int Soactive { get; set; }
}
