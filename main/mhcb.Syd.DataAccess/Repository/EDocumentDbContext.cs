using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.EDocument;

#nullable disable

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class EDocumentDbContext : DbContext
    {
        public EDocumentDbContext()
        {
        }

        public EDocumentDbContext(DbContextOptions<EDocumentDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdvanceNoticeDepositsConfirmationPaymentInfo> AdvanceNoticeDepositsConfirmationPaymentInfos { get; set; }
        public virtual DbSet<CurrentSavingsStatement> CurrentSavingsStatements { get; set; }
        public virtual DbSet<ForeignExchangeConfirmation> ForeignExchangeConfirmations { get; set; }
        public virtual DbSet<ForeignExchangeStatement> ForeignExchangeStatements { get; set; }
        public virtual DbSet<GBaseDocument> GBaseDocuments { get; set; }
        public virtual DbSet<MoneyMarketConfirmation> MoneyMarketConfirmations { get; set; }
        public virtual DbSet<MoneyMarketStatement> MoneyMarketStatements { get; set; }
        public virtual DbSet<Mwdp6103statement> Mwdp6103statements { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<Statement> Statements { get; set; }

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


                //optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=eDocument;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AdvanceNoticeDepositsConfirmationPaymentInfo>(entity =>
            {
                entity.Property(e => e.Ccyabbr).IsUnicode(false);

                entity.Property(e => e.CustomerPayTo).IsUnicode(false);

                entity.Property(e => e.MhcbpayTo).IsUnicode(false);
            });

            modelBuilder.Entity<CurrentSavingsStatement>(entity =>
            {
                entity.Property(e => e.Balance).IsUnicode(false);

                entity.Property(e => e.Credit).IsUnicode(false);

                entity.Property(e => e.Date).IsUnicode(false);

                entity.Property(e => e.Debit).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ValueDate).IsUnicode(false);

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.CurrentSavingsStatements)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CurrentSavingsDepositStatements_Statements");
            });

            modelBuilder.Entity<ForeignExchangeConfirmation>(entity =>
            {
                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.CompanyAddress).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.ContractDate).IsUnicode(false);

                entity.Property(e => e.OperationDate).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);

                entity.Property(e => e.OurDueDate).IsFixedLength(true);

                entity.Property(e => e.OurPurchaseAmount).IsUnicode(false);

                entity.Property(e => e.OurPurchaseRate).IsUnicode(false);

                entity.Property(e => e.OurSaleAmount).IsUnicode(false);

                entity.Property(e => e.OurSaleDeliveryDate).IsFixedLength(true);

                entity.Property(e => e.ReferenceNumber).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.TransactionNumber).IsUnicode(false);

                entity.HasOne(d => d.GBaseDocument)
                    .WithMany(p => p.ForeignExchangeConfirmations)
                    .HasForeignKey(d => d.GBaseDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForeignExchangeConfirmations_gBaseDocuments");
            });

            modelBuilder.Entity<ForeignExchangeStatement>(entity =>
            {
                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.DealDate).IsUnicode(false);

                entity.Property(e => e.EquivalentAmount).IsUnicode(false);

                entity.Property(e => e.EquivalentAmountCurrency).IsUnicode(false);

                entity.Property(e => e.OurPrice).IsUnicode(false);

                entity.Property(e => e.OurSale).IsUnicode(false);

                entity.Property(e => e.Rate).IsUnicode(false);

                entity.Property(e => e.ReferenceNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ValueDate).IsUnicode(false);

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.ForeignExchangeStatements)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ForeignExchangeStatement_Statements");
            });

            modelBuilder.Entity<GBaseDocument>(entity =>
            {
                entity.Property(e => e.DateProcessed).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MoneyMarketConfirmation>(entity =>
            {
                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.ClosingBalance).IsUnicode(false);

                entity.Property(e => e.CompanyAddress).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.ContractDate).IsUnicode(false);

                entity.Property(e => e.Days).IsUnicode(false);

                entity.Property(e => e.DueDate).IsUnicode(false);

                entity.Property(e => e.IncreaseDecrease).IsUnicode(false);

                entity.Property(e => e.MurexEvent).IsUnicode(false);

                entity.Property(e => e.MurexGenerator).IsUnicode(false);

                entity.Property(e => e.OldRate).IsUnicode(false);

                entity.Property(e => e.OperationDate).IsUnicode(false);

                entity.Property(e => e.Operator).IsUnicode(false);

                entity.Property(e => e.PrincipalAmount).IsUnicode(false);

                entity.Property(e => e.Rate).IsUnicode(false);

                entity.Property(e => e.ReferenceNumber).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.TransactionNumber).IsUnicode(false);

                entity.Property(e => e.ValueDate).IsUnicode(false);

                entity.HasOne(d => d.GBaseDocument)
                    .WithMany(p => p.MoneyMarketConfirmations)
                    .HasForeignKey(d => d.GBaseDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MoneyMarketConfirmations_gBaseDocuments");
            });

            modelBuilder.Entity<MoneyMarketStatement>(entity =>
            {
                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.Comments).IsUnicode(false);

                entity.Property(e => e.Date).IsUnicode(false);

                entity.Property(e => e.Days).IsUnicode(false);

                entity.Property(e => e.DealNo).IsUnicode(false);

                entity.Property(e => e.DebitCredit)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Interest).IsUnicode(false);

                entity.Property(e => e.Principal).IsUnicode(false);

                entity.Property(e => e.Rate).IsUnicode(false);

                entity.Property(e => e.Term).IsUnicode(false);

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.MoneyMarketStatements)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CallLoanAndDepositStatements_Statements");
            });

            modelBuilder.Entity<Mwdp6103statement>(entity =>
            {
                entity.Property(e => e.Balance).IsUnicode(false);

                entity.Property(e => e.Date).IsUnicode(false);

                entity.Property(e => e.IntRate).IsUnicode(false);

                entity.Property(e => e.Interest).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ValueDate).IsUnicode(false);

                entity.HasOne(d => d.Statement)
                    .WithMany(p => p.Mwdp6103statements)
                    .HasForeignKey(d => d.StatementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MWDP6103_Statements");
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

            modelBuilder.Entity<Statement>(entity =>
            {
                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.AccountType).IsUnicode(false);

                entity.Property(e => e.CompanyAddress).IsUnicode(false);

                entity.Property(e => e.CompanyName).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.Period).IsUnicode(false);

                entity.HasOne(d => d.GBaseDocument)
                    .WithMany(p => p.Statements)
                    .HasForeignKey(d => d.GBaseDocumentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Statements_gBaseDocuments");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
