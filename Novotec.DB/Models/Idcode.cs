using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Idcode
{
    public long Idident { get; set; }

    public long Idwho { get; set; }

    public DateTime? Iddate { get; set; }

    public string Idtitle { get; set; } = null!;

    public string Idnumber { get; set; } = null!;

    public int Idcard { get; set; }

    public string Idcode1 { get; set; } = null!;

    public int Idpos1 { get; set; }

    public int Idposi1 { get; set; }

    public int Idlen1 { get; set; }

    public string Idcode2 { get; set; } = null!;

    public int Idpos2 { get; set; }

    public int Idposi2 { get; set; }

    public int Idlen2 { get; set; }

    public string Idcode3 { get; set; } = null!;

    public int Idpos3 { get; set; }

    public int Idposi3 { get; set; }

    public int Idlen3 { get; set; }

    public string Idcode4 { get; set; } = null!;

    public int Idpos4 { get; set; }

    public int Idposi4 { get; set; }

    public int Idlen4 { get; set; }

    public string Idcode5 { get; set; } = null!;

    public int Idpos5 { get; set; }

    public int Idposi5 { get; set; }

    public int Idlen5 { get; set; }

    public int Idtype { get; set; }

    public int Idlenpin { get; set; }

    public int Idfunpin { get; set; }

    public int Idoffset { get; set; }

    public int Idcon0 { get; set; }

    public int Idcon1 { get; set; }

    public int Idcon2 { get; set; }

    public int Idcon3 { get; set; }

    public int Idcon4 { get; set; }

    public int Idcon5 { get; set; }

    public int Idcon6 { get; set; }

    public int Idcntpos { get; set; }

    public string Idcntval { get; set; } = null!;

    public int Idcnttype { get; set; }

    public int Idcntlen { get; set; }

    public int Idpinpos { get; set; }

    public string Idpinval { get; set; } = null!;

    public int Idpintype { get; set; }

    public int Idpinlen { get; set; }

    public int Idinflen { get; set; }

    public int Idinfpos { get; set; }

    public string Idinfval { get; set; } = null!;

    public int Idinftype { get; set; }

    public int Idaddlen { get; set; }

    public int Idaddpos { get; set; }

    public string Idaddval { get; set; } = null!;

    public int Idaddtype { get; set; }

    public string Idmemo { get; set; } = null!;
}
