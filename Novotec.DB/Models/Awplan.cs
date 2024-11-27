using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Awplan
{
    public long Awident { get; set; }

    public DateTime? Awdate { get; set; }

    public long Awwho { get; set; }

    public long Awauident { get; set; }

    public byte Awmon { get; set; }

    public byte Awtue { get; set; }

    public byte Awwed { get; set; }

    public byte Awthu { get; set; }

    public byte Awfri { get; set; }

    public byte Awsat { get; set; }

    public byte Awsun { get; set; }

    public short Awstart { get; set; }

    public short Awend { get; set; }

    public int Awcycle { get; set; }

    public short Awdat01 { get; set; }

    public short Awdat02 { get; set; }

    public short Awdat03 { get; set; }

    public short Awdat04 { get; set; }

    public short Awdat05 { get; set; }

    public short Awdat06 { get; set; }

    public short Awdat07 { get; set; }

    public short Awdat08 { get; set; }

    public short Awdat09 { get; set; }

    public short Awdat10 { get; set; }

    public short Awdat11 { get; set; }

    public short Awdat12 { get; set; }

    public byte Awdelay { get; set; }

    public byte Awstock { get; set; }

    public byte Awprepaid { get; set; }

    public byte Awjournal { get; set; }
}
