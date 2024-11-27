using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Export
{
    public string? Datum { get; set; }

    public string? Zeit { get; set; }

    public string? Kennzeichen { get; set; }

    public string? KfzIntern { get; set; }

    public string? MitarbeiterNachname { get; set; }

    public string? MitarbeiterVorname { get; set; }

    public string? PersonAusweisNr { get; set; }

    public string? KfzAusweisNr { get; set; }

    public string? Tankplatz { get; set; }

    public string? Menge { get; set; }

    public string? KmOderStunden { get; set; }
}
