using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.LOAN;

#nullable disable

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class LOANDbContext : DbContext
    {
        public LOANDbContext()
        {
        }

        public LOANDbContext(DbContextOptions<LOANDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCode> AccountCodes { get; set; }
        public virtual DbSet<AccountNo1> AccountNo1s { get; set; }
        public virtual DbSet<AccountNo2> AccountNo2s { get; set; }
        public virtual DbSet<AccountOfficer> AccountOfficers { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<BaseRate> BaseRates { get; set; }
        public virtual DbSet<CdmChecklist> CdmChecklists { get; set; }
        public virtual DbSet<CdmChecklistGroup> CdmChecklistGroups { get; set; }
        public virtual DbSet<CovenantCondition> CovenantConditions { get; set; }
        public virtual DbSet<CovenantConditionGroup> CovenantConditionGroups { get; set; }
        public virtual DbSet<CovenantFreqType> CovenantFreqTypes { get; set; }
        public virtual DbSet<CovenantMaster> CovenantMasters { get; set; }
        public virtual DbSet<CovenantPermission> CovenantPermissions { get; set; }
        public virtual DbSet<CovenantReceiptTiming> CovenantReceiptTimings { get; set; }
        public virtual DbSet<CovenantRecord> CovenantRecords { get; set; }
        public virtual DbSet<CovenantStressMonitorLimit> CovenantStressMonitorLimits { get; set; }
        public virtual DbSet<CovenantType> CovenantTypes { get; set; }
        public virtual DbSet<CustMasterBak20090423> CustMasterBak20090423s { get; set; }
        public virtual DbSet<CustomerAccountCode> CustomerAccountCodes { get; set; }
        public virtual DbSet<DeptPermission> DeptPermissions { get; set; }
        public virtual DbSet<ExchOperator> ExchOperators { get; set; }
        public virtual DbSet<ExchRate> ExchRates { get; set; }
        public virtual DbSet<FacilityMaster> FacilityMasters { get; set; }
        public virtual DbSet<FeeCalcMethod> FeeCalcMethods { get; set; }
        public virtual DbSet<FeeDayOfMonthType> FeeDayOfMonthTypes { get; set; }
        public virtual DbSet<FeeFreqRefType> FeeFreqRefTypes { get; set; }
        public virtual DbSet<FeeFreqType> FeeFreqTypes { get; set; }
        public virtual DbSet<FeeKind> FeeKinds { get; set; }
        public virtual DbSet<FeePayment> FeePayments { get; set; }
        public virtual DbSet<FeeRateLimitChangeLog> FeeRateLimitChangeLogs { get; set; }
        public virtual DbSet<FeeType> FeeTypes { get; set; }
        public virtual DbSet<Fxfccy> Fxfccies { get; set; }
        public virtual DbSet<GuaranteeFeeType> GuaranteeFeeTypes { get; set; }
        public virtual DbSet<IntCalcType> IntCalcTypes { get; set; }
        public virtual DbSet<LcsCustMaster> LcsCustMasters { get; set; }
        public virtual DbSet<LoanMaster> LoanMasters { get; set; }
        public virtual DbSet<LoanMasterAccountOfficer> LoanMasterAccountOfficers { get; set; }
        public virtual DbSet<LoanMasterBorrower> LoanMasterBorrowers { get; set; }
        public virtual DbSet<LoanMasterCovenant> LoanMasterCovenants { get; set; }
        public virtual DbSet<LoanMasterPermission> LoanMasterPermissions { get; set; }
        public virtual DbSet<LoanMasterRating> LoanMasterRatings { get; set; }
        public virtual DbSet<LoanMasterSecurity> LoanMasterSecurities { get; set; }
        public virtual DbSet<LoanMasterStatusCode> LoanMasterStatusCodes { get; set; }
        public virtual DbSet<LoanTran> LoanTrans { get; set; }
        public virtual DbSet<MarginBase> MarginBases { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<ProdType> ProdTypes { get; set; }
        public virtual DbSet<Rating1> Rating1s { get; set; }
        public virtual DbSet<Rating2> Rating2s { get; set; }
        public virtual DbSet<RatingCode> RatingCodes { get; set; }
        public virtual DbSet<RepayType> RepayTypes { get; set; }
        public virtual DbSet<StatusCode> StatusCodes { get; set; }
        public virtual DbSet<SwiftInf> SwiftInfs { get; set; }
        public virtual DbSet<TrancheContent> TrancheContents { get; set; }
        public virtual DbSet<TrancheGuarantee> TrancheGuarantees { get; set; }
        public virtual DbSet<TrancheMargin> TrancheMargins { get; set; }
        public virtual DbSet<TrancheMaster> TrancheMasters { get; set; }
        public virtual DbSet<TrancheType> TrancheTypes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<VEuccustomer> VEuccustomers { get; set; }
        public virtual DbSet<VEucfacility> VEucfacilities { get; set; }
        public virtual DbSet<VFacilityCurrentOutstandingDetail> VFacilityCurrentOutstandingDetails { get; set; }
        public virtual DbSet<VGuideCustomerMaster> VGuideCustomerMasters { get; set; }
        public virtual DbSet<VGuideEucCountryCode> VGuideEucCountryCodes { get; set; }
        public virtual DbSet<VGuideEucDeptCode> VGuideEucDeptCodes { get; set; }
        public virtual DbSet<VLoanForwardRepayment> VLoanForwardRepayments { get; set; }
        public virtual DbSet<VLoanPostRepayment> VLoanPostRepayments { get; set; }
        public virtual DbSet<VLoanRepayment> VLoanRepayments { get; set; }
        public virtual DbSet<VLoanRolloverEquiv> VLoanRolloverEquivs { get; set; }
        public virtual DbSet<VLoanRolloverRepayment> VLoanRolloverRepayments { get; set; }
        public virtual DbSet<VLoanTransLive> VLoanTransLives { get; set; }
        public virtual DbSet<VLoanTransSearchV3> VLoanTransSearchV3s { get; set; }
        public virtual DbSet<VRsDetOutstandingBalAndAccruedInt> VRsDetOutstandingBalAndAccruedInts { get; set; }
        public virtual DbSet<ViewEucCustomer2> ViewEucCustomer2s { get; set; }
        public virtual DbSet<ViewEucFacility2> ViewEucFacility2s { get; set; }
        public virtual DbSet<ViewEucFeeAndCharge2> ViewEucFeeAndCharge2s { get; set; }
        public virtual DbSet<ViewEucLoantrans2> ViewEucLoantrans2s { get; set; }
        public virtual DbSet<ViewEucOustandingBalAndAccruedInt> ViewEucOustandingBalAndAccruedInts { get; set; }
        public virtual DbSet<ViewEucOutstandingBalAndAccruedIntDet> ViewEucOutstandingBalAndAccruedIntDets { get; set; }
        public virtual DbSet<ViewEucOutstandingBalAndAccruedIntSum> ViewEucOutstandingBalAndAccruedIntSums { get; set; }
        public virtual DbSet<ViewLoanCovenantMaster> ViewLoanCovenantMasters { get; set; }
        public virtual DbSet<ViewLoanCovenantRecord> ViewLoanCovenantRecords { get; set; }
        public virtual DbSet<ViewLoanCustomerLoanTrancheFacility> ViewLoanCustomerLoanTrancheFacilities { get; set; }

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


                //optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=LOAN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AccountOfficer>(entity =>
            {
                entity.Property(e => e.AccountOfficer1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.Property(e => e.AuditDesc).IsUnicode(false);

                entity.Property(e => e.AuditTime).IsUnicode(false);

                entity.Property(e => e.FieldName).IsUnicode(false);

                entity.Property(e => e.ModuleName).IsUnicode(false);

                entity.Property(e => e.NewValue).IsUnicode(false);

                entity.Property(e => e.OriginalValue).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.TransNo).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BaseRate>(entity =>
            {
                entity.Property(e => e.RateType).IsUnicode(false);

                entity.Property(e => e.RateDesc).IsUnicode(false);
            });

            modelBuilder.Entity<CdmChecklist>(entity =>
            {
                entity.Property(e => e.AgreementSigningDate).IsUnicode(false);

                entity.Property(e => e.AgreementSigningDate2).IsUnicode(false);

                entity.Property(e => e.AmendmentDate).IsUnicode(false);

                entity.Property(e => e.AnalystName).IsUnicode(false);

                entity.Property(e => e.AppliDate).IsUnicode(false);

                entity.Property(e => e.AppliNo).IsUnicode(false);

                entity.Property(e => e.AppliType).IsUnicode(false);

                entity.Property(e => e.BookOfficeCd).IsUnicode(false);

                entity.Property(e => e.CifNo).IsUnicode(false);

                entity.Property(e => e.CommitCommencementDate).IsUnicode(false);

                entity.Property(e => e.Commitment).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DateImported).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ElLimit)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ElMasterNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ElProtectionDetail1).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail10).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail2).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail3).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail4).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail5).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail6).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail7).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail8).IsUnicode(false);

                entity.Property(e => e.ElProtectionDetail9).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate1).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate10).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate2).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate3).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate4).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate5).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate6).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate7).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate8).IsUnicode(false);

                entity.Property(e => e.ElProtectionDuedate9).IsUnicode(false);

                entity.Property(e => e.ElProtectionType1).IsUnicode(false);

                entity.Property(e => e.ElProtectionType10).IsUnicode(false);

                entity.Property(e => e.ElProtectionType2).IsUnicode(false);

                entity.Property(e => e.ElProtectionType3).IsUnicode(false);

                entity.Property(e => e.ElProtectionType4).IsUnicode(false);

                entity.Property(e => e.ElProtectionType5).IsUnicode(false);

                entity.Property(e => e.ElProtectionType6).IsUnicode(false);

                entity.Property(e => e.ElProtectionType7).IsUnicode(false);

                entity.Property(e => e.ElProtectionType8).IsUnicode(false);

                entity.Property(e => e.ElProtectionType9).IsUnicode(false);

                entity.Property(e => e.ElTrancheNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FileId).IsUnicode(false);

                entity.Property(e => e.FinalCcySwift).IsUnicode(false);

                entity.Property(e => e.GbFinalTakeAmt)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GbaseRef)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MaxDrawn1).IsUnicode(false);

                entity.Property(e => e.MaxDrawn2).IsUnicode(false);

                entity.Property(e => e.MaxDrawn3).IsUnicode(false);

                entity.Property(e => e.Multi).IsUnicode(false);

                entity.Property(e => e.MultiCcyDetails).IsUnicode(false);

                entity.Property(e => e.MultiName1).IsUnicode(false);

                entity.Property(e => e.MultiName10).IsUnicode(false);

                entity.Property(e => e.MultiName11).IsUnicode(false);

                entity.Property(e => e.MultiName12).IsUnicode(false);

                entity.Property(e => e.MultiName13).IsUnicode(false);

                entity.Property(e => e.MultiName14).IsUnicode(false);

                entity.Property(e => e.MultiName15).IsUnicode(false);

                entity.Property(e => e.MultiName16).IsUnicode(false);

                entity.Property(e => e.MultiName17).IsUnicode(false);

                entity.Property(e => e.MultiName18).IsUnicode(false);

                entity.Property(e => e.MultiName19).IsUnicode(false);

                entity.Property(e => e.MultiName2).IsUnicode(false);

                entity.Property(e => e.MultiName20).IsUnicode(false);

                entity.Property(e => e.MultiName3).IsUnicode(false);

                entity.Property(e => e.MultiName4).IsUnicode(false);

                entity.Property(e => e.MultiName5).IsUnicode(false);

                entity.Property(e => e.MultiName6).IsUnicode(false);

                entity.Property(e => e.MultiName7).IsUnicode(false);

                entity.Property(e => e.MultiName8).IsUnicode(false);

                entity.Property(e => e.MultiName9).IsUnicode(false);

                entity.Property(e => e.NewAmendFlag)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('New Application')");

                entity.Property(e => e.ObligorName).IsUnicode(false);

                entity.Property(e => e.ObligorRatingNm).IsUnicode(false);

                entity.Property(e => e.RelatedAppliDate).IsUnicode(false);

                entity.Property(e => e.RelatedAppliNo).IsUnicode(false);

                entity.Property(e => e.RmName).IsUnicode(false);

                entity.Property(e => e.Spread).IsUnicode(false);

                entity.Property(e => e.Syndication)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TermEndDate).IsUnicode(false);

                entity.Property(e => e.TypeOfTransaction).IsUnicode(false);
            });

            modelBuilder.Entity<CovenantCondition>(entity =>
            {
                entity.Property(e => e.ConditionType).ValueGeneratedOnAdd();

                entity.Property(e => e.ConditionDesc).IsUnicode(false);

                entity.HasOne(d => d.ConditionGroupNavigation)
                    .WithMany(p => p.CovenantConditions)
                    .HasForeignKey(d => d.ConditionGroup)
                    .HasConstraintName("FK_COVENANT_CONDITION_COVENANT_CONDITION_GROUP");
            });

            modelBuilder.Entity<CovenantConditionGroup>(entity =>
            {
                entity.Property(e => e.ConditionGroupDesc).IsUnicode(false);
            });

            modelBuilder.Entity<CovenantFreqType>(entity =>
            {
                entity.Property(e => e.DatePart).IsUnicode(false);

                entity.Property(e => e.FreqDesc).IsUnicode(false);
            });

            modelBuilder.Entity<CovenantMaster>(entity =>
            {
                entity.Property(e => e.AccountOfficer)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.CovType).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.Denomination).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MathSymbol).IsUnicode(false);

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.ConditionTypeNavigation)
                    .WithMany(p => p.CovenantMasters)
                    .HasForeignKey(d => d.ConditionType)
                    .HasConstraintName("FK_COVENANT_MASTER_COVENANT_CONDITION");
            });

            modelBuilder.Entity<CovenantPermission>(entity =>
            {
                entity.HasKey(e => new { e.DeptId, e.DepartmentCode });

                entity.Property(e => e.DepartmentCode).IsUnicode(false);
            });

            modelBuilder.Entity<CovenantReceiptTiming>(entity =>
            {
                entity.Property(e => e.DatePart).IsUnicode(false);

                entity.Property(e => e.TimingDesc)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<CovenantRecord>(entity =>
            {
                entity.HasKey(e => new { e.CovenantNo, e.RecordNo });

                entity.Property(e => e.AoRemarks).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Denomination).IsUnicode(false);

                entity.Property(e => e.InCompliance).IsUnicode(false);

                entity.Property(e => e.MathSymbol).IsUnicode(false);

                entity.Property(e => e.OriginalDesc).IsUnicode(false);

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.CovenantNoNavigation)
                    .WithMany(p => p.CovenantRecords)
                    .HasForeignKey(d => d.CovenantNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_COVENANT_RECORD_COVENANT_MASTER");
            });

            modelBuilder.Entity<CovenantStressMonitorLimit>(entity =>
            {
                entity.Property(e => e.LimitType).IsUnicode(false);
            });

            modelBuilder.Entity<CovenantType>(entity =>
            {
                entity.Property(e => e.CovenantType1).IsUnicode(false);

                entity.Property(e => e.CovenantDecs).IsUnicode(false);
            });

            modelBuilder.Entity<CustMasterBak20090423>(entity =>
            {
                entity.HasKey(e => e.CustId)
                    .HasName("PK_CUST_MASTER_1");

                entity.Property(e => e.Address1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.Address2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.Address3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.Address4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.ApprBy).IsUnicode(false);

                entity.Property(e => e.Contact)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.CustType).IsUnicode(false);

                entity.Property(e => e.FaxNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.Positions)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')")
                    .HasComment("");

                entity.Property(e => e.PrepBy).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DeptPermission>(entity =>
            {
                entity.Property(e => e.DeptName).IsUnicode(false);
            });

            modelBuilder.Entity<ExchOperator>(entity =>
            {
                entity.HasKey(e => new { e.Ccy1, e.Ccy2 });

                entity.Property(e => e.Ccy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ccy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Operator)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rules)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ExchRate>(entity =>
            {
                entity.Property(e => e.CcyCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FacilityMaster>(entity =>
            {
                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.ApplnNo).IsUnicode(false);

                entity.Property(e => e.ApplnNo1).IsUnicode(false);

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseRate).IsUnicode(false);

                entity.Property(e => e.BaseRateRemark).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.FeeColDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.FeeEndDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.FeeRemarks).IsUnicode(false);

                entity.Property(e => e.FeeStartDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.GFeeRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.GFeeType).HasDefaultValueSql("(2)");

                entity.Property(e => e.IntCalcRemark).IsUnicode(false);

                entity.Property(e => e.MaxIntPeriod).IsUnicode(false);

                entity.Property(e => e.OtherRemark).IsUnicode(false);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rating1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayRemark).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.DayOfMonthTypeNavigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.DayOfMonthType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACILITY_MASTER_FEE_DAY_OF_MONTH_TYPE");

                entity.HasOne(d => d.FeeCalcMethodTypeNavigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.FeeCalcMethodType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACILITY_MASTER_FEE_CALC_METHOD");

                entity.HasOne(d => d.FeePaymentTypeNavigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.FeePaymentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACILITY_MASTER_FEE_PAYMENT");

                entity.HasOne(d => d.FreqTypeNavigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.FreqType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FACILITY_MASTER_FEE_FREQ_TYPE");

                entity.HasOne(d => d.Rating1Navigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.Rating1)
                    .HasConstraintName("FK_FACILITY_MASTER_RATING1");

                entity.HasOne(d => d.Rating2Navigation)
                    .WithMany(p => p.FacilityMasters)
                    .HasForeignKey(d => d.Rating2)
                    .HasConstraintName("FK_FACILITY_MASTER_RATING2");
            });

            modelBuilder.Entity<FeeCalcMethod>(entity =>
            {
                entity.Property(e => e.FeeCalcMethodDesc).IsUnicode(false);
            });

            modelBuilder.Entity<FeeDayOfMonthType>(entity =>
            {
                entity.HasKey(e => e.DayOfMonthType)
                    .HasName("PK_DAY_OF_MONTH_TYPE");

                entity.Property(e => e.DayOfMonthDesc).IsUnicode(false);
            });

            modelBuilder.Entity<FeeFreqRefType>(entity =>
            {
                entity.HasOne(d => d.FreqTypeNavigation)
                    .WithMany(p => p.FeeFreqRefTypes)
                    .HasForeignKey(d => d.FreqType)
                    .HasConstraintName("FK_FEE_FREQ_REF_TYPE_FEE_FREQ_TYPE");
            });

            modelBuilder.Entity<FeeFreqType>(entity =>
            {
                entity.Property(e => e.FixedDate).HasDefaultValueSql("(0)");

                entity.Property(e => e.FreqDesc).IsUnicode(false);
            });

            modelBuilder.Entity<FeeKind>(entity =>
            {
                entity.Property(e => e.FeeKind1).IsUnicode(false);
            });

            modelBuilder.Entity<FeePayment>(entity =>
            {
                entity.Property(e => e.FeePaymentDesc).IsUnicode(false);
            });

            modelBuilder.Entity<FeeRateLimitChangeLog>(entity =>
            {
                entity.HasKey(e => new { e.RefNo, e.FeeTransNo })
                    .HasName("PK_RATE_LIMIT_CHANGE_LOG");

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.FeeKind)
                    .WithMany(p => p.FeeRateLimitChangeLogs)
                    .HasForeignKey(d => d.FeeKindId)
                    .HasConstraintName("FK_FEE_RATE_LIMIT_CHANGE_LOG_FEE_KIND");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.FeeRateLimitChangeLogs)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FEE_RATE_LIMIT_CHANGE_LOG_FACILITY_MASTER");
            });

            modelBuilder.Entity<FeeType>(entity =>
            {
                entity.Property(e => e.FeeDesc).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfccy>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.Ccydesc).IsUnicode(false);
            });

            modelBuilder.Entity<GuaranteeFeeType>(entity =>
            {
                entity.Property(e => e.GuaranteeFeeDesc).IsUnicode(false);
            });

            modelBuilder.Entity<IntCalcType>(entity =>
            {
                entity.Property(e => e.IntCalcDesc).IsUnicode(false);
            });

            modelBuilder.Entity<LcsCustMaster>(entity =>
            {
                entity.Property(e => e.ApprBy).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Contact).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.PrepBy).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LoanMaster>(entity =>
            {
                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.AmendmentDate).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Ccif)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcifName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contact).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.FaxNo).IsUnicode(false);

                entity.Property(e => e.Gcif)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.RatioSpread1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatioSpread2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TelNo).IsUnicode(false);
            });

            modelBuilder.Entity<LoanMasterAccountOfficer>(entity =>
            {
                entity.Property(e => e.AccountOfficer)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.LoanMasterAccountOfficers)
                    .HasForeignKey(d => d.LoanNo)
                    .HasConstraintName("FK_LOAN_MASTER_ACCOUNT_OFFICER_LOAN_MASTER");
            });

            modelBuilder.Entity<LoanMasterBorrower>(entity =>
            {
                entity.Property(e => e.Ccif)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcifName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.Gcif)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.LoanMasterBorrowers)
                    .HasForeignKey(d => d.LoanNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_MASTER_BORROWER_LOAN_MASTER");
            });

            modelBuilder.Entity<LoanMasterCovenant>(entity =>
            {
                entity.HasOne(d => d.CovenantNoNavigation)
                    .WithMany(p => p.LoanMasterCovenants)
                    .HasForeignKey(d => d.CovenantNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_MASTER_COVENANT_COVENANT_MASTER");

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.LoanMasterCovenants)
                    .HasForeignKey(d => d.LoanNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_MASTER_COVENANT_LOAN_MASTER");
            });

            modelBuilder.Entity<LoanMasterPermission>(entity =>
            {
                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<LoanMasterRating>(entity =>
            {
                entity.Property(e => e.RatingRange)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatingType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.LoanMasterRatings)
                    .HasForeignKey(d => d.LoanNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_MASTER_RATING_LOAN_MASTER");
            });

            modelBuilder.Entity<LoanMasterSecurity>(entity =>
            {
                entity.Property(e => e.CollateralLedger)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N/A')");

                entity.Property(e => e.CollateralSecurityType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unsecured')");

                entity.Property(e => e.Comment)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Details)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorSecurityType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unsecured')");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.LoanMasterSecurities)
                    .HasForeignKey(d => d.LoanNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_MASTER_SECURITY_LOAN_MASTER");
            });

            modelBuilder.Entity<LoanMasterStatusCode>(entity =>
            {
                entity.HasKey(e => new { e.Module, e.StatusCode })
                    .HasName("PK_LOAN_MASTER_STATUS_CODE_1");

                entity.Property(e => e.Module).IsFixedLength(true);

                entity.Property(e => e.StatusCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ShortDesc).IsFixedLength(true);
            });

            modelBuilder.Entity<LoanTran>(entity =>
            {
                entity.HasKey(e => new { e.RefNo, e.TransNo });

                entity.Property(e => e.RefNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppRatesBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BalAmt).HasComment("not in use");

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')")
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.ModifyRatesBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('*')")
                    .IsFixedLength(true);

                entity.Property(e => e.RoNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.HasOne(d => d.AccountCodeNavigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.AccountCode)
                    .HasConstraintName("FK_LOAN_TRANS_ACCOUNT_CODE");

                entity.HasOne(d => d.AccountNo1Navigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.AccountNo1)
                    .HasConstraintName("FK_LOAN_TRANS_ACCOUNT_NO1");

                entity.HasOne(d => d.AccountNo2Navigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.AccountNo2)
                    .HasConstraintName("FK_LOAN_TRANS_ACCOUNT_NO2");

                entity.HasOne(d => d.CustomerAccountCodeNavigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.CustomerAccountCode)
                    .HasConstraintName("FK_LOAN_TRANS_CUSTOMER_ACCOUNT_CODE");

                entity.HasOne(d => d.ProcBy1Navigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.ProcBy1)
                    .HasConstraintName("FK_LOAN_TRANS_USERS");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.LoanTrans)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LOAN_TRANS_FACILITY_MASTER");
            });

            modelBuilder.Entity<MarginBase>(entity =>
            {
                entity.Property(e => e.MarginBaseDesc).IsUnicode(false);
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

            modelBuilder.Entity<ProdType>(entity =>
            {
                entity.Property(e => e.ProdId).ValueGeneratedNever();

                entity.Property(e => e.ProdDesc)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Rating1>(entity =>
            {
                entity.Property(e => e.Rating11)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Rating2>(entity =>
            {
                entity.Property(e => e.Rating21).ValueGeneratedNever();
            });

            modelBuilder.Entity<RatingCode>(entity =>
            {
                entity.Property(e => e.CodeDesc).IsUnicode(false);

                entity.Property(e => e.Rating).IsUnicode(false);
            });

            modelBuilder.Entity<RepayType>(entity =>
            {
                entity.HasKey(e => e.RepayType1)
                    .HasName("PK_REPAYMENT_TYPE");

                entity.Property(e => e.RepayType1).ValueGeneratedNever();

                entity.Property(e => e.RepayDesc).IsUnicode(false);
            });

            modelBuilder.Entity<StatusCode>(entity =>
            {
                entity.Property(e => e.StatusCode1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.StatusDesc).IsUnicode(false);
            });

            modelBuilder.Entity<SwiftInf>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.AccNo).IsUnicode(false);

                entity.Property(e => e.ForAccOf).IsUnicode(false);

                entity.Property(e => e.PayTo).IsUnicode(false);

                entity.Property(e => e.SwiftCode).IsUnicode(false);

                entity.Property(e => e.SwiftNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<TrancheContent>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AUD')");

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.TrancheNoNavigation)
                    .WithMany(p => p.TrancheContents)
                    .HasForeignKey(d => d.TrancheNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANCHE_CONTENT_TRANCHE_MASTER");
            });

            modelBuilder.Entity<TrancheGuarantee>(entity =>
            {
                entity.Property(e => e.Beneficiary)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BgRemark)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Borrower)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AUD')");

                entity.Property(e => e.GbaseGuaranteeNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuaranteeNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MultiBorrowers)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OriginalAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.OutstandingAmount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.TrancheNoNavigation)
                    .WithMany(p => p.TrancheGuarantees)
                    .HasForeignKey(d => d.TrancheNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANCHE_GUARANTEE_TRANCHE_MASTER");
            });

            modelBuilder.Entity<TrancheMargin>(entity =>
            {
                entity.Property(e => e.CommitmentFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.FinancialGntee).HasDefaultValueSql("((0))");

                entity.Property(e => e.LineFee).HasDefaultValueSql("((0))");

                entity.Property(e => e.Other).HasDefaultValueSql("((0))");

                entity.Property(e => e.PerfomanceGntee).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioMargin).HasDefaultValueSql("((0))");

                entity.Property(e => e.RatioRange)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatioType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RefNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remark)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);

                entity.HasOne(d => d.TrancheNoNavigation)
                    .WithMany(p => p.TrancheMargins)
                    .HasForeignKey(d => d.TrancheNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TRANCHE_MARGIN_TRANCHE_MASTER");
            });

            modelBuilder.Entity<TrancheMaster>(entity =>
            {
                entity.Property(e => e.ApplnNo).IsUnicode(false);

                entity.Property(e => e.ApplnNoRelt).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CfdBaseRate)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FinancialName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Margin11am)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MarginRemark11am)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MatDateNotes).IsUnicode(false);

                entity.Property(e => e.MinDd).IsUnicode(false);

                entity.Property(e => e.MultiCcyDesc)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Multiple).IsUnicode(false);

                entity.Property(e => e.PeriodNotes).IsUnicode(false);

                entity.Property(e => e.PortionNotes).IsUnicode(false);

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TrancheName).IsUnicode(false);

                entity.Property(e => e.TrancheType).IsUnicode(false);

                entity.Property(e => e.TrdInternalRate)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.LoanNoNavigation)
                    .WithMany(p => p.TrancheMasters)
                    .HasForeignKey(d => d.LoanNo)
                    .HasConstraintName("FK_TRANCHE_MASTER_LOAN_MASTER");

                entity.HasOne(d => d.TrancheTypeNavigation)
                    .WithMany(p => p.TrancheMasters)
                    .HasForeignKey(d => d.TrancheType)
                    .HasConstraintName("FK_TRANCHE_MASTER_TRANCHE_TYPE");
            });

            modelBuilder.Entity<TrancheType>(entity =>
            {
                entity.Property(e => e.TrancheType1).IsUnicode(false);

                entity.Property(e => e.TrancheTypeDesc).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .IsClustered(false);

                entity.HasIndex(e => e.UserId, "IX_USERS")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.LastApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LastModBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            modelBuilder.Entity<VEuccustomer>(entity =>
            {
                entity.ToView("vEUCCustomer");
            });

            modelBuilder.Entity<VEucfacility>(entity =>
            {
                entity.ToView("vEUCFacility");
            });

            modelBuilder.Entity<VFacilityCurrentOutstandingDetail>(entity =>
            {
                entity.ToView("vFacilityCurrentOutstandingDetails");

                entity.Property(e => e.CcyCode)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);
            });

            modelBuilder.Entity<VGuideCustomerMaster>(entity =>
            {
                entity.ToView("vGUIDE_CUSTOMER_MASTER");

                entity.Property(e => e.Address1).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Ccif).IsUnicode(false);

                entity.Property(e => e.CcifName).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.FaxNo).IsUnicode(false);

                entity.Property(e => e.GuideStatus).IsUnicode(false);

                entity.Property(e => e.JapaneseFlg).IsUnicode(false);

                entity.Property(e => e.Nationality).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.StepsCustCd).IsUnicode(false);

                entity.Property(e => e.TelNo).IsUnicode(false);
            });

            modelBuilder.Entity<VGuideEucCountryCode>(entity =>
            {
                entity.ToView("vGUIDE_EUC_COUNTRY_CODE");

                entity.Property(e => e.AreaCd).IsUnicode(false);

                entity.Property(e => e.BoeAreaCd).IsUnicode(false);

                entity.Property(e => e.BoeCd).IsUnicode(false);

                entity.Property(e => e.CountryCd).IsUnicode(false);

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.Property(e => e.FrbCd).IsUnicode(false);

                entity.Property(e => e.HomeCcyCd).IsUnicode(false);
            });

            modelBuilder.Entity<VGuideEucDeptCode>(entity =>
            {
                entity.ToView("vGUIDE_EUC_DEPT_CODE");

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.DeptAbbr).IsUnicode(false);

                entity.Property(e => e.DeptCd).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);
            });

            modelBuilder.Entity<VLoanForwardRepayment>(entity =>
            {
                entity.ToView("vLoan_ForwardRepayment");

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VLoanPostRepayment>(entity =>
            {
                entity.ToView("vLoan_PostRepayment");

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VLoanRepayment>(entity =>
            {
                entity.ToView("vLoan_Repayment");

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VLoanRolloverEquiv>(entity =>
            {
                entity.ToView("vLoan_RolloverEquiv");

                entity.Property(e => e.RefNo).IsUnicode(false);
            });

            modelBuilder.Entity<VLoanRolloverRepayment>(entity =>
            {
                entity.ToView("vLoan_RolloverRepayment");

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VLoanTransLive>(entity =>
            {
                entity.ToView("vLoan_Trans_Live");

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VLoanTransSearchV3>(entity =>
            {
                entity.ToView("vLoan_Trans_Search_v3");

                entity.Property(e => e.AppLnNo).IsUnicode(false);

                entity.Property(e => e.ApprBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ApprBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.ChkBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.CustStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DrawExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FlagDelBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.OriginalDrawExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.OriginalRepayExchInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProcBy2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RepayExchRateInd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<VRsDetOutstandingBalAndAccruedInt>(entity =>
            {
                entity.ToView("vRS_DetOutstandingBalAndAccruedInt");

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);
            });

            modelBuilder.Entity<ViewEucCustomer2>(entity =>
            {
                entity.ToView("VIEW_EUC_CUSTOMER_2");
            });

            modelBuilder.Entity<ViewEucFacility2>(entity =>
            {
                entity.ToView("VIEW_EUC_FACILITY_2");
            });

            modelBuilder.Entity<ViewEucFeeAndCharge2>(entity =>
            {
                entity.ToView("VIEW_EUC_FEE_and_CHARGE_2");
            });

            modelBuilder.Entity<ViewEucLoantrans2>(entity =>
            {
                entity.ToView("VIEW_EUC_LOANTRANS_2");

                entity.Property(e => e.ApprBy1).IsUnicode(false);

                entity.Property(e => e.ApprBy2).IsUnicode(false);

                entity.Property(e => e.ChkBy).IsUnicode(false);

                entity.Property(e => e.DrawExchRateInd).IsUnicode(false);

                entity.Property(e => e.IntRecvBy).IsUnicode(false);

                entity.Property(e => e.IntRecvDate).IsUnicode(false);

                entity.Property(e => e.ProcBy1).IsUnicode(false);

                entity.Property(e => e.ProcBy2).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RepayExchRateInd).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ViewEucOustandingBalAndAccruedInt>(entity =>
            {
                entity.ToView("VIEW_EUC_OustandingBalAndAccruedInt");
            });

            modelBuilder.Entity<ViewEucOutstandingBalAndAccruedIntDet>(entity =>
            {
                entity.ToView("VIEW_EUC_OutstandingBalAndAccruedInt_DET");
            });

            modelBuilder.Entity<ViewEucOutstandingBalAndAccruedIntSum>(entity =>
            {
                entity.ToView("VIEW_EUC_OutstandingBalAndAccruedInt_SUM");
            });

            modelBuilder.Entity<ViewLoanCovenantMaster>(entity =>
            {
                entity.ToView("VIEW_LOAN_COVENANT_MASTER");

                entity.Property(e => e.AccountOfficer)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Condit).IsUnicode(false);

                entity.Property(e => e.ConditionDesc).IsUnicode(false);

                entity.Property(e => e.CovApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CovStatus).IsUnicode(false);

                entity.Property(e => e.CovenantDecs).IsUnicode(false);

                entity.Property(e => e.CovenantNo).ValueGeneratedOnAdd();

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.Denomination).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.LoanAo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MathSymbol).IsUnicode(false);

                entity.Property(e => e.TimingDesc)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<ViewLoanCovenantRecord>(entity =>
            {
                entity.ToView("VIEW_LOAN_COVENANT_RECORDS");

                entity.Property(e => e.AccountOfficer)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Condit).IsUnicode(false);

                entity.Property(e => e.ConditionDesc).IsUnicode(false);

                entity.Property(e => e.CovenantDecs).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.Denomination).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.InCompliance).IsUnicode(false);

                entity.Property(e => e.LoanAo)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MathSymbol).IsUnicode(false);

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.RecStatus).IsUnicode(false);
            });

            modelBuilder.Entity<ViewLoanCustomerLoanTrancheFacility>(entity =>
            {
                entity.ToView("VIEW_LOAN_CUSTOMER_LOAN_TRANCHE_FACILITY");

                entity.Property(e => e.ApplnNo).IsUnicode(false);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.CustStatusCd).IsUnicode(false);

                entity.Property(e => e.LoanCustAbbr).IsUnicode(false);

                entity.Property(e => e.LoanStatus).IsUnicode(false);

                entity.Property(e => e.ProdDesc2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ProdDesc4)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.RatioSpread1).IsUnicode(false);

                entity.Property(e => e.RatioSpread2).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.TrancheName).IsUnicode(false);

                entity.Property(e => e.TrancheStatus).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
