using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Response
{
    public long Rsident { get; set; }

    public DateTime? Rsdate { get; set; }

    public long Rsorident { get; set; }

    public long Rsauident { get; set; }

    public int Rsstate { get; set; }

    public string Rsdata { get; set; } = null!;

    public long Rsrqno { get; set; }
}
