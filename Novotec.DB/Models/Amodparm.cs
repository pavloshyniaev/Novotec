using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Amodparm
{
    public long Amident { get; set; }

    public DateTime? Amdate { get; set; }

    public long Amwho { get; set; }

    public long Amauident { get; set; }

    public string Amtel { get; set; } = null!;

    public string Amip { get; set; } = null!;

    public string Amipv6 { get; set; } = null!;

    public string Amhostname { get; set; } = null!;

    public string Amsubnet { get; set; } = null!;

    public byte Amcom { get; set; }

    public string Aminit { get; set; } = null!;

    public byte Ampuls { get; set; }

    public string Amcmd { get; set; } = null!;

    public string Amend { get; set; } = null!;

    public int Amport { get; set; }

    public int Amownport { get; set; }

    public byte Amdatabits { get; set; }

    public byte Amparity { get; set; }

    public int Ambaud { get; set; }

    public int Amxmdelay { get; set; }

    public byte Amlrc { get; set; }

    public byte Amterm { get; set; }

    public byte Amupload { get; set; }

    public byte Amdownload { get; set; }

    public byte Amrecrep { get; set; }

    public byte Amtrarep { get; set; }

    public byte Amnackrep { get; set; }

    public byte Amgsm { get; set; }

    public byte Amgprs { get; set; }

    public byte Amprot { get; set; }

    public string Amprotpath { get; set; } = null!;
}
