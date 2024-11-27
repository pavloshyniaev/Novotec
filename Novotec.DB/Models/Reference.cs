using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Reference
{
    public long Reident { get; set; }

    public long Recaident { get; set; }

    public long Reauident { get; set; }

    public byte Redown { get; set; }

    public byte Reatt { get; set; }

    public byte Retype { get; set; }

    public byte Relock { get; set; }

    public byte Repin { get; set; }

    public int Recode { get; set; }

    public string Recodensc { get; set; } = null!;

    public byte Remileage { get; set; }

    public byte Rerange { get; set; }

    public byte Readdin { get; set; }

    public long Reapident { get; set; }

    public long Reapident2 { get; set; }

    public long Reapident3 { get; set; }

    public long Reapident4 { get; set; }

    public long Reapident5 { get; set; }

    public long Reapident6 { get; set; }

    public long Reapident7 { get; set; }

    public long Reapident8 { get; set; }

    public long Reapident9 { get; set; }

    public long Reapident10 { get; set; }

    public int Reapgroup { get; set; }

    public byte Relex { get; set; }

    public byte Resecond { get; set; }

    public byte Relimit { get; set; }

    public byte Remessno { get; set; }

    public int Recc { get; set; }

    public byte Reoffgroup { get; set; }

    public byte Rehh { get; set; }

    public byte Recolstate { get; set; }

    public long Reogident { get; set; }

    public long Recrident { get; set; }

    public byte Redial { get; set; }

    public byte Reprivate { get; set; }

    public DateTime? Revalid { get; set; }

    public DateTime? Reexpire { get; set; }

    public int Requant { get; set; }

    public int Redialog { get; set; }

    public string? Repinonl { get; set; }

    public int Reautocnt { get; set; }
}
