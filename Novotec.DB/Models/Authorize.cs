using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Authorize
{
    public long Ahident { get; set; }

    public DateTime? Ahdate { get; set; }

    public long Ahwho { get; set; }

    public string Ahtitle { get; set; } = null!;

    public int Ahpg1 { get; set; }

    public int Ahpg2 { get; set; }

    public int Ahpg3 { get; set; }

    public int Ahpg4 { get; set; }

    public int Ahpg5 { get; set; }

    public int Ahpg6 { get; set; }

    public int Ahpg7 { get; set; }

    public int Ahpg8 { get; set; }

    public int Ahpg9 { get; set; }

    public int Ahpg10 { get; set; }
}
