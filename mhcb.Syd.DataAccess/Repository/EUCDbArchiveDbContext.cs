using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using mhcb.Syd.DataAccess.Models.EUCDbArchive;

#nullable disable

namespace mhcb.Syd.DataAccess.Repository
{
    public partial class EUCDbArchiveDbContext : DbContext
    {
        public EUCDbArchiveDbContext()
        {
        }

        public EUCDbArchiveDbContext(DbContextOptions<EUCDbArchiveDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountCodeTable> AccountCodeTables { get; set; }
        public virtual DbSet<AccountNoBalance> AccountNoBalances { get; set; }
        public virtual DbSet<AdjustAccountDetail> AdjustAccountDetails { get; set; }
        public virtual DbSet<AgentGuarantee> AgentGuarantees { get; set; }
        public virtual DbSet<AgentLoan> AgentLoans { get; set; }
        public virtual DbSet<BankInf> BankInfs { get; set; }
        public virtual DbSet<BankMoneyLendingLimit> BankMoneyLendingLimits { get; set; }
        public virtual DbSet<BaseRateTable> BaseRateTables { get; set; }
        public virtual DbSet<BatchLogAccount> BatchLogAccounts { get; set; }
        public virtual DbSet<BatchLogCommon> BatchLogCommons { get; set; }
        public virtual DbSet<BatchLogRemittance> BatchLogRemittances { get; set; }
        public virtual DbSet<BatchLogRemittanceBak> BatchLogRemittanceBaks { get; set; }
        public virtual DbSet<BisOffBsCommitAndOther> BisOffBsCommitAndOthers { get; set; }
        public virtual DbSet<BisOffBsCurrentExposure> BisOffBsCurrentExposures { get; set; }
        public virtual DbSet<BisOffBsOriginalExposure> BisOffBsOriginalExposures { get; set; }
        public virtual DbSet<BisOnBalance> BisOnBalances { get; set; }
        public virtual DbSet<BkFxLendingLmtClassif> BkFxLendingLmtClassifs { get; set; }
        public virtual DbSet<BkFxLendingLmtClassifMin> BkFxLendingLmtClassifMins { get; set; }
        public virtual DbSet<BkFxLendingLmtInteg> BkFxLendingLmtIntegs { get; set; }
        public virtual DbSet<BranchCodeTable> BranchCodeTables { get; set; }
        public virtual DbSet<BsByActGpMemoBaht> BsByActGpMemoBahts { get; set; }
        public virtual DbSet<BsByActGpMemoUsd> BsByActGpMemoUsds { get; set; }
        public virtual DbSet<BsByActGpOnBaht> BsByActGpOnBahts { get; set; }
        public virtual DbSet<BsByActGpOnUsd> BsByActGpOnUsds { get; set; }
        public virtual DbSet<BsByBaseCcyByDiv> BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<BsByCcyByDiv> BsByCcyByDivs { get; set; }
        public virtual DbSet<BsPlFile> BsPlFiles { get; set; }
        public virtual DbSet<CashFlow> CashFlows { get; set; }
        public virtual DbSet<CcyCodeTable> CcyCodeTables { get; set; }
        public virtual DbSet<CcyConversionRateTable> CcyConversionRateTables { get; set; }
        public virtual DbSet<CollateralAndGuarantor> CollateralAndGuarantors { get; set; }
        public virtual DbSet<CollateralCodeTable> CollateralCodeTables { get; set; }
        public virtual DbSet<CollectedPaidInterest> CollectedPaidInterests { get; set; }
        public virtual DbSet<Commitment> Commitments { get; set; }
        public virtual DbSet<ConsoliAccountCodeTable> ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<ConsoliBsPlFileSpd> ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<ConsoliBsPlFileUsd> ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<ConsoliBsPlSpd> ConsoliBsPlSpds { get; set; }
        public virtual DbSet<ConsoliBsPlUsd> ConsoliBsPlUsds { get; set; }
        public virtual DbSet<ConsoliMemoBsPlSpd> ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<ConsoliMemoBsPlUsd> ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<CorrespondentMaster> CorrespondentMasters { get; set; }
        public virtual DbSet<CountryCodeTable> CountryCodeTables { get; set; }
        public virtual DbSet<CreditLine> CreditLines { get; set; }
        public virtual DbSet<CustAttributeCodeTable> CustAttributeCodeTables { get; set; }
        public virtual DbSet<CustBnkDivProf> CustBnkDivProfs { get; set; }
        public virtual DbSet<CustProfitAnalysis> CustProfitAnalyses { get; set; }
        public virtual DbSet<CustomerBalance> CustomerBalances { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<DBisOffBsCommitAndOther> DBisOffBsCommitAndOthers { get; set; }
        public virtual DbSet<DBisOnBalance> DBisOnBalances { get; set; }
        public virtual DbSet<DEventByCcy> DEventByCcies { get; set; }
        public virtual DbSet<DEventByDfb> DEventByDfbs { get; set; }
        public virtual DbSet<DebitCreditDetail> DebitCreditDetails { get; set; }
        public virtual DbSet<DefferedLoan> DefferedLoans { get; set; }
        public virtual DbSet<DeptCodeTable> DeptCodeTables { get; set; }
        public virtual DbSet<Euctablelist> Euctablelists { get; set; }
        public virtual DbSet<Euctablelistfull> Euctablelistfulls { get; set; }
        public virtual DbSet<EuroYenLoan> EuroYenLoans { get; set; }
        public virtual DbSet<EuroyenLoanProfit> EuroyenLoanProfits { get; set; }
        public virtual DbSet<FacilityTypeOverride> FacilityTypeOverrides { get; set; }
        public virtual DbSet<FeeAndCharge> FeeAndCharges { get; set; }
        public virtual DbSet<ForeignExchange> ForeignExchanges { get; set; }
        public virtual DbSet<FwdRevalDetail> FwdRevalDetails { get; set; }
        public virtual DbSet<FwdRevalRetrace> FwdRevalRetraces { get; set; }
        public virtual DbSet<FwdValueBLogAccount> FwdValueBLogAccounts { get; set; }
        public virtual DbSet<FwdValueBLogCommon> FwdValueBLogCommons { get; set; }
        public virtual DbSet<FwdValueBLogRemit> FwdValueBLogRemits { get; set; }
        public virtual DbSet<FwdValueBLogRemitBak> FwdValueBLogRemitBaks { get; set; }
        public virtual DbSet<FwdValueRemitLimit> FwdValueRemitLimits { get; set; }
        public virtual DbSet<FxCurrentExpLmt> FxCurrentExpLmts { get; set; }
        public virtual DbSet<GenFundDivProf> GenFundDivProfs { get; set; }
        public virtual DbSet<Guarantee> Guarantees { get; set; }
        public virtual DbSet<HedgeAccountDetail> HedgeAccountDetails { get; set; }
        public virtual DbSet<HedgeActControl> HedgeActControls { get; set; }
        public virtual DbSet<HedgeDefRevalDetail> HedgeDefRevalDetails { get; set; }
        public virtual DbSet<HedgeDetail> HedgeDetails { get; set; }
        public virtual DbSet<HedgeMarketRevDetail> HedgeMarketRevDetails { get; set; }
        public virtual DbSet<HedgePortfolio> HedgePortfolios { get; set; }
        public virtual DbSet<ImpExpDocument> ImpExpDocuments { get; set; }
        public virtual DbSet<ImportAndExport> ImportAndExports { get; set; }
        public virtual DbSet<ImportLc> ImportLcs { get; set; }
        public virtual DbSet<IncomingRemittance> IncomingRemittances { get; set; }
        public virtual DbSet<IncomingRemittanceBak> IncomingRemittanceBaks { get; set; }
        public virtual DbSet<IndustryCodeTable> IndustryCodeTables { get; set; }
        public virtual DbSet<IntAndCcySwap> IntAndCcySwaps { get; set; }
        public virtual DbSet<InternalDefPlRev> InternalDefPlRevs { get; set; }
        public virtual DbSet<InternalForexRate> InternalForexRates { get; set; }
        public virtual DbSet<IssuerProfitAnalysis> IssuerProfitAnalyses { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<LoanGrtAmt> LoanGrtAmts { get; set; }
        public virtual DbSet<LoanMaturityLadder> LoanMaturityLadders { get; set; }
        public virtual DbSet<LoanRepaymentSchedule> LoanRepaymentSchedules { get; set; }
        public virtual DbSet<LoanTrancheContentBatch> LoanTrancheContentBatches { get; set; }
        public virtual DbSet<LoanTrancheMasterBatch> LoanTrancheMasterBatches { get; set; }
        public virtual DbSet<M02AccountAcmBal> M02AccountAcmBals { get; set; }
        public virtual DbSet<M02AccountCodeTable> M02AccountCodeTables { get; set; }
        public virtual DbSet<M02AccountNoBalance> M02AccountNoBalances { get; set; }
        public virtual DbSet<M02AgentGuarantee> M02AgentGuarantees { get; set; }
        public virtual DbSet<M02AgentLoan> M02AgentLoans { get; set; }
        public virtual DbSet<M02BankInf> M02BankInfs { get; set; }
        public virtual DbSet<M02BisOffBsCommitAndOth> M02BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M02BisOffBsCurrentExp> M02BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M02BisOffBsOriginalExp> M02BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M02BisOnBalance> M02BisOnBalances { get; set; }
        public virtual DbSet<M02BsByActGpMemoBaht> M02BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M02BsByActGpMemoUsd> M02BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M02BsByActGpOnBaht> M02BsByActGpOnBahts { get; set; }
        public virtual DbSet<M02BsByActGpOnUsd> M02BsByActGpOnUsds { get; set; }
        public virtual DbSet<M02BsByBaseCcyByDiv> M02BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M02BsByCcyByDiv> M02BsByCcyByDivs { get; set; }
        public virtual DbSet<M02BsPlFile> M02BsPlFiles { get; set; }
        public virtual DbSet<M02CcyCodeTable> M02CcyCodeTables { get; set; }
        public virtual DbSet<M02CcyConversionRateTable> M02CcyConversionRateTables { get; set; }
        public virtual DbSet<M02CollateralAndGuarantor> M02CollateralAndGuarantors { get; set; }
        public virtual DbSet<M02Commitment> M02Commitments { get; set; }
        public virtual DbSet<M02ConsoliAccountCodeTable> M02ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M02ConsoliBsPlFileSpd> M02ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M02ConsoliBsPlFileUsd> M02ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M02ConsoliBsPlSpd> M02ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M02ConsoliBsPlUsd> M02ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M02ConsoliMemoBsPlSpd> M02ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M02ConsoliMemoBsPlUsd> M02ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M02CorrespondentMaster> M02CorrespondentMasters { get; set; }
        public virtual DbSet<M02CreditLine> M02CreditLines { get; set; }
        public virtual DbSet<M02CustProfitAnalysis> M02CustProfitAnalyses { get; set; }
        public virtual DbSet<M02CustomerBalance> M02CustomerBalances { get; set; }
        public virtual DbSet<M02CustomerMaster> M02CustomerMasters { get; set; }
        public virtual DbSet<M02DefferedLoan> M02DefferedLoans { get; set; }
        public virtual DbSet<M02EuroYenLoan> M02EuroYenLoans { get; set; }
        public virtual DbSet<M02EuroyenLoanProfit> M02EuroyenLoanProfits { get; set; }
        public virtual DbSet<M02FeeAndCharge> M02FeeAndCharges { get; set; }
        public virtual DbSet<M02ForeignExchange> M02ForeignExchanges { get; set; }
        public virtual DbSet<M02FwdRevalDetail> M02FwdRevalDetails { get; set; }
        public virtual DbSet<M02FwdRevalRetrace> M02FwdRevalRetraces { get; set; }
        public virtual DbSet<M02FxCurrentExpLmt> M02FxCurrentExpLmts { get; set; }
        public virtual DbSet<M02Guarantee> M02Guarantees { get; set; }
        public virtual DbSet<M02HedgeDefRevalDetail> M02HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M02ImpExpDocument> M02ImpExpDocuments { get; set; }
        public virtual DbSet<M02ImportAndExport> M02ImportAndExports { get; set; }
        public virtual DbSet<M02ImportLc> M02ImportLcs { get; set; }
        public virtual DbSet<M02IntAndCcySwap> M02IntAndCcySwaps { get; set; }
        public virtual DbSet<M02IssuerProfitAnalysis> M02IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M02Loan> M02Loans { get; set; }
        public virtual DbSet<M02LoanRepaymentSchedule> M02LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M02ManualRevisionDetail> M02ManualRevisionDetails { get; set; }
        public virtual DbSet<M02MoneyMarketTran> M02MoneyMarketTrans { get; set; }
        public virtual DbSet<M02ProfByAccCdByAccNo> M02ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M02RevalSwapPl> M02RevalSwapPls { get; set; }
        public virtual DbSet<M02Security> M02Securities { get; set; }
        public virtual DbSet<M02SecurityDetail> M02SecurityDetails { get; set; }
        public virtual DbSet<M02SettlRetraceInput> M02SettlRetraceInputs { get; set; }
        public virtual DbSet<M02SettlementInf> M02SettlementInfs { get; set; }
        public virtual DbSet<M02SwapCurrentExpLmt> M02SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M02SystemRevisionDetail> M02SystemRevisionDetails { get; set; }
        public virtual DbSet<M02TotalCreditLine> M02TotalCreditLines { get; set; }
        public virtual DbSet<M02TreasuryProfitByTran> M02TreasuryProfitByTrans { get; set; }
        public virtual DbSet<M03AccountAcmBal> M03AccountAcmBals { get; set; }
        public virtual DbSet<M03AccountCodeTable> M03AccountCodeTables { get; set; }
        public virtual DbSet<M03AccountNoBalance> M03AccountNoBalances { get; set; }
        public virtual DbSet<M03AgentGuarantee> M03AgentGuarantees { get; set; }
        public virtual DbSet<M03AgentLoan> M03AgentLoans { get; set; }
        public virtual DbSet<M03BankInf> M03BankInfs { get; set; }
        public virtual DbSet<M03BisOffBsCommitAndOth> M03BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M03BisOffBsCurrentExp> M03BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M03BisOffBsOriginalExp> M03BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M03BisOnBalance> M03BisOnBalances { get; set; }
        public virtual DbSet<M03BsByActGpMemoBaht> M03BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M03BsByActGpMemoUsd> M03BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M03BsByActGpOnBaht> M03BsByActGpOnBahts { get; set; }
        public virtual DbSet<M03BsByActGpOnUsd> M03BsByActGpOnUsds { get; set; }
        public virtual DbSet<M03BsByBaseCcyByDiv> M03BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M03BsByCcyByDiv> M03BsByCcyByDivs { get; set; }
        public virtual DbSet<M03BsPlFile> M03BsPlFiles { get; set; }
        public virtual DbSet<M03CcyCodeTable> M03CcyCodeTables { get; set; }
        public virtual DbSet<M03CcyConversionRateTable> M03CcyConversionRateTables { get; set; }
        public virtual DbSet<M03CollateralAndGuarantor> M03CollateralAndGuarantors { get; set; }
        public virtual DbSet<M03Commitment> M03Commitments { get; set; }
        public virtual DbSet<M03ConsoliAccountCodeTable> M03ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M03ConsoliBsPlFileSpd> M03ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M03ConsoliBsPlFileUsd> M03ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M03ConsoliBsPlSpd> M03ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M03ConsoliBsPlUsd> M03ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M03ConsoliMemoBsPlSpd> M03ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M03ConsoliMemoBsPlUsd> M03ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M03CorrespondentMaster> M03CorrespondentMasters { get; set; }
        public virtual DbSet<M03CreditLine> M03CreditLines { get; set; }
        public virtual DbSet<M03CustProfitAnalysis> M03CustProfitAnalyses { get; set; }
        public virtual DbSet<M03CustomerBalance> M03CustomerBalances { get; set; }
        public virtual DbSet<M03CustomerMaster> M03CustomerMasters { get; set; }
        public virtual DbSet<M03DefferedLoan> M03DefferedLoans { get; set; }
        public virtual DbSet<M03EuroYenLoan> M03EuroYenLoans { get; set; }
        public virtual DbSet<M03EuroyenLoanProfit> M03EuroyenLoanProfits { get; set; }
        public virtual DbSet<M03FeeAndCharge> M03FeeAndCharges { get; set; }
        public virtual DbSet<M03ForeignExchange> M03ForeignExchanges { get; set; }
        public virtual DbSet<M03FwdRevalDetail> M03FwdRevalDetails { get; set; }
        public virtual DbSet<M03FwdRevalRetrace> M03FwdRevalRetraces { get; set; }
        public virtual DbSet<M03FxCurrentExpLmt> M03FxCurrentExpLmts { get; set; }
        public virtual DbSet<M03Guarantee> M03Guarantees { get; set; }
        public virtual DbSet<M03HedgeDefRevalDetail> M03HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M03ImpExpDocument> M03ImpExpDocuments { get; set; }
        public virtual DbSet<M03ImportAndExport> M03ImportAndExports { get; set; }
        public virtual DbSet<M03ImportLc> M03ImportLcs { get; set; }
        public virtual DbSet<M03IntAndCcySwap> M03IntAndCcySwaps { get; set; }
        public virtual DbSet<M03IssuerProfitAnalysis> M03IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M03Loan> M03Loans { get; set; }
        public virtual DbSet<M03LoanRepaymentSchedule> M03LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M03ManualRevisionDetail> M03ManualRevisionDetails { get; set; }
        public virtual DbSet<M03MoneyMarketTran> M03MoneyMarketTrans { get; set; }
        public virtual DbSet<M03ProfByAccCdByAccNo> M03ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M03RevalSwapPl> M03RevalSwapPls { get; set; }
        public virtual DbSet<M03Security> M03Securities { get; set; }
        public virtual DbSet<M03SecurityDetail> M03SecurityDetails { get; set; }
        public virtual DbSet<M03SettlRetraceInput> M03SettlRetraceInputs { get; set; }
        public virtual DbSet<M03SettlementInf> M03SettlementInfs { get; set; }
        public virtual DbSet<M03SwapCurrentExpLmt> M03SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M03SystemRevisionDetail> M03SystemRevisionDetails { get; set; }
        public virtual DbSet<M03TotalCreditLine> M03TotalCreditLines { get; set; }
        public virtual DbSet<M03TreasuryProfitByTran> M03TreasuryProfitByTrans { get; set; }
        public virtual DbSet<M04AccountAcmBal> M04AccountAcmBals { get; set; }
        public virtual DbSet<M04AccountCodeTable> M04AccountCodeTables { get; set; }
        public virtual DbSet<M04AccountNoBalance> M04AccountNoBalances { get; set; }
        public virtual DbSet<M04AgentGuarantee> M04AgentGuarantees { get; set; }
        public virtual DbSet<M04AgentLoan> M04AgentLoans { get; set; }
        public virtual DbSet<M04BankInf> M04BankInfs { get; set; }
        public virtual DbSet<M04BisOffBsCommitAndOth> M04BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M04BisOffBsCurrentExp> M04BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M04BisOffBsOriginalExp> M04BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M04BisOnBalance> M04BisOnBalances { get; set; }
        public virtual DbSet<M04BsByActGpMemoBaht> M04BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M04BsByActGpMemoUsd> M04BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M04BsByActGpOnBaht> M04BsByActGpOnBahts { get; set; }
        public virtual DbSet<M04BsByActGpOnUsd> M04BsByActGpOnUsds { get; set; }
        public virtual DbSet<M04BsByBaseCcyByDiv> M04BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M04BsByCcyByDiv> M04BsByCcyByDivs { get; set; }
        public virtual DbSet<M04BsPlFile> M04BsPlFiles { get; set; }
        public virtual DbSet<M04CcyCodeTable> M04CcyCodeTables { get; set; }
        public virtual DbSet<M04CcyConversionRateTable> M04CcyConversionRateTables { get; set; }
        public virtual DbSet<M04CollateralAndGuarantor> M04CollateralAndGuarantors { get; set; }
        public virtual DbSet<M04Commitment> M04Commitments { get; set; }
        public virtual DbSet<M04ConsoliAccountCodeTable> M04ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M04ConsoliBsPlFileSpd> M04ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M04ConsoliBsPlFileUsd> M04ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M04ConsoliBsPlSpd> M04ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M04ConsoliBsPlUsd> M04ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M04ConsoliMemoBsPlSpd> M04ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M04ConsoliMemoBsPlUsd> M04ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M04CorrespondentMaster> M04CorrespondentMasters { get; set; }
        public virtual DbSet<M04CreditLine> M04CreditLines { get; set; }
        public virtual DbSet<M04CustProfitAnalysis> M04CustProfitAnalyses { get; set; }
        public virtual DbSet<M04CustomerBalance> M04CustomerBalances { get; set; }
        public virtual DbSet<M04CustomerMaster> M04CustomerMasters { get; set; }
        public virtual DbSet<M04DefferedLoan> M04DefferedLoans { get; set; }
        public virtual DbSet<M04EuroYenLoan> M04EuroYenLoans { get; set; }
        public virtual DbSet<M04EuroyenLoanProfit> M04EuroyenLoanProfits { get; set; }
        public virtual DbSet<M04FeeAndCharge> M04FeeAndCharges { get; set; }
        public virtual DbSet<M04ForeignExchange> M04ForeignExchanges { get; set; }
        public virtual DbSet<M04FwdRevalDetail> M04FwdRevalDetails { get; set; }
        public virtual DbSet<M04FwdRevalRetrace> M04FwdRevalRetraces { get; set; }
        public virtual DbSet<M04FxCurrentExpLmt> M04FxCurrentExpLmts { get; set; }
        public virtual DbSet<M04Guarantee> M04Guarantees { get; set; }
        public virtual DbSet<M04HedgeDefRevalDetail> M04HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M04ImpExpDocument> M04ImpExpDocuments { get; set; }
        public virtual DbSet<M04ImportAndExport> M04ImportAndExports { get; set; }
        public virtual DbSet<M04ImportLc> M04ImportLcs { get; set; }
        public virtual DbSet<M04IntAndCcySwap> M04IntAndCcySwaps { get; set; }
        public virtual DbSet<M04IssuerProfitAnalysis> M04IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M04Loan> M04Loans { get; set; }
        public virtual DbSet<M04LoanRepaymentSchedule> M04LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M04ManualRevisionDetail> M04ManualRevisionDetails { get; set; }
        public virtual DbSet<M04MoneyMarketTran> M04MoneyMarketTrans { get; set; }
        public virtual DbSet<M04ProfByAccCdByAccNo> M04ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M04RevalSwapPl> M04RevalSwapPls { get; set; }
        public virtual DbSet<M04Security> M04Securities { get; set; }
        public virtual DbSet<M04SecurityDetail> M04SecurityDetails { get; set; }
        public virtual DbSet<M04SettlRetraceInput> M04SettlRetraceInputs { get; set; }
        public virtual DbSet<M04SettlementInf> M04SettlementInfs { get; set; }
        public virtual DbSet<M04SwapCurrentExpLmt> M04SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M04SystemRevisionDetail> M04SystemRevisionDetails { get; set; }
        public virtual DbSet<M04TotalCreditLine> M04TotalCreditLines { get; set; }
        public virtual DbSet<M04TreasuryProfitByTran> M04TreasuryProfitByTrans { get; set; }
        public virtual DbSet<M05AccountAcmBal> M05AccountAcmBals { get; set; }
        public virtual DbSet<M05AccountCodeTable> M05AccountCodeTables { get; set; }
        public virtual DbSet<M05AccountNoBalance> M05AccountNoBalances { get; set; }
        public virtual DbSet<M05AgentGuarantee> M05AgentGuarantees { get; set; }
        public virtual DbSet<M05AgentLoan> M05AgentLoans { get; set; }
        public virtual DbSet<M05BankInf> M05BankInfs { get; set; }
        public virtual DbSet<M05BisOffBsCommitAndOth> M05BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M05BisOffBsCurrentExp> M05BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M05BisOffBsOriginalExp> M05BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M05BisOnBalance> M05BisOnBalances { get; set; }
        public virtual DbSet<M05BsByActGpMemoBaht> M05BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M05BsByActGpMemoUsd> M05BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M05BsByActGpOnBaht> M05BsByActGpOnBahts { get; set; }
        public virtual DbSet<M05BsByActGpOnUsd> M05BsByActGpOnUsds { get; set; }
        public virtual DbSet<M05BsByBaseCcyByDiv> M05BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M05BsByCcyByDiv> M05BsByCcyByDivs { get; set; }
        public virtual DbSet<M05BsPlFile> M05BsPlFiles { get; set; }
        public virtual DbSet<M05CcyCodeTable> M05CcyCodeTables { get; set; }
        public virtual DbSet<M05CcyConversionRateTable> M05CcyConversionRateTables { get; set; }
        public virtual DbSet<M05CollateralAndGuarantor> M05CollateralAndGuarantors { get; set; }
        public virtual DbSet<M05Commitment> M05Commitments { get; set; }
        public virtual DbSet<M05ConsoliAccountCodeTable> M05ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M05ConsoliBsPlFileSpd> M05ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M05ConsoliBsPlFileUsd> M05ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M05ConsoliBsPlSpd> M05ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M05ConsoliBsPlUsd> M05ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M05ConsoliMemoBsPlSpd> M05ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M05ConsoliMemoBsPlUsd> M05ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M05CorrespondentMaster> M05CorrespondentMasters { get; set; }
        public virtual DbSet<M05CreditLine> M05CreditLines { get; set; }
        public virtual DbSet<M05CustProfitAnalysis> M05CustProfitAnalyses { get; set; }
        public virtual DbSet<M05CustomerBalance> M05CustomerBalances { get; set; }
        public virtual DbSet<M05CustomerMaster> M05CustomerMasters { get; set; }
        public virtual DbSet<M05DefferedLoan> M05DefferedLoans { get; set; }
        public virtual DbSet<M05EuroYenLoan> M05EuroYenLoans { get; set; }
        public virtual DbSet<M05EuroyenLoanProfit> M05EuroyenLoanProfits { get; set; }
        public virtual DbSet<M05FeeAndCharge> M05FeeAndCharges { get; set; }
        public virtual DbSet<M05ForeignExchange> M05ForeignExchanges { get; set; }
        public virtual DbSet<M05FwdRevalDetail> M05FwdRevalDetails { get; set; }
        public virtual DbSet<M05FwdRevalRetrace> M05FwdRevalRetraces { get; set; }
        public virtual DbSet<M05FxCurrentExpLmt> M05FxCurrentExpLmts { get; set; }
        public virtual DbSet<M05Guarantee> M05Guarantees { get; set; }
        public virtual DbSet<M05HedgeDefRevalDetail> M05HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M05ImpExpDocument> M05ImpExpDocuments { get; set; }
        public virtual DbSet<M05ImportAndExport> M05ImportAndExports { get; set; }
        public virtual DbSet<M05ImportLc> M05ImportLcs { get; set; }
        public virtual DbSet<M05IntAndCcySwap> M05IntAndCcySwaps { get; set; }
        public virtual DbSet<M05IssuerProfitAnalysis> M05IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M05Loan> M05Loans { get; set; }
        public virtual DbSet<M05LoanRepaymentSchedule> M05LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M05ManualRevisionDetail> M05ManualRevisionDetails { get; set; }
        public virtual DbSet<M05MoneyMarketTran> M05MoneyMarketTrans { get; set; }
        public virtual DbSet<M05ProfByAccCdByAccNo> M05ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M05RevalSwapPl> M05RevalSwapPls { get; set; }
        public virtual DbSet<M05Security> M05Securities { get; set; }
        public virtual DbSet<M05SecurityDetail> M05SecurityDetails { get; set; }
        public virtual DbSet<M05SettlRetraceInput> M05SettlRetraceInputs { get; set; }
        public virtual DbSet<M05SettlementInf> M05SettlementInfs { get; set; }
        public virtual DbSet<M05SwapCurrentExpLmt> M05SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M05SystemRevisionDetail> M05SystemRevisionDetails { get; set; }
        public virtual DbSet<M05TotalCreditLine> M05TotalCreditLines { get; set; }
        public virtual DbSet<M05TreasuryProfitByTran> M05TreasuryProfitByTrans { get; set; }
        public virtual DbSet<M06AccountAcmBal> M06AccountAcmBals { get; set; }
        public virtual DbSet<M06AccountCodeTable> M06AccountCodeTables { get; set; }
        public virtual DbSet<M06AccountNoBalance> M06AccountNoBalances { get; set; }
        public virtual DbSet<M06AgentGuarantee> M06AgentGuarantees { get; set; }
        public virtual DbSet<M06AgentLoan> M06AgentLoans { get; set; }
        public virtual DbSet<M06BankInf> M06BankInfs { get; set; }
        public virtual DbSet<M06BisOffBsCommitAndOth> M06BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M06BisOffBsCurrentExp> M06BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M06BisOffBsOriginalExp> M06BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M06BisOnBalance> M06BisOnBalances { get; set; }
        public virtual DbSet<M06BsByActGpMemoBaht> M06BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M06BsByActGpMemoUsd> M06BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M06BsByActGpOnBaht> M06BsByActGpOnBahts { get; set; }
        public virtual DbSet<M06BsByActGpOnUsd> M06BsByActGpOnUsds { get; set; }
        public virtual DbSet<M06BsByBaseCcyByDiv> M06BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M06BsByCcyByDiv> M06BsByCcyByDivs { get; set; }
        public virtual DbSet<M06BsPlFile> M06BsPlFiles { get; set; }
        public virtual DbSet<M06CcyCodeTable> M06CcyCodeTables { get; set; }
        public virtual DbSet<M06CcyConversionRateTable> M06CcyConversionRateTables { get; set; }
        public virtual DbSet<M06CollateralAndGuarantor> M06CollateralAndGuarantors { get; set; }
        public virtual DbSet<M06Commitment> M06Commitments { get; set; }
        public virtual DbSet<M06ConsoliAccountCodeTable> M06ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M06ConsoliBsPlFileSpd> M06ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M06ConsoliBsPlFileUsd> M06ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M06ConsoliBsPlSpd> M06ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M06ConsoliBsPlUsd> M06ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M06ConsoliMemoBsPlSpd> M06ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M06ConsoliMemoBsPlUsd> M06ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M06CorrespondentMaster> M06CorrespondentMasters { get; set; }
        public virtual DbSet<M06CreditLine> M06CreditLines { get; set; }
        public virtual DbSet<M06CustProfitAnalysis> M06CustProfitAnalyses { get; set; }
        public virtual DbSet<M06CustomerBalance> M06CustomerBalances { get; set; }
        public virtual DbSet<M06CustomerMaster> M06CustomerMasters { get; set; }
        public virtual DbSet<M06DefferedLoan> M06DefferedLoans { get; set; }
        public virtual DbSet<M06EuroYenLoan> M06EuroYenLoans { get; set; }
        public virtual DbSet<M06EuroyenLoanProfit> M06EuroyenLoanProfits { get; set; }
        public virtual DbSet<M06FeeAndCharge> M06FeeAndCharges { get; set; }
        public virtual DbSet<M06ForeignExchange> M06ForeignExchanges { get; set; }
        public virtual DbSet<M06FwdRevalDetail> M06FwdRevalDetails { get; set; }
        public virtual DbSet<M06FwdRevalRetrace> M06FwdRevalRetraces { get; set; }
        public virtual DbSet<M06FxCurrentExpLmt> M06FxCurrentExpLmts { get; set; }
        public virtual DbSet<M06Guarantee> M06Guarantees { get; set; }
        public virtual DbSet<M06HedgeDefRevalDetail> M06HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M06ImpExpDocument> M06ImpExpDocuments { get; set; }
        public virtual DbSet<M06ImportAndExport> M06ImportAndExports { get; set; }
        public virtual DbSet<M06ImportLc> M06ImportLcs { get; set; }
        public virtual DbSet<M06IntAndCcySwap> M06IntAndCcySwaps { get; set; }
        public virtual DbSet<M06IssuerProfitAnalysis> M06IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M06Loan> M06Loans { get; set; }
        public virtual DbSet<M06LoanRepaymentSchedule> M06LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M06ManualRevisionDetail> M06ManualRevisionDetails { get; set; }
        public virtual DbSet<M06MoneyMarketTran> M06MoneyMarketTrans { get; set; }
        public virtual DbSet<M06ProfByAccCdByAccNo> M06ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M06RevalSwapPl> M06RevalSwapPls { get; set; }
        public virtual DbSet<M06Security> M06Securities { get; set; }
        public virtual DbSet<M06SecurityDetail> M06SecurityDetails { get; set; }
        public virtual DbSet<M06SettlRetraceInput> M06SettlRetraceInputs { get; set; }
        public virtual DbSet<M06SettlementInf> M06SettlementInfs { get; set; }
        public virtual DbSet<M06SwapCurrentExpLmt> M06SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M06SystemRevisionDetail> M06SystemRevisionDetails { get; set; }
        public virtual DbSet<M06TotalCreditLine> M06TotalCreditLines { get; set; }
        public virtual DbSet<M06TreasuryProfitByTran> M06TreasuryProfitByTrans { get; set; }
        public virtual DbSet<M07AccountAcmBal> M07AccountAcmBals { get; set; }
        public virtual DbSet<M07AccountCodeTable> M07AccountCodeTables { get; set; }
        public virtual DbSet<M07AccountNoBalance> M07AccountNoBalances { get; set; }
        public virtual DbSet<M07AgentGuarantee> M07AgentGuarantees { get; set; }
        public virtual DbSet<M07AgentLoan> M07AgentLoans { get; set; }
        public virtual DbSet<M07BankInf> M07BankInfs { get; set; }
        public virtual DbSet<M07BisOffBsCommitAndOth> M07BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<M07BisOffBsCurrentExp> M07BisOffBsCurrentExps { get; set; }
        public virtual DbSet<M07BisOffBsOriginalExp> M07BisOffBsOriginalExps { get; set; }
        public virtual DbSet<M07BisOnBalance> M07BisOnBalances { get; set; }
        public virtual DbSet<M07BsByActGpMemoBaht> M07BsByActGpMemoBahts { get; set; }
        public virtual DbSet<M07BsByActGpMemoUsd> M07BsByActGpMemoUsds { get; set; }
        public virtual DbSet<M07BsByActGpOnBaht> M07BsByActGpOnBahts { get; set; }
        public virtual DbSet<M07BsByActGpOnUsd> M07BsByActGpOnUsds { get; set; }
        public virtual DbSet<M07BsByBaseCcyByDiv> M07BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<M07BsByCcyByDiv> M07BsByCcyByDivs { get; set; }
        public virtual DbSet<M07BsPlFile> M07BsPlFiles { get; set; }
        public virtual DbSet<M07CcyCodeTable> M07CcyCodeTables { get; set; }
        public virtual DbSet<M07CcyConversionRateTable> M07CcyConversionRateTables { get; set; }
        public virtual DbSet<M07CollateralAndGuarantor> M07CollateralAndGuarantors { get; set; }
        public virtual DbSet<M07Commitment> M07Commitments { get; set; }
        public virtual DbSet<M07ConsoliAccountCodeTable> M07ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<M07ConsoliBsPlFileSpd> M07ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<M07ConsoliBsPlFileUsd> M07ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<M07ConsoliBsPlSpd> M07ConsoliBsPlSpds { get; set; }
        public virtual DbSet<M07ConsoliBsPlUsd> M07ConsoliBsPlUsds { get; set; }
        public virtual DbSet<M07ConsoliMemoBsPlSpd> M07ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<M07ConsoliMemoBsPlUsd> M07ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<M07CorrespondentMaster> M07CorrespondentMasters { get; set; }
        public virtual DbSet<M07CreditLine> M07CreditLines { get; set; }
        public virtual DbSet<M07CustProfitAnalysis> M07CustProfitAnalyses { get; set; }
        public virtual DbSet<M07CustomerBalance> M07CustomerBalances { get; set; }
        public virtual DbSet<M07CustomerMaster> M07CustomerMasters { get; set; }
        public virtual DbSet<M07DefferedLoan> M07DefferedLoans { get; set; }
        public virtual DbSet<M07EuroYenLoan> M07EuroYenLoans { get; set; }
        public virtual DbSet<M07EuroyenLoanProfit> M07EuroyenLoanProfits { get; set; }
        public virtual DbSet<M07FeeAndCharge> M07FeeAndCharges { get; set; }
        public virtual DbSet<M07ForeignExchange> M07ForeignExchanges { get; set; }
        public virtual DbSet<M07FwdRevalDetail> M07FwdRevalDetails { get; set; }
        public virtual DbSet<M07FwdRevalRetrace> M07FwdRevalRetraces { get; set; }
        public virtual DbSet<M07FxCurrentExpLmt> M07FxCurrentExpLmts { get; set; }
        public virtual DbSet<M07Guarantee> M07Guarantees { get; set; }
        public virtual DbSet<M07HedgeDefRevalDetail> M07HedgeDefRevalDetails { get; set; }
        public virtual DbSet<M07ImpExpDocument> M07ImpExpDocuments { get; set; }
        public virtual DbSet<M07ImportAndExport> M07ImportAndExports { get; set; }
        public virtual DbSet<M07ImportLc> M07ImportLcs { get; set; }
        public virtual DbSet<M07IntAndCcySwap> M07IntAndCcySwaps { get; set; }
        public virtual DbSet<M07IssuerProfitAnalysis> M07IssuerProfitAnalyses { get; set; }
        public virtual DbSet<M07Loan> M07Loans { get; set; }
        public virtual DbSet<M07LoanRepaymentSchedule> M07LoanRepaymentSchedules { get; set; }
        public virtual DbSet<M07ManualRevisionDetail> M07ManualRevisionDetails { get; set; }
        public virtual DbSet<M07MoneyMarketTran> M07MoneyMarketTrans { get; set; }
        public virtual DbSet<M07ProfByAccCdByAccNo> M07ProfByAccCdByAccNos { get; set; }
        public virtual DbSet<M07RevalSwapPl> M07RevalSwapPls { get; set; }
        public virtual DbSet<M07Security> M07Securities { get; set; }
        public virtual DbSet<M07SecurityDetail> M07SecurityDetails { get; set; }
        public virtual DbSet<M07SettlRetraceInput> M07SettlRetraceInputs { get; set; }
        public virtual DbSet<M07SettlementInf> M07SettlementInfs { get; set; }
        public virtual DbSet<M07SwapCurrentExpLmt> M07SwapCurrentExpLmts { get; set; }
        public virtual DbSet<M07SystemRevisionDetail> M07SystemRevisionDetails { get; set; }
        public virtual DbSet<M07TotalCreditLine> M07TotalCreditLines { get; set; }
        public virtual DbSet<M07TreasuryProfitByTran> M07TreasuryProfitByTrans { get; set; }
        public virtual DbSet<MAccountAcmBal> MAccountAcmBals { get; set; }
        public virtual DbSet<MAccountCodeTable> MAccountCodeTables { get; set; }
        public virtual DbSet<MAccountNoBalance> MAccountNoBalances { get; set; }
        public virtual DbSet<MAgentGuarantee> MAgentGuarantees { get; set; }
        public virtual DbSet<MAgentLoan> MAgentLoans { get; set; }
        public virtual DbSet<MBankInf> MBankInfs { get; set; }
        public virtual DbSet<MBankMoneyLendingLimit> MBankMoneyLendingLimits { get; set; }
        public virtual DbSet<MBaseRateTable> MBaseRateTables { get; set; }
        public virtual DbSet<MBkFxLendingLmtClassif> MBkFxLendingLmtClassifs { get; set; }
        public virtual DbSet<MBkFxLendingLmtClassifmin> MBkFxLendingLmtClassifmins { get; set; }
        public virtual DbSet<MBkFxLendingLmtInteg> MBkFxLendingLmtIntegs { get; set; }
        public virtual DbSet<MBranchCodeTable> MBranchCodeTables { get; set; }
        public virtual DbSet<MBsByActGpMemoBaht> MBsByActGpMemoBahts { get; set; }
        public virtual DbSet<MBsByActGpMemoUsd> MBsByActGpMemoUsds { get; set; }
        public virtual DbSet<MBsByActGpOnBaht> MBsByActGpOnBahts { get; set; }
        public virtual DbSet<MBsByActGpOnUsd> MBsByActGpOnUsds { get; set; }
        public virtual DbSet<MBsByBaseCcyByDiv> MBsByBaseCcyByDivs { get; set; }
        public virtual DbSet<MBsByCcyByDiv> MBsByCcyByDivs { get; set; }
        public virtual DbSet<MBsPlFile> MBsPlFiles { get; set; }
        public virtual DbSet<MCcyCodeTable> MCcyCodeTables { get; set; }
        public virtual DbSet<MCcyConversionRateTable> MCcyConversionRateTables { get; set; }
        public virtual DbSet<MCollateralAndGuarantor> MCollateralAndGuarantors { get; set; }
        public virtual DbSet<MCollateralCodeTable> MCollateralCodeTables { get; set; }
        public virtual DbSet<MCommitment> MCommitments { get; set; }
        public virtual DbSet<MConsoliAccountCodeTable> MConsoliAccountCodeTables { get; set; }
        public virtual DbSet<MConsoliBsPlFileSpd> MConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<MConsoliBsPlFileUsd> MConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<MConsoliBsPlSpd> MConsoliBsPlSpds { get; set; }
        public virtual DbSet<MConsoliBsPlUsd> MConsoliBsPlUsds { get; set; }
        public virtual DbSet<MConsoliMemoBsPlSpd> MConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<MConsoliMemoBsPlUsd> MConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<MCorrespondentMaster> MCorrespondentMasters { get; set; }
        public virtual DbSet<MCountryCodeTable> MCountryCodeTables { get; set; }
        public virtual DbSet<MCreditLine> MCreditLines { get; set; }
        public virtual DbSet<MCustAttributeCodeTable> MCustAttributeCodeTables { get; set; }
        public virtual DbSet<MCustomerBalance> MCustomerBalances { get; set; }
        public virtual DbSet<MCustomerMaster> MCustomerMasters { get; set; }
        public virtual DbSet<MDeptCodeTable> MDeptCodeTables { get; set; }
        public virtual DbSet<MEuroYenLoan> MEuroYenLoans { get; set; }
        public virtual DbSet<MFeeAndCharge> MFeeAndCharges { get; set; }
        public virtual DbSet<MForeignExchange> MForeignExchanges { get; set; }
        public virtual DbSet<MFwdRevalRetrace> MFwdRevalRetraces { get; set; }
        public virtual DbSet<MFwdValueRemitLimit> MFwdValueRemitLimits { get; set; }
        public virtual DbSet<MFxCurrentExpLmt> MFxCurrentExpLmts { get; set; }
        public virtual DbSet<MGuarantee> MGuarantees { get; set; }
        public virtual DbSet<MHedgeDefRevalDetail> MHedgeDefRevalDetails { get; set; }
        public virtual DbSet<MImpExpDocument> MImpExpDocuments { get; set; }
        public virtual DbSet<MImportAndExport> MImportAndExports { get; set; }
        public virtual DbSet<MImportLc> MImportLcs { get; set; }
        public virtual DbSet<MIndustryCodeTable> MIndustryCodeTables { get; set; }
        public virtual DbSet<MIntAndCcySwap> MIntAndCcySwaps { get; set; }
        public virtual DbSet<MLoan> MLoans { get; set; }
        public virtual DbSet<MLoanRepaymentSchedule> MLoanRepaymentSchedules { get; set; }
        public virtual DbSet<MMoneyMarketTran> MMoneyMarketTrans { get; set; }
        public virtual DbSet<MPurposeCodeTable> MPurposeCodeTables { get; set; }
        public virtual DbSet<MRevalSwapPl> MRevalSwapPls { get; set; }
        public virtual DbSet<MSecurity> MSecurities { get; set; }
        public virtual DbSet<MSecurityDetail> MSecurityDetails { get; set; }
        public virtual DbSet<MSettlRetraceInput> MSettlRetraceInputs { get; set; }
        public virtual DbSet<MSettlementInf> MSettlementInfs { get; set; }
        public virtual DbSet<MSwapCurrentExpLmt> MSwapCurrentExpLmts { get; set; }
        public virtual DbSet<MTotalCreditLine> MTotalCreditLines { get; set; }
        public virtual DbSet<ManualRevisionDetail> ManualRevisionDetails { get; set; }
        public virtual DbSet<MiscellaneousInf> MiscellaneousInfs { get; set; }
        public virtual DbSet<MoneyMarketTran> MoneyMarketTrans { get; set; }
        public virtual DbSet<MonthlyCustomerBalance> MonthlyCustomerBalances { get; set; }
        public virtual DbSet<NetWrixAuditError> NetWrixAuditErrors { get; set; }
        public virtual DbSet<OffBsCashFlowBot> OffBsCashFlowBots { get; set; }
        public virtual DbSet<OnDemandBatch> OnDemandBatches { get; set; }
        public virtual DbSet<OnDemandBatchLog> OnDemandBatchLogs { get; set; }
        public virtual DbSet<OnDemandLock> OnDemandLocks { get; set; }
        public virtual DbSet<OndemandCreditLine> OndemandCreditLines { get; set; }
        public virtual DbSet<OndemandCustomerMaster> OndemandCustomerMasters { get; set; }
        public virtual DbSet<OndemandCustomersAccount> OndemandCustomersAccounts { get; set; }
        public virtual DbSet<OndemandForeignExchange> OndemandForeignExchanges { get; set; }
        public virtual DbSet<OndemandGuarantee> OndemandGuarantees { get; set; }
        public virtual DbSet<OndemandImpExpDocument> OndemandImpExpDocuments { get; set; }
        public virtual DbSet<OndemandImportAndExport> OndemandImportAndExports { get; set; }
        public virtual DbSet<OndemandImportLc> OndemandImportLcs { get; set; }
        public virtual DbSet<OndemandIntAndCcySwap> OndemandIntAndCcySwaps { get; set; }
        public virtual DbSet<OndemandLoan> OndemandLoans { get; set; }
        public virtual DbSet<OndemandLogAccount> OndemandLogAccounts { get; set; }
        public virtual DbSet<OndemandLogCommon> OndemandLogCommons { get; set; }
        public virtual DbSet<OndemandLogRemittance> OndemandLogRemittances { get; set; }
        public virtual DbSet<OndemandMiscellaneousInf> OndemandMiscellaneousInfs { get; set; }
        public virtual DbSet<OndemandMoneyMarketTran> OndemandMoneyMarketTrans { get; set; }
        public virtual DbSet<OndemandSecurity> OndemandSecurities { get; set; }
        public virtual DbSet<OndemandSwapFxLmt> OndemandSwapFxLmts { get; set; }
        public virtual DbSet<OndemandTotalCreditLine> OndemandTotalCreditLines { get; set; }
        public virtual DbSet<Ondemandtablelist> Ondemandtablelists { get; set; }
        public virtual DbSet<Ondemandtablelistfull> Ondemandtablelistfulls { get; set; }
        public virtual DbSet<OndmTableReadFlag> OndmTableReadFlags { get; set; }
        public virtual DbSet<OndmViewCustomersAccount> OndmViewCustomersAccounts { get; set; }
        public virtual DbSet<OndmViewFx> OndmViewFxes { get; set; }
        public virtual DbSet<OndmViewImpExp> OndmViewImpExps { get; set; }
        public virtual DbSet<OndmViewIntCcy> OndmViewIntCcies { get; set; }
        public virtual DbSet<OndmViewLoan> OndmViewLoans { get; set; }
        public virtual DbSet<OndmViewMm> OndmViewMms { get; set; }
        public virtual DbSet<OndmViewSecurity> OndmViewSecurities { get; set; }
        public virtual DbSet<OsBnkDivProf> OsBnkDivProfs { get; set; }
        public virtual DbSet<OtherDivSemiAnnual> OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<OutgoingRemittance> OutgoingRemittances { get; set; }
        public virtual DbSet<OutgoingRemittanceBak> OutgoingRemittanceBaks { get; set; }
        public virtual DbSet<OutgoingRemittanceMt360> OutgoingRemittanceMt360s { get; set; }
        public virtual DbSet<PoolingDetailFile> PoolingDetailFiles { get; set; }
        public virtual DbSet<ProfBalByCustByProd> ProfBalByCustByProds { get; set; }
        public virtual DbSet<ProfBalByPurpose> ProfBalByPurposes { get; set; }
        public virtual DbSet<ProfitByAccCdByAccNo> ProfitByAccCdByAccNos { get; set; }
        public virtual DbSet<ProfitDetailByTran> ProfitDetailByTrans { get; set; }
        public virtual DbSet<PurposeCodeTable> PurposeCodeTables { get; set; }
        public virtual DbSet<RemainPerIntSwap> RemainPerIntSwaps { get; set; }
        public virtual DbSet<RevalSwapDepoPl> RevalSwapDepoPls { get; set; }
        public virtual DbSet<RevalSwapPl> RevalSwapPls { get; set; }
        public virtual DbSet<RevalSwapPlExPro> RevalSwapPlExPros { get; set; }
        public virtual DbSet<RevalSwapPlExProBot> RevalSwapPlExProBots { get; set; }
        public virtual DbSet<RevisionByCcyByAct> RevisionByCcyByActs { get; set; }
        public virtual DbSet<RptGlobalTradeFinanceLcrExport> RptGlobalTradeFinanceLcrExports { get; set; }
        public virtual DbSet<RptGlobalTradeFinanceLcrRaw> RptGlobalTradeFinanceLcrRaws { get; set; }
        public virtual DbSet<RptGlobalTradeFinanceLcrSummary> RptGlobalTradeFinanceLcrSummaries { get; set; }
        public virtual DbSet<SchemeProfAnalysis> SchemeProfAnalyses { get; set; }
        public virtual DbSet<Security> Securities { get; set; }
        public virtual DbSet<SecurityBnkDivProf> SecurityBnkDivProfs { get; set; }
        public virtual DbSet<SemiAnnualByCust> SemiAnnualByCusts { get; set; }
        public virtual DbSet<SemiAnnualByIssuer> SemiAnnualByIssuers { get; set; }
        public virtual DbSet<SettlRetraceInput> SettlRetraceInputs { get; set; }
        public virtual DbSet<SettlementInf> SettlementInfs { get; set; }
        public virtual DbSet<SwapCurrentExpLmt> SwapCurrentExpLmts { get; set; }
        public virtual DbSet<SystemRevisionDetail> SystemRevisionDetails { get; set; }
        public virtual DbSet<T02AccountAcmBal> T02AccountAcmBals { get; set; }
        public virtual DbSet<T02AccountCodeTable> T02AccountCodeTables { get; set; }
        public virtual DbSet<T02AccountNoBalance> T02AccountNoBalances { get; set; }
        public virtual DbSet<T02AgentGuarantee> T02AgentGuarantees { get; set; }
        public virtual DbSet<T02AgentLoan> T02AgentLoans { get; set; }
        public virtual DbSet<T02BankInf> T02BankInfs { get; set; }
        public virtual DbSet<T02BisOffBsCommitAndOth> T02BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T02BisOffBsCurrentExp> T02BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T02BisOffBsOriginalExp> T02BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T02BisOnBalance> T02BisOnBalances { get; set; }
        public virtual DbSet<T02BsByActGpMemoBaht> T02BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T02BsByActGpMemoUsd> T02BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T02BsByActGpOnBaht> T02BsByActGpOnBahts { get; set; }
        public virtual DbSet<T02BsByActGpOnUsd> T02BsByActGpOnUsds { get; set; }
        public virtual DbSet<T02BsByBaseCcyByDiv> T02BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T02BsByCcyByDiv> T02BsByCcyByDivs { get; set; }
        public virtual DbSet<T02BsPlFile> T02BsPlFiles { get; set; }
        public virtual DbSet<T02CcyCodeTable> T02CcyCodeTables { get; set; }
        public virtual DbSet<T02CcyConversionRateTable> T02CcyConversionRateTables { get; set; }
        public virtual DbSet<T02CollateralAndGuarantor> T02CollateralAndGuarantors { get; set; }
        public virtual DbSet<T02CollectedPaidInterest> T02CollectedPaidInterests { get; set; }
        public virtual DbSet<T02Commitment> T02Commitments { get; set; }
        public virtual DbSet<T02ConsoliAccountCodeTable> T02ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T02ConsoliBsPlFileSpd> T02ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T02ConsoliBsPlFileUsd> T02ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T02ConsoliBsPlSpd> T02ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T02ConsoliBsPlUsd> T02ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T02ConsoliMemoBsPlSpd> T02ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T02ConsoliMemoBsPlUsd> T02ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T02CorrespondentMaster> T02CorrespondentMasters { get; set; }
        public virtual DbSet<T02CreditLine> T02CreditLines { get; set; }
        public virtual DbSet<T02CustomerBalance> T02CustomerBalances { get; set; }
        public virtual DbSet<T02CustomerMaster> T02CustomerMasters { get; set; }
        public virtual DbSet<T02DefferedLoan> T02DefferedLoans { get; set; }
        public virtual DbSet<T02EuroYenLoan> T02EuroYenLoans { get; set; }
        public virtual DbSet<T02EuroyenLoanProfit> T02EuroyenLoanProfits { get; set; }
        public virtual DbSet<T02FeeAndCharge> T02FeeAndCharges { get; set; }
        public virtual DbSet<T02ForeignExchange> T02ForeignExchanges { get; set; }
        public virtual DbSet<T02FwdRevalDetail> T02FwdRevalDetails { get; set; }
        public virtual DbSet<T02Guarantee> T02Guarantees { get; set; }
        public virtual DbSet<T02HedgeDefRevalDetail> T02HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T02ImpExpDocument> T02ImpExpDocuments { get; set; }
        public virtual DbSet<T02ImportAndExport> T02ImportAndExports { get; set; }
        public virtual DbSet<T02ImportLc> T02ImportLcs { get; set; }
        public virtual DbSet<T02IntAndCcySwap> T02IntAndCcySwaps { get; set; }
        public virtual DbSet<T02Loan> T02Loans { get; set; }
        public virtual DbSet<T02ManualRevisionDetail> T02ManualRevisionDetails { get; set; }
        public virtual DbSet<T02MoneyMarketTran> T02MoneyMarketTrans { get; set; }
        public virtual DbSet<T02OtherDivSemiAnnual> T02OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T02Security> T02Securities { get; set; }
        public virtual DbSet<T02SecurityDetail> T02SecurityDetails { get; set; }
        public virtual DbSet<T02SemiAnnualByCust> T02SemiAnnualByCusts { get; set; }
        public virtual DbSet<T02SemiAnnualByIssuer> T02SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T02SettlementInf> T02SettlementInfs { get; set; }
        public virtual DbSet<T02SystemRevisionDetail> T02SystemRevisionDetails { get; set; }
        public virtual DbSet<T02TermBsPlFile> T02TermBsPlFiles { get; set; }
        public virtual DbSet<T02TotalCreditLine> T02TotalCreditLines { get; set; }
        public virtual DbSet<T03AccountAcmBal> T03AccountAcmBals { get; set; }
        public virtual DbSet<T03AccountCodeTable> T03AccountCodeTables { get; set; }
        public virtual DbSet<T03AccountNoBalance> T03AccountNoBalances { get; set; }
        public virtual DbSet<T03AgentGuarantee> T03AgentGuarantees { get; set; }
        public virtual DbSet<T03AgentLoan> T03AgentLoans { get; set; }
        public virtual DbSet<T03BankInf> T03BankInfs { get; set; }
        public virtual DbSet<T03BisOffBsCommitAndOth> T03BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T03BisOffBsCurrentExp> T03BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T03BisOffBsOriginalExp> T03BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T03BisOnBalance> T03BisOnBalances { get; set; }
        public virtual DbSet<T03BsByActGpMemoBaht> T03BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T03BsByActGpMemoUsd> T03BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T03BsByActGpOnBaht> T03BsByActGpOnBahts { get; set; }
        public virtual DbSet<T03BsByActGpOnUsd> T03BsByActGpOnUsds { get; set; }
        public virtual DbSet<T03BsByBaseCcyByDiv> T03BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T03BsByCcyByDiv> T03BsByCcyByDivs { get; set; }
        public virtual DbSet<T03BsPlFile> T03BsPlFiles { get; set; }
        public virtual DbSet<T03CcyCodeTable> T03CcyCodeTables { get; set; }
        public virtual DbSet<T03CcyConversionRateTable> T03CcyConversionRateTables { get; set; }
        public virtual DbSet<T03CollateralAndGuarantor> T03CollateralAndGuarantors { get; set; }
        public virtual DbSet<T03CollectedPaidInterest> T03CollectedPaidInterests { get; set; }
        public virtual DbSet<T03Commitment> T03Commitments { get; set; }
        public virtual DbSet<T03ConsoliAccountCodeTable> T03ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T03ConsoliBsPlFileSpd> T03ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T03ConsoliBsPlFileUsd> T03ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T03ConsoliBsPlSpd> T03ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T03ConsoliBsPlUsd> T03ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T03ConsoliMemoBsPlSpd> T03ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T03ConsoliMemoBsPlUsd> T03ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T03CorrespondentMaster> T03CorrespondentMasters { get; set; }
        public virtual DbSet<T03CreditLine> T03CreditLines { get; set; }
        public virtual DbSet<T03CustomerBalance> T03CustomerBalances { get; set; }
        public virtual DbSet<T03CustomerMaster> T03CustomerMasters { get; set; }
        public virtual DbSet<T03DefferedLoan> T03DefferedLoans { get; set; }
        public virtual DbSet<T03EuroYenLoan> T03EuroYenLoans { get; set; }
        public virtual DbSet<T03EuroyenLoanProfit> T03EuroyenLoanProfits { get; set; }
        public virtual DbSet<T03FeeAndCharge> T03FeeAndCharges { get; set; }
        public virtual DbSet<T03ForeignExchange> T03ForeignExchanges { get; set; }
        public virtual DbSet<T03FwdRevalDetail> T03FwdRevalDetails { get; set; }
        public virtual DbSet<T03Guarantee> T03Guarantees { get; set; }
        public virtual DbSet<T03HedgeDefRevalDetail> T03HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T03ImpExpDocument> T03ImpExpDocuments { get; set; }
        public virtual DbSet<T03ImportAndExport> T03ImportAndExports { get; set; }
        public virtual DbSet<T03ImportLc> T03ImportLcs { get; set; }
        public virtual DbSet<T03IntAndCcySwap> T03IntAndCcySwaps { get; set; }
        public virtual DbSet<T03Loan> T03Loans { get; set; }
        public virtual DbSet<T03ManualRevisionDetail> T03ManualRevisionDetails { get; set; }
        public virtual DbSet<T03MoneyMarketTran> T03MoneyMarketTrans { get; set; }
        public virtual DbSet<T03OtherDivSemiAnnual> T03OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T03Security> T03Securities { get; set; }
        public virtual DbSet<T03SecurityDetail> T03SecurityDetails { get; set; }
        public virtual DbSet<T03SemiAnnualByCust> T03SemiAnnualByCusts { get; set; }
        public virtual DbSet<T03SemiAnnualByIssuer> T03SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T03SettlementInf> T03SettlementInfs { get; set; }
        public virtual DbSet<T03SystemRevisionDetail> T03SystemRevisionDetails { get; set; }
        public virtual DbSet<T03TermBsPlFile> T03TermBsPlFiles { get; set; }
        public virtual DbSet<T03TotalCreditLine> T03TotalCreditLines { get; set; }
        public virtual DbSet<T04AccountAcmBal> T04AccountAcmBals { get; set; }
        public virtual DbSet<T04AccountCodeTable> T04AccountCodeTables { get; set; }
        public virtual DbSet<T04AccountNoBalance> T04AccountNoBalances { get; set; }
        public virtual DbSet<T04AgentGuarantee> T04AgentGuarantees { get; set; }
        public virtual DbSet<T04AgentLoan> T04AgentLoans { get; set; }
        public virtual DbSet<T04BankInf> T04BankInfs { get; set; }
        public virtual DbSet<T04BisOffBsCommitAndOth> T04BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T04BisOffBsCurrentExp> T04BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T04BisOffBsOriginalExp> T04BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T04BisOnBalance> T04BisOnBalances { get; set; }
        public virtual DbSet<T04BsByActGpMemoBaht> T04BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T04BsByActGpMemoUsd> T04BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T04BsByActGpOnBaht> T04BsByActGpOnBahts { get; set; }
        public virtual DbSet<T04BsByActGpOnUsd> T04BsByActGpOnUsds { get; set; }
        public virtual DbSet<T04BsByBaseCcyByDiv> T04BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T04BsByCcyByDiv> T04BsByCcyByDivs { get; set; }
        public virtual DbSet<T04BsPlFile> T04BsPlFiles { get; set; }
        public virtual DbSet<T04CcyCodeTable> T04CcyCodeTables { get; set; }
        public virtual DbSet<T04CcyConversionRateTable> T04CcyConversionRateTables { get; set; }
        public virtual DbSet<T04CollateralAndGuarantor> T04CollateralAndGuarantors { get; set; }
        public virtual DbSet<T04CollectedPaidInterest> T04CollectedPaidInterests { get; set; }
        public virtual DbSet<T04Commitment> T04Commitments { get; set; }
        public virtual DbSet<T04ConsoliAccountCodeTable> T04ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T04ConsoliBsPlFileSpd> T04ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T04ConsoliBsPlFileUsd> T04ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T04ConsoliBsPlSpd> T04ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T04ConsoliBsPlUsd> T04ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T04ConsoliMemoBsPlSpd> T04ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T04ConsoliMemoBsPlUsd> T04ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T04CorrespondentMaster> T04CorrespondentMasters { get; set; }
        public virtual DbSet<T04CreditLine> T04CreditLines { get; set; }
        public virtual DbSet<T04CustomerBalance> T04CustomerBalances { get; set; }
        public virtual DbSet<T04CustomerMaster> T04CustomerMasters { get; set; }
        public virtual DbSet<T04DefferedLoan> T04DefferedLoans { get; set; }
        public virtual DbSet<T04EuroYenLoan> T04EuroYenLoans { get; set; }
        public virtual DbSet<T04EuroyenLoanProfit> T04EuroyenLoanProfits { get; set; }
        public virtual DbSet<T04FeeAndCharge> T04FeeAndCharges { get; set; }
        public virtual DbSet<T04ForeignExchange> T04ForeignExchanges { get; set; }
        public virtual DbSet<T04FwdRevalDetail> T04FwdRevalDetails { get; set; }
        public virtual DbSet<T04Guarantee> T04Guarantees { get; set; }
        public virtual DbSet<T04HedgeDefRevalDetail> T04HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T04ImpExpDocument> T04ImpExpDocuments { get; set; }
        public virtual DbSet<T04ImportAndExport> T04ImportAndExports { get; set; }
        public virtual DbSet<T04ImportLc> T04ImportLcs { get; set; }
        public virtual DbSet<T04IntAndCcySwap> T04IntAndCcySwaps { get; set; }
        public virtual DbSet<T04Loan> T04Loans { get; set; }
        public virtual DbSet<T04ManualRevisionDetail> T04ManualRevisionDetails { get; set; }
        public virtual DbSet<T04MoneyMarketTran> T04MoneyMarketTrans { get; set; }
        public virtual DbSet<T04OtherDivSemiAnnual> T04OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T04Security> T04Securities { get; set; }
        public virtual DbSet<T04SecurityDetail> T04SecurityDetails { get; set; }
        public virtual DbSet<T04SemiAnnualByCust> T04SemiAnnualByCusts { get; set; }
        public virtual DbSet<T04SemiAnnualByIssuer> T04SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T04SettlementInf> T04SettlementInfs { get; set; }
        public virtual DbSet<T04SystemRevisionDetail> T04SystemRevisionDetails { get; set; }
        public virtual DbSet<T04TermBsPlFile> T04TermBsPlFiles { get; set; }
        public virtual DbSet<T04TotalCreditLine> T04TotalCreditLines { get; set; }
        public virtual DbSet<T05AccountAcmBal> T05AccountAcmBals { get; set; }
        public virtual DbSet<T05AccountCodeTable> T05AccountCodeTables { get; set; }
        public virtual DbSet<T05AccountNoBalance> T05AccountNoBalances { get; set; }
        public virtual DbSet<T05AgentGuarantee> T05AgentGuarantees { get; set; }
        public virtual DbSet<T05AgentLoan> T05AgentLoans { get; set; }
        public virtual DbSet<T05BankInf> T05BankInfs { get; set; }
        public virtual DbSet<T05BisOffBsCommitAndOth> T05BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T05BisOffBsCurrentExp> T05BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T05BisOffBsOriginalExp> T05BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T05BisOnBalance> T05BisOnBalances { get; set; }
        public virtual DbSet<T05BsByActGpMemoBaht> T05BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T05BsByActGpMemoUsd> T05BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T05BsByActGpOnBaht> T05BsByActGpOnBahts { get; set; }
        public virtual DbSet<T05BsByActGpOnUsd> T05BsByActGpOnUsds { get; set; }
        public virtual DbSet<T05BsByBaseCcyByDiv> T05BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T05BsByCcyByDiv> T05BsByCcyByDivs { get; set; }
        public virtual DbSet<T05BsPlFile> T05BsPlFiles { get; set; }
        public virtual DbSet<T05CcyCodeTable> T05CcyCodeTables { get; set; }
        public virtual DbSet<T05CcyConversionRateTable> T05CcyConversionRateTables { get; set; }
        public virtual DbSet<T05CollateralAndGuarantor> T05CollateralAndGuarantors { get; set; }
        public virtual DbSet<T05CollectedPaidInterest> T05CollectedPaidInterests { get; set; }
        public virtual DbSet<T05Commitment> T05Commitments { get; set; }
        public virtual DbSet<T05ConsoliAccountCodeTable> T05ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T05ConsoliBsPlFileSpd> T05ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T05ConsoliBsPlFileUsd> T05ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T05ConsoliBsPlSpd> T05ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T05ConsoliBsPlUsd> T05ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T05ConsoliMemoBsPlSpd> T05ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T05ConsoliMemoBsPlUsd> T05ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T05CorrespondentMaster> T05CorrespondentMasters { get; set; }
        public virtual DbSet<T05CreditLine> T05CreditLines { get; set; }
        public virtual DbSet<T05CustomerBalance> T05CustomerBalances { get; set; }
        public virtual DbSet<T05CustomerMaster> T05CustomerMasters { get; set; }
        public virtual DbSet<T05DefferedLoan> T05DefferedLoans { get; set; }
        public virtual DbSet<T05EuroYenLoan> T05EuroYenLoans { get; set; }
        public virtual DbSet<T05EuroyenLoanProfit> T05EuroyenLoanProfits { get; set; }
        public virtual DbSet<T05FeeAndCharge> T05FeeAndCharges { get; set; }
        public virtual DbSet<T05ForeignExchange> T05ForeignExchanges { get; set; }
        public virtual DbSet<T05FwdRevalDetail> T05FwdRevalDetails { get; set; }
        public virtual DbSet<T05Guarantee> T05Guarantees { get; set; }
        public virtual DbSet<T05HedgeDefRevalDetail> T05HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T05ImpExpDocument> T05ImpExpDocuments { get; set; }
        public virtual DbSet<T05ImportAndExport> T05ImportAndExports { get; set; }
        public virtual DbSet<T05ImportLc> T05ImportLcs { get; set; }
        public virtual DbSet<T05IntAndCcySwap> T05IntAndCcySwaps { get; set; }
        public virtual DbSet<T05Loan> T05Loans { get; set; }
        public virtual DbSet<T05ManualRevisionDetail> T05ManualRevisionDetails { get; set; }
        public virtual DbSet<T05MoneyMarketTran> T05MoneyMarketTrans { get; set; }
        public virtual DbSet<T05OtherDivSemiAnnual> T05OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T05Security> T05Securities { get; set; }
        public virtual DbSet<T05SecurityDetail> T05SecurityDetails { get; set; }
        public virtual DbSet<T05SemiAnnualByCust> T05SemiAnnualByCusts { get; set; }
        public virtual DbSet<T05SemiAnnualByIssuer> T05SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T05SettlementInf> T05SettlementInfs { get; set; }
        public virtual DbSet<T05SystemRevisionDetail> T05SystemRevisionDetails { get; set; }
        public virtual DbSet<T05TermBsPlFile> T05TermBsPlFiles { get; set; }
        public virtual DbSet<T05TotalCreditLine> T05TotalCreditLines { get; set; }
        public virtual DbSet<T06AccountAcmBal> T06AccountAcmBals { get; set; }
        public virtual DbSet<T06AccountCodeTable> T06AccountCodeTables { get; set; }
        public virtual DbSet<T06AccountNoBalance> T06AccountNoBalances { get; set; }
        public virtual DbSet<T06AgentGuarantee> T06AgentGuarantees { get; set; }
        public virtual DbSet<T06AgentLoan> T06AgentLoans { get; set; }
        public virtual DbSet<T06BankInf> T06BankInfs { get; set; }
        public virtual DbSet<T06BisOffBsCommitAndOth> T06BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T06BisOffBsCurrentExp> T06BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T06BisOffBsOriginalExp> T06BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T06BisOnBalance> T06BisOnBalances { get; set; }
        public virtual DbSet<T06BsByActGpMemoBaht> T06BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T06BsByActGpMemoUsd> T06BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T06BsByActGpOnBaht> T06BsByActGpOnBahts { get; set; }
        public virtual DbSet<T06BsByActGpOnUsd> T06BsByActGpOnUsds { get; set; }
        public virtual DbSet<T06BsByBaseCcyByDiv> T06BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T06BsByCcyByDiv> T06BsByCcyByDivs { get; set; }
        public virtual DbSet<T06BsPlFile> T06BsPlFiles { get; set; }
        public virtual DbSet<T06CcyCodeTable> T06CcyCodeTables { get; set; }
        public virtual DbSet<T06CcyConversionRateTable> T06CcyConversionRateTables { get; set; }
        public virtual DbSet<T06CollateralAndGuarantor> T06CollateralAndGuarantors { get; set; }
        public virtual DbSet<T06CollectedPaidInterest> T06CollectedPaidInterests { get; set; }
        public virtual DbSet<T06Commitment> T06Commitments { get; set; }
        public virtual DbSet<T06ConsoliAccountCodeTable> T06ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T06ConsoliBsPlFileSpd> T06ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T06ConsoliBsPlFileUsd> T06ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T06ConsoliBsPlSpd> T06ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T06ConsoliBsPlUsd> T06ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T06ConsoliMemoBsPlSpd> T06ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T06ConsoliMemoBsPlUsd> T06ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T06CorrespondentMaster> T06CorrespondentMasters { get; set; }
        public virtual DbSet<T06CreditLine> T06CreditLines { get; set; }
        public virtual DbSet<T06CustomerBalance> T06CustomerBalances { get; set; }
        public virtual DbSet<T06CustomerMaster> T06CustomerMasters { get; set; }
        public virtual DbSet<T06DefferedLoan> T06DefferedLoans { get; set; }
        public virtual DbSet<T06EuroYenLoan> T06EuroYenLoans { get; set; }
        public virtual DbSet<T06EuroyenLoanProfit> T06EuroyenLoanProfits { get; set; }
        public virtual DbSet<T06FeeAndCharge> T06FeeAndCharges { get; set; }
        public virtual DbSet<T06ForeignExchange> T06ForeignExchanges { get; set; }
        public virtual DbSet<T06FwdRevalDetail> T06FwdRevalDetails { get; set; }
        public virtual DbSet<T06Guarantee> T06Guarantees { get; set; }
        public virtual DbSet<T06HedgeDefRevalDetail> T06HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T06ImpExpDocument> T06ImpExpDocuments { get; set; }
        public virtual DbSet<T06ImportAndExport> T06ImportAndExports { get; set; }
        public virtual DbSet<T06ImportLc> T06ImportLcs { get; set; }
        public virtual DbSet<T06IntAndCcySwap> T06IntAndCcySwaps { get; set; }
        public virtual DbSet<T06Loan> T06Loans { get; set; }
        public virtual DbSet<T06ManualRevisionDetail> T06ManualRevisionDetails { get; set; }
        public virtual DbSet<T06MoneyMarketTran> T06MoneyMarketTrans { get; set; }
        public virtual DbSet<T06OtherDivSemiAnnual> T06OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T06Security> T06Securities { get; set; }
        public virtual DbSet<T06SecurityDetail> T06SecurityDetails { get; set; }
        public virtual DbSet<T06SemiAnnualByCust> T06SemiAnnualByCusts { get; set; }
        public virtual DbSet<T06SemiAnnualByIssuer> T06SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T06SettlementInf> T06SettlementInfs { get; set; }
        public virtual DbSet<T06SystemRevisionDetail> T06SystemRevisionDetails { get; set; }
        public virtual DbSet<T06TermBsPlFile> T06TermBsPlFiles { get; set; }
        public virtual DbSet<T06TotalCreditLine> T06TotalCreditLines { get; set; }
        public virtual DbSet<T07AccountAcmBal> T07AccountAcmBals { get; set; }
        public virtual DbSet<T07AccountCodeTable> T07AccountCodeTables { get; set; }
        public virtual DbSet<T07AccountNoBalance> T07AccountNoBalances { get; set; }
        public virtual DbSet<T07AgentGuarantee> T07AgentGuarantees { get; set; }
        public virtual DbSet<T07AgentLoan> T07AgentLoans { get; set; }
        public virtual DbSet<T07BankInf> T07BankInfs { get; set; }
        public virtual DbSet<T07BisOffBsCommitAndOth> T07BisOffBsCommitAndOths { get; set; }
        public virtual DbSet<T07BisOffBsCurrentExp> T07BisOffBsCurrentExps { get; set; }
        public virtual DbSet<T07BisOffBsOriginalExp> T07BisOffBsOriginalExps { get; set; }
        public virtual DbSet<T07BisOnBalance> T07BisOnBalances { get; set; }
        public virtual DbSet<T07BsByActGpMemoBaht> T07BsByActGpMemoBahts { get; set; }
        public virtual DbSet<T07BsByActGpMemoUsd> T07BsByActGpMemoUsds { get; set; }
        public virtual DbSet<T07BsByActGpOnBaht> T07BsByActGpOnBahts { get; set; }
        public virtual DbSet<T07BsByActGpOnUsd> T07BsByActGpOnUsds { get; set; }
        public virtual DbSet<T07BsByBaseCcyByDiv> T07BsByBaseCcyByDivs { get; set; }
        public virtual DbSet<T07BsByCcyByDiv> T07BsByCcyByDivs { get; set; }
        public virtual DbSet<T07CcyCodeTable> T07CcyCodeTables { get; set; }
        public virtual DbSet<T07CcyConversionRateTable> T07CcyConversionRateTables { get; set; }
        public virtual DbSet<T07CollateralAndGuarantor> T07CollateralAndGuarantors { get; set; }
        public virtual DbSet<T07CollectedPaidInterest> T07CollectedPaidInterests { get; set; }
        public virtual DbSet<T07Commitment> T07Commitments { get; set; }
        public virtual DbSet<T07ConsoliAccountCodeTable> T07ConsoliAccountCodeTables { get; set; }
        public virtual DbSet<T07ConsoliBsPlFileSpd> T07ConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<T07ConsoliBsPlFileUsd> T07ConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<T07ConsoliBsPlSpd> T07ConsoliBsPlSpds { get; set; }
        public virtual DbSet<T07ConsoliBsPlUsd> T07ConsoliBsPlUsds { get; set; }
        public virtual DbSet<T07ConsoliMemoBsPlSpd> T07ConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<T07ConsoliMemoBsPlUsd> T07ConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<T07CorrespondentMaster> T07CorrespondentMasters { get; set; }
        public virtual DbSet<T07CreditLine> T07CreditLines { get; set; }
        public virtual DbSet<T07CustomerBalance> T07CustomerBalances { get; set; }
        public virtual DbSet<T07CustomerMaster> T07CustomerMasters { get; set; }
        public virtual DbSet<T07DefferedLoan> T07DefferedLoans { get; set; }
        public virtual DbSet<T07EuroYenLoan> T07EuroYenLoans { get; set; }
        public virtual DbSet<T07EuroyenLoanProfit> T07EuroyenLoanProfits { get; set; }
        public virtual DbSet<T07FeeAndCharge> T07FeeAndCharges { get; set; }
        public virtual DbSet<T07ForeignExchange> T07ForeignExchanges { get; set; }
        public virtual DbSet<T07FwdRevalDetail> T07FwdRevalDetails { get; set; }
        public virtual DbSet<T07Guarantee> T07Guarantees { get; set; }
        public virtual DbSet<T07HedgeDefRevalDetail> T07HedgeDefRevalDetails { get; set; }
        public virtual DbSet<T07ImpExpDocument> T07ImpExpDocuments { get; set; }
        public virtual DbSet<T07ImportAndExport> T07ImportAndExports { get; set; }
        public virtual DbSet<T07ImportLc> T07ImportLcs { get; set; }
        public virtual DbSet<T07IntAndCcySwap> T07IntAndCcySwaps { get; set; }
        public virtual DbSet<T07Loan> T07Loans { get; set; }
        public virtual DbSet<T07ManualRevisionDetail> T07ManualRevisionDetails { get; set; }
        public virtual DbSet<T07MoneyMarketTran> T07MoneyMarketTrans { get; set; }
        public virtual DbSet<T07OtherDivSemiAnnual> T07OtherDivSemiAnnuals { get; set; }
        public virtual DbSet<T07Security> T07Securities { get; set; }
        public virtual DbSet<T07SecurityDetail> T07SecurityDetails { get; set; }
        public virtual DbSet<T07SemiAnnualByCust> T07SemiAnnualByCusts { get; set; }
        public virtual DbSet<T07SemiAnnualByIssuer> T07SemiAnnualByIssuers { get; set; }
        public virtual DbSet<T07SettlementInf> T07SettlementInfs { get; set; }
        public virtual DbSet<T07SystemRevisionDetail> T07SystemRevisionDetails { get; set; }
        public virtual DbSet<T07TermBsPlFile> T07TermBsPlFiles { get; set; }
        public virtual DbSet<T07TotalCreditLine> T07TotalCreditLines { get; set; }
        public virtual DbSet<TAccountAcmBal> TAccountAcmBals { get; set; }
        public virtual DbSet<TAccountCodeTable> TAccountCodeTables { get; set; }
        public virtual DbSet<TAccountNoBalance> TAccountNoBalances { get; set; }
        public virtual DbSet<TAgentGuarantee> TAgentGuarantees { get; set; }
        public virtual DbSet<TAgentLoan> TAgentLoans { get; set; }
        public virtual DbSet<TBankInf> TBankInfs { get; set; }
        public virtual DbSet<TBisOffBsCommitAndOth> TBisOffBsCommitAndOths { get; set; }
        public virtual DbSet<TBisOffBsCurrentExp> TBisOffBsCurrentExps { get; set; }
        public virtual DbSet<TBisOffBsOriginalExp> TBisOffBsOriginalExps { get; set; }
        public virtual DbSet<TBisOnBalance> TBisOnBalances { get; set; }
        public virtual DbSet<TBsByActGpMemoBaht> TBsByActGpMemoBahts { get; set; }
        public virtual DbSet<TBsByActGpMemoUsd> TBsByActGpMemoUsds { get; set; }
        public virtual DbSet<TBsByActGpOnBaht> TBsByActGpOnBahts { get; set; }
        public virtual DbSet<TBsByActGpOnUsd> TBsByActGpOnUsds { get; set; }
        public virtual DbSet<TBsByBaseCcyByDiv> TBsByBaseCcyByDivs { get; set; }
        public virtual DbSet<TBsByCcyByDiv> TBsByCcyByDivs { get; set; }
        public virtual DbSet<TBsPlFile> TBsPlFiles { get; set; }
        public virtual DbSet<TCcyCodeTable> TCcyCodeTables { get; set; }
        public virtual DbSet<TCcyConversionRateTable> TCcyConversionRateTables { get; set; }
        public virtual DbSet<TCollateralAndGuarantor> TCollateralAndGuarantors { get; set; }
        public virtual DbSet<TCollectedPaidInterest> TCollectedPaidInterests { get; set; }
        public virtual DbSet<TCommitment> TCommitments { get; set; }
        public virtual DbSet<TConsoliAccountCodeTable> TConsoliAccountCodeTables { get; set; }
        public virtual DbSet<TConsoliBsPlFileSpd> TConsoliBsPlFileSpds { get; set; }
        public virtual DbSet<TConsoliBsPlFileUsd> TConsoliBsPlFileUsds { get; set; }
        public virtual DbSet<TConsoliBsPlSpd> TConsoliBsPlSpds { get; set; }
        public virtual DbSet<TConsoliBsPlUsd> TConsoliBsPlUsds { get; set; }
        public virtual DbSet<TConsoliMemoBsPlSpd> TConsoliMemoBsPlSpds { get; set; }
        public virtual DbSet<TConsoliMemoBsPlUsd> TConsoliMemoBsPlUsds { get; set; }
        public virtual DbSet<TCorrespondentMaster> TCorrespondentMasters { get; set; }
        public virtual DbSet<TCreditLine> TCreditLines { get; set; }
        public virtual DbSet<TCustomerBalance> TCustomerBalances { get; set; }
        public virtual DbSet<TCustomerMaster> TCustomerMasters { get; set; }
        public virtual DbSet<TDefferedLoan> TDefferedLoans { get; set; }
        public virtual DbSet<TEuroYenLoan> TEuroYenLoans { get; set; }
        public virtual DbSet<TEuroyenLoanProfit> TEuroyenLoanProfits { get; set; }
        public virtual DbSet<TFeeAndCharge> TFeeAndCharges { get; set; }
        public virtual DbSet<TForeignExchange> TForeignExchanges { get; set; }
        public virtual DbSet<TFwdRevalDetail> TFwdRevalDetails { get; set; }
        public virtual DbSet<TGuarantee> TGuarantees { get; set; }
        public virtual DbSet<THedgeDefRevalDetail> THedgeDefRevalDetails { get; set; }
        public virtual DbSet<TImpExpDocument> TImpExpDocuments { get; set; }
        public virtual DbSet<TImportAndExport> TImportAndExports { get; set; }
        public virtual DbSet<TImportLc> TImportLcs { get; set; }
        public virtual DbSet<TIntAndCcySwap> TIntAndCcySwaps { get; set; }
        public virtual DbSet<TLoan> TLoans { get; set; }
        public virtual DbSet<TManualRevisionDetail> TManualRevisionDetails { get; set; }
        public virtual DbSet<TMoneyMarketTran> TMoneyMarketTrans { get; set; }
        public virtual DbSet<TOtherDivSemiAnnual> TOtherDivSemiAnnuals { get; set; }
        public virtual DbSet<TSecurity> TSecurities { get; set; }
        public virtual DbSet<TSecurityDetail> TSecurityDetails { get; set; }
        public virtual DbSet<TSemiAnnualByCust> TSemiAnnualByCusts { get; set; }
        public virtual DbSet<TSemiAnnualByIssuer> TSemiAnnualByIssuers { get; set; }
        public virtual DbSet<TSettlementInf> TSettlementInfs { get; set; }
        public virtual DbSet<TSystemRevisionDetail> TSystemRevisionDetails { get; set; }
        public virtual DbSet<TTotalCreditLine> TTotalCreditLines { get; set; }
        public virtual DbSet<TaxCodeTable> TaxCodeTables { get; set; }
        public virtual DbSet<TermBsPlFile> TermBsPlFiles { get; set; }
        public virtual DbSet<TotalCreditLine> TotalCreditLines { get; set; }
        public virtual DbSet<TransVolume> TransVolumes { get; set; }
        public virtual DbSet<TreasuryBnkDivProf> TreasuryBnkDivProfs { get; set; }
        public virtual DbSet<TreasuryProfitByTran> TreasuryProfitByTrans { get; set; }
        public virtual DbSet<ViewCcyCodeTable> ViewCcyCodeTables { get; set; }
        public virtual DbSet<ViewLoanMaster> ViewLoanMasters { get; set; }
        public virtual DbSet<ViewOndemandGuarantee> ViewOndemandGuarantees { get; set; }
        public virtual DbSet<ViewOndemandImportAndExport> ViewOndemandImportAndExports { get; set; }
        public virtual DbSet<ViewOndemandImportLc> ViewOndemandImportLcs { get; set; }
        public virtual DbSet<ViewOndemandLoan> ViewOndemandLoans { get; set; }
        public virtual DbSet<ViewOndemandMoneyMarketTran> ViewOndemandMoneyMarketTrans { get; set; }
        public virtual DbSet<ViewOndemandSecurity> ViewOndemandSecurities { get; set; }

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

                //optionsBuilder.UseSqlServer("Data Source=MIZSQLT01;Initial Catalog=EUCDbArchive;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AccountNoBalance>(entity =>
            {
                entity.HasKey(e => new { e.DataDate, e.CustAbbr, e.ActCd, e.IbfId, e.CcyCd, e.ActNo });

                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AdjustAccountDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BankMoneyLendingLimit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BaseRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BatchLogAccount>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BatchLogCommon>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BatchLogRemittance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BatchLogRemittanceBak>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BisOffBsCommitAndOther>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BisOffBsCurrentExposure>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BisOffBsOriginalExposure>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BkFxLendingLmtClassif>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BkFxLendingLmtClassifMin>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BkFxLendingLmtInteg>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BranchCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CashFlow>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CollateralCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CountryCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustAttributeCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustBnkDivProf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DBisOffBsCommitAndOther>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DBisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DEventByCcy>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DEventByDfb>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DebitCreditDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DeptCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FacilityTypeOverride>(entity =>
            {
                entity.Property(e => e.FacilityType).IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.RefNo).IsUnicode(false);
            });

            modelBuilder.Entity<FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdValueBLogAccount>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdValueBLogCommon>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdValueBLogRemit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdValueBLogRemitBak>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FwdValueRemitLimit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<GenFundDivProf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgeAccountDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgeActControl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgeDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgeMarketRevDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<HedgePortfolio>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IncomingRemittance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IncomingRemittanceBak>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IndustryCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InternalDefPlRev>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<InternalForexRate>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LoanGrtAmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LoanMaturityLadder>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<LoanTrancheContentBatch>(entity =>
            {
                entity.Property(e => e.Ccy)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AUD')");

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.DataDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LoanTrancheMasterBatch>(entity =>
            {
                entity.Property(e => e.ApplnNo).IsUnicode(false);

                entity.Property(e => e.ApplnNoRelt).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BaseCcy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.CfdBaseRate).IsUnicode(false);

                entity.Property(e => e.FinancialName).IsUnicode(false);

                entity.Property(e => e.Margin11am).IsUnicode(false);

                entity.Property(e => e.MarginRemark11am).IsUnicode(false);

                entity.Property(e => e.MatDateNotes).IsUnicode(false);

                entity.Property(e => e.MinDd).IsUnicode(false);

                entity.Property(e => e.MultiCcyDesc).IsUnicode(false);

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

                entity.Property(e => e.TrdInternalRate).IsUnicode(false);
            });

            modelBuilder.Entity<M02AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M02TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M03TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M04TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M05TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M06TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CustProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07FwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07FxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07IssuerProfitAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07LoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07ProfByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<M07TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MAccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MAccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MAgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MAgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBankMoneyLendingLimit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBaseRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBkFxLendingLmtClassif>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBkFxLendingLmtClassifmin>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBkFxLendingLmtInteg>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBranchCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCollateralCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCommitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCountryCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCustAttributeCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MCustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MDeptCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MEuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MFeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MFwdRevalRetrace>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MFwdValueRemitLimit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MFxCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MHedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MIndustryCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MIntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MLoanRepaymentSchedule>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MMoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MPurposeCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MRevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSecurity>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MSwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MTotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MiscellaneousInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<MonthlyCustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
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

            modelBuilder.Entity<OffBsCashFlowBot>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OnDemandBatch>(entity =>
            {
                entity.Property(e => e.CreatedWhen).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdatedWhen).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OnDemandBatchLog>(entity =>
            {
                entity.Property(e => e.When).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Batch)
                    .WithMany(p => p.OnDemandBatchLogs)
                    .HasForeignKey(d => d.BatchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OnDemand_Batch_Log_OnDemand_Batch");
            });

            modelBuilder.Entity<OnDemandLock>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OndemandCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandCustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandCustomersAccount>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandIntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandLogAccount>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandLogCommon>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandLogRemittance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandMiscellaneousInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandMoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandSecurity>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandSwapFxLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndemandTotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OndmTableReadFlag>(entity =>
            {
                entity.Property(e => e.OndmTableName).IsUnicode(false);

                entity.Property(e => e.ReadFlag).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<OndmViewCustomersAccount>(entity =>
            {
                entity.ToView("ONDM_VIEW_CUSTOMERS_ACCOUNT", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewFx>(entity =>
            {
                entity.ToView("ONDM_VIEW_FX", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewImpExp>(entity =>
            {
                entity.ToView("ONDM_VIEW_IMP_EXP", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewIntCcy>(entity =>
            {
                entity.ToView("ONDM_VIEW_INT_CCY", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewLoan>(entity =>
            {
                entity.ToView("ONDM_VIEW_LOAN", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewMm>(entity =>
            {
                entity.ToView("ONDM_VIEW_MM", "EUC_ONDM");
            });

            modelBuilder.Entity<OndmViewSecurity>(entity =>
            {
                entity.ToView("ONDM_VIEW_SECURITY", "EUC_ONDM");
            });

            modelBuilder.Entity<OsBnkDivProf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutgoingRemittance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutgoingRemittanceBak>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<OutgoingRemittanceMt360>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PoolingDetailFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProfBalByCustByProd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProfBalByPurpose>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProfitByAccCdByAccNo>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ProfitDetailByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<PurposeCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RemainPerIntSwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RevalSwapDepoPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RevalSwapPl>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RevalSwapPlExPro>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RevalSwapPlExProBot>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RevisionByCcyByAct>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RptGlobalTradeFinanceLcrExport>(entity =>
            {
                entity.Property(e => e.Account).IsUnicode(false);

                entity.Property(e => e.Action).IsUnicode(false);

                entity.Property(e => e.BorrowOrLend).IsUnicode(false);

                entity.Property(e => e.FacilityType).IsUnicode(false);

                entity.Property(e => e.MaturityDate).IsUnicode(false);

                entity.Property(e => e.RecordStatus).IsUnicode(false);

                entity.Property(e => e.Revolving).IsUnicode(false);

                entity.Property(e => e.RptGtfLcrExportId).ValueGeneratedOnAdd();

                entity.Property(e => e.SettlementCcy).IsUnicode(false);

                entity.Property(e => e.TheirName).IsUnicode(false);

                entity.Property(e => e.TradeExternalId).IsUnicode(false);

                entity.Property(e => e.Type).IsUnicode(false);

                entity.Property(e => e.UploadDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RptGlobalTradeFinanceLcrRaw>(entity =>
            {
                entity.Property(e => e.GbaseRefType).IsUnicode(false);

                entity.Property(e => e.RefNo).IsUnicode(false);

                entity.Property(e => e.RptGtfLcrId).ValueGeneratedOnAdd();

                entity.Property(e => e.UploadDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RptGlobalTradeFinanceLcrSummary>(entity =>
            {
                entity.Property(e => e.RptGtfLcrSummaryId).ValueGeneratedOnAdd();

                entity.Property(e => e.UploadDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SchemeProfAnalysis>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SecurityBnkDivProf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SettlRetraceInput>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SwapCurrentExpLmt>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T02TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T03TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T04TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T05TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06BsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T06TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07AccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07AccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07AccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07AgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07AgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07BsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07Commitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07CustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07DefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07EuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07EuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07FeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07FwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07Guarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07HedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07IntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07Loan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07ManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07MoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07OtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07Security>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07SecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07SemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07SemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07SettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07SystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<T07TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TAccountAcmBal>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TAccountNoBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TAgentGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TAgentLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBankInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBisOffBsCommitAndOth>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBisOffBsCurrentExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBisOffBsOriginalExp>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBisOnBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByActGpMemoBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByActGpMemoUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByActGpOnBaht>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByActGpOnUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByBaseCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsByCcyByDiv>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCcyCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCcyConversionRateTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCollateralAndGuarantor>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCollectedPaidInterest>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCommitment>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliAccountCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliBsPlFileSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliBsPlFileUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliMemoBsPlSpd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TConsoliMemoBsPlUsd>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCorrespondentMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCustomerBalance>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TCustomerMaster>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TDefferedLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TEuroYenLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TEuroyenLoanProfit>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TFeeAndCharge>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TForeignExchange>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TFwdRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TGuarantee>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<THedgeDefRevalDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TImpExpDocument>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TImportAndExport>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TImportLc>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TIntAndCcySwap>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TLoan>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TManualRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TMoneyMarketTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TOtherDivSemiAnnual>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSecurity>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSecurityDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSemiAnnualByCust>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSemiAnnualByIssuer>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSettlementInf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TSystemRevisionDetail>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TTotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TaxCodeTable>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TermBsPlFile>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TotalCreditLine>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TransVolume>(entity =>
            {
                entity.Property(e => e.Updatedate1).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TreasuryBnkDivProf>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TreasuryProfitByTran>(entity =>
            {
                entity.Property(e => e.Updatedate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<ViewCcyCodeTable>(entity =>
            {
                entity.ToView("VIEW_CCY_CODE_TABLE", "EUC");
            });

            modelBuilder.Entity<ViewLoanMaster>(entity =>
            {
                entity.ToView("VIEW_LOAN_MASTER");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.Agent).IsUnicode(false);

                entity.Property(e => e.AmendmentDate).IsUnicode(false);

                entity.Property(e => e.ApprBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.BranchNo).IsUnicode(false);

                entity.Property(e => e.Contact).IsUnicode(false);

                entity.Property(e => e.CustAbbr).IsUnicode(false);

                entity.Property(e => e.FaxNo).IsUnicode(false);

                entity.Property(e => e.LoanNo).ValueGeneratedOnAdd();

                entity.Property(e => e.ProcBy)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TelNo).IsUnicode(false);
            });

            modelBuilder.Entity<ViewOndemandGuarantee>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_GUARANTEE", "EUC_ONDM");
            });

            modelBuilder.Entity<ViewOndemandImportAndExport>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_IMPORT_AND_EXPORT", "EUC_ONDM");
            });

            modelBuilder.Entity<ViewOndemandImportLc>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_IMPORT_LC", "EUC_ONDM");
            });

            modelBuilder.Entity<ViewOndemandLoan>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_LOAN", "EUC_ONDM");
            });

            modelBuilder.Entity<ViewOndemandMoneyMarketTran>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_MONEY_MARKET_TRANS", "EUC_ONDM");
            });

            modelBuilder.Entity<ViewOndemandSecurity>(entity =>
            {
                entity.ToView("VIEW_ONDEMAND_SECURITY", "EUC_ONDM");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
