using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Cahistory
{
    public long Chident { get; set; }

    public DateTime? Chdate { get; set; }

    public long Chwho { get; set; }

    public long Chcaident { get; set; }

    public long Chleident { get; set; }

    public long Chcoident { get; set; }

    public long Chveident { get; set; }

    public long Chemident { get; set; }

    public long Chfcident { get; set; }
}
