using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class DboPbase
{
    public short? Pbident { get; set; }

    public string? Pbdate { get; set; }

    public sbyte? Pbwho { get; set; }

    public string? Pbtitle { get; set; }

    public string? Pbnumber { get; set; }

    public string? Pbmemo { get; set; }

    public sbyte? Pbpgident { get; set; }

    public sbyte? Pbptident { get; set; }

    public string? Pbextern { get; set; }

    public string? Pbean { get; set; }

    public sbyte? Pbdispl { get; set; }

    public sbyte? Pbvaident { get; set; }

    public sbyte? Pbtype { get; set; }

    public sbyte? Pbimport { get; set; }

    public sbyte? Pbnscnum { get; set; }

    public string? Pbnscrcpt { get; set; }

    public string? Pbnsconlt { get; set; }

    public string? Pbnsconln { get; set; }

    public sbyte? Pbnscptf1 { get; set; }

    public sbyte? Pbnscptf2 { get; set; }
}
