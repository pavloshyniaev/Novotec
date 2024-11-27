using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboEmployee
{
    public short? Emident { get; set; } // ?? Employee Id

    public string? Emdate { get; set; }

    public sbyte? Emwho { get; set; }

    public string? Empersno { get; set; } // personal number

    public string? Emdrivno { get; set; } // driver licence number

    public string? Emstart { get; set; } // hire date

    public string? Emend { get; set; } // fire date

    public sbyte? Emtype { get; set; }

    public sbyte? Emleident { get; set; }

    public sbyte? Emcoident { get; set; } // ?? Company Identifier

    public short? Emadident { get; set; } // ?? Address Identifier

    public string? Emmemo { get; set; } // notes

    public string? Emstate { get; set; } // status

    public short? Emadcomp { get; set; } // ????? Company Address

    public sbyte? Emiscust { get; set; } // is customer

    public string? Emcoid { get; set; } // ?? Company Id

    public string? Emcocode { get; set; } // ?? Company Code

    public string? Emho { get; set; }

    public string? Emdivision { get; set; }

    public string? Emdivabbr { get; set; }

    public string? Emgroup { get; set; }
}
