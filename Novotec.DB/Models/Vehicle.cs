using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Vehicle
{
    public long Veident { get; set; } // vehicle id

    public DateTime? Vedate { get; set; }

    public long Vewho { get; set; }

    public string Veintno { get; set; } = null!; // registration number

    public string Vevehno { get; set; } = null!; // internal vehicle number

    public string Veplate { get; set; } = null!; // license plate

    public string Vememo { get; set; } = null!; // notes

    public long Vepbident { get; set; }

    public long Vepgident { get; set; }

    public DateTime? Vestart { get; set; } // start date

    public DateTime? Veend { get; set; } // end date

    public long Veleident { get; set; }

    public long Vecoident { get; set; }

    public string Vecc { get; set; } = null!;

    public long Veemident { get; set; }

    public string Vestoc { get; set; } = null!;

    public long Vesrident { get; set; }

    public int Vemiles { get; set; } // current km

    public decimal Vehours { get; set; } // current hours

    public byte Vetype { get; set; }

    public int Vekmoffset { get; set; }

    public decimal Vehhoffset { get; set; }

    public DateTime? Veoffdate { get; set; }

    public int Vekmstart { get; set; } // initial km

    public decimal Vehhstart { get; set; } // initial hours

    public string Veplate2 { get; set; } = null!;

    public string Vestate { get; set; } = null!;

    public string Vecocode { get; set; } = null!;

    public string Veho { get; set; } = null!;

    public string Vedivision { get; set; } = null!;

    public string Vedivabbr { get; set; } = null!;

    public string Vegroup { get; set; } = null!;

    public int Vecat { get; set; } // vehicle category
}
