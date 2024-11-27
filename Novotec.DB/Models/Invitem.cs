using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Invitem
{
    public long Itident { get; set; }

    public long Itivident { get; set; }

    public int Itrectype { get; set; }

    public int Itcurrno { get; set; }

    public DateTime? Itidate { get; set; }

    public string Itname { get; set; } = null!;

    public long Itemident { get; set; }

    public string Itplate { get; set; } = null!;

    public string Itintno { get; set; } = null!;

    public long Itveident { get; set; }

    public string Itvecc { get; set; } = null!;

    public string Itvestoc { get; set; } = null!;

    public int Itmiles { get; set; }

    public decimal Ithours { get; set; }

    public string Itprod { get; set; } = null!;

    public string Itprodnum { get; set; } = null!;

    public long Itpbident { get; set; }

    public decimal Itquant { get; set; }

    public decimal Ituspprice { get; set; }

    public decimal Itusppricen { get; set; }

    public decimal Itupppriceg { get; set; }

    public decimal Ituppprice { get; set; }

    public decimal Itsptotaln { get; set; }

    public decimal Itsptotalg { get; set; }

    public decimal Itpptotaln { get; set; }

    public decimal Itpptotalg { get; set; }

    public int Itinvpbase { get; set; }

    public decimal Itinvprice { get; set; }

    public decimal Itinvtotal { get; set; }

    public decimal Itvat { get; set; }

    public decimal Itspvatval { get; set; }

    public decimal Itppvatval { get; set; }

    public string Itcano1 { get; set; } = null!;

    public long Itcaident1 { get; set; }

    public string Itcano2 { get; set; } = null!;

    public long Itcaident2 { get; set; }

    public string Itfustat { get; set; } = null!;

    public long Itfuident { get; set; }

    public long Ithiident { get; set; }

    public string Itvehcano { get; set; } = null!;

    public string Itperscano { get; set; } = null!;

    public long Ithiinfo { get; set; }

    public string Itipnumber { get; set; } = null!;

    public string Itiptitle { get; set; } = null!;
}
