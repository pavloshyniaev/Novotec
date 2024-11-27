using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Hium
{
    public long Hiident { get; set; }

    public long Hitrident { get; set; }

    public DateTime? Hidate { get; set; }

    public DateTime? Hitrdate { get; set; }

    public DateTime? Hitrdatsta { get; set; }

    public DateTime? Hitrdatend { get; set; }

    public int Hitrdur { get; set; }

    public int Hitype { get; set; }

    public long Hipuident { get; set; }

    public decimal Hipuvalue { get; set; }

    public DateTime? Hiexpdate { get; set; }

    public long Hiauident { get; set; }

    public long Hicaident { get; set; }

    public long Hicaident2 { get; set; }

    public long Hipbident { get; set; }

    public decimal Hilprice { get; set; }

    public decimal Hilprice2 { get; set; }

    public decimal Hilprice3 { get; set; }

    public decimal Hilpricevn { get; set; }

    public decimal Hilpriceeb { get; set; }

    public decimal Hilpriceew { get; set; }

    public long Hivaident { get; set; }

    public decimal Hiquant { get; set; }

    public decimal Hitotal1 { get; set; }

    public decimal Hitotal2 { get; set; }

    public decimal Hitotal3 { get; set; }

    public decimal Hitotalvn { get; set; }

    public decimal Hitotaleb { get; set; }

    public decimal Hitotalew { get; set; }

    public decimal Hitotalvat { get; set; }

    public int Hiinvpbase { get; set; }

    public int Hiinvpextra { get; set; }

    public decimal Hiinvpexval { get; set; }

    public decimal Hiinvlprice { get; set; }

    public decimal Hiinvtotal { get; set; }

    public decimal Higainl { get; set; }

    public decimal Higain { get; set; }

    public int Hiprtype { get; set; }

    public long Hiaiident { get; set; }

    public long Hiprot { get; set; }

    public long Hirecno { get; set; }

    public int Histate { get; set; }

    public long Hiinfo { get; set; }

    public long Hiinfo2 { get; set; }

    public long Hiipident { get; set; }

    public long Histident { get; set; }

    public decimal Hiconltr { get; set; }

    public long Hihiident { get; set; }

    public decimal Hicon100 { get; set; }

    public decimal Hicon1000 { get; set; }

    public decimal Hiconrev { get; set; }

    public decimal Himileage { get; set; }

    public long Hiemident { get; set; }

    public long Hiemcaident { get; set; }

    public long Hiveident { get; set; }

    public long Hivecaident { get; set; }

    public long Hiivident { get; set; }

    public int Hiintern { get; set; }

    public long Hifuident { get; set; }

    public long Hiflident { get; set; }

    public string Himemo { get; set; } = null!;

    public decimal Hico2av { get; set; }

    public decimal Hico2 { get; set; }

    public string Hidial1 { get; set; } = null!;

    public string Hidial2 { get; set; } = null!;

    public string Hidial3 { get; set; } = null!;

    public string Hidial4 { get; set; } = null!;

    public string Hidial5 { get; set; } = null!;

    public int Hitolltt { get; set; }

    public int Hitollto { get; set; }

    public int Hitolltz { get; set; }

    public int Hitollta { get; set; }

    public int Hitolltg { get; set; }

    public int Hitolltm { get; set; }

    public int Hitollis { get; set; }

    public string Hitollty { get; set; } = null!;

    public byte Himan { get; set; }

    public byte Hilk { get; set; }

    public decimal Hitotquantity { get; set; }

    public decimal Hitotamount { get; set; }

    public byte Hinozzle { get; set; }

    public decimal Hitotqdiff { get; set; }

    public decimal Hitotadiff { get; set; }
}
