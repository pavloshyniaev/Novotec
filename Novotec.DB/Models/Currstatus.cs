using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Currstatus
{
    public long Cuident { get; set; }

    public DateTime Cudate { get; set; }

    public int Cutype { get; set; }

    public string Cupinfo { get; set; } = null!;

    public string Custation { get; set; } = null!;

    public int Cuprogno { get; set; }

    public int Cumessid { get; set; }

    public string Cumessage { get; set; } = null!;

    public string Cumemo { get; set; } = null!;

    public int Cucritical { get; set; }
}
