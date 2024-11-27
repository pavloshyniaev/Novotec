using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboVehicle
{
    public short? Veident { get; set; } // vehicle id

    public sbyte? Veleident { get; set; }

    public sbyte? Vecoident { get; set; } // company id
    
    public sbyte? Veemident { get; set; } // employee id
    
    public sbyte? Vesrident { get; set; }

    public sbyte? Vepbident { get; set; }

    public sbyte? Vepgident { get; set; }
    
    public string? Vedate { get; set; } // setting datetime.now

    public sbyte? Vewho { get; set; } // new ParaMAIN().ExecuteScalar64(csb.ConnectionString, "SELECT usident FROM uslog WHERE UPPER(usname)='NOVOTEC'");

    public int? Veintno { get; set; } // interne Kfz-Nummer

    public string? Vevehno { get; set; } // vehicle number

    public string? Veplate { get; set; } // Kennzeichen
    
    //int num = _sql.valVEPLATE2.IndexOfAny(" -/\\+#',;.:_)()[]!§$%&{}\"=?*+~@><".ToCharArray());
    // if (num < 0)
    // {
    // 	break;
    // }
    // _sql.valVEPLATE2 = _sql.valVEPLATE2.Remove(num, 1);
    public string? Veplate2 { get; set; } // plate without any symbols

    public string? Vememo { get; set; } // Notes

    public string? Vestart { get; set; } // Inbetriebnahme

    public string? Veend { get; set; } // Außerbetriebsetzung
    
    public string? Vecc { get; set; } // Kostenträger
    
    public string? Vestoc { get; set; } // inventory number
    
    // setConsumptionKM
    public int? Vemiles { get; set; } // aktueller Zählerstand
    
    public sbyte? Vekmstart { get; set; } // Anfangszählerstand
    
    public sbyte? Vekmoffset { get; set; } // Offset bei Zählerwechsel
    
    // setConsumptionHH
    public decimal? Vehours { get; set; } // aktueller Zählerstand

    public decimal? Vehhstart { get; set; } // Anfangszählerstand

    public decimal? Vehhoffset { get; set; } // Offset bei Zählerwechsel

    public sbyte? Vecat { get; set; } // Category
    
    public string? Vestate { get; set; } // status ( out of order, ... )
    
    public sbyte? Vetype { get; set; } // Auswertungstyp
    
    public string? Veoffdate { get; set; } // Datum bei Zählerwechsel

    public string? Vecocode { get; set; }

    public string? Veho { get; set; }

    public string? Vedivision { get; set; }

    public string? Vedivabbr { get; set; }

    public string? Vegroup { get; set; }
}
