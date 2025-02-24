using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.Rates;

#nullable disable

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class RatesDbContext : DbContext
    {
        public RatesDbContext()
        {
        }

        public RatesDbContext(DbContextOptions<RatesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BloombergRate> BloombergRates { get; set; }
        public virtual DbSet<BloombergRateFile> BloombergRateFiles { get; set; }
        public virtual DbSet<BloombergRateLastSnapFile> BloombergRateLastSnapFiles { get; set; }
        public virtual DbSet<BloombergReasonCode> BloombergReasonCodes { get; set; }
        public virtual DbSet<BloombergReturnCode> BloombergReturnCodes { get; set; }
        public virtual DbSet<BloombergToAxiomRate> BloombergToAxiomRates { get; set; }
        public virtual DbSet<BloombergToMurexMappingRule> BloombergToMurexMappingRules { get; set; }
        public virtual DbSet<BloombergToMurexMappingRuleFile> BloombergToMurexMappingRuleFiles { get; set; }
        public virtual DbSet<BloombergToMurexRate> BloombergToMurexRates { get; set; }
        public virtual DbSet<BloombergToMurexRateError> BloombergToMurexRateErrors { get; set; }
        public virtual DbSet<DatascopeColumnSelectorByRicsRtsh> DatascopeColumnSelectorByRicsRtshes { get; set; }
        public virtual DbSet<DatascopeFileRetrievalLog> DatascopeFileRetrievalLogs { get; set; }
        public virtual DbSet<FxsmDataScopeMurexMapping> FxsmDataScopeMurexMappings { get; set; }
        public virtual DbSet<FxspDataScopeMurexMapping> FxspDataScopeMurexMappings { get; set; }
        public virtual DbSet<FxswDataScopeMurexMapping> FxswDataScopeMurexMappings { get; set; }
        public virtual DbSet<FxvlDataScopeMurexMapping> FxvlDataScopeMurexMappings { get; set; }
        public virtual DbSet<InstrumentGroup> InstrumentGroups { get; set; }
        public virtual DbSet<InstrumentGroupAm> InstrumentGroupAms { get; set; }
        public virtual DbSet<MurexRateType> MurexRateTypes { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<PrimeRevenueRate> PrimeRevenueRates { get; set; }
        public virtual DbSet<ReutersDataScope> ReutersDataScopes { get; set; }
        public virtual DbSet<ReutersDataScopeArchive> ReutersDataScopeArchives { get; set; }
        public virtual DbSet<ReutersDataScopeT> ReutersDataScopeTs { get; set; }
        public virtual DbSet<RtcsDataScopeMurexMapping> RtcsDataScopeMurexMappings { get; set; }
        public virtual DbSet<RtcvDataScopeMurexMapping> RtcvDataScopeMurexMappings { get; set; }
        public virtual DbSet<RtshDataScopeMurexMapping> RtshDataScopeMurexMappings { get; set; }
        public virtual DbSet<RtssDataScopeMurexMapping> RtssDataScopeMurexMappings { get; set; }
        public virtual DbSet<ScprDataScopeMurexMapping> ScprDataScopeMurexMappings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //To protect potentially sensitive information in your connection string,
                //you should move it out of source code.
                //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration
                //- see https://go.microsoft.com/fwlink/?linkid=2131148.
                //For more guidance on storing connection strings,
                //see http://go.microsoft.com/fwlink/?LinkId=723263.


                //optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=Rates;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<BloombergRate>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.BloombergRateFile)
                    .WithMany(p => p.BloombergRates)
                    .HasForeignKey(d => d.BloombergRateFileId)
                    .HasConstraintName("FK_BloombergRate_BloombergRateFile");
            });

            modelBuilder.Entity<BloombergRateFile>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BloombergRateLastSnapFile>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BloombergReasonCode>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BloombergReturnCode>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BloombergToMurexMappingRule>(entity =>
            {
                entity.Property(e => e.AskPref1Constant).IsUnicode(false);

                entity.Property(e => e.AskPref1ConstantOprator).IsUnicode(false);

                entity.Property(e => e.AskPref1Field1).IsUnicode(false);

                entity.Property(e => e.AskPref1Field2).IsUnicode(false);

                entity.Property(e => e.AskPref1FieldOperator).IsUnicode(false);

                entity.Property(e => e.AskPref2Constant).IsUnicode(false);

                entity.Property(e => e.AskPref2ConstantOprator).IsUnicode(false);

                entity.Property(e => e.AskPref2Field1).IsUnicode(false);

                entity.Property(e => e.AskPref2Field2).IsUnicode(false);

                entity.Property(e => e.AskPref2FieldOperator).IsUnicode(false);

                entity.Property(e => e.BidPref1Constant).IsUnicode(false);

                entity.Property(e => e.BidPref1ConstantOprator).IsUnicode(false);

                entity.Property(e => e.BidPref1Field1).IsUnicode(false);

                entity.Property(e => e.BidPref1Field2).IsUnicode(false);

                entity.Property(e => e.BidPref1FieldOperator).IsUnicode(false);

                entity.Property(e => e.BidPref2Constant).IsUnicode(false);

                entity.Property(e => e.BidPref2ConstantOprator).IsUnicode(false);

                entity.Property(e => e.BidPref2Field1).IsUnicode(false);

                entity.Property(e => e.BidPref2Field2).IsUnicode(false);

                entity.Property(e => e.BidPref2FieldOperator).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Lable1).IsUnicode(false);

                entity.Property(e => e.Lable2).IsUnicode(false);

                entity.Property(e => e.Lable3).IsUnicode(false);

                entity.Property(e => e.Lable4).IsUnicode(false);

                entity.Property(e => e.Lable5).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRatesCode).IsUnicode(false);

                entity.Property(e => e.Ticker).IsUnicode(false);

                entity.HasOne(d => d.BloombergToMurexMappingRuleFile)
                    .WithMany(p => p.BloombergToMurexMappingRules)
                    .HasForeignKey(d => d.BloombergToMurexMappingRuleFileId)
                    .HasConstraintName("FK_BloombergToMurexMappingRule_BloombergToMurexMappingRuleFile");
            });

            modelBuilder.Entity<BloombergToMurexMappingRuleFile>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BloombergToMurexRate>(entity =>
            {
                entity.Property(e => e.AskPref1).IsUnicode(false);

                entity.Property(e => e.AskPref2).IsUnicode(false);

                entity.Property(e => e.BidPref1).IsUnicode(false);

                entity.Property(e => e.BidPref2).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Index).IsUnicode(false);

                entity.Property(e => e.IsCompletedNotified).HasDefaultValueSql("((0))");

                entity.Property(e => e.Lable).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRatesCode).IsUnicode(false);

                entity.Property(e => e.Pillar).IsUnicode(false);

                entity.Property(e => e.SwapTemplate).IsUnicode(false);

                entity.Property(e => e.SwapTenor).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.HasOne(d => d.BloombergRate)
                    .WithMany(p => p.BloombergToMurexRates)
                    .HasForeignKey(d => d.BloombergRateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BloombergToMurexRate_BloombergRate");

                entity.HasOne(d => d.BloombergToMurexMappingRule)
                    .WithMany(p => p.BloombergToMurexRates)
                    .HasForeignKey(d => d.BloombergToMurexMappingRuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BloombergToMurexRate_BloombergToMurexMappingRule");
            });

            modelBuilder.Entity<BloombergToMurexRateError>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.BloombergReasonCode)
                    .WithMany(p => p.BloombergToMurexRateErrors)
                    .HasForeignKey(d => d.BloombergReasonCodeId)
                    .HasConstraintName("FK_BloombergToMurexRateError_BloombergReasonCode");

                entity.HasOne(d => d.BloombergReturnCode)
                    .WithMany(p => p.BloombergToMurexRateErrors)
                    .HasForeignKey(d => d.BloombergReturnCodeId)
                    .HasConstraintName("FK_BloombergToMurexRateError_BloombergReturnCode");

                entity.HasOne(d => d.BloombergToMurexRate)
                    .WithMany(p => p.BloombergToMurexRateErrors)
                    .HasForeignKey(d => d.BloombergToMurexRateId)
                    .HasConstraintName("FK_BloombergToMurexRateError_BloombergToMurexRate");
            });

            modelBuilder.Entity<DatascopeColumnSelectorByRicsRtsh>(entity =>
            {
                entity.Property(e => e.AskPriceFrom).IsUnicode(false);

                entity.Property(e => e.BidPriceFrom).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);
            });

            modelBuilder.Entity<FxsmDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);
            });

            modelBuilder.Entity<FxspDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);
            });

            modelBuilder.Entity<FxswDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.CurveLable).IsUnicode(false);

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<FxvlDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);
            });

            modelBuilder.Entity<MurexRateType>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);
            });

            modelBuilder.Entity<NetWrixAuditError>(entity =>
            {
                entity.HasKey(e => e.ErrorId)
                    .HasName("PK_NetWrix_ErrorID")
                    .IsClustered(false);

                entity.HasIndex(e => e.ErrorTime, "NetWrixErrorTimeClustered")
                    .IsClustered();

                entity.Property(e => e.ErrorId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Application).HasDefaultValueSql("(app_name())");

                entity.Property(e => e.DataBaseName).HasDefaultValueSql("(db_name())");

                entity.Property(e => e.ErrorTime).HasDefaultValueSql("(getutcdate())");

                entity.Property(e => e.Workstation).HasDefaultValueSql("(host_name())");
            });

            modelBuilder.Entity<PrimeRevenueRate>(entity =>
            {
                entity.Property(e => e.PrimeRevenueRateId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReutersDataScope>(entity =>
            {
                entity.HasKey(e => new { e.Ric, e.TimeStamp, e.AmPm });

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AmPm).HasDefaultValueSql("(N'PM')");

                entity.Property(e => e.DataScopeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReutersDataScopeArchive>(entity =>
            {
                entity.HasKey(e => new { e.Ric, e.TimeStamp, e.AmPm });

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AmPm).HasDefaultValueSql("(N'PM')");

                entity.Property(e => e.DataScopeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ReutersDataScopeT>(entity =>
            {
                entity.HasKey(e => new { e.Ric, e.TimeStamp, e.AmPm });

                entity.Property(e => e.TimeStamp).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AmPm).HasDefaultValueSql("(N'PM')");

                entity.Property(e => e.DataScopeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RtcsDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Index).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Pillar).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<RtcvDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Index).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);
            });

            modelBuilder.Entity<RtshDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<RtssDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.SwapTemplate).IsUnicode(false);

                entity.Property(e => e.SwapTenor).IsUnicode(false);
            });

            modelBuilder.Entity<ScprDataScopeMurexMapping>(entity =>
            {
                entity.Property(e => e.Lable).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexRateCode).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
