using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.GUIDE;

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class GUIDEDbContext : DbContext
    {
        public GUIDEDbContext()
        {
        }

        public GUIDEDbContext(DbContextOptions<GUIDEDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AreaCode> AreaCodes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AuditEvent> AuditEvents { get; set; }
        public virtual DbSet<AuditLog> AuditLogs { get; set; }
        public virtual DbSet<AuditMurexGuideRateChange> AuditMurexGuideRateChanges { get; set; }
        public virtual DbSet<AuditTrail> AuditTrails { get; set; }
        public virtual DbSet<BankInf> BankInfs { get; set; }
        public virtual DbSet<BankInfCorr> BankInfCorrs { get; set; }
        public virtual DbSet<BaseRate> BaseRates { get; set; }
        public virtual DbSet<BisRate> BisRates { get; set; }
        public virtual DbSet<BusinessConditionA> BusinessConditionAs { get; set; }
        public virtual DbSet<BusinessConditionB> BusinessConditionBs { get; set; }
        public virtual DbSet<BusinessConditionC> BusinessConditionCs { get; set; }
        public virtual DbSet<CcyCodeTable> CcyCodeTables { get; set; }
        public virtual DbSet<CmpCode> CmpCodes { get; set; }
        public virtual DbSet<ConfigVal> ConfigVals { get; set; }
        public virtual DbSet<CorpSettlementAccount> CorpSettlementAccounts { get; set; }
        public virtual DbSet<CurrExchangeRate> CurrExchangeRates { get; set; }
        public virtual DbSet<CustAccountNo> CustAccountNos { get; set; }
        public virtual DbSet<CustGradeCode> CustGradeCodes { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<CustomerMasterLog> CustomerMasterLogs { get; set; }
        public virtual DbSet<DataDrivenSubscriptionSetting> DataDrivenSubscriptionSettings { get; set; }
        public virtual DbSet<DealTypeGroup> DealTypeGroups { get; set; }
        public virtual DbSet<DealingSettlementOfficeMap> DealingSettlementOfficeMaps { get; set; }
        public virtual DbSet<DepositsRate> DepositsRates { get; set; }
        public virtual DbSet<DistributionChannel> DistributionChannels { get; set; }
        public virtual DbSet<DistributionPassword> DistributionPasswords { get; set; }
        public virtual DbSet<DistributionPreference> DistributionPreferences { get; set; }
        public virtual DbSet<DistributionType> DistributionTypes { get; set; }
        public virtual DbSet<DomesticClearingAnzSummary> DomesticClearingAnzSummaries { get; set; }
        public virtual DbSet<DomesticClearingBsb> DomesticClearingBsbs { get; set; }
        public virtual DbSet<DomesticClearingBsbFile> DomesticClearingBsbFiles { get; set; }
        public virtual DbSet<DomesticClearingBulkPaymentDetail> DomesticClearingBulkPaymentDetails { get; set; }
        public virtual DbSet<DomesticClearingBulkPaymentSummary> DomesticClearingBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingDeposit> DomesticClearingDeposits { get; set; }
        public virtual DbSet<DomesticClearingDirectEntry> DomesticClearingDirectEntries { get; set; }
        public virtual DbSet<DomesticClearingDirection> DomesticClearingDirections { get; set; }
        public virtual DbSet<DomesticClearingFee> DomesticClearingFees { get; set; }
        public virtual DbSet<DomesticClearingFeeLog> DomesticClearingFeeLogs { get; set; }
        public virtual DbSet<DomesticClearingGasStatus> DomesticClearingGasStatuses { get; set; }
        public virtual DbSet<DomesticClearingGde> DomesticClearingGdes { get; set; }
        public virtual DbSet<DomesticClearingGoposting> DomesticClearingGopostings { get; set; }
        public virtual DbSet<DomesticClearingMultiPurposeInstructionAttachment> DomesticClearingMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingMultiPurposeInstructionDetail> DomesticClearingMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingNotification> DomesticClearingNotifications { get; set; }
        public virtual DbSet<DomesticClearingPayment> DomesticClearingPayments { get; set; }
        public virtual DbSet<DomesticClearingPaymentLine> DomesticClearingPaymentLines { get; set; }
        public virtual DbSet<DomesticClearingPaymentLineValidationError> DomesticClearingPaymentLineValidationErrors { get; set; }
        public virtual DbSet<DomesticClearingPaymentLog> DomesticClearingPaymentLogs { get; set; }
        public virtual DbSet<DomesticClearingPaymentMethod> DomesticClearingPaymentMethods { get; set; }
        public virtual DbSet<DomesticClearingPaymentMethodValidation> DomesticClearingPaymentMethodValidations { get; set; }
        public virtual DbSet<DomesticClearingPaymentValidationError> DomesticClearingPaymentValidationErrors { get; set; }
        public virtual DbSet<DomesticClearingPostingType> DomesticClearingPostingTypes { get; set; }
        public virtual DbSet<DomesticClearingPresentment> DomesticClearingPresentments { get; set; }
        public virtual DbSet<DomesticClearingProduct> DomesticClearingProducts { get; set; }
        public virtual DbSet<DomesticClearingProductLog> DomesticClearingProductLogs { get; set; }
        public virtual DbSet<DomesticClearingRecBatch> DomesticClearingRecBatches { get; set; }
        public virtual DbSet<DomesticClearingRecCollateGo> DomesticClearingRecCollateGos { get; set; }
        public virtual DbSet<DomesticClearingRecCollateInwardClearing> DomesticClearingRecCollateInwardClearings { get; set; }
        public virtual DbSet<DomesticClearingRecCollatePayment> DomesticClearingRecCollatePayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollatePaymentCreation> DomesticClearingRecCollatePaymentCreations { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoEuconDemandLogAccount> DomesticClearingRecCollectGoEuconDemandLogAccounts { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoEuconDemandLogCommon> DomesticClearingRecCollectGoEuconDemandLogCommons { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGasGoCredit> DomesticClearingRecCollectGoGasGoCredits { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGasGoDebit> DomesticClearingRecCollectGoGasGoDebits { get; set; }
        public virtual DbSet<DomesticClearingRecCollectGoGoposting> DomesticClearingRecCollectGoGopostings { get; set; }
        public virtual DbSet<DomesticClearingRecCollectInwardClearingAnzSummary> DomesticClearingRecCollectInwardClearingAnzSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectInwardClearingPayment> DomesticClearingRecCollectInwardClearingPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentBulkPaymentSummary> DomesticClearingRecCollectPaymentBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary> DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentCreationPayment> DomesticClearingRecCollectPaymentCreationPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentDereplyDetail> DomesticClearingRecCollectPaymentDereplyDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentDereplyHeader> DomesticClearingRecCollectPaymentDereplyHeaders { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment> DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail> DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails { get; set; }
        public virtual DbSet<DomesticClearingRecCollectPaymentPayment> DomesticClearingRecCollectPaymentPayments { get; set; }
        public virtual DbSet<DomesticClearingRecCollection> DomesticClearingRecCollections { get; set; }
        public virtual DbSet<DomesticClearingRecKeyStatus> DomesticClearingRecKeyStatuses { get; set; }
        public virtual DbSet<DomesticClearingRecRecGo> DomesticClearingRecRecGos { get; set; }
        public virtual DbSet<DomesticClearingRecRecInwardClearing> DomesticClearingRecRecInwardClearings { get; set; }
        public virtual DbSet<DomesticClearingRecRecPayment> DomesticClearingRecRecPayments { get; set; }
        public virtual DbSet<DomesticClearingRecRecPaymentCreation> DomesticClearingRecRecPaymentCreations { get; set; }
        public virtual DbSet<DomesticClearingRecSource> DomesticClearingRecSources { get; set; }
        public virtual DbSet<DomesticClearingRecType> DomesticClearingRecTypes { get; set; }
        public virtual DbSet<DomesticClearingRecValueStatus> DomesticClearingRecValueStatuses { get; set; }
        public virtual DbSet<DomesticClearingRemitter> DomesticClearingRemitters { get; set; }
        public virtual DbSet<DomesticClearingRemitterLog> DomesticClearingRemitterLogs { get; set; }
        public virtual DbSet<DomesticClearingReturnRefusalCode> DomesticClearingReturnRefusalCodes { get; set; }
        public virtual DbSet<DomesticClearingSource> DomesticClearingSources { get; set; }
        public virtual DbSet<DomesticClearingStatus> DomesticClearingStatuses { get; set; }
        public virtual DbSet<DomesticClearingUnitCodeAccount> DomesticClearingUnitCodeAccounts { get; set; }
        public virtual DbSet<DomesticClearingUnitCodeAccountLog> DomesticClearingUnitCodeAccountLogs { get; set; }
        public virtual DbSet<DomesticClearingValidationError> DomesticClearingValidationErrors { get; set; }
        public virtual DbSet<DreamsUploadException> DreamsUploadExceptions { get; set; }
        public virtual DbSet<EndOfDayStart> EndOfDayStarts { get; set; }
        public virtual DbSet<EucCcyCode> EucCcyCodes { get; set; }
        public virtual DbSet<EucCollateralCode> EucCollateralCodes { get; set; }
        public virtual DbSet<EucCountryCode> EucCountryCodes { get; set; }
        public virtual DbSet<EucCustAttributeCode> EucCustAttributeCodes { get; set; }
        public virtual DbSet<EucCustomerAccountNo> EucCustomerAccountNos { get; set; }
        public virtual DbSet<EucDeptCode> EucDeptCodes { get; set; }
        public virtual DbSet<EucIndustryCode> EucIndustryCodes { get; set; }
        public virtual DbSet<EucTaxCode> EucTaxCodes { get; set; }
        public virtual DbSet<FuturesRate> FuturesRates { get; set; }
        public virtual DbSet<FxConfirmationComment> FxConfirmationComments { get; set; }
        public virtual DbSet<FxConfirmationLog> FxConfirmationLogs { get; set; }
        public virtual DbSet<FxConfirmationReminderEmailLog> FxConfirmationReminderEmailLogs { get; set; }
        public virtual DbSet<FxConfirmationSearchDto> FxConfirmationSearchDtos { get; set; }
        public virtual DbSet<FxConfirmationStatus> FxConfirmationStatuses { get; set; }
        public virtual DbSet<FxRate> FxRates { get; set; }
        public virtual DbSet<FxSettlementInf> FxSettlementInfs { get; set; }
        public virtual DbSet<FxTransaction> FxTransactions { get; set; }
        public virtual DbSet<FxTransactionExt> FxTransactionExts { get; set; }
        public virtual DbSet<Fxfarbitrage> Fxfarbitrages { get; set; }
        public virtual DbSet<FxfbusCenter> FxfbusCenters { get; set; }
        public virtual DbSet<Fxfcalendar> Fxfcalendars { get; set; }
        public virtual DbSet<Fxfccy> Fxfccies { get; set; }
        public virtual DbSet<FxfcreditCustType> FxfcreditCustTypes { get; set; }
        public virtual DbSet<FxfcreditParent> FxfcreditParents { get; set; }
        public virtual DbSet<Fxfcust> Fxfcusts { get; set; }
        public virtual DbSet<Fxfcustthreshold> Fxfcustthresholds { get; set; }
        public virtual DbSet<FxfdealType> FxfdealTypes { get; set; }
        public virtual DbSet<Fxfinstitution> Fxfinstitutions { get; set; }
        public virtual DbSet<Fxfswift> Fxfswifts { get; set; }
        public virtual DbSet<GasGoCredit> GasGoCredits { get; set; }
        public virtual DbSet<GasGoDebit> GasGoDebits { get; set; }
        public virtual DbSet<GasGoParameter> GasGoParameters { get; set; }
        public virtual DbSet<GasGoUploadParameter> GasGoUploadParameters { get; set; }
        public virtual DbSet<GasTemplate> GasTemplates { get; set; }
        public virtual DbSet<GasTemplateDetail> GasTemplateDetails { get; set; }
        public virtual DbSet<GasUploadHistory> GasUploadHistories { get; set; }
        public virtual DbSet<GasUploadStatus> GasUploadStatuses { get; set; }
        public virtual DbSet<GasUploadTexception> GasUploadTexceptions { get; set; }
        public virtual DbSet<GbaseErrorCode> GbaseErrorCodes { get; set; }
        public virtual DbSet<GbaseRateConversionByCcyPair> GbaseRateConversionByCcyPairs { get; set; }
        public virtual DbSet<GbaseReferenceNo> GbaseReferenceNos { get; set; }
        public virtual DbSet<GbaseReferenceNoLastUsed> GbaseReferenceNoLastUseds { get; set; }
        public virtual DbSet<GeneralisedCode> GeneralisedCodes { get; set; }
        public virtual DbSet<GlinkQueueManagerAction> GlinkQueueManagerActions { get; set; }
        public virtual DbSet<GuideBisRateTempl> GuideBisRateTempls { get; set; }
        public virtual DbSet<GuideDepositRateTempl> GuideDepositRateTempls { get; set; }
        public virtual DbSet<GuideExchangeRateTempl> GuideExchangeRateTempls { get; set; }
        public virtual DbSet<GuideLog> GuideLogs { get; set; }
        public virtual DbSet<GuideRevaluationRateTempl> GuideRevaluationRateTempls { get; set; }
        public virtual DbSet<GuideSwapRateTempl> GuideSwapRateTempls { get; set; }
        public virtual DbSet<InterbankAccountNo> InterbankAccountNos { get; set; }
        public virtual DbSet<IspsLotusNotesExtract> IspsLotusNotesExtracts { get; set; }
        public virtual DbSet<IspsMurexGeneratorMapper> IspsMurexGeneratorMappers { get; set; }
        public virtual DbSet<IspsStpTradeType> IspsStpTradeTypes { get; set; }
        public virtual DbSet<MassApprovalInput> MassApprovalInputs { get; set; }
        public virtual DbSet<MassDreamsApprovalAccess> MassDreamsApprovalAccesses { get; set; }
        public virtual DbSet<MassGbaseMenuAccess> MassGbaseMenuAccesses { get; set; }
        public virtual DbSet<MassTransaction> MassTransactions { get; set; }
        public virtual DbSet<MassTransactionHistory> MassTransactionHistories { get; set; }
        public virtual DbSet<MgeBreceivedFile> MgeBreceivedFiles { get; set; }
        public virtual DbSet<MgeBtransactionConfirmation> MgeBtransactionConfirmations { get; set; }
        public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }
        public virtual DbSet<MoneyMarketTicket> MoneyMarketTickets { get; set; }
        public virtual DbSet<MoneyMarketTicketExt> MoneyMarketTicketExts { get; set; }
        public virtual DbSet<MsmqMessageDatum> MsmqMessageData { get; set; }
        public virtual DbSet<MsmqMessageHistoryDatum> MsmqMessageHistoryData { get; set; }
        public virtual DbSet<MurexHolidayCalendar> MurexHolidayCalendars { get; set; }
        public virtual DbSet<MurexRamSummary> MurexRamSummaries { get; set; }
        public virtual DbSet<MurexRateExportControl> MurexRateExportControls { get; set; }
        public virtual DbSet<MxCategory> MxCategories { get; set; }
        public virtual DbSet<MxCategoryMapping> MxCategoryMappings { get; set; }
        public virtual DbSet<MxCounterpartyType> MxCounterpartyTypes { get; set; }
        public virtual DbSet<MxCtpyTypeAttrCode> MxCtpyTypeAttrCodes { get; set; }
        public virtual DbSet<MxCustCounterpartyType> MxCustCounterpartyTypes { get; set; }
        public virtual DbSet<MxCustomerEvent> MxCustomerEvents { get; set; }
        public virtual DbSet<MxCustomerStatus> MxCustomerStatuses { get; set; }
        public virtual DbSet<MxEucBalanceEvent> MxEucBalanceEvents { get; set; }
        public virtual DbSet<MxGuideCustDetail> MxGuideCustDetails { get; set; }
        public virtual DbSet<MxInboundEvent> MxInboundEvents { get; set; }
        public virtual DbSet<MxInboundEventLog> MxInboundEventLogs { get; set; }
        public virtual DbSet<MxInboundMessageStatus> MxInboundMessageStatuses { get; set; }
        public virtual DbSet<MxIndustryCodeSector> MxIndustryCodeSectors { get; set; }
        public virtual DbSet<MxIspsTrade> MxIspsTrades { get; set; }
        public virtual DbSet<MxTaxCode> MxTaxCodes { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<ObsBasisExportMapping> ObsBasisExportMappings { get; set; }
        public virtual DbSet<ObsBasisRate> ObsBasisRates { get; set; }
        public virtual DbSet<ObsYieldExportMapping> ObsYieldExportMappings { get; set; }
        public virtual DbSet<ObsYieldFutureMaturity> ObsYieldFutureMaturities { get; set; }
        public virtual DbSet<ObsYieldRate> ObsYieldRates { get; set; }
        public virtual DbSet<Opd37FileProcessHistory> Opd37FileProcessHistories { get; set; }
        public virtual DbSet<Opd37LoanInterestRateChangeExport> Opd37LoanInterestRateChangeExports { get; set; }
        public virtual DbSet<Opd37LoanInterestRateRetraceExport> Opd37LoanInterestRateRetraceExports { get; set; }
        public virtual DbSet<Opd37LoanRaw> Opd37LoanRaws { get; set; }
        public virtual DbSet<Opd37SwapExport> Opd37SwapExports { get; set; }
        public virtual DbSet<Opd37SwapRaw> Opd37SwapRaws { get; set; }
        public virtual DbSet<PasswordHistory> PasswordHistories { get; set; }
        public virtual DbSet<PaymentControlAccordConfirmation> PaymentControlAccordConfirmations { get; set; }
        public virtual DbSet<PaymentControlMatchFx> PaymentControlMatchFxes { get; set; }
        public virtual DbSet<PaymentControlMatchMoneyMarket> PaymentControlMatchMoneyMarkets { get; set; }
        public virtual DbSet<PaymentControlMisysConfirmation> PaymentControlMisysConfirmations { get; set; }
        public virtual DbSet<PaymentControlPayment> PaymentControlPayments { get; set; }
        public virtual DbSet<PaymentControlPaymentLog> PaymentControlPaymentLogs { get; set; }
        public virtual DbSet<PaymentControlProduct> PaymentControlProducts { get; set; }
        public virtual DbSet<PaymentControlProductReference> PaymentControlProductReferences { get; set; }
        public virtual DbSet<PaymentControlRemittance> PaymentControlRemittances { get; set; }
        public virtual DbSet<PaymentControlRtgsSwiftCodeTranslation> PaymentControlRtgsSwiftCodeTranslations { get; set; }
        public virtual DbSet<PaymentControlStatus> PaymentControlStatuses { get; set; }
        public virtual DbSet<PaymentControlSwiftAck> PaymentControlSwiftAcks { get; set; }
        public virtual DbSet<PaymentControlSwiftPayment> PaymentControlSwiftPayments { get; set; }
        public virtual DbSet<PaymentControlSwiftPaymentLog> PaymentControlSwiftPaymentLogs { get; set; }
        public virtual DbSet<RacfSystemId> RacfSystemIds { get; set; }
        public virtual DbSet<RacfSystemIdHistory> RacfSystemIdHistories { get; set; }
        public virtual DbSet<RamBaseRecord> RamBaseRecords { get; set; }
        public virtual DbSet<RamGbaseTotal> RamGbaseTotals { get; set; }
        public virtual DbSet<RamReconSummary> RamReconSummaries { get; set; }
        public virtual DbSet<RatesGbaseUploadCriterion> RatesGbaseUploadCriteria { get; set; }
        public virtual DbSet<RatesGbaseUploadCtl> RatesGbaseUploadCtls { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<RevaluationRate> RevaluationRates { get; set; }
        public virtual DbSet<RmbDefault> RmbDefaults { get; set; }
        public virtual DbSet<SecurityGroup> SecurityGroups { get; set; }
        public virtual DbSet<SecurityGroupFunction> SecurityGroupFunctions { get; set; }
        public virtual DbSet<SettlementCorpCustDefault> SettlementCorpCustDefaults { get; set; }
        public virtual DbSet<SettlementCorpCustDefault2> SettlementCorpCustDefault2s { get; set; }
        public virtual DbSet<SettlementInf> SettlementInfs { get; set; }
        public virtual DbSet<SettlementInterbankDefault> SettlementInterbankDefaults { get; set; }
        public virtual DbSet<ShipUploadingHistory> ShipUploadingHistories { get; set; }
        public virtual DbSet<SpotRateUsdEquiv> SpotRateUsdEquivs { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<SwapRate> SwapRates { get; set; }
        public virtual DbSet<SystemFunction> SystemFunctions { get; set; }
        public virtual DbSet<SystemMessage> SystemMessages { get; set; }
        public virtual DbSet<SystemModule> SystemModules { get; set; }
        public virtual DbSet<SystemModuleGroup> SystemModuleGroups { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<SystemRegistryParameter> SystemRegistryParameters { get; set; }
        public virtual DbSet<SystemSetting> SystemSettings { get; set; }
        public virtual DbSet<TempRevaluationRate> TempRevaluationRates { get; set; }
        public virtual DbSet<TransactionKindAdvancedNotice> TransactionKindAdvancedNotices { get; set; }
        public virtual DbSet<TransactionKindMoneyMarket> TransactionKindMoneyMarkets { get; set; }
        public virtual DbSet<TransactionKindOverrideCode> TransactionKindOverrideCodes { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserSecurityGroup> UserSecurityGroups { get; set; }
        public virtual DbSet<UsersExt> UsersExts { get; set; }
        public virtual DbSet<UsrGbaseSplTransaction> UsrGbaseSplTransactions { get; set; }
        public virtual DbSet<VgasGeneraloperation> VgasGeneraloperations { get; set; }
        public virtual DbSet<VgasSelectwebgastransaction> VgasSelectwebgastransactions { get; set; }
        public virtual DbSet<ViewEucBankInfPrepare1> ViewEucBankInfPrepare1s { get; set; }
        public virtual DbSet<ViewEucBankInfPrepare2> ViewEucBankInfPrepare2s { get; set; }
        public virtual DbSet<ViewEucCcyCode> ViewEucCcyCodes { get; set; }
        public virtual DbSet<ViewEucCustomerAccountNo> ViewEucCustomerAccountNos { get; set; }
        public virtual DbSet<ViewEucCustomerMaster> ViewEucCustomerMasters { get; set; }
        public virtual DbSet<ViewFxsystemCreditparent> ViewFxsystemCreditparents { get; set; }
        public virtual DbSet<ViewGipFxTransaction> ViewGipFxTransactions { get; set; }
        public virtual DbSet<ViewGuideCorpCustomerAccount> ViewGuideCorpCustomerAccounts { get; set; }
        public virtual DbSet<ViewGuideCustomerMasterAll> ViewGuideCustomerMasterAlls { get; set; }
        public virtual DbSet<ViewGuideFxTransaction> ViewGuideFxTransactions { get; set; }
        public virtual DbSet<ViewMmTicketDetail> ViewMmTicketDetails { get; set; }
        public virtual DbSet<ViewRamReconSummary> ViewRamReconSummaries { get; set; }
        public virtual DbSet<ViewRatesGuideBisRate> ViewRatesGuideBisRates { get; set; }
        public virtual DbSet<ViewRatesGuideDepositRate> ViewRatesGuideDepositRates { get; set; }
        public virtual DbSet<ViewRatesGuideSwapRate> ViewRatesGuideSwapRates { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=GUIDE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetUser>(entity =>
            {
                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRole",
                        l => l.HasOne<AspNetRole>().WithMany().HasForeignKey("RoleId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                        r => r.HasOne<AspNetUser>().WithMany().HasForeignKey("UserId").HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");

                            j.ToTable("AspNetUserRoles", "dbo");

                            j.HasIndex(new[] { "RoleId" }, "IX_RoleId");

                            j.HasIndex(new[] { "UserId" }, "IX_UserId");

                            j.IndexerProperty<string>("UserId").HasMaxLength(128);

                            j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                        });
            });

            modelBuilder.Entity<AspNetUserClaim>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogin>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.Property(e => e.UserId).IsFixedLength();
            });

            modelBuilder.Entity<BankInf>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.SettlBranchNo });

                entity.Property(e => e.SettlBranchNo).HasDefaultValueSql("('751')");

                entity.Property(e => e.Acronym).HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ChapsSortCd).HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsAba).HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsUid).HasDefaultValueSql("('')");

                entity.Property(e => e.CorBankCd).HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.FedId).HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry).HasDefaultValueSql("('AU')");

                entity.Property(e => e.MhcbBrAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.NameAddr1).HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr2).HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr3).HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr4).HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.SwiftFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BankInfCorr>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.CcyCd, e.SettlBranchNo });

                entity.Property(e => e.SettlBranchNo).HasDefaultValueSql("('751')");

                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankInfId).ValueGeneratedOnAdd();

                entity.Property(e => e.BranchNo).HasDefaultValueSql("('')");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankActno).HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.BankInfCorrs)
                    .HasForeignKey(d => new { d.SwiftId, d.SettlBranchNo })
                    .HasConstraintName("FK_BANK_INF_BANK_INF_CORR");
            });

            modelBuilder.Entity<BaseRate>(entity =>
            {
                entity.HasKey(e => new { e.OperationDate, e.StartDate, e.Ccy, e.Source, e.Duration });
            });

            modelBuilder.Entity<BisRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.ImportedBy).HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<CmpCode>(entity =>
            {
                entity.Property(e => e.CmpCode1).ValueGeneratedNever();
            });

            modelBuilder.Entity<CustAccountNo>(entity =>
            {
                entity.Property(e => e.ActId).ValueGeneratedNever();
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CustAbbr });

                entity.Property(e => e.BranchNo).HasDefaultValueSql("('751')");

                entity.Property(e => e.CustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Address).HasDefaultValueSql("('')");

                entity.Property(e => e.Address2).HasDefaultValueSql("('')");

                entity.Property(e => e.AreaCd).HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeCd).HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeSubCd).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.BankGroupAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.BankManagementCd).HasDefaultValueSql("('')");

                entity.Property(e => e.BoeCd).HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessCondition).HasDefaultValueSql("('')");

                entity.Property(e => e.CfsIo).HasDefaultValueSql("('')");

                entity.Property(e => e.CollateralNo).HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.CorresBankCd).HasDefaultValueSql("('')");

                entity.Property(e => e.CreditSupervision).HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode).HasDefaultValueSql("('')");

                entity.Property(e => e.CustId).HasDefaultValueSql("(0)");

                entity.Property(e => e.CustName).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentCd).HasDefaultValueSql("('')");

                entity.Property(e => e.DkbCompanyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.GoodAssetFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.GradeCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCompanyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorAttrCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCd).HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCountry).HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorName).HasDefaultValueSql("('')");

                entity.Property(e => e.IndustryCd).HasDefaultValueSql("('')");

                entity.Property(e => e.JapaneseFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LicenceFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.LocalIndustryCd).HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry).HasDefaultValueSql("('')");

                entity.Property(e => e.MailCountry).HasDefaultValueSql("('')");

                entity.Property(e => e.Mark3Cd).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Nationality).HasDefaultValueSql("('')");

                entity.Property(e => e.NextReviewDate).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.ObligorSupervision).HasDefaultValueSql("('')");

                entity.Property(e => e.OfficerCd).HasDefaultValueSql("('')");

                entity.Property(e => e.OffshoreCd).HasDefaultValueSql("('')");

                entity.Property(e => e.OpeningDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ParentCustCd).HasDefaultValueSql("('')");

                entity.Property(e => e.ParentNationality).HasDefaultValueSql("('')");

                entity.Property(e => e.RatingDate).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.RatingPoint).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioOfInvDkb).HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvGvn).HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvJp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks1).HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks2).HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks3).HasDefaultValueSql("('')");

                entity.Property(e => e.RetailActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.StaffLoanFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.Stance).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd).HasDefaultValueSql("('')");

                entity.Property(e => e.StepsCustCd).HasDefaultValueSql("('')");

                entity.Property(e => e.SublimitBankAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCd).HasDefaultValueSql("('')");

                entity.Property(e => e.TaxId).HasDefaultValueSql("('')");

                entity.Property(e => e.TaxNo).HasDefaultValueSql("('')");

                entity.Property(e => e.TelNo).HasDefaultValueSql("('')");

                entity.Property(e => e.TelexNo).HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomerMasterLog>(entity =>
            {
                entity.Property(e => e.LogTime).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DataDrivenSubscriptionSetting>(entity =>
            {
                entity.Property(e => e.Comments).HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress).HasDefaultValueSql("('')");

                entity.Property(e => e.EndOfDay).HasDefaultValueSql("(0)");

                entity.Property(e => e.FileExtn).HasDefaultValueSql("(1)");

                entity.Property(e => e.FileName).HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Linked).HasDefaultValueSql("('True')");

                entity.Property(e => e.Path).HasDefaultValueSql("('\\\\mizweb01\\AppData$\\guide\\report')");

                entity.Property(e => e.PwExpired).HasDefaultValueSql("(1)");

                entity.Property(e => e.RenderFormat).HasDefaultValueSql("('MHTML')");

                entity.Property(e => e.ReportInclude).HasDefaultValueSql("('True')");

                entity.Property(e => e.Subject).HasDefaultValueSql("('')");

                entity.Property(e => e.WriteMode).HasDefaultValueSql("('AutoIncrement')");
            });

            modelBuilder.Entity<DealTypeGroup>(entity =>
            {
                entity.Property(e => e.FamilyCode).IsFixedLength();

                entity.Property(e => e.ThreeLetterCode).IsFixedLength();
            });

            modelBuilder.Entity<DealingSettlementOfficeMap>(entity =>
            {
                entity.HasKey(e => e.DealingSettlementOfficeId)
                    .HasName("PK_Dealing_SettlementOffice");

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DepositsRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });

                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.Period).HasDefaultValueSql("('1M')");

                entity.Property(e => e.ImportedBy).HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DistributionChannel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<DistributionPreference>(entity =>
            {
                entity.HasOne(d => d.DistributionChannelNavigation)
                    .WithMany(p => p.DistributionPreferences)
                    .HasForeignKey(d => d.DistributionChannel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRIBUTION_PREFERENCE_DISTRIBUTION_CHANNEL");

                entity.HasOne(d => d.DistributionTypeNavigation)
                    .WithMany(p => p.DistributionPreferences)
                    .HasForeignKey(d => d.DistributionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DISTRIBUTION_PREFERENCE_DISTRIBUTION_TYPE");
            });

            modelBuilder.Entity<DistributionType>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DefaultDistributionStatus).IsFixedLength();
            });

            modelBuilder.Entity<DomesticClearingAnzSummary>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingBsb>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingBsbFile>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingBulkPaymentDetail>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingBulkPaymentDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_BulkPaymentDetail_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingBulkPaymentDetails)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_BulkPaymentDetail_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingBulkPaymentSummary>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingDeposit>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingDeposits)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_Deposit_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingDirectEntry>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingDirectEntries)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_DirectEntry_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingDirectEntries)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_DirectEntry_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingDirection>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingFee>(entity =>
            {
                entity.HasKey(e => e.FeeId)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.Account, e.StatusId, e.EffectiveDate }, "IX_DomesticClearing_Fee_AccountStatusIdEffectiveDate")
                    .IsClustered();

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.DomesticClearingFees)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Fee_DomesticClearing_PaymentMethod");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingFees)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Fee_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingFeeLog>(entity =>
            {
                entity.HasOne(d => d.Fee)
                    .WithMany(p => p.DomesticClearingFeeLogs)
                    .HasForeignKey(d => d.FeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_FeeLog_DomesticClearing_Fee");
            });

            modelBuilder.Entity<DomesticClearingGasStatus>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingGde>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingGdes)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_GDES_DomesticClearing_Payment");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingGdes)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_GDES_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingGoposting>(entity =>
            {
                entity.HasKey(e => e.GopostingId)
                    .HasName("PK_DomesticClearing_GOPosting_1");

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.DebitMinNoNavigation)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.DebitMinNo)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_GAS_GO_DEBIT");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_Direction");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_PaymentLine");

                entity.HasOne(d => d.PostingType)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.PostingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_PostingType");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingGopostings)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_GOPosting_DomesticClearing_GasStatus");
            });

            modelBuilder.Entity<DomesticClearingMultiPurposeInstructionAttachment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.MultiPurposeInstructionDetail)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.MultiPurposeInstructionDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionAttachment_DomesticClearing_MultiPurposeInstructionDetail");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionAttachment_DomesticClearing_PaymentLine");
            });

            modelBuilder.Entity<DomesticClearingMultiPurposeInstructionDetail>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_MultiPurposeInstructionDetail_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingNotification>(entity =>
            {
                entity.HasKey(e => e.NotificationId)
                    .IsClustered(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingPayment>(entity =>
            {
                entity.HasIndex(e => e.FeePostId, "UQ_DomesticClearing_Payment_FeePostId")
                    .IsUnique()
                    .HasFilter("([FeePostId] IS NOT NULL)");

                entity.HasIndex(e => e.MainPostId, "UQ_DomesticClearing_Payment_MainPostId")
                    .IsUnique()
                    .HasFilter("([MainPostId] IS NOT NULL)");

                entity.Property(e => e.BranchNo).HasDefaultValueSql("((751))");

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsClearerExtracted).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.DirectionId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Direction");

                entity.HasOne(d => d.FeePost)
                    .WithOne(p => p.DomesticClearingPaymentFeePost)
                    .HasForeignKey<DomesticClearingPayment>(d => d.FeePostId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_FeePosting");

                entity.HasOne(d => d.MainPost)
                    .WithOne(p => p.DomesticClearingPaymentMainPost)
                    .HasForeignKey<DomesticClearingPayment>(d => d.MainPostId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_GOPosting");

                entity.HasOne(d => d.PaymentMethod)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.PaymentMethodId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_PaymentMethod");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Product");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Payment_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingPaymentLine>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_Payment");

                entity.HasOne(d => d.ReturnFeePost)
                    .WithMany(p => p.DomesticClearingPaymentLineReturnFeePosts)
                    .HasForeignKey(d => d.ReturnFeePostId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_GOPosting1");

                entity.HasOne(d => d.ReturnPost)
                    .WithMany(p => p.DomesticClearingPaymentLineReturnPosts)
                    .HasForeignKey(d => d.ReturnPostId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_GOPosting");

                entity.HasOne(d => d.ReturnRefusalCode)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.ReturnRefusalCodeId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_ReturnCode");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingPaymentLines)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLine_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingPaymentLineValidationError>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PaymentLine)
                    .WithMany(p => p.DomesticClearingPaymentLineValidationErrors)
                    .HasForeignKey(d => d.PaymentLineId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLineValidationError_DomesticClearing_PaymentLine");

                entity.HasOne(d => d.ValidationError)
                    .WithMany(p => p.DomesticClearingPaymentLineValidationErrors)
                    .HasForeignKey(d => d.ValidationErrorId)
                    .HasConstraintName("FK_DomesticClearing_PaymentLineValidationError_DomesticClearing_ValidationError");
            });

            modelBuilder.Entity<DomesticClearingPaymentLog>(entity =>
            {
                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentLogs)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentLog_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingPaymentMethod>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Direction)
                    .WithMany(p => p.DomesticClearingPaymentMethods)
                    .HasForeignKey(d => d.DirectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentMethod_DomesticClearing_Direction");

                entity.HasOne(d => d.Source)
                    .WithMany(p => p.DomesticClearingPaymentMethods)
                    .HasForeignKey(d => d.SourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_PaymentMethod_DomesticClearing_Source");
            });

            modelBuilder.Entity<DomesticClearingPaymentValidationError>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPaymentValidationErrors)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_PaymentValidationError_DomesticClearing_Payment");

                entity.HasOne(d => d.ValidationError)
                    .WithMany(p => p.DomesticClearingPaymentValidationErrors)
                    .HasForeignKey(d => d.ValidationErrorId)
                    .HasConstraintName("FK_DomesticClearing_PaymentValidationError_DomesticClearing_ValidationError");
            });

            modelBuilder.Entity<DomesticClearingPresentment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.DomesticClearingPresentments)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_DomesticClearing_Presentment_DomesticClearing_Payment");
            });

            modelBuilder.Entity<DomesticClearingProduct>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingProducts)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Product_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingProductLog>(entity =>
            {
                entity.HasOne(d => d.Product)
                    .WithMany(p => p.DomesticClearingProductLogs)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_ProductLog_DomesticClearing_Product");
            });

            modelBuilder.Entity<DomesticClearingRecBatch>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecType)
                    .WithMany(p => p.DomesticClearingRecBatches)
                    .HasForeignKey(d => d.RecTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Batch_DomesticClearing_Rec_Type");
            });

            modelBuilder.Entity<DomesticClearingRecCollateGo>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollateGos)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_GO_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollateGos)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_GO_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollateInwardClearing>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollateInwardClearings)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_InwardClearing_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollateInwardClearings)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_InwardClearing_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollatePayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollatePayments)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_Payment_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollatePayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollatePaymentCreation>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecCollatePaymentCreations)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_PaymentCreation_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollatePaymentCreations)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collate_PaymentCreation_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoEuconDemandLogAccount>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoEuconDemandLogAccounts)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_EUCOnDemandLogAccount_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoEuconDemandLogCommon>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoEuconDemandLogCommons)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_EUCOnDemandLogCommon_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGasGoCredit>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGasGoCredits)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GasGoCredit_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGasGoDebit>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGasGoDebits)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GasGoDebit_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectGoGoposting>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectGoGopostings)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_GO_GOPosting_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectInwardClearingAnzSummary>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectInwardClearingAnzSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_InwardClearing_AnzSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectInwardClearingPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectInwardClearingPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_InwardClearing_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentBulkPaymentSummary>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentBulkPaymentSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_BulkPaymentSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationBulkPaymentSummary>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationBulkPaymentSummaries)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_BulkPaymentSummary_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionAttachment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetail>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_MultiPurposeInstructionDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentCreationPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentCreationPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_PaymentCreation_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentDereplyDetail>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentDereplyDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_DEReplyDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentDereplyHeader>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentDereplyHeaders)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_DEReplyHeader_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentMultiPurposeInstructionAttachments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionAttachment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentMultiPurposeInstructionDetail>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentMultiPurposeInstructionDetails)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_MultiPurposeInstructionDetail_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollectPaymentPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecCollection)
                    .WithMany(p => p.DomesticClearingRecCollectPaymentPayments)
                    .HasForeignKey(d => d.RecCollectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Collect_Payment_Payment_DomesticClearing_Rec_Collection");
            });

            modelBuilder.Entity<DomesticClearingRecCollection>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecSource)
                    .WithMany(p => p.DomesticClearingRecCollections)
                    .HasForeignKey(d => d.RecSourceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Batch_DomesticClearing_Rec_Source");
            });

            modelBuilder.Entity<DomesticClearingRecKeyStatus>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingRecRecGo>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecGos)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecGos)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecGos)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_GO_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecInwardClearing>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecInwardClearings)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_InwardClearing_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecPayments)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_Payment_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecRecPaymentCreation>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.RecBatch)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecBatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_Batch");

                entity.HasOne(d => d.RecKeyStatus)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecKeyStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_KeyStatus");

                entity.HasOne(d => d.RecValueStatus)
                    .WithMany(p => p.DomesticClearingRecRecPaymentCreations)
                    .HasForeignKey(d => d.RecValueStatusId)
                    .HasConstraintName("FK_DomesticClearing_Rec_Rec_PaymentCreation_DomesticClearing_Rec_ValueStatus");
            });

            modelBuilder.Entity<DomesticClearingRecSource>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingRecType>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingRecValueStatus>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingRemitter>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingRemitters)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_Remitter_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingRemitterLog>(entity =>
            {
                entity.HasOne(d => d.Remitter)
                    .WithMany(p => p.DomesticClearingRemitterLogs)
                    .HasForeignKey(d => d.RemitterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_RemitterLog_DomesticClearing_Remitter");
            });

            modelBuilder.Entity<DomesticClearingReturnRefusalCode>(entity =>
            {
                entity.HasKey(e => e.ReturnRefusalCodeId)
                    .HasName("PK_DomesticClearing_ReturnCode");

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingSource>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingStatus>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DomesticClearingUnitCodeAccount>(entity =>
            {
                entity.HasKey(e => e.UnitCodeAccountId)
                    .HasName("PK_DomesticClearing_UnitCodeAccounts");

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.DomesticClearingUnitCodeAccounts)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_DomesticClearing_UnitCodeAccounts_DomesticClearing_Status");
            });

            modelBuilder.Entity<DomesticClearingUnitCodeAccountLog>(entity =>
            {
                entity.HasOne(d => d.UnitCodeAccount)
                    .WithMany(p => p.DomesticClearingUnitCodeAccountLogs)
                    .HasForeignKey(d => d.UnitCodeAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DomesticClearing_UnitCodeAccountLog_DomesticClearing_UnitCodeAccount");
            });

            modelBuilder.Entity<DomesticClearingValidationError>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DreamsUploadException>(entity =>
            {
                entity.Property(e => e.ExceptionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EndOfDayStart>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EucCcyCode>(entity =>
            {
                entity.HasKey(e => new { e.CcyCd, e.BranchNo });
            });

            modelBuilder.Entity<EucCollateralCode>(entity =>
            {
                entity.HasKey(e => new { e.CollateralCd, e.BranchNo });
            });

            modelBuilder.Entity<EucCustAttributeCode>(entity =>
            {
                entity.HasKey(e => new { e.AttributeCd, e.BranchNo });
            });

            modelBuilder.Entity<EucCustomerAccountNo>(entity =>
            {
                entity.HasKey(e => new { e.CustAbbr, e.ActCd, e.ActNo, e.IbfId, e.CcyCd, e.StatusCd });

                entity.Property(e => e.CustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd).HasDefaultValueSql("('')");

                entity.Property(e => e.ActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId).HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<EucDeptCode>(entity =>
            {
                entity.HasKey(e => new { e.DeptCd, e.BranchNo });
            });

            modelBuilder.Entity<EucIndustryCode>(entity =>
            {
                entity.HasKey(e => new { e.IndustryCd, e.BranchNo });
            });

            modelBuilder.Entity<EucTaxCode>(entity =>
            {
                entity.HasKey(e => new { e.TaxId, e.TaxCd, e.BranchNo });
            });

            modelBuilder.Entity<FuturesRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });
            });

            modelBuilder.Entity<FxConfirmationSearchDto>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<FxConfirmationStatus>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<FxRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy });

                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<FxSettlementInf>(entity =>
            {
                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankToBankInf).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OperationId).HasDefaultValueSql("(1)");

                entity.Property(e => e.PayAccBank).HasDefaultValueSql("('')");

                entity.Property(e => e.PayBeneficiary).HasDefaultValueSql("('')");

                entity.Property(e => e.PayCcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.PayCustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.PayHoFavorMt202).HasDefaultValueSql("('')");

                entity.Property(e => e.PayOrderingCustomer).HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherCr).HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherDr).HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherMethod).HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherRmtFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails1).HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails2).HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails3).HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails4).HasDefaultValueSql("('')");

                entity.Property(e => e.PayRecBank).HasDefaultValueSql("('')");

                entity.Property(e => e.PayReceiverCorres).HasDefaultValueSql("('')");

                entity.Property(e => e.PaySenderCorres).HasDefaultValueSql("('')");

                entity.Property(e => e.RecCcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.RecHoFavorMt202).HasDefaultValueSql("('')");

                entity.Property(e => e.RecIntermediaryBank).HasDefaultValueSql("('')");

                entity.Property(e => e.RecKihyoIrai).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOrderingBank).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOrderingCustomer).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherCr).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherDr).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherMethod).HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherRmtFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.RecRecBank).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd).HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithOne(p => p.FxSettlementInf)
                    .HasForeignKey<FxSettlementInf>(d => d.RefNo)
                    .HasConstraintName("FK_FX_TRANSACTION_FX_SETTLEMENT_INF");
            });

            modelBuilder.Entity<FxTransaction>(entity =>
            {
                entity.Property(e => e.AccountEntry).HasDefaultValueSql("('')");

                entity.Property(e => e.AccrualFrom).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AccrualTo).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ActAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd).HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy).HasDefaultValueSql("(0)");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Addressee).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Authorized).HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo).HasDefaultValueSql("('751')");

                entity.Property(e => e.Broker).HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.Code56).HasDefaultValueSql("('')");

                entity.Property(e => e.Code57).HasDefaultValueSql("('')");

                entity.Property(e => e.Code57a).HasDefaultValueSql("('')");

                entity.Property(e => e.Code58).HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAmt).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyBal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyTtb).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractDateOpe).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ContractDateValue).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.CoverPoFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode).HasDefaultValueSql("('')");

                entity.Property(e => e.Dealer).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.DelivaryDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DelivaryThru).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DivisionCd).HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAmt).HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyBal).HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyCd).HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyTtb).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExchangeRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExecutionRefNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.GipDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId).HasDefaultValueSql("('')");

                entity.Property(e => e.InternalRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OptionsFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.RemarksTrd).HasDefaultValueSql("('')");

                entity.Property(e => e.Revise).HasDefaultValueSql("('')");

                entity.Property(e => e.SchemeNo).HasDefaultValueSql("('')");

                entity.Property(e => e.SetInstruction).HasDefaultValueSql("('')");

                entity.Property(e => e.SettlementValueDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Spread).HasDefaultValueSql("(0)");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd).HasDefaultValueSql("('')");

                entity.Property(e => e.SwapRefNo).HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.CustomerMaster)
                    .WithMany(p => p.FxTransactions)
                    .HasForeignKey(d => new { d.BranchNo, d.CustAbbr })
                    .HasConstraintName("FK_FX_TRANSACTION_CUSTOMER_MASTER");
            });

            modelBuilder.Entity<FxTransactionExt>(entity =>
            {
                entity.Property(e => e.ContractCcyAbbrOrig).IsFixedLength();

                entity.Property(e => e.EquivCcyAbbrOrig).IsFixedLength();
            });

            modelBuilder.Entity<Fxfarbitrage>(entity =>
            {
                entity.Property(e => e.FwdbghCcy).IsFixedLength();

                entity.Property(e => e.FwdsoldCcy).IsFixedLength();

                entity.Property(e => e.Ibf).IsFixedLength();

                entity.Property(e => e.IfwdBghCcy).IsFixedLength();

                entity.Property(e => e.IfwdSoldCcy).IsFixedLength();

                entity.Property(e => e.LendPrinCcy).IsFixedLength();

                entity.Property(e => e.SpotBghCcy).IsFixedLength();

                entity.Property(e => e.SpotSoldCcy).IsFixedLength();

                entity.Property(e => e.TakePrinCcy).IsFixedLength();
            });

            modelBuilder.Entity<Fxfccy>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.CcyCd).IsFixedLength();
            });

            modelBuilder.Entity<Fxfcust>(entity =>
            {
                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.HasOne(d => d.MxGuideCustDetail)
                    .WithMany(p => p.Fxfcusts)
                    .HasForeignKey(d => d.MxGuideCustDetailId)
                    .HasConstraintName("FK_FXFCustMxGuideCustDetail");
            });

            modelBuilder.Entity<FxfdealType>(entity =>
            {
                entity.HasKey(e => e.DealtypeId)
                    .HasName("PK_FXFDEALTYPE")
                    .IsClustered(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Fxfswift>(entity =>
            {
                entity.Property(e => e.RecordKind).IsFixedLength();
            });

            modelBuilder.Entity<GbaseReferenceNo>(entity =>
            {
                entity.HasKey(e => new { e.DealTypeCode, e.ReferenceCode })
                    .HasName("PK_GBASE_Reference_Number");

                entity.Property(e => e.DealTypeCode).IsFixedLength();
            });

            modelBuilder.Entity<GbaseReferenceNoLastUsed>(entity =>
            {
                entity.Property(e => e.DealTypeCode).IsFixedLength();
            });

            modelBuilder.Entity<GlinkQueueManagerAction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GuideBisRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<GuideDepositRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<GuideExchangeRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<GuideLog>(entity =>
            {
                entity.Property(e => e.AuditDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GuideRevaluationRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<GuideSwapRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<InterbankAccountNo>(entity =>
            {
                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<IspsLotusNotesExtract>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IspsMurexGeneratorMapper>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IspsStpTradeType>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MassApprovalInput>(entity =>
            {
                entity.Property(e => e.Identifier).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MassTransaction>(entity =>
            {
                entity.Property(e => e.TranId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MgeBtransactionConfirmation>(entity =>
            {
                entity.Property(e => e.AddDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<MoneyMarketTicket>(entity =>
            {
                entity.Property(e => e.Ibf).IsFixedLength();
            });

            modelBuilder.Entity<MoneyMarketTicketExt>(entity =>
            {
                entity.Property(e => e.MmticketId).ValueGeneratedNever();

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Mmticket)
                    .WithOne(p => p.MoneyMarketTicketExt)
                    .HasForeignKey<MoneyMarketTicketExt>(d => d.MmticketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MoneyMarketTicket_Ext_MoneyMarketTicket");
            });

            modelBuilder.Entity<MsmqMessageDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MsmqMessageHistoryDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MxCtpyTypeAttrCode>(entity =>
            {
                entity.HasOne(d => d.CounterpartyTypeNavigation)
                    .WithMany(p => p.MxCtpyTypeAttrCodes)
                    .HasForeignKey(d => d.CounterpartyType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCtpyTypeAttrCode_MxCounterpartyType");

                entity.HasOne(d => d.EucCustAttributeCode)
                    .WithMany(p => p.MxCtpyTypeAttrCodes)
                    .HasForeignKey(d => new { d.AttributeCode, d.Branch })
                    .HasConstraintName("FK_MxCtpyTypeAttrCode_EucCustAttributeCode");
            });

            modelBuilder.Entity<MxCustCounterpartyType>(entity =>
            {
                entity.HasOne(d => d.CounterpartyType)
                    .WithMany(p => p.MxCustCounterpartyTypes)
                    .HasForeignKey(d => d.CounterpartyTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCustCounterpartyType_MxCounterpartyType");

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.MxCustCounterpartyTypes)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MxCustCounterpartyType_FXFCust");
            });

            modelBuilder.Entity<MxEucBalanceEvent>(entity =>
            {
                entity.Property(e => e.Currency).IsFixedLength();
            });

            modelBuilder.Entity<MxGuideCustDetail>(entity =>
            {
                entity.HasOne(d => d.MxCustomerEventNavigation)
                    .WithMany(p => p.MxGuideCustDetails)
                    .HasForeignKey(d => d.MxCustomerEvent)
                    .HasConstraintName("FK_MxGuideCustDetail_MxCustomerEvent");

                entity.HasOne(d => d.MxCustomerStatusNavigation)
                    .WithMany(p => p.MxGuideCustDetails)
                    .HasForeignKey(d => d.MxCustomerStatus)
                    .HasConstraintName("FK_MxGuideCustDetail_MxCustomerStatus");
            });

            modelBuilder.Entity<MxInboundEvent>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_MxInboundMessage");
            });

            modelBuilder.Entity<MxInboundEventLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_MxInboundMessageLog");
            });

            modelBuilder.Entity<MxInboundMessageStatus>(entity =>
            {
                entity.Property(e => e.StatusId).ValueGeneratedNever();
            });

            modelBuilder.Entity<MxIspsTrade>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusUpdateTime).HasDefaultValueSql("(getdate())");
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

            modelBuilder.Entity<Opd37FileProcessHistory>(entity =>
            {
                entity.HasKey(e => e.FileProcessHistoryId)
                    .HasName("PK__OPD-37_F__B205DD24757B891F");

                entity.Property(e => e.ProcessDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Opd37LoanInterestRateChangeExport>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Opd37LoanInterestRateRetraceExport>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Opd37LoanRaw>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Opd37SwapExport>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Opd37SwapRaw>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Password, e.PwdChangeDt });
            });

            modelBuilder.Entity<PaymentControlAccordConfirmation>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlAccordConfirmations)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_AccordConfirmation_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMatchFx>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMatchFxes)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MatchFX_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMatchMoneyMarket>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMatchMoneyMarkets)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MatchMoneyMarket_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlMisysConfirmation>(entity =>
            {
                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlMisysConfirmations)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_MisysConfirmation_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.WaitingAckNack).HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingConfirmation).HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingPayment).HasDefaultValueSql("((1))");

                entity.Property(e => e.WaitingSwiftPayment).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.ProductReference)
                    .WithMany(p => p.PaymentControlPayments)
                    .HasForeignKey(d => d.ProductReferenceId)
                    .HasConstraintName("FK_PaymentControl_Payment_PaymentControl_ProductReference");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PaymentControlPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_PaymentControl_Payment_PaymentControl_Status");
            });

            modelBuilder.Entity<PaymentControlPaymentLog>(entity =>
            {
                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlPaymentLogs)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_PaymentLog_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlProduct>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PaymentControlProductReference>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.PaymentControlProductReferences)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_ProductReference_PaymentControl_Product");
            });

            modelBuilder.Entity<PaymentControlRemittance>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlRemittances)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_Remittance_PaymentControl_Payment");
            });

            modelBuilder.Entity<PaymentControlRtgsSwiftCodeTranslation>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PaymentControlStatus>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PaymentControlSwiftAck>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentControlSwiftAcks)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftAck_PaymentControl_Payment");

                entity.HasOne(d => d.SwiftPayment)
                    .WithMany(p => p.PaymentControlSwiftAcks)
                    .HasForeignKey(d => d.SwiftPaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftAck_PaymentControl_SwiftPayment");
            });

            modelBuilder.Entity<PaymentControlSwiftPayment>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.PaymentNavigation)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.PaymentId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_Payment");

                entity.HasOne(d => d.ProductReference)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.ProductReferenceId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_ProductReference");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.PaymentControlSwiftPayments)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_PaymentControl_SwiftPayment_PaymentControl_Status");
            });

            modelBuilder.Entity<PaymentControlSwiftPaymentLog>(entity =>
            {
                entity.HasOne(d => d.SwiftPayment)
                    .WithMany(p => p.PaymentControlSwiftPaymentLogs)
                    .HasForeignKey(d => d.SwiftPaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentControl_SwiftPaymentLog_PaymentControl_SwiftPayment");
            });

            modelBuilder.Entity<RacfSystemId>(entity =>
            {
                entity.HasKey(e => new { e.IdType, e.SystemId });
            });

            modelBuilder.Entity<RamBaseRecord>(entity =>
            {
                entity.Property(e => e.DeletedAmt).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<RatesGbaseUploadCriterion>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.Ccy });
            });

            modelBuilder.Entity<RatesGbaseUploadCtl>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.OprDate, e.Ccy });

                entity.Property(e => e.AcuStatus).HasDefaultValueSql("('P')");

                entity.Property(e => e.AcuTransStatus).HasDefaultValueSql("('N')");

                entity.Property(e => e.BuStatus).HasDefaultValueSql("('P')");

                entity.Property(e => e.BuTransStatus).HasDefaultValueSql("('N')");

                entity.Property(e => e.GbaseMsg).HasDefaultValueSql("('')");

                entity.Property(e => e.UploadedBy).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<RevaluationRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Days });

                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.RecStatus).IsFixedLength();
            });

            modelBuilder.Entity<RmbDefault>(entity =>
            {
                entity.Property(e => e.DefultFlg).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<SecurityGroup>(entity =>
            {
                entity.Property(e => e.CreatedAmendedDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SecurityGroupFunction>(entity =>
            {
                entity.HasKey(e => new { e.SgIdentifier, e.SfIdentifier });
            });

            modelBuilder.Entity<SettlementCorpCustDefault>(entity =>
            {
                entity.Property(e => e.AccBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.AdviceRecFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.BeneBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo).HasDefaultValueSql("((751))");

                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("((1))");

                entity.Property(e => e.IntermediaryBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingBank).HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingCustomer).HasDefaultValueSql("('')");

                entity.Property(e => e.PayActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType).HasDefaultValueSql("('')");

                entity.Property(e => e.PayMethod).HasDefaultValueSql("('')");

                entity.Property(e => e.PayRmtFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.PriortyFlg).HasDefaultValueSql("((2))");

                entity.Property(e => e.RecActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.RecCorres).HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType).HasDefaultValueSql("('')");

                entity.Property(e => e.RecMethod).HasDefaultValueSql("('')");

                entity.Property(e => e.RecRmtFlg).HasDefaultValueSql("('')");

                entity.Property(e => e.RecordKind).HasDefaultValueSql("((2))");

                entity.Property(e => e.SenderCorres).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<SettlementCorpCustDefault2>(entity =>
            {
                entity.Property(e => e.CorpCustId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SettlementInf>(entity =>
            {
                entity.Property(e => e.AccBankActno).HasDefaultValueSql("('')");

                entity.Property(e => e.AccBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AdviceRecFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.AdviceRecLimit).HasDefaultValueSql("(0)");

                entity.Property(e => e.AuthorizeBy).HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.BankInf).HasDefaultValueSql("('')");

                entity.Property(e => e.BankInfFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.BeneBankActno).HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo).HasDefaultValueSql("('751')");

                entity.Property(e => e.ConfirmationFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.ConfirmationSwiftId).HasDefaultValueSql("('')");

                entity.Property(e => e.CoverPoFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.CustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy).HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription).HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus).HasDefaultValueSql("('')");

                entity.Property(e => e.IntermediaryBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy).HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OcnnectFlg).HasDefaultValueSql("('N')");

                entity.Property(e => e.OpeDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayActCd).HasDefaultValueSql("('')");

                entity.Property(e => e.PayActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType).HasDefaultValueSql("('202')");

                entity.Property(e => e.PayMethod).HasDefaultValueSql("('SW')");

                entity.Property(e => e.PayRmtFlg).HasDefaultValueSql("('A')");

                entity.Property(e => e.PaySettlCode).HasDefaultValueSql("('')");

                entity.Property(e => e.PriortyFlg).HasDefaultValueSql("('02')");

                entity.Property(e => e.RecActCd).HasDefaultValueSql("('')");

                entity.Property(e => e.RecActNo).HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankBrActno).HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankHoActno).HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId).HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr).HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType).HasDefaultValueSql("('210')");

                entity.Property(e => e.RecMethod).HasDefaultValueSql("('SW')");

                entity.Property(e => e.RecRmtFlg).HasDefaultValueSql("('M')");

                entity.Property(e => e.RecSettlCode).HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks).HasDefaultValueSql("('')");

                entity.Property(e => e.Status).HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd).HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SettlementInterbankDefault>(entity =>
            {
                entity.Property(e => e.AccountNo).HasDefaultValueSql("('')");

                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("((1))");

                entity.Property(e => e.ObuAccountNo).HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SpotRateUsdEquiv>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy })
                    .HasName("PK_SPOT_RATE");

                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SwapRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.ImportedBy).HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength();
            });

            modelBuilder.Entity<SystemModuleGroup>(entity =>
            {
                entity.HasKey(e => new { e.SmIdentifier, e.SgIdentifier });
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.Property(e => e.SettingId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TempRevaluationRate>(entity =>
            {
                entity.Property(e => e.Ccy).IsFixedLength();

                entity.Property(e => e.RecStatus).IsFixedLength();
            });

            modelBuilder.Entity<TransactionKindAdvancedNotice>(entity =>
            {
                entity.Property(e => e.TransactionKind).IsFixedLength();
            });

            modelBuilder.Entity<TransactionKindMoneyMarket>(entity =>
            {
                entity.Property(e => e.BuySell).HasDefaultValueSql("('')");

                entity.Property(e => e.TransactionKind).IsFixedLength();
            });

            modelBuilder.Entity<TransactionKindOverrideCode>(entity =>
            {
                entity.Property(e => e.TransactionKind).IsFixedLength();
            });

            modelBuilder.Entity<UserSecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SgIdentifier });
            });

            modelBuilder.Entity<UsersExt>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersExt)
                    .HasForeignKey<UsersExt>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERS_Ext_USERS");
            });

            modelBuilder.Entity<VgasGeneraloperation>(entity =>
            {
                entity.ToView("VGAS_GENERALOPERATION", "dbo");
            });

            modelBuilder.Entity<VgasSelectwebgastransaction>(entity =>
            {
                entity.ToView("VGAS_SELECTWEBGASTRANSACTIONS", "dbo");
            });

            modelBuilder.Entity<ViewEucBankInfPrepare1>(entity =>
            {
                entity.ToView("VIEW_EUC_BANK_INF_PREPARE1", "dbo");
            });

            modelBuilder.Entity<ViewEucBankInfPrepare2>(entity =>
            {
                entity.ToView("VIEW_EUC_BANK_INF_PREPARE2", "dbo");
            });

            modelBuilder.Entity<ViewEucCcyCode>(entity =>
            {
                entity.ToView("VIEW_EUC_CCY_CODE", "dbo");
            });

            modelBuilder.Entity<ViewEucCustomerAccountNo>(entity =>
            {
                entity.ToView("VIEW_EUC_CUSTOMER_ACCOUNT_NO", "dbo");
            });

            modelBuilder.Entity<ViewEucCustomerMaster>(entity =>
            {
                entity.ToView("VIEW_EUC_CUSTOMER_MASTER", "dbo");
            });

            modelBuilder.Entity<ViewFxsystemCreditparent>(entity =>
            {
                entity.ToView("VIEW_ FXSYSTEM_CREDITPARENT", "dbo");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<ViewGipFxTransaction>(entity =>
            {
                entity.ToView("VIEW_GIP_FX_TRANSACTION", "dbo");
            });

            modelBuilder.Entity<ViewGuideCorpCustomerAccount>(entity =>
            {
                entity.ToView("VIEW_GUIDE_CORP_CUSTOMER_ACCOUNT", "dbo");
            });

            modelBuilder.Entity<ViewGuideCustomerMasterAll>(entity =>
            {
                entity.ToView("VIEW_GUIDE_CUSTOMER_MASTER_ALL", "dbo");
            });

            modelBuilder.Entity<ViewGuideFxTransaction>(entity =>
            {
                entity.ToView("VIEW_GUIDE_FX_TRANSACTION", "dbo");
            });

            modelBuilder.Entity<ViewMmTicketDetail>(entity =>
            {
                entity.ToView("VIEW_MM_TICKET_DETAILS", "dbo");

                entity.Property(e => e.Ibf).IsFixedLength();
            });

            modelBuilder.Entity<ViewRamReconSummary>(entity =>
            {
                entity.ToView("VIEW_RAM_RECON_SUMMARY", "dbo");
            });

            modelBuilder.Entity<ViewRatesGuideBisRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_BIS_RATE", "dbo");

                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<ViewRatesGuideDepositRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_DEPOSIT_RATE", "dbo");

                entity.Property(e => e.Ccy).IsFixedLength();
            });

            modelBuilder.Entity<ViewRatesGuideSwapRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_SWAP_RATE", "dbo");

                entity.Property(e => e.Ccy).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
