using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OPD-37_Loan_Raw")]
    public partial class Opd37LoanRaw
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("AS_OF_DATE")]
        public DateTime AsOfDate { get; set; }
        [Column("REF_1")]
        [StringLength(50)]
        public string Ref1 { get; set; }
        [Column("REF_2")]
        public int? Ref2 { get; set; }
        [Column("ENTITY")]
        [StringLength(50)]
        public string Entity { get; set; }
        [Column("ABBREVIATION")]
        [StringLength(50)]
        public string Abbreviation { get; set; }
        [Column("GENERATOR")]
        [StringLength(50)]
        public string Generator { get; set; }
        [Column("CONTRACT_START_DT")]
        public DateTime? ContractStartDt { get; set; }
        [Column("TRADE_DT")]
        public DateTime? TradeDt { get; set; }
        [Column("MATURITY_DATE")]
        public DateTime? MaturityDate { get; set; }
        [Column("CORP")]
        public int? Corp { get; set; }
        [Column("CORP_NAME")]
        [StringLength(200)]
        public string CorpName { get; set; }
        [Column("PRD")]
        [StringLength(50)]
        public string Prd { get; set; }
        [Column("M_CNT_TYPO")]
        [StringLength(50)]
        public string MCntTypo { get; set; }
        [Column("PFOLIO")]
        [StringLength(50)]
        public string Pfolio { get; set; }
        [Column("INT_ACCRUAL_BUY_REC")]
        public double? IntAccrualBuyRec { get; set; }
        [Column("INT_ACCRUAL_SELL_PAY")]
        public double? IntAccrualSellPay { get; set; }
        [Column("INT_ACCRUAL_PrevEOM_BUY_REC")]
        public double? IntAccrualPrevEomBuyRec { get; set; }
        [Column("INT_ACCRUAL_PrevEOM_SELL_PAY")]
        public double? IntAccrualPrevEomSellPay { get; set; }
        [Column("INT_ACCRUAL_Loan_PrevEOM")]
        public double? IntAccrualLoanPrevEom { get; set; }
        [Column("INT_ACCRUAL_LOAN")]
        public double? IntAccrualLoan { get; set; }
        [Column("EFFECTIVERATETODAY_BUY_REC")]
        public double? EffectiveratetodayBuyRec { get; set; }
        [Column("EFFECTIVERATETODAY_SELL_PAY")]
        public double? EffectiveratetodaySellPay { get; set; }
        [Column("EffectiveRatePrevEOM_BUY_REC")]
        public double? EffectiveRatePrevEomBuyRec { get; set; }
        [Column("EffectiveRatePrevEOM_SELL_PAY")]
        public double? EffectiveRatePrevEomSellPay { get; set; }
        public double? EffectiveRateTodayLeg1 { get; set; }
        public double? EffectiveRateTodayLeg2 { get; set; }
        [Column("EffectiveRatePrevEOMLeg1")]
        public double? EffectiveRatePrevEomleg1 { get; set; }
        [Column("EffectiveRatePrevEOMLeg2")]
        public double? EffectiveRatePrevEomleg2 { get; set; }
        [Column("M_TRN_FMLY")]
        [StringLength(50)]
        public string MTrnFmly { get; set; }
        [Column("M_TRN_GRP")]
        [StringLength(50)]
        public string MTrnGrp { get; set; }
        [Column("M_PLIRDACC12")]
        public double? MPlirdacc12 { get; set; }
        [Column("M_PLIRDACC22")]
        public double? MPlirdacc22 { get; set; }
        [Column("M_TP_RTVLC00")]
        public double? MTpRtvlc00 { get; set; }
        [Column("M_TP_RTVLC01")]
        public double? MTpRtvlc01 { get; set; }
        [Column("M_TP_RTVLC02")]
        public double? MTpRtvlc02 { get; set; }
        [Column("M_TP_RTVLC10")]
        public double? MTpRtvlc10 { get; set; }
        [Column("M_TP_RTVLC11")]
        public double? MTpRtvlc11 { get; set; }
        [Column("M_TP_RTVLC12")]
        public double? MTpRtvlc12 { get; set; }
        [Column("BUY_AMTORBALANCE")]
        public double? BuyAmtorbalance { get; set; }
        [Column("BUY_AMTOREOMBALANCE")]
        public double? BuyAmtoreombalance { get; set; }
        [Column("M_TP_BUY")]
        [StringLength(50)]
        public string MTpBuy { get; set; }
        [Column("SELL_AMTORBALANCE")]
        public double? SellAmtorbalance { get; set; }
        [Column("SELL_AMTOREOMBALANCE")]
        public double? SellAmtoreombalance { get; set; }
        [Column("M_PL_LQTY2")]
        public double? MPlLqty2 { get; set; }
        [Column("M_PL_LEQQTY2")]
        public double? MPlLeqqty2 { get; set; }
        [Column("M_TP_RTCCP01")]
        public double? MTpRtccp01 { get; set; }
        [Column("M_TP_RTCCP02")]
        public double? MTpRtccp02 { get; set; }
        [Column("M_TP_RTCCP11")]
        public double? MTpRtccp11 { get; set; }
        [Column("M_TP_RTCCP12")]
        public double? MTpRtccp12 { get; set; }
        [Column("M_TP_RTPR0")]
        [StringLength(50)]
        public string MTpRtpr0 { get; set; }
        [Column("M_TP_RTCUR0")]
        [StringLength(50)]
        public string MTpRtcur0 { get; set; }
        [Column("M_TP_RTCUR1")]
        [StringLength(50)]
        public string MTpRtcur1 { get; set; }
        [Column("BUY_CUR")]
        [StringLength(50)]
        public string BuyCur { get; set; }
        [Column("SELL_CUR")]
        [StringLength(50)]
        public string SellCur { get; set; }
        [StringLength(50)]
        public string InterestPeriodStartLeg1 { get; set; }
        [StringLength(50)]
        public string InterestPeriodStartLeg2 { get; set; }
        [Column("InterestPeriodStartLeg1PrevEOM")]
        [StringLength(50)]
        public string InterestPeriodStartLeg1PrevEom { get; set; }
        [Column("InterestPeriodStartLeg2PrevEOM")]
        [StringLength(50)]
        public string InterestPeriodStartLeg2PrevEom { get; set; }
        [StringLength(255)]
        public string FilePath { get; set; }
        public int? Processed { get; set; }
    }
}
