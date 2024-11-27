using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Storage
{
    public long Stident { get; set; }

    public DateTime? Stdate { get; set; }

    public long Stwho { get; set; }

    public string Sttitle { get; set; } = null!;

    public string Stnumber { get; set; } = null!;

    public string Stmemo { get; set; } = null!;

    public long Stpbident { get; set; }

    public decimal Stmin { get; set; }

    public decimal Stmax { get; set; }

    public decimal Storder { get; set; }

    public decimal Stunit { get; set; }

    public decimal Stminorder { get; set; }

    public byte Stordered { get; set; }

    public DateTime? Stordate { get; set; }

    public DateTime? Stinv { get; set; }

    public byte Stauto { get; set; }

    public decimal Stamount { get; set; }

    public decimal Stamauto { get; set; }

    public DateTime? Stamdate { get; set; }

    public byte Stprobe { get; set; }

    public decimal Stmeasure { get; set; }

    public DateTime? Stmedate { get; set; }

    public byte Stpos { get; set; }

    public byte Stshow { get; set; }

    public int Stnscnum { get; set; }

    public int Stnscinvmon { get; set; }

    public int Stnscinvweek { get; set; }

    public int Stnsctime { get; set; }

    public byte Stlargequ { get; set; }
}
