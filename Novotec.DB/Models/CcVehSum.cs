using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class CcVehSum
{
    public long Sshiident { get; set; }

    public long? Expr1 { get; set; }

    public long Sssrident { get; set; }

    public string? Srtitle { get; set; }

    public int? Srlevel { get; set; }

    public string? Srnumber { get; set; }

    public string? Veplate { get; set; }

    public string? Veintno { get; set; }

    public string? Pbnumber { get; set; }

    public string? Pbtitle { get; set; }

    public decimal? Hiquant { get; set; }

    public decimal? Hitotal1 { get; set; }

    public decimal? Hitotal2 { get; set; }

    public decimal? Hitotal3 { get; set; }

    public decimal? Hitotalvn { get; set; }

    public decimal? Hitotaleb { get; set; }

    public decimal? Hitotalew { get; set; }

    public decimal? Hitotalvat { get; set; }

    public decimal? Hiinvtotal { get; set; }

    public int? Hiinvpbase { get; set; }

    public decimal? Hiinvlprice { get; set; }

    public DateTime? Hitrdate { get; set; }
}
