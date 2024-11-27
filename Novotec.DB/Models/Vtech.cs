using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Vtech
{
    public long Vtident { get; set; }

    public DateTime? Vtdate { get; set; }

    public long Vtwho { get; set; }

    public int Vttank { get; set; }

    public decimal Vtnorm { get; set; }

    public string Vttyresiz1 { get; set; } = null!;

    public string Vttyresiz2 { get; set; } = null!;

    public string Vttyresiz3 { get; set; } = null!;

    public string Vttyresiz4 { get; set; } = null!;

    public string Vttyresiz5 { get; set; } = null!;

    public string Vttyresize { get; set; } = null!;

    public byte Vtsteer1 { get; set; }

    public byte Vtsteer2 { get; set; }

    public byte Vtsteer3 { get; set; }

    public byte Vtsteer4 { get; set; }

    public byte Vtsteer5 { get; set; }

    public byte Vtlift1 { get; set; }

    public byte Vtlift2 { get; set; }

    public byte Vtlift3 { get; set; }

    public byte Vtlift4 { get; set; }

    public byte Vtlift5 { get; set; }

    public byte Vttwin1 { get; set; }

    public byte Vttwin2 { get; set; }

    public byte Vttwin3 { get; set; }

    public byte Vttwin4 { get; set; }

    public byte Vttwin5 { get; set; }

    public int Vtgvw { get; set; }

    public int Vtswl { get; set; }

    public int Vtret { get; set; }

    public int Vtunda { get; set; }

    public string Vtmotor { get; set; } = null!;

    public int Vtmpower { get; set; }

    public int Vtcyclap { get; set; }

    public int Vtseats { get; set; }

    public int Vtstand { get; set; }

    public string Vtmemo { get; set; } = null!;

    public int Vtloadarea { get; set; }

    public int Vthold { get; set; }

    public int Vtloadh { get; set; }

    public int Vtloadw { get; set; }

    public int Vtloadl { get; set; }

    public decimal Vtpos { get; set; }

    public decimal Vtneg { get; set; }

    public int Vtco2 { get; set; }

    public DateTime? Vtdatemaint { get; set; }

    public int Vttankvolminp { get; set; }

    public int Vttankvolmaxp { get; set; }

    public int Vttankh2kg { get; set; }

    public int Vtmintemp { get; set; }

    public int Vtmaxtemp { get; set; }

    public int Vtmaxp { get; set; }

    public int Vtminp { get; set; }

    public int Vth2type { get; set; }
}
