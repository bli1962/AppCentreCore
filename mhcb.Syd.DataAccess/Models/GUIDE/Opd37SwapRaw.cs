using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Keyless]
    [Table("OPD-37_Swap_Raw")]
    public partial class Opd37SwapRaw
    {
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("AS_OF_DATE")]
        [StringLength(50)]
        public string AsOfDate { get; set; }
        [Column("REF_1")]
        [StringLength(50)]
        public string Ref1 { get; set; }
        [Column("REF_2")]
        [StringLength(50)]
        public string Ref2 { get; set; }
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
        [StringLength(50)]
        public string ContractStartDt { get; set; }
        [Column("TRADE_DT")]
        [StringLength(50)]
        public string TradeDt { get; set; }
        [Column("MATURITY_DATE")]
        [StringLength(50)]
        public string MaturityDate { get; set; }
        [Column("CORP")]
        [StringLength(50)]
        public string Corp { get; set; }
        [Column("CORP_NAME")]
        [StringLength(500)]
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
        [StringLength(50)]
        public string IntAccrualBuyRec { get; set; }
        [Column("INT_ACCRUAL_SELL_PAY")]
        [StringLength(50)]
        public string IntAccrualSellPay { get; set; }
        [Column("EFFECTIVERATETODAY_BUY_REC")]
        [StringLength(50)]
        public string EffectiveratetodayBuyRec { get; set; }
        [Column("EFFECTIVERATETODAY_SELL_PAY")]
        [StringLength(50)]
        public string EffectiveratetodaySellPay { get; set; }
        [Column("M_TRN_FMLY")]
        [StringLength(50)]
        public string MTrnFmly { get; set; }
        [Column("M_TRN_GRP")]
        [StringLength(50)]
        public string MTrnGrp { get; set; }
        [Column("M_TP_RTPR0")]
        [StringLength(50)]
        public string MTpRtpr0 { get; set; }
        [Column("M_PLIRDACC12")]
        [StringLength(50)]
        public string MPlirdacc12 { get; set; }
        [Column("M_PLIRDACC22")]
        [StringLength(50)]
        public string MPlirdacc22 { get; set; }
        [Column("M_TP_RTVLC00")]
        [StringLength(50)]
        public string MTpRtvlc00 { get; set; }
        [Column("M_TP_RTVLC01")]
        [StringLength(50)]
        public string MTpRtvlc01 { get; set; }
        [Column("M_TP_RTVLC02")]
        [StringLength(50)]
        public string MTpRtvlc02 { get; set; }
        [Column("M_TP_RTVLC10")]
        [StringLength(50)]
        public string MTpRtvlc10 { get; set; }
        [Column("M_TP_RTVLC11")]
        [StringLength(50)]
        public string MTpRtvlc11 { get; set; }
        [Column("M_TP_RTVLC12")]
        [StringLength(50)]
        public string MTpRtvlc12 { get; set; }
        [StringLength(255)]
        public string FilePath { get; set; }
        public int? Processed { get; set; }
    }
}
