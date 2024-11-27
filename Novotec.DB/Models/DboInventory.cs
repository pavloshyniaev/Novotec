using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboInventory
{
    public short? Inident { get; set; }

    public string? Indate { get; set; }

    public sbyte? Inwho { get; set; }

    public sbyte? Instident { get; set; }

    public string? Inindate { get; set; }

    public decimal? Inquant { get; set; }

    public sbyte? Inpbident { get; set; }

    public decimal? Inact { get; set; }

    public decimal? Inbuyprice { get; set; }

    public decimal? Insellprice { get; set; }

    public decimal? Inwbp { get; set; }

    public decimal? Innewwbp { get; set; }

    public sbyte? Incoident { get; set; }

    public sbyte? Incorr { get; set; }

    public string? Inmemo { get; set; }
}
