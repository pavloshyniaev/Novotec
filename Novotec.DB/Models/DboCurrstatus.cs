using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboCurrstatus
{
    public int? Cuident { get; set; }

    public string? Cudate { get; set; }

    public sbyte? Cutype { get; set; }

    public string? Cupinfo { get; set; }

    public string? Custation { get; set; }

    public short? Cuprogno { get; set; }

    public short? Cumessid { get; set; }

    public string? Cumessage { get; set; }

    public string? Cumemo { get; set; }

    public sbyte? Cucritical { get; set; }
}
