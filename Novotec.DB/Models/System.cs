using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class System
{
    public long Syident { get; set; }

    public DateTime Sydate { get; set; }

    public long Sywho { get; set; }

    public int Symaid { get; set; }

    public int Sycnt { get; set; }

    public int Syyear { get; set; }

    public int Syibancheck { get; set; }

    public int Syctryno { get; set; }

    public int Sypain { get; set; }

    public int Sysendsepa { get; set; }

    public int Syattachin { get; set; }

    public int Sysepa { get; set; }

    public string Sysmtp { get; set; } = null!;

    public string Syfrom { get; set; } = null!;

    public string Syuser { get; set; } = null!;

    public string Sypw { get; set; } = null!;

    public int Syport { get; set; }

    public int Syssl { get; set; }

    public string Sytext { get; set; } = null!;
}
