using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Event
{
    public long Evident { get; set; }

    public long Evwho { get; set; }

    public DateTime? Evdate { get; set; }

    public DateTime Evstart { get; set; }

    public DateTime Evend { get; set; }

    public string Evsubject { get; set; } = null!;

    public int Evstate { get; set; }

    public string Evdescr { get; set; } = null!;

    public int Evlabel { get; set; }

    public long Evlabelid { get; set; }

    public string Evlocation { get; set; } = null!;

    public byte Evallday { get; set; }

    public int Evevtype { get; set; }

    public string Evrecurr { get; set; } = null!;

    public string Evremind { get; set; } = null!;

    public long Evveident { get; set; }

    public long Evemident { get; set; }

    public string Evdone { get; set; } = null!;

    public DateTime Evdonedate { get; set; }

    public long Evemid { get; set; }

    public int Evconfirm { get; set; }

    public int Evdays { get; set; }

    public int Evmiles { get; set; }

    public int Evoffmiles { get; set; }

    public decimal Evhours { get; set; }

    public decimal Evoffhours { get; set; }

    public int Evtype { get; set; }

    public decimal Evhrecurr { get; set; }

    public decimal Evhdone { get; set; }

    public int Evmrecurr { get; set; }

    public int Evmdone { get; set; }

    public int Evrectype { get; set; }
}
