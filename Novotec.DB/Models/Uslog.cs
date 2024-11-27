using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Uslog
{
    public long Usident { get; set; }

    public DateTime? Usdate { get; set; }

    public long Uswho { get; set; }

    public string Uspw { get; set; } = null!;

    public string Usname { get; set; } = null!;

    public byte Usadmin { get; set; }

    public DateTime? Usvaldate { get; set; }

    public byte Usskin { get; set; }

    public string Usskinname { get; set; } = null!;

    public string Usskinnav { get; set; } = null!;

    public byte Uslang { get; set; }

    public byte Uslayout { get; set; }

    public byte Usbkcolor { get; set; }

    public byte Usovcolor { get; set; }

    public byte Usovseps { get; set; }

    public byte Usstart { get; set; }

    public byte Usctrl1 { get; set; }

    public byte Usctrl2 { get; set; }

    public byte Usctrl3 { get; set; }

    public byte Usctrl4 { get; set; }

    public byte Usctrl5 { get; set; }

    public byte Usctrl6 { get; set; }

    public short Usrefresh { get; set; }

    public int Uslimit { get; set; }

    public short Usmonth { get; set; }

    public int Uslines { get; set; }

    public string Usbackup { get; set; } = null!;

    public string Usdtapath { get; set; } = null!;

    public string Uspdfpath { get; set; } = null!;

    public string Usinvpath { get; set; } = null!;

    public string Ussepapath { get; set; } = null!;

    public string Ussmtp { get; set; } = null!;

    public string Usmailfrom { get; set; } = null!;

    public string Usmailftxt { get; set; } = null!;

    public string Usmailbody { get; set; } = null!;

    public string Uspwinv { get; set; } = null!;

    public string Ususerinv { get; set; } = null!;

    public string Ussmtphost { get; set; } = null!;

    public int Ussmtpport { get; set; }

    public int Ussmtpssl { get; set; }

    public string Ustaraddr { get; set; } = null!;

    public string Ususername { get; set; } = null!;

    public string Uspwemail { get; set; } = null!;

    public string Ussrcaddr { get; set; } = null!;

    public long Usahident { get; set; }

    public int Usinvtype { get; set; }

    public string Ussmstel { get; set; } = null!;

    public DateTime? Ussmssdate { get; set; }

    public DateTime? Ussmsedate { get; set; }

    public int Ussmsstime { get; set; }

    public int Ussmsetime { get; set; }

    public int Ussmsstime1 { get; set; }

    public int Ussmsetime1 { get; set; }

    public byte Ussmsday { get; set; }

    public int Usrecurr { get; set; }

    public int Usrepeat { get; set; }

    public string Uscompupp { get; set; } = null!;

    public string Uscompmid { get; set; } = null!;

    public string Uscomplow { get; set; } = null!;

    public int Usappn { get; set; }

    public int Usappv { get; set; }

    public int Usappe { get; set; }

    public int Usoutlook { get; set; }

    public string Usout1 { get; set; } = null!;

    public string Usout2 { get; set; } = null!;

    public string Usout3 { get; set; } = null!;

    public int Ussmtpportm { get; set; }

    public int Ussmtpsslm { get; set; }

    public string Usftp { get; set; } = null!;

    public string Usftpuser { get; set; } = null!;

    public string Usftppw { get; set; } = null!;

    public string Usimport { get; set; } = null!;

    public string Usvoucher { get; set; } = null!;

    public string Usdownload { get; set; } = null!;

    public long Usrrident { get; set; }

    public int Uscrypt { get; set; }

    public string Uspwcrypt { get; set; } = null!;

    public int Usservice { get; set; }

    public string Usappointloc { get; set; } = null!;
}
