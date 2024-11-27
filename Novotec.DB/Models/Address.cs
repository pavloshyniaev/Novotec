using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Address
{
    public long Adident { get; set; }

    public long Adwho { get; set; }

    public DateTime? Addate { get; set; }

    public byte Adtype { get; set; }

    public string Adloc { get; set; } = null!;

    public string Adzip { get; set; } = null!;

    public string Adctry { get; set; } = null!;

    public string Adstr { get; set; } = null!;

    public string Adhp { get; set; } = null!;

    public string Adpb { get; set; } = null!;

    public string Adfname1 { get; set; } = null!;

    public string Adlname1 { get; set; } = null!;

    public string Adtitle1 { get; set; } = null!;

    public byte Adgen1 { get; set; }

    public string Adtel1 { get; set; } = null!;

    public string Adtel2 { get; set; } = null!;

    public string Adfax1 { get; set; } = null!;

    public string Ademail1 { get; set; } = null!;

    public string Adfname2 { get; set; } = null!;

    public string Adlname2 { get; set; } = null!;

    public string Adtitle2 { get; set; } = null!;

    public byte Adgen2 { get; set; }

    public string Adtel3 { get; set; } = null!;

    public string Adtel4 { get; set; } = null!;

    public string Adfax2 { get; set; } = null!;

    public string Ademail2 { get; set; } = null!;

    public string Adbank1 { get; set; } = null!;

    public string Adroutno1 { get; set; } = null!;

    public string Adiban1 { get; set; } = null!;

    public string Adacc1 { get; set; } = null!;

    public string Adibc1 { get; set; } = null!;

    public string Adbank2 { get; set; } = null!;

    public string Adroutno2 { get; set; } = null!;

    public string Adiban2 { get; set; } = null!;

    public string Adacc2 { get; set; } = null!;

    public string Adibc2 { get; set; } = null!;

    public string Adbank3 { get; set; } = null!;

    public string Adroutno3 { get; set; } = null!;

    public string Adiban3 { get; set; } = null!;

    public string Adacc3 { get; set; } = null!;

    public string Adibc3 { get; set; } = null!;

    public string Adbank4 { get; set; } = null!;

    public string Adroutno4 { get; set; } = null!;

    public string Adiban4 { get; set; } = null!;

    public string Adacc4 { get; set; } = null!;

    public string Adibc4 { get; set; } = null!;

    public string Adbank5 { get; set; } = null!;

    public string Adroutno5 { get; set; } = null!;

    public string Adiban5 { get; set; } = null!;

    public string Adacc5 { get; set; } = null!;

    public string Adibc5 { get; set; } = null!;

    public long Adxxident { get; set; }

    public string Advatid { get; set; } = null!;

    public string Adtaxid { get; set; } = null!;
}
