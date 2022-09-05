using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_INT_AND_CCY_SWAP", Schema = "EUC")]
    public partial class M03IntAndCcySwap
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("DIVISION_CD")]
        [StringLength(2)]
        public string DivisionCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("SWAP_TERM", TypeName = "decimal(4, 0)")]
        public decimal? SwapTerm { get; set; }
        [Column("CONTRACT_DATE_OPE", TypeName = "datetime")]
        public DateTime? ContractDateOpe { get; set; }
        [Column("CONTRACT_DATE_VALUE", TypeName = "datetime")]
        public DateTime? ContractDateValue { get; set; }
        [Column("MATURITY", TypeName = "datetime")]
        public DateTime? Maturity { get; set; }
        [Column("BROKER")]
        [StringLength(12)]
        public string Broker { get; set; }
        [Column("AGENT_FLG")]
        [StringLength(1)]
        public string AgentFlg { get; set; }
        [Column("AGENT_BANK_ABBR")]
        [StringLength(12)]
        public string AgentBankAbbr { get; set; }
        [Column("SCHEME_NO")]
        [StringLength(12)]
        public string SchemeNo { get; set; }
        [Column("REF_SUB_NO")]
        [StringLength(2)]
        public string RefSubNo { get; set; }
        [Column("FUNCTION_CD")]
        [StringLength(1)]
        public string FunctionCd { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("PRINCIPAL_AMT_ACT_CD")]
        [StringLength(5)]
        public string PrincipalAmtActCd { get; set; }
        [Column("PRINCIPAL_ACT_ABBR")]
        [StringLength(15)]
        public string PrincipalActAbbr { get; set; }
        [Column("PRINCIPAL_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? PrincipalAmount { get; set; }
        [Column("BALANCE_ACT_CD")]
        [StringLength(5)]
        public string BalanceActCd { get; set; }
        [Column("BALANCE_ACT_ABBR")]
        [StringLength(15)]
        public string BalanceActAbbr { get; set; }
        [Column("BALANCE", TypeName = "decimal(16, 3)")]
        public decimal? Balance { get; set; }
        [Column("SUPPLEMENTAL_INT")]
        [StringLength(1)]
        public string SupplementalInt { get; set; }
        [Column("START_VALUE", TypeName = "datetime")]
        public DateTime? StartValue { get; set; }
        [Column("START_OPE", TypeName = "datetime")]
        public DateTime? StartOpe { get; set; }
        [Column("INT_CALC_CD_1")]
        [StringLength(1)]
        public string IntCalcCd1 { get; set; }
        [Column("INT_CALC_CD_2")]
        [StringLength(1)]
        public string IntCalcCd2 { get; set; }
        [Column("INT_CALC_CD_3")]
        [StringLength(1)]
        public string IntCalcCd3 { get; set; }
        [Column("INT_CALC_CD_4")]
        [StringLength(1)]
        public string IntCalcCd4 { get; set; }
        [Column("INT_CALC_CD_5")]
        [StringLength(2)]
        public string IntCalcCd5 { get; set; }
        [Column("INT_CALC_CD_6")]
        [StringLength(1)]
        public string IntCalcCd6 { get; set; }
        [Column("FIXED_FLOAT")]
        [StringLength(1)]
        public string FixedFloat { get; set; }
        [Column("INT_MARKET_LINKAGE")]
        [StringLength(1)]
        public string IntMarketLinkage { get; set; }
        [Column("BASE_RATE_CD")]
        [StringLength(2)]
        public string BaseRateCd { get; set; }
        [Column("BASE_RATE_TERM")]
        [StringLength(2)]
        public string BaseRateTerm { get; set; }
        [Column("BASE_RATE", TypeName = "decimal(10, 7)")]
        public decimal? BaseRate { get; set; }
        [Column("SPREAD", TypeName = "decimal(9, 7)")]
        public decimal? Spread { get; set; }
        [Column("INT_RATE", TypeName = "decimal(10, 7)")]
        public decimal? IntRate { get; set; }
        [Column("LAST_INT_DATE", TypeName = "datetime")]
        public DateTime? LastIntDate { get; set; }
        [Column("NOMINAL_AMT_SCHEDULE")]
        [StringLength(1)]
        public string NominalAmtSchedule { get; set; }
        [Column("NEXT_INT_DATE", TypeName = "datetime")]
        public DateTime? NextIntDate { get; set; }
        [Column("NEXT_RATE_CHANGE", TypeName = "datetime")]
        public DateTime? NextRateChange { get; set; }
        [Column("INTERNAL_RATE_TYPE")]
        [StringLength(1)]
        public string InternalRateType { get; set; }
        [Column("INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? InternalRate { get; set; }
        [Column("PERCENTAGE_TYPE")]
        [StringLength(1)]
        public string PercentageType { get; set; }
        [Column("PERCENTAGE_INTERNAL_RATE", TypeName = "decimal(9, 6)")]
        public decimal? PercentageInternalRate { get; set; }
        [Column("IN_SPREAD_TYPE")]
        [StringLength(1)]
        public string InSpreadType { get; set; }
        [Column("IN_SPREAD_RATE", TypeName = "decimal(9, 7)")]
        public decimal? InSpreadRate { get; set; }
        [Column("OUT_SPREAD_TYPE")]
        [StringLength(1)]
        public string OutSpreadType { get; set; }
        [Column("OUT_SPREAD_RATE", TypeName = "decimal(9, 7)")]
        public decimal? OutSpreadRate { get; set; }
        [Column("HEDGE_TYPE")]
        [StringLength(1)]
        public string HedgeType { get; set; }
        [Column("HEDGE_REF_NO")]
        [StringLength(12)]
        public string HedgeRefNo { get; set; }
        [Column("LAST_OPE_DATE", TypeName = "datetime")]
        public DateTime? LastOpeDate { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
