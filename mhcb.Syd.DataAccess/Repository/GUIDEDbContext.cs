using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.GUIDE;

#nullable disable

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
        public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }
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
        public virtual DbSet<CustomerMasterBakMurexRelease> CustomerMasterBakMurexReleases { get; set; }
        public virtual DbSet<CustomerMasterLog> CustomerMasterLogs { get; set; }
        public virtual DbSet<CustomerMasterModCodesMurexRelease> CustomerMasterModCodesMurexReleases { get; set; }
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
        public virtual DbSet<FxRate> FxRates { get; set; }
        public virtual DbSet<FxSettlementInf> FxSettlementInfs { get; set; }
        public virtual DbSet<FxTransaction> FxTransactions { get; set; }
        public virtual DbSet<FxTransactionConfirmation> FxTransactionConfirmations { get; set; }
        public virtual DbSet<FxTransactionConfirmationStatus> FxTransactionConfirmationStatuses { get; set; }
        public virtual DbSet<FxTransactionExt> FxTransactionExts { get; set; }
        public virtual DbSet<FxTransactionExtBakMurexRelease> FxTransactionExtBakMurexReleases { get; set; }
        public virtual DbSet<FxTransactionModCodesMurexRelease> FxTransactionModCodesMurexReleases { get; set; }
        public virtual DbSet<FxTransactionUploadGipStatus> FxTransactionUploadGipStatuses { get; set; }
        public virtual DbSet<Fxfarbitrage> Fxfarbitrages { get; set; }
        public virtual DbSet<FxfbusCenter> FxfbusCenters { get; set; }
        public virtual DbSet<Fxfcalendar> Fxfcalendars { get; set; }
        public virtual DbSet<Fxfccy> Fxfccies { get; set; }
        public virtual DbSet<FxfcreditCustType> FxfcreditCustTypes { get; set; }
        public virtual DbSet<FxfcreditParent> FxfcreditParents { get; set; }
        public virtual DbSet<Fxfcust> Fxfcusts { get; set; }
        public virtual DbSet<FxfcustBakMurexRelease> FxfcustBakMurexReleases { get; set; }
        public virtual DbSet<Fxfcustthreshold> Fxfcustthresholds { get; set; }
        public virtual DbSet<FxfdealType> FxfdealTypes { get; set; }
        public virtual DbSet<Fxfinstitution> Fxfinstitutions { get; set; }
        public virtual DbSet<Fxfswift> Fxfswifts { get; set; }
        public virtual DbSet<FxfswiftModCodesMurexRelease> FxfswiftModCodesMurexReleases { get; set; }
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
        public virtual DbSet<MassApprovalInput> MassApprovalInputs { get; set; }
        public virtual DbSet<MassDreamsApprovalAccess> MassDreamsApprovalAccesses { get; set; }
        public virtual DbSet<MassGbaseMenuAccess> MassGbaseMenuAccesses { get; set; }
        public virtual DbSet<MassTransaction> MassTransactions { get; set; }
        public virtual DbSet<MassTransactionHistory> MassTransactionHistories { get; set; }
        public virtual DbSet<MgeBcustomer> MgeBcustomers { get; set; }
        public virtual DbSet<MgeBreceivedFile> MgeBreceivedFiles { get; set; }
        public virtual DbSet<MgeBtransactionConfirmation> MgeBtransactionConfirmations { get; set; }
        public virtual DbSet<MgeBtransactionDataControl> MgeBtransactionDataControls { get; set; }
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
        public virtual DbSet<MxCustCounterpartyTypeBakMurexRelease> MxCustCounterpartyTypeBakMurexReleases { get; set; }
        public virtual DbSet<MxCustomerEvent> MxCustomerEvents { get; set; }
        public virtual DbSet<MxCustomerStatus> MxCustomerStatuses { get; set; }
        public virtual DbSet<MxEucBalanceEvent> MxEucBalanceEvents { get; set; }
        public virtual DbSet<MxGuideCustDetail> MxGuideCustDetails { get; set; }
        public virtual DbSet<MxGuideCustDetailBakMurexRelease> MxGuideCustDetailBakMurexReleases { get; set; }
        public virtual DbSet<MxInboundEvent> MxInboundEvents { get; set; }
        public virtual DbSet<MxInboundEventLog> MxInboundEventLogs { get; set; }
        public virtual DbSet<MxInboundMessageStatus> MxInboundMessageStatuses { get; set; }
        public virtual DbSet<MxIndustryCodeSector> MxIndustryCodeSectors { get; set; }
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
                //To protect potentially sensitive information in your connection string,
                //you should move it out of source code.
                //You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration
                //- see https://go.microsoft.com/fwlink/?linkid=2131148.
                //For more guidance on storing connection strings,
                //see http://go.microsoft.com/fwlink/?LinkId=723263.

                //optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=GUIDE;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AreaCode>(entity =>
            {
                entity.Property(e => e.AreaCode1).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
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

            modelBuilder.Entity<AspNetUserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AuditEvent>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ExceptionFlag).IsUnicode(false);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.Property(e => e.AppName).IsUnicode(false);

                entity.Property(e => e.AuditDesc).IsUnicode(false);

                entity.Property(e => e.NewValue).IsUnicode(false);

                entity.Property(e => e.OriginalValue).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.TableName).IsUnicode(false);

                entity.Property(e => e.TransNo).IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<AuditMurexGuideRateChange>(entity =>
            {
                entity.Property(e => e.Detail).IsUnicode(false);

                entity.Property(e => e.RateType).IsUnicode(false);
            });

            modelBuilder.Entity<AuditTrail>(entity =>
            {
                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<BankInf>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.SettlBranchNo });

                entity.Property(e => e.SwiftId).IsUnicode(false);

                entity.Property(e => e.SettlBranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.Acronym)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.ChapsSortCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsAba)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ChipsUid)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorBankCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FedId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AU')");

                entity.Property(e => e.MhcbBrAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.NameAddr1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NameAddr4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SwiftFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<BankInfCorr>(entity =>
            {
                entity.HasKey(e => new { e.SwiftId, e.CcyCd, e.SettlBranchNo });

                entity.Property(e => e.SwiftId).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.SettlBranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankInfId).ValueGeneratedOnAdd();

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankActno)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MmSettlBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.S)
                    .WithMany(p => p.BankInfCorrs)
                    .HasForeignKey(d => new { d.SwiftId, d.SettlBranchNo })
                    .HasConstraintName("FK_BANK_INF_BANK_INF_CORR");
            });

            modelBuilder.Entity<BaseRate>(entity =>
            {
                entity.HasKey(e => new { e.OperationDate, e.StartDate, e.Ccy, e.Source, e.Duration });

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Source).IsUnicode(false);

                entity.Property(e => e.ImportedBy).IsUnicode(false);

                entity.Property(e => e.RecStatus).IsUnicode(false);
            });

            modelBuilder.Entity<BisRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);

                entity.Property(e => e.ImportedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<BusinessConditionA>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<BusinessConditionB>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<BusinessConditionC>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<CcyCodeTable>(entity =>
            {
                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.Mark3Cd).IsUnicode(false);

                entity.Property(e => e.SetpsCd).IsUnicode(false);

                entity.Property(e => e.SwiftCd).IsUnicode(false);
            });

            modelBuilder.Entity<CmpCode>(entity =>
            {
                entity.Property(e => e.CmpCode1).ValueGeneratedNever();

                entity.Property(e => e.CmpAbbr).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<ConfigVal>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Value).IsUnicode(false);
            });

            modelBuilder.Entity<CorpSettlementAccount>(entity =>
            {
                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.AdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.BankFlg).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CoverPoFlg).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayMessageType).IsUnicode(false);

                entity.Property(e => e.PayMethod).IsUnicode(false);

                entity.Property(e => e.PayRmtFlg).IsUnicode(false);

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.PriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecBankId).IsUnicode(false);

                entity.Property(e => e.RecMessageType).IsUnicode(false);

                entity.Property(e => e.RecMethod).IsUnicode(false);

                entity.Property(e => e.RecRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<CurrExchangeRate>(entity =>
            {
                entity.Property(e => e.FromCcyCode).IsUnicode(false);

                entity.Property(e => e.ToCcyCode).IsUnicode(false);
            });

            modelBuilder.Entity<CustAccountNo>(entity =>
            {
                entity.Property(e => e.ActId).ValueGeneratedNever();

                entity.Property(e => e.ActCd).IsUnicode(false);

                entity.Property(e => e.ActDescription).IsUnicode(false);

                entity.Property(e => e.ActNo).IsUnicode(false);

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Ubo).IsUnicode(false);
            });

            modelBuilder.Entity<CustGradeCode>(entity =>
            {
                entity.Property(e => e.GradeCode).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.GradeAbbr).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.HasKey(e => new { e.BranchNo, e.CustAbbr });

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.CustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Address)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Address2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AreaCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AttributeSubCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankGroupAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankManagementCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BoeCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BusinessCondition)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CfsIo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CollateralNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CompanyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CorresBankCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreditSupervision)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustId).HasDefaultValueSql("(0)");

                entity.Property(e => e.CustName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DepartmentCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DkbCompanyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GoodAssetFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GradeCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GroupCompanyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorAttrCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorCountry)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GuarantorName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IndustryCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.JapaneseFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.LastUpdated).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LicenceFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocalIndustryCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.LocationCountry)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.MailCountry)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mark3Cd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Nationality)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.NextReviewDate).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.ObligorSupervision)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OfficerCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OffshoreCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OpeningDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ParentCustCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ParentNationality)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RatingDate).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.RatingPoint).HasDefaultValueSql("((-1))");

                entity.Property(e => e.RatioOfInvDkb).HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvGvn).HasDefaultValueSql("(0)");

                entity.Property(e => e.RatioOfInvJp).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Remarks3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RetailActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StaffLoanFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Stance)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StepsCustCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SublimitBankAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TaxNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TelexNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<CustomerMasterBakMurexRelease>(entity =>
            {
                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.AreaCd).IsUnicode(false);

                entity.Property(e => e.AttributeCd).IsUnicode(false);

                entity.Property(e => e.AttributeSubCd).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.BankFlg).IsUnicode(false);

                entity.Property(e => e.BankGroupAbbr).IsUnicode(false);

                entity.Property(e => e.BankManagementCd).IsUnicode(false);

                entity.Property(e => e.BoeCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.BusinessCondition).IsUnicode(false);

                entity.Property(e => e.CfsIo).IsUnicode(false);

                entity.Property(e => e.CollateralNo).IsUnicode(false);

                entity.Property(e => e.CompanyCd).IsUnicode(false);

                entity.Property(e => e.CorresBankCd).IsUnicode(false);

                entity.Property(e => e.CreditSupervision).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.DkbCompanyCd).IsUnicode(false);

                entity.Property(e => e.GipDescription).IsUnicode(false);

                entity.Property(e => e.GipStatus).IsUnicode(false);

                entity.Property(e => e.GoodAssetFlg).IsUnicode(false);

                entity.Property(e => e.GradeCd).IsUnicode(false);

                entity.Property(e => e.GroupCd).IsUnicode(false);

                entity.Property(e => e.GroupCompanyCd).IsUnicode(false);

                entity.Property(e => e.GuarantorAttrCd).IsUnicode(false);

                entity.Property(e => e.GuarantorCd).IsUnicode(false);

                entity.Property(e => e.GuarantorCountry).IsUnicode(false);

                entity.Property(e => e.GuarantorName).IsUnicode(false);

                entity.Property(e => e.IndustryCd).IsUnicode(false);

                entity.Property(e => e.JapaneseFlg).IsUnicode(false);

                entity.Property(e => e.LicenceFlg).IsUnicode(false);

                entity.Property(e => e.LocalIndustryCd).IsUnicode(false);

                entity.Property(e => e.LocationCountry).IsUnicode(false);

                entity.Property(e => e.MailCountry).IsUnicode(false);

                entity.Property(e => e.Mark3Cd).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);

                entity.Property(e => e.Nationality).IsUnicode(false);

                entity.Property(e => e.ObligorSupervision).IsUnicode(false);

                entity.Property(e => e.OfficerCd).IsUnicode(false);

                entity.Property(e => e.OffshoreCd).IsUnicode(false);

                entity.Property(e => e.ParentCustCd).IsUnicode(false);

                entity.Property(e => e.ParentNationality).IsUnicode(false);

                entity.Property(e => e.Remarks1).IsUnicode(false);

                entity.Property(e => e.Remarks2).IsUnicode(false);

                entity.Property(e => e.Remarks3).IsUnicode(false);

                entity.Property(e => e.RetailActNo).IsUnicode(false);

                entity.Property(e => e.StaffLoanFlg).IsUnicode(false);

                entity.Property(e => e.Stance).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.StepsCustCd).IsUnicode(false);

                entity.Property(e => e.SublimitBankAbbr).IsUnicode(false);

                entity.Property(e => e.TaxCd).IsUnicode(false);

                entity.Property(e => e.TaxId).IsUnicode(false);

                entity.Property(e => e.TaxNo).IsUnicode(false);

                entity.Property(e => e.TelNo).IsUnicode(false);

                entity.Property(e => e.TelexNo).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMasterLog>(entity =>
            {
                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.AreaCd).IsUnicode(false);

                entity.Property(e => e.AttributeCd).IsUnicode(false);

                entity.Property(e => e.AttributeSubCd).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.BankFlg).IsUnicode(false);

                entity.Property(e => e.BankGroupAbbr).IsUnicode(false);

                entity.Property(e => e.BankManagementCd).IsUnicode(false);

                entity.Property(e => e.BoeCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.BusinessCondition).IsUnicode(false);

                entity.Property(e => e.CfsIo).IsUnicode(false);

                entity.Property(e => e.CollateralNo).IsUnicode(false);

                entity.Property(e => e.CompanyCd).IsUnicode(false);

                entity.Property(e => e.CorresBankCd).IsUnicode(false);

                entity.Property(e => e.CreditSupervision).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.DkbCompanyCd).IsUnicode(false);

                entity.Property(e => e.GipDescription).IsUnicode(false);

                entity.Property(e => e.GipStatus).IsUnicode(false);

                entity.Property(e => e.GoodAssetFlg).IsUnicode(false);

                entity.Property(e => e.GradeCd).IsUnicode(false);

                entity.Property(e => e.GroupCd).IsUnicode(false);

                entity.Property(e => e.GroupCompanyCd).IsUnicode(false);

                entity.Property(e => e.GuarantorAttrCd).IsUnicode(false);

                entity.Property(e => e.GuarantorCd).IsUnicode(false);

                entity.Property(e => e.GuarantorCountry).IsUnicode(false);

                entity.Property(e => e.GuarantorName).IsUnicode(false);

                entity.Property(e => e.IndustryCd).IsUnicode(false);

                entity.Property(e => e.JapaneseFlg).IsUnicode(false);

                entity.Property(e => e.LicenceFlg).IsUnicode(false);

                entity.Property(e => e.LocalIndustryCd).IsUnicode(false);

                entity.Property(e => e.LocationCountry).IsUnicode(false);

                entity.Property(e => e.LogTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MailCountry).IsUnicode(false);

                entity.Property(e => e.Mark3Cd).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);

                entity.Property(e => e.Nationality).IsUnicode(false);

                entity.Property(e => e.ObligorSupervision).IsUnicode(false);

                entity.Property(e => e.OfficerCd).IsUnicode(false);

                entity.Property(e => e.OffshoreCd).IsUnicode(false);

                entity.Property(e => e.ParentCustCd).IsUnicode(false);

                entity.Property(e => e.ParentNationality).IsUnicode(false);

                entity.Property(e => e.Remarks1).IsUnicode(false);

                entity.Property(e => e.Remarks2).IsUnicode(false);

                entity.Property(e => e.Remarks3).IsUnicode(false);

                entity.Property(e => e.RetailActNo).IsUnicode(false);

                entity.Property(e => e.StaffLoanFlg).IsUnicode(false);

                entity.Property(e => e.Stance).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.StepsCustCd).IsUnicode(false);

                entity.Property(e => e.SublimitBankAbbr).IsUnicode(false);

                entity.Property(e => e.TaxCd).IsUnicode(false);

                entity.Property(e => e.TaxId).IsUnicode(false);

                entity.Property(e => e.TaxNo).IsUnicode(false);

                entity.Property(e => e.TelNo).IsUnicode(false);

                entity.Property(e => e.TelexNo).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);
            });

            modelBuilder.Entity<CustomerMasterModCodesMurexRelease>(entity =>
            {
                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.ParallelCustCode).IsUnicode(false);

                entity.Property(e => e.ProdBranchNo).IsUnicode(false);

                entity.Property(e => e.ProdCustCode).IsUnicode(false);
            });

            modelBuilder.Entity<DataDrivenSubscriptionSetting>(entity =>
            {
                entity.Property(e => e.Alias).IsUnicode(false);

                entity.Property(e => e.Comments)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EmailAddress)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EndOfDay).HasDefaultValueSql("(0)");

                entity.Property(e => e.FileExtn).HasDefaultValueSql("(1)");

                entity.Property(e => e.FileName)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Linked)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Path)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('\\\\mizweb01\\AppData$\\guide\\report')");

                entity.Property(e => e.PwExpired).HasDefaultValueSql("(1)");

                entity.Property(e => e.RenderFormat)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('MHTML')");

                entity.Property(e => e.ReportInclude)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('True')");

                entity.Property(e => e.Subject)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.WriteMode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AutoIncrement')");
            });

            modelBuilder.Entity<DealTypeGroup>(entity =>
            {
                entity.Property(e => e.FamilyCode).IsFixedLength(true);

                entity.Property(e => e.ThreeLetterCode).IsFixedLength(true);
            });

            modelBuilder.Entity<DealingSettlementOfficeMap>(entity =>
            {
                entity.HasKey(e => e.DealingSettlementOfficeId)
                    .HasName("PK_Dealing_SettlementOffice");

                entity.Property(e => e.CreatedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealingOfficeCode).IsUnicode(false);

                entity.Property(e => e.DealingOfficeLocation).IsUnicode(false);

                entity.Property(e => e.DealingOfficeName).IsUnicode(false);

                entity.Property(e => e.DealingSystem).IsUnicode(false);

                entity.Property(e => e.ModifiedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('DTS Upload')");

                entity.Property(e => e.ModifiedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SettlementOfficeCode).IsUnicode(false);
            });

            modelBuilder.Entity<DepositsRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Period)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1M')");

                entity.Property(e => e.ImportedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<DistributionChannel>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Channel).IsUnicode(false);
            });

            modelBuilder.Entity<DistributionPassword>(entity =>
            {
                entity.Property(e => e.CustomerAbbr).IsUnicode(false);

                entity.Property(e => e.CustomerBranch).IsUnicode(false);

                entity.Property(e => e.CustomerCode).IsUnicode(false);
            });

            modelBuilder.Entity<DistributionPreference>(entity =>
            {
                entity.Property(e => e.AddedBy).IsUnicode(false);

                entity.Property(e => e.AuthorisedBy).IsUnicode(false);

                entity.Property(e => e.CustomerAbbr).IsUnicode(false);

                entity.Property(e => e.CustomerBranch).IsUnicode(false);

                entity.Property(e => e.CustomerCode).IsUnicode(false);

                entity.Property(e => e.ModifiedBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

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

                entity.Property(e => e.DefaultDistributionStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DistributionType1).IsUnicode(false);

                entity.Property(e => e.TemplateName).IsUnicode(false);

                entity.Property(e => e.VisableToSystem).IsUnicode(false);
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

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((751))");

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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
                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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
                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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
                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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
                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyCode).IsUnicode(false);

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

                entity.Property(e => e.RecordId).IsUnicode(false);

                entity.Property(e => e.UploadError).IsUnicode(false);

                entity.Property(e => e.UploadType).IsUnicode(false);
            });

            modelBuilder.Entity<EndOfDayStart>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EucCcyCode>(entity =>
            {
                entity.HasKey(e => new { e.CcyCd, e.BranchNo });

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.CcyName).IsUnicode(false);

                entity.Property(e => e.DecimalPoint).IsUnicode(false);

                entity.Property(e => e.Mark3Cd).IsUnicode(false);

                entity.Property(e => e.StepsCd).IsUnicode(false);

                entity.Property(e => e.SwiftCd).IsUnicode(false);
            });

            modelBuilder.Entity<EucCollateralCode>(entity =>
            {
                entity.HasKey(e => new { e.CollateralCd, e.BranchNo });

                entity.Property(e => e.CollateralCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CollateralName).IsUnicode(false);

                entity.Property(e => e.CollateralRank).IsUnicode(false);
            });

            modelBuilder.Entity<EucCountryCode>(entity =>
            {
                entity.Property(e => e.CountryCd).IsUnicode(false);

                entity.Property(e => e.AreaCd).IsUnicode(false);

                entity.Property(e => e.BoeAreaCd).IsUnicode(false);

                entity.Property(e => e.BoeCd).IsUnicode(false);

                entity.Property(e => e.CountryName).IsUnicode(false);

                entity.Property(e => e.FrbCd).IsUnicode(false);

                entity.Property(e => e.HomeCcyCd).IsUnicode(false);
            });

            modelBuilder.Entity<EucCustAttributeCode>(entity =>
            {
                entity.HasKey(e => new { e.AttributeCd, e.BranchNo });

                entity.Property(e => e.AttributeCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.AttributeName).IsUnicode(false);
            });

            modelBuilder.Entity<EucCustomerAccountNo>(entity =>
            {
                entity.HasKey(e => new { e.CustAbbr, e.ActCd, e.ActNo, e.IbfId, e.CcyCd, e.StatusCd });

                entity.Property(e => e.CustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActAbbr).IsUnicode(false);

                entity.Property(e => e.ActName).IsUnicode(false);

                entity.Property(e => e.ActShortName).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<EucDeptCode>(entity =>
            {
                entity.HasKey(e => new { e.DeptCd, e.BranchNo });

                entity.Property(e => e.DeptCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.DeptAbbr).IsUnicode(false);

                entity.Property(e => e.DeptName).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);
            });

            modelBuilder.Entity<EucIndustryCode>(entity =>
            {
                entity.HasKey(e => new { e.IndustryCd, e.BranchNo });

                entity.Property(e => e.IndustryCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.IndustryName).IsUnicode(false);
            });

            modelBuilder.Entity<EucTaxCode>(entity =>
            {
                entity.HasKey(e => new { e.TaxId, e.TaxCd, e.BranchNo });

                entity.Property(e => e.TaxId).IsUnicode(false);

                entity.Property(e => e.TaxCd).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);
            });

            modelBuilder.Entity<FuturesRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Period });

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.ImportedBy).IsUnicode(false);

                entity.Property(e => e.RecStatus).IsUnicode(false);
            });

            modelBuilder.Entity<FxRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy });

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.ImportedBy).IsUnicode(false);

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FxSettlementInf>(entity =>
            {
                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.BankFlg).IsUnicode(false);

                entity.Property(e => e.BankToBankInf)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CoverPoFlg).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OperationId).HasDefaultValueSql("(1)");

                entity.Property(e => e.PayAccBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayActNo).IsUnicode(false);

                entity.Property(e => e.PayAdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.PayBeneficiary)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayCcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayCustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayHoFavorMt202)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayIntermediaryBank).IsUnicode(false);

                entity.Property(e => e.PayKihyoIrai).IsUnicode(false);

                entity.Property(e => e.PayMessageType).IsUnicode(false);

                entity.Property(e => e.PayMethod).IsUnicode(false);

                entity.Property(e => e.PayOrderingCustomer)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherCr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherDr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayOtherRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails3)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPaymentDetails4)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayPriortyFlg).IsUnicode(false);

                entity.Property(e => e.PayRecBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayReceiverCorres)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayRmtFlg).IsUnicode(false);

                entity.Property(e => e.PaySenderCorres)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.PriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecActNo).IsUnicode(false);

                entity.Property(e => e.RecAdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.RecCcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecHoFavorMt202)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecIntermediaryBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecKihyoIrai)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType).IsUnicode(false);

                entity.Property(e => e.RecMethod).IsUnicode(false);

                entity.Property(e => e.RecOrderingBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOrderingCustomer)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherCr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherDr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecOtherRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecPriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecRecBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithOne(p => p.FxSettlementInf)
                    .HasForeignKey<FxSettlementInf>(d => d.RefNo)
                    .HasConstraintName("FK_FX_TRANSACTION_FX_SETTLEMENT_INF");
            });

            modelBuilder.Entity<FxTransaction>(entity =>
            {
                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.AccountEntry)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccrualFrom).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AccrualTo).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ActAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ActCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(0)");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Addressee)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.Authorized)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.Broker)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code56)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code57)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code57a)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code58)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyAmt).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyBal).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractCcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ContractCcyTtb).HasDefaultValueSql("(0)");

                entity.Property(e => e.ContractDateOpe).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.ContractDateValue).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.CoverPoFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CustCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DealNo).IsUnicode(false);

                entity.Property(e => e.Dealer)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dealtype).IsUnicode(false);

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DelivaryDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DelivaryThru).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.DivisionCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyAmt).HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyBal).HasDefaultValueSql("(0)");

                entity.Property(e => e.EquivCcyCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.EquivCcyTtb).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExchangeRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ExecutionRefNo).HasDefaultValueSql("(0)");

                entity.Property(e => e.GipDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IbfId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InternalRate).HasDefaultValueSql("(0)");

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OptionsFlag).HasDefaultValueSql("(0)");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RemarksTrd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revise)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SchemeNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SetInstruction)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SettlementValueDate).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.Spread).HasDefaultValueSql("(0)");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Subtype).IsUnicode(false);

                entity.Property(e => e.SwapRefNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.VerifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.HasOne(d => d.CustomerMaster)
                    .WithMany(p => p.FxTransactions)
                    .HasForeignKey(d => new { d.BranchNo, d.CustAbbr })
                    .HasConstraintName("FK_FX_TRANSACTION_CUSTOMER_MASTER");
            });

            modelBuilder.Entity<FxTransactionConfirmation>(entity =>
            {
                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionConfirmationStatus>(entity =>
            {
                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionExt>(entity =>
            {
                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.AuthorisedDealer).IsUnicode(false);

                entity.Property(e => e.ContractCcyAbbrOrig)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DealingMethod).IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbrOrig)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Event).IsUnicode(false);

                entity.Property(e => e.PortfolioBook).IsUnicode(false);

                entity.Property(e => e.PortfolioDesk).IsUnicode(false);

                entity.Property(e => e.PortfolioGroup).IsUnicode(false);

                entity.Property(e => e.SourceCtpy).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);

                entity.Property(e => e.SourceSystem).IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionExtBakMurexRelease>(entity =>
            {
                entity.Property(e => e.AuthorisedDealer).IsUnicode(false);

                entity.Property(e => e.ContractCcyAbbrOrig)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DealingMethod).IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbrOrig)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Event).IsUnicode(false);

                entity.Property(e => e.PortfolioBook).IsUnicode(false);

                entity.Property(e => e.PortfolioDesk).IsUnicode(false);

                entity.Property(e => e.PortfolioGroup).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.SourceCtpy).IsUnicode(false);

                entity.Property(e => e.SourceId).IsUnicode(false);

                entity.Property(e => e.SourceSystem).IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionModCodesMurexRelease>(entity =>
            {
                entity.Property(e => e.AccountEntry).IsUnicode(false);

                entity.Property(e => e.ActAbbr).IsUnicode(false);

                entity.Property(e => e.ActCd).IsUnicode(false);

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Addressee).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Authorized).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.Code56).IsUnicode(false);

                entity.Property(e => e.Code57).IsUnicode(false);

                entity.Property(e => e.Code57a).IsUnicode(false);

                entity.Property(e => e.Code58).IsUnicode(false);

                entity.Property(e => e.ContractCcyAbbr).IsUnicode(false);

                entity.Property(e => e.ContractCcyCd).IsUnicode(false);

                entity.Property(e => e.CoverPoFlg).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.DealNo).IsUnicode(false);

                entity.Property(e => e.Dealer).IsUnicode(false);

                entity.Property(e => e.Dealtype).IsUnicode(false);

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.DivisionCd).IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbr).IsUnicode(false);

                entity.Property(e => e.EquivCcyCd).IsUnicode(false);

                entity.Property(e => e.GipDescription).IsUnicode(false);

                entity.Property(e => e.GipStatus).IsUnicode(false);

                entity.Property(e => e.IbfId).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RemarksTrd).IsUnicode(false);

                entity.Property(e => e.Revise).IsUnicode(false);

                entity.Property(e => e.SchemeNo).IsUnicode(false);

                entity.Property(e => e.SetInstruction).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.Subtype).IsUnicode(false);

                entity.Property(e => e.SwapRefNo).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);

                entity.Property(e => e.VerifyBy).IsUnicode(false);
            });

            modelBuilder.Entity<FxTransactionUploadGipStatus>(entity =>
            {
                entity.HasKey(e => e.GipStatus)
                    .HasName("FX_TRANSACTION_GipStatus_PK");

                entity.Property(e => e.GipStatus).ValueGeneratedNever();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Fxfarbitrage>(entity =>
            {
                entity.Property(e => e.FixedCurrency).IsUnicode(false);

                entity.Property(e => e.FwdbghCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FwdsoldCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ibf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IfwdBghCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.IfwdSoldCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.LendPrinCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SchemeNo).IsUnicode(false);

                entity.Property(e => e.SpotBghCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpotSoldCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TakePrinCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<FxfbusCenter>(entity =>
            {
                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfcalendar>(entity =>
            {
                entity.Property(e => e.Ccycode).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfccy>(entity =>
            {
                entity.Property(e => e.AudcrossCcyname).IsUnicode(false);

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CcyCd)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Ccydesc).IsUnicode(false);

                entity.Property(e => e.DreamsDesc).IsUnicode(false);

                entity.Property(e => e.MurexRateQuotation).IsUnicode(false);

                entity.Property(e => e.ReutersRateType).IsUnicode(false);
            });

            modelBuilder.Entity<FxfcreditCustType>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<FxfcreditParent>(entity =>
            {
                entity.Property(e => e.Cif).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CorpNo).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Ibosno).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfcust>(entity =>
            {
                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.CallDepositAudType).IsUnicode(false);

                entity.Property(e => e.CallDepositFgnType).IsUnicode(false);

                entity.Property(e => e.CallLoanAudType).IsUnicode(false);

                entity.Property(e => e.CallLoanFgnType).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Ccif).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fax).IsUnicode(false);

                entity.Property(e => e.Ibosno).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(((1)/(1))/(1900))");

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PostCode).IsUnicode(false);

                entity.Property(e => e.Sector).IsUnicode(false);

                entity.Property(e => e.Shortname).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Street1).IsUnicode(false);

                entity.Property(e => e.Street2).IsUnicode(false);

                entity.Property(e => e.Street3).IsUnicode(false);

                entity.Property(e => e.Street4).IsUnicode(false);

                entity.Property(e => e.Swift).IsUnicode(false);

                entity.Property(e => e.TaxCode).IsUnicode(false);

                entity.Property(e => e.Tel).IsUnicode(false);

                entity.Property(e => e.Telex).IsUnicode(false);

                entity.HasOne(d => d.MxGuideCustDetail)
                    .WithMany(p => p.Fxfcusts)
                    .HasForeignKey(d => d.MxGuideCustDetailId)
                    .HasConstraintName("FK_FXFCustMxGuideCustDetail");
            });

            modelBuilder.Entity<FxfcustBakMurexRelease>(entity =>
            {
                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.CallDepositAudType).IsUnicode(false);

                entity.Property(e => e.CallDepositFgnType).IsUnicode(false);

                entity.Property(e => e.CallLoanAudType).IsUnicode(false);

                entity.Property(e => e.CallLoanFgnType).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Ccif).IsUnicode(false);

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Country).IsUnicode(false);

                entity.Property(e => e.CustId).ValueGeneratedOnAdd();

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.Fax).IsUnicode(false);

                entity.Property(e => e.Ibosno).IsUnicode(false);

                entity.Property(e => e.Location).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);

                entity.Property(e => e.PostCode).IsUnicode(false);

                entity.Property(e => e.Sector).IsUnicode(false);

                entity.Property(e => e.Shortname).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Street1).IsUnicode(false);

                entity.Property(e => e.Street2).IsUnicode(false);

                entity.Property(e => e.Street3).IsUnicode(false);

                entity.Property(e => e.Street4).IsUnicode(false);

                entity.Property(e => e.Swift).IsUnicode(false);

                entity.Property(e => e.TaxCode).IsUnicode(false);

                entity.Property(e => e.Tel).IsUnicode(false);

                entity.Property(e => e.Telex).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfcustthreshold>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.AccountNo).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);
            });

            modelBuilder.Entity<FxfdealType>(entity =>
            {
                entity.HasKey(e => e.DealtypeId)
                    .HasName("PK_FXFDEALTYPE")
                    .IsClustered(false);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Dealtype).IsUnicode(false);

                entity.Property(e => e.RefType).IsUnicode(false);

                entity.Property(e => e.ShortName).IsUnicode(false);

                entity.Property(e => e.Subtype).IsUnicode(false);

                entity.Property(e => e.Tranname).IsUnicode(false);

                entity.Property(e => e.Typology).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfinstitution>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Subtypecode).IsUnicode(false);
            });

            modelBuilder.Entity<Fxfswift>(entity =>
            {
                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Addresse).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Bic561).IsUnicode(false);

                entity.Property(e => e.Bic571).IsUnicode(false);

                entity.Property(e => e.Bic572).IsUnicode(false);

                entity.Property(e => e.Bic573).IsUnicode(false);

                entity.Property(e => e.Bic574).IsUnicode(false);

                entity.Property(e => e.Bic581).IsUnicode(false);

                entity.Property(e => e.Bic591).IsUnicode(false);

                entity.Property(e => e.Bic592).IsUnicode(false);

                entity.Property(e => e.Bic593).IsUnicode(false);

                entity.Property(e => e.Bic594).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier56).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59).IsUnicode(false);

                entity.Property(e => e.RecordKind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecialInstruction1).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction2).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction3).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction4).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<FxfswiftModCodesMurexRelease>(entity =>
            {
                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Addresse).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Bic561).IsUnicode(false);

                entity.Property(e => e.Bic571).IsUnicode(false);

                entity.Property(e => e.Bic572).IsUnicode(false);

                entity.Property(e => e.Bic573).IsUnicode(false);

                entity.Property(e => e.Bic574).IsUnicode(false);

                entity.Property(e => e.Bic581).IsUnicode(false);

                entity.Property(e => e.Bic591).IsUnicode(false);

                entity.Property(e => e.Bic592).IsUnicode(false);

                entity.Property(e => e.Bic593).IsUnicode(false);

                entity.Property(e => e.Bic594).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier56).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59).IsUnicode(false);

                entity.Property(e => e.RecordKind)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.SpecialInstruction1).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction2).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction3).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction4).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<GbaseErrorCode>(entity =>
            {
                entity.Property(e => e.ErrorCode).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.ShortDesc).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<GbaseRateConversionByCcyPair>(entity =>
            {
                entity.Property(e => e.Ccy1).IsUnicode(false);

                entity.Property(e => e.Ccy2).IsUnicode(false);

                entity.Property(e => e.DealType).IsUnicode(false);
            });

            modelBuilder.Entity<GbaseReferenceNo>(entity =>
            {
                entity.HasKey(e => new { e.DealTypeCode, e.ReferenceCode })
                    .HasName("PK_GBASE_Reference_Number");

                entity.Property(e => e.DealTypeCode).IsFixedLength(true);
            });

            modelBuilder.Entity<GbaseReferenceNoLastUsed>(entity =>
            {
                entity.Property(e => e.DealTypeCode).IsFixedLength(true);
            });

            modelBuilder.Entity<GeneralisedCode>(entity =>
            {
                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<GlinkQueueManagerAction>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ActionDescription).IsUnicode(false);

                entity.Property(e => e.ActionObject).IsUnicode(false);

                entity.Property(e => e.ActionType).IsUnicode(false);
            });

            modelBuilder.Entity<GuideBisRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);
            });

            modelBuilder.Entity<GuideDepositRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Period).IsUnicode(false);
            });

            modelBuilder.Entity<GuideExchangeRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.MurexLable).IsUnicode(false);
            });

            modelBuilder.Entity<GuideLog>(entity =>
            {
                entity.Property(e => e.AuditDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.TableName).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<GuideRevaluationRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexLable).IsUnicode(false);

                entity.Property(e => e.Ric).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<GuideSwapRateTempl>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);
            });

            modelBuilder.Entity<InterbankAccountNo>(entity =>
            {
                entity.Property(e => e.ActCd).IsUnicode(false);

                entity.Property(e => e.ActNo).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("(1)");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.SwiftFlg).IsUnicode(false);

                entity.Property(e => e.SwiftId).IsUnicode(false);
            });

            modelBuilder.Entity<MassApprovalInput>(entity =>
            {
                entity.Property(e => e.Identifier).ValueGeneratedOnAdd();

                entity.Property(e => e.AcuBuInd).IsUnicode(false);

                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.EndTranNumber).IsUnicode(false);

                entity.Property(e => e.SectionCode).IsUnicode(false);

                entity.Property(e => e.StartTranNumber).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<MassDreamsApprovalAccess>(entity =>
            {
                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.MenuOption).IsUnicode(false);

                entity.Property(e => e.OptionDesc).IsUnicode(false);
            });

            modelBuilder.Entity<MassGbaseMenuAccess>(entity =>
            {
                entity.Property(e => e.ActiveInd).IsUnicode(false);

                entity.Property(e => e.ApprovalFailureStatus).IsUnicode(false);

                entity.Property(e => e.ApprovalQueryStatus).IsUnicode(false);

                entity.Property(e => e.ApprovalSuccessStatus).IsUnicode(false);

                entity.Property(e => e.MassModuleFlag).IsUnicode(false);

                entity.Property(e => e.MenuSection).IsUnicode(false);

                entity.Property(e => e.ModuleId).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SectionDesc).IsUnicode(false);

                entity.Property(e => e.SourceTableName).IsUnicode(false);

                entity.Property(e => e.SourceTableUpdateFlag).IsUnicode(false);

                entity.Property(e => e.UpdateColForDesc).IsUnicode(false);

                entity.Property(e => e.UpdateColForStatus).IsUnicode(false);

                entity.Property(e => e.WhereColForAppBy).IsUnicode(false);

                entity.Property(e => e.WhereColForAppDt).IsUnicode(false);

                entity.Property(e => e.WhereColForMinNo).IsUnicode(false);

                entity.Property(e => e.WhereColForRefNo).IsUnicode(false);

                entity.Property(e => e.WhereColForTranNo).IsUnicode(false);
            });

            modelBuilder.Entity<MassTransaction>(entity =>
            {
                entity.Property(e => e.TranId).ValueGeneratedOnAdd();

                entity.Property(e => e.AcuBuInd).IsUnicode(false);

                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.GbaseRefCode).IsUnicode(false);

                entity.Property(e => e.MinNo).IsUnicode(false);

                entity.Property(e => e.ModuleId).IsUnicode(false);

                entity.Property(e => e.OperationMode).IsUnicode(false);

                entity.Property(e => e.ReapprovedOverrideBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TranNumber).IsUnicode(false);
            });

            modelBuilder.Entity<MassTransactionHistory>(entity =>
            {
                entity.Property(e => e.AcuBuInd).IsUnicode(false);

                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.GbaseRefCode).IsUnicode(false);

                entity.Property(e => e.MinNo).IsUnicode(false);

                entity.Property(e => e.ModuleId).IsUnicode(false);

                entity.Property(e => e.OperationMode).IsUnicode(false);

                entity.Property(e => e.ReapprovedOverrideBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TranNumber).IsUnicode(false);
            });

            modelBuilder.Entity<MgeBcustomer>(entity =>
            {
                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.MgeBcustCode).IsUnicode(false);
            });

            modelBuilder.Entity<MgeBreceivedFile>(entity =>
            {
                entity.Property(e => e.FileFullPath).IsUnicode(false);

                entity.Property(e => e.Notes).IsUnicode(false);
            });

            modelBuilder.Entity<MgeBtransactionConfirmation>(entity =>
            {
                entity.Property(e => e.AddDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AnswerFilename).IsUnicode(false);

                entity.Property(e => e.AnswerResponse).IsUnicode(false);

                entity.Property(e => e.AnswerResponseDetail).IsUnicode(false);

                entity.Property(e => e.AnswerStatus).IsUnicode(false);

                entity.Property(e => e.AttachmentList).IsUnicode(false);

                entity.Property(e => e.ConfirmationFilename).IsUnicode(false);

                entity.Property(e => e.ControlFilename).IsUnicode(false);

                entity.Property(e => e.FileIdentificationName).IsUnicode(false);

                entity.Property(e => e.ImportErrorMessage).IsUnicode(false);

                entity.Property(e => e.ImportResultFilename).IsUnicode(false);

                entity.Property(e => e.MgeBcustomerUnitCode).IsUnicode(false);

                entity.Property(e => e.ReferenceNumber).IsUnicode(false);

                entity.Property(e => e.TransactionDataFileName).IsUnicode(false);
            });

            modelBuilder.Entity<MgeBtransactionDataControl>(entity =>
            {
                entity.Property(e => e.AddDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AnswerFilename).IsUnicode(false);

                entity.Property(e => e.AnswerResponse).IsUnicode(false);

                entity.Property(e => e.AnswerResponseDetail).IsUnicode(false);

                entity.Property(e => e.AnswerStatus).IsUnicode(false);

                entity.Property(e => e.AttachmentList).IsUnicode(false);

                entity.Property(e => e.ConfirmationFilename).IsUnicode(false);

                entity.Property(e => e.FileIdentificationName).IsUnicode(false);

                entity.Property(e => e.Filename).IsUnicode(false);

                entity.Property(e => e.ImportErrorMessage).IsUnicode(false);

                entity.Property(e => e.ImportResultFilename).IsUnicode(false);

                entity.Property(e => e.MgeBcustomerUnitCode).IsUnicode(false);

                entity.Property(e => e.ReferenceNumber).IsUnicode(false);

                entity.Property(e => e.TransactionDataFileName).IsUnicode(false);
            });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");
            });

            modelBuilder.Entity<MoneyMarketTicket>(entity =>
            {
                entity.Property(e => e.Authorised).IsUnicode(false);

                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.BrokerName).IsUnicode(false);

                entity.Property(e => e.BuySell).IsUnicode(false);

                entity.Property(e => e.CounterpartyAbbreviation).IsUnicode(false);

                entity.Property(e => e.CounterpartyDescription).IsUnicode(false);

                entity.Property(e => e.CounterpartyShortName).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.CustomerCode).IsUnicode(false);

                entity.Property(e => e.DealingContact).IsUnicode(false);

                entity.Property(e => e.DealingMethod).IsUnicode(false);

                entity.Property(e => e.Event).IsUnicode(false);

                entity.Property(e => e.FrontOfficeAuthorisedBy).IsUnicode(false);

                entity.Property(e => e.FrontOfficeInputBy).IsUnicode(false);

                entity.Property(e => e.FundType).IsUnicode(false);

                entity.Property(e => e.GbaseRefNo).IsUnicode(false);

                entity.Property(e => e.Ibf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Instrument).IsUnicode(false);

                entity.Property(e => e.InterestSet).IsUnicode(false);

                entity.Property(e => e.InterestSetLabel).IsUnicode(false);

                entity.Property(e => e.Issuer).IsUnicode(false);

                entity.Property(e => e.IssuerFullName).IsUnicode(false);

                entity.Property(e => e.IssuerGbaseAbbreviation).IsUnicode(false);

                entity.Property(e => e.LegalEntity).IsUnicode(false);

                entity.Property(e => e.MurexTradeId).IsUnicode(false);

                entity.Property(e => e.Nature).IsUnicode(false);

                entity.Property(e => e.PayoutType).IsUnicode(false);

                entity.Property(e => e.PortfolioBook).IsUnicode(false);

                entity.Property(e => e.PortfolioDesk).IsUnicode(false);

                entity.Property(e => e.PortfolioGroup).IsUnicode(false);

                entity.Property(e => e.RateConvention).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RolloverType).IsUnicode(false);

                entity.Property(e => e.RolloverTypeLabel).IsUnicode(false);

                entity.Property(e => e.SchemeNumber).IsUnicode(false);

                entity.Property(e => e.SettlementDetails).IsUnicode(false);

                entity.Property(e => e.SettlementDirectionLabel).IsUnicode(false);

                entity.Property(e => e.TicketTemplate).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);

                entity.Property(e => e.Typology).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearer).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearerLabel).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxCode).IsUnicode(false);
            });

            modelBuilder.Entity<MoneyMarketTicketExt>(entity =>
            {
                entity.Property(e => e.MmticketId).ValueGeneratedNever();

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.DeleteBy).IsUnicode(false);

                entity.Property(e => e.DeletionStatus).IsUnicode(false);

                entity.Property(e => e.GipDescription).IsUnicode(false);

                entity.Property(e => e.GipStatus).IsUnicode(false);

                entity.Property(e => e.ModifyBy).IsUnicode(false);

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);

                entity.Property(e => e.VerifyBy).IsUnicode(false);

                entity.HasOne(d => d.Mmticket)
                    .WithOne(p => p.MoneyMarketTicketExt)
                    .HasForeignKey<MoneyMarketTicketExt>(d => d.MmticketId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MoneyMarketTicket_Ext_MoneyMarketTicket");
            });

            modelBuilder.Entity<MsmqMessageDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MessageBody).IsUnicode(false);

                entity.Property(e => e.MessageLabel).IsUnicode(false);

                entity.Property(e => e.QueueName).IsUnicode(false);
            });

            modelBuilder.Entity<MsmqMessageHistoryDatum>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.MessageBody).IsUnicode(false);

                entity.Property(e => e.MessageLabel).IsUnicode(false);

                entity.Property(e => e.QueuePath).IsUnicode(false);

                entity.Property(e => e.TransactionRefNo).IsUnicode(false);
            });

            modelBuilder.Entity<MurexHolidayCalendar>(entity =>
            {
                entity.Property(e => e.CalendarDesc).IsUnicode(false);

                entity.Property(e => e.CalendarLabel).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.HolidayDesc).IsUnicode(false);
            });

            modelBuilder.Entity<MurexRamSummary>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Kind).IsUnicode(false);
            });

            modelBuilder.Entity<MxCategoryMapping>(entity =>
            {
                entity.Property(e => e.AttributeCd).IsUnicode(false);

                entity.Property(e => e.AttributeDesp).IsUnicode(false);

                entity.Property(e => e.DepartmentCd).IsUnicode(false);

                entity.Property(e => e.MxCategory).IsUnicode(false);
            });

            modelBuilder.Entity<MxCtpyTypeAttrCode>(entity =>
            {
                entity.Property(e => e.AttributeCode).IsUnicode(false);

                entity.Property(e => e.Branch).IsUnicode(false);

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

            modelBuilder.Entity<MxCustCounterpartyTypeBakMurexRelease>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MxEucBalanceEvent>(entity =>
            {
                entity.Property(e => e.BorrowOrLend).IsUnicode(false);

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.ClosingDate).IsUnicode(false);

                entity.Property(e => e.Currency).IsFixedLength(true);

                entity.Property(e => e.CustomerAbbreviation).IsUnicode(false);

                entity.Property(e => e.EffectiveDate).IsUnicode(false);

                entity.Property(e => e.EventType).IsUnicode(false);

                entity.Property(e => e.GbaseReferenceNo).IsUnicode(false);

                entity.Property(e => e.MaturityDate).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TradeDate).IsUnicode(false);

                entity.Property(e => e.TradeExternalId).IsUnicode(false);
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

            modelBuilder.Entity<MxGuideCustDetailBakMurexRelease>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MxInboundEvent>(entity =>
            {
                entity.HasKey(e => e.MessageId)
                    .HasName("PK_MxInboundMessage");

                entity.Property(e => e.Category).IsUnicode(false);

                entity.Property(e => e.Details).IsUnicode(false);

                entity.Property(e => e.EventType).IsUnicode(false);

                entity.Property(e => e.MessageXml).IsUnicode(false);

                entity.Property(e => e.SendingSystem).IsUnicode(false);
            });

            modelBuilder.Entity<MxInboundEventLog>(entity =>
            {
                entity.HasKey(e => e.LogId)
                    .HasName("PK_MxInboundMessageLog");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EventId).IsUnicode(false);

                entity.Property(e => e.Exception).IsUnicode(false);

                entity.Property(e => e.LogLevel).IsUnicode(false);

                entity.Property(e => e.Logger).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<MxInboundMessageStatus>(entity =>
            {
                entity.Property(e => e.StatusId).ValueGeneratedNever();

                entity.Property(e => e.StatusName).IsUnicode(false);
            });

            modelBuilder.Entity<MxIndustryCodeSector>(entity =>
            {
                entity.Property(e => e.IndustryCode).IsUnicode(false);

                entity.Property(e => e.IndustryName).IsUnicode(false);

                entity.Property(e => e.Sector).IsUnicode(false);
            });

            modelBuilder.Entity<MxTaxCode>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);
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

            modelBuilder.Entity<ObsBasisExportMapping>(entity =>
            {
                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexCcy).IsUnicode(false);

                entity.Property(e => e.ObsCcy).IsUnicode(false);

                entity.Property(e => e.ObsYieldMaturity).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<ObsBasisRate>(entity =>
            {
                entity.Property(e => e.ObsCcy).IsUnicode(false);

                entity.Property(e => e.ObsYieldMaturity).IsUnicode(false);
            });

            modelBuilder.Entity<ObsYieldExportMapping>(entity =>
            {
                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Market).IsUnicode(false);

                entity.Property(e => e.Maturity).IsUnicode(false);

                entity.Property(e => e.MurexCcy).IsUnicode(false);

                entity.Property(e => e.ObsCcy).IsUnicode(false);

                entity.Property(e => e.ObsYieldCurveType).IsUnicode(false);

                entity.Property(e => e.ObsYieldMaturity).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<ObsYieldFutureMaturity>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.ContractName).IsUnicode(false);

                entity.Property(e => e.MurexMaturityLable).IsUnicode(false);
            });

            modelBuilder.Entity<ObsYieldRate>(entity =>
            {
                entity.Property(e => e.ObsCcy).IsUnicode(false);

                entity.Property(e => e.ObsYieldCurveType).IsUnicode(false);

                entity.Property(e => e.ObsYieldMaturity).IsUnicode(false);
            });

            modelBuilder.Entity<Opd37FileProcessHistory>(entity =>
            {
                entity.HasKey(e => e.FileProcessHistoryId)
                    .HasName("PK__OPD-37_F__B205DD24757B891F");

                entity.Property(e => e.FileName).IsUnicode(false);

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
                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.BuyCur).IsUnicode(false);

                entity.Property(e => e.CorpName).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.InterestPeriodStartLeg1).IsUnicode(false);

                entity.Property(e => e.InterestPeriodStartLeg1PrevEom).IsUnicode(false);

                entity.Property(e => e.InterestPeriodStartLeg2).IsUnicode(false);

                entity.Property(e => e.InterestPeriodStartLeg2PrevEom).IsUnicode(false);

                entity.Property(e => e.MCntTypo).IsUnicode(false);

                entity.Property(e => e.MTpBuy).IsUnicode(false);

                entity.Property(e => e.MTpRtcur0).IsUnicode(false);

                entity.Property(e => e.MTpRtcur1).IsUnicode(false);

                entity.Property(e => e.MTpRtpr0).IsUnicode(false);

                entity.Property(e => e.MTrnFmly).IsUnicode(false);

                entity.Property(e => e.MTrnGrp).IsUnicode(false);

                entity.Property(e => e.Pfolio).IsUnicode(false);

                entity.Property(e => e.Prd).IsUnicode(false);

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ref1).IsUnicode(false);

                entity.Property(e => e.SellCur).IsUnicode(false);
            });

            modelBuilder.Entity<Opd37SwapExport>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IntRate).IsUnicode(false);

                entity.Property(e => e.NextIntRate).IsUnicode(false);

                entity.Property(e => e.NextStartDate).IsUnicode(false);

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.RefSubNo).IsUnicode(false);

                entity.Property(e => e.StartDate).IsUnicode(false);
            });

            modelBuilder.Entity<Opd37SwapRaw>(entity =>
            {
                entity.Property(e => e.Abbreviation).IsUnicode(false);

                entity.Property(e => e.AsOfDate).IsUnicode(false);

                entity.Property(e => e.ContractStartDt).IsUnicode(false);

                entity.Property(e => e.Corp).IsUnicode(false);

                entity.Property(e => e.CorpName).IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveratetodayBuyRec).IsUnicode(false);

                entity.Property(e => e.EffectiveratetodaySellPay).IsUnicode(false);

                entity.Property(e => e.Entity).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Generator).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IntAccrualBuyRec).IsUnicode(false);

                entity.Property(e => e.IntAccrualSellPay).IsUnicode(false);

                entity.Property(e => e.MCntTypo).IsUnicode(false);

                entity.Property(e => e.MPlirdacc12).IsUnicode(false);

                entity.Property(e => e.MPlirdacc22).IsUnicode(false);

                entity.Property(e => e.MTpRtpr0).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc00).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc01).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc02).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc10).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc11).IsUnicode(false);

                entity.Property(e => e.MTpRtvlc12).IsUnicode(false);

                entity.Property(e => e.MTrnFmly).IsUnicode(false);

                entity.Property(e => e.MTrnGrp).IsUnicode(false);

                entity.Property(e => e.MaturityDate).IsUnicode(false);

                entity.Property(e => e.Pfolio).IsUnicode(false);

                entity.Property(e => e.Prd).IsUnicode(false);

                entity.Property(e => e.Processed).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ref1).IsUnicode(false);

                entity.Property(e => e.Ref2).IsUnicode(false);

                entity.Property(e => e.TradeDt).IsUnicode(false);
            });

            modelBuilder.Entity<PasswordHistory>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Password, e.PwdChangeDt });

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.SecurityFlag).IsUnicode(false);
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
                entity.Property(e => e.CountryCode).IsUnicode(false);

                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerAbbreviation).IsUnicode(false);

                entity.Property(e => e.PaymentCurrencyCode).IsUnicode(false);

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

                entity.Property(e => e.IdType).IsUnicode(false);

                entity.Property(e => e.SystemId).IsUnicode(false);

                entity.Property(e => e.ChangedBy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.RacfPreviousPwd).IsUnicode(false);

                entity.Property(e => e.RacfStatusCode).IsUnicode(false);
            });

            modelBuilder.Entity<RacfSystemIdHistory>(entity =>
            {
                entity.Property(e => e.IdType).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.SystemId).IsUnicode(false);
            });

            modelBuilder.Entity<RamBaseRecord>(entity =>
            {
                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.DeletedAmt).HasDefaultValueSql("(0)");

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.Kind).IsUnicode(false);

                entity.Property(e => e.RamTypeCode).IsUnicode(false);
            });

            modelBuilder.Entity<RamGbaseTotal>(entity =>
            {
                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);
            });

            modelBuilder.Entity<RamReconSummary>(entity =>
            {
                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Comparefkey).IsUnicode(false);

                entity.Property(e => e.Comparerkey).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.FxalmFormattedAmt).IsUnicode(false);

                entity.Property(e => e.GbaseFormattedAmt).IsUnicode(false);

                entity.Property(e => e.GuideFormattedAmt).IsUnicode(false);

                entity.Property(e => e.Kind).IsUnicode(false);

                entity.Property(e => e.RamTypeCode).IsUnicode(false);
            });

            modelBuilder.Entity<RatesGbaseUploadCriterion>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.Ccy });

                entity.Property(e => e.RateType).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.AcuFlag).IsUnicode(false);

                entity.Property(e => e.BuFlag).IsUnicode(false);

                entity.Property(e => e.CriteriaType).IsUnicode(false);
            });

            modelBuilder.Entity<RatesGbaseUploadCtl>(entity =>
            {
                entity.HasKey(e => new { e.RateType, e.OprDate, e.Ccy });

                entity.Property(e => e.RateType).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.AcuStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.AcuTransStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BuStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('P')");

                entity.Property(e => e.BuTransStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.GbaseMsg).IsUnicode(false);

                entity.Property(e => e.UploadedBy).IsUnicode(false);
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.AcuStatusCode).IsUnicode(false);

                entity.Property(e => e.ApprovalStatus).IsUnicode(false);

                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.BuStatusCode).IsUnicode(false);

                entity.Property(e => e.CreatedAmendedBy).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.EmployeeNo).IsUnicode(false);

                entity.Property(e => e.EnabledInd).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.GbasePreviousPwd).IsUnicode(false);

                entity.Property(e => e.GbasePwdAcuStatusCode).IsUnicode(false);

                entity.Property(e => e.GbasePwdBuStatusCode).IsUnicode(false);

                entity.Property(e => e.GbasePwdStatusCode).IsUnicode(false);

                entity.Property(e => e.GbaseStatusCode).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MasterId).IsUnicode(false);

                entity.Property(e => e.OperatorId).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ProfileEditedBy).IsUnicode(false);

                entity.Property(e => e.PwdChangeInd).IsUnicode(false);

                entity.Property(e => e.RacfPreviousPwd).IsUnicode(false);

                entity.Property(e => e.RacfStatusCode).IsUnicode(false);

                entity.Property(e => e.RankCode).IsUnicode(false);

                entity.Property(e => e.RecStatus).IsUnicode(false);

                entity.Property(e => e.ResetBy).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);

                entity.Property(e => e.SubDeptCode).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.UserProfileStatus).IsUnicode(false);
            });

            modelBuilder.Entity<RevaluationRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Days });

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GbaseMsg).IsUnicode(false);

                entity.Property(e => e.ImportedBy).IsUnicode(false);

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<RmbDefault>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.DefultFlg).HasDefaultValueSql("(0)");
            });

            modelBuilder.Entity<SecurityGroup>(entity =>
            {
                entity.Property(e => e.CreatedAmendedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EnabledInd).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SecurityGroupFunction>(entity =>
            {
                entity.HasKey(e => new { e.SgIdentifier, e.SfIdentifier });
            });

            modelBuilder.Entity<SettlementCorpCustDefault>(entity =>
            {
                entity.Property(e => e.AccBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdviceRecFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BeneBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(751)");

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("(1)");

                entity.Property(e => e.IntermediaryBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingBank)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OrderingCustomer)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.PriortyFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCorres)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RecordKind)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(2)");

                entity.Property(e => e.SenderCorres)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");
            });

            modelBuilder.Entity<SettlementCorpCustDefault2>(entity =>
            {
                entity.Property(e => e.AccBankId).IsUnicode(false);

                entity.Property(e => e.AdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.BeneBankId).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.CorpCustId).ValueGeneratedOnAdd();

                entity.Property(e => e.IntermediaryBankId).IsUnicode(false);

                entity.Property(e => e.OrderingBank).IsUnicode(false);

                entity.Property(e => e.OrderingCustomer).IsUnicode(false);

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayActNo).IsUnicode(false);

                entity.Property(e => e.PayMessageType).IsUnicode(false);

                entity.Property(e => e.PayMethod).IsUnicode(false);

                entity.Property(e => e.PayRmtFlg).IsUnicode(false);

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.PriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecActNo).IsUnicode(false);

                entity.Property(e => e.RecBankId).IsUnicode(false);

                entity.Property(e => e.RecCorres).IsUnicode(false);

                entity.Property(e => e.RecMessageType).IsUnicode(false);

                entity.Property(e => e.RecMethod).IsUnicode(false);

                entity.Property(e => e.RecRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RecordKind).IsUnicode(false);

                entity.Property(e => e.SenderCorres).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<SettlementInf>(entity =>
            {
                entity.Property(e => e.AccBankActno)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AddOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.AdviceRecFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.AdviceRecLimit).HasDefaultValueSql("(0)");

                entity.Property(e => e.AuthorizeBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AuthorizeOn).HasDefaultValueSql("('1900-01-01')");

                entity.Property(e => e.BankFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BankInf)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankInfFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.BeneBankActno)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BeneBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BranchNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('751')");

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.ConfirmationFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.ConfirmationSwiftId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CoverPoFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.DeleteOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.DeletionStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipDescription)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.GipStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IntermediaryBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyOn).HasDefaultValueSql("(1 / 1 / 1900)");

                entity.Property(e => e.OcnnectFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.OpeDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PayActCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayMessageType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('202')");

                entity.Property(e => e.PayMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SW')");

                entity.Property(e => e.PayRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.PaySettlCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PriortyFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('02')");

                entity.Property(e => e.RecActCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecActNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankBrActno)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankHoActno)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecBankId)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecCustAbbr)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecMessageType)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('210')");

                entity.Property(e => e.RecMethod)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SW')");

                entity.Property(e => e.RecRmtFlg)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('M')");

                entity.Property(e => e.RecSettlCode)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.RecordKind).IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.StatusCd)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TranNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SettlementInterbankDefault>(entity =>
            {
                entity.Property(e => e.AccountNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.BankFlg).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CoverPoFlg).IsUnicode(false);

                entity.Property(e => e.DefaultFlg).HasDefaultValueSql("(1)");

                entity.Property(e => e.ObuAccountNo)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayMessageType).IsUnicode(false);

                entity.Property(e => e.PayMethod).IsUnicode(false);

                entity.Property(e => e.PayRmtFlg).IsUnicode(false);

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.PriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecBankId).IsUnicode(false);

                entity.Property(e => e.RecMessageType).IsUnicode(false);

                entity.Property(e => e.RecMethod).IsUnicode(false);

                entity.Property(e => e.RecRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RecordKind).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<ShipUploadingHistory>(entity =>
            {
                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.GbaseRef).IsUnicode(false);

                entity.Property(e => e.Scenario).IsUnicode(false);

                entity.Property(e => e.ShipMinNo).IsUnicode(false);

                entity.Property(e => e.ShipSeqNo).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TranNumber).IsUnicode(false);

                entity.Property(e => e.UploadSeq).IsUnicode(false);
            });

            modelBuilder.Entity<SpotRateUsdEquiv>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy })
                    .HasName("PK_SPOT_RATE");

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ShortDes).IsUnicode(false);
            });

            modelBuilder.Entity<SwapRate>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.Ccy, e.Duration, e.DurationUnit });

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);

                entity.Property(e => e.ImportedBy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.ImportedTime).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<SystemFunction>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);
            });

            modelBuilder.Entity<SystemMessage>(entity =>
            {
                entity.Property(e => e.Text).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<SystemModule>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EnabledInd).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<SystemModuleGroup>(entity =>
            {
                entity.HasKey(e => new { e.SmIdentifier, e.SgIdentifier });
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.Property(e => e.ParamType).IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);
            });

            modelBuilder.Entity<SystemRegistryParameter>(entity =>
            {
                entity.Property(e => e.ParamKey).IsUnicode(false);

                entity.Property(e => e.ActiveFlag).IsUnicode(false);

                entity.Property(e => e.EncriptInd).IsUnicode(false);

                entity.Property(e => e.ParamValue).IsUnicode(false);
            });

            modelBuilder.Entity<SystemSetting>(entity =>
            {
                entity.Property(e => e.Database).IsUnicode(false);

                entity.Property(e => e.Server).IsUnicode(false);

                entity.Property(e => e.SettingGroup).IsUnicode(false);

                entity.Property(e => e.SettingId).ValueGeneratedOnAdd();

                entity.Property(e => e.SettingName).IsUnicode(false);

                entity.Property(e => e.SettingValue).IsUnicode(false);

                entity.Property(e => e.SystemName).IsUnicode(false);

                entity.Property(e => e.UpdatedBy).IsUnicode(false);
            });

            modelBuilder.Entity<TempRevaluationRate>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.GbaseMsg).IsUnicode(false);

                entity.Property(e => e.ImportedBy).IsUnicode(false);

                entity.Property(e => e.RecStatus)
                    .IsUnicode(false)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<TransactionKindAdvancedNotice>(entity =>
            {
                entity.Property(e => e.Instrument).IsUnicode(false);

                entity.Property(e => e.Actabbr).IsUnicode(false);

                entity.Property(e => e.Actname).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.ComfirmationType).IsUnicode(false);

                entity.Property(e => e.Days).IsUnicode(false);

                entity.Property(e => e.LegalEntity).IsUnicode(false);

                entity.Property(e => e.Rate).IsUnicode(false);

                entity.Property(e => e.TicketProductName).IsUnicode(false);

                entity.Property(e => e.TransactionKind).IsFixedLength(true);

                entity.Property(e => e.Typology).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionKindMoneyMarket>(entity =>
            {
                entity.Property(e => e.AccountCategory).IsUnicode(false);

                entity.Property(e => e.BranchCode).IsUnicode(false);

                entity.Property(e => e.BuySell)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CounterpartyTypeRule).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MxLegalEntity).IsUnicode(false);

                entity.Property(e => e.MxTypology).IsUnicode(false);

                entity.Property(e => e.Payout).IsUnicode(false);

                entity.Property(e => e.TermRule).IsUnicode(false);

                entity.Property(e => e.TransactionKind).IsFixedLength(true);

                entity.Property(e => e.TransactionType).IsUnicode(false);
            });

            modelBuilder.Entity<TransactionKindOverrideCode>(entity =>
            {
                entity.Property(e => e.CounterpartyLabel).IsUnicode(false);

                entity.Property(e => e.GbaseCustomerAbbrev).IsUnicode(false);

                entity.Property(e => e.MxPayout).IsUnicode(false);

                entity.Property(e => e.MxTypology).IsUnicode(false);

                entity.Property(e => e.TransactionKind).IsFixedLength(true);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.AcuStatusCode).IsUnicode(false);

                entity.Property(e => e.ApprovalStatus).IsUnicode(false);

                entity.Property(e => e.ApprovedBy).IsUnicode(false);

                entity.Property(e => e.BuStatusCode).IsUnicode(false);

                entity.Property(e => e.CreatedAmendedBy).IsUnicode(false);

                entity.Property(e => e.CreatedBy).IsUnicode(false);

                entity.Property(e => e.DeptCode).IsUnicode(false);

                entity.Property(e => e.EmployeeNo).IsUnicode(false);

                entity.Property(e => e.EnabledInd).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.GbasePreviousPwd).IsUnicode(false);

                entity.Property(e => e.GbasePwdAcuStatusCode).IsUnicode(false);

                entity.Property(e => e.GbasePwdBuStatusCode).IsUnicode(false);

                entity.Property(e => e.GbasePwdStatusCode).IsUnicode(false);

                entity.Property(e => e.GbaseStatusCode).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.MasterId).IsUnicode(false);

                entity.Property(e => e.OperatorId).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.ProfileEditedBy).IsUnicode(false);

                entity.Property(e => e.PwdChangeInd).IsUnicode(false);

                entity.Property(e => e.RacfPreviousPwd).IsUnicode(false);

                entity.Property(e => e.RacfStatusCode).IsUnicode(false);

                entity.Property(e => e.RankCode).IsUnicode(false);

                entity.Property(e => e.RecStatus).IsUnicode(false);

                entity.Property(e => e.ResetBy).IsUnicode(false);

                entity.Property(e => e.Role).IsUnicode(false);

                entity.Property(e => e.SubDeptCode).IsUnicode(false);

                entity.Property(e => e.UserProfileStatus).IsUnicode(false);
            });

            modelBuilder.Entity<UserSecurityGroup>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.SgIdentifier });

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<UsersExt>(entity =>
            {
                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.NetworkId).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.UsersExt)
                    .HasForeignKey<UsersExt>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USERS_Ext_USERS");
            });

            modelBuilder.Entity<UsrGbaseSplTransaction>(entity =>
            {
                entity.Property(e => e.UserId).IsUnicode(false);

                entity.Property(e => e.AccountSettlement).IsUnicode(false);

                entity.Property(e => e.ApprovalLdgrMod).IsUnicode(false);

                entity.Property(e => e.ApprovalOfCorrection).IsUnicode(false);

                entity.Property(e => e.ApprovalOfLoan).IsUnicode(false);

                entity.Property(e => e.ApprovalOfOd).IsUnicode(false);

                entity.Property(e => e.ApprovalOfRemittance).IsUnicode(false);

                entity.Property(e => e.ApprovalOfTmpod).IsUnicode(false);

                entity.Property(e => e.ApprovalWarnCd).IsUnicode(false);

                entity.Property(e => e.EdpManager).IsUnicode(false);

                entity.Property(e => e.FwdValueRemittance).IsUnicode(false);

                entity.Property(e => e.NonOnlineAcc).IsUnicode(false);

                entity.Property(e => e.Personnel).IsUnicode(false);

                entity.Property(e => e.ProfitManagement).IsUnicode(false);

                entity.Property(e => e.ReversalOfOp).IsUnicode(false);

                entity.Property(e => e.SynthLimitCont).IsUnicode(false);

                entity.Property(e => e.System).IsUnicode(false);

                entity.Property(e => e.TakeInPosting).IsUnicode(false);

                entity.Property(e => e.TransmitOfOut).IsUnicode(false);

                entity.Property(e => e.UpdateOfMessage).IsUnicode(false);

                entity.Property(e => e.WarningCdOverrd).IsUnicode(false);
            });

            modelBuilder.Entity<VgasGeneraloperation>(entity =>
            {
                entity.ToView("VGAS_GENERALOPERATION");

                entity.Property(e => e.ApprovedPassword).IsUnicode(false);

                entity.Property(e => e.AvaildateDtDd).IsUnicode(false);

                entity.Property(e => e.AvaildateDtMm).IsUnicode(false);

                entity.Property(e => e.AvaildateDtYy).IsUnicode(false);

                entity.Property(e => e.Cr1AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr1AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr1AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr1AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr1AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr1AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr1AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr1AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr1CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr1CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr1ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr1CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr1DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr1DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr1EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr1ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr1FundTx).IsUnicode(false);

                entity.Property(e => e.Cr1FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr1FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr1IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr1InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr1TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr2AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr2AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr2AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr2AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr2AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr2AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr2AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr2AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr2CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr2CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr2ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr2CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr2DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr2DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr2EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr2ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr2FundTx).IsUnicode(false);

                entity.Property(e => e.Cr2FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr2FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr2IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr2InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr2TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr3AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr3AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr3AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr3AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr3AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr3AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr3AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr3AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr3CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr3CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr3ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr3CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr3DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr3DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr3EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr3ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr3FundTx).IsUnicode(false);

                entity.Property(e => e.Cr3FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr3FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr3IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr3InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr3TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr4AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr4AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr4AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr4AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr4AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr4AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr4AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr4AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr4CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr4CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr4ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr4CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr4DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr4DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr4EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr4ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr4FundTx).IsUnicode(false);

                entity.Property(e => e.Cr4FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr4FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr4IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr4InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr4TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr5AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr5AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr5AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr5AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr5AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr5AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr5AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr5AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr5CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr5CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr5ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr5CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr5DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr5DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr5EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr5ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr5FundTx).IsUnicode(false);

                entity.Property(e => e.Cr5FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr5FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr5IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr5InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr5TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr6AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr6AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr6AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr6AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr6AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr6AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr6AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr6AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr6CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr6CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr6ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr6CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr6DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr6DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr6EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr6ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr6FundTx).IsUnicode(false);

                entity.Property(e => e.Cr6FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr6FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr6IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr6InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr6TypeTx).IsUnicode(false);

                entity.Property(e => e.Cr7AccCdTx).IsUnicode(false);

                entity.Property(e => e.Cr7AccnumTx).IsUnicode(false);

                entity.Property(e => e.Cr7AdviseprintTx).IsUnicode(false);

                entity.Property(e => e.Cr7AmountAmt).IsUnicode(false);

                entity.Property(e => e.Cr7AvailableDate).IsUnicode(false);

                entity.Property(e => e.Cr7AvailableDateDdDt).IsUnicode(false);

                entity.Property(e => e.Cr7AvailableDateDdYy).IsUnicode(false);

                entity.Property(e => e.Cr7AvailableDateMmDt).IsUnicode(false);

                entity.Property(e => e.Cr7CcyTx).IsUnicode(false);

                entity.Property(e => e.Cr7CcyUpload).IsUnicode(false);

                entity.Property(e => e.Cr7ChecknoTx).IsUnicode(false);

                entity.Property(e => e.Cr7CustidTx).IsUnicode(false);

                entity.Property(e => e.Cr7DetailsTx).IsUnicode(false);

                entity.Property(e => e.Cr7DivisionTx).IsUnicode(false);

                entity.Property(e => e.Cr7EntityTx).IsUnicode(false);

                entity.Property(e => e.Cr7ExchrateInt).IsUnicode(false);

                entity.Property(e => e.Cr7FundTx).IsUnicode(false);

                entity.Property(e => e.Cr7FxccyTx).IsUnicode(false);

                entity.Property(e => e.Cr7FxccyUpload).IsUnicode(false);

                entity.Property(e => e.Cr7IbfTx).IsUnicode(false);

                entity.Property(e => e.Cr7InterrateInt).IsUnicode(false);

                entity.Property(e => e.Cr7TypeTx).IsUnicode(false);

                entity.Property(e => e.DeletedPassword).IsUnicode(false);

                entity.Property(e => e.DrAmountAmt).IsUnicode(false);

                entity.Property(e => e.DrCcyUpload).IsUnicode(false);

                entity.Property(e => e.DrFxccyUpload).IsUnicode(false);

                entity.Property(e => e.EncryptInd).IsUnicode(false);

                entity.Property(e => e.HostName).IsUnicode(false);

                entity.Property(e => e.ReversedPassword).IsUnicode(false);

                entity.Property(e => e.StatusDesc).IsUnicode(false);

                entity.Property(e => e.UploadedPassword).IsUnicode(false);

                entity.Property(e => e.ValuedateDtDd).IsUnicode(false);

                entity.Property(e => e.ValuedateDtMm).IsUnicode(false);

                entity.Property(e => e.ValuedateDtYy).IsUnicode(false);
            });

            modelBuilder.Entity<VgasSelectwebgastransaction>(entity =>
            {
                entity.ToView("VGAS_SELECTWEBGASTRANSACTIONS");

                entity.Property(e => e.ApprovedDate).IsUnicode(false);

                entity.Property(e => e.AvailableDate).IsUnicode(false);

                entity.Property(e => e.CreatedDate).IsUnicode(false);

                entity.Property(e => e.DeletedDate).IsUnicode(false);

                entity.Property(e => e.LastEditedDate).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.RecordType).IsUnicode(false);

                entity.Property(e => e.ReversedDate).IsUnicode(false);

                entity.Property(e => e.StatusCodeDesc).IsUnicode(false);

                entity.Property(e => e.UploadedDate).IsUnicode(false);

                entity.Property(e => e.ValuedateDt).IsUnicode(false);
            });

            modelBuilder.Entity<ViewEucBankInfPrepare1>(entity =>
            {
                entity.ToView("VIEW_EUC_BANK_INF_PREPARE1");
            });

            modelBuilder.Entity<ViewEucBankInfPrepare2>(entity =>
            {
                entity.ToView("VIEW_EUC_BANK_INF_PREPARE2");
            });

            modelBuilder.Entity<ViewEucCcyCode>(entity =>
            {
                entity.ToView("VIEW_EUC_CCY_CODE");
            });

            modelBuilder.Entity<ViewFxsystemCreditparent>(entity =>
            {
                entity.ToView("VIEW_ FXSYSTEM_CREDITPARENT");

                entity.Property(e => e.Cif).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CorpNo).IsUnicode(false);

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.Ibosno).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<ViewGipFxTransaction>(entity =>
            {
                entity.ToView("VIEW_GIP_FX_TRANSACTION");

                entity.Property(e => e.AccountEntry).IsUnicode(false);

                entity.Property(e => e.ActAbbr).IsUnicode(false);

                entity.Property(e => e.ActCd).IsUnicode(false);

                entity.Property(e => e.AddBy).IsUnicode(false);

                entity.Property(e => e.Addressee).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Authorized).IsUnicode(false);

                entity.Property(e => e.Banktobankinf).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.Code56).IsUnicode(false);

                entity.Property(e => e.Code57).IsUnicode(false);

                entity.Property(e => e.Code57a).IsUnicode(false);

                entity.Property(e => e.Code58).IsUnicode(false);

                entity.Property(e => e.ContractCcyAbbr).IsUnicode(false);

                entity.Property(e => e.ContractCcyCd).IsUnicode(false);

                entity.Property(e => e.CoverPoFlg).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.Dealer).IsUnicode(false);

                entity.Property(e => e.Dealno).IsUnicode(false);

                entity.Property(e => e.Dealtype).IsUnicode(false);

                entity.Property(e => e.DivisionCd).IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbr).IsUnicode(false);

                entity.Property(e => e.EquivCcyCd).IsUnicode(false);

                entity.Property(e => e.ExecutionRefNo1).IsUnicode(false);

                entity.Property(e => e.GbaseContractAmt).IsUnicode(false);

                entity.Property(e => e.GbaseDeliveryContractAmt).IsUnicode(false);

                entity.Property(e => e.GbaseEquivCcyAmt).IsUnicode(false);

                entity.Property(e => e.GipDescription).IsUnicode(false);

                entity.Property(e => e.GipStatus).IsUnicode(false);

                entity.Property(e => e.IbfId).IsUnicode(false);

                entity.Property(e => e.PayAccBank).IsUnicode(false);

                entity.Property(e => e.PayActCd).IsUnicode(false);

                entity.Property(e => e.PayActNo).IsUnicode(false);

                entity.Property(e => e.PayAdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.PayBeneficiary).IsUnicode(false);

                entity.Property(e => e.PayCustAbbr).IsUnicode(false);

                entity.Property(e => e.PayHoFavorMt202).IsUnicode(false);

                entity.Property(e => e.PayIntermediaryBank).IsUnicode(false);

                entity.Property(e => e.PayKihyoIrai).IsUnicode(false);

                entity.Property(e => e.PayMessageType).IsUnicode(false);

                entity.Property(e => e.PayMethod).IsUnicode(false);

                entity.Property(e => e.PayOrderingCustomer).IsUnicode(false);

                entity.Property(e => e.PayOtherCr).IsUnicode(false);

                entity.Property(e => e.PayOtherDr).IsUnicode(false);

                entity.Property(e => e.PayOtherMethod).IsUnicode(false);

                entity.Property(e => e.PayOtherRmtFlg).IsUnicode(false);

                entity.Property(e => e.PayPaymentDetails1).IsUnicode(false);

                entity.Property(e => e.PayPaymentDetails2).IsUnicode(false);

                entity.Property(e => e.PayPaymentDetails3).IsUnicode(false);

                entity.Property(e => e.PayPaymentDetails4).IsUnicode(false);

                entity.Property(e => e.PayPriortyFlg).IsUnicode(false);

                entity.Property(e => e.PayRecBank).IsUnicode(false);

                entity.Property(e => e.PayReceiverCorres).IsUnicode(false);

                entity.Property(e => e.PayRmtFlg).IsUnicode(false);

                entity.Property(e => e.PaySenderCorres).IsUnicode(false);

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.RecActCd).IsUnicode(false);

                entity.Property(e => e.RecActNo).IsUnicode(false);

                entity.Property(e => e.RecAdviceRecFlg).IsUnicode(false);

                entity.Property(e => e.RecCustAbbr).IsUnicode(false);

                entity.Property(e => e.RecHoFavorMt202).IsUnicode(false);

                entity.Property(e => e.RecIntermediaryBank).IsUnicode(false);

                entity.Property(e => e.RecKihyoIrai).IsUnicode(false);

                entity.Property(e => e.RecMessageType).IsUnicode(false);

                entity.Property(e => e.RecMethod).IsUnicode(false);

                entity.Property(e => e.RecOrderingBank).IsUnicode(false);

                entity.Property(e => e.RecOrderingCustomer).IsUnicode(false);

                entity.Property(e => e.RecOtherCr).IsUnicode(false);

                entity.Property(e => e.RecOtherDr).IsUnicode(false);

                entity.Property(e => e.RecOtherMethod).IsUnicode(false);

                entity.Property(e => e.RecOtherRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecPriortyFlg).IsUnicode(false);

                entity.Property(e => e.RecRecBank).IsUnicode(false);

                entity.Property(e => e.RecRelatedRef).IsUnicode(false);

                entity.Property(e => e.RecRmtFlg).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Revise).IsUnicode(false);

                entity.Property(e => e.SchemeNo).IsUnicode(false);

                entity.Property(e => e.Setinstruction).IsUnicode(false);

                entity.Property(e => e.SettleTranNo).IsUnicode(false);

                entity.Property(e => e.SettlementAuthorizeBy).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.Subtype).IsUnicode(false);

                entity.Property(e => e.SwapRefNo).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);
            });

            modelBuilder.Entity<ViewGuideCorpCustomerAccount>(entity =>
            {
                entity.ToView("VIEW_GUIDE_CORP_CUSTOMER_ACCOUNT");

                entity.Property(e => e.ActCd).IsUnicode(false);

                entity.Property(e => e.ActNo).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.CcyAbbr).IsUnicode(false);

                entity.Property(e => e.CcyCd).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);
            });

            modelBuilder.Entity<ViewGuideCustomerMasterAll>(entity =>
            {
                entity.ToView("VIEW_GUIDE_CUSTOMER_MASTER_ALL");

                entity.Property(e => e.AddBy1).IsUnicode(false);

                entity.Property(e => e.AddBy2).IsUnicode(false);

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Address2).IsUnicode(false);

                entity.Property(e => e.AttributeCode).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy1).IsUnicode(false);

                entity.Property(e => e.AuthorizeBy2).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Code).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.CustName).IsUnicode(false);

                entity.Property(e => e.DeleteBy1).IsUnicode(false);

                entity.Property(e => e.DeleteBy2).IsUnicode(false);

                entity.Property(e => e.DeletionStatus1).IsUnicode(false);

                entity.Property(e => e.DeletionStatus2).IsUnicode(false);

                entity.Property(e => e.Ibosno).IsUnicode(false);

                entity.Property(e => e.IndustryCd).IsUnicode(false);

                entity.Property(e => e.LocationCountry).IsUnicode(false);

                entity.Property(e => e.ModifyBy1).IsUnicode(false);

                entity.Property(e => e.ModifyBy2).IsUnicode(false);

                entity.Property(e => e.MxName).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.Status1).IsUnicode(false);

                entity.Property(e => e.Status2).IsUnicode(false);

                entity.Property(e => e.StatusCd).IsUnicode(false);

                entity.Property(e => e.TranNo).IsUnicode(false);
            });

            modelBuilder.Entity<ViewGuideFxTransaction>(entity =>
            {
                entity.ToView("VIEW_GUIDE_FX_TRANSACTION");

                entity.Property(e => e.Bank).IsUnicode(false);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.BuyCcy).IsUnicode(false);

                entity.Property(e => e.ContractCcyAbbr).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.CustCode).IsUnicode(false);

                entity.Property(e => e.DealNo).IsUnicode(false);

                entity.Property(e => e.Dealer).IsUnicode(false);

                entity.Property(e => e.DeliveryAddBy).IsUnicode(false);

                entity.Property(e => e.DeliveryAuthorizeBy).IsUnicode(false);

                entity.Property(e => e.DeliveryDeleteBy).IsUnicode(false);

                entity.Property(e => e.DeliveryDeletionStatus).IsUnicode(false);

                entity.Property(e => e.DeliveryGipDescription).IsUnicode(false);

                entity.Property(e => e.DeliveryGipStatus).IsUnicode(false);

                entity.Property(e => e.DeliveryModifyBy).IsUnicode(false);

                entity.Property(e => e.DeliveryStatus).IsUnicode(false);

                entity.Property(e => e.DeliveryTranNo).IsUnicode(false);

                entity.Property(e => e.DeliveryVerifyBy).IsUnicode(false);

                entity.Property(e => e.EquivCcyAbbr).IsUnicode(false);

                entity.Property(e => e.PayActNo).IsUnicode(false);

                entity.Property(e => e.PaySettlCode).IsUnicode(false);

                entity.Property(e => e.RecActNo).IsUnicode(false);

                entity.Property(e => e.RecSettlCode).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.RefNum).IsUnicode(false);

                entity.Property(e => e.SchemeNo).IsUnicode(false);

                entity.Property(e => e.SellCcy).IsUnicode(false);

                entity.Property(e => e.Shortname).IsUnicode(false);

                entity.Property(e => e.TransAddBy).IsUnicode(false);

                entity.Property(e => e.TransAuthorizeBy).IsUnicode(false);

                entity.Property(e => e.TransDeleteBy).IsUnicode(false);

                entity.Property(e => e.TransDeletionStatus).IsUnicode(false);

                entity.Property(e => e.TransGipDescription).IsUnicode(false);

                entity.Property(e => e.TransGipStatus).IsUnicode(false);

                entity.Property(e => e.TransModifyBy).IsUnicode(false);

                entity.Property(e => e.TransStatus).IsUnicode(false);

                entity.Property(e => e.TransTranNo).IsUnicode(false);

                entity.Property(e => e.TransVerifyBy).IsUnicode(false);
            });

            modelBuilder.Entity<ViewMmTicketDetail>(entity =>
            {
                entity.ToView("VIEW_MM_TICKET_DETAILS");

                entity.Property(e => e.Addresse).IsUnicode(false);

                entity.Property(e => e.Authorised).IsUnicode(false);

                entity.Property(e => e.Bic561).IsUnicode(false);

                entity.Property(e => e.Bic571).IsUnicode(false);

                entity.Property(e => e.Bic572).IsUnicode(false);

                entity.Property(e => e.Bic573).IsUnicode(false);

                entity.Property(e => e.Bic574).IsUnicode(false);

                entity.Property(e => e.Bic581).IsUnicode(false);

                entity.Property(e => e.Bic591).IsUnicode(false);

                entity.Property(e => e.Bic592).IsUnicode(false);

                entity.Property(e => e.Bic593).IsUnicode(false);

                entity.Property(e => e.Bic594).IsUnicode(false);

                entity.Property(e => e.Broker).IsUnicode(false);

                entity.Property(e => e.BuySell).IsUnicode(false);

                entity.Property(e => e.CounterpartyAbbreviation).IsUnicode(false);

                entity.Property(e => e.CounterpartyDescription).IsUnicode(false);

                entity.Property(e => e.CounterpartyShortName).IsUnicode(false);

                entity.Property(e => e.Currency).IsUnicode(false);

                entity.Property(e => e.CustomerCode).IsUnicode(false);

                entity.Property(e => e.DealingContact).IsUnicode(false);

                entity.Property(e => e.DealingMethod).IsUnicode(false);

                entity.Property(e => e.Event).IsUnicode(false);

                entity.Property(e => e.FrontOfficeAuthorisedBy).IsUnicode(false);

                entity.Property(e => e.FrontOfficeInputBy).IsUnicode(false);

                entity.Property(e => e.FundType).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.FxalmPartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.GbaseRefNo).IsUnicode(false);

                entity.Property(e => e.Ibf)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Instrument).IsUnicode(false);

                entity.Property(e => e.InterestSet).IsUnicode(false);

                entity.Property(e => e.InterestSetLabel).IsUnicode(false);

                entity.Property(e => e.Issuer).IsUnicode(false);

                entity.Property(e => e.IssuerFullName).IsUnicode(false);

                entity.Property(e => e.IssuerGbaseAbbreviation).IsUnicode(false);

                entity.Property(e => e.LegalEntity).IsUnicode(false);

                entity.Property(e => e.MizuhoTicketProduct).IsUnicode(false);

                entity.Property(e => e.MmticketId).IsUnicode(false);

                entity.Property(e => e.MurexTradeId).IsUnicode(false);

                entity.Property(e => e.Nature).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier56).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier57).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier58).IsUnicode(false);

                entity.Property(e => e.PartyIdentifier59).IsUnicode(false);

                entity.Property(e => e.PayoutType).IsUnicode(false);

                entity.Property(e => e.PortfolioBook).IsUnicode(false);

                entity.Property(e => e.PortfolioDesk).IsUnicode(false);

                entity.Property(e => e.PortfolioGroup).IsUnicode(false);

                entity.Property(e => e.RateConvention).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.RolloverType).IsUnicode(false);

                entity.Property(e => e.RolloverTypeLabel).IsUnicode(false);

                entity.Property(e => e.SchemeNumber).IsUnicode(false);

                entity.Property(e => e.SettlementDetails).IsUnicode(false);

                entity.Property(e => e.SettlementDirectionLabel).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction1).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction2).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction3).IsUnicode(false);

                entity.Property(e => e.SpecialInstruction4).IsUnicode(false);

                entity.Property(e => e.TicketTemplate).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);

                entity.Property(e => e.Typology).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearer).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxBearerLabel).IsUnicode(false);

                entity.Property(e => e.WithholdingTaxCode).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRamReconSummary>(entity =>
            {
                entity.ToView("VIEW_RAM_RECON_SUMMARY");

                entity.Property(e => e.Branch).IsUnicode(false);

                entity.Property(e => e.Ccy).IsUnicode(false);

                entity.Property(e => e.Comparefkey).IsUnicode(false);

                entity.Property(e => e.Comparerkey).IsUnicode(false);

                entity.Property(e => e.Department).IsUnicode(false);

                entity.Property(e => e.FxalmFormattedAmt).IsUnicode(false);

                entity.Property(e => e.GbaseFormattedAmt).IsUnicode(false);

                entity.Property(e => e.GuideFormattedAmt).IsUnicode(false);

                entity.Property(e => e.Kind).IsUnicode(false);

                entity.Property(e => e.RamTypeCode).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRatesGuideBisRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_BIS_RATE");

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRatesGuideDepositRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_DEPOSIT_RATE");

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Period).IsUnicode(false);
            });

            modelBuilder.Entity<ViewRatesGuideSwapRate>(entity =>
            {
                entity.ToView("VIEW_RATES_GUIDE_SWAP_RATE");

                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.DurationUnit).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
