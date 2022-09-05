using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("SETTLEMENT_INF", Schema = "EUC")]
    public partial class SettlementInf
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("RECORD_KIND")]
        [StringLength(1)]
        public string RecordKind { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("METHOD")]
        [StringLength(2)]
        public string Method { get; set; }
        [Column("COVER_PO_FLG")]
        [StringLength(1)]
        public string CoverPoFlg { get; set; }
        [Column("ADVICE_REC_FLG")]
        [StringLength(1)]
        public string AdviceRecFlg { get; set; }
        [Column("ADVICE_REC_LIMIT", TypeName = "decimal(16, 3)")]
        public decimal? AdviceRecLimit { get; set; }
        [Column("REC_SETTL_CODE")]
        [StringLength(2)]
        public string RecSettlCode { get; set; }
        [Column("PAY_SETTL_CODE")]
        [StringLength(2)]
        public string PaySettlCode { get; set; }
        [Column("REC_BANK_ID")]
        [StringLength(12)]
        public string RecBankId { get; set; }
        [Column("REC_BANK_CUST_ABBR")]
        [StringLength(12)]
        public string RecBankCustAbbr { get; set; }
        [Column("ACC_BANK_ID")]
        [StringLength(12)]
        public string AccBankId { get; set; }
        [Column("INTERMEDIARY_BANK_ID")]
        [StringLength(12)]
        public string IntermediaryBankId { get; set; }
        [Column("BENE_BANK_ACTNO")]
        [StringLength(34)]
        public string BeneBankActno { get; set; }
        [Column("BENE_BANK_ID")]
        [StringLength(12)]
        public string BeneBankId { get; set; }
        [Column("REMARKS")]
        [StringLength(70)]
        public string Remarks { get; set; }
        [Column("CONFIRMATION_FLG")]
        [StringLength(1)]
        public string ConfirmationFlg { get; set; }
        [Column("CONFIRMATION_SWIFT_ID")]
        [StringLength(12)]
        public string ConfirmationSwiftId { get; set; }
        [Column("REC_BANK_BR_ACTNO")]
        [StringLength(20)]
        public string RecBankBrActno { get; set; }
        [Column("REC_BANK_HO_ACTNO")]
        [StringLength(20)]
        public string RecBankHoActno { get; set; }
        [Column("ACC_BANK_ACTNO")]
        [StringLength(34)]
        public string AccBankActno { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("BANK_FLG")]
        [StringLength(1)]
        public string BankFlg { get; set; }
        [Column("REC_ACT_CD")]
        [StringLength(5)]
        public string RecActCd { get; set; }
        [Column("REC_METHOD")]
        [StringLength(2)]
        public string RecMethod { get; set; }
        [Column("REC_MESSAGE_TYPE")]
        [StringLength(3)]
        public string RecMessageType { get; set; }
        [Column("REC_RMT_FLG")]
        [StringLength(1)]
        public string RecRmtFlg { get; set; }
        [Column("PAY_ACT_CD")]
        [StringLength(5)]
        public string PayActCd { get; set; }
        [Column("PAY_MESSAGE_TYPE")]
        [StringLength(3)]
        public string PayMessageType { get; set; }
        [Column("PAY_RMT_FLG")]
        [StringLength(1)]
        public string PayRmtFlg { get; set; }
        [Column("PRIORTY_FLG")]
        [StringLength(2)]
        public string PriortyFlg { get; set; }
        [Column("BANK_INF_FLG")]
        [StringLength(1)]
        public string BankInfFlg { get; set; }
        [Column("BANK_INF")]
        [StringLength(35)]
        public string BankInf { get; set; }
        [Column("OCNNECT_FLG")]
        [StringLength(1)]
        public string OcnnectFlg { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
