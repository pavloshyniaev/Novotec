using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Nscstat
{
    public long Ntident { get; set; }

    public DateTime Ntdate { get; set; }

    public long Ntwho { get; set; }

    public long Ntauident { get; set; }

    public int Nttrnum { get; set; }

    public int Nttanum { get; set; }

    public int Ntrecno { get; set; }

    public int Ntbnwrecno { get; set; }

    public int Ntnscbl { get; set; }

    public int Ntpcbl { get; set; }

    public int Ntejnum { get; set; }

    public DateTime? Ntejdate { get; set; }

    public int Ntrespbl { get; set; }

    public int Ntrespnum { get; set; }

    public int Nttrstat { get; set; }

    public int Ntnscstat { get; set; }

    public int Ntnscerr { get; set; }

    public int Ntejstat { get; set; }

    public int Ntlastblno { get; set; }

    public int Ntstartgap { get; set; }

    public int Ntendgap { get; set; }

    public int Ntterm { get; set; }

    public int Ntnozzle { get; set; }

    public int Ntterm1s { get; set; }

    public int Ntterm1e { get; set; }

    public int Ntterm1rps { get; set; }

    public int Ntterm1rpe { get; set; }

    public int Ntterm2s { get; set; }

    public int Ntterm2e { get; set; }

    public int Ntterm2rps { get; set; }

    public int Ntterm2rpe { get; set; }

    public int Ntrrstat { get; set; }

    public DateTime? Ntrrdate { get; set; }
}
