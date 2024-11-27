using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Adisp
{
    public long Aiident { get; set; }

    public DateTime? Aidate { get; set; }

    public long Aiwho { get; set; }

    public long Aiauident { get; set; }

    public byte Ainum { get; set; }

    public byte Aistate { get; set; }

    public byte Aishow { get; set; }

    public byte Aiextern { get; set; }

    public int Aimaxtime { get; set; }

    public int Aimaxam { get; set; }

    public int Aiimp { get; set; }

    public decimal Aicorr { get; set; }

    public long Aitube1 { get; set; }

    public long Aitube2 { get; set; }

    public long Aitube3 { get; set; }

    public long Aitube4 { get; set; }

    public long Aitube5 { get; set; }

    public long Aitube6 { get; set; }

    public long Aitube7 { get; set; }

    public long Aitube8 { get; set; }

    public long Aitube9 { get; set; }

    public long Aitube10 { get; set; }

    public long Aistore1 { get; set; }

    public long Aistore2 { get; set; }

    public long Aistore3 { get; set; }

    public long Aistore4 { get; set; }

    public long Aistore5 { get; set; }

    public long Aistore6 { get; set; }

    public long Aistore7 { get; set; }

    public long Aistore8 { get; set; }

    public long Aistore9 { get; set; }

    public long Aistore10 { get; set; }

    public byte Airef1 { get; set; }

    public byte Airef2 { get; set; }

    public byte Airef3 { get; set; }

    public byte Airef4 { get; set; }

    public byte Airef5 { get; set; }

    public byte Airef6 { get; set; }

    public byte Airef7 { get; set; }

    public byte Airef8 { get; set; }

    public byte Airef9 { get; set; }

    public byte Airef10 { get; set; }

    public decimal Ainscmaxam { get; set; }

    public int Ainscdelay { get; set; }

    public int Ainscbundle1 { get; set; }

    public int Ainscbundle2 { get; set; }

    public int Ainscbundle3 { get; set; }

    public int Ainscmaxdur { get; set; }

    public int Ainscctrl { get; set; }

    public int Ainscstate { get; set; }

    public int Ainscerr { get; set; }

    public int Ailonnode { get; set; }

    public int Ailonside { get; set; }

    public int Aitypelon { get; set; }

    public int Aidispquant { get; set; }

    public decimal Ainscmaxquant { get; set; }

    public string Aiextref { get; set; } = null!;
}
