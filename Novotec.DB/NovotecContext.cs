using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using NovotecDB.Models;

namespace NovotecDB;

public partial class NovotecContext : DbContext
{
    public NovotecContext()
    {
    }

    public NovotecContext(DbContextOptions<NovotecContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Aactive> Aactives { get; set; }

    public virtual DbSet<Acard> Acards { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Adisp> Adisps { get; set; }

    public virtual DbSet<Agroup> Agroups { get; set; }

    public virtual DbSet<Alimit> Alimits { get; set; }

    public virtual DbSet<Amodparm> Amodparms { get; set; }

    public virtual DbSet<Aopstat> Aopstats { get; set; }

    public virtual DbSet<Aprod> Aprods { get; set; }

    public virtual DbSet<Asvspec> Asvspecs { get; set; }

    public virtual DbSet<Atext> Atexts { get; set; }

    public virtual DbSet<Aumenu> Aumenus { get; set; }

    public virtual DbSet<Authorize> Authorizes { get; set; }

    public virtual DbSet<Automat> Automats { get; set; }

    public virtual DbSet<Awplan> Awplans { get; set; }

    public virtual DbSet<Cahistory> Cahistories { get; set; }

    public virtual DbSet<Card> Cards { get; set; }

    public virtual DbSet<Cash> Cashes { get; set; }

    public virtual DbSet<Cashdisc> Cashdiscs { get; set; }

    public virtual DbSet<CcVehSum> CcVehSums { get; set; }

    public virtual DbSet<Code> Codes { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Crange> Cranges { get; set; }

    public virtual DbSet<Currstatus> Currstatuses { get; set; }

    public virtual DbSet<CustomerCardAutomat> CustomerCardAutomats { get; set; }

    public virtual DbSet<Deltext> Deltexts { get; set; }

    public virtual DbSet<Discount> Discounts { get; set; }

    public virtual DbSet<Discprod> Discprods { get; set; }

    public virtual DbSet<Em10> Em10s { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeCardAutomat> EmployeeCardAutomats { get; set; }

    public virtual DbSet<Endatum> Endata { get; set; }

    public virtual DbSet<Enfuel> Enfuels { get; set; }

    public virtual DbSet<Error> Errors { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<Export> Exports { get; set; }

    public virtual DbSet<Fcountry> Fcountries { get; set; }

    public virtual DbSet<Fcuno> Fcunos { get; set; }

    public virtual DbSet<Fleet> Fleets { get; set; }

    public virtual DbSet<Fleet1> Fleet1s { get; set; }

    public virtual DbSet<Fuelstat> Fuelstats { get; set; }

    public virtual DbSet<Glbsearch> Glbsearches { get; set; }

    public virtual DbSet<Hia2> Hia2s { get; set; }

    public virtual DbSet<Hia3> Hia3s { get; set; }

    public virtual DbSet<Hium> Hia { get; set; }

    public virtual DbSet<Idcode> Idcodes { get; set; }

    public virtual DbSet<Inputadd> Inputadds { get; set; }

    public virtual DbSet<Invcharge> Invcharges { get; set; }

    public virtual DbSet<Inventory> Inventories { get; set; }

    public virtual DbSet<Invinv> Invinvs { get; set; }

    public virtual DbSet<Invitem> Invitems { get; set; }

    public virtual DbSet<Invnum> Invnums { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<Invspec> Invspecs { get; set; }

    public virtual DbSet<Level> Levels { get; set; }

    public virtual DbSet<Leveldatum> Leveldata { get; set; }

    public virtual DbSet<Levelmeter> Levelmeters { get; set; }

    public virtual DbSet<Login> Logins { get; set; }

    public virtual DbSet<Mclient> Mclients { get; set; }

    public virtual DbSet<Nscspec> Nscspecs { get; set; }

    public virtual DbSet<Nscstat> Nscstats { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<Overview> Overviews { get; set; }

    public virtual DbSet<Ovsort> Ovsorts { get; set; }

    public virtual DbSet<Pbase> Pbases { get; set; }

    public virtual DbSet<Pgroup> Pgroups { get; set; }

    public virtual DbSet<Pprice> Pprices { get; set; }

    public virtual DbSet<Preauth> Preauths { get; set; }

    public virtual DbSet<Prepaid> Prepaids { get; set; }

    public virtual DbSet<Pricing> Pricings { get; set; }

    public virtual DbSet<Pricprod> Pricprods { get; set; }

    public virtual DbSet<Ptype> Ptypes { get; set; }

    public virtual DbSet<Queue> Queues { get; set; }

    public virtual DbSet<Qunit> Qunits { get; set; }

    public virtual DbSet<Reference> References { get; set; }

    public virtual DbSet<Response> Responses { get; set; }

    public virtual DbSet<Scharac> Scharacs { get; set; }

    public virtual DbSet<Search> Searches { get; set; }

    public virtual DbSet<Sstructure> Sstructures { get; set; }

    public virtual DbSet<Sthistory> Sthistories { get; set; }

    public virtual DbSet<Storage> Storages { get; set; }

    public virtual DbSet<Stosel> Stosels { get; set; }

    public virtual DbSet<Structure> Structures { get; set; }

    public virtual DbSet<Svaccdriv> Svaccdrivs { get; set; }

    public virtual DbSet<Svaccinp> Svaccinps { get; set; }

    public virtual DbSet<Svaccount> Svaccounts { get; set; }

    public virtual DbSet<Sysprop> Sysprops { get; set; }

    public virtual DbSet<NovotecDB.Models.System> Systems { get; set; }

    public virtual DbSet<Tagroup> Tagroups { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<Termsel> Termsels { get; set; }

    public virtual DbSet<Tlabel> Tlabels { get; set; }

    public virtual DbSet<Tstatus> Tstatuses { get; set; }

    public virtual DbSet<Uslog> Uslogs { get; set; }

    public virtual DbSet<Vat> Vats { get; set; }

    public virtual DbSet<Vcharac> Vcharacs { get; set; }

    public virtual DbSet<Ve10> Ve10s { get; set; }

    public virtual DbSet<Ve110> Ve110s { get; set; }

    public virtual DbSet<Vehicle> Vehicles { get; set; }

    public virtual DbSet<VehicleCardAutomat> VehicleCardAutomats { get; set; }

    public virtual DbSet<Vfattrib> Vfattribs { get; set; }

    public virtual DbSet<Vrefatt> Vrefatts { get; set; }

    public virtual DbSet<Vtech> Vteches { get; set; }

    public virtual DbSet<Wstation> Wstations { get; set; }

    public virtual DbSet<Zvt> Zvts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Aactive>(entity =>
        {
            entity.HasKey(e => e.Aaident);

            entity.ToTable("AACTIVE");

            entity.Property(e => e.Aaident).HasColumnName("AAIDENT");
            entity.Property(e => e.Aaauident).HasColumnName("AAAUIDENT");
            entity.Property(e => e.Aadend)
                .HasDefaultValueSql("(CONVERT([datetime],'2001-01-01T00:00:00',0))")
                .HasColumnType("datetime")
                .HasColumnName("AADEND");
            entity.Property(e => e.Aadstart)
                .HasDefaultValueSql("(CONVERT([datetime],'2001-01-01T00:00:00',0))")
                .HasColumnType("datetime")
                .HasColumnName("AADSTART");
            entity.Property(e => e.Aaidle).HasColumnName("AAIDLE");
            entity.Property(e => e.Aalend).HasColumnName("AALEND");
            entity.Property(e => e.Aalstart).HasColumnName("AALSTART");
            entity.Property(e => e.Aastart)
                .HasColumnType("datetime")
                .HasColumnName("AASTART");
            entity.Property(e => e.Aastate).HasColumnName("AASTATE");
        });

        modelBuilder.Entity<Acard>(entity =>
        {
            entity.HasKey(e => e.Acident);

            entity.ToTable("ACARD");

            entity.Property(e => e.Acident).HasColumnName("ACIDENT");
            entity.Property(e => e.Acauident).HasColumnName("ACAUIDENT");
            entity.Property(e => e.Accaident).HasColumnName("ACCAIDENT");
            entity.Property(e => e.Acdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ACDATE");
            entity.Property(e => e.Acidident).HasColumnName("ACIDIDENT");
            entity.Property(e => e.Actype).HasColumnName("ACTYPE");
            entity.Property(e => e.Acwho).HasColumnName("ACWHO");
            entity.Property(e => e.Aczvident).HasColumnName("ACZVIDENT");
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.Adident);

            entity.ToTable("ADDRESS");

            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adacc3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADACC3");
            entity.Property(e => e.Adacc4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADACC4");
            entity.Property(e => e.Adacc5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADACC5");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adbank3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADBANK3");
            entity.Property(e => e.Adbank4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADBANK4");
            entity.Property(e => e.Adbank5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADBANK5");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Addate)
                .HasColumnType("datetime")
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADEMAIL2");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADFAX2");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADFNAME2");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen2).HasColumnName("ADGEN2");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADHP");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adiban3)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBAN3");
            entity.Property(e => e.Adiban4)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBAN4");
            entity.Property(e => e.Adiban5)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBAN5");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adibc3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBC3");
            entity.Property(e => e.Adibc4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBC4");
            entity.Property(e => e.Adibc5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADIBC5");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADLNAME2");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADPB");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adroutno3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADROUTNO3");
            entity.Property(e => e.Adroutno4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADROUTNO4");
            entity.Property(e => e.Adroutno5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADROUTNO5");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtaxid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTAXID");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTEL3");
            entity.Property(e => e.Adtel4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTEL4");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADTITLE2");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Advatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADVATID");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adxxident)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADXXIDENT");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ADZIP");
        });

        modelBuilder.Entity<Adisp>(entity =>
        {
            entity.HasKey(e => e.Aiident);

            entity.ToTable("ADISP");

            entity.Property(e => e.Aiident).HasColumnName("AIIDENT");
            entity.Property(e => e.Aiauident).HasColumnName("AIAUIDENT");
            entity.Property(e => e.Aicorr)
                .HasColumnType("decimal(4, 3)")
                .HasColumnName("AICORR");
            entity.Property(e => e.Aidate)
                .HasColumnType("datetime")
                .HasColumnName("AIDATE");
            entity.Property(e => e.Aidispquant).HasColumnName("AIDISPQUANT");
            entity.Property(e => e.Aiextern).HasColumnName("AIEXTERN");
            entity.Property(e => e.Aiextref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AIEXTREF");
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
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("AINSCMAXAM");
            entity.Property(e => e.Ainscmaxdur).HasColumnName("AINSCMAXDUR");
            entity.Property(e => e.Ainscmaxquant)
                .HasColumnType("numeric(6, 2)")
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

        modelBuilder.Entity<Agroup>(entity =>
        {
            entity.HasKey(e => e.Agident);

            entity.ToTable("AGROUP");

            entity.Property(e => e.Agident).HasColumnName("AGIDENT");
            entity.Property(e => e.Agdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AGDATE");
            entity.Property(e => e.Agmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AGMEMO");
            entity.Property(e => e.Agnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AGNUMBER");
            entity.Property(e => e.Agtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AGTITLE");
            entity.Property(e => e.Agwho).HasColumnName("AGWHO");
        });

        modelBuilder.Entity<Alimit>(entity =>
        {
            entity.HasKey(e => e.Alident);

            entity.ToTable("ALIMIT");

            entity.Property(e => e.Alident).HasColumnName("ALIDENT");
            entity.Property(e => e.Alauident).HasColumnName("ALAUIDENT");
            entity.Property(e => e.Aldate)
                .HasColumnType("datetime")
                .HasColumnName("ALDATE");
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

        modelBuilder.Entity<Amodparm>(entity =>
        {
            entity.HasKey(e => e.Amident);

            entity.ToTable("AMODPARM");

            entity.Property(e => e.Amident).HasColumnName("AMIDENT");
            entity.Property(e => e.Amauident).HasColumnName("AMAUIDENT");
            entity.Property(e => e.Ambaud).HasColumnName("AMBAUD");
            entity.Property(e => e.Amcmd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMCMD");
            entity.Property(e => e.Amcom).HasColumnName("AMCOM");
            entity.Property(e => e.Amdatabits).HasColumnName("AMDATABITS");
            entity.Property(e => e.Amdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AMDATE");
            entity.Property(e => e.Amdownload).HasColumnName("AMDOWNLOAD");
            entity.Property(e => e.Amend)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMEND");
            entity.Property(e => e.Amgprs).HasColumnName("AMGPRS");
            entity.Property(e => e.Amgsm).HasColumnName("AMGSM");
            entity.Property(e => e.Amhostname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMHOSTNAME");
            entity.Property(e => e.Aminit)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMINIT");
            entity.Property(e => e.Amip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMIP");
            entity.Property(e => e.Amipv6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMIPV6");
            entity.Property(e => e.Amlrc).HasColumnName("AMLRC");
            entity.Property(e => e.Amnackrep).HasColumnName("AMNACKREP");
            entity.Property(e => e.Amownport).HasColumnName("AMOWNPORT");
            entity.Property(e => e.Amparity).HasColumnName("AMPARITY");
            entity.Property(e => e.Amport).HasColumnName("AMPORT");
            entity.Property(e => e.Amprot).HasColumnName("AMPROT");
            entity.Property(e => e.Amprotpath)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMPROTPATH");
            entity.Property(e => e.Ampuls).HasColumnName("AMPULS");
            entity.Property(e => e.Amrecrep).HasColumnName("AMRECREP");
            entity.Property(e => e.Amsubnet)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMSUBNET");
            entity.Property(e => e.Amtel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AMTEL");
            entity.Property(e => e.Amterm).HasColumnName("AMTERM");
            entity.Property(e => e.Amtrarep).HasColumnName("AMTRAREP");
            entity.Property(e => e.Amupload).HasColumnName("AMUPLOAD");
            entity.Property(e => e.Amwho).HasColumnName("AMWHO");
            entity.Property(e => e.Amxmdelay).HasColumnName("AMXMDELAY");
        });

        modelBuilder.Entity<Aopstat>(entity =>
        {
            entity.HasKey(e => e.Aoident);

            entity.ToTable("AOPSTAT");

            entity.Property(e => e.Aoident).HasColumnName("AOIDENT");
            entity.Property(e => e.Aoauident).HasColumnName("AOAUIDENT");
            entity.Property(e => e.Aocomdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AOCOMDATE");
            entity.Property(e => e.Aocomstate)
                .HasDefaultValue((short)-1)
                .HasColumnName("AOCOMSTATE");
            entity.Property(e => e.Aodisp1)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP1");
            entity.Property(e => e.Aodisp10)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP10");
            entity.Property(e => e.Aodisp11)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP11");
            entity.Property(e => e.Aodisp12)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP12");
            entity.Property(e => e.Aodisp13)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP13");
            entity.Property(e => e.Aodisp14)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP14");
            entity.Property(e => e.Aodisp15)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP15");
            entity.Property(e => e.Aodisp16)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP16");
            entity.Property(e => e.Aodisp17)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP17");
            entity.Property(e => e.Aodisp18)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP18");
            entity.Property(e => e.Aodisp19)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP19");
            entity.Property(e => e.Aodisp2)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP2");
            entity.Property(e => e.Aodisp20)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP20");
            entity.Property(e => e.Aodisp21)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP21");
            entity.Property(e => e.Aodisp22)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP22");
            entity.Property(e => e.Aodisp23)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP23");
            entity.Property(e => e.Aodisp24)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP24");
            entity.Property(e => e.Aodisp25)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP25");
            entity.Property(e => e.Aodisp26)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP26");
            entity.Property(e => e.Aodisp27)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP27");
            entity.Property(e => e.Aodisp28)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP28");
            entity.Property(e => e.Aodisp29)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP29");
            entity.Property(e => e.Aodisp3)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP3");
            entity.Property(e => e.Aodisp30)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP30");
            entity.Property(e => e.Aodisp31)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP31");
            entity.Property(e => e.Aodisp32)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP32");
            entity.Property(e => e.Aodisp4)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP4");
            entity.Property(e => e.Aodisp5)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP5");
            entity.Property(e => e.Aodisp6)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP6");
            entity.Property(e => e.Aodisp7)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP7");
            entity.Property(e => e.Aodisp8)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP8");
            entity.Property(e => e.Aodisp9)
                .HasDefaultValue((short)-1)
                .HasColumnName("AODISP9");
            entity.Property(e => e.Aohelp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AOHELP");
            entity.Property(e => e.Aolimit).HasColumnName("AOLIMIT");
            entity.Property(e => e.Aolock).HasColumnName("AOLOCK");
            entity.Property(e => e.Aoopstate).HasColumnName("AOOPSTATE");
            entity.Property(e => e.Aosta2date)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AOSTA2DATE");
            entity.Property(e => e.Aostadate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AOSTADATE");
            entity.Property(e => e.Aostat)
                .HasDefaultValue((short)-1)
                .HasColumnName("AOSTAT");
            entity.Property(e => e.Aostat2)
                .HasDefaultValue((short)-1)
                .HasColumnName("AOSTAT2");
        });

        modelBuilder.Entity<Aprod>(entity =>
        {
            entity.HasKey(e => e.Apident);

            entity.ToTable("APROD");

            entity.Property(e => e.Apident).HasColumnName("APIDENT");
            entity.Property(e => e.Apauident).HasColumnName("APAUIDENT");
            entity.Property(e => e.Apdate)
                .HasColumnType("datetime")
                .HasColumnName("APDATE");
            entity.Property(e => e.Apintern).HasColumnName("APINTERN");
            entity.Property(e => e.Appbident).HasColumnName("APPBIDENT");
            entity.Property(e => e.Approbe).HasColumnName("APPROBE");
            entity.Property(e => e.Apstident).HasColumnName("APSTIDENT");
            entity.Property(e => e.Aptank).HasColumnName("APTANK");
            entity.Property(e => e.Apwho).HasColumnName("APWHO");
        });

        modelBuilder.Entity<Asvspec>(entity =>
        {
            entity.HasKey(e => e.Asident);

            entity.ToTable("ASVSPEC");

            entity.Property(e => e.Asident).HasColumnName("ASIDENT");
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
                .HasColumnType("datetime")
                .HasColumnName("ASDATE");
            entity.Property(e => e.Asdelay).HasColumnName("ASDELAY");
            entity.Property(e => e.Asend).HasColumnName("ASEND");
            entity.Property(e => e.Asimp).HasColumnName("ASIMP");
            entity.Property(e => e.Asinout).HasColumnName("ASINOUT");
            entity.Property(e => e.Aslpin).HasColumnName("ASLPIN");
            entity.Property(e => e.Asmuldisp).HasColumnName("ASMULDISP");
            entity.Property(e => e.Asoffset)
                .IsUnicode(false)
                .HasDefaultValue("")
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

        modelBuilder.Entity<Atext>(entity =>
        {
            entity.HasKey(e => e.Atident);

            entity.ToTable("ATEXT");

            entity.Property(e => e.Atident).HasColumnName("ATIDENT");
            entity.Property(e => e.Atauident).HasColumnName("ATAUIDENT");
            entity.Property(e => e.Atbold).HasColumnName("ATBOLD");
            entity.Property(e => e.Atdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ATDATE");
            entity.Property(e => e.Atline)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ATLINE");
            entity.Property(e => e.Atlineno).HasColumnName("ATLINENO");
            entity.Property(e => e.Attype).HasColumnName("ATTYPE");
            entity.Property(e => e.Atwho).HasColumnName("ATWHO");
        });

        modelBuilder.Entity<Aumenu>(entity =>
        {
            entity.HasKey(e => e.Aeident);

            entity.ToTable("AUMENU");

            entity.Property(e => e.Aeident).HasColumnName("AEIDENT");
            entity.Property(e => e.Aeahident).HasColumnName("AEAHIDENT");
            entity.Property(e => e.Aenum).HasColumnName("AENUM");
            entity.Property(e => e.Aetype).HasColumnName("AETYPE");
        });

        modelBuilder.Entity<Authorize>(entity =>
        {
            entity.HasKey(e => e.Ahident);

            entity.ToTable("AUTHORIZE");

            entity.Property(e => e.Ahident).HasColumnName("AHIDENT");
            entity.Property(e => e.Ahdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AHDATE");
            entity.Property(e => e.Ahpg1).HasColumnName("AHPG1");
            entity.Property(e => e.Ahpg10).HasColumnName("AHPG10");
            entity.Property(e => e.Ahpg2).HasColumnName("AHPG2");
            entity.Property(e => e.Ahpg3).HasColumnName("AHPG3");
            entity.Property(e => e.Ahpg4).HasColumnName("AHPG4");
            entity.Property(e => e.Ahpg5).HasColumnName("AHPG5");
            entity.Property(e => e.Ahpg6).HasColumnName("AHPG6");
            entity.Property(e => e.Ahpg7).HasColumnName("AHPG7");
            entity.Property(e => e.Ahpg8).HasColumnName("AHPG8");
            entity.Property(e => e.Ahpg9).HasColumnName("AHPG9");
            entity.Property(e => e.Ahtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AHTITLE");
            entity.Property(e => e.Ahwho).HasColumnName("AHWHO");
        });

        modelBuilder.Entity<Automat>(entity =>
        {
            entity.HasKey(e => e.Auident);

            entity.ToTable("AUTOMAT");

            entity.HasIndex(e => e.Autitle, "INDEX_AUTOMAT_NAME");

            entity.HasIndex(e => e.Aunumber, "INDEX_AUTOMAT_NUMBER").HasFilter("([AUNUMBER]<>'')");

            entity.HasIndex(e => e.Auwho, "INDEX_AUTOMAT_WHO");

            entity.Property(e => e.Auident).HasColumnName("AUIDENT");
            entity.Property(e => e.Auactive).HasColumnName("AUACTIVE");
            entity.Property(e => e.Auagident).HasColumnName("AUAGIDENT");
            entity.Property(e => e.Auautype).HasColumnName("AUAUTYPE");
            entity.Property(e => e.Aucashregisterid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUCASHREGISTERID");
            entity.Property(e => e.Audate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AUDATE");
            entity.Property(e => e.Aufuident).HasColumnName("AUFUIDENT");
            entity.Property(e => e.Auifsfaiid).HasColumnName("AUIFSFAIID");
            entity.Property(e => e.Auintern1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUINTERN1");
            entity.Property(e => e.Auintern2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUINTERN2");
            entity.Property(e => e.Aumemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUMEMO");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Aurelease).HasColumnName("AURELEASE");
            entity.Property(e => e.Aurelsub).HasColumnName("AURELSUB");
            entity.Property(e => e.Auseries)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUSERIES");
            entity.Property(e => e.Ausysno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUSYSNO");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Autype).HasColumnName("AUTYPE");
            entity.Property(e => e.Auwho).HasColumnName("AUWHO");
        });

        modelBuilder.Entity<Awplan>(entity =>
        {
            entity.HasKey(e => e.Awident);

            entity.ToTable("AWPLAN");

            entity.Property(e => e.Awident).HasColumnName("AWIDENT");
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
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("AWDATE");
            entity.Property(e => e.Awdelay).HasColumnName("AWDELAY");
            entity.Property(e => e.Awend).HasColumnName("AWEND");
            entity.Property(e => e.Awfri).HasColumnName("AWFRI");
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

        modelBuilder.Entity<Cahistory>(entity =>
        {
            entity.HasKey(e => e.Chident);

            entity.ToTable("CAHISTORY");

            entity.HasIndex(e => e.Chcaident, "INDEX_CAHISTORY_CARD");

            entity.HasIndex(e => new { e.Chcaident, e.Chdate }, "INDEX_CAHISTORY_CARDDATE");

            entity.Property(e => e.Chident).HasColumnName("CHIDENT");
            entity.Property(e => e.Chcaident).HasColumnName("CHCAIDENT");
            entity.Property(e => e.Chcoident).HasColumnName("CHCOIDENT");
            entity.Property(e => e.Chdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CHDATE");
            entity.Property(e => e.Chemident).HasColumnName("CHEMIDENT");
            entity.Property(e => e.Chfcident).HasColumnName("CHFCIDENT");
            entity.Property(e => e.Chleident).HasColumnName("CHLEIDENT");
            entity.Property(e => e.Chveident).HasColumnName("CHVEIDENT");
            entity.Property(e => e.Chwho).HasColumnName("CHWHO");
        });

        modelBuilder.Entity<Card>(entity =>
        {
            entity.HasKey(e => e.Caident);

            entity.ToTable("CARDS");

            entity.HasIndex(e => e.Cacoident, "INDEX_CARDS_CACOIDENT");

            entity.HasIndex(e => e.Caemident, "INDEX_CARDS_CAEMIDENT");

            entity.HasIndex(e => e.Cafcident, "INDEX_CARDS_CAFCIDENT");

            entity.HasIndex(e => e.Cano, "INDEX_CARDS_CANO");

            entity.HasIndex(e => e.Catype, "INDEX_CARDS_CATYPE");

            entity.HasIndex(e => e.Caveident, "INDEX_CARDS_CAVEIDENT");

            entity.Property(e => e.Caident).HasColumnName("CAIDENT");
            entity.Property(e => e.Cacoident).HasColumnName("CACOIDENT");
            entity.Property(e => e.Cadate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CADATE");
            entity.Property(e => e.Caemident).HasColumnName("CAEMIDENT");
            entity.Property(e => e.Cafcident).HasColumnName("CAFCIDENT");
            entity.Property(e => e.Caleident).HasColumnName("CALEIDENT");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CANO2");
            entity.Property(e => e.Capuident).HasColumnName("CAPUIDENT");
            entity.Property(e => e.Castident).HasColumnName("CASTIDENT");
            entity.Property(e => e.Catype).HasColumnName("CATYPE");
            entity.Property(e => e.Caveident).HasColumnName("CAVEIDENT");
            entity.Property(e => e.Cawho).HasColumnName("CAWHO");
        });

        modelBuilder.Entity<Cash>(entity =>
        {
            entity.HasKey(e => e.Csident);

            entity.ToTable("CASH");

            entity.Property(e => e.Csident).HasColumnName("CSIDENT");
            entity.Property(e => e.Csaiident).HasColumnName("CSAIIDENT");
            entity.Property(e => e.Csauident).HasColumnName("CSAUIDENT");
            entity.Property(e => e.Cscatype).HasColumnName("CSCATYPE");
            entity.Property(e => e.Csdate)
                .HasColumnType("datetime")
                .HasColumnName("CSDATE");
            entity.Property(e => e.Cslprice)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("CSLPRICE");
            entity.Property(e => e.Csprice)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("CSPRICE");
            entity.Property(e => e.Csprident).HasColumnName("CSPRIDENT");
            entity.Property(e => e.Csprotno).HasColumnName("CSPROTNO");
            entity.Property(e => e.Csquant)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("CSQUANT");
            entity.Property(e => e.Csrecn1).HasColumnName("CSRECN1");
            entity.Property(e => e.Csrecn2).HasColumnName("CSRECN2");
            entity.Property(e => e.Csstident).HasColumnName("CSSTIDENT");
            entity.Property(e => e.Cswho).HasColumnName("CSWHO");
        });

        modelBuilder.Entity<Cashdisc>(entity =>
        {
            entity.HasKey(e => e.Ciident);

            entity.ToTable("CASHDISC");

            entity.Property(e => e.Ciident).HasColumnName("CIIDENT");
            entity.Property(e => e.Cidate)
                .HasColumnType("datetime")
                .HasColumnName("CIDATE");
            entity.Property(e => e.Cititle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .HasColumnName("CITITLE1");
            entity.Property(e => e.Cititle2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("2")
                .HasColumnName("CITITLE2");
            entity.Property(e => e.Cititle3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("3")
                .HasColumnName("CITITLE3");
            entity.Property(e => e.Cititle4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("4")
                .HasColumnName("CITITLE4");
            entity.Property(e => e.Cititle5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("5")
                .HasColumnName("CITITLE5");
            entity.Property(e => e.Civalue1)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("CIVALUE1");
            entity.Property(e => e.Civalue2)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("CIVALUE2");
            entity.Property(e => e.Civalue3)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("CIVALUE3");
            entity.Property(e => e.Civalue4)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("CIVALUE4");
            entity.Property(e => e.Civalue5)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("CIVALUE5");
            entity.Property(e => e.Ciwho).HasColumnName("CIWHO");
        });

        modelBuilder.Entity<CcVehSum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CC_VEH_SUM");

            entity.Property(e => e.Hiinvlprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HIINVLPRICE");
            entity.Property(e => e.Hiinvpbase).HasColumnName("HIINVPBASE");
            entity.Property(e => e.Hiinvtotal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIINVTOTAL");
            entity.Property(e => e.Hiquant)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HIQUANT");
            entity.Property(e => e.Hitotal1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL1");
            entity.Property(e => e.Hitotal2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL2");
            entity.Property(e => e.Hitotal3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL3");
            entity.Property(e => e.Hitotaleb)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEB");
            entity.Property(e => e.Hitotalew)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEW");
            entity.Property(e => e.Hitotalvat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVAT");
            entity.Property(e => e.Hitotalvn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVN");
            entity.Property(e => e.Hitrdate)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATE");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Srlevel).HasColumnName("SRLEVEL");
            entity.Property(e => e.Srnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Sshiident).HasColumnName("SSHIIDENT");
            entity.Property(e => e.Sssrident).HasColumnName("SSSRIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
        });

        modelBuilder.Entity<Code>(entity =>
        {
            entity.HasKey(e => e.Cdident);

            entity.ToTable("CODE");

            entity.Property(e => e.Cdident).HasColumnName("CDIDENT");
            entity.Property(e => e.Cdauident).HasColumnName("CDAUIDENT");
            entity.Property(e => e.Cdcano).HasColumnName("CDCANO");
            entity.Property(e => e.Cdcode).HasColumnName("CDCODE");
            entity.Property(e => e.Cddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CDDATE");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.Coident);

            entity.ToTable("COMPANY");

            entity.HasIndex(e => e.Cocono1, "INDEX_COMPANY_COCONO1");

            entity.HasIndex(e => e.Codate, "INDEX_COMPANY_CODATE");

            entity.HasIndex(e => e.Cotitle1, "INDEX_COMPANY_COTITLE1");

            entity.HasIndex(e => e.Cowho, "INDEX_COMPANY_COWHO");

            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COCONO2");
            entity.Property(e => e.Codate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CODATE");
            entity.Property(e => e.Coend)
                .HasColumnType("datetime")
                .HasColumnName("COEND");
            entity.Property(e => e.Coieident).HasColumnName("COIEIDENT");
            entity.Property(e => e.Comanager1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COMANAGER1");
            entity.Property(e => e.Comanager2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COMANAGER2");
            entity.Property(e => e.Comanager3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COMANAGER3");
            entity.Property(e => e.Comemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COMEMO");
            entity.Property(e => e.Coname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CONAME");
            entity.Property(e => e.Copuident).HasColumnName("COPUIDENT");
            entity.Property(e => e.Coregcourt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COREGCOURT");
            entity.Property(e => e.Costate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("COSTATE");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Couci)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("COUCI");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
        });

        modelBuilder.Entity<Crange>(entity =>
        {
            entity.HasKey(e => e.Crident);

            entity.ToTable("CRANGE");

            entity.Property(e => e.Crident).HasColumnName("CRIDENT");
            entity.Property(e => e.Crcorr).HasColumnName("CRCORR");
            entity.Property(e => e.Crdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CRDATE");
            entity.Property(e => e.Crmaxval).HasColumnName("CRMAXVAL");
            entity.Property(e => e.Crmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CRMEMO");
            entity.Property(e => e.Crminval).HasColumnName("CRMINVAL");
            entity.Property(e => e.Crnumber).HasColumnName("CRNUMBER");
            entity.Property(e => e.Crrep).HasColumnName("CRREP");
            entity.Property(e => e.Crtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("CRTITLE");
            entity.Property(e => e.Crtype).HasColumnName("CRTYPE");
            entity.Property(e => e.Crwho).HasColumnName("CRWHO");
        });

        modelBuilder.Entity<Currstatus>(entity =>
        {
            entity.HasKey(e => e.Cuident);

            entity.ToTable("CURRSTATUS");

            entity.Property(e => e.Cuident).HasColumnName("CUIDENT");
            entity.Property(e => e.Cucritical).HasColumnName("CUCRITICAL");
            entity.Property(e => e.Cudate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("CUDATE");
            entity.Property(e => e.Cumemo)
                .IsUnicode(false)
                .HasColumnName("CUMEMO");
            entity.Property(e => e.Cumessage)
                .IsUnicode(false)
                .HasColumnName("CUMESSAGE");
            entity.Property(e => e.Cumessid).HasColumnName("CUMESSID");
            entity.Property(e => e.Cupinfo)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CUPINFO");
            entity.Property(e => e.Cuprogno).HasColumnName("CUPROGNO");
            entity.Property(e => e.Custation)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("CUSTATION");
            entity.Property(e => e.Cutype).HasColumnName("CUTYPE");
        });

        modelBuilder.Entity<CustomerCardAutomat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CustomerCardAutomat");

            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Caident).HasColumnName("CAIDENT");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
        });

        modelBuilder.Entity<Deltext>(entity =>
        {
            entity.HasKey(e => e.Dtident);

            entity.ToTable("DELTEXT");

            entity.Property(e => e.Dtident).HasColumnName("DTIDENT");
            entity.Property(e => e.Dtdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DTDATE");
            entity.Property(e => e.Dttext)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DTTEXT");
            entity.Property(e => e.Dttype).HasColumnName("DTTYPE");
            entity.Property(e => e.Dtwho).HasColumnName("DTWHO");
        });

        modelBuilder.Entity<Discount>(entity =>
        {
            entity.HasKey(e => e.Diident);

            entity.ToTable("DISCOUNT");

            entity.Property(e => e.Diident).HasColumnName("DIIDENT");
            entity.Property(e => e.Didate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DIDATE");
            entity.Property(e => e.Dititle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("DITITLE");
            entity.Property(e => e.Ditype).HasColumnName("DITYPE");
            entity.Property(e => e.Diwho).HasColumnName("DIWHO");
        });

        modelBuilder.Entity<Discprod>(entity =>
        {
            entity.HasKey(e => e.Dpident);

            entity.ToTable("DISCPROD");

            entity.Property(e => e.Dpident).HasColumnName("DPIDENT");
            entity.Property(e => e.Dpdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DPDATE");
            entity.Property(e => e.Dpdiident).HasColumnName("DPDIIDENT");
            entity.Property(e => e.Dppbident).HasColumnName("DPPBIDENT");
            entity.Property(e => e.Dpquant)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("DPQUANT");
            entity.Property(e => e.Dptype).HasColumnName("DPTYPE");
            entity.Property(e => e.Dpvaldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("DPVALDAT");
            entity.Property(e => e.Dpvaltype).HasColumnName("DPVALTYPE");
            entity.Property(e => e.Dpvalue)
                .HasColumnType("decimal(10, 3)")
                .HasColumnName("DPVALUE");
            entity.Property(e => e.Dpwho).HasColumnName("DPWHO");
        });

        modelBuilder.Entity<Em10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EM_10");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Emadcomp).HasColumnName("EMADCOMP");
            entity.Property(e => e.Emadident).HasColumnName("EMADIDENT");
            entity.Property(e => e.Emcocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMCOCODE");
            entity.Property(e => e.Emcoid).HasColumnName("EMCOID");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdate)
                .HasColumnType("datetime")
                .HasColumnName("EMDATE");
            entity.Property(e => e.Emdivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMDIVABBR");
            entity.Property(e => e.Emdivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMDIVISION");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Emend)
                .HasColumnType("datetime")
                .HasColumnName("EMEND");
            entity.Property(e => e.Emgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMGROUP");
            entity.Property(e => e.Emho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMHO");
            entity.Property(e => e.Emident).HasColumnName("EMIDENT");
            entity.Property(e => e.Emiscust).HasColumnName("EMISCUST");
            entity.Property(e => e.Emleident).HasColumnName("EMLEIDENT");
            entity.Property(e => e.Emmemo)
                .IsUnicode(false)
                .HasColumnName("EMMEMO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMPERSNO");
            entity.Property(e => e.Emstart)
                .HasColumnType("datetime")
                .HasColumnName("EMSTART");
            entity.Property(e => e.Emstate)
                .IsUnicode(false)
                .HasColumnName("EMSTATE");
            entity.Property(e => e.Emtype).HasColumnName("EMTYPE");
            entity.Property(e => e.Emwho).HasColumnName("EMWHO");
            entity.Property(e => e.Ofademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("OFADEMAIL1");
            entity.Property(e => e.Ofadfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OFADFAX1");
            entity.Property(e => e.Ofadident).HasColumnName("OFADIDENT");
            entity.Property(e => e.Ofadtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OFADTEL1");
            entity.Property(e => e.Ofadtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OFADTEL2");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Usadmin).HasColumnName("USADMIN");
            entity.Property(e => e.Usdate)
                .HasColumnType("datetime")
                .HasColumnName("USDATE");
            entity.Property(e => e.Usident).HasColumnName("USIDENT");
            entity.Property(e => e.Usname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USNAME");
            entity.Property(e => e.Usovseps).HasColumnName("USOVSEPS");
            entity.Property(e => e.Usvaldate)
                .HasColumnType("datetime")
                .HasColumnName("USVALDATE");
            entity.Property(e => e.Uswho).HasColumnName("USWHO");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Emident);

            entity.ToTable("EMPLOYEE");

            entity.HasIndex(e => e.Emdrivno, "INDEX_EMPLOYEE_DRIVNO").HasFilter("([EMDRIVNO]<>'')");

            entity.HasIndex(e => e.Emcoid, "INDEX_EMPLOYEE_EMCOID");

            entity.HasIndex(e => e.Emcoident, "INDEX_EMPLOYEE_EMCOIDENT");

            entity.HasIndex(e => e.Empersno, "INDEX_EMPLOYEE_PERSNO").HasFilter("([EMPERSNO]<>'')");

            entity.HasIndex(e => e.Emwho, "INDEX_EMPLOYEE_WHO");

            entity.Property(e => e.Emident).HasColumnName("EMIDENT");
            entity.Property(e => e.Emadcomp).HasColumnName("EMADCOMP");
            entity.Property(e => e.Emadident).HasColumnName("EMADIDENT");
            entity.Property(e => e.Emcocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMCOCODE");
            entity.Property(e => e.Emcoid).HasColumnName("EMCOID");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdate)
                .HasColumnType("datetime")
                .HasColumnName("EMDATE");
            entity.Property(e => e.Emdivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMDIVABBR");
            entity.Property(e => e.Emdivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMDIVISION");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Emend)
                .HasColumnType("datetime")
                .HasColumnName("EMEND");
            entity.Property(e => e.Emgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMGROUP");
            entity.Property(e => e.Emho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMHO");
            entity.Property(e => e.Emiscust).HasColumnName("EMISCUST");
            entity.Property(e => e.Emleident).HasColumnName("EMLEIDENT");
            entity.Property(e => e.Emmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMMEMO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMPERSNO");
            entity.Property(e => e.Emstart)
                .HasColumnType("datetime")
                .HasColumnName("EMSTART");
            entity.Property(e => e.Emstate)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EMSTATE");
            entity.Property(e => e.Emtype).HasColumnName("EMTYPE");
            entity.Property(e => e.Emwho).HasColumnName("EMWHO");
        });

        modelBuilder.Entity<EmployeeCardAutomat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EmployeeCardAutomat");

            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMPERSNO");
        });

        modelBuilder.Entity<Endatum>(entity =>
        {
            entity.HasKey(e => e.Enident);

            entity.ToTable("ENDATA");

            entity.Property(e => e.Enident).HasColumnName("ENIDENT");
            entity.Property(e => e.Enauident).HasColumnName("ENAUIDENT");
            entity.Property(e => e.Endate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ENDATE");
            entity.Property(e => e.Enline)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ENLINE");
            entity.Property(e => e.Enlineno).HasColumnName("ENLINENO");
        });

        modelBuilder.Entity<Enfuel>(entity =>
        {
            entity.HasKey(e => e.Efident);

            entity.ToTable("ENFUEL");

            entity.Property(e => e.Efident).HasColumnName("EFIDENT");
            entity.Property(e => e.Efauident).HasColumnName("EFAUIDENT");
            entity.Property(e => e.Efdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EFDATE");
            entity.Property(e => e.Efline)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EFLINE");
            entity.Property(e => e.Eflineno).HasColumnName("EFLINENO");
        });

        modelBuilder.Entity<Error>(entity =>
        {
            entity.HasKey(e => e.Erident);

            entity.ToTable("ERROR");

            entity.Property(e => e.Erident).HasColumnName("ERIDENT");
            entity.Property(e => e.Eraiident).HasColumnName("ERAIIDENT");
            entity.Property(e => e.Erauident).HasColumnName("ERAUIDENT");
            entity.Property(e => e.Erdate)
                .HasColumnType("datetime")
                .HasColumnName("ERDATE");
            entity.Property(e => e.Ermemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ERMEMO");
            entity.Property(e => e.Ernum).HasColumnName("ERNUM");
            entity.Property(e => e.Ertype).HasColumnName("ERTYPE");
            entity.Property(e => e.Erwho).HasColumnName("ERWHO");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.Evident);

            entity.ToTable("EVENT");

            entity.HasIndex(e => e.Evemident, "INDEX_EVENT_EMIDENT");

            entity.HasIndex(e => new { e.Evstart, e.Evend, e.Evveident, e.Evdonedate }, "INDEX_EVENT_EVENT");

            entity.HasIndex(e => e.Evveident, "INDEX_EVENT_VEHICLE");

            entity.Property(e => e.Evident).HasColumnName("EVIDENT");
            entity.Property(e => e.Evallday).HasColumnName("EVALLDAY");
            entity.Property(e => e.Evconfirm).HasColumnName("EVCONFIRM");
            entity.Property(e => e.Evdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EVDATE");
            entity.Property(e => e.Evdays).HasColumnName("EVDAYS");
            entity.Property(e => e.Evdescr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EVDESCR");
            entity.Property(e => e.Evdone)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("EVDONE");
            entity.Property(e => e.Evdonedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EVDONEDATE");
            entity.Property(e => e.Evemid).HasColumnName("EVEMID");
            entity.Property(e => e.Evemident).HasColumnName("EVEMIDENT");
            entity.Property(e => e.Evend)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EVEND");
            entity.Property(e => e.Evevtype).HasColumnName("EVEVTYPE");
            entity.Property(e => e.Evhdone)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("EVHDONE");
            entity.Property(e => e.Evhours)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("EVHOURS");
            entity.Property(e => e.Evhrecurr)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("EVHRECURR");
            entity.Property(e => e.Evlabel).HasColumnName("EVLABEL");
            entity.Property(e => e.Evlabelid).HasColumnName("EVLABELID");
            entity.Property(e => e.Evlocation)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EVLOCATION");
            entity.Property(e => e.Evmdone).HasColumnName("EVMDONE");
            entity.Property(e => e.Evmiles).HasColumnName("EVMILES");
            entity.Property(e => e.Evmrecurr).HasColumnName("EVMRECURR");
            entity.Property(e => e.Evoffhours)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("EVOFFHOURS");
            entity.Property(e => e.Evoffmiles).HasColumnName("EVOFFMILES");
            entity.Property(e => e.Evrectype).HasColumnName("EVRECTYPE");
            entity.Property(e => e.Evrecurr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EVRECURR");
            entity.Property(e => e.Evremind)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EVREMIND");
            entity.Property(e => e.Evstart)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("EVSTART");
            entity.Property(e => e.Evstate).HasColumnName("EVSTATE");
            entity.Property(e => e.Evsubject)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("EVSUBJECT");
            entity.Property(e => e.Evtype).HasColumnName("EVTYPE");
            entity.Property(e => e.Evveident).HasColumnName("EVVEIDENT");
            entity.Property(e => e.Evwho).HasColumnName("EVWHO");
        });

        modelBuilder.Entity<Export>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EXPORT");

            entity.Property(e => e.Datum)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Kennzeichen)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KfzAusweisNr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("KFZ Ausweis-Nr.");
            entity.Property(e => e.KfzIntern)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("KFZ intern");
            entity.Property(e => e.KmOderStunden)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KM oder Stunden");
            entity.Property(e => e.Menge)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.MitarbeiterNachname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mitarbeiter Nachname");
            entity.Property(e => e.MitarbeiterVorname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Mitarbeiter Vorname");
            entity.Property(e => e.PersonAusweisNr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Person Ausweis-Nr.");
            entity.Property(e => e.Tankplatz)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Zeit)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Fcountry>(entity =>
        {
            entity.HasKey(e => e.Foident);

            entity.ToTable("FCOUNTRY");

            entity.Property(e => e.Foident).HasColumnName("FOIDENT");
            entity.Property(e => e.Focode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FOCODE");
            entity.Property(e => e.Foctry)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FOCTRY");
            entity.Property(e => e.Fono).HasColumnName("FONO");
        });

        modelBuilder.Entity<Fcuno>(entity =>
        {
            entity.HasKey(e => e.Fcident);

            entity.ToTable("FCUNO");

            entity.Property(e => e.Fcident).HasColumnName("FCIDENT");
            entity.Property(e => e.Fcdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FCDATE");
            entity.Property(e => e.Fcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FCNO");
            entity.Property(e => e.Fctype).HasColumnName("FCTYPE");
            entity.Property(e => e.Fcwho).HasColumnName("FCWHO");
        });

        modelBuilder.Entity<Fleet>(entity =>
        {
            entity.HasKey(e => e.Feident);

            entity.ToTable("FLEET");

            entity.Property(e => e.Feident).HasColumnName("FEIDENT");
            entity.Property(e => e.Feno).HasColumnName("FENO");
            entity.Property(e => e.Fetitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FETITLE");
        });

        modelBuilder.Entity<Fleet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FLEET_1");

            entity.Property(e => e.Cadate)
                .HasColumnType("datetime")
                .HasColumnName("CADATE");
            entity.Property(e => e.Cafcident).HasColumnName("CAFCIDENT");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Fcident).HasColumnName("FCIDENT");
            entity.Property(e => e.Fcno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("FCNO");
            entity.Property(e => e.Fctype).HasColumnName("FCTYPE");
            entity.Property(e => e.Feno).HasColumnName("FENO");
            entity.Property(e => e.Fetitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FETITLE");
        });

        modelBuilder.Entity<Fuelstat>(entity =>
        {
            entity.HasKey(e => e.Fuident);

            entity.ToTable("FUELSTAT");

            entity.Property(e => e.Fuident).HasColumnName("FUIDENT");
            entity.Property(e => e.Fuadident).HasColumnName("FUADIDENT");
            entity.Property(e => e.Fudate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("FUDATE");
            entity.Property(e => e.Fuintno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUINTNO");
            entity.Property(e => e.Fuintno2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUINTNO2");
            entity.Property(e => e.Fuintno3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUINTNO3");
            entity.Property(e => e.Fuintno4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUINTNO4");
            entity.Property(e => e.Fumemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUMEMO");
            entity.Property(e => e.Funumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUNUMBER");
            entity.Property(e => e.Fusrident).HasColumnName("FUSRIDENT");
            entity.Property(e => e.Futitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUTITLE");
            entity.Property(e => e.Futitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUTITLE2");
            entity.Property(e => e.Futitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("FUTITLE3");
            entity.Property(e => e.Futype).HasColumnName("FUTYPE");
            entity.Property(e => e.Fuwho).HasColumnName("FUWHO");
        });

        modelBuilder.Entity<Glbsearch>(entity =>
        {
            entity.HasKey(e => e.Glident);

            entity.ToTable("GLBSEARCH");

            entity.Property(e => e.Glident).HasColumnName("GLIDENT");
            entity.Property(e => e.Gldate)
                .HasColumnType("datetime")
                .HasColumnName("GLDATE");
            entity.Property(e => e.Glfield)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("GLFIELD");
            entity.Property(e => e.Glitem)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("GLITEM");
            entity.Property(e => e.Glprog).HasColumnName("GLPROG");
            entity.Property(e => e.Glscope).HasColumnName("GLSCOPE");
            entity.Property(e => e.Glsql)
                .HasMaxLength(400)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("GLSQL");
            entity.Property(e => e.Gltext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("GLTEXT");
            entity.Property(e => e.Glwho).HasColumnName("GLWHO");
        });

        modelBuilder.Entity<Hia2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HIA_2");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1_2");
            entity.Property(e => e.Adacc13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1_3");
            entity.Property(e => e.Adacc14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1_4");
            entity.Property(e => e.Adacc15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1_5");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adacc22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2_2");
            entity.Property(e => e.Adacc23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2_3");
            entity.Property(e => e.Adacc24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2_4");
            entity.Property(e => e.Adacc25)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2_5");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1_2");
            entity.Property(e => e.Adbank13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1_3");
            entity.Property(e => e.Adbank14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1_4");
            entity.Property(e => e.Adbank15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1_5");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adbank22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2_2");
            entity.Property(e => e.Adbank23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2_3");
            entity.Property(e => e.Adbank24)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2_4");
            entity.Property(e => e.Adbank25)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2_5");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Adctry2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY_2");
            entity.Property(e => e.Adctry3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY_3");
            entity.Property(e => e.Adctry4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY_4");
            entity.Property(e => e.Adctry5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY_5");
            entity.Property(e => e.Addate)
                .HasColumnType("datetime")
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1_2");
            entity.Property(e => e.Ademail13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1_3");
            entity.Property(e => e.Ademail14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1_4");
            entity.Property(e => e.Ademail15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1_5");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1_2");
            entity.Property(e => e.Adfax13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1_3");
            entity.Property(e => e.Adfax14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1_4");
            entity.Property(e => e.Adfax15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1_5");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1_2");
            entity.Property(e => e.Adfname13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1_3");
            entity.Property(e => e.Adfname14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1_4");
            entity.Property(e => e.Adfname15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1_5");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen12).HasColumnName("ADGEN1_2");
            entity.Property(e => e.Adgen13).HasColumnName("ADGEN1_3");
            entity.Property(e => e.Adgen14).HasColumnName("ADGEN1_4");
            entity.Property(e => e.Adgen15).HasColumnName("ADGEN1_5");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adhp2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP_2");
            entity.Property(e => e.Adhp3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP_3");
            entity.Property(e => e.Adhp4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP_4");
            entity.Property(e => e.Adhp5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP_5");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban12)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1_2");
            entity.Property(e => e.Adiban13)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1_3");
            entity.Property(e => e.Adiban14)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1_4");
            entity.Property(e => e.Adiban15)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1_5");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adiban22)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2_2");
            entity.Property(e => e.Adiban23)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2_3");
            entity.Property(e => e.Adiban24)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2_4");
            entity.Property(e => e.Adiban25)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2_5");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1_2");
            entity.Property(e => e.Adibc13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1_3");
            entity.Property(e => e.Adibc14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1_4");
            entity.Property(e => e.Adibc15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1_5");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adibc22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2_2");
            entity.Property(e => e.Adibc23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2_3");
            entity.Property(e => e.Adibc24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2_4");
            entity.Property(e => e.Adibc25)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2_5");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adident2).HasColumnName("ADIDENT_2");
            entity.Property(e => e.Adident3).HasColumnName("ADIDENT_3");
            entity.Property(e => e.Adident4).HasColumnName("ADIDENT_4");
            entity.Property(e => e.Adident5).HasColumnName("ADIDENT_5");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1_2");
            entity.Property(e => e.Adlname13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1_3");
            entity.Property(e => e.Adlname14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1_4");
            entity.Property(e => e.Adlname15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1_5");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adloc2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC_2");
            entity.Property(e => e.Adloc3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC_3");
            entity.Property(e => e.Adloc4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC_4");
            entity.Property(e => e.Adloc5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC_5");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adpb2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB_2");
            entity.Property(e => e.Adpb3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB_3");
            entity.Property(e => e.Adpb4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB_4");
            entity.Property(e => e.Adpb5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB_5");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1_2");
            entity.Property(e => e.Adroutno13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1_3");
            entity.Property(e => e.Adroutno14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1_4");
            entity.Property(e => e.Adroutno15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1_5");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adroutno22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2_2");
            entity.Property(e => e.Adroutno23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2_3");
            entity.Property(e => e.Adroutno24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2_4");
            entity.Property(e => e.Adroutno25)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2_5");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adstr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR_2");
            entity.Property(e => e.Adstr3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR_3");
            entity.Property(e => e.Adstr4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR_4");
            entity.Property(e => e.Adstr5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR_5");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1_2");
            entity.Property(e => e.Adtel13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1_3");
            entity.Property(e => e.Adtel14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1_4");
            entity.Property(e => e.Adtel15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1_5");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2_2");
            entity.Property(e => e.Adtel23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2_3");
            entity.Property(e => e.Adtel24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2_4");
            entity.Property(e => e.Adtel25)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2_5");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1_2");
            entity.Property(e => e.Adtitle13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1_3");
            entity.Property(e => e.Adtitle14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1_4");
            entity.Property(e => e.Adtitle15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1_5");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Adtype2).HasColumnName("ADTYPE_2");
            entity.Property(e => e.Adtype3).HasColumnName("ADTYPE_3");
            entity.Property(e => e.Adtype4).HasColumnName("ADTYPE_4");
            entity.Property(e => e.Adtype5).HasColumnName("ADTYPE_5");
            entity.Property(e => e.Advatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID");
            entity.Property(e => e.Advatid2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID_2");
            entity.Property(e => e.Advatid3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID_3");
            entity.Property(e => e.Advatid4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID_4");
            entity.Property(e => e.Advatid5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID_5");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adwho2).HasColumnName("ADWHO_2");
            entity.Property(e => e.Adwho3).HasColumnName("ADWHO_3");
            entity.Property(e => e.Adwho4).HasColumnName("ADWHO_4");
            entity.Property(e => e.Adwho5).HasColumnName("ADWHO_5");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Adzip2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP_2");
            entity.Property(e => e.Adzip3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP_3");
            entity.Property(e => e.Adzip4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP_4");
            entity.Property(e => e.Adzip5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP_5");
            entity.Property(e => e.Aiextern).HasColumnName("AIEXTERN");
            entity.Property(e => e.Aiextref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AIEXTREF");
            entity.Property(e => e.Ainum).HasColumnName("AINUM");
            entity.Property(e => e.Aistate).HasColumnName("AISTATE");
            entity.Property(e => e.Auactive).HasColumnName("AUACTIVE");
            entity.Property(e => e.Auautype).HasColumnName("AUAUTYPE");
            entity.Property(e => e.Audate)
                .HasColumnType("datetime")
                .HasColumnName("AUDATE");
            entity.Property(e => e.Auident).HasColumnName("AUIDENT");
            entity.Property(e => e.Auintern1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUINTERN1");
            entity.Property(e => e.Auintern2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUINTERN2");
            entity.Property(e => e.Aumemo)
                .IsUnicode(false)
                .HasColumnName("AUMEMO");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Aurelease).HasColumnName("AURELEASE");
            entity.Property(e => e.Aurelsub).HasColumnName("AURELSUB");
            entity.Property(e => e.Auseries)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUSERIES");
            entity.Property(e => e.Ausysno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUSYSNO");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Autype).HasColumnName("AUTYPE");
            entity.Property(e => e.Auwho).HasColumnName("AUWHO");
            entity.Property(e => e.Cacoident).HasColumnName("CACOIDENT");
            entity.Property(e => e.Cacoident2).HasColumnName("CACOIDENT_2");
            entity.Property(e => e.Cadate)
                .HasColumnType("datetime")
                .HasColumnName("CADATE");
            entity.Property(e => e.Cadate2)
                .HasColumnType("datetime")
                .HasColumnName("CADATE_2");
            entity.Property(e => e.Caemident).HasColumnName("CAEMIDENT");
            entity.Property(e => e.Caemident2).HasColumnName("CAEMIDENT_2");
            entity.Property(e => e.Caident).HasColumnName("CAIDENT");
            entity.Property(e => e.Caident2).HasColumnName("CAIDENT_2");
            entity.Property(e => e.Caleident).HasColumnName("CALEIDENT");
            entity.Property(e => e.Caleident2).HasColumnName("CALEIDENT_2");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2");
            entity.Property(e => e.Cano21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO_2");
            entity.Property(e => e.Cano22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2_2");
            entity.Property(e => e.Catype).HasColumnName("CATYPE");
            entity.Property(e => e.Catype2).HasColumnName("CATYPE_2");
            entity.Property(e => e.Caveident).HasColumnName("CAVEIDENT");
            entity.Property(e => e.Caveident2).HasColumnName("CAVEIDENT_2");
            entity.Property(e => e.Cawho).HasColumnName("CAWHO");
            entity.Property(e => e.Cawho2).HasColumnName("CAWHO_2");
            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Coadident1).HasColumnName("COADIDENT_1");
            entity.Property(e => e.Coadident2).HasColumnName("COADIDENT_2");
            entity.Property(e => e.Coadident3).HasColumnName("COADIDENT_3");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1_1");
            entity.Property(e => e.Cocono12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1_2");
            entity.Property(e => e.Cocono13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1_3");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Cocono21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2_1");
            entity.Property(e => e.Cocono22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2_2");
            entity.Property(e => e.Cocono23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2_3");
            entity.Property(e => e.Codate)
                .HasColumnType("datetime")
                .HasColumnName("CODATE");
            entity.Property(e => e.Codate1)
                .HasColumnType("datetime")
                .HasColumnName("CODATE_1");
            entity.Property(e => e.Codate2)
                .HasColumnType("datetime")
                .HasColumnName("CODATE_2");
            entity.Property(e => e.Codate3)
                .HasColumnType("datetime")
                .HasColumnName("CODATE_3");
            entity.Property(e => e.Coend)
                .HasColumnType("datetime")
                .HasColumnName("COEND");
            entity.Property(e => e.Coend1)
                .HasColumnType("datetime")
                .HasColumnName("COEND_1");
            entity.Property(e => e.Coend2)
                .HasColumnType("datetime")
                .HasColumnName("COEND_2");
            entity.Property(e => e.Coend3)
                .HasColumnType("datetime")
                .HasColumnName("COEND_3");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Coident1).HasColumnName("COIDENT_1");
            entity.Property(e => e.Coident2).HasColumnName("COIDENT_2");
            entity.Property(e => e.Coident3).HasColumnName("COIDENT_3");
            entity.Property(e => e.Comemo)
                .IsUnicode(false)
                .HasColumnName("COMEMO");
            entity.Property(e => e.Comemo1)
                .IsUnicode(false)
                .HasColumnName("COMEMO_1");
            entity.Property(e => e.Comemo2)
                .IsUnicode(false)
                .HasColumnName("COMEMO_2");
            entity.Property(e => e.Comemo3)
                .IsUnicode(false)
                .HasColumnName("COMEMO_3");
            entity.Property(e => e.Costate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE");
            entity.Property(e => e.Costate1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE_1");
            entity.Property(e => e.Costate2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE_2");
            entity.Property(e => e.Costate3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE_3");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1_1");
            entity.Property(e => e.Cotitle12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1_2");
            entity.Property(e => e.Cotitle13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1_3");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2_1");
            entity.Property(e => e.Cotitle22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2_2");
            entity.Property(e => e.Cotitle23)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2_3");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotitle31)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3_1");
            entity.Property(e => e.Cotitle32)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3_2");
            entity.Property(e => e.Cotitle33)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3_3");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Cotype1).HasColumnName("COTYPE_1");
            entity.Property(e => e.Cotype2).HasColumnName("COTYPE_2");
            entity.Property(e => e.Cotype3).HasColumnName("COTYPE_3");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
            entity.Property(e => e.Cowho1).HasColumnName("COWHO_1");
            entity.Property(e => e.Cowho2).HasColumnName("COWHO_2");
            entity.Property(e => e.Cowho3).HasColumnName("COWHO_3");
            entity.Property(e => e.Emadident).HasColumnName("EMADIDENT");
            entity.Property(e => e.Emcocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMCOCODE");
            entity.Property(e => e.Emcoid).HasColumnName("EMCOID");
            entity.Property(e => e.Emcoid1).HasColumnName("EMCOID_1");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdate)
                .HasColumnType("datetime")
                .HasColumnName("EMDATE");
            entity.Property(e => e.Emdivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMDIVABBR");
            entity.Property(e => e.Emdivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMDIVISION");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Emend)
                .HasColumnType("datetime")
                .HasColumnName("EMEND");
            entity.Property(e => e.Emgroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMGROUP");
            entity.Property(e => e.Emho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMHO");
            entity.Property(e => e.Emident).HasColumnName("EMIDENT");
            entity.Property(e => e.Emident1).HasColumnName("EMIDENT_1");
            entity.Property(e => e.Emiscust).HasColumnName("EMISCUST");
            entity.Property(e => e.Emleident).HasColumnName("EMLEIDENT");
            entity.Property(e => e.Emmemo)
                .IsUnicode(false)
                .HasColumnName("EMMEMO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMPERSNO");
            entity.Property(e => e.Emstart)
                .HasColumnType("datetime")
                .HasColumnName("EMSTART");
            entity.Property(e => e.Emstate)
                .IsUnicode(false)
                .HasColumnName("EMSTATE");
            entity.Property(e => e.Emtype).HasColumnName("EMTYPE");
            entity.Property(e => e.Emwho).HasColumnName("EMWHO");
            entity.Property(e => e.Fetitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FETITLE_2");
            entity.Property(e => e.Fuadident).HasColumnName("FUADIDENT");
            entity.Property(e => e.Fudate)
                .HasColumnType("datetime")
                .HasColumnName("FUDATE");
            entity.Property(e => e.Fuident).HasColumnName("FUIDENT");
            entity.Property(e => e.Fuintno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUINTNO");
            entity.Property(e => e.Fuintno2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUINTNO2");
            entity.Property(e => e.Fumemo)
                .IsUnicode(false)
                .HasColumnName("FUMEMO");
            entity.Property(e => e.Funumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FUNUMBER");
            entity.Property(e => e.Fusrident).HasColumnName("FUSRIDENT");
            entity.Property(e => e.Futitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE");
            entity.Property(e => e.Futitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE2");
            entity.Property(e => e.Futitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE3");
            entity.Property(e => e.Futype).HasColumnName("FUTYPE");
            entity.Property(e => e.Fuwho).HasColumnName("FUWHO");
            entity.Property(e => e.Hiaiident).HasColumnName("HIAIIDENT");
            entity.Property(e => e.Hiauident).HasColumnName("HIAUIDENT");
            entity.Property(e => e.Hicaident).HasColumnName("HICAIDENT");
            entity.Property(e => e.Hicaident2).HasColumnName("HICAIDENT2");
            entity.Property(e => e.Hico2)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICO2");
            entity.Property(e => e.Hico2av)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICO2AV");
            entity.Property(e => e.Hicon100)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON100");
            entity.Property(e => e.Hicon1000)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON1000");
            entity.Property(e => e.Hiconltr)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONLTR");
            entity.Property(e => e.Hiconrev)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONREV");
            entity.Property(e => e.Hidate)
                .HasColumnType("datetime")
                .HasColumnName("HIDATE");
            entity.Property(e => e.Hidial1)
                .IsUnicode(false)
                .HasColumnName("HIDIAL1");
            entity.Property(e => e.Hidial2)
                .IsUnicode(false)
                .HasColumnName("HIDIAL2");
            entity.Property(e => e.Hidial3)
                .IsUnicode(false)
                .HasColumnName("HIDIAL3");
            entity.Property(e => e.Hidial4)
                .IsUnicode(false)
                .HasColumnName("HIDIAL4");
            entity.Property(e => e.Hidial5)
                .IsUnicode(false)
                .HasColumnName("HIDIAL5");
            entity.Property(e => e.Hiemcaident).HasColumnName("HIEMCAIDENT");
            entity.Property(e => e.Hiemident).HasColumnName("HIEMIDENT");
            entity.Property(e => e.Hiexpdate)
                .HasColumnType("datetime")
                .HasColumnName("HIEXPDATE");
            entity.Property(e => e.Hiflident).HasColumnName("HIFLIDENT");
            entity.Property(e => e.Hifuident).HasColumnName("HIFUIDENT");
            entity.Property(e => e.Higain)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIGAIN");
            entity.Property(e => e.Higainl)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIGAINL");
            entity.Property(e => e.Hihiident).HasColumnName("HIHIIDENT");
            entity.Property(e => e.Hiident).HasColumnName("HIIDENT");
            entity.Property(e => e.Hiinfo).HasColumnName("HIINFO");
            entity.Property(e => e.Hiinfo2).HasColumnName("HIINFO2");
            entity.Property(e => e.Hiintern).HasColumnName("HIINTERN");
            entity.Property(e => e.Hiinvlprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HIINVLPRICE");
            entity.Property(e => e.Hiinvpbase).HasColumnName("HIINVPBASE");
            entity.Property(e => e.Hiinvpextra).HasColumnName("HIINVPEXTRA");
            entity.Property(e => e.Hiinvpexval)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HIINVPEXVAL");
            entity.Property(e => e.Hiinvtotal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIINVTOTAL");
            entity.Property(e => e.Hiipident).HasColumnName("HIIPIDENT");
            entity.Property(e => e.Hiivident).HasColumnName("HIIVIDENT");
            entity.Property(e => e.Hilk).HasColumnName("HILK");
            entity.Property(e => e.Hilprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE");
            entity.Property(e => e.Hilprice2)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE2");
            entity.Property(e => e.Hilprice3)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE3");
            entity.Property(e => e.Hilpriceeb)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEEB");
            entity.Property(e => e.Hilpriceew)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEEW");
            entity.Property(e => e.Hilpricevn)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEVN");
            entity.Property(e => e.Himan).HasColumnName("HIMAN");
            entity.Property(e => e.Himemo)
                .IsUnicode(false)
                .HasColumnName("HIMEMO");
            entity.Property(e => e.Himileage)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("HIMILEAGE");
            entity.Property(e => e.Hinozzle).HasColumnName("HINOZZLE");
            entity.Property(e => e.Hipbident).HasColumnName("HIPBIDENT");
            entity.Property(e => e.Hiprot).HasColumnName("HIPROT");
            entity.Property(e => e.Hiprtype).HasColumnName("HIPRTYPE");
            entity.Property(e => e.Hipuident).HasColumnName("HIPUIDENT");
            entity.Property(e => e.Hipuvalue)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIPUVALUE");
            entity.Property(e => e.Hiquant)
                .HasColumnType("numeric(10, 3)")
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
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("HITOLLTY");
            entity.Property(e => e.Hitolltz).HasColumnName("HITOLLTZ");
            entity.Property(e => e.Hitotadiff)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTADIFF");
            entity.Property(e => e.Hitotal1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL1");
            entity.Property(e => e.Hitotal2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL2");
            entity.Property(e => e.Hitotal3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL3");
            entity.Property(e => e.Hitotaleb)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEB");
            entity.Property(e => e.Hitotalew)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEW");
            entity.Property(e => e.Hitotalvat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVAT");
            entity.Property(e => e.Hitotalvn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVN");
            entity.Property(e => e.Hitotamount)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTAMOUNT");
            entity.Property(e => e.Hitotqdiff)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTQDIFF");
            entity.Property(e => e.Hitotquantity)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTQUANTITY");
            entity.Property(e => e.Hitrdate)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATE");
            entity.Property(e => e.Hitrdatend)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATEND");
            entity.Property(e => e.Hitrdatsta)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATSTA");
            entity.Property(e => e.Hitrdur).HasColumnName("HITRDUR");
            entity.Property(e => e.Hitrident).HasColumnName("HITRIDENT");
            entity.Property(e => e.Hitype).HasColumnName("HITYPE");
            entity.Property(e => e.Hivaident).HasColumnName("HIVAIDENT");
            entity.Property(e => e.Hivecaident).HasColumnName("HIVECAIDENT");
            entity.Property(e => e.Hiveident).HasColumnName("HIVEIDENT");
            entity.Property(e => e.Ipmemo)
                .IsUnicode(false)
                .HasColumnName("IPMEMO");
            entity.Property(e => e.Ipnumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("IPNUMBER");
            entity.Property(e => e.Iptitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IPTITLE");
            entity.Property(e => e.Ividate)
                .HasColumnType("datetime")
                .HasColumnName("IVIDATE");
            entity.Property(e => e.Ivident).HasColumnName("IVIDENT");
            entity.Property(e => e.Ivno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IVNO");
            entity.Property(e => e.Pbdate)
                .HasColumnType("datetime")
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbimport).HasColumnName("PBIMPORT");
            entity.Property(e => e.Pbmemo)
                .IsUnicode(false)
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnscnum).HasColumnName("PBNSCNUM");
            entity.Property(e => e.Pbnsconln)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("PBNSCONLN");
            entity.Property(e => e.Pbnsconlt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBNSCONLT");
            entity.Property(e => e.Pbnscptf1).HasColumnName("PBNSCPTF1");
            entity.Property(e => e.Pbnscptf2).HasColumnName("PBNSCPTF2");
            entity.Property(e => e.Pbnscrcpt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PBNSCRCPT");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbtype).HasColumnName("PBTYPE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
            entity.Property(e => e.Peact)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PEACT");
            entity.Property(e => e.Pecaident).HasColumnName("PECAIDENT");
            entity.Property(e => e.Peident).HasColumnName("PEIDENT");
            entity.Property(e => e.Pgco2)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("PGCO2");
            entity.Property(e => e.Pgdate)
                .HasColumnType("datetime")
                .HasColumnName("PGDATE");
            entity.Property(e => e.Pgfltype).HasColumnName("PGFLTYPE");
            entity.Property(e => e.Pgident).HasColumnName("PGIDENT");
            entity.Property(e => e.Pgmemo)
                .IsUnicode(false)
                .HasColumnName("PGMEMO");
            entity.Property(e => e.Pgnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PGNUMBER");
            entity.Property(e => e.Pgtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PGTITLE");
            entity.Property(e => e.Pgwho).HasColumnName("PGWHO");
            entity.Property(e => e.Ptdate)
                .HasColumnType("datetime")
                .HasColumnName("PTDATE");
            entity.Property(e => e.Ptfltype).HasColumnName("PTFLTYPE");
            entity.Property(e => e.Ptident).HasColumnName("PTIDENT");
            entity.Property(e => e.Ptmemo)
                .IsUnicode(false)
                .HasColumnName("PTMEMO");
            entity.Property(e => e.Ptnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PTNUMBER");
            entity.Property(e => e.Ptquident).HasColumnName("PTQUIDENT");
            entity.Property(e => e.Pttitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PTTITLE");
            entity.Property(e => e.Pttype).HasColumnName("PTTYPE");
            entity.Property(e => e.Ptwho).HasColumnName("PTWHO");
            entity.Property(e => e.Sradident1).HasColumnName("SRADIDENT_1");
            entity.Property(e => e.Sradident2).HasColumnName("SRADIDENT_2");
            entity.Property(e => e.Srdate1)
                .HasColumnType("datetime")
                .HasColumnName("SRDATE_1");
            entity.Property(e => e.Srdate2)
                .HasColumnType("datetime")
                .HasColumnName("SRDATE_2");
            entity.Property(e => e.Srhlevel1).HasColumnName("SRHLEVEL_1");
            entity.Property(e => e.Srhlevel2).HasColumnName("SRHLEVEL_2");
            entity.Property(e => e.Srident1).HasColumnName("SRIDENT_1");
            entity.Property(e => e.Srident2).HasColumnName("SRIDENT_2");
            entity.Property(e => e.Srimage1).HasColumnName("SRIMAGE_1");
            entity.Property(e => e.Srimage2).HasColumnName("SRIMAGE_2");
            entity.Property(e => e.Srlevel1).HasColumnName("SRLEVEL_1");
            entity.Property(e => e.Srlevel2).HasColumnName("SRLEVEL_2");
            entity.Property(e => e.Srmemo1)
                .IsUnicode(false)
                .HasColumnName("SRMEMO_1");
            entity.Property(e => e.Srmemo2)
                .IsUnicode(false)
                .HasColumnName("SRMEMO_2");
            entity.Property(e => e.Srnumber1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER_1");
            entity.Property(e => e.Srnumber2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER_2");
            entity.Property(e => e.Srsrident1).HasColumnName("SRSRIDENT_1");
            entity.Property(e => e.Srsrident2).HasColumnName("SRSRIDENT_2");
            entity.Property(e => e.Srtitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE_1");
            entity.Property(e => e.Srtitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE_2");
            entity.Property(e => e.Srwho1).HasColumnName("SRWHO_1");
            entity.Property(e => e.Srwho2).HasColumnName("SRWHO_2");
            entity.Property(e => e.Stamauto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMAUTO");
            entity.Property(e => e.Stamdate)
                .HasColumnType("datetime")
                .HasColumnName("STAMDATE");
            entity.Property(e => e.Stamount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMOUNT");
            entity.Property(e => e.Stauto).HasColumnName("STAUTO");
            entity.Property(e => e.Stdate)
                .HasColumnType("datetime")
                .HasColumnName("STDATE");
            entity.Property(e => e.Stident).HasColumnName("STIDENT");
            entity.Property(e => e.Stinv)
                .HasColumnType("datetime")
                .HasColumnName("STINV");
            entity.Property(e => e.Stmax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMAX");
            entity.Property(e => e.Stmeasure)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMEASURE");
            entity.Property(e => e.Stmedate)
                .HasColumnType("datetime")
                .HasColumnName("STMEDATE");
            entity.Property(e => e.Stmemo)
                .IsUnicode(false)
                .HasColumnName("STMEMO");
            entity.Property(e => e.Stmin)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMIN");
            entity.Property(e => e.Stminorder)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STMINORDER");
            entity.Property(e => e.Stnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STNUMBER");
            entity.Property(e => e.Stordate)
                .HasColumnType("datetime")
                .HasColumnName("STORDATE");
            entity.Property(e => e.Storder)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STORDER");
            entity.Property(e => e.Stordered).HasColumnName("STORDERED");
            entity.Property(e => e.Stpbident).HasColumnName("STPBIDENT");
            entity.Property(e => e.Stprobe).HasColumnName("STPROBE");
            entity.Property(e => e.Sttitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STTITLE");
            entity.Property(e => e.Stunit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STUNIT");
            entity.Property(e => e.Stwho).HasColumnName("STWHO");
            entity.Property(e => e.Vadate)
                .HasColumnType("datetime")
                .HasColumnName("VADATE");
            entity.Property(e => e.Vaident).HasColumnName("VAIDENT");
            entity.Property(e => e.Vanumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VANUMBER");
            entity.Property(e => e.Vatitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VATITLE");
            entity.Property(e => e.Vatype).HasColumnName("VATYPE");
            entity.Property(e => e.Vavat)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("VAVAT");
            entity.Property(e => e.Vawho).HasColumnName("VAWHO");
            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECC");
            entity.Property(e => e.Vecocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECOCODE");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasColumnType("datetime")
                .HasColumnName("VEDATE");
            entity.Property(e => e.Vedivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVABBR");
            entity.Property(e => e.Vedivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVISION");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasColumnType("datetime")
                .HasColumnName("VEEND");
            entity.Property(e => e.Vegroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEGROUP");
            entity.Property(e => e.Vehhoffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Veho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEHO");
            entity.Property(e => e.Vehours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .IsUnicode(false)
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles).HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasColumnType("datetime")
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasColumnType("datetime")
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .IsUnicode(false)
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vevehno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("VEVEHNO");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
            entity.Property(e => e.Vtco2).HasColumnName("VTCO2");
            entity.Property(e => e.Vtgvw).HasColumnName("VTGVW");
            entity.Property(e => e.Vtident).HasColumnName("VTIDENT");
            entity.Property(e => e.Vtneg)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTPOS");
            entity.Property(e => e.Vttank).HasColumnName("VTTANK");
        });

        modelBuilder.Entity<Hia3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("HIA_3");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1_2");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adacc22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2_2");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1_2");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adbank22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2_2");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Adctry2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY_2");
            entity.Property(e => e.Addate)
                .HasColumnType("datetime")
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1_2");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1_2");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1_2");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen12).HasColumnName("ADGEN1_2");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adhp2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP_2");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban12)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1_2");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adiban22)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2_2");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1_2");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adibc22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2_2");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adident2).HasColumnName("ADIDENT_2");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1_2");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adloc2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC_2");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adpb2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB_2");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1_2");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adroutno22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2_2");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adstr2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR_2");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1_2");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2_2");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1_2");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Adtype2).HasColumnName("ADTYPE_2");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adwho2).HasColumnName("ADWHO_2");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Adzip2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP_2");
            entity.Property(e => e.Auactive).HasColumnName("AUACTIVE");
            entity.Property(e => e.Auautype).HasColumnName("AUAUTYPE");
            entity.Property(e => e.Audate)
                .HasColumnType("datetime")
                .HasColumnName("AUDATE");
            entity.Property(e => e.Auident).HasColumnName("AUIDENT");
            entity.Property(e => e.Auintern1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUINTERN1");
            entity.Property(e => e.Auintern2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUINTERN2");
            entity.Property(e => e.Aumemo)
                .IsUnicode(false)
                .HasColumnName("AUMEMO");
            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Aurelease).HasColumnName("AURELEASE");
            entity.Property(e => e.Aurelsub).HasColumnName("AURELSUB");
            entity.Property(e => e.Auseries)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUSERIES");
            entity.Property(e => e.Ausysno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUSYSNO");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Autype).HasColumnName("AUTYPE");
            entity.Property(e => e.Auwho).HasColumnName("AUWHO");
            entity.Property(e => e.Cacoident).HasColumnName("CACOIDENT");
            entity.Property(e => e.Cadate)
                .HasColumnType("datetime")
                .HasColumnName("CADATE");
            entity.Property(e => e.Caemident).HasColumnName("CAEMIDENT");
            entity.Property(e => e.Caident).HasColumnName("CAIDENT");
            entity.Property(e => e.Caleident).HasColumnName("CALEIDENT");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2");
            entity.Property(e => e.Catype).HasColumnName("CATYPE");
            entity.Property(e => e.Caveident).HasColumnName("CAVEIDENT");
            entity.Property(e => e.Cawho).HasColumnName("CAWHO");
            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Coadident1).HasColumnName("COADIDENT_1");
            entity.Property(e => e.Coadident2).HasColumnName("COADIDENT_2");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1_1");
            entity.Property(e => e.Cocono12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1_2");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Cocono21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2_1");
            entity.Property(e => e.Cocono22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2_2");
            entity.Property(e => e.Codate)
                .HasColumnType("datetime")
                .HasColumnName("CODATE");
            entity.Property(e => e.Codate1)
                .HasColumnType("datetime")
                .HasColumnName("CODATE_1");
            entity.Property(e => e.Codate2)
                .HasColumnType("datetime")
                .HasColumnName("CODATE_2");
            entity.Property(e => e.Coend)
                .HasColumnType("datetime")
                .HasColumnName("COEND");
            entity.Property(e => e.Coend1)
                .HasColumnType("datetime")
                .HasColumnName("COEND_1");
            entity.Property(e => e.Coend2)
                .HasColumnType("datetime")
                .HasColumnName("COEND_2");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Coident1).HasColumnName("COIDENT_1");
            entity.Property(e => e.Coident2).HasColumnName("COIDENT_2");
            entity.Property(e => e.Comemo)
                .IsUnicode(false)
                .HasColumnName("COMEMO");
            entity.Property(e => e.Comemo1)
                .IsUnicode(false)
                .HasColumnName("COMEMO_1");
            entity.Property(e => e.Comemo2)
                .IsUnicode(false)
                .HasColumnName("COMEMO_2");
            entity.Property(e => e.Costate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE");
            entity.Property(e => e.Costate1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE_1");
            entity.Property(e => e.Costate2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE_2");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1_1");
            entity.Property(e => e.Cotitle12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1_2");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle21)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2_1");
            entity.Property(e => e.Cotitle22)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2_2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotitle31)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3_1");
            entity.Property(e => e.Cotitle32)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3_2");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Cotype1).HasColumnName("COTYPE_1");
            entity.Property(e => e.Cotype2).HasColumnName("COTYPE_2");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
            entity.Property(e => e.Cowho1).HasColumnName("COWHO_1");
            entity.Property(e => e.Cowho2).HasColumnName("COWHO_2");
            entity.Property(e => e.Emadident).HasColumnName("EMADIDENT");
            entity.Property(e => e.Emcoid).HasColumnName("EMCOID");
            entity.Property(e => e.Emcoident).HasColumnName("EMCOIDENT");
            entity.Property(e => e.Emdate)
                .HasColumnType("datetime")
                .HasColumnName("EMDATE");
            entity.Property(e => e.Emdrivno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("EMDRIVNO");
            entity.Property(e => e.Emend)
                .HasColumnType("datetime")
                .HasColumnName("EMEND");
            entity.Property(e => e.Emident).HasColumnName("EMIDENT");
            entity.Property(e => e.Emiscust).HasColumnName("EMISCUST");
            entity.Property(e => e.Emleident).HasColumnName("EMLEIDENT");
            entity.Property(e => e.Emmemo)
                .IsUnicode(false)
                .HasColumnName("EMMEMO");
            entity.Property(e => e.Empersno)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("EMPERSNO");
            entity.Property(e => e.Emstart)
                .HasColumnType("datetime")
                .HasColumnName("EMSTART");
            entity.Property(e => e.Emstate)
                .IsUnicode(false)
                .HasColumnName("EMSTATE");
            entity.Property(e => e.Emtype).HasColumnName("EMTYPE");
            entity.Property(e => e.Emwho).HasColumnName("EMWHO");
            entity.Property(e => e.Fuadident).HasColumnName("FUADIDENT");
            entity.Property(e => e.Fudate)
                .HasColumnType("datetime")
                .HasColumnName("FUDATE");
            entity.Property(e => e.Fuident).HasColumnName("FUIDENT");
            entity.Property(e => e.Fuintno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUINTNO");
            entity.Property(e => e.Fuintno2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUINTNO2");
            entity.Property(e => e.Fumemo)
                .IsUnicode(false)
                .HasColumnName("FUMEMO");
            entity.Property(e => e.Funumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("FUNUMBER");
            entity.Property(e => e.Fusrident).HasColumnName("FUSRIDENT");
            entity.Property(e => e.Futitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE");
            entity.Property(e => e.Futitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE2");
            entity.Property(e => e.Futitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FUTITLE3");
            entity.Property(e => e.Futype).HasColumnName("FUTYPE");
            entity.Property(e => e.Fuwho).HasColumnName("FUWHO");
            entity.Property(e => e.Hiaiident).HasColumnName("HIAIIDENT");
            entity.Property(e => e.Hiauident).HasColumnName("HIAUIDENT");
            entity.Property(e => e.Hicaident).HasColumnName("HICAIDENT");
            entity.Property(e => e.Hicaident2).HasColumnName("HICAIDENT2");
            entity.Property(e => e.Hicon100)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON100");
            entity.Property(e => e.Hicon1000)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON1000");
            entity.Property(e => e.Hiconltr)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONLTR");
            entity.Property(e => e.Hiconrev)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONREV");
            entity.Property(e => e.Hidate)
                .HasColumnType("datetime")
                .HasColumnName("HIDATE");
            entity.Property(e => e.Hiexpdate)
                .HasColumnType("datetime")
                .HasColumnName("HIEXPDATE");
            entity.Property(e => e.Hiflident).HasColumnName("HIFLIDENT");
            entity.Property(e => e.Hifuident).HasColumnName("HIFUIDENT");
            entity.Property(e => e.Hihiident).HasColumnName("HIHIIDENT");
            entity.Property(e => e.Hiident).HasColumnName("HIIDENT");
            entity.Property(e => e.Hiinfo).HasColumnName("HIINFO");
            entity.Property(e => e.Hilprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE");
            entity.Property(e => e.Hilprice2)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE2");
            entity.Property(e => e.Himileage)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("HIMILEAGE");
            entity.Property(e => e.Hipbident).HasColumnName("HIPBIDENT");
            entity.Property(e => e.Hiprot).HasColumnName("HIPROT");
            entity.Property(e => e.Hiquant)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HIQUANT");
            entity.Property(e => e.Hirecno).HasColumnName("HIRECNO");
            entity.Property(e => e.Histate).HasColumnName("HISTATE");
            entity.Property(e => e.Histident).HasColumnName("HISTIDENT");
            entity.Property(e => e.Hitotal1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL1");
            entity.Property(e => e.Hitotal2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL2");
            entity.Property(e => e.Hitrdate)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATE");
            entity.Property(e => e.Hitrident).HasColumnName("HITRIDENT");
            entity.Property(e => e.Hitype).HasColumnName("HITYPE");
            entity.Property(e => e.Hivaident).HasColumnName("HIVAIDENT");
            entity.Property(e => e.Iptitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("iptitle");
            entity.Property(e => e.Pbdate)
                .HasColumnType("datetime")
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbmemo)
                .IsUnicode(false)
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
            entity.Property(e => e.Schiident).HasColumnName("SCHIIDENT");
            entity.Property(e => e.Scvcident).HasColumnName("SCVCIDENT");
            entity.Property(e => e.Sradident1).HasColumnName("SRADIDENT_1");
            entity.Property(e => e.Sradident2).HasColumnName("SRADIDENT_2");
            entity.Property(e => e.Srdate1)
                .HasColumnType("datetime")
                .HasColumnName("SRDATE_1");
            entity.Property(e => e.Srdate2)
                .HasColumnType("datetime")
                .HasColumnName("SRDATE_2");
            entity.Property(e => e.Srhlevel1).HasColumnName("SRHLEVEL_1");
            entity.Property(e => e.Srhlevel2).HasColumnName("SRHLEVEL_2");
            entity.Property(e => e.Srident1).HasColumnName("SRIDENT_1");
            entity.Property(e => e.Srident2).HasColumnName("SRIDENT_2");
            entity.Property(e => e.Srimage1).HasColumnName("SRIMAGE_1");
            entity.Property(e => e.Srimage2).HasColumnName("SRIMAGE_2");
            entity.Property(e => e.Srlevel1).HasColumnName("SRLEVEL_1");
            entity.Property(e => e.Srlevel2).HasColumnName("SRLEVEL_2");
            entity.Property(e => e.Srmemo1)
                .IsUnicode(false)
                .HasColumnName("SRMEMO_1");
            entity.Property(e => e.Srmemo2)
                .IsUnicode(false)
                .HasColumnName("SRMEMO_2");
            entity.Property(e => e.Srnumber1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER_1");
            entity.Property(e => e.Srnumber2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER_2");
            entity.Property(e => e.Srsrident1).HasColumnName("SRSRIDENT_1");
            entity.Property(e => e.Srsrident2).HasColumnName("SRSRIDENT_2");
            entity.Property(e => e.Srtitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE_1");
            entity.Property(e => e.Srtitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE_2");
            entity.Property(e => e.Srwho1).HasColumnName("SRWHO_1");
            entity.Property(e => e.Srwho2).HasColumnName("SRWHO_2");
            entity.Property(e => e.Stamauto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMAUTO");
            entity.Property(e => e.Stamdate)
                .HasColumnType("datetime")
                .HasColumnName("STAMDATE");
            entity.Property(e => e.Stamount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMOUNT");
            entity.Property(e => e.Stauto).HasColumnName("STAUTO");
            entity.Property(e => e.Stdate)
                .HasColumnType("datetime")
                .HasColumnName("STDATE");
            entity.Property(e => e.Stident).HasColumnName("STIDENT");
            entity.Property(e => e.Stinv)
                .HasColumnType("datetime")
                .HasColumnName("STINV");
            entity.Property(e => e.Stmax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMAX");
            entity.Property(e => e.Stmeasure)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMEASURE");
            entity.Property(e => e.Stmedate)
                .HasColumnType("datetime")
                .HasColumnName("STMEDATE");
            entity.Property(e => e.Stmemo)
                .IsUnicode(false)
                .HasColumnName("STMEMO");
            entity.Property(e => e.Stmin)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMIN");
            entity.Property(e => e.Stminorder)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STMINORDER");
            entity.Property(e => e.Stnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("STNUMBER");
            entity.Property(e => e.Stordate)
                .HasColumnType("datetime")
                .HasColumnName("STORDATE");
            entity.Property(e => e.Storder)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STORDER");
            entity.Property(e => e.Stordered).HasColumnName("STORDERED");
            entity.Property(e => e.Stpbident).HasColumnName("STPBIDENT");
            entity.Property(e => e.Stprobe).HasColumnName("STPROBE");
            entity.Property(e => e.Sttitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("STTITLE");
            entity.Property(e => e.Stunit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STUNIT");
            entity.Property(e => e.Stwho).HasColumnName("STWHO");
            entity.Property(e => e.Vadate)
                .HasColumnType("datetime")
                .HasColumnName("VADATE");
            entity.Property(e => e.Vaident).HasColumnName("VAIDENT");
            entity.Property(e => e.Vanumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VANUMBER");
            entity.Property(e => e.Vatitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VATITLE");
            entity.Property(e => e.Vatype).HasColumnName("VATYPE");
            entity.Property(e => e.Vavat)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("VAVAT");
            entity.Property(e => e.Vawho).HasColumnName("VAWHO");
            entity.Property(e => e.Vcident).HasColumnName("VCIDENT");
            entity.Property(e => e.Vctitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VCTITLE");
            entity.Property(e => e.Vcvfident).HasColumnName("VCVFIDENT");
            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECC");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasColumnType("datetime")
                .HasColumnName("VEDATE");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasColumnType("datetime")
                .HasColumnName("VEEND");
            entity.Property(e => e.Vehhoffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Vehours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .IsUnicode(false)
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles).HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasColumnType("datetime")
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasColumnType("datetime")
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .IsUnicode(false)
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
            entity.Property(e => e.Vtgvw).HasColumnName("VTGVW");
            entity.Property(e => e.Vtident).HasColumnName("VTIDENT");
            entity.Property(e => e.Vtneg)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTPOS");
            entity.Property(e => e.Vttank).HasColumnName("VTTANK");
        });

        modelBuilder.Entity<Hium>(entity =>
        {
            entity.HasKey(e => e.Hiident);

            entity.ToTable("HIA");

            entity.HasIndex(e => e.Hiaiident, "INDEX_HIA_ADISP_NOFILTER");

            entity.HasIndex(e => e.Hicaident, "INDEX_HIA_CARD1").HasFilter("([HICAIDENT]>(0))");

            entity.HasIndex(e => e.Hicaident, "INDEX_HIA_CARD1_NOFILTER");

            entity.HasIndex(e => e.Hicaident2, "INDEX_HIA_CARD2").HasFilter("([HICAIDENT2]>(0))");

            entity.HasIndex(e => e.Hicaident2, "INDEX_HIA_CARD2_NOFILTER");

            entity.HasIndex(e => e.Hicaident, "INDEX_HIA_CARDDATE");

            entity.HasIndex(e => e.Hiemident, "INDEX_HIA_EMPLOYEE").HasFilter("([HIEMIDENT]>(0))");

            entity.HasIndex(e => e.Hiemident, "INDEX_HIA_EMPLOYEE_NOFILTER");

            entity.HasIndex(e => e.Hiflident, "INDEX_HIA_FLEET").HasFilter("([HIFLIDENT]>(0))");

            entity.HasIndex(e => e.Hiflident, "INDEX_HIA_FLEET_NOFILTER");

            entity.HasIndex(e => e.Hiintern, "INDEX_HIA_HIINTERN");

            entity.HasIndex(e => e.Hitrdate, "INDEX_HIA_HITRDATE");

            entity.HasIndex(e => e.Hitype, "INDEX_HIA_HITYPE");

            entity.HasIndex(e => e.Hiivident, "INDEX_HIA_INVOICE_NOFILTER");

            entity.HasIndex(e => e.Hipuident, "INDEX_HIA_PREPAID").HasFilter("([HIPUIDENT]>(0))");

            entity.HasIndex(e => e.Hipbident, "INDEX_HIA_PRODUCT");

            entity.HasIndex(e => e.Histident, "INDEX_HIA_STORAGE").HasFilter("([HISTIDENT]>(0))");

            entity.HasIndex(e => e.Hiauident, "INDEX_HIA_TERMINAL").HasFilter("([HIAUIDENT]>(0))");

            entity.HasIndex(e => e.Hiauident, "INDEX_HIA_TERMINAL_NOFILTER");

            entity.HasIndex(e => e.Hitrdate, "INDEX_HIA_TRDATE");

            entity.HasIndex(e => e.Hitrident, "INDEX_HIA_TRIDENT").HasFilter("([HITRIDENT]>(0))");

            entity.HasIndex(e => e.Hitype, "INDEX_HIA_TYPE");

            entity.HasIndex(e => e.Hivaident, "INDEX_HIA_VAT_NOFILTER");

            entity.HasIndex(e => e.Hiveident, "INDEX_HIA_VEHICLE").HasFilter("([HIVEIDENT]>(0))");

            entity.HasIndex(e => new { e.Hiveident, e.Hitrdate }, "INDEX_HIA_VEHICLE_DATE");

            entity.HasIndex(e => e.Hiveident, "INDEX_HIA_VEHICLE_NOFILTER");

            entity.HasIndex(e => new { e.Hiveident, e.Hitrdate, e.Himileage }, "INDEX_HIA_VEHICLE_PROD");

            entity.Property(e => e.Hiident).HasColumnName("HIIDENT");
            entity.Property(e => e.Hiaiident).HasColumnName("HIAIIDENT");
            entity.Property(e => e.Hiauident).HasColumnName("HIAUIDENT");
            entity.Property(e => e.Hicaident).HasColumnName("HICAIDENT");
            entity.Property(e => e.Hicaident2).HasColumnName("HICAIDENT2");
            entity.Property(e => e.Hico2)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICO2");
            entity.Property(e => e.Hico2av)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICO2AV");
            entity.Property(e => e.Hicon100)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON100");
            entity.Property(e => e.Hicon1000)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICON1000");
            entity.Property(e => e.Hiconltr)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONLTR");
            entity.Property(e => e.Hiconrev)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("HICONREV");
            entity.Property(e => e.Hidate)
                .HasColumnType("datetime")
                .HasColumnName("HIDATE");
            entity.Property(e => e.Hidial1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIDIAL1");
            entity.Property(e => e.Hidial2)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIDIAL2");
            entity.Property(e => e.Hidial3)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIDIAL3");
            entity.Property(e => e.Hidial4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIDIAL4");
            entity.Property(e => e.Hidial5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIDIAL5");
            entity.Property(e => e.Hiemcaident).HasColumnName("HIEMCAIDENT");
            entity.Property(e => e.Hiemident).HasColumnName("HIEMIDENT");
            entity.Property(e => e.Hiexpdate)
                .HasColumnType("datetime")
                .HasColumnName("HIEXPDATE");
            entity.Property(e => e.Hiflident).HasColumnName("HIFLIDENT");
            entity.Property(e => e.Hifuident).HasColumnName("HIFUIDENT");
            entity.Property(e => e.Higain)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIGAIN");
            entity.Property(e => e.Higainl)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIGAINL");
            entity.Property(e => e.Hihiident).HasColumnName("HIHIIDENT");
            entity.Property(e => e.Hiinfo).HasColumnName("HIINFO");
            entity.Property(e => e.Hiinfo2).HasColumnName("HIINFO2");
            entity.Property(e => e.Hiintern).HasColumnName("HIINTERN");
            entity.Property(e => e.Hiinvlprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HIINVLPRICE");
            entity.Property(e => e.Hiinvpbase).HasColumnName("HIINVPBASE");
            entity.Property(e => e.Hiinvpextra).HasColumnName("HIINVPEXTRA");
            entity.Property(e => e.Hiinvpexval)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HIINVPEXVAL");
            entity.Property(e => e.Hiinvtotal)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIINVTOTAL");
            entity.Property(e => e.Hiipident).HasColumnName("HIIPIDENT");
            entity.Property(e => e.Hiivident).HasColumnName("HIIVIDENT");
            entity.Property(e => e.Hilk).HasColumnName("HILK");
            entity.Property(e => e.Hilprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE");
            entity.Property(e => e.Hilprice2)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE2");
            entity.Property(e => e.Hilprice3)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICE3");
            entity.Property(e => e.Hilpriceeb)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEEB");
            entity.Property(e => e.Hilpriceew)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEEW");
            entity.Property(e => e.Hilpricevn)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("HILPRICEVN");
            entity.Property(e => e.Himan).HasColumnName("HIMAN");
            entity.Property(e => e.Himemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HIMEMO");
            entity.Property(e => e.Himileage)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("HIMILEAGE");
            entity.Property(e => e.Hinozzle).HasColumnName("HINOZZLE");
            entity.Property(e => e.Hipbident).HasColumnName("HIPBIDENT");
            entity.Property(e => e.Hiprot).HasColumnName("HIPROT");
            entity.Property(e => e.Hiprtype).HasColumnName("HIPRTYPE");
            entity.Property(e => e.Hipuident).HasColumnName("HIPUIDENT");
            entity.Property(e => e.Hipuvalue)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HIPUVALUE");
            entity.Property(e => e.Hiquant)
                .HasColumnType("numeric(10, 3)")
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
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("HITOLLTY");
            entity.Property(e => e.Hitolltz).HasColumnName("HITOLLTZ");
            entity.Property(e => e.Hitotadiff)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTADIFF");
            entity.Property(e => e.Hitotal1)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL1");
            entity.Property(e => e.Hitotal2)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL2");
            entity.Property(e => e.Hitotal3)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTAL3");
            entity.Property(e => e.Hitotaleb)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEB");
            entity.Property(e => e.Hitotalew)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALEW");
            entity.Property(e => e.Hitotalvat)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVAT");
            entity.Property(e => e.Hitotalvn)
                .HasColumnType("numeric(10, 2)")
                .HasColumnName("HITOTALVN");
            entity.Property(e => e.Hitotamount)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTAMOUNT");
            entity.Property(e => e.Hitotqdiff)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTQDIFF");
            entity.Property(e => e.Hitotquantity)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("HITOTQUANTITY");
            entity.Property(e => e.Hitrdate)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATE");
            entity.Property(e => e.Hitrdatend)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATEND");
            entity.Property(e => e.Hitrdatsta)
                .HasColumnType("datetime")
                .HasColumnName("HITRDATSTA");
            entity.Property(e => e.Hitrdur).HasColumnName("HITRDUR");
            entity.Property(e => e.Hitrident).HasColumnName("HITRIDENT");
            entity.Property(e => e.Hitype).HasColumnName("HITYPE");
            entity.Property(e => e.Hivaident).HasColumnName("HIVAIDENT");
            entity.Property(e => e.Hivecaident).HasColumnName("HIVECAIDENT");
            entity.Property(e => e.Hiveident).HasColumnName("HIVEIDENT");
        });

        modelBuilder.Entity<Idcode>(entity =>
        {
            entity.HasKey(e => e.Idident);

            entity.ToTable("IDCODE");

            entity.Property(e => e.Idident).HasColumnName("IDIDENT");
            entity.Property(e => e.Idaddlen).HasColumnName("IDADDLEN");
            entity.Property(e => e.Idaddpos).HasColumnName("IDADDPOS");
            entity.Property(e => e.Idaddtype).HasColumnName("IDADDTYPE");
            entity.Property(e => e.Idaddval)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDADDVAL");
            entity.Property(e => e.Idcard).HasColumnName("IDCARD");
            entity.Property(e => e.Idcntlen).HasColumnName("IDCNTLEN");
            entity.Property(e => e.Idcntpos).HasColumnName("IDCNTPOS");
            entity.Property(e => e.Idcnttype).HasColumnName("IDCNTTYPE");
            entity.Property(e => e.Idcntval)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCNTVAL");
            entity.Property(e => e.Idcode1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCODE1");
            entity.Property(e => e.Idcode2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCODE2");
            entity.Property(e => e.Idcode3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCODE3");
            entity.Property(e => e.Idcode4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCODE4");
            entity.Property(e => e.Idcode5)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDCODE5");
            entity.Property(e => e.Idcon0).HasColumnName("IDCON0");
            entity.Property(e => e.Idcon1).HasColumnName("IDCON1");
            entity.Property(e => e.Idcon2).HasColumnName("IDCON2");
            entity.Property(e => e.Idcon3).HasColumnName("IDCON3");
            entity.Property(e => e.Idcon4).HasColumnName("IDCON4");
            entity.Property(e => e.Idcon5).HasColumnName("IDCON5");
            entity.Property(e => e.Idcon6).HasColumnName("IDCON6");
            entity.Property(e => e.Iddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IDDATE");
            entity.Property(e => e.Idfunpin).HasColumnName("IDFUNPIN");
            entity.Property(e => e.Idinflen).HasColumnName("IDINFLEN");
            entity.Property(e => e.Idinfpos).HasColumnName("IDINFPOS");
            entity.Property(e => e.Idinftype).HasColumnName("IDINFTYPE");
            entity.Property(e => e.Idinfval)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDINFVAL");
            entity.Property(e => e.Idlen1).HasColumnName("IDLEN1");
            entity.Property(e => e.Idlen2).HasColumnName("IDLEN2");
            entity.Property(e => e.Idlen3).HasColumnName("IDLEN3");
            entity.Property(e => e.Idlen4).HasColumnName("IDLEN4");
            entity.Property(e => e.Idlen5).HasColumnName("IDLEN5");
            entity.Property(e => e.Idlenpin).HasColumnName("IDLENPIN");
            entity.Property(e => e.Idmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDMEMO");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))")
                .HasColumnName("IDNUMBER");
            entity.Property(e => e.Idoffset).HasColumnName("IDOFFSET");
            entity.Property(e => e.Idpinlen).HasColumnName("IDPINLEN");
            entity.Property(e => e.Idpinpos).HasColumnName("IDPINPOS");
            entity.Property(e => e.Idpintype).HasColumnName("IDPINTYPE");
            entity.Property(e => e.Idpinval)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDPINVAL");
            entity.Property(e => e.Idpos1).HasColumnName("IDPOS1");
            entity.Property(e => e.Idpos2).HasColumnName("IDPOS2");
            entity.Property(e => e.Idpos3).HasColumnName("IDPOS3");
            entity.Property(e => e.Idpos4).HasColumnName("IDPOS4");
            entity.Property(e => e.Idpos5).HasColumnName("IDPOS5");
            entity.Property(e => e.Idposi1).HasColumnName("IDPOSI1");
            entity.Property(e => e.Idposi2).HasColumnName("IDPOSI2");
            entity.Property(e => e.Idposi3).HasColumnName("IDPOSI3");
            entity.Property(e => e.Idposi4).HasColumnName("IDPOSI4");
            entity.Property(e => e.Idposi5).HasColumnName("IDPOSI5");
            entity.Property(e => e.Idtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IDTITLE");
            entity.Property(e => e.Idtype).HasColumnName("IDTYPE");
            entity.Property(e => e.Idwho).HasColumnName("IDWHO");
        });

        modelBuilder.Entity<Inputadd>(entity =>
        {
            entity.HasKey(e => e.Ipident);

            entity.ToTable("INPUTADD");

            entity.Property(e => e.Ipident).HasColumnName("IPIDENT");
            entity.Property(e => e.Ipdate)
                .HasColumnType("datetime")
                .HasColumnName("IPDATE");
            entity.Property(e => e.Ipmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IPMEMO");
            entity.Property(e => e.Ipnumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IPNUMBER");
            entity.Property(e => e.Iptitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IPTITLE");
            entity.Property(e => e.Iptype).HasColumnName("IPTYPE");
            entity.Property(e => e.Ipwho).HasColumnName("IPWHO");
        });

        modelBuilder.Entity<Invcharge>(entity =>
        {
            entity.HasKey(e => e.Icident);

            entity.ToTable("INVCHARGE");

            entity.Property(e => e.Icident).HasColumnName("ICIDENT");
            entity.Property(e => e.Icdate)
                .HasColumnType("datetime")
                .HasColumnName("ICDATE");
            entity.Property(e => e.Icpbident).HasColumnName("ICPBIDENT");
            entity.Property(e => e.Ictitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("1")
                .HasColumnName("ICTITLE1");
            entity.Property(e => e.Ictitle2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("2")
                .HasColumnName("ICTITLE2");
            entity.Property(e => e.Ictitle3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("3")
                .HasColumnName("ICTITLE3");
            entity.Property(e => e.Ictitle4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("4")
                .HasColumnName("ICTITLE4");
            entity.Property(e => e.Ictitle5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("5")
                .HasColumnName("ICTITLE5");
            entity.Property(e => e.Icvalue1)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("ICVALUE1");
            entity.Property(e => e.Icvalue2)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("ICVALUE2");
            entity.Property(e => e.Icvalue3)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("ICVALUE3");
            entity.Property(e => e.Icvalue4)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("ICVALUE4");
            entity.Property(e => e.Icvalue5)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("ICVALUE5");
            entity.Property(e => e.Icwho).HasColumnName("ICWHO");
        });

        modelBuilder.Entity<Inventory>(entity =>
        {
            entity.HasKey(e => e.Inident);

            entity.ToTable("INVENTORY");

            entity.HasIndex(e => e.Incoident, "INDEX_INVENTORY_INCOIDENT");

            entity.HasIndex(e => e.Inindate, "INDEX_INVENTORY_ININDATE");

            entity.HasIndex(e => e.Inindate, "INDEX_INVENTORY_ININDATE1").IsDescending();

            entity.HasIndex(e => e.Inpbident, "INDEX_INVENTORY_INPBIDENT");

            entity.HasIndex(e => new { e.Inquant, e.Innewwbp }, "INDEX_INVENTORY_INQUANT");

            entity.HasIndex(e => new { e.Instident, e.Inindate }, "INDEX_INVENTORY_INSTIDENT");

            entity.HasIndex(e => new { e.Instident, e.Inpbident, e.Inindate }, "INDEX_INVENTORY_INSTIDENT1");

            entity.Property(e => e.Inident).HasColumnName("INIDENT");
            entity.Property(e => e.Inact)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("INACT");
            entity.Property(e => e.Inbuyprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("INBUYPRICE");
            entity.Property(e => e.Incoident).HasColumnName("INCOIDENT");
            entity.Property(e => e.Incorr).HasColumnName("INCORR");
            entity.Property(e => e.Indate)
                .HasColumnType("datetime")
                .HasColumnName("INDATE");
            entity.Property(e => e.Inindate)
                .HasColumnType("datetime")
                .HasColumnName("ININDATE");
            entity.Property(e => e.Inmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("INMEMO");
            entity.Property(e => e.Innewwbp)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("INNEWWBP");
            entity.Property(e => e.Inpbident).HasColumnName("INPBIDENT");
            entity.Property(e => e.Inquant)
                .HasColumnType("numeric(12, 3)")
                .HasColumnName("INQUANT");
            entity.Property(e => e.Insellprice)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("INSELLPRICE");
            entity.Property(e => e.Instident).HasColumnName("INSTIDENT");
            entity.Property(e => e.Inwbp)
                .HasColumnType("numeric(10, 4)")
                .HasColumnName("INWBP");
            entity.Property(e => e.Inwho).HasColumnName("INWHO");
        });

        modelBuilder.Entity<Invinv>(entity =>
        {
            entity.HasKey(e => e.Iiident);

            entity.ToTable("INVINV");

            entity.Property(e => e.Iiident).HasColumnName("IIIDENT");
            entity.Property(e => e.Iibdisk).HasColumnName("IIBDISK");
            entity.Property(e => e.Iicnt).HasColumnName("IICNT");
            entity.Property(e => e.Iidate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IIDATE");
            entity.Property(e => e.Iidisc)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IIDISC");
            entity.Property(e => e.Iidtadate)
                .HasColumnType("datetime")
                .HasColumnName("IIDTADATE");
            entity.Property(e => e.Iigross)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IIGROSS");
            entity.Property(e => e.Iinet)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IINET");
            entity.Property(e => e.Iivat)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IIVAT");
            entity.Property(e => e.Iiwho).HasColumnName("IIWHO");
        });

        modelBuilder.Entity<Invitem>(entity =>
        {
            entity.HasKey(e => e.Itident);

            entity.ToTable("INVITEM");

            entity.Property(e => e.Itident).HasColumnName("ITIDENT");
            entity.Property(e => e.Itcaident1).HasColumnName("ITCAIDENT1");
            entity.Property(e => e.Itcaident2).HasColumnName("ITCAIDENT2");
            entity.Property(e => e.Itcano1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITCANO1");
            entity.Property(e => e.Itcano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITCANO2");
            entity.Property(e => e.Itcurrno).HasColumnName("ITCURRNO");
            entity.Property(e => e.Itemident).HasColumnName("ITEMIDENT");
            entity.Property(e => e.Itfuident).HasColumnName("ITFUIDENT");
            entity.Property(e => e.Itfustat)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITFUSTAT");
            entity.Property(e => e.Ithiident).HasColumnName("ITHIIDENT");
            entity.Property(e => e.Ithiinfo).HasColumnName("ITHIINFO");
            entity.Property(e => e.Ithours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("ITHOURS");
            entity.Property(e => e.Itidate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ITIDATE");
            entity.Property(e => e.Itintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITINTNO");
            entity.Property(e => e.Itinvpbase).HasColumnName("ITINVPBASE");
            entity.Property(e => e.Itinvprice)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ITINVPRICE");
            entity.Property(e => e.Itinvtotal)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITINVTOTAL");
            entity.Property(e => e.Itipnumber)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITIPNUMBER");
            entity.Property(e => e.Itiptitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITIPTITLE");
            entity.Property(e => e.Itivident).HasColumnName("ITIVIDENT");
            entity.Property(e => e.Itmiles).HasColumnName("ITMILES");
            entity.Property(e => e.Itname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITNAME");
            entity.Property(e => e.Itpbident).HasColumnName("ITPBIDENT");
            entity.Property(e => e.Itperscano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITPERSCANO");
            entity.Property(e => e.Itplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITPLATE");
            entity.Property(e => e.Itpptotalg)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITPPTOTALG");
            entity.Property(e => e.Itpptotaln)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITPPTOTALN");
            entity.Property(e => e.Itppvatval)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITPPVATVAL");
            entity.Property(e => e.Itprod)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITPROD");
            entity.Property(e => e.Itprodnum)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITPRODNUM");
            entity.Property(e => e.Itquant)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITQUANT");
            entity.Property(e => e.Itrectype).HasColumnName("ITRECTYPE");
            entity.Property(e => e.Itsptotalg)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITSPTOTALG");
            entity.Property(e => e.Itsptotaln)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITSPTOTALN");
            entity.Property(e => e.Itspvatval)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("ITSPVATVAL");
            entity.Property(e => e.Ituppprice)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ITUPPPRICE");
            entity.Property(e => e.Itupppriceg)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ITUPPPRICEG");
            entity.Property(e => e.Ituspprice)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ITUSPPRICE");
            entity.Property(e => e.Itusppricen)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ITUSPPRICEN");
            entity.Property(e => e.Itvat)
                .HasColumnType("decimal(4, 2)")
                .HasColumnName("ITVAT");
            entity.Property(e => e.Itvecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITVECC");
            entity.Property(e => e.Itvehcano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITVEHCANO");
            entity.Property(e => e.Itveident).HasColumnName("ITVEIDENT");
            entity.Property(e => e.Itvestoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ITVESTOC");
        });

        modelBuilder.Entity<Invnum>(entity =>
        {
            entity.HasKey(e => e.Iuident);

            entity.ToTable("INVNUM");

            entity.Property(e => e.Iuident).HasColumnName("IUIDENT");
            entity.Property(e => e.Iucnt).HasColumnName("IUCNT");
            entity.Property(e => e.Iucurr).HasColumnName("IUCURR");
            entity.Property(e => e.Iudate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IUDATE");
            entity.Property(e => e.Iufiller).HasColumnName("IUFILLER");
            entity.Property(e => e.Iuinc)
                .HasDefaultValue(1)
                .HasColumnName("IUINC");
            entity.Property(e => e.Iulength).HasColumnName("IULENGTH");
            entity.Property(e => e.Iunotype).HasColumnName("IUNOTYPE");
            entity.Property(e => e.Iuresdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IURESDATE");
            entity.Property(e => e.Iustart)
                .HasDefaultValue(1L)
                .HasColumnName("IUSTART");
            entity.Property(e => e.Iutype).HasColumnName("IUTYPE");
            entity.Property(e => e.Iuvalue)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IUVALUE");
            entity.Property(e => e.Iuwho).HasColumnName("IUWHO");
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasKey(e => e.Ivident);

            entity.ToTable("INVOICE");

            entity.Property(e => e.Ivident).HasColumnName("IVIDENT");
            entity.Property(e => e.Ivbdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVBDATE");
            entity.Property(e => e.Ivbdisk).HasColumnName("IVBDISK");
            entity.Property(e => e.Ivcancdat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVCANCDAT");
            entity.Property(e => e.Ivcancel).HasColumnName("IVCANCEL");
            entity.Property(e => e.Ivcashd)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCASHD");
            entity.Property(e => e.Ivcashdtar)
                .HasColumnType("datetime")
                .HasColumnName("IVCASHDTAR");
            entity.Property(e => e.Ivcashdv)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCASHDV");
            entity.Property(e => e.Ivchnum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCHNUM");
            entity.Property(e => e.Ivchtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCHTITLE");
            entity.Property(e => e.Ivchvaltotal)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCHVALTOTAL");
            entity.Property(e => e.Ivchvalunit)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCHVALUNIT");
            entity.Property(e => e.Ivchvat)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCHVAT");
            entity.Property(e => e.Ivchvatval)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVCHVATVAL");
            entity.Property(e => e.Ivcnt).HasColumnName("IVCNT");
            entity.Property(e => e.Ivcoident).HasColumnName("IVCOIDENT");
            entity.Property(e => e.Ivcuacc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUACC");
            entity.Property(e => e.Ivcuban)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUBAN");
            entity.Property(e => e.Ivcubank)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUBANK");
            entity.Property(e => e.Ivcucity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUCITY");
            entity.Property(e => e.Ivcuctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUCTRY");
            entity.Property(e => e.Ivcuemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUEMAIL");
            entity.Property(e => e.Ivcufax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUFAX");
            entity.Property(e => e.Ivcuhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUHP");
            entity.Property(e => e.Ivcuibc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUIBC");
            entity.Property(e => e.Ivcuname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUNAME");
            entity.Property(e => e.Ivcuno1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUNO1");
            entity.Property(e => e.Ivcuno2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUNO2");
            entity.Property(e => e.Ivcupb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUPB");
            entity.Property(e => e.Ivcuroutno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUROUTNO");
            entity.Property(e => e.Ivcustr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUSTR");
            entity.Property(e => e.Ivcutel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUTEL");
            entity.Property(e => e.Ivcutitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUTITLE1");
            entity.Property(e => e.Ivcutitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUTITLE2");
            entity.Property(e => e.Ivcutitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUTITLE3");
            entity.Property(e => e.Ivcuvatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUVATID");
            entity.Property(e => e.Ivcuzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVCUZIP");
            entity.Property(e => e.Ivdiscount)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVDISCOUNT");
            entity.Property(e => e.Ivdiscspnet)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVDISCSPNET");
            entity.Property(e => e.Ivduedate)
                .HasColumnType("datetime")
                .HasColumnName("IVDUEDATE");
            entity.Property(e => e.Ivedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVEDATE");
            entity.Property(e => e.Ivemaildate)
                .HasColumnType("datetime")
                .HasColumnName("IVEMAILDATE");
            entity.Property(e => e.Ivexdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVEXDATE");
            entity.Property(e => e.Ividate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVIDATE");
            entity.Property(e => e.Iviiident).HasColumnName("IVIIIDENT");
            entity.Property(e => e.Ivintern).HasColumnName("IVINTERN");
            entity.Property(e => e.Ivinvtotal)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVINVTOTAL");
            entity.Property(e => e.Ivisacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISACC1");
            entity.Property(e => e.Ivisacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISACC2");
            entity.Property(e => e.Ivisacc3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISACC3");
            entity.Property(e => e.Ivisban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBAN1");
            entity.Property(e => e.Ivisban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBAN2");
            entity.Property(e => e.Ivisban3)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBAN3");
            entity.Property(e => e.Ivisbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBANK1");
            entity.Property(e => e.Ivisbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBANK2");
            entity.Property(e => e.Ivisbank3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISBANK3");
            entity.Property(e => e.Iviscity)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IVISCITY");
            entity.Property(e => e.Ivisctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISCTRY");
            entity.Property(e => e.Ivisemail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISEMAIL");
            entity.Property(e => e.Ivisfax)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISFAX");
            entity.Property(e => e.Ivishp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISHP");
            entity.Property(e => e.Ivisibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISIBC1");
            entity.Property(e => e.Ivisibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISIBC2");
            entity.Property(e => e.Ivisibc3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISIBC3");
            entity.Property(e => e.Ivispb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISPB");
            entity.Property(e => e.Ivisroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISROUTNO1");
            entity.Property(e => e.Ivisroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISROUTNO2");
            entity.Property(e => e.Ivisroutno3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISROUTNO3");
            entity.Property(e => e.Ivisstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISSTR");
            entity.Property(e => e.Ivistel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISTEL");
            entity.Property(e => e.Ivistext)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISTEXT");
            entity.Property(e => e.Ivistitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISTITLE1");
            entity.Property(e => e.Ivistitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISTITLE2");
            entity.Property(e => e.Ivistitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISTITLE3");
            entity.Property(e => e.Ivisvatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISVATID");
            entity.Property(e => e.Iviszip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVISZIP");
            entity.Property(e => e.Ivmaid)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVMAID");
            entity.Property(e => e.Ivmanager1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVMANAGER1");
            entity.Property(e => e.Ivmanager2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVMANAGER2");
            entity.Property(e => e.Ivmanager3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVMANAGER3");
            entity.Property(e => e.Ivno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("IVNO");
            entity.Property(e => e.Ivpaydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVPAYDATE");
            entity.Property(e => e.Ivpaytype).HasColumnName("IVPAYTYPE");
            entity.Property(e => e.Ivpdfdate)
                .HasColumnType("datetime")
                .HasColumnName("IVPDFDATE");
            entity.Property(e => e.Ivppgross)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVPPGROSS");
            entity.Property(e => e.Ivppnet)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVPPNET");
            entity.Property(e => e.Ivprenot)
                .HasColumnType("datetime")
                .HasColumnName("IVPRENOT");
            entity.Property(e => e.Ivprint).HasColumnName("IVPRINT");
            entity.Property(e => e.Ivprintdate)
                .HasColumnType("datetime")
                .HasColumnName("IVPRINTDATE");
            entity.Property(e => e.Ivregcourt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVREGCOURT");
            entity.Property(e => e.Ivsdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVSDATE");
            entity.Property(e => e.Ivsepaexpdat)
                .HasColumnType("datetime")
                .HasColumnName("IVSEPAEXPDAT");
            entity.Property(e => e.Ivsepaform).HasColumnName("IVSEPAFORM");
            entity.Property(e => e.Ivsepapredat)
                .HasColumnType("datetime")
                .HasColumnName("IVSEPAPREDAT");
            entity.Property(e => e.Ivsepatype).HasColumnName("IVSEPATYPE");
            entity.Property(e => e.Ivseqtype)
                .HasDefaultValue(1)
                .HasColumnName("IVSEQTYPE");
            entity.Property(e => e.Ivspgross)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVSPGROSS");
            entity.Property(e => e.Ivspnet)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVSPNET");
            entity.Property(e => e.Ivtardate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IVTARDATE");
            entity.Property(e => e.Ivtype).HasColumnName("IVTYPE");
            entity.Property(e => e.Ivuci)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IVUCI");
            entity.Property(e => e.Ivvat1)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVAT1");
            entity.Property(e => e.Ivvat2)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVAT2");
            entity.Property(e => e.Ivvat3)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVAT3");
            entity.Property(e => e.Ivvatdisc1)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATDISC1");
            entity.Property(e => e.Ivvatdisc2)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATDISC2");
            entity.Property(e => e.Ivvatdisc3)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATDISC3");
            entity.Property(e => e.Ivvattot1)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATTOT1");
            entity.Property(e => e.Ivvattot2)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATTOT2");
            entity.Property(e => e.Ivvattot3)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATTOT3");
            entity.Property(e => e.Ivvatval1)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL1");
            entity.Property(e => e.Ivvatval1n)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL1N");
            entity.Property(e => e.Ivvatval2)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL2");
            entity.Property(e => e.Ivvatval2n)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL2N");
            entity.Property(e => e.Ivvatval3)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL3");
            entity.Property(e => e.Ivvatval3n)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("IVVATVAL3N");
        });

        modelBuilder.Entity<Invspec>(entity =>
        {
            entity.HasKey(e => e.Ieident);

            entity.ToTable("INVSPEC");

            entity.Property(e => e.Ieident).HasColumnName("IEIDENT");
            entity.Property(e => e.Iecdisc).HasColumnName("IECDISC");
            entity.Property(e => e.Iecdisctar).HasColumnName("IECDISCTAR");
            entity.Property(e => e.Iecharge).HasColumnName("IECHARGE");
            entity.Property(e => e.Iedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("IEDATE");
            entity.Property(e => e.Iediident).HasColumnName("IEDIIDENT");
            entity.Property(e => e.Ieintern).HasColumnName("IEINTERN");
            entity.Property(e => e.Ieintype).HasColumnName("IEINTYPE");
            entity.Property(e => e.Iepayment).HasColumnName("IEPAYMENT");
            entity.Property(e => e.Iepaytext)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("IEPAYTEXT");
            entity.Property(e => e.Ieprident).HasColumnName("IEPRIDENT");
            entity.Property(e => e.Ieprint).HasColumnName("IEPRINT");
            entity.Property(e => e.Ietardays).HasColumnName("IETARDAYS");
            entity.Property(e => e.Ietitle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("IETITLE");
            entity.Property(e => e.Ietype).HasColumnName("IETYPE");
            entity.Property(e => e.Iewho).HasColumnName("IEWHO");
        });

        modelBuilder.Entity<Level>(entity =>
        {
            entity.HasKey(e => e.Leident);

            entity.ToTable("LEVEL");

            entity.HasIndex(e => e.Lelevel, "INDEX_LEVEL_LELEVEL");

            entity.Property(e => e.Leident).HasColumnName("LEIDENT");
            entity.Property(e => e.Ledate)
                .HasColumnType("datetime")
                .HasColumnName("LEDATE");
            entity.Property(e => e.Lelevel).HasColumnName("LELEVEL");
            entity.Property(e => e.Lemenu).HasColumnName("LEMENU");
            entity.Property(e => e.Letext)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("LETEXT");
            entity.Property(e => e.Letype).HasColumnName("LETYPE");
            entity.Property(e => e.Lewho).HasColumnName("LEWHO");
        });

        modelBuilder.Entity<Leveldatum>(entity =>
        {
            entity.HasKey(e => e.Ldident);

            entity.ToTable("LEVELDATA");

            entity.Property(e => e.Ldident).HasColumnName("LDIDENT");
            entity.Property(e => e.Ldauident).HasColumnName("LDAUIDENT");
            entity.Property(e => e.Lddate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LDDATE");
            entity.Property(e => e.Lddate2)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LDDATE2");
            entity.Property(e => e.Lddensity).HasColumnName("LDDENSITY");
            entity.Property(e => e.Ldplevel).HasColumnName("LDPLEVEL");
            entity.Property(e => e.Ldprobe).HasColumnName("LDPROBE");
            entity.Property(e => e.Ldtemp).HasColumnName("LDTEMP");
            entity.Property(e => e.Ldwlevel).HasColumnName("LDWLEVEL");
        });

        modelBuilder.Entity<Levelmeter>(entity =>
        {
            entity.HasKey(e => e.Lmident);

            entity.ToTable("LEVELMETER");

            entity.Property(e => e.Lmident).HasColumnName("LMIDENT");
            entity.Property(e => e.Lmactive).HasColumnName("LMACTIVE");
            entity.Property(e => e.Lmauident).HasColumnName("LMAUIDENT");
            entity.Property(e => e.Lmbaud)
                .HasDefaultValue(1200)
                .HasColumnName("LMBAUD");
            entity.Property(e => e.Lmdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LMDATE");
            entity.Property(e => e.Lmformat).HasColumnName("LMFORMAT");
            entity.Property(e => e.Lmheight).HasColumnName("LMHEIGHT");
            entity.Property(e => e.Lmnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
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
            entity.Property(e => e.Lmprottype)
                .HasDefaultValue(1)
                .HasColumnName("LMPROTTYPE");
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
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("LMTITLE");
            entity.Property(e => e.Lmwho).HasColumnName("LMWHO");
        });

        modelBuilder.Entity<Login>(entity =>
        {
            entity.HasKey(e => e.Loident);

            entity.ToTable("LOGIN");

            entity.Property(e => e.Loident).HasColumnName("LOIDENT");
            entity.Property(e => e.Loadmin)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("LOADMIN");
            entity.Property(e => e.Lodate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("LODATE");
            entity.Property(e => e.Loprog)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("LOPROG");
            entity.Property(e => e.Lotype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("")
                .IsFixedLength()
                .HasColumnName("LOTYPE");
            entity.Property(e => e.Lowho).HasColumnName("LOWHO");
        });

        modelBuilder.Entity<Mclient>(entity =>
        {
            entity.HasKey(e => e.Mcident);

            entity.ToTable("MCLIENT");

            entity.Property(e => e.Mcident).HasColumnName("MCIDENT");
            entity.Property(e => e.Mcdate)
                .HasColumnType("datetime")
                .HasColumnName("MCDATE");
            entity.Property(e => e.Mcmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("MCMEMO");
            entity.Property(e => e.Mcnum).HasColumnName("MCNUM");
            entity.Property(e => e.Mctitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("MCTITLE");
        });

        modelBuilder.Entity<Nscspec>(entity =>
        {
            entity.HasKey(e => e.Nsident);

            entity.ToTable("NSCSPEC");

            entity.Property(e => e.Nsident).HasColumnName("NSIDENT");
            entity.Property(e => e.Nsauident).HasColumnName("NSAUIDENT");
            entity.Property(e => e.Nscaldate)
                .HasColumnType("datetime")
                .HasColumnName("NSCALDATE");
            entity.Property(e => e.Nscalstr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSCALSTR");
            entity.Property(e => e.Nscalsum)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSCALSUM");
            entity.Property(e => e.Nsclocktime).HasColumnName("NSCLOCKTIME");
            entity.Property(e => e.Nsdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NSDATE");
            entity.Property(e => e.Nsdial1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSDIAL1");
            entity.Property(e => e.Nsdial2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSDIAL2");
            entity.Property(e => e.Nsdial3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSDIAL3");
            entity.Property(e => e.Nsdial4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSDIAL4");
            entity.Property(e => e.Nsdial5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSDIAL5");
            entity.Property(e => e.Nshwstr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("NSHWSTR");
            entity.Property(e => e.Nsnochange).HasColumnName("NSNOCHANGE");
            entity.Property(e => e.Nstintern).HasColumnName("NSTINTERN");
            entity.Property(e => e.Nstprice).HasColumnName("NSTPRICE");
            entity.Property(e => e.Nstype1).HasColumnName("NSTYPE1");
            entity.Property(e => e.Nstype2).HasColumnName("NSTYPE2");
            entity.Property(e => e.Nstype3).HasColumnName("NSTYPE3");
            entity.Property(e => e.Nstype4).HasColumnName("NSTYPE4");
            entity.Property(e => e.Nstype5).HasColumnName("NSTYPE5");
            entity.Property(e => e.Nswho).HasColumnName("NSWHO");
        });

        modelBuilder.Entity<Nscstat>(entity =>
        {
            entity.HasKey(e => e.Ntident);

            entity.ToTable("NSCSTAT");

            entity.Property(e => e.Ntident).HasColumnName("NTIDENT");
            entity.Property(e => e.Ntauident).HasColumnName("NTAUIDENT");
            entity.Property(e => e.Ntbnwrecno).HasColumnName("NTBNWRECNO");
            entity.Property(e => e.Ntdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("NTDATE");
            entity.Property(e => e.Ntejdate)
                .HasColumnType("datetime")
                .HasColumnName("NTEJDATE");
            entity.Property(e => e.Ntejnum).HasColumnName("NTEJNUM");
            entity.Property(e => e.Ntejstat).HasColumnName("NTEJSTAT");
            entity.Property(e => e.Ntendgap).HasColumnName("NTENDGAP");
            entity.Property(e => e.Ntlastblno).HasColumnName("NTLASTBLNO");
            entity.Property(e => e.Ntnozzle).HasColumnName("NTNOZZLE");
            entity.Property(e => e.Ntnscbl).HasColumnName("NTNSCBL");
            entity.Property(e => e.Ntnscerr).HasColumnName("NTNSCERR");
            entity.Property(e => e.Ntnscstat).HasColumnName("NTNSCSTAT");
            entity.Property(e => e.Ntpcbl).HasColumnName("NTPCBL");
            entity.Property(e => e.Ntrecno).HasColumnName("NTRECNO");
            entity.Property(e => e.Ntrespbl).HasColumnName("NTRESPBL");
            entity.Property(e => e.Ntrespnum).HasColumnName("NTRESPNUM");
            entity.Property(e => e.Ntrrdate)
                .HasColumnType("datetime")
                .HasColumnName("NTRRDATE");
            entity.Property(e => e.Ntrrstat).HasColumnName("NTRRSTAT");
            entity.Property(e => e.Ntstartgap).HasColumnName("NTSTARTGAP");
            entity.Property(e => e.Nttanum).HasColumnName("NTTANUM");
            entity.Property(e => e.Ntterm).HasColumnName("NTTERM");
            entity.Property(e => e.Ntterm1e).HasColumnName("NTTERM1E");
            entity.Property(e => e.Ntterm1rpe).HasColumnName("NTTERM1RPE");
            entity.Property(e => e.Ntterm1rps).HasColumnName("NTTERM1RPS");
            entity.Property(e => e.Ntterm1s).HasColumnName("NTTERM1S");
            entity.Property(e => e.Ntterm2e).HasColumnName("NTTERM2E");
            entity.Property(e => e.Ntterm2rpe).HasColumnName("NTTERM2RPE");
            entity.Property(e => e.Ntterm2rps).HasColumnName("NTTERM2RPS");
            entity.Property(e => e.Ntterm2s).HasColumnName("NTTERM2S");
            entity.Property(e => e.Nttrnum).HasColumnName("NTTRNUM");
            entity.Property(e => e.Nttrstat).HasColumnName("NTTRSTAT");
            entity.Property(e => e.Ntwho).HasColumnName("NTWHO");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Orident);

            entity.ToTable("ORDERS");

            entity.HasIndex(e => e.Orstate, "INDEX_ORDERS_STATE");

            entity.HasIndex(e => e.Orauident, "INDEX_ORDERS_TERMINAL");

            entity.Property(e => e.Orident).HasColumnName("ORIDENT");
            entity.Property(e => e.Orauident).HasColumnName("ORAUIDENT");
            entity.Property(e => e.Orcnt).HasColumnName("ORCNT");
            entity.Property(e => e.Ordata)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ORDATA");
            entity.Property(e => e.Ordate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ORDATE");
            entity.Property(e => e.Orerror).HasColumnName("ORERROR");
            entity.Property(e => e.Orprogno).HasColumnName("ORPROGNO");
            entity.Property(e => e.Orrqno).HasColumnName("ORRQNO");
            entity.Property(e => e.Orstart)
                .HasColumnType("datetime")
                .HasColumnName("ORSTART");
            entity.Property(e => e.Orstate).HasColumnName("ORSTATE");
            entity.Property(e => e.Orwho).HasColumnName("ORWHO");
        });

        modelBuilder.Entity<Overview>(entity =>
        {
            entity.HasKey(e => e.Ovident);

            entity.ToTable("OVERVIEWS");

            entity.Property(e => e.Ovident).HasColumnName("OVIDENT");
            entity.Property(e => e.Ovcolnum).HasColumnName("OVCOLNUM");
            entity.Property(e => e.Ovcolsize).HasColumnName("OVCOLSIZE");
            entity.Property(e => e.Ovcoltitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OVCOLTITLE");
            entity.Property(e => e.Ovcolustitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OVCOLUSTITLE");
            entity.Property(e => e.Ovdate)
                .HasColumnType("datetime")
                .HasColumnName("OVDATE");
            entity.Property(e => e.Ovnum).HasColumnName("OVNUM");
            entity.Property(e => e.Ovusident).HasColumnName("OVUSIDENT");
        });

        modelBuilder.Entity<Ovsort>(entity =>
        {
            entity.HasKey(e => e.Osident);

            entity.ToTable("OVSORT");

            entity.Property(e => e.Osident).HasColumnName("OSIDENT");
            entity.Property(e => e.Osdate)
                .HasColumnType("datetime")
                .HasColumnName("OSDATE");
            entity.Property(e => e.Osfilter).HasColumnName("OSFILTER");
            entity.Property(e => e.Osovnum).HasColumnName("OSOVNUM");
            entity.Property(e => e.Ossort1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSSORT1");
            entity.Property(e => e.Ossort2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSSORT2");
            entity.Property(e => e.Ossort3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSSORT3");
            entity.Property(e => e.Ossort4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSSORT4");
            entity.Property(e => e.Ossort5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSSORT5");
            entity.Property(e => e.Ostitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("OSTITLE");
            entity.Property(e => e.Osusident).HasColumnName("OSUSIDENT");
        });

        modelBuilder.Entity<Pbase>(entity =>
        {
            entity.HasKey(e => e.Pbident);

            entity.ToTable("PBASE");

            entity.HasIndex(e => e.Pbtitle, "INDEX_PBASE_NAME");

            entity.HasIndex(e => e.Pbnumber, "INDEX_PBASE_NUMBER").HasFilter("([PBNUMBER]<>'')");

            entity.HasIndex(e => e.Pbwho, "INDEX_PBASE_WHO");

            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbimport).HasColumnName("PBIMPORT");
            entity.Property(e => e.Pbmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnscnum).HasColumnName("PBNSCNUM");
            entity.Property(e => e.Pbnsconln)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBNSCONLN");
            entity.Property(e => e.Pbnsconlt)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBNSCONLT");
            entity.Property(e => e.Pbnscptf1).HasColumnName("PBNSCPTF1");
            entity.Property(e => e.Pbnscptf2).HasColumnName("PBNSCPTF2");
            entity.Property(e => e.Pbnscrcpt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBNSCRCPT");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbtype).HasColumnName("PBTYPE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
        });

        modelBuilder.Entity<Pgroup>(entity =>
        {
            entity.HasKey(e => e.Pgident);

            entity.ToTable("PGROUP");

            entity.Property(e => e.Pgident).HasColumnName("PGIDENT");
            entity.Property(e => e.Pgco2)
                .HasColumnType("decimal(5, 3)")
                .HasColumnName("PGCO2");
            entity.Property(e => e.Pgdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PGDATE");
            entity.Property(e => e.Pgfltype).HasColumnName("PGFLTYPE");
            entity.Property(e => e.Pgmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PGMEMO");
            entity.Property(e => e.Pgnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PGNUMBER");
            entity.Property(e => e.Pgtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PGTITLE");
            entity.Property(e => e.Pgwho).HasColumnName("PGWHO");
        });

        modelBuilder.Entity<Pprice>(entity =>
        {
            entity.HasKey(e => e.Ppident);

            entity.ToTable("PPRICE");

            entity.Property(e => e.Ppident).HasColumnName("PPIDENT");
            entity.Property(e => e.Ppdate)
                .HasColumnType("datetime")
                .HasColumnName("PPDATE");
            entity.Property(e => e.Ppeffdate)
                .HasColumnType("datetime")
                .HasColumnName("PPEFFDATE");
            entity.Property(e => e.Ppfuident).HasColumnName("PPFUIDENT");
            entity.Property(e => e.Pppbident).HasColumnName("PPPBIDENT");
            entity.Property(e => e.Ppprice)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("PPPRICE");
            entity.Property(e => e.Pptype).HasColumnName("PPTYPE");
            entity.Property(e => e.Ppvaident).HasColumnName("PPVAIDENT");
            entity.Property(e => e.Ppvat)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("PPVAT");
            entity.Property(e => e.Ppwho).HasColumnName("PPWHO");
        });

        modelBuilder.Entity<Preauth>(entity =>
        {
            entity.HasKey(e => e.Paident);

            entity.ToTable("PREAUTH");

            entity.Property(e => e.Paident).HasColumnName("PAIDENT");
            entity.Property(e => e.Paauident).HasColumnName("PAAUIDENT");
            entity.Property(e => e.Pacar).HasColumnName("PACAR");
            entity.Property(e => e.Pacard).HasColumnName("PACARD");
            entity.Property(e => e.Padate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PADATE");
            entity.Property(e => e.Pareceipt).HasColumnName("PARECEIPT");
            entity.Property(e => e.Patruck).HasColumnName("PATRUCK");
            entity.Property(e => e.Pawho).HasColumnName("PAWHO");
        });

        modelBuilder.Entity<Prepaid>(entity =>
        {
            entity.HasKey(e => e.Peident);

            entity.ToTable("PREPAID");

            entity.Property(e => e.Peident).HasColumnName("PEIDENT");
            entity.Property(e => e.Peact)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PEACT");
            entity.Property(e => e.Peactdate)
                .HasColumnType("datetime")
                .HasColumnName("PEACTDATE");
            entity.Property(e => e.Pecaident).HasColumnName("PECAIDENT");
            entity.Property(e => e.Pechange)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("PECHANGE");
            entity.Property(e => e.Pedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PEDATE");
            entity.Property(e => e.Pedownload)
                .HasDefaultValue(1)
                .HasColumnName("PEDOWNLOAD");
            entity.Property(e => e.Pewho).HasColumnName("PEWHO");
        });

        modelBuilder.Entity<Pricing>(entity =>
        {
            entity.HasKey(e => e.Prident);

            entity.ToTable("PRICING");

            entity.Property(e => e.Prident).HasColumnName("PRIDENT");
            entity.Property(e => e.Prdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PRDATE");
            entity.Property(e => e.Prtitle)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PRTITLE");
            entity.Property(e => e.Prwho).HasColumnName("PRWHO");
        });

        modelBuilder.Entity<Pricprod>(entity =>
        {
            entity.HasKey(e => e.Piident);

            entity.ToTable("PRICPROD");

            entity.Property(e => e.Piident).HasColumnName("PIIDENT");
            entity.Property(e => e.Pidate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PIDATE");
            entity.Property(e => e.Pipbident).HasColumnName("PIPBIDENT");
            entity.Property(e => e.Piprident).HasColumnName("PIPRIDENT");
            entity.Property(e => e.Pitype).HasColumnName("PITYPE");
            entity.Property(e => e.Pivaldat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PIVALDAT");
            entity.Property(e => e.Pivaltype).HasColumnName("PIVALTYPE");
            entity.Property(e => e.Pivalue)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("PIVALUE");
            entity.Property(e => e.Piwho).HasColumnName("PIWHO");
        });

        modelBuilder.Entity<Ptype>(entity =>
        {
            entity.HasKey(e => e.Ptident);

            entity.ToTable("PTYPE");

            entity.Property(e => e.Ptident).HasColumnName("PTIDENT");
            entity.Property(e => e.Ptdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("PTDATE");
            entity.Property(e => e.Ptfltype).HasColumnName("PTFLTYPE");
            entity.Property(e => e.Ptmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PTMEMO");
            entity.Property(e => e.Ptnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PTNUMBER");
            entity.Property(e => e.Ptquident).HasColumnName("PTQUIDENT");
            entity.Property(e => e.Pttitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("PTTITLE");
            entity.Property(e => e.Pttype).HasColumnName("PTTYPE");
            entity.Property(e => e.Ptwho).HasColumnName("PTWHO");
        });

        modelBuilder.Entity<Queue>(entity =>
        {
            entity.HasKey(e => e.Qeident);

            entity.ToTable("QUEUES");

            entity.HasIndex(e => e.Qedate, "INDEX_QUEUES_QEDATE");

            entity.HasIndex(e => e.Qeorident, "INDEX_QUEUES_QEORIDENT");

            entity.HasIndex(e => e.Qestate, "INDEX_QUEUES_STATE");

            entity.HasIndex(e => e.Qeauident, "INDEX_QUEUES_TERMINAL");

            entity.HasIndex(e => e.Qestate, "NONCLUSTEREDINDEX-20160510-101016");

            entity.Property(e => e.Qeident).HasColumnName("QEIDENT");
            entity.Property(e => e.Qeauident).HasColumnName("QEAUIDENT");
            entity.Property(e => e.Qeblockno)
                .HasDefaultValue(-1L)
                .HasColumnName("QEBLOCKNO");
            entity.Property(e => e.Qecnt).HasColumnName("QECNT");
            entity.Property(e => e.Qedata)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("QEDATA");
            entity.Property(e => e.Qedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("QEDATE");
            entity.Property(e => e.Qeorident).HasColumnName("QEORIDENT");
            entity.Property(e => e.Qerqno).HasColumnName("QERQNO");
            entity.Property(e => e.Qestate)
                .HasDefaultValue(1)
                .HasColumnName("QESTATE");
        });

        modelBuilder.Entity<Qunit>(entity =>
        {
            entity.HasKey(e => e.Quident);

            entity.ToTable("QUNITS");

            entity.Property(e => e.Quident).HasColumnName("QUIDENT");
            entity.Property(e => e.Qudate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("QUDATE");
            entity.Property(e => e.Qufltype).HasColumnName("QUFLTYPE");
            entity.Property(e => e.Qumemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("QUMEMO");
            entity.Property(e => e.Qunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("QUNUMBER");
            entity.Property(e => e.Qutitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("QUTITLE");
            entity.Property(e => e.Quwho).HasColumnName("QUWHO");
        });

        modelBuilder.Entity<Reference>(entity =>
        {
            entity.HasKey(e => e.Reident);

            entity.ToTable("REFERENCE");

            entity.HasIndex(e => e.Reauident, "INDEX_REFERENCE_REAUIDENT");

            entity.HasIndex(e => e.Recaident, "INDEX_REFERENCE_RECAIDENT");

            entity.Property(e => e.Reident).HasColumnName("REIDENT");
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
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RECODENSC");
            entity.Property(e => e.Recolstate).HasColumnName("RECOLSTATE");
            entity.Property(e => e.Recrident).HasColumnName("RECRIDENT");
            entity.Property(e => e.Redial).HasColumnName("REDIAL");
            entity.Property(e => e.Redialog).HasColumnName("REDIALOG");
            entity.Property(e => e.Redown).HasColumnName("REDOWN");
            entity.Property(e => e.Reexpire)
                .HasColumnType("datetime")
                .HasColumnName("REEXPIRE");
            entity.Property(e => e.Rehh).HasColumnName("REHH");
            entity.Property(e => e.Relex).HasColumnName("RELEX");
            entity.Property(e => e.Relimit).HasColumnName("RELIMIT");
            entity.Property(e => e.Relock).HasColumnName("RELOCK");
            entity.Property(e => e.Remessno).HasColumnName("REMESSNO");
            entity.Property(e => e.Remileage).HasColumnName("REMILEAGE");
            entity.Property(e => e.Reoffgroup).HasColumnName("REOFFGROUP");
            entity.Property(e => e.Reogident).HasColumnName("REOGIDENT");
            entity.Property(e => e.Repin).HasColumnName("REPIN");
            entity.Property(e => e.Repinonl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("REPINONL");
            entity.Property(e => e.Reprivate).HasColumnName("REPRIVATE");
            entity.Property(e => e.Requant).HasColumnName("REQUANT");
            entity.Property(e => e.Rerange).HasColumnName("RERANGE");
            entity.Property(e => e.Resecond).HasColumnName("RESECOND");
            entity.Property(e => e.Retype).HasColumnName("RETYPE");
            entity.Property(e => e.Revalid)
                .HasColumnType("datetime")
                .HasColumnName("REVALID");
        });

        modelBuilder.Entity<Response>(entity =>
        {
            entity.HasKey(e => e.Rsident);

            entity.ToTable("RESPONSE");

            entity.Property(e => e.Rsident).HasColumnName("RSIDENT");
            entity.Property(e => e.Rsauident).HasColumnName("RSAUIDENT");
            entity.Property(e => e.Rsdata)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("RSDATA");
            entity.Property(e => e.Rsdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("RSDATE");
            entity.Property(e => e.Rsorident).HasColumnName("RSORIDENT");
            entity.Property(e => e.Rsrqno).HasColumnName("RSRQNO");
            entity.Property(e => e.Rsstate).HasColumnName("RSSTATE");
        });

        modelBuilder.Entity<Scharac>(entity =>
        {
            entity.HasKey(e => e.Scident);

            entity.ToTable("SCHARAC");

            entity.HasIndex(e => e.Schiident, "INDEX_SCHARAC_SCHIIDENT");

            entity.HasIndex(e => e.Scvcident, "INDEX_SCHARAC_SCVCIDENT");

            entity.Property(e => e.Scident).HasColumnName("SCIDENT");
            entity.Property(e => e.Schiident).HasColumnName("SCHIIDENT");
            entity.Property(e => e.Scvcident).HasColumnName("SCVCIDENT");
        });

        modelBuilder.Entity<Search>(entity =>
        {
            entity.HasKey(e => e.Seident);

            entity.ToTable("SEARCH");

            entity.Property(e => e.Seident).HasColumnName("SEIDENT");
            entity.Property(e => e.Seauto).HasColumnName("SEAUTO");
            entity.Property(e => e.Secap)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SECAP");
            entity.Property(e => e.Sedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SEDATE");
            entity.Property(e => e.Selisttype).HasColumnName("SELISTTYPE");
            entity.Property(e => e.Sememo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SEMEMO");
            entity.Property(e => e.Seprog).HasColumnName("SEPROG");
            entity.Property(e => e.Sesql)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SESQL");
            entity.Property(e => e.Sewho).HasColumnName("SEWHO");
        });

        modelBuilder.Entity<Sstructure>(entity =>
        {
            entity.HasKey(e => e.Ssident);

            entity.ToTable("SSTRUCTURE");

            entity.HasIndex(e => e.Sshiident, "INDEX_SSTRUCTURE_HICOIDENT");

            entity.HasIndex(e => e.Sshiident, "INDEX_SSTRUCTURE_HISRIDENT");

            entity.HasIndex(e => e.Sscoident, "INDEX_SSTRUCTURE_SCOIDENT");

            entity.HasIndex(e => e.Sshiident, "INDEX_SSTRUCTURE_SSHIIDENT");

            entity.HasIndex(e => e.Sssrident, "INDEX_SSTRUCTURE_SSSRIDENT");

            entity.Property(e => e.Ssident).HasColumnName("SSIDENT");
            entity.Property(e => e.Sscoident).HasColumnName("SSCOIDENT");
            entity.Property(e => e.Sshiident).HasColumnName("SSHIIDENT");
            entity.Property(e => e.Sssrident).HasColumnName("SSSRIDENT");
        });

        modelBuilder.Entity<Sthistory>(entity =>
        {
            entity.HasKey(e => e.Shident);

            entity.ToTable("STHISTORY");

            entity.HasIndex(e => e.Shcoident, "INDEX_STHISTORY_SHCOIDENT");

            entity.HasIndex(e => e.Shsrident, "INDEX_STHISTORY_SHSRIDENT");

            entity.HasIndex(e => e.Shvaldate, "INDEX_STHISTORY_SHVALDATE");

            entity.HasIndex(e => e.Shveident, "INDEX_STHISTORY_SHVEIDENT");

            entity.Property(e => e.Shident).HasColumnName("SHIDENT");
            entity.Property(e => e.Shcoident)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHCOIDENT");
            entity.Property(e => e.Shdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SHDATE");
            entity.Property(e => e.Shsrident)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHSRIDENT");
            entity.Property(e => e.Shvaldate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SHVALDATE");
            entity.Property(e => e.Shveident)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHVEIDENT");
            entity.Property(e => e.Shwho).HasColumnName("SHWHO");
        });

        modelBuilder.Entity<Storage>(entity =>
        {
            entity.HasKey(e => e.Stident);

            entity.ToTable("STORAGE");

            entity.HasIndex(e => e.Sttitle, "INDEX_STORAGE_NAME");

            entity.HasIndex(e => e.Stnumber, "INDEX_STORAGE_NUMBER").HasFilter("([STNUMBER]<>'')");

            entity.HasIndex(e => e.Stpbident, "INDEX_STORAGE_PRODUCT");

            entity.HasIndex(e => e.Stwho, "INDEX_STORAGE_WHO");

            entity.Property(e => e.Stident).HasColumnName("STIDENT");
            entity.Property(e => e.Stamauto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMAUTO");
            entity.Property(e => e.Stamdate)
                .HasColumnType("datetime")
                .HasColumnName("STAMDATE");
            entity.Property(e => e.Stamount)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STAMOUNT");
            entity.Property(e => e.Stauto).HasColumnName("STAUTO");
            entity.Property(e => e.Stdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("STDATE");
            entity.Property(e => e.Stinv)
                .HasColumnType("datetime")
                .HasColumnName("STINV");
            entity.Property(e => e.Stlargequ).HasColumnName("STLARGEQU");
            entity.Property(e => e.Stmax)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMAX");
            entity.Property(e => e.Stmeasure)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMEASURE");
            entity.Property(e => e.Stmedate)
                .HasColumnType("datetime")
                .HasColumnName("STMEDATE");
            entity.Property(e => e.Stmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("STMEMO");
            entity.Property(e => e.Stmin)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STMIN");
            entity.Property(e => e.Stminorder)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STMINORDER");
            entity.Property(e => e.Stnscinvmon).HasColumnName("STNSCINVMON");
            entity.Property(e => e.Stnscinvweek).HasColumnName("STNSCINVWEEK");
            entity.Property(e => e.Stnscnum).HasColumnName("STNSCNUM");
            entity.Property(e => e.Stnsctime).HasColumnName("STNSCTIME");
            entity.Property(e => e.Stnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("STNUMBER");
            entity.Property(e => e.Stordate)
                .HasColumnType("datetime")
                .HasColumnName("STORDATE");
            entity.Property(e => e.Storder)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("STORDER");
            entity.Property(e => e.Stordered).HasColumnName("STORDERED");
            entity.Property(e => e.Stpbident).HasColumnName("STPBIDENT");
            entity.Property(e => e.Stpos).HasColumnName("STPOS");
            entity.Property(e => e.Stprobe).HasColumnName("STPROBE");
            entity.Property(e => e.Stshow).HasColumnName("STSHOW");
            entity.Property(e => e.Sttitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("STTITLE");
            entity.Property(e => e.Stunit)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("STUNIT");
            entity.Property(e => e.Stwho).HasColumnName("STWHO");
        });

        modelBuilder.Entity<Stosel>(entity =>
        {
            entity.HasKey(e => e.Soident);

            entity.ToTable("STOSEL");

            entity.Property(e => e.Soident).HasColumnName("SOIDENT");
            entity.Property(e => e.Soactive).HasColumnName("SOACTIVE");
            entity.Property(e => e.Sopos).HasColumnName("SOPOS");
            entity.Property(e => e.Sostident).HasColumnName("SOSTIDENT");
            entity.Property(e => e.Sousident).HasColumnName("SOUSIDENT");
        });

        modelBuilder.Entity<Structure>(entity =>
        {
            entity.HasKey(e => e.Srident);

            entity.ToTable("STRUCTURE");

            entity.HasIndex(e => e.Srlevel, "INDEX_STRUCTURE_SRLEVEL");

            entity.Property(e => e.Srident).HasColumnName("SRIDENT");
            entity.Property(e => e.Sradident).HasColumnName("SRADIDENT");
            entity.Property(e => e.Srdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SRDATE");
            entity.Property(e => e.Srhlevel).HasColumnName("SRHLEVEL");
            entity.Property(e => e.Srimage).HasColumnName("SRIMAGE");
            entity.Property(e => e.Srlevel).HasColumnName("SRLEVEL");
            entity.Property(e => e.Srmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SRMEMO");
            entity.Property(e => e.Srnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SRNUMBER");
            entity.Property(e => e.Srsrident).HasColumnName("SRSRIDENT");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Srwho).HasColumnName("SRWHO");
        });

        modelBuilder.Entity<Svaccdriv>(entity =>
        {
            entity.HasKey(e => e.Saident);

            entity.ToTable("SVACCDRIV");

            entity.Property(e => e.Saident).HasColumnName("SAIDENT");
            entity.Property(e => e.Saaccount).HasColumnName("SAACCOUNT");
            entity.Property(e => e.Saauident).HasColumnName("SAAUIDENT");
            entity.Property(e => e.Sadrvno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SADRVNO");
            entity.Property(e => e.Saemident).HasColumnName("SAEMIDENT");
            entity.Property(e => e.Sapin).HasColumnName("SAPIN");
        });

        modelBuilder.Entity<Svaccinp>(entity =>
        {
            entity.HasKey(e => e.Siident);

            entity.ToTable("SVACCINP");

            entity.Property(e => e.Siident).HasColumnName("SIIDENT");
            entity.Property(e => e.Siaccount).HasColumnName("SIACCOUNT");
            entity.Property(e => e.Siauident).HasColumnName("SIAUIDENT");
            entity.Property(e => e.Siipident).HasColumnName("SIIPIDENT");
        });

        modelBuilder.Entity<Svaccount>(entity =>
        {
            entity.HasKey(e => e.Svident);

            entity.ToTable("SVACCOUNT");

            entity.HasIndex(e => e.Svcaident, "INDEX_SVACCOUNT_CARD");

            entity.HasIndex(e => new { e.Svauident, e.Svcaident }, "INDEX_SVACCOUNT_CARDTERM");

            entity.HasIndex(e => e.Svauident, "INDEX_SVACCOUNT_TERMINAL");

            entity.Property(e => e.Svident).HasColumnName("SVIDENT");
            entity.Property(e => e.Svaccount1).HasColumnName("SVACCOUNT");
            entity.Property(e => e.Svauident).HasColumnName("SVAUIDENT");
            entity.Property(e => e.Svcaident).HasColumnName("SVCAIDENT");
        });

        modelBuilder.Entity<Sysprop>(entity =>
        {
            entity.HasKey(e => e.Soident);

            entity.ToTable("SYSPROP");

            entity.Property(e => e.Soident).HasColumnName("SOIDENT");
            entity.Property(e => e.Sodate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SODATE");
            entity.Property(e => e.Sotitle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SOTITLE");
            entity.Property(e => e.Soval)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SOVAL");
            entity.Property(e => e.Sowho).HasColumnName("SOWHO");
        });

        modelBuilder.Entity<System>(entity =>
        {
            entity.HasKey(e => e.Syident);

            entity.ToTable("SYSTEM");

            entity.Property(e => e.Syident).HasColumnName("SYIDENT");
            entity.Property(e => e.Syattachin)
                .HasDefaultValue(1)
                .HasColumnName("SYATTACHIN");
            entity.Property(e => e.Sycnt)
                .HasDefaultValue(1)
                .HasColumnName("SYCNT");
            entity.Property(e => e.Syctryno).HasColumnName("SYCTRYNO");
            entity.Property(e => e.Sydate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("SYDATE");
            entity.Property(e => e.Syfrom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SYFROM");
            entity.Property(e => e.Syibancheck)
                .HasDefaultValue(1)
                .HasColumnName("SYIBANCHECK");
            entity.Property(e => e.Symaid)
                .HasDefaultValue(6)
                .HasColumnName("SYMAID");
            entity.Property(e => e.Sypain)
                .HasDefaultValue(2)
                .HasColumnName("SYPAIN");
            entity.Property(e => e.Syport).HasColumnName("SYPORT");
            entity.Property(e => e.Sypw)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SYPW");
            entity.Property(e => e.Sysendsepa)
                .HasDefaultValue(1)
                .HasColumnName("SYSENDSEPA");
            entity.Property(e => e.Sysepa)
                .HasDefaultValue(1)
                .HasColumnName("SYSEPA");
            entity.Property(e => e.Sysmtp)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SYSMTP");
            entity.Property(e => e.Syssl).HasColumnName("SYSSL");
            entity.Property(e => e.Sytext)
                .HasMaxLength(140)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SYTEXT");
            entity.Property(e => e.Syuser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("SYUSER");
            entity.Property(e => e.Sywho).HasColumnName("SYWHO");
            entity.Property(e => e.Syyear)
                .HasDefaultValueSql("(datepart(year,getdate()))")
                .HasColumnName("SYYEAR");
        });

        modelBuilder.Entity<Tagroup>(entity =>
        {
            entity.HasKey(e => e.Taident);

            entity.ToTable("TAGROUP");

            entity.Property(e => e.Taident).HasColumnName("TAIDENT");
            entity.Property(e => e.Tadate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TADATE");
            entity.Property(e => e.Tano).HasColumnName("TANO");
            entity.Property(e => e.Tatitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("TATITLE");
            entity.Property(e => e.Tawho).HasColumnName("TAWHO");
        });

        modelBuilder.Entity<Terminal>(entity =>
        {
            entity.HasKey(e => e.Tmident);

            entity.ToTable("TERMINAL");

            entity.Property(e => e.Tmident).HasColumnName("TMIDENT");
            entity.Property(e => e.Tmauident).HasColumnName("TMAUIDENT");
            entity.Property(e => e.Tmbarcode).HasColumnName("TMBARCODE");
            entity.Property(e => e.Tmbnreader).HasColumnName("TMBNREADER");
            entity.Property(e => e.Tmcollect).HasColumnName("TMCOLLECT");
            entity.Property(e => e.Tmcom)
                .HasDefaultValueSql("('')")
                .HasColumnName("TMCOM");
            entity.Property(e => e.Tmdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
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
            entity.Property(e => e.Tmipaddr4)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("TMIPADDR4");
            entity.Property(e => e.Tmipaddr6)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
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
            entity.Property(e => e.Tmport)
                .HasDefaultValueSql("('')")
                .HasColumnName("TMPORT");
            entity.Property(e => e.Tmprinter).HasColumnName("TMPRINTER");
            entity.Property(e => e.Tmtype).HasColumnName("TMTYPE");
            entity.Property(e => e.Tmwho).HasColumnName("TMWHO");
        });

        modelBuilder.Entity<Termsel>(entity =>
        {
            entity.HasKey(e => e.Teident);

            entity.ToTable("TERMSEL");

            entity.Property(e => e.Teident).HasColumnName("TEIDENT");
            entity.Property(e => e.Teauident).HasColumnName("TEAUIDENT");
            entity.Property(e => e.Teusident).HasColumnName("TEUSIDENT");
        });

        modelBuilder.Entity<Tlabel>(entity =>
        {
            entity.HasKey(e => e.Tlident);

            entity.ToTable("TLABEL");

            entity.Property(e => e.Tlident).HasColumnName("TLIDENT");
            entity.Property(e => e.Tlcolor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TLCOLOR");
            entity.Property(e => e.Tldate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TLDATE");
            entity.Property(e => e.Tlid).HasColumnName("TLID");
            entity.Property(e => e.Tlmemo)
                .IsUnicode(false)
                .HasColumnName("TLMEMO");
            entity.Property(e => e.Tlstype)
                .HasDefaultValue(1)
                .HasColumnName("TLSTYPE");
            entity.Property(e => e.Tltext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TLTEXT");
            entity.Property(e => e.Tlwho).HasColumnName("TLWHO");
        });

        modelBuilder.Entity<Tstatus>(entity =>
        {
            entity.HasKey(e => e.Tsident);

            entity.ToTable("TSTATUS");

            entity.Property(e => e.Tsident).HasColumnName("TSIDENT");
            entity.Property(e => e.Tscolor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TSCOLOR");
            entity.Property(e => e.Tsdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TSDATE");
            entity.Property(e => e.Tsid).HasColumnName("TSID");
            entity.Property(e => e.Tsmemo)
                .IsUnicode(false)
                .HasColumnName("TSMEMO");
            entity.Property(e => e.Tstext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("TSTEXT");
            entity.Property(e => e.Tstype)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TSTYPE");
            entity.Property(e => e.Tswho).HasColumnName("TSWHO");
        });

        modelBuilder.Entity<Uslog>(entity =>
        {
            entity.HasKey(e => e.Usident);

            entity.ToTable("USLOG");

            entity.Property(e => e.Usident).HasColumnName("USIDENT");
            entity.Property(e => e.Usadmin).HasColumnName("USADMIN");
            entity.Property(e => e.Usahident).HasColumnName("USAHIDENT");
            entity.Property(e => e.Usappe)
                .HasDefaultValue(3)
                .HasColumnName("USAPPE");
            entity.Property(e => e.Usappn)
                .HasDefaultValue(4)
                .HasColumnName("USAPPN");
            entity.Property(e => e.Usappointloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USAPPOINTLOC");
            entity.Property(e => e.Usappv)
                .HasDefaultValue(3)
                .HasColumnName("USAPPV");
            entity.Property(e => e.Usbackup)
                .IsUnicode(false)
                .HasDefaultValue("C:\\")
                .HasColumnName("USBACKUP");
            entity.Property(e => e.Usbkcolor).HasColumnName("USBKCOLOR");
            entity.Property(e => e.Uscomplow)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USCOMPLOW");
            entity.Property(e => e.Uscompmid)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USCOMPMID");
            entity.Property(e => e.Uscompupp)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USCOMPUPP");
            entity.Property(e => e.Uscrypt).HasColumnName("USCRYPT");
            entity.Property(e => e.Usctrl1)
                .HasDefaultValue((byte)8)
                .HasColumnName("USCTRL1");
            entity.Property(e => e.Usctrl2).HasColumnName("USCTRL2");
            entity.Property(e => e.Usctrl3).HasColumnName("USCTRL3");
            entity.Property(e => e.Usctrl4).HasColumnName("USCTRL4");
            entity.Property(e => e.Usctrl5).HasColumnName("USCTRL5");
            entity.Property(e => e.Usctrl6).HasColumnName("USCTRL6");
            entity.Property(e => e.Usdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("USDATE");
            entity.Property(e => e.Usdownload)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USDOWNLOAD");
            entity.Property(e => e.Usdtapath)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USDTAPATH");
            entity.Property(e => e.Usftp)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USFTP");
            entity.Property(e => e.Usftppw)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USFTPPW");
            entity.Property(e => e.Usftpuser)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USFTPUSER");
            entity.Property(e => e.Usimport)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USIMPORT");
            entity.Property(e => e.Usinvpath)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USINVPATH");
            entity.Property(e => e.Usinvtype).HasColumnName("USINVTYPE");
            entity.Property(e => e.Uslang).HasColumnName("USLANG");
            entity.Property(e => e.Uslayout).HasColumnName("USLAYOUT");
            entity.Property(e => e.Uslimit)
                .HasDefaultValue(99999)
                .HasColumnName("USLIMIT");
            entity.Property(e => e.Uslines)
                .HasDefaultValue(10000)
                .HasColumnName("USLINES");
            entity.Property(e => e.Usmailbody)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USMAILBODY");
            entity.Property(e => e.Usmailfrom)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USMAILFROM");
            entity.Property(e => e.Usmailftxt)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USMAILFTXT");
            entity.Property(e => e.Usmonth)
                .HasDefaultValue((short)1)
                .HasColumnName("USMONTH");
            entity.Property(e => e.Usname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USNAME");
            entity.Property(e => e.Usout1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USOUT1");
            entity.Property(e => e.Usout2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USOUT2");
            entity.Property(e => e.Usout3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USOUT3");
            entity.Property(e => e.Usoutlook)
                .HasDefaultValue(1)
                .HasColumnName("USOUTLOOK");
            entity.Property(e => e.Usovcolor).HasColumnName("USOVCOLOR");
            entity.Property(e => e.Usovseps).HasColumnName("USOVSEPS");
            entity.Property(e => e.Uspdfpath)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USPDFPATH");
            entity.Property(e => e.Uspw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USPW");
            entity.Property(e => e.Uspwcrypt)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USPWCRYPT");
            entity.Property(e => e.Uspwemail)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USPWEMAIL");
            entity.Property(e => e.Uspwinv)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USPWINV");
            entity.Property(e => e.Usrecurr).HasColumnName("USRECURR");
            entity.Property(e => e.Usrefresh).HasColumnName("USREFRESH");
            entity.Property(e => e.Usrepeat).HasColumnName("USREPEAT");
            entity.Property(e => e.Usrrident).HasColumnName("USRRIDENT");
            entity.Property(e => e.Ussepapath)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSEPAPATH");
            entity.Property(e => e.Usservice).HasColumnName("USSERVICE");
            entity.Property(e => e.Usskin).HasColumnName("USSKIN");
            entity.Property(e => e.Usskinname)
                .IsUnicode(false)
                .HasDefaultValue("METROPOLIS")
                .HasColumnName("USSKINNAME");
            entity.Property(e => e.Usskinnav)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSKINNAV");
            entity.Property(e => e.Ussmsday).HasColumnName("USSMSDAY");
            entity.Property(e => e.Ussmsedate)
                .HasColumnType("datetime")
                .HasColumnName("USSMSEDATE");
            entity.Property(e => e.Ussmsetime).HasColumnName("USSMSETIME");
            entity.Property(e => e.Ussmsetime1).HasColumnName("USSMSETIME1");
            entity.Property(e => e.Ussmssdate)
                .HasColumnType("datetime")
                .HasColumnName("USSMSSDATE");
            entity.Property(e => e.Ussmsstime).HasColumnName("USSMSSTIME");
            entity.Property(e => e.Ussmsstime1).HasColumnName("USSMSSTIME1");
            entity.Property(e => e.Ussmstel)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSMSTEL");
            entity.Property(e => e.Ussmtp)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSMTP");
            entity.Property(e => e.Ussmtphost)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSMTPHOST");
            entity.Property(e => e.Ussmtpport).HasColumnName("USSMTPPORT");
            entity.Property(e => e.Ussmtpportm).HasColumnName("USSMTPPORTM");
            entity.Property(e => e.Ussmtpssl).HasColumnName("USSMTPSSL");
            entity.Property(e => e.Ussmtpsslm).HasColumnName("USSMTPSSLM");
            entity.Property(e => e.Ussrcaddr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USSRCADDR");
            entity.Property(e => e.Usstart)
                .HasDefaultValue((byte)1)
                .HasColumnName("USSTART");
            entity.Property(e => e.Ustaraddr)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USTARADDR");
            entity.Property(e => e.Ususerinv)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USUSERINV");
            entity.Property(e => e.Ususername)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USUSERNAME");
            entity.Property(e => e.Usvaldate)
                .HasDefaultValueSql("(CONVERT([datetime],'9999-31-12 23:59:59',(0)))")
                .HasColumnType("datetime")
                .HasColumnName("USVALDATE");
            entity.Property(e => e.Usvoucher)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("USVOUCHER");
            entity.Property(e => e.Uswho).HasColumnName("USWHO");
        });

        modelBuilder.Entity<Vat>(entity =>
        {
            entity.HasKey(e => e.Vaident);

            entity.ToTable("VAT");

            entity.Property(e => e.Vaident).HasColumnName("VAIDENT");
            entity.Property(e => e.Vadate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("VADATE");
            entity.Property(e => e.Vamemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VAMEMO");
            entity.Property(e => e.Vanumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VANUMBER");
            entity.Property(e => e.Vatitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VATITLE");
            entity.Property(e => e.Vatype).HasColumnName("VATYPE");
            entity.Property(e => e.Vavat)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("VAVAT");
            entity.Property(e => e.Vavatchg)
                .HasColumnType("numeric(6, 2)")
                .HasColumnName("VAVATCHG");
            entity.Property(e => e.Vavatdat)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("VAVATDAT");
            entity.Property(e => e.Vawho).HasColumnName("VAWHO");
        });

        modelBuilder.Entity<Vcharac>(entity =>
        {
            entity.HasKey(e => e.Vcident);

            entity.ToTable("VCHARAC");

            entity.HasIndex(e => e.Vcvfident, "INDEX_VCHARAC_VCVFIDENT");

            entity.Property(e => e.Vcident).HasColumnName("VCIDENT");
            entity.Property(e => e.Vcdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("VCDATE");
            entity.Property(e => e.Vcmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VCMEMO");
            entity.Property(e => e.Vcnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VCNUMBER");
            entity.Property(e => e.Vctitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VCTITLE");
            entity.Property(e => e.Vcvfident).HasColumnName("VCVFIDENT");
            entity.Property(e => e.Vcwho).HasColumnName("VCWHO");
        });

        modelBuilder.Entity<Ve10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VE_10");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Addate)
                .HasColumnType("datetime")
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL2");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX2");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME2");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen2).HasColumnName("ADGEN2");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME2");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL3");
            entity.Property(e => e.Adtel4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL4");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE2");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Advatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adxxident).HasColumnName("ADXXIDENT");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Codate)
                .HasColumnType("datetime")
                .HasColumnName("CODATE");
            entity.Property(e => e.Coend)
                .HasColumnType("datetime")
                .HasColumnName("COEND");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Comemo)
                .IsUnicode(false)
                .HasColumnName("COMEMO");
            entity.Property(e => e.Costate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
            entity.Property(e => e.Pbdate)
                .HasColumnType("datetime")
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbmemo)
                .IsUnicode(false)
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
            entity.Property(e => e.Pgdate)
                .HasColumnType("datetime")
                .HasColumnName("PGDATE");
            entity.Property(e => e.Pgident).HasColumnName("PGIDENT");
            entity.Property(e => e.Pgmemo)
                .IsUnicode(false)
                .HasColumnName("PGMEMO");
            entity.Property(e => e.Pgnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PGNUMBER");
            entity.Property(e => e.Pgtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PGTITLE");
            entity.Property(e => e.Pgwho).HasColumnName("PGWHO");
            entity.Property(e => e.Sradident).HasColumnName("SRADIDENT");
            entity.Property(e => e.Srmemo)
                .IsUnicode(false)
                .HasColumnName("SRMEMO");
            entity.Property(e => e.Srnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Usdate)
                .HasColumnType("datetime")
                .HasColumnName("USDATE");
            entity.Property(e => e.Usident).HasColumnName("USIDENT");
            entity.Property(e => e.Usname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USNAME");
            entity.Property(e => e.Uspw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USPW");
            entity.Property(e => e.Uswho).HasColumnName("USWHO");
            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECC");
            entity.Property(e => e.Vecocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECOCODE");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasColumnType("datetime")
                .HasColumnName("VEDATE");
            entity.Property(e => e.Vedivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVABBR");
            entity.Property(e => e.Vedivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVISION");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasColumnType("datetime")
                .HasColumnName("VEEND");
            entity.Property(e => e.Vegroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEGROUP");
            entity.Property(e => e.Vehhoffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Veho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEHO");
            entity.Property(e => e.Vehours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .IsUnicode(false)
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles).HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasColumnType("datetime")
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasColumnType("datetime")
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .IsUnicode(false)
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
            entity.Property(e => e.Vtcyclap).HasColumnName("VTCYCLAP");
            entity.Property(e => e.Vtdate)
                .HasColumnType("datetime")
                .HasColumnName("VTDATE");
            entity.Property(e => e.Vtgvw).HasColumnName("VTGVW");
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
            entity.Property(e => e.Vtmemo)
                .IsUnicode(false)
                .HasColumnName("VTMEMO");
            entity.Property(e => e.Vtmotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTMOTOR");
            entity.Property(e => e.Vtmpower).HasColumnName("VTMPOWER");
            entity.Property(e => e.Vtneg)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasColumnType("decimal(3, 1)")
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
            entity.Property(e => e.Vttwin1).HasColumnName("VTTWIN1");
            entity.Property(e => e.Vttwin2).HasColumnName("VTTWIN2");
            entity.Property(e => e.Vttwin3).HasColumnName("VTTWIN3");
            entity.Property(e => e.Vttwin4).HasColumnName("VTTWIN4");
            entity.Property(e => e.Vttwin5).HasColumnName("VTTWIN5");
            entity.Property(e => e.Vttyresiz1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZ1");
            entity.Property(e => e.Vttyresiz2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZ2");
            entity.Property(e => e.Vttyresiz3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZ3");
            entity.Property(e => e.Vttyresiz4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZ4");
            entity.Property(e => e.Vttyresiz5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZ5");
            entity.Property(e => e.Vttyresize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VTTYRESIZE");
            entity.Property(e => e.Vtunda).HasColumnName("VTUNDA");
            entity.Property(e => e.Vtwho).HasColumnName("VTWHO");
        });

        modelBuilder.Entity<Ve110>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VE1_10");

            entity.Property(e => e.Adacc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC1");
            entity.Property(e => e.Adacc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADACC2");
            entity.Property(e => e.Adbank1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK1");
            entity.Property(e => e.Adbank2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADBANK2");
            entity.Property(e => e.Adctry)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADCTRY");
            entity.Property(e => e.Addate)
                .HasColumnType("datetime")
                .HasColumnName("ADDATE");
            entity.Property(e => e.Ademail1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL1");
            entity.Property(e => e.Ademail2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADEMAIL2");
            entity.Property(e => e.Adfax1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX1");
            entity.Property(e => e.Adfax2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFAX2");
            entity.Property(e => e.Adfname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME1");
            entity.Property(e => e.Adfname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADFNAME2");
            entity.Property(e => e.Adgen1).HasColumnName("ADGEN1");
            entity.Property(e => e.Adgen2).HasColumnName("ADGEN2");
            entity.Property(e => e.Adhp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADHP");
            entity.Property(e => e.Adiban1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN1");
            entity.Property(e => e.Adiban2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ADIBAN2");
            entity.Property(e => e.Adibc1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC1");
            entity.Property(e => e.Adibc2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADIBC2");
            entity.Property(e => e.Adident).HasColumnName("ADIDENT");
            entity.Property(e => e.Adlname1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME1");
            entity.Property(e => e.Adlname2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADLNAME2");
            entity.Property(e => e.Adloc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADLOC");
            entity.Property(e => e.Adpb)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADPB");
            entity.Property(e => e.Adroutno1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO1");
            entity.Property(e => e.Adroutno2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADROUTNO2");
            entity.Property(e => e.Adstr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADSTR");
            entity.Property(e => e.Adtel1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL1");
            entity.Property(e => e.Adtel2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL2");
            entity.Property(e => e.Adtel3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL3");
            entity.Property(e => e.Adtel4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTEL4");
            entity.Property(e => e.Adtitle1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE1");
            entity.Property(e => e.Adtitle2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ADTITLE2");
            entity.Property(e => e.Adtype).HasColumnName("ADTYPE");
            entity.Property(e => e.Advatid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ADVATID");
            entity.Property(e => e.Adwho).HasColumnName("ADWHO");
            entity.Property(e => e.Adxxident).HasColumnName("ADXXIDENT");
            entity.Property(e => e.Adzip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ADZIP");
            entity.Property(e => e.Coadident).HasColumnName("COADIDENT");
            entity.Property(e => e.Cocono1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO1");
            entity.Property(e => e.Cocono2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COCONO2");
            entity.Property(e => e.Codate)
                .HasColumnType("datetime")
                .HasColumnName("CODATE");
            entity.Property(e => e.Coend)
                .HasColumnType("datetime")
                .HasColumnName("COEND");
            entity.Property(e => e.Coident).HasColumnName("COIDENT");
            entity.Property(e => e.Comemo)
                .IsUnicode(false)
                .HasColumnName("COMEMO");
            entity.Property(e => e.Costate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COSTATE");
            entity.Property(e => e.Cotitle1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE1");
            entity.Property(e => e.Cotitle2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE2");
            entity.Property(e => e.Cotitle3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COTITLE3");
            entity.Property(e => e.Cotype).HasColumnName("COTYPE");
            entity.Property(e => e.Cowho).HasColumnName("COWHO");
            entity.Property(e => e.Pbdate)
                .HasColumnType("datetime")
                .HasColumnName("PBDATE");
            entity.Property(e => e.Pbdispl).HasColumnName("PBDISPL");
            entity.Property(e => e.Pbean)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("PBEAN");
            entity.Property(e => e.Pbextern)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("PBEXTERN");
            entity.Property(e => e.Pbident).HasColumnName("PBIDENT");
            entity.Property(e => e.Pbmemo)
                .IsUnicode(false)
                .HasColumnName("PBMEMO");
            entity.Property(e => e.Pbnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PBNUMBER");
            entity.Property(e => e.Pbpgident).HasColumnName("PBPGIDENT");
            entity.Property(e => e.Pbptident).HasColumnName("PBPTIDENT");
            entity.Property(e => e.Pbtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PBTITLE");
            entity.Property(e => e.Pbvaident).HasColumnName("PBVAIDENT");
            entity.Property(e => e.Pbwho).HasColumnName("PBWHO");
            entity.Property(e => e.Pgdate)
                .HasColumnType("datetime")
                .HasColumnName("PGDATE");
            entity.Property(e => e.Pgident).HasColumnName("PGIDENT");
            entity.Property(e => e.Pgmemo)
                .IsUnicode(false)
                .HasColumnName("PGMEMO");
            entity.Property(e => e.Pgnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PGNUMBER");
            entity.Property(e => e.Pgtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PGTITLE");
            entity.Property(e => e.Pgwho).HasColumnName("PGWHO");
            entity.Property(e => e.Sradident).HasColumnName("SRADIDENT");
            entity.Property(e => e.Srmemo)
                .IsUnicode(false)
                .HasColumnName("SRMEMO");
            entity.Property(e => e.Srnumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SRNUMBER");
            entity.Property(e => e.Srtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SRTITLE");
            entity.Property(e => e.Usadmin).HasColumnName("USADMIN");
            entity.Property(e => e.Usdate)
                .HasColumnType("datetime")
                .HasColumnName("USDATE");
            entity.Property(e => e.Usident).HasColumnName("USIDENT");
            entity.Property(e => e.Usname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USNAME");
            entity.Property(e => e.Uspw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("USPW");
            entity.Property(e => e.Usvaldate)
                .HasColumnType("datetime")
                .HasColumnName("USVALDATE");
            entity.Property(e => e.Uswho).HasColumnName("USWHO");
            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECC");
            entity.Property(e => e.Vecocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VECOCODE");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasColumnType("datetime")
                .HasColumnName("VEDATE");
            entity.Property(e => e.Vedivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVABBR");
            entity.Property(e => e.Vedivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEDIVISION");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasColumnType("datetime")
                .HasColumnName("VEEND");
            entity.Property(e => e.Vegroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEGROUP");
            entity.Property(e => e.Vehhoffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Veho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("VEHO");
            entity.Property(e => e.Vehours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .IsUnicode(false)
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles).HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasColumnType("datetime")
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasColumnType("datetime")
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .IsUnicode(false)
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
            entity.Property(e => e.Vtident).HasColumnName("VTIDENT");
            entity.Property(e => e.Vtneg)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTPOS");
            entity.Property(e => e.Vttank).HasColumnName("VTTANK");
        });

        modelBuilder.Entity<Vehicle>(entity =>
        {
            entity.HasKey(e => e.Veident);

            entity.ToTable("VEHICLE");

            entity.HasIndex(e => e.Veintno, "INDEX_VEHICLE_INTNO").HasFilter("([VEINTNO]<>'')");

            entity.HasIndex(e => e.Veplate, "INDEX_VEHICLE_PLATE").HasFilter("([VEPLATE]<>'')");

            entity.HasIndex(e => e.Veplate2, "INDEX_VEHICLE_PLATE2").HasFilter("([VEPLATE2]<>'')");

            entity.HasIndex(e => e.Vecoident, "INDEX_VEHICLE_VECOIDENT");

            entity.HasIndex(e => e.Vewho, "INDEX_VEHICLE_WHO");

            entity.Property(e => e.Veident).HasColumnName("VEIDENT");
            entity.Property(e => e.Vecat).HasColumnName("VECAT");
            entity.Property(e => e.Vecc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VECC");
            entity.Property(e => e.Vecocode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VECOCODE");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Vedate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("VEDATE");
            entity.Property(e => e.Vedivabbr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEDIVABBR");
            entity.Property(e => e.Vedivision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEDIVISION");
            entity.Property(e => e.Veemident).HasColumnName("VEEMIDENT");
            entity.Property(e => e.Veend)
                .HasColumnType("datetime")
                .HasColumnName("VEEND");
            entity.Property(e => e.Vegroup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEGROUP");
            entity.Property(e => e.Vehhoffset)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHOFFSET");
            entity.Property(e => e.Vehhstart)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHHSTART");
            entity.Property(e => e.Veho)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEHO");
            entity.Property(e => e.Vehours)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("VEHOURS");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Vekmoffset).HasColumnName("VEKMOFFSET");
            entity.Property(e => e.Vekmstart).HasColumnName("VEKMSTART");
            entity.Property(e => e.Veleident).HasColumnName("VELEIDENT");
            entity.Property(e => e.Vememo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEMEMO");
            entity.Property(e => e.Vemiles).HasColumnName("VEMILES");
            entity.Property(e => e.Veoffdate)
                .HasColumnType("datetime")
                .HasColumnName("VEOFFDATE");
            entity.Property(e => e.Vepbident).HasColumnName("VEPBIDENT");
            entity.Property(e => e.Vepgident).HasColumnName("VEPGIDENT");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Veplate2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEPLATE2");
            entity.Property(e => e.Vesrident).HasColumnName("VESRIDENT");
            entity.Property(e => e.Vestart)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime")
                .HasColumnName("VESTART");
            entity.Property(e => e.Vestate)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VESTATE");
            entity.Property(e => e.Vestoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VESTOC");
            entity.Property(e => e.Vetype).HasColumnName("VETYPE");
            entity.Property(e => e.Vevehno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VEVEHNO");
            entity.Property(e => e.Vewho).HasColumnName("VEWHO");
        });

        modelBuilder.Entity<VehicleCardAutomat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VehicleCardAutomat");

            entity.Property(e => e.Aunumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AUNUMBER");
            entity.Property(e => e.Autitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUTITLE");
            entity.Property(e => e.Cano)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO");
            entity.Property(e => e.Cano2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CANO2");
            entity.Property(e => e.Caveident).HasColumnName("CAVEIDENT");
            entity.Property(e => e.Vecoident).HasColumnName("VECOIDENT");
            entity.Property(e => e.Veintno)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("VEINTNO");
            entity.Property(e => e.Veplate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("VEPLATE");
            entity.Property(e => e.Vevehno)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("VEVEHNO");
        });

        modelBuilder.Entity<Vfattrib>(entity =>
        {
            entity.HasKey(e => e.Vfident);

            entity.ToTable("VFATTRIB");

            entity.Property(e => e.Vfident).HasColumnName("VFIDENT");
            entity.Property(e => e.Vfdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("VFDATE");
            entity.Property(e => e.Vfmemo)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VFMEMO");
            entity.Property(e => e.Vftitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VFTITLE");
            entity.Property(e => e.Vfwho).HasColumnName("VFWHO");
        });

        modelBuilder.Entity<Vrefatt>(entity =>
        {
            entity.HasKey(e => e.Vrident);

            entity.ToTable("VREFATT");

            entity.Property(e => e.Vrident).HasColumnName("VRIDENT");
            entity.Property(e => e.Vrvcident).HasColumnName("VRVCIDENT");
            entity.Property(e => e.Vrveident).HasColumnName("VRVEIDENT");
        });

        modelBuilder.Entity<Vtech>(entity =>
        {
            entity.HasKey(e => e.Vtident);

            entity.ToTable("VTECH");

            entity.Property(e => e.Vtident)
                .ValueGeneratedNever()
                .HasColumnName("VTIDENT");
            entity.Property(e => e.Vtco2).HasColumnName("VTCO2");
            entity.Property(e => e.Vtcyclap).HasColumnName("VTCYCLAP");
            entity.Property(e => e.Vtdate)
                .HasColumnType("datetime")
                .HasColumnName("VTDATE");
            entity.Property(e => e.Vtdatemaint)
                .HasDefaultValueSql("(CONVERT([datetime],'1989-01-01T00:00:00',0))")
                .HasColumnType("datetime")
                .HasColumnName("VTDATEMAINT");
            entity.Property(e => e.Vtgvw).HasColumnName("VTGVW");
            entity.Property(e => e.Vth2type)
                .HasDefaultValue(2)
                .HasColumnName("VTH2TYPE");
            entity.Property(e => e.Vthold).HasColumnName("VTHOLD");
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
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTMEMO");
            entity.Property(e => e.Vtminp).HasColumnName("VTMINP");
            entity.Property(e => e.Vtmintemp).HasColumnName("VTMINTEMP");
            entity.Property(e => e.Vtmotor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTMOTOR");
            entity.Property(e => e.Vtmpower).HasColumnName("VTMPOWER");
            entity.Property(e => e.Vtneg)
                .HasColumnType("decimal(3, 1)")
                .HasColumnName("VTNEG");
            entity.Property(e => e.Vtnorm)
                .HasColumnType("decimal(4, 1)")
                .HasColumnName("VTNORM");
            entity.Property(e => e.Vtpos)
                .HasColumnType("decimal(3, 1)")
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
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZ1");
            entity.Property(e => e.Vttyresiz2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZ2");
            entity.Property(e => e.Vttyresiz3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZ3");
            entity.Property(e => e.Vttyresiz4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZ4");
            entity.Property(e => e.Vttyresiz5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZ5");
            entity.Property(e => e.Vttyresize)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("VTTYRESIZE");
            entity.Property(e => e.Vtunda).HasColumnName("VTUNDA");
            entity.Property(e => e.Vtwho).HasColumnName("VTWHO");
        });

        modelBuilder.Entity<Wstation>(entity =>
        {
            entity.HasKey(e => e.Wsident);

            entity.ToTable("WSTATION");

            entity.Property(e => e.Wsident).HasColumnName("WSIDENT");
            entity.Property(e => e.Wsdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("WSDATE");
            entity.Property(e => e.Wswho).HasColumnName("WSWHO");
            entity.Property(e => e.Wsws)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("WSWS");
        });

        modelBuilder.Entity<Zvt>(entity =>
        {
            entity.HasKey(e => e.Zvident);

            entity.ToTable("ZVT");

            entity.Property(e => e.Zvident).HasColumnName("ZVIDENT");
            entity.Property(e => e.Zvdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ZVDATE");
            entity.Property(e => e.Zvshow).HasColumnName("ZVSHOW");
            entity.Property(e => e.Zvtitle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("")
                .HasColumnName("ZVTITLE");
            entity.Property(e => e.Zvtype).HasColumnName("ZVTYPE");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
