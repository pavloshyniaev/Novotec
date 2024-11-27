using System;
using System.Collections.Generic;

namespace NovotecDB.Models;

public partial class Hia2
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

    public decimal Hiinvlprice { get; set; }

    public decimal Hiinvtotal { get; set; }

    public int Hiinvpbase { get; set; }

    public long Hiaiident { get; set; }

    public long Hiprot { get; set; }

    public long Hiflident { get; set; }

    public long Hirecno { get; set; }

    public int Histate { get; set; }

    public long Hiinfo { get; set; }

    public long Hiinfo2 { get; set; }

    public long Histident { get; set; }

    public decimal Hiconltr { get; set; }

    public long Hihiident { get; set; }

    public decimal Hicon100 { get; set; }

    public decimal Hicon1000 { get; set; }

    public decimal Hiconrev { get; set; }

    public decimal Himileage { get; set; }

    public long Hifuident { get; set; }

    public long Hicaident2 { get; set; }

    public int Hiintern { get; set; }

    public long Hiemident { get; set; }

    public long Hiemcaident { get; set; }

    public long Hiveident { get; set; }

    public long Hivecaident { get; set; }

    public long Hiivident { get; set; }

    public string Himemo { get; set; } = null!;

    public decimal Hico2av { get; set; }

    public decimal Hico2 { get; set; }

    public decimal Higainl { get; set; }

    public decimal Higain { get; set; }

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

    public decimal Hitotadiff { get; set; }

    public decimal Hitotqdiff { get; set; }

    public long Hiipident { get; set; }

    public int Hiinvpextra { get; set; }

    public decimal Hiinvpexval { get; set; }

    public int Hiprtype { get; set; }

    public long? Auident { get; set; }

    public DateTime? Audate { get; set; }

    public long? Auwho { get; set; }

    public string? Aunumber { get; set; }

    public string? Autitle { get; set; }

    public int? Aurelease { get; set; }

    public int? Aurelsub { get; set; }

    public byte? Autype { get; set; }

    public byte? Auautype { get; set; }

    public string? Aumemo { get; set; }

    public string? Ausysno { get; set; }

    public byte? Auactive { get; set; }

    public string? Auseries { get; set; }

    public string? Auintern1 { get; set; }

    public string? Auintern2 { get; set; }

    public long? Fuident { get; set; }

    public DateTime? Fudate { get; set; }

    public long? Fuwho { get; set; }

    public string? Futitle { get; set; }

    public string? Futitle2 { get; set; }

    public string? Futitle3 { get; set; }

    public byte? Futype { get; set; }

    public string? Funumber { get; set; }

    public long? Fuadident { get; set; }

    public string? Fumemo { get; set; }

    public string? Fuintno { get; set; }

    public string? Fuintno2 { get; set; }

    public long? Fusrident { get; set; }

    public long? Adident { get; set; }

    public long? Adwho { get; set; }

    public DateTime? Addate { get; set; }

    public byte? Adtype { get; set; }

    public string? Adloc { get; set; }

    public string? Adzip { get; set; }

    public string? Adctry { get; set; }

    public string? Adstr { get; set; }

    public string? Adhp { get; set; }

    public string? Adpb { get; set; }

    public string? Adfname1 { get; set; }

    public string? Adlname1 { get; set; }

    public string? Adtitle1 { get; set; }

    public byte? Adgen1 { get; set; }

    public string? Adtel1 { get; set; }

    public string? Adtel2 { get; set; }

    public string? Adfax1 { get; set; }

    public string? Ademail1 { get; set; }

    public string? Adbank1 { get; set; }

    public string? Adroutno1 { get; set; }

    public string? Adiban1 { get; set; }

    public string? Adacc1 { get; set; }

    public string? Adibc1 { get; set; }

    public string? Adbank2 { get; set; }

    public string? Adroutno2 { get; set; }

    public string? Adiban2 { get; set; }

    public string? Adacc2 { get; set; }

    public string? Adibc2 { get; set; }

    public string? Advatid { get; set; }

    public long? Caident { get; set; }

    public DateTime? Cadate { get; set; }

    public long? Cawho { get; set; }

    public string? Cano { get; set; }

    public byte? Catype { get; set; }

    public long? Caleident { get; set; }

    public long? Cacoident { get; set; }

    public long? Caveident { get; set; }

    public long? Caemident { get; set; }

    public string? Cano2 { get; set; }

    public long? Coident { get; set; }

    public DateTime? Codate { get; set; }

    public long? Cowho { get; set; }

    public string? Cocono1 { get; set; }

    public string? Cocono2 { get; set; }

    public string? Cotitle1 { get; set; }

    public string? Cotitle2 { get; set; }

    public string? Cotitle3 { get; set; }

    public string? Comemo { get; set; }

    public long? Coadident { get; set; }

    public DateTime? Coend { get; set; }

    public string? Costate { get; set; }

    public byte? Cotype { get; set; }

    public long? Adident3 { get; set; }

    public long? Adwho3 { get; set; }

    public byte? Adtype3 { get; set; }

    public string? Adloc3 { get; set; }

    public string? Adzip3 { get; set; }

    public string? Adctry3 { get; set; }

    public string? Adstr3 { get; set; }

    public string? Adhp3 { get; set; }

    public string? Adpb3 { get; set; }

    public string? Adfname13 { get; set; }

    public string? Adlname13 { get; set; }

    public string? Adtitle13 { get; set; }

    public byte? Adgen13 { get; set; }

    public string? Adtel13 { get; set; }

    public string? Adtel23 { get; set; }

    public string? Adfax13 { get; set; }

    public string? Ademail13 { get; set; }

    public string? Adbank13 { get; set; }

    public string? Adroutno13 { get; set; }

    public string? Adiban13 { get; set; }

    public string? Adacc13 { get; set; }

    public string? Adibc13 { get; set; }

    public string? Adbank23 { get; set; }

    public string? Adroutno23 { get; set; }

    public string? Adiban23 { get; set; }

    public string? Adacc23 { get; set; }

    public string? Adibc23 { get; set; }

    public string? Advatid3 { get; set; }

    public long? Veident { get; set; }

    public DateTime? Vedate { get; set; }

    public long? Vewho { get; set; }

    public string? Veintno { get; set; }

    public string? Veplate { get; set; }

    public string? Vememo { get; set; }

    public long? Vepbident { get; set; }

    public long? Vepgident { get; set; }

    public DateTime? Vestart { get; set; }

    public DateTime? Veend { get; set; }

    public long? Veleident { get; set; }

    public long? Vecoident { get; set; }

    public string? Vecc { get; set; }

    public long? Veemident { get; set; }

    public string? Vestoc { get; set; }

    public long? Vesrident { get; set; }

    public int? Vemiles { get; set; }

    public decimal? Vehours { get; set; }

    public byte? Vetype { get; set; }

    public int? Vekmoffset { get; set; }

    public decimal? Vehhoffset { get; set; }

    public DateTime? Veoffdate { get; set; }

    public int? Vekmstart { get; set; }

    public decimal? Vehhstart { get; set; }

    public string? Veplate2 { get; set; }

    public string? Vestate { get; set; }

    public string? Vecocode { get; set; }

    public string? Veho { get; set; }

    public string? Vedivision { get; set; }

    public string? Vedivabbr { get; set; }

    public string? Vegroup { get; set; }

    public string? Vevehno { get; set; }

    public int? Vecat { get; set; }

    public long? Vtident { get; set; }

    public int? Vttank { get; set; }

    public decimal? Vtnorm { get; set; }

    public decimal? Vtpos { get; set; }

    public decimal? Vtneg { get; set; }

    public int? Vtco2 { get; set; }

    public int? Vtgvw { get; set; }

    public long? Coident2 { get; set; }

    public DateTime? Codate2 { get; set; }

    public long? Cowho2 { get; set; }

    public string? Cocono12 { get; set; }

    public string? Cocono22 { get; set; }

    public string? Cotitle12 { get; set; }

    public string? Cotitle22 { get; set; }

    public string? Cotitle32 { get; set; }

    public string? Comemo2 { get; set; }

    public long? Coadident2 { get; set; }

    public DateTime? Coend2 { get; set; }

    public string? Costate2 { get; set; }

    public byte? Cotype2 { get; set; }

    public long? Caident2 { get; set; }

    public DateTime? Cadate2 { get; set; }

    public long? Cawho2 { get; set; }

    public string? Cano21 { get; set; }

    public byte? Catype2 { get; set; }

    public long? Caleident2 { get; set; }

    public long? Cacoident2 { get; set; }

    public long? Caveident2 { get; set; }

    public long? Caemident2 { get; set; }

    public string? Cano22 { get; set; }

    public long? Coident3 { get; set; }

    public DateTime? Codate3 { get; set; }

    public long? Cowho3 { get; set; }

    public string? Cocono13 { get; set; }

    public string? Cocono23 { get; set; }

    public string? Cotitle13 { get; set; }

    public string? Cotitle23 { get; set; }

    public string? Cotitle33 { get; set; }

    public string? Comemo3 { get; set; }

    public long? Coadident3 { get; set; }

    public DateTime? Coend3 { get; set; }

    public string? Costate3 { get; set; }

    public byte? Cotype3 { get; set; }

    public long? Srident2 { get; set; }

    public DateTime? Srdate2 { get; set; }

    public long? Srwho2 { get; set; }

    public string? Srnumber2 { get; set; }

    public string? Srtitle2 { get; set; }

    public string? Srmemo2 { get; set; }

    public long? Sradident2 { get; set; }

    public long? Srsrident2 { get; set; }

    public int? Srlevel2 { get; set; }

    public int? Srimage2 { get; set; }

    public int? Srhlevel2 { get; set; }

    public long? Emident { get; set; }

    public DateTime? Emdate { get; set; }

    public long? Emwho { get; set; }

    public string? Empersno { get; set; }

    public string? Emdrivno { get; set; }

    public DateTime? Emstart { get; set; }

    public DateTime? Emend { get; set; }

    public byte? Emtype { get; set; }

    public long? Emleident { get; set; }

    public long? Emcoident { get; set; }

    public long? Emadident { get; set; }

    public string? Emmemo { get; set; }

    public string? Emstate { get; set; }

    public byte? Emiscust { get; set; }

    public long? Emcoid { get; set; }

    public string? Emcocode { get; set; }

    public string? Emho { get; set; }

    public string? Emdivision { get; set; }

    public string? Emdivabbr { get; set; }

    public string? Emgroup { get; set; }

    public long? Coident1 { get; set; }

    public DateTime? Codate1 { get; set; }

    public long? Cowho1 { get; set; }

    public string? Cocono11 { get; set; }

    public string? Cocono21 { get; set; }

    public string? Cotitle11 { get; set; }

    public string? Cotitle21 { get; set; }

    public string? Cotitle31 { get; set; }

    public string? Comemo1 { get; set; }

    public long? Coadident1 { get; set; }

    public DateTime? Coend1 { get; set; }

    public string? Costate1 { get; set; }

    public byte? Cotype1 { get; set; }

    public long? Srident1 { get; set; }

    public DateTime? Srdate1 { get; set; }

    public long? Srwho1 { get; set; }

    public string? Srnumber1 { get; set; }

    public string? Srtitle1 { get; set; }

    public string? Srmemo1 { get; set; }

    public long? Sradident1 { get; set; }

    public long? Srsrident1 { get; set; }

    public int? Srlevel1 { get; set; }

    public int? Srimage1 { get; set; }

    public int? Srhlevel1 { get; set; }

    public long? Adident2 { get; set; }

    public long? Adwho2 { get; set; }

    public byte? Adtype2 { get; set; }

    public string? Adloc2 { get; set; }

    public string? Adzip2 { get; set; }

    public string? Adctry2 { get; set; }

    public string? Adstr2 { get; set; }

    public string? Adhp2 { get; set; }

    public string? Adpb2 { get; set; }

    public string? Adfname12 { get; set; }

    public string? Adlname12 { get; set; }

    public string? Adtitle12 { get; set; }

    public byte? Adgen12 { get; set; }

    public string? Adtel12 { get; set; }

    public string? Adtel22 { get; set; }

    public string? Adfax12 { get; set; }

    public string? Ademail12 { get; set; }

    public string? Adbank12 { get; set; }

    public string? Adroutno12 { get; set; }

    public string? Adiban12 { get; set; }

    public string? Adacc12 { get; set; }

    public string? Adibc12 { get; set; }

    public string? Adbank22 { get; set; }

    public string? Adroutno22 { get; set; }

    public string? Adiban22 { get; set; }

    public string? Adacc22 { get; set; }

    public string? Adibc22 { get; set; }

    public string? Advatid2 { get; set; }

    public long? Adident4 { get; set; }

    public long? Adwho4 { get; set; }

    public byte? Adtype4 { get; set; }

    public string? Adloc4 { get; set; }

    public string? Adzip4 { get; set; }

    public string? Adctry4 { get; set; }

    public string? Adstr4 { get; set; }

    public string? Adhp4 { get; set; }

    public string? Adpb4 { get; set; }

    public string? Adfname14 { get; set; }

    public string? Adlname14 { get; set; }

    public string? Adtitle14 { get; set; }

    public byte? Adgen14 { get; set; }

    public string? Adtel14 { get; set; }

    public string? Adtel24 { get; set; }

    public string? Adfax14 { get; set; }

    public string? Ademail14 { get; set; }

    public string? Adbank14 { get; set; }

    public string? Adroutno14 { get; set; }

    public string? Adiban14 { get; set; }

    public string? Adacc14 { get; set; }

    public string? Adibc14 { get; set; }

    public string? Adbank24 { get; set; }

    public string? Adroutno24 { get; set; }

    public string? Adiban24 { get; set; }

    public string? Adacc24 { get; set; }

    public string? Adibc24 { get; set; }

    public string? Advatid4 { get; set; }

    public long? Adident5 { get; set; }

    public long? Adwho5 { get; set; }

    public byte? Adtype5 { get; set; }

    public string? Adloc5 { get; set; }

    public string? Adzip5 { get; set; }

    public string? Adctry5 { get; set; }

    public string? Adstr5 { get; set; }

    public string? Adhp5 { get; set; }

    public string? Adpb5 { get; set; }

    public string? Adfname15 { get; set; }

    public string? Adlname15 { get; set; }

    public string? Adtitle15 { get; set; }

    public byte? Adgen15 { get; set; }

    public string? Adtel15 { get; set; }

    public string? Adtel25 { get; set; }

    public string? Adfax15 { get; set; }

    public string? Ademail15 { get; set; }

    public string? Adbank15 { get; set; }

    public string? Adroutno15 { get; set; }

    public string? Adiban15 { get; set; }

    public string? Adacc15 { get; set; }

    public string? Adibc15 { get; set; }

    public string? Adbank25 { get; set; }

    public string? Adroutno25 { get; set; }

    public string? Adiban25 { get; set; }

    public string? Adacc25 { get; set; }

    public string? Adibc25 { get; set; }

    public string? Advatid5 { get; set; }

    public long? Pbident { get; set; }

    public DateTime? Pbdate { get; set; }

    public long? Pbwho { get; set; }

    public string? Pbtitle { get; set; }

    public string? Pbnumber { get; set; }

    public string? Pbmemo { get; set; }

    public long? Pbpgident { get; set; }

    public long? Pbptident { get; set; }

    public string? Pbextern { get; set; }

    public string? Pbean { get; set; }

    public long? Pbdispl { get; set; }

    public long? Pbvaident { get; set; }

    public int? Pbtype { get; set; }

    public byte? Pbimport { get; set; }

    public int? Pbnscnum { get; set; }

    public string? Pbnscrcpt { get; set; }

    public string? Pbnsconlt { get; set; }

    public string? Pbnsconln { get; set; }

    public int? Pbnscptf1 { get; set; }

    public int? Pbnscptf2 { get; set; }

    public long? Pgident { get; set; }

    public DateTime? Pgdate { get; set; }

    public long? Pgwho { get; set; }

    public string? Pgtitle { get; set; }

    public string? Pgnumber { get; set; }

    public string? Pgmemo { get; set; }

    public int? Pgfltype { get; set; }

    public decimal? Pgco2 { get; set; }

    public long? Ptident { get; set; }

    public DateTime? Ptdate { get; set; }

    public long? Ptwho { get; set; }

    public string? Pttitle { get; set; }

    public string? Ptnumber { get; set; }

    public string? Ptmemo { get; set; }

    public long? Ptquident { get; set; }

    public int? Pttype { get; set; }

    public int? Ptfltype { get; set; }

    public long? Vaident { get; set; }

    public DateTime? Vadate { get; set; }

    public long? Vawho { get; set; }

    public decimal? Vavat { get; set; }

    public byte? Vatype { get; set; }

    public string? Vanumber { get; set; }

    public string? Vatitle { get; set; }

    public long? Stident { get; set; }

    public DateTime? Stdate { get; set; }

    public long? Stwho { get; set; }

    public string? Sttitle { get; set; }

    public string? Stnumber { get; set; }

    public string? Stmemo { get; set; }

    public long? Stpbident { get; set; }

    public decimal? Stmin { get; set; }

    public decimal? Stmax { get; set; }

    public decimal? Storder { get; set; }

    public decimal? Stunit { get; set; }

    public decimal? Stminorder { get; set; }

    public byte? Stordered { get; set; }

    public DateTime? Stordate { get; set; }

    public DateTime? Stinv { get; set; }

    public byte? Stauto { get; set; }

    public decimal? Stamount { get; set; }

    public decimal? Stamauto { get; set; }

    public DateTime? Stamdate { get; set; }

    public byte? Stprobe { get; set; }

    public decimal? Stmeasure { get; set; }

    public DateTime? Stmedate { get; set; }

    public string? Iptitle { get; set; }

    public string? Ipnumber { get; set; }

    public string? Ipmemo { get; set; }

    public byte? Ainum { get; set; }

    public byte? Aistate { get; set; }

    public byte? Aiextern { get; set; }

    public string? Aiextref { get; set; }

    public string? Fetitle2 { get; set; }

    public long? Emident1 { get; set; }

    public long? Emcoid1 { get; set; }

    public string? Ivno { get; set; }

    public DateTime? Ividate { get; set; }

    public long? Ivident { get; set; }

    public long? Peident { get; set; }

    public long? Pecaident { get; set; }

    public decimal? Peact { get; set; }
}
