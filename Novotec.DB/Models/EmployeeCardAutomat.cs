using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class EmployeeCardAutomat
{
    public string Cano { get; set; } = null!;

    public string Cano2 { get; set; } = null!;

    public string Empersno { get; set; } = null!;

    public string Emdrivno { get; set; } = null!;

    public string Adloc { get; set; } = null!;

    public string Adzip { get; set; } = null!;

    public string Adctry { get; set; } = null!;

    public string Adstr { get; set; } = null!;

    public string Adfname1 { get; set; } = null!;

    public string Adlname1 { get; set; } = null!;

    public string Adtitle1 { get; set; } = null!;

    public byte Adgen1 { get; set; }

    public string Adtel1 { get; set; } = null!;

    public string Adtel2 { get; set; } = null!;

    public string Aunumber { get; set; } = null!;

    public string Autitle { get; set; } = null!;

    public long Emcoident { get; set; }
}
