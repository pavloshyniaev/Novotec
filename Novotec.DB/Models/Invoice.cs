using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invoice
{
    public long Ivident { get; set; }

    public long Iviiident { get; set; }

    public string Ivno { get; set; } = null!;

    public int Ivprint { get; set; }

    public DateTime? Ividate { get; set; }

    public int Ivcnt { get; set; }

    public DateTime? Ivcancdat { get; set; }

    public int Ivcancel { get; set; }

    public long Ivcoident { get; set; }

    public string Ivcuno1 { get; set; } = null!;

    public string Ivcuno2 { get; set; } = null!;

    public string Ivcutitle1 { get; set; } = null!;

    public string Ivcutitle2 { get; set; } = null!;

    public string Ivcutitle3 { get; set; } = null!;

    public string Ivcuname { get; set; } = null!;

    public string Ivcuctry { get; set; } = null!;

    public string Ivcuzip { get; set; } = null!;

    public string Ivcucity { get; set; } = null!;

    public string Ivcustr { get; set; } = null!;

    public string Ivcutel { get; set; } = null!;

    public string Ivcufax { get; set; } = null!;

    public string Ivcuhp { get; set; } = null!;

    public string Ivcuemail { get; set; } = null!;

    public string Ivcupb { get; set; } = null!;

    public string Ivcubank { get; set; } = null!;

    public string Ivcuroutno { get; set; } = null!;

    public string Ivcuban { get; set; } = null!;

    public string Ivcuibc { get; set; } = null!;

    public string Ivcuacc { get; set; } = null!;

    public string Ivcuvatid { get; set; } = null!;

    public string Ivistitle1 { get; set; } = null!;

    public string Ivistitle2 { get; set; } = null!;

    public string Ivistitle3 { get; set; } = null!;

    public string Ivisctry { get; set; } = null!;

    public string Iviszip { get; set; } = null!;

    public string Iviscity { get; set; } = null!;

    public string Ivisstr { get; set; } = null!;

    public string Ivistel { get; set; } = null!;

    public string Ivisfax { get; set; } = null!;

    public string Ivishp { get; set; } = null!;

    public string Ivisemail { get; set; } = null!;

    public string Ivispb { get; set; } = null!;

    public string Ivistext { get; set; } = null!;

    public string Ivisbank1 { get; set; } = null!;

    public string Ivisroutno1 { get; set; } = null!;

    public string Ivisban1 { get; set; } = null!;

    public string Ivisibc1 { get; set; } = null!;

    public string Ivisacc1 { get; set; } = null!;

    public string Ivisbank2 { get; set; } = null!;

    public string Ivisroutno2 { get; set; } = null!;

    public string Ivisban2 { get; set; } = null!;

    public string Ivisibc2 { get; set; } = null!;

    public string Ivisacc2 { get; set; } = null!;

    public string Ivisbank3 { get; set; } = null!;

    public string Ivisroutno3 { get; set; } = null!;

    public string Ivisban3 { get; set; } = null!;

    public string Ivisibc3 { get; set; } = null!;

    public string Ivisacc3 { get; set; } = null!;

    public string Ivisvatid { get; set; } = null!;

    public decimal Ivspnet { get; set; }

    public decimal Ivspgross { get; set; }

    public decimal Ivppnet { get; set; }

    public decimal Ivppgross { get; set; }

    public decimal Ivinvtotal { get; set; }

    public decimal Ivdiscount { get; set; }

    public decimal Ivdiscspnet { get; set; }

    public decimal Ivcashd { get; set; }

    public decimal Ivcashdv { get; set; }

    public DateTime? Ivcashdtar { get; set; }

    public DateTime? Ivtardate { get; set; }

    public DateTime? Ivpaydate { get; set; }

    public int Ivpaytype { get; set; }

    public decimal Ivvat1 { get; set; }

    public decimal Ivvatval1 { get; set; }

    public decimal Ivvatval1n { get; set; }

    public decimal Ivvattot1 { get; set; }

    public decimal Ivvatdisc1 { get; set; }

    public decimal Ivvat2 { get; set; }

    public decimal Ivvatval2 { get; set; }

    public decimal Ivvatval2n { get; set; }

    public decimal Ivvattot2 { get; set; }

    public decimal Ivvatdisc2 { get; set; }

    public decimal Ivvat3 { get; set; }

    public decimal Ivvatval3 { get; set; }

    public decimal Ivvatval3n { get; set; }

    public decimal Ivvattot3 { get; set; }

    public decimal Ivvatdisc3 { get; set; }

    public DateTime? Ivexdate { get; set; }

    public int Ivbdisk { get; set; }

    public DateTime? Ivbdate { get; set; }

    public DateTime Ivsdate { get; set; }

    public DateTime Ivedate { get; set; }

    public int Ivtype { get; set; }

    public int Ivintern { get; set; }

    public string Ivmanager1 { get; set; } = null!;

    public string Ivmanager2 { get; set; } = null!;

    public string Ivmanager3 { get; set; } = null!;

    public string Ivregcourt { get; set; } = null!;

    public DateTime? Ivprintdate { get; set; }

    public DateTime? Ivemaildate { get; set; }

    public DateTime? Ivpdfdate { get; set; }

    public string Ivchtitle { get; set; } = null!;

    public string Ivchnum { get; set; } = null!;

    public decimal Ivchvat { get; set; }

    public decimal Ivchvatval { get; set; }

    public decimal Ivchvalunit { get; set; }

    public decimal Ivchvaltotal { get; set; }

    public string Ivuci { get; set; } = null!;

    public string Ivmaid { get; set; } = null!;

    public DateTime? Ivprenot { get; set; }

    public DateTime? Ivduedate { get; set; }

    public int Ivsepatype { get; set; }

    public int Ivsepaform { get; set; }

    public DateTime? Ivsepaexpdat { get; set; }

    public DateTime? Ivsepapredat { get; set; }

    public int Ivseqtype { get; set; }
}
