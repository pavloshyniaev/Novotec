using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace NovotecDB.Models;

public partial class NovotecContext : DbContext
{
    public NovotecContext()
    {
    }

    public NovotecContext(DbContextOptions<NovotecContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DboAactive> DboAactives { get; set; }

    public virtual DbSet<DboAcard> DboAcards { get; set; }

    public virtual DbSet<DboAddress> DboAddresses { get; set; }

    public virtual DbSet<DboAdisp> DboAdisps { get; set; }

    public virtual DbSet<DboAgroup> DboAgroups { get; set; }

    public virtual DbSet<DboAlimit> DboAlimits { get; set; }

    public virtual DbSet<DboAmodparm> DboAmodparms { get; set; }

    public virtual DbSet<DboAopstat> DboAopstats { get; set; }

    public virtual DbSet<DboAprod> DboAprods { get; set; }

    public virtual DbSet<DboAsvspec> DboAsvspecs { get; set; }

    public virtual DbSet<DboAtext> DboAtexts { get; set; }

    public virtual DbSet<DboAumenu> DboAumenus { get; set; }

    public virtual DbSet<DboAuthorize> DboAuthorizes { get; set; }

    public virtual DbSet<DboAutomat> DboAutomats { get; set; }

    public virtual DbSet<DboAwplan> DboAwplans { get; set; }

    public virtual DbSet<DboCahistory> DboCahistories { get; set; }

    public virtual DbSet<DboCard> DboCards { get; set; }

    public virtual DbSet<DboCash> DboCashes { get; set; }

    public virtual DbSet<DboCashdisc> DboCashdiscs { get; set; }

    public virtual DbSet<DboCode> DboCodes { get; set; }

    public virtual DbSet<DboCompany> DboCompanies { get; set; }

    public virtual DbSet<DboCrange> DboCranges { get; set; }

    public virtual DbSet<DboCurrstatus> DboCurrstatuses { get; set; }

    public virtual DbSet<DboDeltext> DboDeltexts { get; set; }

    public virtual DbSet<DboDiscount> DboDiscounts { get; set; }

    public virtual DbSet<DboDiscprod> DboDiscprods { get; set; }

    public virtual DbSet<DboDtproperty> DboDtproperties { get; set; }

    public virtual DbSet<DboEmployee> DboEmployees { get; set; }

    public virtual DbSet<DboEndatum> DboEndata { get; set; }

    public virtual DbSet<DboEnfuel> DboEnfuels { get; set; }

    public virtual DbSet<DboError> DboErrors { get; set; }

    public virtual DbSet<DboEvent> DboEvents { get; set; }

    public virtual DbSet<DboExport> DboExports { get; set; }

    public virtual DbSet<DboFcountry> DboFcountries { get; set; }

    public virtual DbSet<DboFcuno> DboFcunos { get; set; }

    public virtual DbSet<DboFleet> DboFleets { get; set; }

    public virtual DbSet<DboFuelstat> DboFuelstats { get; set; }

    public virtual DbSet<DboGlbsearch> DboGlbsearches { get; set; }

    public virtual DbSet<DboHium> DboHia { get; set; }

    public virtual DbSet<DboIdcode> DboIdcodes { get; set; }

    public virtual DbSet<DboInputadd> DboInputadds { get; set; }

    public virtual DbSet<DboInvcharge> DboInvcharges { get; set; }

    public virtual DbSet<DboInventory> DboInventories { get; set; }

    public virtual DbSet<DboInvinv> DboInvinvs { get; set; }

    public virtual DbSet<DboInvitem> DboInvitems { get; set; }

    public virtual DbSet<DboInvnum> DboInvnums { get; set; }

    public virtual DbSet<DboInvoice> DboInvoices { get; set; }

    public virtual DbSet<DboInvspec> DboInvspecs { get; set; }

    public virtual DbSet<DboLevel> DboLevels { get; set; }

    public virtual DbSet<DboLeveldatum> DboLeveldata { get; set; }

    public virtual DbSet<DboLevelmeter> DboLevelmeters { get; set; }

    public virtual DbSet<DboLogin> DboLogins { get; set; }

    public virtual DbSet<DboMclient> DboMclients { get; set; }

    public virtual DbSet<DboNscspec> DboNscspecs { get; set; }

    public virtual DbSet<DboNscstat> DboNscstats { get; set; }

    public virtual DbSet<DboOrder> DboOrders { get; set; }

    public virtual DbSet<DboOverview> DboOverviews { get; set; }

    public virtual DbSet<DboOvsort> DboOvsorts { get; set; }

    public virtual DbSet<DboPbase> DboPbases { get; set; }

    public virtual DbSet<DboPgroup> DboPgroups { get; set; }

    public virtual DbSet<DboPprice> DboPprices { get; set; }

    public virtual DbSet<DboPreauth> DboPreauths { get; set; }

    public virtual DbSet<DboPrepaid> DboPrepaids { get; set; }

    public virtual DbSet<DboPricing> DboPricings { get; set; }

    public virtual DbSet<DboPricprod> DboPricprods { get; set; }

    public virtual DbSet<DboPtype> DboPtypes { get; set; }

    public virtual DbSet<DboQueue> DboQueues { get; set; }

    public virtual DbSet<DboQunit> DboQunits { get; set; }

    public virtual DbSet<DboReference> DboReferences { get; set; }

    public virtual DbSet<DboResponse> DboResponses { get; set; }

    public virtual DbSet<DboScharac> DboScharacs { get; set; }

    public virtual DbSet<DboSearch> DboSearches { get; set; }

    public virtual DbSet<DboSstructure> DboSstructures { get; set; }

    public virtual DbSet<DboSthistory> DboSthistories { get; set; }

    public virtual DbSet<DboStorage> DboStorages { get; set; }

    public virtual DbSet<DboStosel> DboStosels { get; set; }

    public virtual DbSet<DboStructure> DboStructures { get; set; }

    public virtual DbSet<DboSvaccdriv> DboSvaccdrivs { get; set; }

    public virtual DbSet<DboSvaccinp> DboSvaccinps { get; set; }

    public virtual DbSet<DboSvaccount> DboSvaccounts { get; set; }

    public virtual DbSet<DboSysdiagram> DboSysdiagrams { get; set; }

    public virtual DbSet<DboSysprop> DboSysprops { get; set; }

    public virtual DbSet<DboSystem> DboSystems { get; set; }

    public virtual DbSet<DboTagroup> DboTagroups { get; set; }

    public virtual DbSet<DboTerminal> DboTerminals { get; set; }

    public virtual DbSet<DboTermsel> DboTermsels { get; set; }

    public virtual DbSet<DboTlabel> DboTlabels { get; set; }

    public virtual DbSet<DboTstatus> DboTstatuses { get; set; }

    public virtual DbSet<DboUslog> DboUslogs { get; set; }

    public virtual DbSet<DboVat> DboVats { get; set; }

    public virtual DbSet<DboVcharac> DboVcharacs { get; set; }

    public virtual DbSet<DboVehicle> DboVehicles { get; set; }

    public virtual DbSet<DboVfattrib> DboVfattribs { get; set; }

    public virtual DbSet<DboVrefatt> DboVrefatts { get; set; }

    public virtual DbSet<DboVtech> DboVteches { get; set; }

    public virtual DbSet<DboWstation> DboWstations { get; set; }

    public virtual DbSet<DboZvt> DboZvts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DboAactive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AACTIVE");

            entity.Property(e => e.Aaauident).HasColumnName("AAAUIDENT");
            entity.Property(e => e.Aadend)
                .HasMaxLength(19)
                .HasColumnName("AADEND");
            entity.Property(e => e.Aadstart)
                .HasMaxLength(19)
                .HasColumnName("AADSTART");
            entity.Property(e => e.Aaident).HasColumnName("AAIDENT");
            entity.Property(e => e.Aaidle).HasColumnName("AAIDLE");
            entity.Property(e => e.Aalend).HasColumnName("AALEND");
            entity.Property(e => e.Aalstart).HasColumnName("AALSTART");
            entity.Property(e => e.Aastart)
                .HasMaxLength(19)
                .HasColumnName("AASTART");
            entity.Property(e => e.Aastate).HasColumnName("AASTATE");
        });

        modelBuilder.Entity<DboAcard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ACARD");

            entity.Property(e => e.Acauident).HasColumnName("ACAUIDENT");
            entity.Property(e => e.Accaident).HasColumnName("ACCAIDENT");
            entity.Property(e => e.Acdate)
                .HasMaxLength(19)
                .HasColumnName("ACDATE");
            entity.Property(e => e.Acident).HasColumnName("ACIDENT");
            entity.Property(e => e.Acidident).HasColumnName("ACIDIDENT");
            entity.Property(e => e.Actype).HasColumnName("ACTYPE");
            entity.Property(e => e.Acwho).HasColumnName("ACWHO");
            entity.Property(e => e.Aczvident).HasColumnName("ACZVIDENT");
        });

        modelBuilder.Entity<DboAddress>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ADDRESS");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(0)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(0)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adacc3)
                .HasMaxLength(0)
                .HasColumnName("ADACC3");
            entity.Property(e => e.Adacc4)
                .HasMaxLength(0)
                .HasColumnName("ADACC4");
            entity.Property(e => e.Adacc5)
                .HasMaxLength(0)
                .HasColumnName("ADACC5");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(0)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(0)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adbank3)
                .HasMaxLength(0)
                .HasColumnName("ADBANK3");
            entity.Property(e => e.Adbank4)
                .HasMaxLength(0)
                .HasColumnName("ADBANK4");
            entity.Property(e => e.Adbank5)
                .HasMaxLength(0)
                .HasColumnName("ADBANK5");
            entity.Property(e => e.Adctry)
                .HasMaxLength(11)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Addate)
                .HasMaxLength(19)
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(0)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail2)
                .HasMaxLength(0)
                .HasColumnName("ADEMAIL2");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(0)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax2)
                .HasMaxLength(0)
                .HasColumnName("ADFAX2");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(21)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname2)
                .HasMaxLength(0)
                .HasColumnName("ADFNAME2");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen2).HasColumnName("ADGEN2");
            entity.Property(e => e.Adhp)
                .HasMaxLength(0)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(0)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(0)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adiban3)
                .HasMaxLength(0)
                .HasColumnName("ADIBAN3");
            entity.Property(e => e.Adiban4)
                .HasMaxLength(0)
                .HasColumnName("ADIBAN4");
            entity.Property(e => e.Adiban5)
                .HasMaxLength(0)
                .HasColumnName("ADIBAN5");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(0)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(0)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adibc3)
                .HasMaxLength(0)
                .HasColumnName("ADIBC3");
            entity.Property(e => e.Adibc4)
                .HasMaxLength(0)
                .HasColumnName("ADIBC4");
            entity.Property(e => e.Adibc5)
                .HasMaxLength(0)
                .HasColumnName("ADIBC5");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(16)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname2)
                .HasMaxLength(0)
                .HasColumnName("ADLNAME2");
            entity.Property(e => e.Adloc)
                .HasMaxLength(29)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(0)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(0)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(0)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adroutno3)
                .HasMaxLength(0)
                .HasColumnName("ADROUTNO3");
            entity.Property(e => e.Adroutno4)
                .HasMaxLength(0)
                .HasColumnName("ADROUTNO4");
            entity.Property(e => e.Adroutno5)
                .HasMaxLength(0)
                .HasColumnName("ADROUTNO5");
            entity.Property(e => e.Adstr)
                .HasMaxLength(32)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtaxid)
                .HasMaxLength(0)
                .HasColumnName("ADTAXID");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(0)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(0)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel3)
                .HasMaxLength(0)
                .HasColumnName("ADTEL3");
            entity.Property(e => e.Adtel4)
                .HasMaxLength(0)
                .HasColumnName("ADTEL4");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(0)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle2)
                .HasMaxLength(0)
                .HasColumnName("ADTITLE2");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Advatid)
                .HasMaxLength(0)
                .HasColumnName("ADVATID");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adxxident).HasColumnName("ADXXIDENT");
            entity.Property(e => e.Adzip)
                .HasMaxLength(9)
                .HasColumnName("ADZIP");
        });

        modelBuilder.Entity<DboAdisp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ADISP");

            entity.Property(e => e.Aiauident).HasColumnName("AIAUIDENT");
            entity.Property(e => e.Aicorr)
                .HasPrecision(4, 3)
                .HasColumnName("AICORR");
            entity.Property(e => e.Aidate)
                .HasMaxLength(19)
                .HasColumnName("AIDATE");
            entity.Property(e => e.Aidispquant).HasColumnName("AIDISPQUANT");
            entity.Property(e => e.Aiextern).HasColumnName("AIEXTERN");
            entity.Property(e => e.Aiextref)
                .HasMaxLength(0)
                .HasColumnName("AIEXTREF");
            entity.Property(e => e.Aiident).HasColumnName("AIIDENT");
            entity.Property(e => e.Aiimp).HasColumnName("AIIMP");
            entity.Property(e => e.Ailonnode).HasColumnName("AILONNODE");
            entity.Property(e => e.Ailonside).HasColumnName("AILONSIDE");
            entity.Property(e => e.Aimaxam).HasColumnName("AIMAXAM");
            entity.Property(e => e.Aimaxtime).HasColumnName("AIMAXTIME");
            entity.Property(e => e.Ainscbundle1).HasColumnName("AINSCBUNDLE1");
            entity.Property(e => e.Ainscbundle2).HasColumnName("AINSCBUNDLE2");
            entity.Property(e => e.Ainscbundle3).HasColumnName("AINSCBUNDLE3");
            entity.Property(e => e.Ainscctrl).HasColumnName("AINSCCTRL");
            entity.Property(e => e.Ainscdelay).HasColumnName("AINSCDELAY");
            entity.Property(e => e.Ainscerr).HasColumnName("AINSCERR");
            entity.Property(e => e.Ainscmaxam)
                .HasPrecision(3, 2)
                .HasColumnName("AINSCMAXAM");
            entity.Property(e => e.Ainscmaxdur).HasColumnName("AINSCMAXDUR");
            entity.Property(e => e.Ainscmaxquant)
                .HasPrecision(3, 2)
                .HasColumnName("AINSCMAXQUANT");
            entity.Property(e => e.Ainscstate).HasColumnName("AINSCSTATE");
            entity.Property(e => e.Ainum).HasColumnName("AINUM");
            entity.Property(e => e.Airef1).HasColumnName("AIREF1");
            entity.Property(e => e.Airef10).HasColumnName("AIREF10");
            entity.Property(e => e.Airef2).HasColumnName("AIREF2");
            entity.Property(e => e.Airef3).HasColumnName("AIREF3");
            entity.Property(e => e.Airef4).HasColumnName("AIREF4");
            entity.Property(e => e.Airef5).HasColumnName("AIREF5");
            entity.Property(e => e.Airef6).HasColumnName("AIREF6");
            entity.Property(e => e.Airef7).HasColumnName("AIREF7");
            entity.Property(e => e.Airef8).HasColumnName("AIREF8");
            entity.Property(e => e.Airef9).HasColumnName("AIREF9");
            entity.Property(e => e.Aishow).HasColumnName("AISHOW");
            entity.Property(e => e.Aistate).HasColumnName("AISTATE");
            entity.Property(e => e.Aistore1).HasColumnName("AISTORE1");
            entity.Property(e => e.Aistore10).HasColumnName("AISTORE10");
            entity.Property(e => e.Aistore2).HasColumnName("AISTORE2");
            entity.Property(e => e.Aistore3).HasColumnName("AISTORE3");
            entity.Property(e => e.Aistore4).HasColumnName("AISTORE4");
            entity.Property(e => e.Aistore5).HasColumnName("AISTORE5");
            entity.Property(e => e.Aistore6).HasColumnName("AISTORE6");
            entity.Property(e => e.Aistore7).HasColumnName("AISTORE7");
            entity.Property(e => e.Aistore8).HasColumnName("AISTORE8");
            entity.Property(e => e.Aistore9).HasColumnName("AISTORE9");
            entity.Property(e => e.Aitube1).HasColumnName("AITUBE1");
            entity.Property(e => e.Aitube10).HasColumnName("AITUBE10");
            entity.Property(e => e.Aitube2).HasColumnName("AITUBE2");
            entity.Property(e => e.Aitube3).HasColumnName("AITUBE3");
            entity.Property(e => e.Aitube4).HasColumnName("AITUBE4");
            entity.Property(e => e.Aitube5).HasColumnName("AITUBE5");
            entity.Property(e => e.Aitube6).HasColumnName("AITUBE6");
            entity.Property(e => e.Aitube7).HasColumnName("AITUBE7");
            entity.Property(e => e.Aitube8).HasColumnName("AITUBE8");
            entity.Property(e => e.Aitube9).HasColumnName("AITUBE9");
            entity.Property(e => e.Aitypelon).HasColumnName("AITYPELON");
            entity.Property(e => e.Aiwho).HasColumnName("AIWHO");
        });

        modelBuilder.Entity<DboAgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AGROUP");

            entity.Property(e => e.Agdate)
                .HasMaxLength(0)
                .HasColumnName("AGDATE");
            entity.Property(e => e.Agident)
                .HasMaxLength(0)
                .HasColumnName("AGIDENT");
            entity.Property(e => e.Agmemo)
                .HasMaxLength(0)
                .HasColumnName("AGMEMO");
            entity.Property(e => e.Agnumber)
                .HasMaxLength(0)
                .HasColumnName("AGNUMBER");
            entity.Property(e => e.Agtitle)
                .HasMaxLength(0)
                .HasColumnName("AGTITLE");
            entity.Property(e => e.Agwho)
                .HasMaxLength(0)
                .HasColumnName("AGWHO");
        });

        modelBuilder.Entity<DboAlimit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ALIMIT");

            entity.Property(e => e.Alauident).HasColumnName("ALAUIDENT");
            entity.Property(e => e.Aldate)
                .HasMaxLength(19)
                .HasColumnName("ALDATE");
            entity.Property(e => e.Alident).HasColumnName("ALIDENT");
            entity.Property(e => e.Allimit1).HasColumnName("ALLIMIT1");
            entity.Property(e => e.Allimit2).HasColumnName("ALLIMIT2");
            entity.Property(e => e.Allimit3).HasColumnName("ALLIMIT3");
            entity.Property(e => e.Allimit4).HasColumnName("ALLIMIT4");
            entity.Property(e => e.Allimit5).HasColumnName("ALLIMIT5");
            entity.Property(e => e.Allimit6).HasColumnName("ALLIMIT6");
            entity.Property(e => e.Allimit7).HasColumnName("ALLIMIT7");
            entity.Property(e => e.Altype).HasColumnName("ALTYPE");
            entity.Property(e => e.Alwho).HasColumnName("ALWHO");
        });

        modelBuilder.Entity<DboAmodparm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AMODPARM");

            entity.Property(e => e.Amauident).HasColumnName("AMAUIDENT");
            entity.Property(e => e.Ambaud).HasColumnName("AMBAUD");
            entity.Property(e => e.Amcmd)
                .HasMaxLength(3)
                .HasColumnName("AMCMD");
            entity.Property(e => e.Amcom).HasColumnName("AMCOM");
            entity.Property(e => e.Amdatabits).HasColumnName("AMDATABITS");
            entity.Property(e => e.Amdate)
                .HasMaxLength(19)
                .HasColumnName("AMDATE");
            entity.Property(e => e.Amdownload).HasColumnName("AMDOWNLOAD");
            entity.Property(e => e.Amend)
                .HasMaxLength(4)
                .HasColumnName("AMEND");
            entity.Property(e => e.Amgprs).HasColumnName("AMGPRS");
            entity.Property(e => e.Amgsm).HasColumnName("AMGSM");
            entity.Property(e => e.Amhostname)
                .HasMaxLength(0)
                .HasColumnName("AMHOSTNAME");
            entity.Property(e => e.Amident).HasColumnName("AMIDENT");
            entity.Property(e => e.Aminit)
                .HasMaxLength(3)
                .HasColumnName("AMINIT");
            entity.Property(e => e.Amip)
                .HasMaxLength(0)
                .HasColumnName("AMIP");
            entity.Property(e => e.Amipv6)
                .HasMaxLength(0)
                .HasColumnName("AMIPV6");
            entity.Property(e => e.Amlrc).HasColumnName("AMLRC");
            entity.Property(e => e.Amnackrep).HasColumnName("AMNACKREP");
            entity.Property(e => e.Amownport).HasColumnName("AMOWNPORT");
            entity.Property(e => e.Amparity).HasColumnName("AMPARITY");
            entity.Property(e => e.Amport).HasColumnName("AMPORT");
            entity.Property(e => e.Amprot).HasColumnName("AMPROT");
            entity.Property(e => e.Amprotpath)
                .HasMaxLength(0)
                .HasColumnName("AMPROTPATH");
            entity.Property(e => e.Ampuls).HasColumnName("AMPULS");
            entity.Property(e => e.Amrecrep).HasColumnName("AMRECREP");
            entity.Property(e => e.Amsubnet)
                .HasMaxLength(0)
                .HasColumnName("AMSUBNET");
            entity.Property(e => e.Amtel)
                .HasMaxLength(0)
                .HasColumnName("AMTEL");
            entity.Property(e => e.Amterm).HasColumnName("AMTERM");
            entity.Property(e => e.Amtrarep).HasColumnName("AMTRAREP");
            entity.Property(e => e.Amupload).HasColumnName("AMUPLOAD");
            entity.Property(e => e.Amwho).HasColumnName("AMWHO");
            entity.Property(e => e.Amxmdelay).HasColumnName("AMXMDELAY");
        });

        modelBuilder.Entity<DboAopstat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AOPSTAT");

            entity.Property(e => e.Aoauident).HasColumnName("AOAUIDENT");
            entity.Property(e => e.Aocomdate)
                .HasMaxLength(19)
                .HasColumnName("AOCOMDATE");
            entity.Property(e => e.Aocomstate).HasColumnName("AOCOMSTATE");
            entity.Property(e => e.Aodisp1).HasColumnName("AODISP1");
            entity.Property(e => e.Aodisp10).HasColumnName("AODISP10");
            entity.Property(e => e.Aodisp11).HasColumnName("AODISP11");
            entity.Property(e => e.Aodisp12).HasColumnName("AODISP12");
            entity.Property(e => e.Aodisp13).HasColumnName("AODISP13");
            entity.Property(e => e.Aodisp14).HasColumnName("AODISP14");
            entity.Property(e => e.Aodisp15).HasColumnName("AODISP15");
            entity.Property(e => e.Aodisp16).HasColumnName("AODISP16");
            entity.Property(e => e.Aodisp17).HasColumnName("AODISP17");
            entity.Property(e => e.Aodisp18).HasColumnName("AODISP18");
            entity.Property(e => e.Aodisp19).HasColumnName("AODISP19");
            entity.Property(e => e.Aodisp2).HasColumnName("AODISP2");
            entity.Property(e => e.Aodisp20).HasColumnName("AODISP20");
            entity.Property(e => e.Aodisp21).HasColumnName("AODISP21");
            entity.Property(e => e.Aodisp22).HasColumnName("AODISP22");
            entity.Property(e => e.Aodisp23).HasColumnName("AODISP23");
            entity.Property(e => e.Aodisp24).HasColumnName("AODISP24");
            entity.Property(e => e.Aodisp25).HasColumnName("AODISP25");
            entity.Property(e => e.Aodisp26).HasColumnName("AODISP26");
            entity.Property(e => e.Aodisp27).HasColumnName("AODISP27");
            entity.Property(e => e.Aodisp28).HasColumnName("AODISP28");
            entity.Property(e => e.Aodisp29).HasColumnName("AODISP29");
            entity.Property(e => e.Aodisp3).HasColumnName("AODISP3");
            entity.Property(e => e.Aodisp30).HasColumnName("AODISP30");
            entity.Property(e => e.Aodisp31).HasColumnName("AODISP31");
            entity.Property(e => e.Aodisp32).HasColumnName("AODISP32");
            entity.Property(e => e.Aodisp4).HasColumnName("AODISP4");
            entity.Property(e => e.Aodisp5).HasColumnName("AODISP5");
            entity.Property(e => e.Aodisp6).HasColumnName("AODISP6");
            entity.Property(e => e.Aodisp7).HasColumnName("AODISP7");
            entity.Property(e => e.Aodisp8).HasColumnName("AODISP8");
            entity.Property(e => e.Aodisp9).HasColumnName("AODISP9");
            entity.Property(e => e.Aohelp)
                .HasMaxLength(0)
                .HasColumnName("AOHELP");
            entity.Property(e => e.Aoident).HasColumnName("AOIDENT");
            entity.Property(e => e.Aolimit).HasColumnName("AOLIMIT");
            entity.Property(e => e.Aolock).HasColumnName("AOLOCK");
            entity.Property(e => e.Aoopstate).HasColumnName("AOOPSTATE");
            entity.Property(e => e.Aosta2date)
                .HasMaxLength(19)
                .HasColumnName("AOSTA2DATE");
            entity.Property(e => e.Aostadate)
                .HasMaxLength(0)
                .HasColumnName("AOSTADATE");
            entity.Property(e => e.Aostat).HasColumnName("AOSTAT");
            entity.Property(e => e.Aostat2).HasColumnName("AOSTAT2");
        });

        modelBuilder.Entity<DboAprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.APROD");

            entity.Property(e => e.Apauident).HasColumnName("APAUIDENT");
            entity.Property(e => e.Apdate)
                .HasMaxLength(19)
                .HasColumnName("APDATE");
            entity.Property(e => e.Apident).HasColumnName("APIDENT");
            entity.Property(e => e.Apintern).HasColumnName("APINTERN");
            entity.Property(e => e.Appbident).HasColumnName("APPBIDENT");
            entity.Property(e => e.Approbe).HasColumnName("APPROBE");
            entity.Property(e => e.Apstident).HasColumnName("APSTIDENT");
            entity.Property(e => e.Aptank).HasColumnName("APTANK");
            entity.Property(e => e.Apwho).HasColumnName("APWHO");
        });

        modelBuilder.Entity<DboAsvspec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ASVSPEC");

            entity.Property(e => e.As042).HasColumnName("AS042");
            entity.Property(e => e.As043).HasColumnName("AS043");
            entity.Property(e => e.As18).HasColumnName("AS18");
            entity.Property(e => e.As202).HasColumnName("AS202");
            entity.Property(e => e.As2memo).HasColumnName("AS2MEMO");
            entity.Property(e => e.As306).HasColumnName("AS306");
            entity.Property(e => e.Asaddinput).HasColumnName("ASADDINPUT");
            entity.Property(e => e.Asattend).HasColumnName("ASATTEND");
            entity.Property(e => e.Asauident).HasColumnName("ASAUIDENT");
            entity.Property(e => e.Asbig).HasColumnName("ASBIG");
            entity.Property(e => e.Asblack).HasColumnName("ASBLACK");
            entity.Property(e => e.Ascal).HasColumnName("ASCAL");
            entity.Property(e => e.Ascancel).HasColumnName("ASCANCEL");
            entity.Property(e => e.Ascard).HasColumnName("ASCARD");
            entity.Property(e => e.Ascheck).HasColumnName("ASCHECK");
            entity.Property(e => e.Ascnt).HasColumnName("ASCNT");
            entity.Property(e => e.Asdate)
                .HasMaxLength(19)
                .HasColumnName("ASDATE");
            entity.Property(e => e.Asdelay).HasColumnName("ASDELAY");
            entity.Property(e => e.Asend).HasColumnName("ASEND");
            entity.Property(e => e.Asident).HasColumnName("ASIDENT");
            entity.Property(e => e.Asimp).HasColumnName("ASIMP");
            entity.Property(e => e.Asinout).HasColumnName("ASINOUT");
            entity.Property(e => e.Aslpin).HasColumnName("ASLPIN");
            entity.Property(e => e.Asmuldisp).HasColumnName("ASMULDISP");
            entity.Property(e => e.Asoffset)
                .HasMaxLength(0)
                .HasColumnName("ASOFFSET");
            entity.Property(e => e.Aspin).HasColumnName("ASPIN");
            entity.Property(e => e.Asprev).HasColumnName("ASPREV");
            entity.Property(e => e.Asprice).HasColumnName("ASPRICE");
            entity.Property(e => e.Asref).HasColumnName("ASREF");
            entity.Property(e => e.Asrefers).HasColumnName("ASREFERS");
            entity.Property(e => e.Assmall).HasColumnName("ASSMALL");
            entity.Property(e => e.Asstart).HasColumnName("ASSTART");
            entity.Property(e => e.Assys).HasColumnName("ASSYS");
            entity.Property(e => e.Astintern).HasColumnName("ASTINTERN");
            entity.Property(e => e.Astprice).HasColumnName("ASTPRICE");
            entity.Property(e => e.Asvaident1).HasColumnName("ASVAIDENT1");
            entity.Property(e => e.Asvaident2).HasColumnName("ASVAIDENT2");
            entity.Property(e => e.Aswho).HasColumnName("ASWHO");
        });

        modelBuilder.Entity<DboAtext>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ATEXT");

            entity.Property(e => e.Atauident).HasColumnName("ATAUIDENT");
            entity.Property(e => e.Atbold).HasColumnName("ATBOLD");
            entity.Property(e => e.Atdate)
                .HasMaxLength(19)
                .HasColumnName("ATDATE");
            entity.Property(e => e.Atident).HasColumnName("ATIDENT");
            entity.Property(e => e.Atline)
                .HasMaxLength(0)
                .HasColumnName("ATLINE");
            entity.Property(e => e.Atlineno).HasColumnName("ATLINENO");
            entity.Property(e => e.Attype).HasColumnName("ATTYPE");
            entity.Property(e => e.Atwho).HasColumnName("ATWHO");
        });

        modelBuilder.Entity<DboAumenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AUMENU");

            entity.Property(e => e.Aeahident)
                .HasMaxLength(0)
                .HasColumnName("AEAHIDENT");
            entity.Property(e => e.Aeident)
                .HasMaxLength(0)
                .HasColumnName("AEIDENT");
            entity.Property(e => e.Aenum)
                .HasMaxLength(0)
                .HasColumnName("AENUM");
            entity.Property(e => e.Aetype)
                .HasMaxLength(0)
                .HasColumnName("AETYPE");
        });

        modelBuilder.Entity<DboAuthorize>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AUTHORIZE");

            entity.Property(e => e.Ahdate)
                .HasMaxLength(0)
                .HasColumnName("AHDATE");
            entity.Property(e => e.Ahident)
                .HasMaxLength(0)
                .HasColumnName("AHIDENT");
            entity.Property(e => e.Ahpg1)
                .HasMaxLength(0)
                .HasColumnName("AHPG1");
            entity.Property(e => e.Ahpg10)
                .HasMaxLength(0)
                .HasColumnName("AHPG10");
            entity.Property(e => e.Ahpg2)
                .HasMaxLength(0)
                .HasColumnName("AHPG2");
            entity.Property(e => e.Ahpg3)
                .HasMaxLength(0)
                .HasColumnName("AHPG3");
            entity.Property(e => e.Ahpg4)
                .HasMaxLength(0)
                .HasColumnName("AHPG4");
            entity.Property(e => e.Ahpg5)
                .HasMaxLength(0)
                .HasColumnName("AHPG5");
            entity.Property(e => e.Ahpg6)
                .HasMaxLength(0)
                .HasColumnName("AHPG6");
            entity.Property(e => e.Ahpg7)
                .HasMaxLength(0)
                .HasColumnName("AHPG7");
            entity.Property(e => e.Ahpg8)
                .HasMaxLength(0)
                .HasColumnName("AHPG8");
            entity.Property(e => e.Ahpg9)
                .HasMaxLength(0)
                .HasColumnName("AHPG9");
            entity.Property(e => e.Ahtitle)
                .HasMaxLength(0)
                .HasColumnName("AHTITLE");
            entity.Property(e => e.Ahwho)
                .HasMaxLength(0)
                .HasColumnName("AHWHO");
        });

        modelBuilder.Entity<DboAutomat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AUTOMAT");

            entity.Property(e => e.Auactive).HasColumnName("AUACTIVE");
            entity.Property(e => e.Auagident).HasColumnName("AUAGIDENT");
            entity.Property(e => e.Auautype).HasColumnName("AUAUTYPE");
            entity.Property(e => e.Aucashregisterid)
                .HasMaxLength(0)
                .HasColumnName("AUCASHREGISTERID");
            entity.Property(e => e.Audate)
                .HasMaxLength(19)
                .HasColumnName("AUDATE");
            entity.Property(e => e.Aufuident).HasColumnName("AUFUIDENT");
            entity.Property(e => e.Auident).HasColumnName("AUIDENT");
            entity.Property(e => e.Auifsfaiid).HasColumnName("AUIFSFAIID");
            entity.Property(e => e.Auintern1)
                .HasMaxLength(0)
                .HasColumnName("AUINTERN1");
            entity.Property(e => e.Auintern2)
                .HasMaxLength(0)
                .HasColumnName("AUINTERN2");
            entity.Property(e => e.Aumemo)
                .HasMaxLength(0)
                .HasColumnName("AUMEMO");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(0)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Aurelease).HasColumnName("AURELEASE");
            entity.Property(e => e.Aurelsub).HasColumnName("AURELSUB");
            entity.Property(e => e.Auseries).HasColumnName("AUSERIES");
            entity.Property(e => e.Ausysno).HasColumnName("AUSYSNO");
            entity.Property(e => e.Autitle)
                .HasMaxLength(21)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Autype).HasColumnName("AUTYPE");
            entity.Property(e => e.Auwho).HasColumnName("AUWHO");
        });

        modelBuilder.Entity<DboAwplan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.AWPLAN");

            entity.Property(e => e.Awauident).HasColumnName("AWAUIDENT");
            entity.Property(e => e.Awcycle).HasColumnName("AWCYCLE");
            entity.Property(e => e.Awdat01).HasColumnName("AWDAT01");
            entity.Property(e => e.Awdat02).HasColumnName("AWDAT02");
            entity.Property(e => e.Awdat03).HasColumnName("AWDAT03");
            entity.Property(e => e.Awdat04).HasColumnName("AWDAT04");
            entity.Property(e => e.Awdat05).HasColumnName("AWDAT05");
            entity.Property(e => e.Awdat06).HasColumnName("AWDAT06");
            entity.Property(e => e.Awdat07).HasColumnName("AWDAT07");
            entity.Property(e => e.Awdat08).HasColumnName("AWDAT08");
            entity.Property(e => e.Awdat09).HasColumnName("AWDAT09");
            entity.Property(e => e.Awdat10).HasColumnName("AWDAT10");
            entity.Property(e => e.Awdat11).HasColumnName("AWDAT11");
            entity.Property(e => e.Awdat12).HasColumnName("AWDAT12");
            entity.Property(e => e.Awdate)
                .HasMaxLength(19)
                .HasColumnName("AWDATE");
            entity.Property(e => e.Awdelay).HasColumnName("AWDELAY");
            entity.Property(e => e.Awend).HasColumnName("AWEND");
            entity.Property(e => e.Awfri).HasColumnName("AWFRI");
            entity.Property(e => e.Awident).HasColumnName("AWIDENT");
            entity.Property(e => e.Awjournal).HasColumnName("AWJOURNAL");
            entity.Property(e => e.Awmon).HasColumnName("AWMON");
            entity.Property(e => e.Awprepaid).HasColumnName("AWPREPAID");
            entity.Property(e => e.Awsat).HasColumnName("AWSAT");
            entity.Property(e => e.Awstart).HasColumnName("AWSTART");
            entity.Property(e => e.Awstock).HasColumnName("AWSTOCK");
            entity.Property(e => e.Awsun).HasColumnName("AWSUN");
            entity.Property(e => e.Awthu).HasColumnName("AWTHU");
            entity.Property(e => e.Awtue).HasColumnName("AWTUE");
            entity.Property(e => e.Awwed).HasColumnName("AWWED");
            entity.Property(e => e.Awwho).HasColumnName("AWWHO");
        });

        modelBuilder.Entity<DboCahistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CAHISTORY");

            entity.Property(e => e.Chcaident).HasColumnName("CHCAIDENT");
            entity.Property(e => e.Chcoident).HasColumnName("CHCOIDENT");
            entity.Property(e => e.Chdate)
                .HasMaxLength(19)
                .HasColumnName("CHDATE");
            entity.Property(e => e.Chemident).HasColumnName("CHEMIDENT");
            entity.Property(e => e.Chfcident).HasColumnName("CHFCIDENT");
            entity.Property(e => e.Chident).HasColumnName("CHIDENT");
            entity.Property(e => e.Chleident).HasColumnName("CHLEIDENT");
            entity.Property(e => e.Chveident).HasColumnName("CHVEIDENT");
            entity.Property(e => e.Chwho).HasColumnName("CHWHO");
        });

        modelBuilder.Entity<DboCard>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CARDS");

            entity.Property(e => e.Cacoident).HasColumnName("CACOIDENT");
            entity.Property(e => e.Cadate)
                .HasMaxLength(19)
                .HasColumnName("CADATE");
            entity.Property(e => e.Caemident).HasColumnName("CAEMIDENT");
            entity.Property(e => e.Cafcident).HasColumnName("CAFCIDENT");
            entity.Property(e => e.Caident).HasColumnName("CAIDENT");
            entity.Property(e => e.Caleident).HasColumnName("CALEIDENT");
            entity.Property(e => e.Cano).HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(18)
                .HasColumnName("CANO2");
            entity.Property(e => e.Capuident).HasColumnName("CAPUIDENT");
            entity.Property(e => e.Castident).HasColumnName("CASTIDENT");
            entity.Property(e => e.Catype).HasColumnName("CATYPE");
            entity.Property(e => e.Caveident).HasColumnName("CAVEIDENT");
            entity.Property(e => e.Cawho).HasColumnName("CAWHO");
        });

        modelBuilder.Entity<DboCash>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CASH");

            entity.Property(e => e.Csaiident)
                .HasMaxLength(0)
                .HasColumnName("CSAIIDENT");
            entity.Property(e => e.Csauident)
                .HasMaxLength(0)
                .HasColumnName("CSAUIDENT");
            entity.Property(e => e.Cscatype)
                .HasMaxLength(0)
                .HasColumnName("CSCATYPE");
            entity.Property(e => e.Csdate)
                .HasMaxLength(0)
                .HasColumnName("CSDATE");
            entity.Property(e => e.Csident)
                .HasMaxLength(0)
                .HasColumnName("CSIDENT");
            entity.Property(e => e.Cslprice)
                .HasMaxLength(0)
                .HasColumnName("CSLPRICE");
            entity.Property(e => e.Csprice)
                .HasMaxLength(0)
                .HasColumnName("CSPRICE");
            entity.Property(e => e.Csprident)
                .HasMaxLength(0)
                .HasColumnName("CSPRIDENT");
            entity.Property(e => e.Csprotno)
                .HasMaxLength(0)
                .HasColumnName("CSPROTNO");
            entity.Property(e => e.Csquant)
                .HasMaxLength(0)
                .HasColumnName("CSQUANT");
            entity.Property(e => e.Csrecn1)
                .HasMaxLength(0)
                .HasColumnName("CSRECN1");
            entity.Property(e => e.Csrecn2)
                .HasMaxLength(0)
                .HasColumnName("CSRECN2");
            entity.Property(e => e.Csstident)
                .HasMaxLength(0)
                .HasColumnName("CSSTIDENT");
            entity.Property(e => e.Cswho)
                .HasMaxLength(0)
                .HasColumnName("CSWHO");
        });

        modelBuilder.Entity<DboCashdisc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CASHDISC");

            entity.Property(e => e.Cidate)
                .HasMaxLength(19)
                .HasColumnName("CIDATE");
            entity.Property(e => e.Ciident).HasColumnName("CIIDENT");
            entity.Property(e => e.Cititle1)
                .HasMaxLength(8)
                .HasColumnName("CITITLE1");
            entity.Property(e => e.Cititle2)
                .HasMaxLength(8)
                .HasColumnName("CITITLE2");
            entity.Property(e => e.Cititle3)
                .HasMaxLength(8)
                .HasColumnName("CITITLE3");
            entity.Property(e => e.Cititle4)
                .HasMaxLength(8)
                .HasColumnName("CITITLE4");
            entity.Property(e => e.Cititle5)
                .HasMaxLength(8)
                .HasColumnName("CITITLE5");
            entity.Property(e => e.Civalue1)
                .HasPrecision(3, 2)
                .HasColumnName("CIVALUE1");
            entity.Property(e => e.Civalue2)
                .HasPrecision(3, 2)
                .HasColumnName("CIVALUE2");
            entity.Property(e => e.Civalue3)
                .HasPrecision(3, 2)
                .HasColumnName("CIVALUE3");
            entity.Property(e => e.Civalue4)
                .HasPrecision(3, 2)
                .HasColumnName("CIVALUE4");
            entity.Property(e => e.Civalue5)
                .HasPrecision(3, 2)
                .HasColumnName("CIVALUE5");
            entity.Property(e => e.Ciwho).HasColumnName("CIWHO");
        });

        modelBuilder.Entity<DboCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CODE");

            entity.Property(e => e.Cdauident)
                .HasMaxLength(0)
                .HasColumnName("CDAUIDENT");
            entity.Property(e => e.Cdcano)
                .HasMaxLength(0)
                .HasColumnName("CDCANO");
            entity.Property(e => e.Cdcode)
                .HasMaxLength(0)
                .HasColumnName("CDCODE");
            entity.Property(e => e.Cddate)
                .HasMaxLength(0)
                .HasColumnName("CDDATE");
            entity.Property(e => e.Cdident)
                .HasMaxLength(0)
                .HasColumnName("CDIDENT");
        });

        modelBuilder.Entity<DboCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.COMPANY");

            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Cocono1).HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(0)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Codate)
                .HasMaxLength(19)
                .HasColumnName("CODATE");
            entity.Property(e => e.Coend)
                .HasMaxLength(0)
                .HasColumnName("COEND");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Coieident).HasColumnName("COIEIDENT");
            entity.Property(e => e.Comanager1)
                .HasMaxLength(0)
                .HasColumnName("COMANAGER1");
            entity.Property(e => e.Comanager2)
                .HasMaxLength(0)
                .HasColumnName("COMANAGER2");
            entity.Property(e => e.Comanager3)
                .HasMaxLength(0)
                .HasColumnName("COMANAGER3");
            entity.Property(e => e.Comemo)
                .HasMaxLength(0)
                .HasColumnName("COMEMO");
            entity.Property(e => e.Coname)
                .HasMaxLength(0)
                .HasColumnName("CONAME");
            entity.Property(e => e.Copuident).HasColumnName("COPUIDENT");
            entity.Property(e => e.Coregcourt)
                .HasMaxLength(0)
                .HasColumnName("COREGCOURT");
            entity.Property(e => e.Costate)
                .HasMaxLength(0)
                .HasColumnName("COSTATE");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(27)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(0)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(0)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Couci)
                .HasMaxLength(2)
                .HasColumnName("COUCI");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
        });

        modelBuilder.Entity<DboCrange>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CRANGE");

            entity.Property(e => e.Crcorr)
                .HasMaxLength(0)
                .HasColumnName("CRCORR");
            entity.Property(e => e.Crdate)
                .HasMaxLength(0)
                .HasColumnName("CRDATE");
            entity.Property(e => e.Crident)
                .HasMaxLength(0)
                .HasColumnName("CRIDENT");
            entity.Property(e => e.Crmaxval)
                .HasMaxLength(0)
                .HasColumnName("CRMAXVAL");
            entity.Property(e => e.Crmemo)
                .HasMaxLength(0)
                .HasColumnName("CRMEMO");
            entity.Property(e => e.Crminval)
                .HasMaxLength(0)
                .HasColumnName("CRMINVAL");
            entity.Property(e => e.Crnumber)
                .HasMaxLength(0)
                .HasColumnName("CRNUMBER");
            entity.Property(e => e.Crrep)
                .HasMaxLength(0)
                .HasColumnName("CRREP");
            entity.Property(e => e.Crtitle)
                .HasMaxLength(0)
                .HasColumnName("CRTITLE");
            entity.Property(e => e.Crtype)
                .HasMaxLength(0)
                .HasColumnName("CRTYPE");
            entity.Property(e => e.Crwho)
                .HasMaxLength(0)
                .HasColumnName("CRWHO");
        });

        modelBuilder.Entity<DboCurrstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.CURRSTATUS");

            entity.Property(e => e.Cucritical).HasColumnName("CUCRITICAL");
            entity.Property(e => e.Cudate)
                .HasMaxLength(19)
                .HasColumnName("CUDATE");
            entity.Property(e => e.Cuident)
                .HasColumnType("mediumint")
                .HasColumnName("CUIDENT");
            entity.Property(e => e.Cumemo)
                .HasMaxLength(34)
                .HasColumnName("CUMEMO");
            entity.Property(e => e.Cumessage)
                .HasMaxLength(27)
                .HasColumnName("CUMESSAGE");
            entity.Property(e => e.Cumessid).HasColumnName("CUMESSID");
            entity.Property(e => e.Cupinfo)
                .HasMaxLength(11)
                .HasColumnName("CUPINFO");
            entity.Property(e => e.Cuprogno).HasColumnName("CUPROGNO");
            entity.Property(e => e.Custation)
                .HasMaxLength(9)
                .HasColumnName("CUSTATION");
            entity.Property(e => e.Cutype).HasColumnName("CUTYPE");
        });

        modelBuilder.Entity<DboDeltext>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.DELTEXT");

            entity.Property(e => e.Dtdate)
                .HasMaxLength(19)
                .HasColumnName("DTDATE");
            entity.Property(e => e.Dtident).HasColumnName("DTIDENT");
            entity.Property(e => e.Dttext)
                .HasMaxLength(8)
                .HasColumnName("DTTEXT");
            entity.Property(e => e.Dttype).HasColumnName("DTTYPE");
            entity.Property(e => e.Dtwho).HasColumnName("DTWHO");
        });

        modelBuilder.Entity<DboDiscount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.DISCOUNT");

            entity.Property(e => e.Didate)
                .HasMaxLength(19)
                .HasColumnName("DIDATE");
            entity.Property(e => e.Diident).HasColumnName("DIIDENT");
            entity.Property(e => e.Dititle)
                .HasMaxLength(14)
                .HasColumnName("DITITLE");
            entity.Property(e => e.Ditype).HasColumnName("DITYPE");
            entity.Property(e => e.Diwho).HasColumnName("DIWHO");
        });

        modelBuilder.Entity<DboDiscprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.DISCPROD");

            entity.Property(e => e.Dpdate)
                .HasMaxLength(19)
                .HasColumnName("DPDATE");
            entity.Property(e => e.Dpdiident).HasColumnName("DPDIIDENT");
            entity.Property(e => e.Dpident).HasColumnName("DPIDENT");
            entity.Property(e => e.Dppbident).HasColumnName("DPPBIDENT");
            entity.Property(e => e.Dpquant)
                .HasPrecision(4, 3)
                .HasColumnName("DPQUANT");
            entity.Property(e => e.Dptype).HasColumnName("DPTYPE");
            entity.Property(e => e.Dpvaldat)
                .HasMaxLength(19)
                .HasColumnName("DPVALDAT");
            entity.Property(e => e.Dpvaltype).HasColumnName("DPVALTYPE");
            entity.Property(e => e.Dpvalue)
                .HasPrecision(4, 3)
                .HasColumnName("DPVALUE");
            entity.Property(e => e.Dpwho).HasColumnName("DPWHO");
        });

        modelBuilder.Entity<DboDtproperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.dtproperties");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lvalue)
                .HasMaxLength(0)
                .HasColumnName("lvalue");
            entity.Property(e => e.Objectid).HasColumnName("objectid");
            entity.Property(e => e.Property)
                .HasMaxLength(15)
                .HasColumnName("property");
            entity.Property(e => e.Uvalue)
                .HasMaxLength(0)
                .HasColumnName("uvalue");
            entity.Property(e => e.Value)
                .HasMaxLength(0)
                .HasColumnName("value");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<DboEmployee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.EMPLOYEE");

            entity.Property(e => e.Emadcomp).HasColumnName("EMADCOMP");
            entity.Property(e => e.Emadident).HasColumnName("EMADIDENT");
            entity.Property(e => e.Emcocode)
                .HasMaxLength(0)
                .HasColumnName("EMCOCODE");
            entity.Property(e => e.Emcoid)
                .HasMaxLength(0)
                .HasColumnName("EMCOID");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdate)
                .HasMaxLength(19)
                .HasColumnName("EMDATE");
            entity.Property(e => e.Emdivabbr)
                .HasMaxLength(0)
                .HasColumnName("EMDIVABBR");
            entity.Property(e => e.Emdivision)
                .HasMaxLength(0)
                .HasColumnName("EMDIVISION");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(0)
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Emend)
                .HasMaxLength(19)
                .HasColumnName("EMEND");
            entity.Property(e => e.Emgroup)
                .HasMaxLength(0)
                .HasColumnName("EMGROUP");
            entity.Property(e => e.Emho)
                .HasMaxLength(0)
                .HasColumnName("EMHO");
            entity.Property(e => e.Emident).HasColumnName("EMIDENT");
            entity.Property(e => e.Emiscust).HasColumnName("EMISCUST");
            entity.Property(e => e.Emleident).HasColumnName("EMLEIDENT");
            entity.Property(e => e.Emmemo)
                .HasMaxLength(0)
                .HasColumnName("EMMEMO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(6)
                .HasColumnName("EMPERSNO");
            entity.Property(e => e.Emstart)
                .HasMaxLength(19)
                .HasColumnName("EMSTART");
            entity.Property(e => e.Emstate)
                .HasMaxLength(8)
                .HasColumnName("EMSTATE");
            entity.Property(e => e.Emtype).HasColumnName("EMTYPE");
            entity.Property(e => e.Emwho).HasColumnName("EMWHO");
        });

        modelBuilder.Entity<DboEndatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ENDATA");

            entity.Property(e => e.Enauident).HasColumnName("ENAUIDENT");
            entity.Property(e => e.Endate)
                .HasMaxLength(19)
                .HasColumnName("ENDATE");
            entity.Property(e => e.Enident).HasColumnName("ENIDENT");
            entity.Property(e => e.Enline)
                .HasMaxLength(32)
                .HasColumnName("ENLINE");
            entity.Property(e => e.Enlineno).HasColumnName("ENLINENO");
        });

        modelBuilder.Entity<DboEnfuel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ENFUEL");

            entity.Property(e => e.Efauident)
                .HasMaxLength(0)
                .HasColumnName("EFAUIDENT");
            entity.Property(e => e.Efdate)
                .HasMaxLength(0)
                .HasColumnName("EFDATE");
            entity.Property(e => e.Efident)
                .HasMaxLength(0)
                .HasColumnName("EFIDENT");
            entity.Property(e => e.Efline)
                .HasMaxLength(0)
                .HasColumnName("EFLINE");
            entity.Property(e => e.Eflineno)
                .HasMaxLength(0)
                .HasColumnName("EFLINENO");
        });

        modelBuilder.Entity<DboError>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ERROR");

            entity.Property(e => e.Eraiident).HasColumnName("ERAIIDENT");
            entity.Property(e => e.Erauident).HasColumnName("ERAUIDENT");
            entity.Property(e => e.Erdate)
                .HasMaxLength(19)
                .HasColumnName("ERDATE");
            entity.Property(e => e.Erident).HasColumnName("ERIDENT");
            entity.Property(e => e.Ermemo)
                .HasMaxLength(0)
                .HasColumnName("ERMEMO");
            entity.Property(e => e.Ernum).HasColumnName("ERNUM");
            entity.Property(e => e.Ertype).HasColumnName("ERTYPE");
            entity.Property(e => e.Erwho).HasColumnName("ERWHO");
        });

        modelBuilder.Entity<DboEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.EVENT");

            entity.Property(e => e.Evallday)
                .HasMaxLength(0)
                .HasColumnName("EVALLDAY");
            entity.Property(e => e.Evconfirm)
                .HasMaxLength(0)
                .HasColumnName("EVCONFIRM");
            entity.Property(e => e.Evdate)
                .HasMaxLength(0)
                .HasColumnName("EVDATE");
            entity.Property(e => e.Evdays)
                .HasMaxLength(0)
                .HasColumnName("EVDAYS");
            entity.Property(e => e.Evdescr)
                .HasMaxLength(0)
                .HasColumnName("EVDESCR");
            entity.Property(e => e.Evdone)
                .HasMaxLength(0)
                .HasColumnName("EVDONE");
            entity.Property(e => e.Evdonedate)
                .HasMaxLength(0)
                .HasColumnName("EVDONEDATE");
            entity.Property(e => e.Evemid)
                .HasMaxLength(0)
                .HasColumnName("EVEMID");
            entity.Property(e => e.Evemident)
                .HasMaxLength(0)
                .HasColumnName("EVEMIDENT");
            entity.Property(e => e.Evend)
                .HasMaxLength(0)
                .HasColumnName("EVEND");
            entity.Property(e => e.Evevtype)
                .HasMaxLength(0)
                .HasColumnName("EVEVTYPE");
            entity.Property(e => e.Evhdone)
                .HasMaxLength(0)
                .HasColumnName("EVHDONE");
            entity.Property(e => e.Evhours)
                .HasMaxLength(0)
                .HasColumnName("EVHOURS");
            entity.Property(e => e.Evhrecurr)
                .HasMaxLength(0)
                .HasColumnName("EVHRECURR");
            entity.Property(e => e.Evident)
                .HasMaxLength(0)
                .HasColumnName("EVIDENT");
            entity.Property(e => e.Evlabel)
                .HasMaxLength(0)
                .HasColumnName("EVLABEL");
            entity.Property(e => e.Evlabelid)
                .HasMaxLength(0)
                .HasColumnName("EVLABELID");
            entity.Property(e => e.Evlocation)
                .HasMaxLength(0)
                .HasColumnName("EVLOCATION");
            entity.Property(e => e.Evmdone)
                .HasMaxLength(0)
                .HasColumnName("EVMDONE");
            entity.Property(e => e.Evmiles)
                .HasMaxLength(0)
                .HasColumnName("EVMILES");
            entity.Property(e => e.Evmrecurr)
                .HasMaxLength(0)
                .HasColumnName("EVMRECURR");
            entity.Property(e => e.Evoffhours)
                .HasMaxLength(0)
                .HasColumnName("EVOFFHOURS");
            entity.Property(e => e.Evoffmiles)
                .HasMaxLength(0)
                .HasColumnName("EVOFFMILES");
            entity.Property(e => e.Evrectype)
                .HasMaxLength(0)
                .HasColumnName("EVRECTYPE");
            entity.Property(e => e.Evrecurr)
                .HasMaxLength(0)
                .HasColumnName("EVRECURR");
            entity.Property(e => e.Evremind)
                .HasMaxLength(0)
                .HasColumnName("EVREMIND");
            entity.Property(e => e.Evstart)
                .HasMaxLength(0)
                .HasColumnName("EVSTART");
            entity.Property(e => e.Evstate)
                .HasMaxLength(0)
                .HasColumnName("EVSTATE");
            entity.Property(e => e.Evsubject)
                .HasMaxLength(0)
                .HasColumnName("EVSUBJECT");
            entity.Property(e => e.Evtype)
                .HasMaxLength(0)
                .HasColumnName("EVTYPE");
            entity.Property(e => e.Evveident)
                .HasMaxLength(0)
                .HasColumnName("EVVEIDENT");
            entity.Property(e => e.Evwho)
                .HasMaxLength(0)
                .HasColumnName("EVWHO");
        });

        modelBuilder.Entity<DboExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.EXPORT");

            entity.Property(e => e.Datum).HasMaxLength(0);
            entity.Property(e => e.Kennzeichen).HasMaxLength(0);
            entity.Property(e => e.KfzAusweisNr)
                .HasMaxLength(0)
                .HasColumnName("KFZ Ausweis-Nr.");
            entity.Property(e => e.KfzIntern)
                .HasMaxLength(0)
                .HasColumnName("KFZ intern");
            entity.Property(e => e.KmOderStunden)
                .HasMaxLength(0)
                .HasColumnName("KM oder Stunden");
            entity.Property(e => e.Menge).HasMaxLength(0);
            entity.Property(e => e.MitarbeiterNachname)
                .HasMaxLength(0)
                .HasColumnName("Mitarbeiter Nachname");
            entity.Property(e => e.MitarbeiterVorname)
                .HasMaxLength(0)
                .HasColumnName("Mitarbeiter Vorname");
            entity.Property(e => e.PersonAusweisNr)
                .HasMaxLength(0)
                .HasColumnName("Person Ausweis-Nr.");
            entity.Property(e => e.Tankplatz).HasMaxLength(0);
            entity.Property(e => e.Zeit).HasMaxLength(0);
        });

        modelBuilder.Entity<DboFcountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.FCOUNTRY");

            entity.Property(e => e.Focode)
                .HasMaxLength(3)
                .HasColumnName("FOCODE");
            entity.Property(e => e.Foctry)
                .HasMaxLength(23)
                .HasColumnName("FOCTRY");
            entity.Property(e => e.Foident).HasColumnName("FOIDENT");
            entity.Property(e => e.Fono).HasColumnName("FONO");
        });

        modelBuilder.Entity<DboFcuno>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.FCUNO");

            entity.Property(e => e.Fcdate)
                .HasMaxLength(0)
                .HasColumnName("FCDATE");
            entity.Property(e => e.Fcident)
                .HasMaxLength(0)
                .HasColumnName("FCIDENT");
            entity.Property(e => e.Fcno)
                .HasMaxLength(0)
                .HasColumnName("FCNO");
            entity.Property(e => e.Fctype)
                .HasMaxLength(0)
                .HasColumnName("FCTYPE");
            entity.Property(e => e.Fcwho)
                .HasMaxLength(0)
                .HasColumnName("FCWHO");
        });

        modelBuilder.Entity<DboFleet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.FLEET");

            entity.Property(e => e.Feident).HasColumnName("FEIDENT");
            entity.Property(e => e.Feno).HasColumnName("FENO");
            entity.Property(e => e.Fetitle)
                .HasMaxLength(22)
                .HasColumnName("FETITLE");
        });

        modelBuilder.Entity<DboFuelstat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.FUELSTAT");

            entity.Property(e => e.Fuadident).HasColumnName("FUADIDENT");
            entity.Property(e => e.Fudate)
                .HasMaxLength(19)
                .HasColumnName("FUDATE");
            entity.Property(e => e.Fuident).HasColumnName("FUIDENT");
            entity.Property(e => e.Fuintno)
                .HasMaxLength(0)
                .HasColumnName("FUINTNO");
            entity.Property(e => e.Fuintno2)
                .HasMaxLength(0)
                .HasColumnName("FUINTNO2");
            entity.Property(e => e.Fuintno3)
                .HasMaxLength(0)
                .HasColumnName("FUINTNO3");
            entity.Property(e => e.Fuintno4)
                .HasMaxLength(0)
                .HasColumnName("FUINTNO4");
            entity.Property(e => e.Fumemo)
                .HasMaxLength(0)
                .HasColumnName("FUMEMO");
            entity.Property(e => e.Funumber).HasColumnName("FUNUMBER");
            entity.Property(e => e.Fusrident).HasColumnName("FUSRIDENT");
            entity.Property(e => e.Futitle)
                .HasMaxLength(18)
                .HasColumnName("FUTITLE");
            entity.Property(e => e.Futitle2)
                .HasMaxLength(0)
                .HasColumnName("FUTITLE2");
            entity.Property(e => e.Futitle3)
                .HasMaxLength(0)
                .HasColumnName("FUTITLE3");
            entity.Property(e => e.Futype).HasColumnName("FUTYPE");
            entity.Property(e => e.Fuwho).HasColumnName("FUWHO");
        });

        modelBuilder.Entity<DboGlbsearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.GLBSEARCH");

            entity.Property(e => e.Gldate)
                .HasMaxLength(0)
                .HasColumnName("GLDATE");
            entity.Property(e => e.Glfield)
                .HasMaxLength(0)
                .HasColumnName("GLFIELD");
            entity.Property(e => e.Glident)
                .HasMaxLength(0)
                .HasColumnName("GLIDENT");
            entity.Property(e => e.Glitem)
                .HasMaxLength(0)
                .HasColumnName("GLITEM");
            entity.Property(e => e.Glprog)
                .HasMaxLength(0)
                .HasColumnName("GLPROG");
            entity.Property(e => e.Glscope)
                .HasMaxLength(0)
                .HasColumnName("GLSCOPE");
            entity.Property(e => e.Glsql)
                .HasMaxLength(0)
                .HasColumnName("GLSQL");
            entity.Property(e => e.Gltext)
                .HasMaxLength(0)
                .HasColumnName("GLTEXT");
            entity.Property(e => e.Glwho)
                .HasMaxLength(0)
                .HasColumnName("GLWHO");
        });

        modelBuilder.Entity<DboHium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.HIA");

            entity.Property(e => e.Hiaiident).HasColumnName("HIAIIDENT");
            entity.Property(e => e.Hiauident).HasColumnName("HIAUIDENT");
            entity.Property(e => e.Hicaident).HasColumnName("HICAIDENT");
            entity.Property(e => e.Hicaident2).HasColumnName("HICAIDENT2");
            entity.Property(e => e.Hico2)
                .HasPrecision(4, 3)
                .HasColumnName("HICO2");
            entity.Property(e => e.Hico2av)
                .HasPrecision(4, 3)
                .HasColumnName("HICO2AV");
            entity.Property(e => e.Hicon100)
                .HasPrecision(4, 3)
                .HasColumnName("HICON100");
            entity.Property(e => e.Hicon1000)
                .HasPrecision(4, 3)
                .HasColumnName("HICON1000");
            entity.Property(e => e.Hiconltr)
                .HasPrecision(4, 3)
                .HasColumnName("HICONLTR");
            entity.Property(e => e.Hiconrev)
                .HasPrecision(4, 3)
                .HasColumnName("HICONREV");
            entity.Property(e => e.Hidate)
                .HasMaxLength(19)
                .HasColumnName("HIDATE");
            entity.Property(e => e.Hidial1).HasColumnName("HIDIAL1");
            entity.Property(e => e.Hidial2)
                .HasMaxLength(0)
                .HasColumnName("HIDIAL2");
            entity.Property(e => e.Hidial3)
                .HasMaxLength(0)
                .HasColumnName("HIDIAL3");
            entity.Property(e => e.Hidial4)
                .HasMaxLength(0)
                .HasColumnName("HIDIAL4");
            entity.Property(e => e.Hidial5)
                .HasMaxLength(0)
                .HasColumnName("HIDIAL5");
            entity.Property(e => e.Hiemcaident).HasColumnName("HIEMCAIDENT");
            entity.Property(e => e.Hiemident).HasColumnName("HIEMIDENT");
            entity.Property(e => e.Hiexpdate)
                .HasMaxLength(19)
                .HasColumnName("HIEXPDATE");
            entity.Property(e => e.Hiflident).HasColumnName("HIFLIDENT");
            entity.Property(e => e.Hifuident).HasColumnName("HIFUIDENT");
            entity.Property(e => e.Higain)
                .HasPrecision(5, 2)
                .HasColumnName("HIGAIN");
            entity.Property(e => e.Higainl)
                .HasPrecision(3, 2)
                .HasColumnName("HIGAINL");
            entity.Property(e => e.Hihiident).HasColumnName("HIHIIDENT");
            entity.Property(e => e.Hiident)
                .HasColumnType("mediumint")
                .HasColumnName("HIIDENT");
            entity.Property(e => e.Hiinfo).HasColumnName("HIINFO");
            entity.Property(e => e.Hiinfo2).HasColumnName("HIINFO2");
            entity.Property(e => e.Hiintern).HasColumnName("HIINTERN");
            entity.Property(e => e.Hiinvlprice)
                .HasPrecision(5, 4)
                .HasColumnName("HIINVLPRICE");
            entity.Property(e => e.Hiinvpbase).HasColumnName("HIINVPBASE");
            entity.Property(e => e.Hiinvpextra).HasColumnName("HIINVPEXTRA");
            entity.Property(e => e.Hiinvpexval)
                .HasPrecision(5, 4)
                .HasColumnName("HIINVPEXVAL");
            entity.Property(e => e.Hiinvtotal)
                .HasPrecision(3, 2)
                .HasColumnName("HIINVTOTAL");
            entity.Property(e => e.Hiipident).HasColumnName("HIIPIDENT");
            entity.Property(e => e.Hiivident).HasColumnName("HIIVIDENT");
            entity.Property(e => e.Hilk).HasColumnName("HILK");
            entity.Property(e => e.Hilprice)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICE");
            entity.Property(e => e.Hilprice2)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICE2");
            entity.Property(e => e.Hilprice3)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICE3");
            entity.Property(e => e.Hilpriceeb)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICEEB");
            entity.Property(e => e.Hilpriceew)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICEEW");
            entity.Property(e => e.Hilpricevn)
                .HasPrecision(5, 4)
                .HasColumnName("HILPRICEVN");
            entity.Property(e => e.Himan).HasColumnName("HIMAN");
            entity.Property(e => e.Himemo)
                .HasMaxLength(4)
                .HasColumnName("HIMEMO");
            entity.Property(e => e.Himileage)
                .HasPrecision(10, 3)
                .HasColumnName("HIMILEAGE");
            entity.Property(e => e.Hinozzle).HasColumnName("HINOZZLE");
            entity.Property(e => e.Hipbident).HasColumnName("HIPBIDENT");
            entity.Property(e => e.Hiprot)
                .HasColumnType("mediumint")
                .HasColumnName("HIPROT");
            entity.Property(e => e.Hiprtype).HasColumnName("HIPRTYPE");
            entity.Property(e => e.Hipuident).HasColumnName("HIPUIDENT");
            entity.Property(e => e.Hipuvalue)
                .HasPrecision(3, 2)
                .HasColumnName("HIPUVALUE");
            entity.Property(e => e.Hiquant)
                .HasPrecision(6, 3)
                .HasColumnName("HIQUANT");
            entity.Property(e => e.Hirecno).HasColumnName("HIRECNO");
            entity.Property(e => e.Histate).HasColumnName("HISTATE");
            entity.Property(e => e.Histident).HasColumnName("HISTIDENT");
            entity.Property(e => e.Hitollis).HasColumnName("HITOLLIS");
            entity.Property(e => e.Hitollta).HasColumnName("HITOLLTA");
            entity.Property(e => e.Hitolltg).HasColumnName("HITOLLTG");
            entity.Property(e => e.Hitolltm).HasColumnName("HITOLLTM");
            entity.Property(e => e.Hitollto).HasColumnName("HITOLLTO");
            entity.Property(e => e.Hitolltt).HasColumnName("HITOLLTT");
            entity.Property(e => e.Hitollty)
                .HasMaxLength(1)
                .HasColumnName("HITOLLTY");
            entity.Property(e => e.Hitolltz).HasColumnName("HITOLLTZ");
            entity.Property(e => e.Hitotadiff)
                .HasPrecision(4, 3)
                .HasColumnName("HITOTADIFF");
            entity.Property(e => e.Hitotal1)
                .HasPrecision(5, 2)
                .HasColumnName("HITOTAL1");
            entity.Property(e => e.Hitotal2)
                .HasPrecision(3, 2)
                .HasColumnName("HITOTAL2");
            entity.Property(e => e.Hitotal3)
                .HasPrecision(3, 2)
                .HasColumnName("HITOTAL3");
            entity.Property(e => e.Hitotaleb)
                .HasPrecision(3, 2)
                .HasColumnName("HITOTALEB");
            entity.Property(e => e.Hitotalew)
                .HasPrecision(3, 2)
                .HasColumnName("HITOTALEW");
            entity.Property(e => e.Hitotalvat)
                .HasPrecision(3, 2)
                .HasColumnName("HITOTALVAT");
            entity.Property(e => e.Hitotalvn)
                .HasPrecision(5, 2)
                .HasColumnName("HITOTALVN");
            entity.Property(e => e.Hitotamount)
                .HasPrecision(4, 3)
                .HasColumnName("HITOTAMOUNT");
            entity.Property(e => e.Hitotqdiff)
                .HasPrecision(4, 3)
                .HasColumnName("HITOTQDIFF");
            entity.Property(e => e.Hitotquantity)
                .HasPrecision(4, 3)
                .HasColumnName("HITOTQUANTITY");
            entity.Property(e => e.Hitrdate)
                .HasMaxLength(19)
                .HasColumnName("HITRDATE");
            entity.Property(e => e.Hitrdatend)
                .HasMaxLength(19)
                .HasColumnName("HITRDATEND");
            entity.Property(e => e.Hitrdatsta)
                .HasMaxLength(19)
                .HasColumnName("HITRDATSTA");
            entity.Property(e => e.Hitrdur).HasColumnName("HITRDUR");
            entity.Property(e => e.Hitrident)
                .HasColumnType("mediumint")
                .HasColumnName("HITRIDENT");
            entity.Property(e => e.Hitype).HasColumnName("HITYPE");
            entity.Property(e => e.Hivaident).HasColumnName("HIVAIDENT");
            entity.Property(e => e.Hivecaident).HasColumnName("HIVECAIDENT");
            entity.Property(e => e.Hiveident).HasColumnName("HIVEIDENT");
        });

        modelBuilder.Entity<DboIdcode>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.IDCODE");

            entity.Property(e => e.Idaddlen)
                .HasMaxLength(0)
                .HasColumnName("IDADDLEN");
            entity.Property(e => e.Idaddpos)
                .HasMaxLength(0)
                .HasColumnName("IDADDPOS");
            entity.Property(e => e.Idaddtype)
                .HasMaxLength(0)
                .HasColumnName("IDADDTYPE");
            entity.Property(e => e.Idaddval)
                .HasMaxLength(0)
                .HasColumnName("IDADDVAL");
            entity.Property(e => e.Idcard)
                .HasMaxLength(0)
                .HasColumnName("IDCARD");
            entity.Property(e => e.Idcntlen)
                .HasMaxLength(0)
                .HasColumnName("IDCNTLEN");
            entity.Property(e => e.Idcntpos)
                .HasMaxLength(0)
                .HasColumnName("IDCNTPOS");
            entity.Property(e => e.Idcnttype)
                .HasMaxLength(0)
                .HasColumnName("IDCNTTYPE");
            entity.Property(e => e.Idcntval)
                .HasMaxLength(0)
                .HasColumnName("IDCNTVAL");
            entity.Property(e => e.Idcode1)
                .HasMaxLength(0)
                .HasColumnName("IDCODE1");
            entity.Property(e => e.Idcode2)
                .HasMaxLength(0)
                .HasColumnName("IDCODE2");
            entity.Property(e => e.Idcode3)
                .HasMaxLength(0)
                .HasColumnName("IDCODE3");
            entity.Property(e => e.Idcode4)
                .HasMaxLength(0)
                .HasColumnName("IDCODE4");
            entity.Property(e => e.Idcode5)
                .HasMaxLength(0)
                .HasColumnName("IDCODE5");
            entity.Property(e => e.Idcon0)
                .HasMaxLength(0)
                .HasColumnName("IDCON0");
            entity.Property(e => e.Idcon1)
                .HasMaxLength(0)
                .HasColumnName("IDCON1");
            entity.Property(e => e.Idcon2)
                .HasMaxLength(0)
                .HasColumnName("IDCON2");
            entity.Property(e => e.Idcon3)
                .HasMaxLength(0)
                .HasColumnName("IDCON3");
            entity.Property(e => e.Idcon4)
                .HasMaxLength(0)
                .HasColumnName("IDCON4");
            entity.Property(e => e.Idcon5)
                .HasMaxLength(0)
                .HasColumnName("IDCON5");
            entity.Property(e => e.Idcon6)
                .HasMaxLength(0)
                .HasColumnName("IDCON6");
            entity.Property(e => e.Iddate)
                .HasMaxLength(0)
                .HasColumnName("IDDATE");
            entity.Property(e => e.Idfunpin)
                .HasMaxLength(0)
                .HasColumnName("IDFUNPIN");
            entity.Property(e => e.Idident)
                .HasMaxLength(0)
                .HasColumnName("IDIDENT");
            entity.Property(e => e.Idinflen)
                .HasMaxLength(0)
                .HasColumnName("IDINFLEN");
            entity.Property(e => e.Idinfpos)
                .HasMaxLength(0)
                .HasColumnName("IDINFPOS");
            entity.Property(e => e.Idinftype)
                .HasMaxLength(0)
                .HasColumnName("IDINFTYPE");
            entity.Property(e => e.Idinfval)
                .HasMaxLength(0)
                .HasColumnName("IDINFVAL");
            entity.Property(e => e.Idlen1)
                .HasMaxLength(0)
                .HasColumnName("IDLEN1");
            entity.Property(e => e.Idlen2)
                .HasMaxLength(0)
                .HasColumnName("IDLEN2");
            entity.Property(e => e.Idlen3)
                .HasMaxLength(0)
                .HasColumnName("IDLEN3");
            entity.Property(e => e.Idlen4)
                .HasMaxLength(0)
                .HasColumnName("IDLEN4");
            entity.Property(e => e.Idlen5)
                .HasMaxLength(0)
                .HasColumnName("IDLEN5");
            entity.Property(e => e.Idlenpin)
                .HasMaxLength(0)
                .HasColumnName("IDLENPIN");
            entity.Property(e => e.Idmemo)
                .HasMaxLength(0)
                .HasColumnName("IDMEMO");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(0)
                .HasColumnName("IDNUMBER");
            entity.Property(e => e.Idoffset)
                .HasMaxLength(0)
                .HasColumnName("IDOFFSET");
            entity.Property(e => e.Idpinlen)
                .HasMaxLength(0)
                .HasColumnName("IDPINLEN");
            entity.Property(e => e.Idpinpos)
                .HasMaxLength(0)
                .HasColumnName("IDPINPOS");
            entity.Property(e => e.Idpintype)
                .HasMaxLength(0)
                .HasColumnName("IDPINTYPE");
            entity.Property(e => e.Idpinval)
                .HasMaxLength(0)
                .HasColumnName("IDPINVAL");
            entity.Property(e => e.Idpos1)
                .HasMaxLength(0)
                .HasColumnName("IDPOS1");
            entity.Property(e => e.Idpos2)
                .HasMaxLength(0)
                .HasColumnName("IDPOS2");
            entity.Property(e => e.Idpos3)
                .HasMaxLength(0)
                .HasColumnName("IDPOS3");
            entity.Property(e => e.Idpos4)
                .HasMaxLength(0)
                .HasColumnName("IDPOS4");
            entity.Property(e => e.Idpos5)
                .HasMaxLength(0)
                .HasColumnName("IDPOS5");
            entity.Property(e => e.Idposi1)
                .HasMaxLength(0)
                .HasColumnName("IDPOSI1");
            entity.Property(e => e.Idposi2)
                .HasMaxLength(0)
                .HasColumnName("IDPOSI2");
            entity.Property(e => e.Idposi3)
                .HasMaxLength(0)
                .HasColumnName("IDPOSI3");
            entity.Property(e => e.Idposi4)
                .HasMaxLength(0)
                .HasColumnName("IDPOSI4");
            entity.Property(e => e.Idposi5)
                .HasMaxLength(0)
                .HasColumnName("IDPOSI5");
            entity.Property(e => e.Idtitle)
                .HasMaxLength(0)
                .HasColumnName("IDTITLE");
            entity.Property(e => e.Idtype)
                .HasMaxLength(0)
                .HasColumnName("IDTYPE");
            entity.Property(e => e.Idwho)
                .HasMaxLength(0)
                .HasColumnName("IDWHO");
        });

        modelBuilder.Entity<DboInputadd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INPUTADD");

            entity.Property(e => e.Ipdate)
                .HasMaxLength(0)
                .HasColumnName("IPDATE");
            entity.Property(e => e.Ipident)
                .HasMaxLength(0)
                .HasColumnName("IPIDENT");
            entity.Property(e => e.Ipmemo)
                .HasMaxLength(0)
                .HasColumnName("IPMEMO");
            entity.Property(e => e.Ipnumber)
                .HasMaxLength(0)
                .HasColumnName("IPNUMBER");
            entity.Property(e => e.Iptitle)
                .HasMaxLength(0)
                .HasColumnName("IPTITLE");
            entity.Property(e => e.Iptype)
                .HasMaxLength(0)
                .HasColumnName("IPTYPE");
            entity.Property(e => e.Ipwho)
                .HasMaxLength(0)
                .HasColumnName("IPWHO");
        });

        modelBuilder.Entity<DboInvcharge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVCHARGE");

            entity.Property(e => e.Icdate)
                .HasMaxLength(19)
                .HasColumnName("ICDATE");
            entity.Property(e => e.Icident).HasColumnName("ICIDENT");
            entity.Property(e => e.Icpbident).HasColumnName("ICPBIDENT");
            entity.Property(e => e.Ictitle1)
                .HasMaxLength(8)
                .HasColumnName("ICTITLE1");
            entity.Property(e => e.Ictitle2)
                .HasMaxLength(8)
                .HasColumnName("ICTITLE2");
            entity.Property(e => e.Ictitle3)
                .HasMaxLength(8)
                .HasColumnName("ICTITLE3");
            entity.Property(e => e.Ictitle4)
                .HasMaxLength(8)
                .HasColumnName("ICTITLE4");
            entity.Property(e => e.Ictitle5)
                .HasMaxLength(8)
                .HasColumnName("ICTITLE5");
            entity.Property(e => e.Icvalue1)
                .HasPrecision(3, 2)
                .HasColumnName("ICVALUE1");
            entity.Property(e => e.Icvalue2)
                .HasPrecision(3, 2)
                .HasColumnName("ICVALUE2");
            entity.Property(e => e.Icvalue3)
                .HasPrecision(3, 2)
                .HasColumnName("ICVALUE3");
            entity.Property(e => e.Icvalue4)
                .HasPrecision(3, 2)
                .HasColumnName("ICVALUE4");
            entity.Property(e => e.Icvalue5)
                .HasPrecision(3, 2)
                .HasColumnName("ICVALUE5");
            entity.Property(e => e.Icwho).HasColumnName("ICWHO");
        });

        modelBuilder.Entity<DboInventory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVENTORY");

            entity.Property(e => e.Inact)
                .HasPrecision(9, 3)
                .HasColumnName("INACT");
            entity.Property(e => e.Inbuyprice)
                .HasPrecision(5, 4)
                .HasColumnName("INBUYPRICE");
            entity.Property(e => e.Incoident).HasColumnName("INCOIDENT");
            entity.Property(e => e.Incorr).HasColumnName("INCORR");
            entity.Property(e => e.Indate)
                .HasMaxLength(19)
                .HasColumnName("INDATE");
            entity.Property(e => e.Inident).HasColumnName("INIDENT");
            entity.Property(e => e.Inindate)
                .HasMaxLength(19)
                .HasColumnName("ININDATE");
            entity.Property(e => e.Inmemo)
                .HasMaxLength(0)
                .HasColumnName("INMEMO");
            entity.Property(e => e.Innewwbp)
                .HasPrecision(5, 4)
                .HasColumnName("INNEWWBP");
            entity.Property(e => e.Inpbident).HasColumnName("INPBIDENT");
            entity.Property(e => e.Inquant)
                .HasPrecision(9, 3)
                .HasColumnName("INQUANT");
            entity.Property(e => e.Insellprice)
                .HasPrecision(5, 4)
                .HasColumnName("INSELLPRICE");
            entity.Property(e => e.Instident).HasColumnName("INSTIDENT");
            entity.Property(e => e.Inwbp)
                .HasPrecision(5, 4)
                .HasColumnName("INWBP");
            entity.Property(e => e.Inwho).HasColumnName("INWHO");
        });

        modelBuilder.Entity<DboInvinv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVINV");

            entity.Property(e => e.Iibdisk)
                .HasMaxLength(0)
                .HasColumnName("IIBDISK");
            entity.Property(e => e.Iicnt)
                .HasMaxLength(0)
                .HasColumnName("IICNT");
            entity.Property(e => e.Iidate)
                .HasMaxLength(0)
                .HasColumnName("IIDATE");
            entity.Property(e => e.Iidisc)
                .HasMaxLength(0)
                .HasColumnName("IIDISC");
            entity.Property(e => e.Iidtadate)
                .HasMaxLength(0)
                .HasColumnName("IIDTADATE");
            entity.Property(e => e.Iigross)
                .HasMaxLength(0)
                .HasColumnName("IIGROSS");
            entity.Property(e => e.Iiident)
                .HasMaxLength(0)
                .HasColumnName("IIIDENT");
            entity.Property(e => e.Iinet)
                .HasMaxLength(0)
                .HasColumnName("IINET");
            entity.Property(e => e.Iivat)
                .HasMaxLength(0)
                .HasColumnName("IIVAT");
            entity.Property(e => e.Iiwho)
                .HasMaxLength(0)
                .HasColumnName("IIWHO");
        });

        modelBuilder.Entity<DboInvitem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVITEM");

            entity.Property(e => e.Itcaident1)
                .HasMaxLength(0)
                .HasColumnName("ITCAIDENT1");
            entity.Property(e => e.Itcaident2)
                .HasMaxLength(0)
                .HasColumnName("ITCAIDENT2");
            entity.Property(e => e.Itcano1)
                .HasMaxLength(0)
                .HasColumnName("ITCANO1");
            entity.Property(e => e.Itcano2)
                .HasMaxLength(0)
                .HasColumnName("ITCANO2");
            entity.Property(e => e.Itcurrno)
                .HasMaxLength(0)
                .HasColumnName("ITCURRNO");
            entity.Property(e => e.Itemident)
                .HasMaxLength(0)
                .HasColumnName("ITEMIDENT");
            entity.Property(e => e.Itfuident)
                .HasMaxLength(0)
                .HasColumnName("ITFUIDENT");
            entity.Property(e => e.Itfustat)
                .HasMaxLength(0)
                .HasColumnName("ITFUSTAT");
            entity.Property(e => e.Ithiident)
                .HasMaxLength(0)
                .HasColumnName("ITHIIDENT");
            entity.Property(e => e.Ithiinfo)
                .HasMaxLength(0)
                .HasColumnName("ITHIINFO");
            entity.Property(e => e.Ithours)
                .HasMaxLength(0)
                .HasColumnName("ITHOURS");
            entity.Property(e => e.Itidate)
                .HasMaxLength(0)
                .HasColumnName("ITIDATE");
            entity.Property(e => e.Itident)
                .HasMaxLength(0)
                .HasColumnName("ITIDENT");
            entity.Property(e => e.Itintno)
                .HasMaxLength(0)
                .HasColumnName("ITINTNO");
            entity.Property(e => e.Itinvpbase)
                .HasMaxLength(0)
                .HasColumnName("ITINVPBASE");
            entity.Property(e => e.Itinvprice)
                .HasMaxLength(0)
                .HasColumnName("ITINVPRICE");
            entity.Property(e => e.Itinvtotal)
                .HasMaxLength(0)
                .HasColumnName("ITINVTOTAL");
            entity.Property(e => e.Itipnumber)
                .HasMaxLength(0)
                .HasColumnName("ITIPNUMBER");
            entity.Property(e => e.Itiptitle)
                .HasMaxLength(0)
                .HasColumnName("ITIPTITLE");
            entity.Property(e => e.Itivident)
                .HasMaxLength(0)
                .HasColumnName("ITIVIDENT");
            entity.Property(e => e.Itmiles)
                .HasMaxLength(0)
                .HasColumnName("ITMILES");
            entity.Property(e => e.Itname)
                .HasMaxLength(0)
                .HasColumnName("ITNAME");
            entity.Property(e => e.Itpbident)
                .HasMaxLength(0)
                .HasColumnName("ITPBIDENT");
            entity.Property(e => e.Itperscano)
                .HasMaxLength(0)
                .HasColumnName("ITPERSCANO");
            entity.Property(e => e.Itplate)
                .HasMaxLength(0)
                .HasColumnName("ITPLATE");
            entity.Property(e => e.Itpptotalg)
                .HasMaxLength(0)
                .HasColumnName("ITPPTOTALG");
            entity.Property(e => e.Itpptotaln)
                .HasMaxLength(0)
                .HasColumnName("ITPPTOTALN");
            entity.Property(e => e.Itppvatval)
                .HasMaxLength(0)
                .HasColumnName("ITPPVATVAL");
            entity.Property(e => e.Itprod)
                .HasMaxLength(0)
                .HasColumnName("ITPROD");
            entity.Property(e => e.Itprodnum)
                .HasMaxLength(0)
                .HasColumnName("ITPRODNUM");
            entity.Property(e => e.Itquant)
                .HasMaxLength(0)
                .HasColumnName("ITQUANT");
            entity.Property(e => e.Itrectype)
                .HasMaxLength(0)
                .HasColumnName("ITRECTYPE");
            entity.Property(e => e.Itsptotalg)
                .HasMaxLength(0)
                .HasColumnName("ITSPTOTALG");
            entity.Property(e => e.Itsptotaln)
                .HasMaxLength(0)
                .HasColumnName("ITSPTOTALN");
            entity.Property(e => e.Itspvatval)
                .HasMaxLength(0)
                .HasColumnName("ITSPVATVAL");
            entity.Property(e => e.Ituppprice)
                .HasMaxLength(0)
                .HasColumnName("ITUPPPRICE");
            entity.Property(e => e.Itupppriceg)
                .HasMaxLength(0)
                .HasColumnName("ITUPPPRICEG");
            entity.Property(e => e.Ituspprice)
                .HasMaxLength(0)
                .HasColumnName("ITUSPPRICE");
            entity.Property(e => e.Itusppricen)
                .HasMaxLength(0)
                .HasColumnName("ITUSPPRICEN");
            entity.Property(e => e.Itvat)
                .HasMaxLength(0)
                .HasColumnName("ITVAT");
            entity.Property(e => e.Itvecc)
                .HasMaxLength(0)
                .HasColumnName("ITVECC");
            entity.Property(e => e.Itvehcano)
                .HasMaxLength(0)
                .HasColumnName("ITVEHCANO");
            entity.Property(e => e.Itveident)
                .HasMaxLength(0)
                .HasColumnName("ITVEIDENT");
            entity.Property(e => e.Itvestoc)
                .HasMaxLength(0)
                .HasColumnName("ITVESTOC");
        });

        modelBuilder.Entity<DboInvnum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVNUM");

            entity.Property(e => e.Iucnt).HasColumnName("IUCNT");
            entity.Property(e => e.Iucurr).HasColumnName("IUCURR");
            entity.Property(e => e.Iudate)
                .HasMaxLength(19)
                .HasColumnName("IUDATE");
            entity.Property(e => e.Iufiller).HasColumnName("IUFILLER");
            entity.Property(e => e.Iuident).HasColumnName("IUIDENT");
            entity.Property(e => e.Iuinc).HasColumnName("IUINC");
            entity.Property(e => e.Iulength).HasColumnName("IULENGTH");
            entity.Property(e => e.Iunotype).HasColumnName("IUNOTYPE");
            entity.Property(e => e.Iuresdate)
                .HasMaxLength(19)
                .HasColumnName("IURESDATE");
            entity.Property(e => e.Iustart).HasColumnName("IUSTART");
            entity.Property(e => e.Iutype).HasColumnName("IUTYPE");
            entity.Property(e => e.Iuvalue)
                .HasMaxLength(3)
                .HasColumnName("IUVALUE");
            entity.Property(e => e.Iuwho).HasColumnName("IUWHO");
        });

        modelBuilder.Entity<DboInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVOICE");

            entity.Property(e => e.Ivbdate)
                .HasMaxLength(0)
                .HasColumnName("IVBDATE");
            entity.Property(e => e.Ivbdisk)
                .HasMaxLength(0)
                .HasColumnName("IVBDISK");
            entity.Property(e => e.Ivcancdat)
                .HasMaxLength(0)
                .HasColumnName("IVCANCDAT");
            entity.Property(e => e.Ivcancel)
                .HasMaxLength(0)
                .HasColumnName("IVCANCEL");
            entity.Property(e => e.Ivcashd)
                .HasMaxLength(0)
                .HasColumnName("IVCASHD");
            entity.Property(e => e.Ivcashdtar)
                .HasMaxLength(0)
                .HasColumnName("IVCASHDTAR");
            entity.Property(e => e.Ivcashdv)
                .HasMaxLength(0)
                .HasColumnName("IVCASHDV");
            entity.Property(e => e.Ivchnum)
                .HasMaxLength(0)
                .HasColumnName("IVCHNUM");
            entity.Property(e => e.Ivchtitle)
                .HasMaxLength(0)
                .HasColumnName("IVCHTITLE");
            entity.Property(e => e.Ivchvaltotal)
                .HasMaxLength(0)
                .HasColumnName("IVCHVALTOTAL");
            entity.Property(e => e.Ivchvalunit)
                .HasMaxLength(0)
                .HasColumnName("IVCHVALUNIT");
            entity.Property(e => e.Ivchvat)
                .HasMaxLength(0)
                .HasColumnName("IVCHVAT");
            entity.Property(e => e.Ivchvatval)
                .HasMaxLength(0)
                .HasColumnName("IVCHVATVAL");
            entity.Property(e => e.Ivcnt)
                .HasMaxLength(0)
                .HasColumnName("IVCNT");
            entity.Property(e => e.Ivcoident)
                .HasMaxLength(0)
                .HasColumnName("IVCOIDENT");
            entity.Property(e => e.Ivcuacc)
                .HasMaxLength(0)
                .HasColumnName("IVCUACC");
            entity.Property(e => e.Ivcuban)
                .HasMaxLength(0)
                .HasColumnName("IVCUBAN");
            entity.Property(e => e.Ivcubank)
                .HasMaxLength(0)
                .HasColumnName("IVCUBANK");
            entity.Property(e => e.Ivcucity)
                .HasMaxLength(0)
                .HasColumnName("IVCUCITY");
            entity.Property(e => e.Ivcuctry)
                .HasMaxLength(0)
                .HasColumnName("IVCUCTRY");
            entity.Property(e => e.Ivcuemail)
                .HasMaxLength(0)
                .HasColumnName("IVCUEMAIL");
            entity.Property(e => e.Ivcufax)
                .HasMaxLength(0)
                .HasColumnName("IVCUFAX");
            entity.Property(e => e.Ivcuhp)
                .HasMaxLength(0)
                .HasColumnName("IVCUHP");
            entity.Property(e => e.Ivcuibc)
                .HasMaxLength(0)
                .HasColumnName("IVCUIBC");
            entity.Property(e => e.Ivcuname)
                .HasMaxLength(0)
                .HasColumnName("IVCUNAME");
            entity.Property(e => e.Ivcuno1)
                .HasMaxLength(0)
                .HasColumnName("IVCUNO1");
            entity.Property(e => e.Ivcuno2)
                .HasMaxLength(0)
                .HasColumnName("IVCUNO2");
            entity.Property(e => e.Ivcupb)
                .HasMaxLength(0)
                .HasColumnName("IVCUPB");
            entity.Property(e => e.Ivcuroutno)
                .HasMaxLength(0)
                .HasColumnName("IVCUROUTNO");
            entity.Property(e => e.Ivcustr)
                .HasMaxLength(0)
                .HasColumnName("IVCUSTR");
            entity.Property(e => e.Ivcutel)
                .HasMaxLength(0)
                .HasColumnName("IVCUTEL");
            entity.Property(e => e.Ivcutitle1)
                .HasMaxLength(0)
                .HasColumnName("IVCUTITLE1");
            entity.Property(e => e.Ivcutitle2)
                .HasMaxLength(0)
                .HasColumnName("IVCUTITLE2");
            entity.Property(e => e.Ivcutitle3)
                .HasMaxLength(0)
                .HasColumnName("IVCUTITLE3");
            entity.Property(e => e.Ivcuvatid)
                .HasMaxLength(0)
                .HasColumnName("IVCUVATID");
            entity.Property(e => e.Ivcuzip)
                .HasMaxLength(0)
                .HasColumnName("IVCUZIP");
            entity.Property(e => e.Ivdiscount)
                .HasMaxLength(0)
                .HasColumnName("IVDISCOUNT");
            entity.Property(e => e.Ivdiscspnet)
                .HasMaxLength(0)
                .HasColumnName("IVDISCSPNET");
            entity.Property(e => e.Ivduedate)
                .HasMaxLength(0)
                .HasColumnName("IVDUEDATE");
            entity.Property(e => e.Ivedate)
                .HasMaxLength(0)
                .HasColumnName("IVEDATE");
            entity.Property(e => e.Ivemaildate)
                .HasMaxLength(0)
                .HasColumnName("IVEMAILDATE");
            entity.Property(e => e.Ivexdate)
                .HasMaxLength(0)
                .HasColumnName("IVEXDATE");
            entity.Property(e => e.Ividate)
                .HasMaxLength(0)
                .HasColumnName("IVIDATE");
            entity.Property(e => e.Ivident)
                .HasMaxLength(0)
                .HasColumnName("IVIDENT");
            entity.Property(e => e.Iviiident)
                .HasMaxLength(0)
                .HasColumnName("IVIIIDENT");
            entity.Property(e => e.Ivintern)
                .HasMaxLength(0)
                .HasColumnName("IVINTERN");
            entity.Property(e => e.Ivinvtotal)
                .HasMaxLength(0)
                .HasColumnName("IVINVTOTAL");
            entity.Property(e => e.Ivisacc1)
                .HasMaxLength(0)
                .HasColumnName("IVISACC1");
            entity.Property(e => e.Ivisacc2)
                .HasMaxLength(0)
                .HasColumnName("IVISACC2");
            entity.Property(e => e.Ivisacc3)
                .HasMaxLength(0)
                .HasColumnName("IVISACC3");
            entity.Property(e => e.Ivisban1)
                .HasMaxLength(0)
                .HasColumnName("IVISBAN1");
            entity.Property(e => e.Ivisban2)
                .HasMaxLength(0)
                .HasColumnName("IVISBAN2");
            entity.Property(e => e.Ivisban3)
                .HasMaxLength(0)
                .HasColumnName("IVISBAN3");
            entity.Property(e => e.Ivisbank1)
                .HasMaxLength(0)
                .HasColumnName("IVISBANK1");
            entity.Property(e => e.Ivisbank2)
                .HasMaxLength(0)
                .HasColumnName("IVISBANK2");
            entity.Property(e => e.Ivisbank3)
                .HasMaxLength(0)
                .HasColumnName("IVISBANK3");
            entity.Property(e => e.Iviscity)
                .HasMaxLength(0)
                .HasColumnName("IVISCITY");
            entity.Property(e => e.Ivisctry)
                .HasMaxLength(0)
                .HasColumnName("IVISCTRY");
            entity.Property(e => e.Ivisemail)
                .HasMaxLength(0)
                .HasColumnName("IVISEMAIL");
            entity.Property(e => e.Ivisfax)
                .HasMaxLength(0)
                .HasColumnName("IVISFAX");
            entity.Property(e => e.Ivishp)
                .HasMaxLength(0)
                .HasColumnName("IVISHP");
            entity.Property(e => e.Ivisibc1)
                .HasMaxLength(0)
                .HasColumnName("IVISIBC1");
            entity.Property(e => e.Ivisibc2)
                .HasMaxLength(0)
                .HasColumnName("IVISIBC2");
            entity.Property(e => e.Ivisibc3)
                .HasMaxLength(0)
                .HasColumnName("IVISIBC3");
            entity.Property(e => e.Ivispb)
                .HasMaxLength(0)
                .HasColumnName("IVISPB");
            entity.Property(e => e.Ivisroutno1)
                .HasMaxLength(0)
                .HasColumnName("IVISROUTNO1");
            entity.Property(e => e.Ivisroutno2)
                .HasMaxLength(0)
                .HasColumnName("IVISROUTNO2");
            entity.Property(e => e.Ivisroutno3)
                .HasMaxLength(0)
                .HasColumnName("IVISROUTNO3");
            entity.Property(e => e.Ivisstr)
                .HasMaxLength(0)
                .HasColumnName("IVISSTR");
            entity.Property(e => e.Ivistel)
                .HasMaxLength(0)
                .HasColumnName("IVISTEL");
            entity.Property(e => e.Ivistext)
                .HasMaxLength(0)
                .HasColumnName("IVISTEXT");
            entity.Property(e => e.Ivistitle1)
                .HasMaxLength(0)
                .HasColumnName("IVISTITLE1");
            entity.Property(e => e.Ivistitle2)
                .HasMaxLength(0)
                .HasColumnName("IVISTITLE2");
            entity.Property(e => e.Ivistitle3)
                .HasMaxLength(0)
                .HasColumnName("IVISTITLE3");
            entity.Property(e => e.Ivisvatid)
                .HasMaxLength(0)
                .HasColumnName("IVISVATID");
            entity.Property(e => e.Iviszip)
                .HasMaxLength(0)
                .HasColumnName("IVISZIP");
            entity.Property(e => e.Ivmaid)
                .HasMaxLength(0)
                .HasColumnName("IVMAID");
            entity.Property(e => e.Ivmanager1)
                .HasMaxLength(0)
                .HasColumnName("IVMANAGER1");
            entity.Property(e => e.Ivmanager2)
                .HasMaxLength(0)
                .HasColumnName("IVMANAGER2");
            entity.Property(e => e.Ivmanager3)
                .HasMaxLength(0)
                .HasColumnName("IVMANAGER3");
            entity.Property(e => e.Ivno)
                .HasMaxLength(0)
                .HasColumnName("IVNO");
            entity.Property(e => e.Ivpaydate)
                .HasMaxLength(0)
                .HasColumnName("IVPAYDATE");
            entity.Property(e => e.Ivpaytype)
                .HasMaxLength(0)
                .HasColumnName("IVPAYTYPE");
            entity.Property(e => e.Ivpdfdate)
                .HasMaxLength(0)
                .HasColumnName("IVPDFDATE");
            entity.Property(e => e.Ivppgross)
                .HasMaxLength(0)
                .HasColumnName("IVPPGROSS");
            entity.Property(e => e.Ivppnet)
                .HasMaxLength(0)
                .HasColumnName("IVPPNET");
            entity.Property(e => e.Ivprenot)
                .HasMaxLength(0)
                .HasColumnName("IVPRENOT");
            entity.Property(e => e.Ivprint)
                .HasMaxLength(0)
                .HasColumnName("IVPRINT");
            entity.Property(e => e.Ivprintdate)
                .HasMaxLength(0)
                .HasColumnName("IVPRINTDATE");
            entity.Property(e => e.Ivregcourt)
                .HasMaxLength(0)
                .HasColumnName("IVREGCOURT");
            entity.Property(e => e.Ivsdate)
                .HasMaxLength(0)
                .HasColumnName("IVSDATE");
            entity.Property(e => e.Ivsepaexpdat)
                .HasMaxLength(0)
                .HasColumnName("IVSEPAEXPDAT");
            entity.Property(e => e.Ivsepaform)
                .HasMaxLength(0)
                .HasColumnName("IVSEPAFORM");
            entity.Property(e => e.Ivsepapredat)
                .HasMaxLength(0)
                .HasColumnName("IVSEPAPREDAT");
            entity.Property(e => e.Ivsepatype)
                .HasMaxLength(0)
                .HasColumnName("IVSEPATYPE");
            entity.Property(e => e.Ivseqtype)
                .HasMaxLength(0)
                .HasColumnName("IVSEQTYPE");
            entity.Property(e => e.Ivspgross)
                .HasMaxLength(0)
                .HasColumnName("IVSPGROSS");
            entity.Property(e => e.Ivspnet)
                .HasMaxLength(0)
                .HasColumnName("IVSPNET");
            entity.Property(e => e.Ivtardate)
                .HasMaxLength(0)
                .HasColumnName("IVTARDATE");
            entity.Property(e => e.Ivtype)
                .HasMaxLength(0)
                .HasColumnName("IVTYPE");
            entity.Property(e => e.Ivuci)
                .HasMaxLength(0)
                .HasColumnName("IVUCI");
            entity.Property(e => e.Ivvat1)
                .HasMaxLength(0)
                .HasColumnName("IVVAT1");
            entity.Property(e => e.Ivvat2)
                .HasMaxLength(0)
                .HasColumnName("IVVAT2");
            entity.Property(e => e.Ivvat3)
                .HasMaxLength(0)
                .HasColumnName("IVVAT3");
            entity.Property(e => e.Ivvatdisc1)
                .HasMaxLength(0)
                .HasColumnName("IVVATDISC1");
            entity.Property(e => e.Ivvatdisc2)
                .HasMaxLength(0)
                .HasColumnName("IVVATDISC2");
            entity.Property(e => e.Ivvatdisc3)
                .HasMaxLength(0)
                .HasColumnName("IVVATDISC3");
            entity.Property(e => e.Ivvattot1)
                .HasMaxLength(0)
                .HasColumnName("IVVATTOT1");
            entity.Property(e => e.Ivvattot2)
                .HasMaxLength(0)
                .HasColumnName("IVVATTOT2");
            entity.Property(e => e.Ivvattot3)
                .HasMaxLength(0)
                .HasColumnName("IVVATTOT3");
            entity.Property(e => e.Ivvatval1)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL1");
            entity.Property(e => e.Ivvatval1n)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL1N");
            entity.Property(e => e.Ivvatval2)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL2");
            entity.Property(e => e.Ivvatval2n)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL2N");
            entity.Property(e => e.Ivvatval3)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL3");
            entity.Property(e => e.Ivvatval3n)
                .HasMaxLength(0)
                .HasColumnName("IVVATVAL3N");
        });

        modelBuilder.Entity<DboInvspec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.INVSPEC");

            entity.Property(e => e.Iecdisc).HasColumnName("IECDISC");
            entity.Property(e => e.Iecdisctar).HasColumnName("IECDISCTAR");
            entity.Property(e => e.Iecharge).HasColumnName("IECHARGE");
            entity.Property(e => e.Iedate)
                .HasMaxLength(19)
                .HasColumnName("IEDATE");
            entity.Property(e => e.Iediident).HasColumnName("IEDIIDENT");
            entity.Property(e => e.Ieident).HasColumnName("IEIDENT");
            entity.Property(e => e.Ieintern).HasColumnName("IEINTERN");
            entity.Property(e => e.Ieintype).HasColumnName("IEINTYPE");
            entity.Property(e => e.Iepayment).HasColumnName("IEPAYMENT");
            entity.Property(e => e.Iepaytext)
                .HasMaxLength(31)
                .HasColumnName("IEPAYTEXT");
            entity.Property(e => e.Ieprident).HasColumnName("IEPRIDENT");
            entity.Property(e => e.Ieprint).HasColumnName("IEPRINT");
            entity.Property(e => e.Ietardays).HasColumnName("IETARDAYS");
            entity.Property(e => e.Ietitle)
                .HasMaxLength(49)
                .HasColumnName("IETITLE");
            entity.Property(e => e.Ietype).HasColumnName("IETYPE");
            entity.Property(e => e.Iewho).HasColumnName("IEWHO");
        });

        modelBuilder.Entity<DboLevel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.LEVEL");

            entity.Property(e => e.Ledate)
                .HasMaxLength(19)
                .HasColumnName("LEDATE");
            entity.Property(e => e.Leident).HasColumnName("LEIDENT");
            entity.Property(e => e.Lelevel).HasColumnName("LELEVEL");
            entity.Property(e => e.Lemenu).HasColumnName("LEMENU");
            entity.Property(e => e.Letext)
                .HasMaxLength(12)
                .HasColumnName("LETEXT");
            entity.Property(e => e.Letype).HasColumnName("LETYPE");
            entity.Property(e => e.Lewho).HasColumnName("LEWHO");
        });

        modelBuilder.Entity<DboLeveldatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.LEVELDATA");

            entity.Property(e => e.Ldauident)
                .HasMaxLength(0)
                .HasColumnName("LDAUIDENT");
            entity.Property(e => e.Lddate)
                .HasMaxLength(0)
                .HasColumnName("LDDATE");
            entity.Property(e => e.Lddate2)
                .HasMaxLength(0)
                .HasColumnName("LDDATE2");
            entity.Property(e => e.Lddensity)
                .HasMaxLength(0)
                .HasColumnName("LDDENSITY");
            entity.Property(e => e.Ldident)
                .HasMaxLength(0)
                .HasColumnName("LDIDENT");
            entity.Property(e => e.Ldplevel)
                .HasMaxLength(0)
                .HasColumnName("LDPLEVEL");
            entity.Property(e => e.Ldprobe)
                .HasMaxLength(0)
                .HasColumnName("LDPROBE");
            entity.Property(e => e.Ldtemp)
                .HasMaxLength(0)
                .HasColumnName("LDTEMP");
            entity.Property(e => e.Ldwlevel)
                .HasMaxLength(0)
                .HasColumnName("LDWLEVEL");
        });

        modelBuilder.Entity<DboLevelmeter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.LEVELMETER");

            entity.Property(e => e.Lmactive).HasColumnName("LMACTIVE");
            entity.Property(e => e.Lmauident).HasColumnName("LMAUIDENT");
            entity.Property(e => e.Lmbaud).HasColumnName("LMBAUD");
            entity.Property(e => e.Lmdate)
                .HasMaxLength(19)
                .HasColumnName("LMDATE");
            entity.Property(e => e.Lmformat).HasColumnName("LMFORMAT");
            entity.Property(e => e.Lmheight).HasColumnName("LMHEIGHT");
            entity.Property(e => e.Lmident).HasColumnName("LMIDENT");
            entity.Property(e => e.Lmnumber)
                .HasMaxLength(0)
                .HasColumnName("LMNUMBER");
            entity.Property(e => e.Lmport).HasColumnName("LMPORT");
            entity.Property(e => e.Lmpos01).HasColumnName("LMPOS01");
            entity.Property(e => e.Lmpos02).HasColumnName("LMPOS02");
            entity.Property(e => e.Lmpos03).HasColumnName("LMPOS03");
            entity.Property(e => e.Lmpos04).HasColumnName("LMPOS04");
            entity.Property(e => e.Lmpos05).HasColumnName("LMPOS05");
            entity.Property(e => e.Lmpos06).HasColumnName("LMPOS06");
            entity.Property(e => e.Lmpos07).HasColumnName("LMPOS07");
            entity.Property(e => e.Lmpos08).HasColumnName("LMPOS08");
            entity.Property(e => e.Lmpos09).HasColumnName("LMPOS09");
            entity.Property(e => e.Lmpos10).HasColumnName("LMPOS10");
            entity.Property(e => e.Lmprottype).HasColumnName("LMPROTTYPE");
            entity.Property(e => e.Lmstident01).HasColumnName("LMSTIDENT01");
            entity.Property(e => e.Lmstident02).HasColumnName("LMSTIDENT02");
            entity.Property(e => e.Lmstident03).HasColumnName("LMSTIDENT03");
            entity.Property(e => e.Lmstident04).HasColumnName("LMSTIDENT04");
            entity.Property(e => e.Lmstident05).HasColumnName("LMSTIDENT05");
            entity.Property(e => e.Lmstident06).HasColumnName("LMSTIDENT06");
            entity.Property(e => e.Lmstident07).HasColumnName("LMSTIDENT07");
            entity.Property(e => e.Lmstident08).HasColumnName("LMSTIDENT08");
            entity.Property(e => e.Lmstident09).HasColumnName("LMSTIDENT09");
            entity.Property(e => e.Lmstident10).HasColumnName("LMSTIDENT10");
            entity.Property(e => e.Lmtitle)
                .HasMaxLength(0)
                .HasColumnName("LMTITLE");
            entity.Property(e => e.Lmwho).HasColumnName("LMWHO");
        });

        modelBuilder.Entity<DboLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.LOGIN");

            entity.Property(e => e.Loadmin).HasColumnName("LOADMIN");
            entity.Property(e => e.Lodate)
                .HasMaxLength(19)
                .HasColumnName("LODATE");
            entity.Property(e => e.Loident)
                .HasColumnType("mediumint")
                .HasColumnName("LOIDENT");
            entity.Property(e => e.Loprog)
                .HasMaxLength(25)
                .HasColumnName("LOPROG");
            entity.Property(e => e.Lotype).HasColumnName("LOTYPE");
            entity.Property(e => e.Lowho).HasColumnName("LOWHO");
        });

        modelBuilder.Entity<DboMclient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.MCLIENT");

            entity.Property(e => e.Mcdate)
                .HasMaxLength(19)
                .HasColumnName("MCDATE");
            entity.Property(e => e.Mcident).HasColumnName("MCIDENT");
            entity.Property(e => e.Mcmemo)
                .HasMaxLength(0)
                .HasColumnName("MCMEMO");
            entity.Property(e => e.Mcnum).HasColumnName("MCNUM");
            entity.Property(e => e.Mctitle)
                .HasMaxLength(7)
                .HasColumnName("MCTITLE");
        });

        modelBuilder.Entity<DboNscspec>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.NSCSPEC");

            entity.Property(e => e.Nsauident)
                .HasMaxLength(0)
                .HasColumnName("NSAUIDENT");
            entity.Property(e => e.Nscaldate)
                .HasMaxLength(0)
                .HasColumnName("NSCALDATE");
            entity.Property(e => e.Nscalstr)
                .HasMaxLength(0)
                .HasColumnName("NSCALSTR");
            entity.Property(e => e.Nscalsum)
                .HasMaxLength(0)
                .HasColumnName("NSCALSUM");
            entity.Property(e => e.Nsclocktime)
                .HasMaxLength(0)
                .HasColumnName("NSCLOCKTIME");
            entity.Property(e => e.Nsdate)
                .HasMaxLength(0)
                .HasColumnName("NSDATE");
            entity.Property(e => e.Nsdial1)
                .HasMaxLength(0)
                .HasColumnName("NSDIAL1");
            entity.Property(e => e.Nsdial2)
                .HasMaxLength(0)
                .HasColumnName("NSDIAL2");
            entity.Property(e => e.Nsdial3)
                .HasMaxLength(0)
                .HasColumnName("NSDIAL3");
            entity.Property(e => e.Nsdial4)
                .HasMaxLength(0)
                .HasColumnName("NSDIAL4");
            entity.Property(e => e.Nsdial5)
                .HasMaxLength(0)
                .HasColumnName("NSDIAL5");
            entity.Property(e => e.Nshwstr)
                .HasMaxLength(0)
                .HasColumnName("NSHWSTR");
            entity.Property(e => e.Nsident)
                .HasMaxLength(0)
                .HasColumnName("NSIDENT");
            entity.Property(e => e.Nsnochange)
                .HasMaxLength(0)
                .HasColumnName("NSNOCHANGE");
            entity.Property(e => e.Nstintern)
                .HasMaxLength(0)
                .HasColumnName("NSTINTERN");
            entity.Property(e => e.Nstprice)
                .HasMaxLength(0)
                .HasColumnName("NSTPRICE");
            entity.Property(e => e.Nstype1)
                .HasMaxLength(0)
                .HasColumnName("NSTYPE1");
            entity.Property(e => e.Nstype2)
                .HasMaxLength(0)
                .HasColumnName("NSTYPE2");
            entity.Property(e => e.Nstype3)
                .HasMaxLength(0)
                .HasColumnName("NSTYPE3");
            entity.Property(e => e.Nstype4)
                .HasMaxLength(0)
                .HasColumnName("NSTYPE4");
            entity.Property(e => e.Nstype5)
                .HasMaxLength(0)
                .HasColumnName("NSTYPE5");
            entity.Property(e => e.Nswho)
                .HasMaxLength(0)
                .HasColumnName("NSWHO");
        });

        modelBuilder.Entity<DboNscstat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.NSCSTAT");

            entity.Property(e => e.Ntauident)
                .HasMaxLength(0)
                .HasColumnName("NTAUIDENT");
            entity.Property(e => e.Ntbnwrecno)
                .HasMaxLength(0)
                .HasColumnName("NTBNWRECNO");
            entity.Property(e => e.Ntdate)
                .HasMaxLength(0)
                .HasColumnName("NTDATE");
            entity.Property(e => e.Ntejdate)
                .HasMaxLength(0)
                .HasColumnName("NTEJDATE");
            entity.Property(e => e.Ntejnum)
                .HasMaxLength(0)
                .HasColumnName("NTEJNUM");
            entity.Property(e => e.Ntejstat)
                .HasMaxLength(0)
                .HasColumnName("NTEJSTAT");
            entity.Property(e => e.Ntendgap)
                .HasMaxLength(0)
                .HasColumnName("NTENDGAP");
            entity.Property(e => e.Ntident)
                .HasMaxLength(0)
                .HasColumnName("NTIDENT");
            entity.Property(e => e.Ntlastblno)
                .HasMaxLength(0)
                .HasColumnName("NTLASTBLNO");
            entity.Property(e => e.Ntnozzle)
                .HasMaxLength(0)
                .HasColumnName("NTNOZZLE");
            entity.Property(e => e.Ntnscbl)
                .HasMaxLength(0)
                .HasColumnName("NTNSCBL");
            entity.Property(e => e.Ntnscerr)
                .HasMaxLength(0)
                .HasColumnName("NTNSCERR");
            entity.Property(e => e.Ntnscstat)
                .HasMaxLength(0)
                .HasColumnName("NTNSCSTAT");
            entity.Property(e => e.Ntpcbl)
                .HasMaxLength(0)
                .HasColumnName("NTPCBL");
            entity.Property(e => e.Ntrecno)
                .HasMaxLength(0)
                .HasColumnName("NTRECNO");
            entity.Property(e => e.Ntrespbl)
                .HasMaxLength(0)
                .HasColumnName("NTRESPBL");
            entity.Property(e => e.Ntrespnum)
                .HasMaxLength(0)
                .HasColumnName("NTRESPNUM");
            entity.Property(e => e.Ntrrdate)
                .HasMaxLength(0)
                .HasColumnName("NTRRDATE");
            entity.Property(e => e.Ntrrstat)
                .HasMaxLength(0)
                .HasColumnName("NTRRSTAT");
            entity.Property(e => e.Ntstartgap)
                .HasMaxLength(0)
                .HasColumnName("NTSTARTGAP");
            entity.Property(e => e.Nttanum)
                .HasMaxLength(0)
                .HasColumnName("NTTANUM");
            entity.Property(e => e.Ntterm)
                .HasMaxLength(0)
                .HasColumnName("NTTERM");
            entity.Property(e => e.Ntterm1e)
                .HasMaxLength(0)
                .HasColumnName("NTTERM1E");
            entity.Property(e => e.Ntterm1rpe)
                .HasMaxLength(0)
                .HasColumnName("NTTERM1RPE");
            entity.Property(e => e.Ntterm1rps)
                .HasMaxLength(0)
                .HasColumnName("NTTERM1RPS");
            entity.Property(e => e.Ntterm1s)
                .HasMaxLength(0)
                .HasColumnName("NTTERM1S");
            entity.Property(e => e.Ntterm2e)
                .HasMaxLength(0)
                .HasColumnName("NTTERM2E");
            entity.Property(e => e.Ntterm2rpe)
                .HasMaxLength(0)
                .HasColumnName("NTTERM2RPE");
            entity.Property(e => e.Ntterm2rps)
                .HasMaxLength(0)
                .HasColumnName("NTTERM2RPS");
            entity.Property(e => e.Ntterm2s)
                .HasMaxLength(0)
                .HasColumnName("NTTERM2S");
            entity.Property(e => e.Nttrnum)
                .HasMaxLength(0)
                .HasColumnName("NTTRNUM");
            entity.Property(e => e.Nttrstat)
                .HasMaxLength(0)
                .HasColumnName("NTTRSTAT");
            entity.Property(e => e.Ntwho)
                .HasMaxLength(0)
                .HasColumnName("NTWHO");
        });

        modelBuilder.Entity<DboOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ORDERS");

            entity.Property(e => e.Orauident).HasColumnName("ORAUIDENT");
            entity.Property(e => e.Orcnt).HasColumnName("ORCNT");
            entity.Property(e => e.Ordata).HasColumnName("ORDATA");
            entity.Property(e => e.Ordate)
                .HasMaxLength(19)
                .HasColumnName("ORDATE");
            entity.Property(e => e.Orerror).HasColumnName("ORERROR");
            entity.Property(e => e.Orident)
                .HasColumnType("mediumint")
                .HasColumnName("ORIDENT");
            entity.Property(e => e.Orprogno).HasColumnName("ORPROGNO");
            entity.Property(e => e.Orrqno).HasColumnName("ORRQNO");
            entity.Property(e => e.Orstart)
                .HasMaxLength(0)
                .HasColumnName("ORSTART");
            entity.Property(e => e.Orstate).HasColumnName("ORSTATE");
            entity.Property(e => e.Orwho).HasColumnName("ORWHO");
        });

        modelBuilder.Entity<DboOverview>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.OVERVIEWS");

            entity.Property(e => e.Ovcolnum).HasColumnName("OVCOLNUM");
            entity.Property(e => e.Ovcolsize).HasColumnName("OVCOLSIZE");
            entity.Property(e => e.Ovcoltitle)
                .HasMaxLength(11)
                .HasColumnName("OVCOLTITLE");
            entity.Property(e => e.Ovcolustitle)
                .HasMaxLength(20)
                .HasColumnName("OVCOLUSTITLE");
            entity.Property(e => e.Ovdate)
                .HasMaxLength(19)
                .HasColumnName("OVDATE");
            entity.Property(e => e.Ovident).HasColumnName("OVIDENT");
            entity.Property(e => e.Ovnum)
                .HasColumnType("mediumint")
                .HasColumnName("OVNUM");
            entity.Property(e => e.Ovusident).HasColumnName("OVUSIDENT");
        });

        modelBuilder.Entity<DboOvsort>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.OVSORT");

            entity.Property(e => e.Osdate)
                .HasMaxLength(19)
                .HasColumnName("OSDATE");
            entity.Property(e => e.Osfilter).HasColumnName("OSFILTER");
            entity.Property(e => e.Osident).HasColumnName("OSIDENT");
            entity.Property(e => e.Osovnum)
                .HasColumnType("mediumint")
                .HasColumnName("OSOVNUM");
            entity.Property(e => e.Ossort1)
                .HasMaxLength(8)
                .HasColumnName("OSSORT1");
            entity.Property(e => e.Ossort2)
                .HasMaxLength(0)
                .HasColumnName("OSSORT2");
            entity.Property(e => e.Ossort3)
                .HasMaxLength(0)
                .HasColumnName("OSSORT3");
            entity.Property(e => e.Ossort4)
                .HasMaxLength(0)
                .HasColumnName("OSSORT4");
            entity.Property(e => e.Ossort5)
                .HasMaxLength(0)
                .HasColumnName("OSSORT5");
            entity.Property(e => e.Ostitle)
                .HasMaxLength(25)
                .HasColumnName("OSTITLE");
            entity.Property(e => e.Osusident).HasColumnName("OSUSIDENT");
        });

        modelBuilder.Entity<DboPbase>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PBASE");

            entity.Property(e => e.Pbdate)
                .HasMaxLength(19)
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(0)
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(0)
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbimport).HasColumnName("PBIMPORT");
            entity.Property(e => e.Pbmemo)
                .HasMaxLength(0)
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnscnum).HasColumnName("PBNSCNUM");
            entity.Property(e => e.Pbnsconln)
                .HasMaxLength(0)
                .HasColumnName("PBNSCONLN");
            entity.Property(e => e.Pbnsconlt)
                .HasMaxLength(0)
                .HasColumnName("PBNSCONLT");
            entity.Property(e => e.Pbnscptf1).HasColumnName("PBNSCPTF1");
            entity.Property(e => e.Pbnscptf2).HasColumnName("PBNSCPTF2");
            entity.Property(e => e.Pbnscrcpt)
                .HasMaxLength(0)
                .HasColumnName("PBNSCRCPT");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(5)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(43)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbtype).HasColumnName("PBTYPE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
        });

        modelBuilder.Entity<DboPgroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PGROUP");

            entity.Property(e => e.Pgco2)
                .HasPrecision(4, 3)
                .HasColumnName("PGCO2");
            entity.Property(e => e.Pgdate)
                .HasMaxLength(19)
                .HasColumnName("PGDATE");
            entity.Property(e => e.Pgfltype).HasColumnName("PGFLTYPE");
            entity.Property(e => e.Pgident).HasColumnName("PGIDENT");
            entity.Property(e => e.Pgmemo)
                .HasMaxLength(0)
                .HasColumnName("PGMEMO");
            entity.Property(e => e.Pgnumber)
                .HasMaxLength(4)
                .HasColumnName("PGNUMBER");
            entity.Property(e => e.Pgtitle)
                .HasMaxLength(12)
                .HasColumnName("PGTITLE");
            entity.Property(e => e.Pgwho).HasColumnName("PGWHO");
        });

        modelBuilder.Entity<DboPprice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PPRICE");

            entity.Property(e => e.Ppdate)
                .HasMaxLength(19)
                .HasColumnName("PPDATE");
            entity.Property(e => e.Ppeffdate)
                .HasMaxLength(19)
                .HasColumnName("PPEFFDATE");
            entity.Property(e => e.Ppfuident).HasColumnName("PPFUIDENT");
            entity.Property(e => e.Ppident).HasColumnName("PPIDENT");
            entity.Property(e => e.Pppbident).HasColumnName("PPPBIDENT");
            entity.Property(e => e.Ppprice)
                .HasPrecision(5, 4)
                .HasColumnName("PPPRICE");
            entity.Property(e => e.Pptype).HasColumnName("PPTYPE");
            entity.Property(e => e.Ppvaident).HasColumnName("PPVAIDENT");
            entity.Property(e => e.Ppvat)
                .HasPrecision(4, 2)
                .HasColumnName("PPVAT");
            entity.Property(e => e.Ppwho).HasColumnName("PPWHO");
        });

        modelBuilder.Entity<DboPreauth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PREAUTH");

            entity.Property(e => e.Paauident)
                .HasMaxLength(0)
                .HasColumnName("PAAUIDENT");
            entity.Property(e => e.Pacar)
                .HasMaxLength(0)
                .HasColumnName("PACAR");
            entity.Property(e => e.Pacard)
                .HasMaxLength(0)
                .HasColumnName("PACARD");
            entity.Property(e => e.Padate)
                .HasMaxLength(0)
                .HasColumnName("PADATE");
            entity.Property(e => e.Paident)
                .HasMaxLength(0)
                .HasColumnName("PAIDENT");
            entity.Property(e => e.Pareceipt)
                .HasMaxLength(0)
                .HasColumnName("PARECEIPT");
            entity.Property(e => e.Patruck)
                .HasMaxLength(0)
                .HasColumnName("PATRUCK");
            entity.Property(e => e.Pawho)
                .HasMaxLength(0)
                .HasColumnName("PAWHO");
        });

        modelBuilder.Entity<DboPrepaid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PREPAID");

            entity.Property(e => e.Peact)
                .HasMaxLength(0)
                .HasColumnName("PEACT");
            entity.Property(e => e.Peactdate)
                .HasMaxLength(0)
                .HasColumnName("PEACTDATE");
            entity.Property(e => e.Pecaident)
                .HasMaxLength(0)
                .HasColumnName("PECAIDENT");
            entity.Property(e => e.Pechange)
                .HasMaxLength(0)
                .HasColumnName("PECHANGE");
            entity.Property(e => e.Pedate)
                .HasMaxLength(0)
                .HasColumnName("PEDATE");
            entity.Property(e => e.Pedownload)
                .HasMaxLength(0)
                .HasColumnName("PEDOWNLOAD");
            entity.Property(e => e.Peident)
                .HasMaxLength(0)
                .HasColumnName("PEIDENT");
            entity.Property(e => e.Pewho)
                .HasMaxLength(0)
                .HasColumnName("PEWHO");
        });

        modelBuilder.Entity<DboPricing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PRICING");

            entity.Property(e => e.Prdate)
                .HasMaxLength(19)
                .HasColumnName("PRDATE");
            entity.Property(e => e.Prident).HasColumnName("PRIDENT");
            entity.Property(e => e.Prtitle)
                .HasMaxLength(26)
                .HasColumnName("PRTITLE");
            entity.Property(e => e.Prwho).HasColumnName("PRWHO");
        });

        modelBuilder.Entity<DboPricprod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PRICPROD");

            entity.Property(e => e.Pidate)
                .HasMaxLength(19)
                .HasColumnName("PIDATE");
            entity.Property(e => e.Piident).HasColumnName("PIIDENT");
            entity.Property(e => e.Pipbident).HasColumnName("PIPBIDENT");
            entity.Property(e => e.Piprident).HasColumnName("PIPRIDENT");
            entity.Property(e => e.Pitype).HasColumnName("PITYPE");
            entity.Property(e => e.Pivaldat)
                .HasMaxLength(19)
                .HasColumnName("PIVALDAT");
            entity.Property(e => e.Pivaltype).HasColumnName("PIVALTYPE");
            entity.Property(e => e.Pivalue)
                .HasPrecision(5, 4)
                .HasColumnName("PIVALUE");
            entity.Property(e => e.Piwho).HasColumnName("PIWHO");
        });

        modelBuilder.Entity<DboPtype>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.PTYPE");

            entity.Property(e => e.Ptdate)
                .HasMaxLength(19)
                .HasColumnName("PTDATE");
            entity.Property(e => e.Ptfltype).HasColumnName("PTFLTYPE");
            entity.Property(e => e.Ptident).HasColumnName("PTIDENT");
            entity.Property(e => e.Ptmemo)
                .HasMaxLength(0)
                .HasColumnName("PTMEMO");
            entity.Property(e => e.Ptnumber)
                .HasMaxLength(11)
                .HasColumnName("PTNUMBER");
            entity.Property(e => e.Ptquident).HasColumnName("PTQUIDENT");
            entity.Property(e => e.Pttitle)
                .HasMaxLength(21)
                .HasColumnName("PTTITLE");
            entity.Property(e => e.Pttype).HasColumnName("PTTYPE");
            entity.Property(e => e.Ptwho).HasColumnName("PTWHO");
        });

        modelBuilder.Entity<DboQueue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.QUEUES");

            entity.Property(e => e.Qeauident).HasColumnName("QEAUIDENT");
            entity.Property(e => e.Qeblockno).HasColumnName("QEBLOCKNO");
            entity.Property(e => e.Qecnt).HasColumnName("QECNT");
            entity.Property(e => e.Qedata)
                .HasMaxLength(56)
                .HasColumnName("QEDATA");
            entity.Property(e => e.Qedate)
                .HasMaxLength(19)
                .HasColumnName("QEDATE");
            entity.Property(e => e.Qeident)
                .HasColumnType("mediumint")
                .HasColumnName("QEIDENT");
            entity.Property(e => e.Qeorident)
                .HasColumnType("mediumint")
                .HasColumnName("QEORIDENT");
            entity.Property(e => e.Qerqno).HasColumnName("QERQNO");
            entity.Property(e => e.Qestate).HasColumnName("QESTATE");
        });

        modelBuilder.Entity<DboQunit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.QUNITS");

            entity.Property(e => e.Qudate)
                .HasMaxLength(19)
                .HasColumnName("QUDATE");
            entity.Property(e => e.Qufltype).HasColumnName("QUFLTYPE");
            entity.Property(e => e.Quident).HasColumnName("QUIDENT");
            entity.Property(e => e.Qumemo)
                .HasMaxLength(0)
                .HasColumnName("QUMEMO");
            entity.Property(e => e.Qunumber)
                .HasMaxLength(3)
                .HasColumnName("QUNUMBER");
            entity.Property(e => e.Qutitle)
                .HasMaxLength(10)
                .HasColumnName("QUTITLE");
            entity.Property(e => e.Quwho).HasColumnName("QUWHO");
        });

        modelBuilder.Entity<DboReference>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.REFERENCE");

            entity.Property(e => e.Readdin).HasColumnName("READDIN");
            entity.Property(e => e.Reapgroup).HasColumnName("REAPGROUP");
            entity.Property(e => e.Reapident).HasColumnName("REAPIDENT");
            entity.Property(e => e.Reapident10).HasColumnName("REAPIDENT10");
            entity.Property(e => e.Reapident2).HasColumnName("REAPIDENT2");
            entity.Property(e => e.Reapident3).HasColumnName("REAPIDENT3");
            entity.Property(e => e.Reapident4).HasColumnName("REAPIDENT4");
            entity.Property(e => e.Reapident5).HasColumnName("REAPIDENT5");
            entity.Property(e => e.Reapident6).HasColumnName("REAPIDENT6");
            entity.Property(e => e.Reapident7).HasColumnName("REAPIDENT7");
            entity.Property(e => e.Reapident8).HasColumnName("REAPIDENT8");
            entity.Property(e => e.Reapident9).HasColumnName("REAPIDENT9");
            entity.Property(e => e.Reatt).HasColumnName("REATT");
            entity.Property(e => e.Reauident).HasColumnName("REAUIDENT");
            entity.Property(e => e.Reautocnt).HasColumnName("REAUTOCNT");
            entity.Property(e => e.Recaident).HasColumnName("RECAIDENT");
            entity.Property(e => e.Recc).HasColumnName("RECC");
            entity.Property(e => e.Recode).HasColumnName("RECODE");
            entity.Property(e => e.Recodensc)
                .HasMaxLength(0)
                .HasColumnName("RECODENSC");
            entity.Property(e => e.Recolstate).HasColumnName("RECOLSTATE");
            entity.Property(e => e.Recrident).HasColumnName("RECRIDENT");
            entity.Property(e => e.Redial).HasColumnName("REDIAL");
            entity.Property(e => e.Redialog).HasColumnName("REDIALOG");
            entity.Property(e => e.Redown).HasColumnName("REDOWN");
            entity.Property(e => e.Reexpire)
                .HasMaxLength(0)
                .HasColumnName("REEXPIRE");
            entity.Property(e => e.Rehh).HasColumnName("REHH");
            entity.Property(e => e.Reident).HasColumnName("REIDENT");
            entity.Property(e => e.Relex).HasColumnName("RELEX");
            entity.Property(e => e.Relimit).HasColumnName("RELIMIT");
            entity.Property(e => e.Relock).HasColumnName("RELOCK");
            entity.Property(e => e.Remessno).HasColumnName("REMESSNO");
            entity.Property(e => e.Remileage).HasColumnName("REMILEAGE");
            entity.Property(e => e.Reoffgroup).HasColumnName("REOFFGROUP");
            entity.Property(e => e.Reogident).HasColumnName("REOGIDENT");
            entity.Property(e => e.Repin).HasColumnName("REPIN");
            entity.Property(e => e.Repinonl)
                .HasMaxLength(0)
                .HasColumnName("REPINONL");
            entity.Property(e => e.Reprivate).HasColumnName("REPRIVATE");
            entity.Property(e => e.Requant).HasColumnName("REQUANT");
            entity.Property(e => e.Rerange).HasColumnName("RERANGE");
            entity.Property(e => e.Resecond).HasColumnName("RESECOND");
            entity.Property(e => e.Retype).HasColumnName("RETYPE");
            entity.Property(e => e.Revalid)
                .HasMaxLength(0)
                .HasColumnName("REVALID");
        });

        modelBuilder.Entity<DboResponse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.RESPONSE");

            entity.Property(e => e.Rsauident).HasColumnName("RSAUIDENT");
            entity.Property(e => e.Rsdata)
                .HasMaxLength(56)
                .HasColumnName("RSDATA");
            entity.Property(e => e.Rsdate)
                .HasMaxLength(19)
                .HasColumnName("RSDATE");
            entity.Property(e => e.Rsident)
                .HasColumnType("mediumint")
                .HasColumnName("RSIDENT");
            entity.Property(e => e.Rsorident)
                .HasColumnType("mediumint")
                .HasColumnName("RSORIDENT");
            entity.Property(e => e.Rsrqno).HasColumnName("RSRQNO");
            entity.Property(e => e.Rsstate).HasColumnName("RSSTATE");
        });

        modelBuilder.Entity<DboScharac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SCHARAC");

            entity.Property(e => e.Schiident)
                .HasMaxLength(0)
                .HasColumnName("SCHIIDENT");
            entity.Property(e => e.Scident)
                .HasMaxLength(0)
                .HasColumnName("SCIDENT");
            entity.Property(e => e.Scvcident)
                .HasMaxLength(0)
                .HasColumnName("SCVCIDENT");
        });

        modelBuilder.Entity<DboSearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SEARCH");

            entity.Property(e => e.Seauto)
                .HasMaxLength(0)
                .HasColumnName("SEAUTO");
            entity.Property(e => e.Secap)
                .HasMaxLength(0)
                .HasColumnName("SECAP");
            entity.Property(e => e.Sedate)
                .HasMaxLength(0)
                .HasColumnName("SEDATE");
            entity.Property(e => e.Seident)
                .HasMaxLength(0)
                .HasColumnName("SEIDENT");
            entity.Property(e => e.Selisttype)
                .HasMaxLength(0)
                .HasColumnName("SELISTTYPE");
            entity.Property(e => e.Sememo)
                .HasMaxLength(0)
                .HasColumnName("SEMEMO");
            entity.Property(e => e.Seprog)
                .HasMaxLength(0)
                .HasColumnName("SEPROG");
            entity.Property(e => e.Sesql)
                .HasMaxLength(0)
                .HasColumnName("SESQL");
            entity.Property(e => e.Sewho)
                .HasMaxLength(0)
                .HasColumnName("SEWHO");
        });

        modelBuilder.Entity<DboSstructure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SSTRUCTURE");

            entity.Property(e => e.Sscoident)
                .HasMaxLength(0)
                .HasColumnName("SSCOIDENT");
            entity.Property(e => e.Sshiident)
                .HasMaxLength(0)
                .HasColumnName("SSHIIDENT");
            entity.Property(e => e.Ssident)
                .HasMaxLength(0)
                .HasColumnName("SSIDENT");
            entity.Property(e => e.Sssrident)
                .HasMaxLength(0)
                .HasColumnName("SSSRIDENT");
        });

        modelBuilder.Entity<DboSthistory>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.STHISTORY");

            entity.Property(e => e.Shcoident).HasColumnName("SHCOIDENT");
            entity.Property(e => e.Shdate)
                .HasMaxLength(19)
                .HasColumnName("SHDATE");
            entity.Property(e => e.Shident).HasColumnName("SHIDENT");
            entity.Property(e => e.Shsrident).HasColumnName("SHSRIDENT");
            entity.Property(e => e.Shvaldate)
                .HasMaxLength(19)
                .HasColumnName("SHVALDATE");
            entity.Property(e => e.Shveident).HasColumnName("SHVEIDENT");
            entity.Property(e => e.Shwho).HasColumnName("SHWHO");
        });

        modelBuilder.Entity<DboStorage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.STORAGE");

            entity.Property(e => e.Stamauto)
                .HasPrecision(3, 2)
                .HasColumnName("STAMAUTO");
            entity.Property(e => e.Stamdate)
                .HasMaxLength(19)
                .HasColumnName("STAMDATE");
            entity.Property(e => e.Stamount)
                .HasPrecision(8, 2)
                .HasColumnName("STAMOUNT");
            entity.Property(e => e.Stauto).HasColumnName("STAUTO");
            entity.Property(e => e.Stdate)
                .HasMaxLength(19)
                .HasColumnName("STDATE");
            entity.Property(e => e.Stident).HasColumnName("STIDENT");
            entity.Property(e => e.Stinv)
                .HasMaxLength(19)
                .HasColumnName("STINV");
            entity.Property(e => e.Stlargequ).HasColumnName("STLARGEQU");
            entity.Property(e => e.Stmax)
                .HasPrecision(8, 2)
                .HasColumnName("STMAX");
            entity.Property(e => e.Stmeasure)
                .HasPrecision(3, 2)
                .HasColumnName("STMEASURE");
            entity.Property(e => e.Stmedate)
                .HasMaxLength(19)
                .HasColumnName("STMEDATE");
            entity.Property(e => e.Stmemo)
                .HasMaxLength(0)
                .HasColumnName("STMEMO");
            entity.Property(e => e.Stmin)
                .HasPrecision(6, 2)
                .HasColumnName("STMIN");
            entity.Property(e => e.Stminorder)
                .HasPrecision(3, 2)
                .HasColumnName("STMINORDER");
            entity.Property(e => e.Stnscinvmon).HasColumnName("STNSCINVMON");
            entity.Property(e => e.Stnscinvweek).HasColumnName("STNSCINVWEEK");
            entity.Property(e => e.Stnscnum).HasColumnName("STNSCNUM");
            entity.Property(e => e.Stnsctime).HasColumnName("STNSCTIME");
            entity.Property(e => e.Stnumber)
                .HasMaxLength(0)
                .HasColumnName("STNUMBER");
            entity.Property(e => e.Stordate)
                .HasMaxLength(19)
                .HasColumnName("STORDATE");
            entity.Property(e => e.Storder)
                .HasPrecision(6, 2)
                .HasColumnName("STORDER");
            entity.Property(e => e.Stordered).HasColumnName("STORDERED");
            entity.Property(e => e.Stpbident).HasColumnName("STPBIDENT");
            entity.Property(e => e.Stpos).HasColumnName("STPOS");
            entity.Property(e => e.Stprobe).HasColumnName("STPROBE");
            entity.Property(e => e.Stshow).HasColumnName("STSHOW");
            entity.Property(e => e.Sttitle)
                .HasMaxLength(11)
                .HasColumnName("STTITLE");
            entity.Property(e => e.Stunit)
                .HasPrecision(3, 2)
                .HasColumnName("STUNIT");
            entity.Property(e => e.Stwho).HasColumnName("STWHO");
        });

        modelBuilder.Entity<DboStosel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.STOSEL");

            entity.Property(e => e.Soactive).HasColumnName("SOACTIVE");
            entity.Property(e => e.Soident).HasColumnName("SOIDENT");
            entity.Property(e => e.Sopos).HasColumnName("SOPOS");
            entity.Property(e => e.Sostident).HasColumnName("SOSTIDENT");
            entity.Property(e => e.Sousident).HasColumnName("SOUSIDENT");
        });

        modelBuilder.Entity<DboStructure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.STRUCTURE");

            entity.Property(e => e.Sradident).HasColumnName("SRADIDENT");
            entity.Property(e => e.Srdate)
                .HasMaxLength(19)
                .HasColumnName("SRDATE");
            entity.Property(e => e.Srhlevel).HasColumnName("SRHLEVEL");
            entity.Property(e => e.Srident).HasColumnName("SRIDENT");
            entity.Property(e => e.Srimage).HasColumnName("SRIMAGE");
            entity.Property(e => e.Srlevel).HasColumnName("SRLEVEL");
            entity.Property(e => e.Srmemo)
                .HasMaxLength(0)
                .HasColumnName("SRMEMO");
            entity.Property(e => e.Srnumber).HasColumnName("SRNUMBER");
            entity.Property(e => e.Srsrident).HasColumnName("SRSRIDENT");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(23)
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Srwho).HasColumnName("SRWHO");
        });

        modelBuilder.Entity<DboSvaccdriv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SVACCDRIV");

            entity.Property(e => e.Saaccount)
                .HasMaxLength(0)
                .HasColumnName("SAACCOUNT");
            entity.Property(e => e.Saauident)
                .HasMaxLength(0)
                .HasColumnName("SAAUIDENT");
            entity.Property(e => e.Sadrvno)
                .HasMaxLength(0)
                .HasColumnName("SADRVNO");
            entity.Property(e => e.Saemident)
                .HasMaxLength(0)
                .HasColumnName("SAEMIDENT");
            entity.Property(e => e.Saident)
                .HasMaxLength(0)
                .HasColumnName("SAIDENT");
            entity.Property(e => e.Sapin)
                .HasMaxLength(0)
                .HasColumnName("SAPIN");
        });

        modelBuilder.Entity<DboSvaccinp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SVACCINP");

            entity.Property(e => e.Siaccount)
                .HasMaxLength(0)
                .HasColumnName("SIACCOUNT");
            entity.Property(e => e.Siauident)
                .HasMaxLength(0)
                .HasColumnName("SIAUIDENT");
            entity.Property(e => e.Siident)
                .HasMaxLength(0)
                .HasColumnName("SIIDENT");
            entity.Property(e => e.Siipident)
                .HasMaxLength(0)
                .HasColumnName("SIIPIDENT");
        });

        modelBuilder.Entity<DboSvaccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SVACCOUNT");

            entity.Property(e => e.Svaccount).HasColumnName("SVACCOUNT");
            entity.Property(e => e.Svauident).HasColumnName("SVAUIDENT");
            entity.Property(e => e.Svcaident).HasColumnName("SVCAIDENT");
            entity.Property(e => e.Svident).HasColumnName("SVIDENT");
        });

        modelBuilder.Entity<DboSysdiagram>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.sysdiagrams");

            entity.Property(e => e.Definition)
                .HasColumnType("text")
                .HasColumnName("definition");
            entity.Property(e => e.DiagramId).HasColumnName("diagram_id");
            entity.Property(e => e.Name)
                .HasMaxLength(9)
                .HasColumnName("name");
            entity.Property(e => e.PrincipalId).HasColumnName("principal_id");
            entity.Property(e => e.Version).HasColumnName("version");
        });

        modelBuilder.Entity<DboSysprop>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SYSPROP");

            entity.Property(e => e.Sodate)
                .HasMaxLength(19)
                .HasColumnName("SODATE");
            entity.Property(e => e.Soident).HasColumnName("SOIDENT");
            entity.Property(e => e.Sotitle)
                .HasMaxLength(14)
                .HasColumnName("SOTITLE");
            entity.Property(e => e.Soval)
                .HasMaxLength(13)
                .HasColumnName("SOVAL");
            entity.Property(e => e.Sowho).HasColumnName("SOWHO");
        });

        modelBuilder.Entity<DboSystem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.SYSTEM");

            entity.Property(e => e.Syattachin).HasColumnName("SYATTACHIN");
            entity.Property(e => e.Sycnt).HasColumnName("SYCNT");
            entity.Property(e => e.Syctryno).HasColumnName("SYCTRYNO");
            entity.Property(e => e.Sydate)
                .HasMaxLength(19)
                .HasColumnName("SYDATE");
            entity.Property(e => e.Syfrom)
                .HasMaxLength(0)
                .HasColumnName("SYFROM");
            entity.Property(e => e.Syibancheck).HasColumnName("SYIBANCHECK");
            entity.Property(e => e.Syident).HasColumnName("SYIDENT");
            entity.Property(e => e.Symaid).HasColumnName("SYMAID");
            entity.Property(e => e.Sypain).HasColumnName("SYPAIN");
            entity.Property(e => e.Syport).HasColumnName("SYPORT");
            entity.Property(e => e.Sypw)
                .HasMaxLength(0)
                .HasColumnName("SYPW");
            entity.Property(e => e.Sysendsepa).HasColumnName("SYSENDSEPA");
            entity.Property(e => e.Sysepa).HasColumnName("SYSEPA");
            entity.Property(e => e.Sysmtp)
                .HasMaxLength(0)
                .HasColumnName("SYSMTP");
            entity.Property(e => e.Syssl).HasColumnName("SYSSL");
            entity.Property(e => e.Sytext)
                .HasMaxLength(12)
                .HasColumnName("SYTEXT");
            entity.Property(e => e.Syuser)
                .HasMaxLength(0)
                .HasColumnName("SYUSER");
            entity.Property(e => e.Sywho).HasColumnName("SYWHO");
            entity.Property(e => e.Syyear).HasColumnName("SYYEAR");
        });

        modelBuilder.Entity<DboTagroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.TAGROUP");

            entity.Property(e => e.Tadate)
                .HasMaxLength(19)
                .HasColumnName("TADATE");
            entity.Property(e => e.Taident).HasColumnName("TAIDENT");
            entity.Property(e => e.Tano).HasColumnName("TANO");
            entity.Property(e => e.Tatitle)
                .HasMaxLength(33)
                .HasColumnName("TATITLE");
            entity.Property(e => e.Tawho).HasColumnName("TAWHO");
        });

        modelBuilder.Entity<DboTerminal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.TERMINAL");

            entity.Property(e => e.Tmauident).HasColumnName("TMAUIDENT");
            entity.Property(e => e.Tmbarcode).HasColumnName("TMBARCODE");
            entity.Property(e => e.Tmbnreader).HasColumnName("TMBNREADER");
            entity.Property(e => e.Tmcollect).HasColumnName("TMCOLLECT");
            entity.Property(e => e.Tmcom).HasColumnName("TMCOM");
            entity.Property(e => e.Tmdate)
                .HasMaxLength(19)
                .HasColumnName("TMDATE");
            entity.Property(e => e.Tmdisplay).HasColumnName("TMDISPLAY");
            entity.Property(e => e.Tmextern1).HasColumnName("TMEXTERN1");
            entity.Property(e => e.Tmextern10).HasColumnName("TMEXTERN10");
            entity.Property(e => e.Tmextern11).HasColumnName("TMEXTERN11");
            entity.Property(e => e.Tmextern12).HasColumnName("TMEXTERN12");
            entity.Property(e => e.Tmextern13).HasColumnName("TMEXTERN13");
            entity.Property(e => e.Tmextern14).HasColumnName("TMEXTERN14");
            entity.Property(e => e.Tmextern15).HasColumnName("TMEXTERN15");
            entity.Property(e => e.Tmextern16).HasColumnName("TMEXTERN16");
            entity.Property(e => e.Tmextern17).HasColumnName("TMEXTERN17");
            entity.Property(e => e.Tmextern18).HasColumnName("TMEXTERN18");
            entity.Property(e => e.Tmextern19).HasColumnName("TMEXTERN19");
            entity.Property(e => e.Tmextern2).HasColumnName("TMEXTERN2");
            entity.Property(e => e.Tmextern20).HasColumnName("TMEXTERN20");
            entity.Property(e => e.Tmextern21).HasColumnName("TMEXTERN21");
            entity.Property(e => e.Tmextern22).HasColumnName("TMEXTERN22");
            entity.Property(e => e.Tmextern23).HasColumnName("TMEXTERN23");
            entity.Property(e => e.Tmextern24).HasColumnName("TMEXTERN24");
            entity.Property(e => e.Tmextern25).HasColumnName("TMEXTERN25");
            entity.Property(e => e.Tmextern26).HasColumnName("TMEXTERN26");
            entity.Property(e => e.Tmextern27).HasColumnName("TMEXTERN27");
            entity.Property(e => e.Tmextern28).HasColumnName("TMEXTERN28");
            entity.Property(e => e.Tmextern29).HasColumnName("TMEXTERN29");
            entity.Property(e => e.Tmextern3).HasColumnName("TMEXTERN3");
            entity.Property(e => e.Tmextern30).HasColumnName("TMEXTERN30");
            entity.Property(e => e.Tmextern31).HasColumnName("TMEXTERN31");
            entity.Property(e => e.Tmextern32).HasColumnName("TMEXTERN32");
            entity.Property(e => e.Tmextern33).HasColumnName("TMEXTERN33");
            entity.Property(e => e.Tmextern34).HasColumnName("TMEXTERN34");
            entity.Property(e => e.Tmextern35).HasColumnName("TMEXTERN35");
            entity.Property(e => e.Tmextern36).HasColumnName("TMEXTERN36");
            entity.Property(e => e.Tmextern37).HasColumnName("TMEXTERN37");
            entity.Property(e => e.Tmextern38).HasColumnName("TMEXTERN38");
            entity.Property(e => e.Tmextern39).HasColumnName("TMEXTERN39");
            entity.Property(e => e.Tmextern4).HasColumnName("TMEXTERN4");
            entity.Property(e => e.Tmextern40).HasColumnName("TMEXTERN40");
            entity.Property(e => e.Tmextern41).HasColumnName("TMEXTERN41");
            entity.Property(e => e.Tmextern42).HasColumnName("TMEXTERN42");
            entity.Property(e => e.Tmextern43).HasColumnName("TMEXTERN43");
            entity.Property(e => e.Tmextern44).HasColumnName("TMEXTERN44");
            entity.Property(e => e.Tmextern45).HasColumnName("TMEXTERN45");
            entity.Property(e => e.Tmextern46).HasColumnName("TMEXTERN46");
            entity.Property(e => e.Tmextern47).HasColumnName("TMEXTERN47");
            entity.Property(e => e.Tmextern48).HasColumnName("TMEXTERN48");
            entity.Property(e => e.Tmextern49).HasColumnName("TMEXTERN49");
            entity.Property(e => e.Tmextern5).HasColumnName("TMEXTERN5");
            entity.Property(e => e.Tmextern50).HasColumnName("TMEXTERN50");
            entity.Property(e => e.Tmextern51).HasColumnName("TMEXTERN51");
            entity.Property(e => e.Tmextern52).HasColumnName("TMEXTERN52");
            entity.Property(e => e.Tmextern53).HasColumnName("TMEXTERN53");
            entity.Property(e => e.Tmextern54).HasColumnName("TMEXTERN54");
            entity.Property(e => e.Tmextern55).HasColumnName("TMEXTERN55");
            entity.Property(e => e.Tmextern56).HasColumnName("TMEXTERN56");
            entity.Property(e => e.Tmextern57).HasColumnName("TMEXTERN57");
            entity.Property(e => e.Tmextern58).HasColumnName("TMEXTERN58");
            entity.Property(e => e.Tmextern59).HasColumnName("TMEXTERN59");
            entity.Property(e => e.Tmextern6).HasColumnName("TMEXTERN6");
            entity.Property(e => e.Tmextern60).HasColumnName("TMEXTERN60");
            entity.Property(e => e.Tmextern61).HasColumnName("TMEXTERN61");
            entity.Property(e => e.Tmextern62).HasColumnName("TMEXTERN62");
            entity.Property(e => e.Tmextern63).HasColumnName("TMEXTERN63");
            entity.Property(e => e.Tmextern64).HasColumnName("TMEXTERN64");
            entity.Property(e => e.Tmextern65).HasColumnName("TMEXTERN65");
            entity.Property(e => e.Tmextern66).HasColumnName("TMEXTERN66");
            entity.Property(e => e.Tmextern67).HasColumnName("TMEXTERN67");
            entity.Property(e => e.Tmextern68).HasColumnName("TMEXTERN68");
            entity.Property(e => e.Tmextern69).HasColumnName("TMEXTERN69");
            entity.Property(e => e.Tmextern7).HasColumnName("TMEXTERN7");
            entity.Property(e => e.Tmextern70).HasColumnName("TMEXTERN70");
            entity.Property(e => e.Tmextern71).HasColumnName("TMEXTERN71");
            entity.Property(e => e.Tmextern72).HasColumnName("TMEXTERN72");
            entity.Property(e => e.Tmextern73).HasColumnName("TMEXTERN73");
            entity.Property(e => e.Tmextern74).HasColumnName("TMEXTERN74");
            entity.Property(e => e.Tmextern75).HasColumnName("TMEXTERN75");
            entity.Property(e => e.Tmextern76).HasColumnName("TMEXTERN76");
            entity.Property(e => e.Tmextern77).HasColumnName("TMEXTERN77");
            entity.Property(e => e.Tmextern78).HasColumnName("TMEXTERN78");
            entity.Property(e => e.Tmextern79).HasColumnName("TMEXTERN79");
            entity.Property(e => e.Tmextern8).HasColumnName("TMEXTERN8");
            entity.Property(e => e.Tmextern80).HasColumnName("TMEXTERN80");
            entity.Property(e => e.Tmextern81).HasColumnName("TMEXTERN81");
            entity.Property(e => e.Tmextern82).HasColumnName("TMEXTERN82");
            entity.Property(e => e.Tmextern83).HasColumnName("TMEXTERN83");
            entity.Property(e => e.Tmextern84).HasColumnName("TMEXTERN84");
            entity.Property(e => e.Tmextern85).HasColumnName("TMEXTERN85");
            entity.Property(e => e.Tmextern86).HasColumnName("TMEXTERN86");
            entity.Property(e => e.Tmextern87).HasColumnName("TMEXTERN87");
            entity.Property(e => e.Tmextern88).HasColumnName("TMEXTERN88");
            entity.Property(e => e.Tmextern89).HasColumnName("TMEXTERN89");
            entity.Property(e => e.Tmextern9).HasColumnName("TMEXTERN9");
            entity.Property(e => e.Tmextern90).HasColumnName("TMEXTERN90");
            entity.Property(e => e.Tmextern91).HasColumnName("TMEXTERN91");
            entity.Property(e => e.Tmextern92).HasColumnName("TMEXTERN92");
            entity.Property(e => e.Tmextern93).HasColumnName("TMEXTERN93");
            entity.Property(e => e.Tmextern94).HasColumnName("TMEXTERN94");
            entity.Property(e => e.Tmextern95).HasColumnName("TMEXTERN95");
            entity.Property(e => e.Tmextern96).HasColumnName("TMEXTERN96");
            entity.Property(e => e.Tmextern97).HasColumnName("TMEXTERN97");
            entity.Property(e => e.Tmextern98).HasColumnName("TMEXTERN98");
            entity.Property(e => e.Tmextern99).HasColumnName("TMEXTERN99");
            entity.Property(e => e.Tmident).HasColumnName("TMIDENT");
            entity.Property(e => e.Tmipaddr4)
                .HasMaxLength(0)
                .HasColumnName("TMIPADDR4");
            entity.Property(e => e.Tmipaddr6)
                .HasMaxLength(0)
                .HasColumnName("TMIPADDR6");
            entity.Property(e => e.Tmnozzle1).HasColumnName("TMNOZZLE1");
            entity.Property(e => e.Tmnozzle10).HasColumnName("TMNOZZLE10");
            entity.Property(e => e.Tmnozzle11).HasColumnName("TMNOZZLE11");
            entity.Property(e => e.Tmnozzle12).HasColumnName("TMNOZZLE12");
            entity.Property(e => e.Tmnozzle13).HasColumnName("TMNOZZLE13");
            entity.Property(e => e.Tmnozzle14).HasColumnName("TMNOZZLE14");
            entity.Property(e => e.Tmnozzle15).HasColumnName("TMNOZZLE15");
            entity.Property(e => e.Tmnozzle16).HasColumnName("TMNOZZLE16");
            entity.Property(e => e.Tmnozzle17).HasColumnName("TMNOZZLE17");
            entity.Property(e => e.Tmnozzle18).HasColumnName("TMNOZZLE18");
            entity.Property(e => e.Tmnozzle19).HasColumnName("TMNOZZLE19");
            entity.Property(e => e.Tmnozzle2).HasColumnName("TMNOZZLE2");
            entity.Property(e => e.Tmnozzle20).HasColumnName("TMNOZZLE20");
            entity.Property(e => e.Tmnozzle21).HasColumnName("TMNOZZLE21");
            entity.Property(e => e.Tmnozzle22).HasColumnName("TMNOZZLE22");
            entity.Property(e => e.Tmnozzle23).HasColumnName("TMNOZZLE23");
            entity.Property(e => e.Tmnozzle24).HasColumnName("TMNOZZLE24");
            entity.Property(e => e.Tmnozzle25).HasColumnName("TMNOZZLE25");
            entity.Property(e => e.Tmnozzle26).HasColumnName("TMNOZZLE26");
            entity.Property(e => e.Tmnozzle27).HasColumnName("TMNOZZLE27");
            entity.Property(e => e.Tmnozzle28).HasColumnName("TMNOZZLE28");
            entity.Property(e => e.Tmnozzle29).HasColumnName("TMNOZZLE29");
            entity.Property(e => e.Tmnozzle3).HasColumnName("TMNOZZLE3");
            entity.Property(e => e.Tmnozzle30).HasColumnName("TMNOZZLE30");
            entity.Property(e => e.Tmnozzle31).HasColumnName("TMNOZZLE31");
            entity.Property(e => e.Tmnozzle32).HasColumnName("TMNOZZLE32");
            entity.Property(e => e.Tmnozzle33).HasColumnName("TMNOZZLE33");
            entity.Property(e => e.Tmnozzle34).HasColumnName("TMNOZZLE34");
            entity.Property(e => e.Tmnozzle35).HasColumnName("TMNOZZLE35");
            entity.Property(e => e.Tmnozzle36).HasColumnName("TMNOZZLE36");
            entity.Property(e => e.Tmnozzle37).HasColumnName("TMNOZZLE37");
            entity.Property(e => e.Tmnozzle38).HasColumnName("TMNOZZLE38");
            entity.Property(e => e.Tmnozzle39).HasColumnName("TMNOZZLE39");
            entity.Property(e => e.Tmnozzle4).HasColumnName("TMNOZZLE4");
            entity.Property(e => e.Tmnozzle40).HasColumnName("TMNOZZLE40");
            entity.Property(e => e.Tmnozzle41).HasColumnName("TMNOZZLE41");
            entity.Property(e => e.Tmnozzle42).HasColumnName("TMNOZZLE42");
            entity.Property(e => e.Tmnozzle43).HasColumnName("TMNOZZLE43");
            entity.Property(e => e.Tmnozzle44).HasColumnName("TMNOZZLE44");
            entity.Property(e => e.Tmnozzle45).HasColumnName("TMNOZZLE45");
            entity.Property(e => e.Tmnozzle46).HasColumnName("TMNOZZLE46");
            entity.Property(e => e.Tmnozzle47).HasColumnName("TMNOZZLE47");
            entity.Property(e => e.Tmnozzle48).HasColumnName("TMNOZZLE48");
            entity.Property(e => e.Tmnozzle49).HasColumnName("TMNOZZLE49");
            entity.Property(e => e.Tmnozzle5).HasColumnName("TMNOZZLE5");
            entity.Property(e => e.Tmnozzle50).HasColumnName("TMNOZZLE50");
            entity.Property(e => e.Tmnozzle51).HasColumnName("TMNOZZLE51");
            entity.Property(e => e.Tmnozzle52).HasColumnName("TMNOZZLE52");
            entity.Property(e => e.Tmnozzle53).HasColumnName("TMNOZZLE53");
            entity.Property(e => e.Tmnozzle54).HasColumnName("TMNOZZLE54");
            entity.Property(e => e.Tmnozzle55).HasColumnName("TMNOZZLE55");
            entity.Property(e => e.Tmnozzle56).HasColumnName("TMNOZZLE56");
            entity.Property(e => e.Tmnozzle57).HasColumnName("TMNOZZLE57");
            entity.Property(e => e.Tmnozzle58).HasColumnName("TMNOZZLE58");
            entity.Property(e => e.Tmnozzle59).HasColumnName("TMNOZZLE59");
            entity.Property(e => e.Tmnozzle6).HasColumnName("TMNOZZLE6");
            entity.Property(e => e.Tmnozzle60).HasColumnName("TMNOZZLE60");
            entity.Property(e => e.Tmnozzle61).HasColumnName("TMNOZZLE61");
            entity.Property(e => e.Tmnozzle62).HasColumnName("TMNOZZLE62");
            entity.Property(e => e.Tmnozzle63).HasColumnName("TMNOZZLE63");
            entity.Property(e => e.Tmnozzle64).HasColumnName("TMNOZZLE64");
            entity.Property(e => e.Tmnozzle65).HasColumnName("TMNOZZLE65");
            entity.Property(e => e.Tmnozzle66).HasColumnName("TMNOZZLE66");
            entity.Property(e => e.Tmnozzle67).HasColumnName("TMNOZZLE67");
            entity.Property(e => e.Tmnozzle68).HasColumnName("TMNOZZLE68");
            entity.Property(e => e.Tmnozzle69).HasColumnName("TMNOZZLE69");
            entity.Property(e => e.Tmnozzle7).HasColumnName("TMNOZZLE7");
            entity.Property(e => e.Tmnozzle70).HasColumnName("TMNOZZLE70");
            entity.Property(e => e.Tmnozzle71).HasColumnName("TMNOZZLE71");
            entity.Property(e => e.Tmnozzle72).HasColumnName("TMNOZZLE72");
            entity.Property(e => e.Tmnozzle73).HasColumnName("TMNOZZLE73");
            entity.Property(e => e.Tmnozzle74).HasColumnName("TMNOZZLE74");
            entity.Property(e => e.Tmnozzle75).HasColumnName("TMNOZZLE75");
            entity.Property(e => e.Tmnozzle76).HasColumnName("TMNOZZLE76");
            entity.Property(e => e.Tmnozzle77).HasColumnName("TMNOZZLE77");
            entity.Property(e => e.Tmnozzle78).HasColumnName("TMNOZZLE78");
            entity.Property(e => e.Tmnozzle79).HasColumnName("TMNOZZLE79");
            entity.Property(e => e.Tmnozzle8).HasColumnName("TMNOZZLE8");
            entity.Property(e => e.Tmnozzle80).HasColumnName("TMNOZZLE80");
            entity.Property(e => e.Tmnozzle81).HasColumnName("TMNOZZLE81");
            entity.Property(e => e.Tmnozzle82).HasColumnName("TMNOZZLE82");
            entity.Property(e => e.Tmnozzle83).HasColumnName("TMNOZZLE83");
            entity.Property(e => e.Tmnozzle84).HasColumnName("TMNOZZLE84");
            entity.Property(e => e.Tmnozzle85).HasColumnName("TMNOZZLE85");
            entity.Property(e => e.Tmnozzle86).HasColumnName("TMNOZZLE86");
            entity.Property(e => e.Tmnozzle87).HasColumnName("TMNOZZLE87");
            entity.Property(e => e.Tmnozzle88).HasColumnName("TMNOZZLE88");
            entity.Property(e => e.Tmnozzle89).HasColumnName("TMNOZZLE89");
            entity.Property(e => e.Tmnozzle9).HasColumnName("TMNOZZLE9");
            entity.Property(e => e.Tmnozzle90).HasColumnName("TMNOZZLE90");
            entity.Property(e => e.Tmnozzle91).HasColumnName("TMNOZZLE91");
            entity.Property(e => e.Tmnozzle92).HasColumnName("TMNOZZLE92");
            entity.Property(e => e.Tmnozzle93).HasColumnName("TMNOZZLE93");
            entity.Property(e => e.Tmnozzle94).HasColumnName("TMNOZZLE94");
            entity.Property(e => e.Tmnozzle95).HasColumnName("TMNOZZLE95");
            entity.Property(e => e.Tmnozzle96).HasColumnName("TMNOZZLE96");
            entity.Property(e => e.Tmnozzle97).HasColumnName("TMNOZZLE97");
            entity.Property(e => e.Tmnozzle98).HasColumnName("TMNOZZLE98");
            entity.Property(e => e.Tmnozzle99).HasColumnName("TMNOZZLE99");
            entity.Property(e => e.Tmnum).HasColumnName("TMNUM");
            entity.Property(e => e.Tmofftime).HasColumnName("TMOFFTIME");
            entity.Property(e => e.Tmport).HasColumnName("TMPORT");
            entity.Property(e => e.Tmprinter).HasColumnName("TMPRINTER");
            entity.Property(e => e.Tmtype).HasColumnName("TMTYPE");
            entity.Property(e => e.Tmwho).HasColumnName("TMWHO");
        });

        modelBuilder.Entity<DboTermsel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.TERMSEL");

            entity.Property(e => e.Teauident)
                .HasMaxLength(0)
                .HasColumnName("TEAUIDENT");
            entity.Property(e => e.Teident)
                .HasMaxLength(0)
                .HasColumnName("TEIDENT");
            entity.Property(e => e.Teusident)
                .HasMaxLength(0)
                .HasColumnName("TEUSIDENT");
        });

        modelBuilder.Entity<DboTlabel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.TLABEL");

            entity.Property(e => e.Tlcolor).HasColumnName("TLCOLOR");
            entity.Property(e => e.Tldate)
                .HasMaxLength(19)
                .HasColumnName("TLDATE");
            entity.Property(e => e.Tlid).HasColumnName("TLID");
            entity.Property(e => e.Tlident).HasColumnName("TLIDENT");
            entity.Property(e => e.Tlmemo)
                .HasMaxLength(0)
                .HasColumnName("TLMEMO");
            entity.Property(e => e.Tlstype).HasColumnName("TLSTYPE");
            entity.Property(e => e.Tltext)
                .HasMaxLength(10)
                .HasColumnName("TLTEXT");
            entity.Property(e => e.Tlwho).HasColumnName("TLWHO");
        });

        modelBuilder.Entity<DboTstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.TSTATUS");

            entity.Property(e => e.Tscolor).HasColumnName("TSCOLOR");
            entity.Property(e => e.Tsdate)
                .HasMaxLength(19)
                .HasColumnName("TSDATE");
            entity.Property(e => e.Tsid).HasColumnName("TSID");
            entity.Property(e => e.Tsident).HasColumnName("TSIDENT");
            entity.Property(e => e.Tsmemo)
                .HasMaxLength(0)
                .HasColumnName("TSMEMO");
            entity.Property(e => e.Tstext)
                .HasMaxLength(24)
                .HasColumnName("TSTEXT");
            entity.Property(e => e.Tstype)
                .HasMaxLength(18)
                .HasColumnName("TSTYPE");
            entity.Property(e => e.Tswho).HasColumnName("TSWHO");
        });

        modelBuilder.Entity<DboUslog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.USLOG");

            entity.Property(e => e.Usadmin).HasColumnName("USADMIN");
            entity.Property(e => e.Usahident).HasColumnName("USAHIDENT");
            entity.Property(e => e.Usappe).HasColumnName("USAPPE");
            entity.Property(e => e.Usappn).HasColumnName("USAPPN");
            entity.Property(e => e.Usappointloc)
                .HasMaxLength(0)
                .HasColumnName("USAPPOINTLOC");
            entity.Property(e => e.Usappv).HasColumnName("USAPPV");
            entity.Property(e => e.Usbackup)
                .HasMaxLength(11)
                .HasColumnName("USBACKUP");
            entity.Property(e => e.Usbkcolor).HasColumnName("USBKCOLOR");
            entity.Property(e => e.Uscomplow)
                .HasMaxLength(0)
                .HasColumnName("USCOMPLOW");
            entity.Property(e => e.Uscompmid)
                .HasMaxLength(0)
                .HasColumnName("USCOMPMID");
            entity.Property(e => e.Uscompupp)
                .HasMaxLength(0)
                .HasColumnName("USCOMPUPP");
            entity.Property(e => e.Uscrypt).HasColumnName("USCRYPT");
            entity.Property(e => e.Usctrl1).HasColumnName("USCTRL1");
            entity.Property(e => e.Usctrl2).HasColumnName("USCTRL2");
            entity.Property(e => e.Usctrl3).HasColumnName("USCTRL3");
            entity.Property(e => e.Usctrl4).HasColumnName("USCTRL4");
            entity.Property(e => e.Usctrl5).HasColumnName("USCTRL5");
            entity.Property(e => e.Usctrl6).HasColumnName("USCTRL6");
            entity.Property(e => e.Usdate)
                .HasMaxLength(19)
                .HasColumnName("USDATE");
            entity.Property(e => e.Usdownload)
                .HasMaxLength(0)
                .HasColumnName("USDOWNLOAD");
            entity.Property(e => e.Usdtapath)
                .HasMaxLength(0)
                .HasColumnName("USDTAPATH");
            entity.Property(e => e.Usftp)
                .HasMaxLength(0)
                .HasColumnName("USFTP");
            entity.Property(e => e.Usftppw)
                .HasMaxLength(0)
                .HasColumnName("USFTPPW");
            entity.Property(e => e.Usftpuser)
                .HasMaxLength(0)
                .HasColumnName("USFTPUSER");
            entity.Property(e => e.Usident).HasColumnName("USIDENT");
            entity.Property(e => e.Usimport)
                .HasMaxLength(0)
                .HasColumnName("USIMPORT");
            entity.Property(e => e.Usinvpath)
                .HasMaxLength(0)
                .HasColumnName("USINVPATH");
            entity.Property(e => e.Usinvtype).HasColumnName("USINVTYPE");
            entity.Property(e => e.Uslang).HasColumnName("USLANG");
            entity.Property(e => e.Uslayout).HasColumnName("USLAYOUT");
            entity.Property(e => e.Uslimit).HasColumnName("USLIMIT");
            entity.Property(e => e.Uslines)
                .HasColumnType("mediumint")
                .HasColumnName("USLINES");
            entity.Property(e => e.Usmailbody)
                .HasMaxLength(0)
                .HasColumnName("USMAILBODY");
            entity.Property(e => e.Usmailfrom)
                .HasMaxLength(0)
                .HasColumnName("USMAILFROM");
            entity.Property(e => e.Usmailftxt)
                .HasMaxLength(0)
                .HasColumnName("USMAILFTXT");
            entity.Property(e => e.Usmonth).HasColumnName("USMONTH");
            entity.Property(e => e.Usname)
                .HasMaxLength(7)
                .HasColumnName("USNAME");
            entity.Property(e => e.Usout1)
                .HasMaxLength(0)
                .HasColumnName("USOUT1");
            entity.Property(e => e.Usout2)
                .HasMaxLength(0)
                .HasColumnName("USOUT2");
            entity.Property(e => e.Usout3)
                .HasMaxLength(0)
                .HasColumnName("USOUT3");
            entity.Property(e => e.Usoutlook).HasColumnName("USOUTLOOK");
            entity.Property(e => e.Usovcolor).HasColumnName("USOVCOLOR");
            entity.Property(e => e.Usovseps).HasColumnName("USOVSEPS");
            entity.Property(e => e.Uspdfpath)
                .HasMaxLength(0)
                .HasColumnName("USPDFPATH");
            entity.Property(e => e.Uspw)
                .HasMaxLength(0)
                .HasColumnName("USPW");
            entity.Property(e => e.Uspwcrypt)
                .HasMaxLength(64)
                .HasColumnName("USPWCRYPT");
            entity.Property(e => e.Uspwemail)
                .HasMaxLength(0)
                .HasColumnName("USPWEMAIL");
            entity.Property(e => e.Uspwinv)
                .HasMaxLength(0)
                .HasColumnName("USPWINV");
            entity.Property(e => e.Usrecurr).HasColumnName("USRECURR");
            entity.Property(e => e.Usrefresh).HasColumnName("USREFRESH");
            entity.Property(e => e.Usrepeat).HasColumnName("USREPEAT");
            entity.Property(e => e.Usrrident).HasColumnName("USRRIDENT");
            entity.Property(e => e.Ussepapath)
                .HasMaxLength(0)
                .HasColumnName("USSEPAPATH");
            entity.Property(e => e.Usservice).HasColumnName("USSERVICE");
            entity.Property(e => e.Usskin).HasColumnName("USSKIN");
            entity.Property(e => e.Usskinname)
                .HasMaxLength(10)
                .HasColumnName("USSKINNAME");
            entity.Property(e => e.Usskinnav)
                .HasMaxLength(0)
                .HasColumnName("USSKINNAV");
            entity.Property(e => e.Ussmsday).HasColumnName("USSMSDAY");
            entity.Property(e => e.Ussmsedate)
                .HasMaxLength(0)
                .HasColumnName("USSMSEDATE");
            entity.Property(e => e.Ussmsetime).HasColumnName("USSMSETIME");
            entity.Property(e => e.Ussmsetime1).HasColumnName("USSMSETIME1");
            entity.Property(e => e.Ussmssdate)
                .HasMaxLength(0)
                .HasColumnName("USSMSSDATE");
            entity.Property(e => e.Ussmsstime).HasColumnName("USSMSSTIME");
            entity.Property(e => e.Ussmsstime1).HasColumnName("USSMSSTIME1");
            entity.Property(e => e.Ussmstel)
                .HasMaxLength(0)
                .HasColumnName("USSMSTEL");
            entity.Property(e => e.Ussmtp)
                .HasMaxLength(0)
                .HasColumnName("USSMTP");
            entity.Property(e => e.Ussmtphost)
                .HasMaxLength(0)
                .HasColumnName("USSMTPHOST");
            entity.Property(e => e.Ussmtpport).HasColumnName("USSMTPPORT");
            entity.Property(e => e.Ussmtpportm).HasColumnName("USSMTPPORTM");
            entity.Property(e => e.Ussmtpssl).HasColumnName("USSMTPSSL");
            entity.Property(e => e.Ussmtpsslm).HasColumnName("USSMTPSSLM");
            entity.Property(e => e.Ussrcaddr)
                .HasMaxLength(0)
                .HasColumnName("USSRCADDR");
            entity.Property(e => e.Usstart).HasColumnName("USSTART");
            entity.Property(e => e.Ustaraddr)
                .HasMaxLength(0)
                .HasColumnName("USTARADDR");
            entity.Property(e => e.Ususerinv)
                .HasMaxLength(0)
                .HasColumnName("USUSERINV");
            entity.Property(e => e.Ususername)
                .HasMaxLength(0)
                .HasColumnName("USUSERNAME");
            entity.Property(e => e.Usvaldate)
                .HasMaxLength(19)
                .HasColumnName("USVALDATE");
            entity.Property(e => e.Usvoucher)
                .HasMaxLength(0)
                .HasColumnName("USVOUCHER");
            entity.Property(e => e.Uswho).HasColumnName("USWHO");
        });

        modelBuilder.Entity<DboVat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VAT");

            entity.Property(e => e.Vadate)
                .HasMaxLength(19)
                .HasColumnName("VADATE");
            entity.Property(e => e.Vaident).HasColumnName("VAIDENT");
            entity.Property(e => e.Vamemo)
                .HasMaxLength(0)
                .HasColumnName("VAMEMO");
            entity.Property(e => e.Vanumber).HasColumnName("VANUMBER");
            entity.Property(e => e.Vatitle)
                .HasMaxLength(9)
                .HasColumnName("VATITLE");
            entity.Property(e => e.Vatype).HasColumnName("VATYPE");
            entity.Property(e => e.Vavat)
                .HasPrecision(4, 2)
                .HasColumnName("VAVAT");
            entity.Property(e => e.Vavatchg)
                .HasPrecision(3, 2)
                .HasColumnName("VAVATCHG");
            entity.Property(e => e.Vavatdat)
                .HasMaxLength(19)
                .HasColumnName("VAVATDAT");
            entity.Property(e => e.Vawho).HasColumnName("VAWHO");
        });

        modelBuilder.Entity<DboVcharac>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VCHARAC");

            entity.Property(e => e.Vcdate)
                .HasMaxLength(19)
                .HasColumnName("VCDATE");
            entity.Property(e => e.Vcident).HasColumnName("VCIDENT");
            entity.Property(e => e.Vcmemo)
                .HasMaxLength(0)
                .HasColumnName("VCMEMO");
            entity.Property(e => e.Vcnumber)
                .HasMaxLength(0)
                .HasColumnName("VCNUMBER");
            entity.Property(e => e.Vctitle)
                .HasMaxLength(12)
                .HasColumnName("VCTITLE");
            entity.Property(e => e.Vcvfident).HasColumnName("VCVFIDENT");
            entity.Property(e => e.Vcwho).HasColumnName("VCWHO");
        });

        modelBuilder.Entity<DboVehicle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VEHICLE");

            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(0)
                .HasColumnName("VECC");
            entity.Property(e => e.Vecocode)
                .HasMaxLength(0)
                .HasColumnName("VECOCODE");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasMaxLength(19)
                .HasColumnName("VEDATE");
            entity.Property(e => e.Vedivabbr)
                .HasMaxLength(0)
                .HasColumnName("VEDIVABBR");
            entity.Property(e => e.Vedivision)
                .HasMaxLength(0)
                .HasColumnName("VEDIVISION");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasMaxLength(19)
                .HasColumnName("VEEND");
            entity.Property(e => e.Vegroup)
                .HasMaxLength(0)
                .HasColumnName("VEGROUP");
            entity.Property(e => e.Vehhoffset)
                .HasPrecision(3, 2)
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasPrecision(3, 2)
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Veho)
                .HasMaxLength(0)
                .HasColumnName("VEHO");
            entity.Property(e => e.Vehours)
                .HasPrecision(8, 2)
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Veintno)
                .HasColumnType("mediumint")
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .HasMaxLength(0)
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles)
                .HasColumnType("mediumint")
                .HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasMaxLength(0)
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(16)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(13)
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasMaxLength(19)
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .HasMaxLength(8)
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(0)
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vevehno)
                .HasMaxLength(0)
                .HasColumnName("VEVEHNO");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
        });

        modelBuilder.Entity<DboVfattrib>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VFATTRIB");

            entity.Property(e => e.Vfdate)
                .HasMaxLength(19)
                .HasColumnName("VFDATE");
            entity.Property(e => e.Vfident).HasColumnName("VFIDENT");
            entity.Property(e => e.Vfmemo)
                .HasMaxLength(0)
                .HasColumnName("VFMEMO");
            entity.Property(e => e.Vftitle)
                .HasMaxLength(11)
                .HasColumnName("VFTITLE");
            entity.Property(e => e.Vfwho).HasColumnName("VFWHO");
        });

        modelBuilder.Entity<DboVrefatt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VREFATT");

            entity.Property(e => e.Vrident)
                .HasMaxLength(0)
                .HasColumnName("VRIDENT");
            entity.Property(e => e.Vrvcident)
                .HasMaxLength(0)
                .HasColumnName("VRVCIDENT");
            entity.Property(e => e.Vrveident)
                .HasMaxLength(0)
                .HasColumnName("VRVEIDENT");
        });

        modelBuilder.Entity<DboVtech>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.VTECH");

            entity.Property(e => e.Vtco2).HasColumnName("VTCO2");
            entity.Property(e => e.Vtcyclap).HasColumnName("VTCYCLAP");
            entity.Property(e => e.Vtdate)
                .HasMaxLength(19)
                .HasColumnName("VTDATE");
            entity.Property(e => e.Vtdatemaint)
                .HasMaxLength(19)
                .HasColumnName("VTDATEMAINT");
            entity.Property(e => e.Vtgvw).HasColumnName("VTGVW");
            entity.Property(e => e.Vth2type).HasColumnName("VTH2TYPE");
            entity.Property(e => e.Vthold).HasColumnName("VTHOLD");
            entity.Property(e => e.Vtident).HasColumnName("VTIDENT");
            entity.Property(e => e.Vtlift1).HasColumnName("VTLIFT1");
            entity.Property(e => e.Vtlift2).HasColumnName("VTLIFT2");
            entity.Property(e => e.Vtlift3).HasColumnName("VTLIFT3");
            entity.Property(e => e.Vtlift4).HasColumnName("VTLIFT4");
            entity.Property(e => e.Vtlift5).HasColumnName("VTLIFT5");
            entity.Property(e => e.Vtloadarea).HasColumnName("VTLOADAREA");
            entity.Property(e => e.Vtloadh).HasColumnName("VTLOADH");
            entity.Property(e => e.Vtloadl).HasColumnName("VTLOADL");
            entity.Property(e => e.Vtloadw).HasColumnName("VTLOADW");
            entity.Property(e => e.Vtmaxp).HasColumnName("VTMAXP");
            entity.Property(e => e.Vtmaxtemp).HasColumnName("VTMAXTEMP");
            entity.Property(e => e.Vtmemo)
                .HasMaxLength(36)
                .HasColumnName("VTMEMO");
            entity.Property(e => e.Vtminp).HasColumnName("VTMINP");
            entity.Property(e => e.Vtmintemp).HasColumnName("VTMINTEMP");
            entity.Property(e => e.Vtmotor)
                .HasMaxLength(0)
                .HasColumnName("VTMOTOR");
            entity.Property(e => e.Vtmpower).HasColumnName("VTMPOWER");
            entity.Property(e => e.Vtneg)
                .HasPrecision(2, 1)
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasPrecision(2, 1)
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasPrecision(2, 1)
                .HasColumnName("VTPOS");
            entity.Property(e => e.Vtret).HasColumnName("VTRET");
            entity.Property(e => e.Vtseats).HasColumnName("VTSEATS");
            entity.Property(e => e.Vtstand).HasColumnName("VTSTAND");
            entity.Property(e => e.Vtsteer1).HasColumnName("VTSTEER1");
            entity.Property(e => e.Vtsteer2).HasColumnName("VTSTEER2");
            entity.Property(e => e.Vtsteer3).HasColumnName("VTSTEER3");
            entity.Property(e => e.Vtsteer4).HasColumnName("VTSTEER4");
            entity.Property(e => e.Vtsteer5).HasColumnName("VTSTEER5");
            entity.Property(e => e.Vtswl).HasColumnName("VTSWL");
            entity.Property(e => e.Vttank).HasColumnName("VTTANK");
            entity.Property(e => e.Vttankh2kg).HasColumnName("VTTANKH2KG");
            entity.Property(e => e.Vttankvolmaxp).HasColumnName("VTTANKVOLMAXP");
            entity.Property(e => e.Vttankvolminp).HasColumnName("VTTANKVOLMINP");
            entity.Property(e => e.Vttwin1).HasColumnName("VTTWIN1");
            entity.Property(e => e.Vttwin2).HasColumnName("VTTWIN2");
            entity.Property(e => e.Vttwin3).HasColumnName("VTTWIN3");
            entity.Property(e => e.Vttwin4).HasColumnName("VTTWIN4");
            entity.Property(e => e.Vttwin5).HasColumnName("VTTWIN5");
            entity.Property(e => e.Vttyresiz1)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZ1");
            entity.Property(e => e.Vttyresiz2)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZ2");
            entity.Property(e => e.Vttyresiz3)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZ3");
            entity.Property(e => e.Vttyresiz4)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZ4");
            entity.Property(e => e.Vttyresiz5)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZ5");
            entity.Property(e => e.Vttyresize)
                .HasMaxLength(0)
                .HasColumnName("VTTYRESIZE");
            entity.Property(e => e.Vtunda).HasColumnName("VTUNDA");
            entity.Property(e => e.Vtwho).HasColumnName("VTWHO");
        });

        modelBuilder.Entity<DboWstation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.WSTATION");

            entity.Property(e => e.Wsdate)
                .HasMaxLength(19)
                .HasColumnName("WSDATE");
            entity.Property(e => e.Wsident).HasColumnName("WSIDENT");
            entity.Property(e => e.Wswho).HasColumnName("WSWHO");
            entity.Property(e => e.Wsws)
                .HasMaxLength(9)
                .HasColumnName("WSWS");
        });

        modelBuilder.Entity<DboZvt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dbo.ZVT");

            entity.Property(e => e.Zvdate)
                .HasMaxLength(19)
                .HasColumnName("ZVDATE");
            entity.Property(e => e.Zvident).HasColumnName("ZVIDENT");
            entity.Property(e => e.Zvshow).HasColumnName("ZVSHOW");
            entity.Property(e => e.Zvtitle)
                .HasMaxLength(38)
                .HasColumnName("ZVTITLE");
            entity.Property(e => e.Zvtype).HasColumnName("ZVTYPE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
