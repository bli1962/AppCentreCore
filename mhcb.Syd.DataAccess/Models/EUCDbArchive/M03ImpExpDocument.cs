using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M03_IMP_EXP_DOCUMENT", Schema = "EUC")]
    public partial class M03ImpExpDocument
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? Amount { get; set; }
        [Column("BALANCE", TypeName = "decimal(16, 3)")]
        public decimal? Balance { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("ACCEPTED_DATE", TypeName = "datetime")]
        public DateTime? AcceptedDate { get; set; }
        [Column("DUE_DATE", TypeName = "datetime")]
        public DateTime? DueDate { get; set; }
        [Column("SETTL_OPE_DATE", TypeName = "datetime")]
        public DateTime? SettlOpeDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("LAST_UPDATE", TypeName = "datetime")]
        public DateTime? LastUpdate { get; set; }
        [Column("SYSTEM_CODE")]
        [StringLength(2)]
        public string SystemCode { get; set; }
        [Column("LAST_OPE_DATE", TypeName = "datetime")]
        public DateTime? LastOpeDate { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("BANK_CD")]
        [StringLength(7)]
        public string BankCd { get; set; }
        [Column("COUNTRY_CD")]
        [StringLength(2)]
        public string CountryCd { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("COMMODITY_CD")]
        [StringLength(3)]
        public string CommodityCd { get; set; }
        [Column("COLLECT_CD")]
        [StringLength(1)]
        public string CollectCd { get; set; }
        [Column("FEE_RATE", TypeName = "decimal(8, 7)")]
        public decimal? FeeRate { get; set; }
        [Column("FEE_CCY_ABBR")]
        [StringLength(4)]
        public string FeeCcyAbbr { get; set; }
        [Column("FEE_CCY_CD")]
        [StringLength(2)]
        public string FeeCcyCd { get; set; }
        [Column("FEE_AMT", TypeName = "decimal(16, 3)")]
        public decimal? FeeAmt { get; set; }
        [Column("FEE_PAYMENT_PAYER")]
        [StringLength(1)]
        public string FeePaymentPayer { get; set; }
        [Column("POSTAGE_CCY_ABBR")]
        [StringLength(4)]
        public string PostageCcyAbbr { get; set; }
        [Column("POSTAGE_CCY_CD")]
        [StringLength(2)]
        public string PostageCcyCd { get; set; }
        [Column("POSTAGE_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? PostageAmount { get; set; }
        [Column("POSTAGE_PAYER")]
        [StringLength(1)]
        public string PostagePayer { get; set; }
        [Column("CABLE_ACT_CD")]
        [StringLength(5)]
        public string CableActCd { get; set; }
        [Column("CABLE_CCY_ABBR")]
        [StringLength(4)]
        public string CableCcyAbbr { get; set; }
        [Column("CABLE_CCY_CD")]
        [StringLength(2)]
        public string CableCcyCd { get; set; }
        [Column("CABLE_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? CableAmount { get; set; }
        [Column("CABLE_PAYER")]
        [StringLength(1)]
        public string CablePayer { get; set; }
        [Column("THEIR_CCY_ABBR")]
        [StringLength(4)]
        public string TheirCcyAbbr { get; set; }
        [Column("THEIR_CCY_CD")]
        [StringLength(2)]
        public string TheirCcyCd { get; set; }
        [Column("THEIR_AMOUNT", TypeName = "decimal(16, 3)")]
        public decimal? TheirAmount { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("DRAFT_NO")]
        [StringLength(15)]
        public string DraftNo { get; set; }
        [Column("TENOR")]
        [StringLength(3)]
        public string Tenor { get; set; }
        [Column("TENOR_CONDITION")]
        [StringLength(31)]
        public string TenorCondition { get; set; }
        [Column("RECEIVE_PAY")]
        [StringLength(70)]
        public string ReceivePay { get; set; }
        [Column("PAYER_ADDR")]
        [StringLength(70)]
        public string PayerAddr { get; set; }
        [Column("NEGOTIATING_BANK")]
        [StringLength(12)]
        public string NegotiatingBank { get; set; }
        [Column("NEGOTIATING_BANK_CD")]
        [StringLength(7)]
        public string NegotiatingBankCd { get; set; }
        [Column("NEGOTIATING_BANK_NAME")]
        [StringLength(70)]
        public string NegotiatingBankName { get; set; }
        [Column("NEGOTIATING_BANK_ADDR")]
        [StringLength(70)]
        public string NegotiatingBankAddr { get; set; }
        [Column("SETTL_BANK_ABBR")]
        [StringLength(12)]
        public string SettlBankAbbr { get; set; }
        [Column("SETTL_BANK_CD")]
        [StringLength(7)]
        public string SettlBankCd { get; set; }
        [Column("SETTL_BANK_NAME")]
        [StringLength(70)]
        public string SettlBankName { get; set; }
        [Column("SETTL_BANK_ACT_CD")]
        [StringLength(5)]
        public string SettlBankActCd { get; set; }
        [Column("SETTL_CUST_ABBR")]
        [StringLength(12)]
        public string SettlCustAbbr { get; set; }
        [Column("SETTL_ACT_NO")]
        [StringLength(12)]
        public string SettlActNo { get; set; }
        [Column("MERCHANDISE_INF")]
        [StringLength(50)]
        public string MerchandiseInf { get; set; }
        [Column("SHIPPED_DATE", TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }
        [Column("ARRIVE_DATE", TypeName = "datetime")]
        public DateTime? ArriveDate { get; set; }
        [Column("VESSEL_NAME")]
        [StringLength(30)]
        public string VesselName { get; set; }
        [Column("DEPARTURE_PORT")]
        [StringLength(30)]
        public string DeparturePort { get; set; }
        [Column("DESTINATION_PORT")]
        [StringLength(30)]
        public string DestinationPort { get; set; }
        [Column("THEIR_REF_NO")]
        [StringLength(20)]
        public string TheirRefNo { get; set; }
        [Column("LC_NO")]
        [StringLength(12)]
        public string LcNo { get; set; }
        [Column("FIRST_DOC_INS")]
        [StringLength(5)]
        public string FirstDocIns { get; set; }
        [Column("FIRST_DOC_BL")]
        [StringLength(5)]
        public string FirstDocBl { get; set; }
        [Column("FIRST_DOC_AIRWY")]
        [StringLength(5)]
        public string FirstDocAirwy { get; set; }
        [Column("SECOND_DOC_INS")]
        [StringLength(5)]
        public string SecondDocIns { get; set; }
        [Column("SECOND_DOC_BL")]
        [StringLength(5)]
        public string SecondDocBl { get; set; }
        [Column("SECOND_DOC_AIRWY")]
        [StringLength(5)]
        public string SecondDocAirwy { get; set; }
        [Column("INSTRUCTION_CD_1")]
        [StringLength(2)]
        public string InstructionCd1 { get; set; }
        [Column("INSTRUCTION_CD_2")]
        [StringLength(2)]
        public string InstructionCd2 { get; set; }
        [Column("INSTRUCTION_CD_3")]
        [StringLength(2)]
        public string InstructionCd3 { get; set; }
        [Column("INSTRUCTION_MSG_1")]
        [StringLength(60)]
        public string InstructionMsg1 { get; set; }
        [Column("INSTRUCTION_MSG_2")]
        [StringLength(60)]
        public string InstructionMsg2 { get; set; }
        [Column("INSTRUCTION_MSG_3")]
        [StringLength(60)]
        public string InstructionMsg3 { get; set; }
        [Column("INSTRUCTION_MSG_4")]
        [StringLength(60)]
        public string InstructionMsg4 { get; set; }
        [Column("INSTRUCTION_MSG_5")]
        [StringLength(60)]
        public string InstructionMsg5 { get; set; }
        [Column("DISCRE_1")]
        [StringLength(30)]
        public string Discre1 { get; set; }
        [Column("DISCRE_2")]
        [StringLength(30)]
        public string Discre2 { get; set; }
        [Column("DISCRE_3")]
        [StringLength(30)]
        public string Discre3 { get; set; }
        [Column("DISCRE_4")]
        [StringLength(30)]
        public string Discre4 { get; set; }
        [Column("DISCRE_5")]
        [StringLength(30)]
        public string Discre5 { get; set; }
        [Column("DISCRE_6")]
        [StringLength(30)]
        public string Discre6 { get; set; }
        [Column("DISCRE_7")]
        [StringLength(30)]
        public string Discre7 { get; set; }
        [Column("DISCRE_8")]
        [StringLength(30)]
        public string Discre8 { get; set; }
        [Column("DISCRE_9")]
        [StringLength(30)]
        public string Discre9 { get; set; }
        [Column("DISCRE_10")]
        [StringLength(30)]
        public string Discre10 { get; set; }
        [Column("ATTENTION_MSG")]
        [StringLength(70)]
        public string AttentionMsg { get; set; }
        [Column("ACT_BANK_ABBR")]
        [StringLength(12)]
        public string ActBankAbbr { get; set; }
        [Column("ACT_BANK_NAME")]
        [StringLength(70)]
        public string ActBankName { get; set; }
        [Column("REMARKS_EUC")]
        [StringLength(20)]
        public string RemarksEuc { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
