using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M_FWD_VALUE_REMIT_LIMIT", Schema = "EUC")]
    public partial class MFwdValueRemitLimit
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("LIMT_CCY_CD")]
        [StringLength(2)]
        public string LimtCcyCd { get; set; }
        [Column("LIMIT_CCY_ABBR")]
        [StringLength(4)]
        public string LimitCcyAbbr { get; set; }
        [Column("LIMIT", TypeName = "decimal(25, 3)")]
        public decimal? Limit { get; set; }
        [Column("BASE_DATE", TypeName = "datetime")]
        public DateTime? BaseDate { get; set; }
        [Column("BALANCE_01", TypeName = "decimal(25, 3)")]
        public decimal? Balance01 { get; set; }
        [Column("BALANCE_02", TypeName = "decimal(25, 3)")]
        public decimal? Balance02 { get; set; }
        [Column("BALANCE_03", TypeName = "decimal(25, 3)")]
        public decimal? Balance03 { get; set; }
        [Column("BALANCE_04", TypeName = "decimal(25, 3)")]
        public decimal? Balance04 { get; set; }
        [Column("BALANCE_05", TypeName = "decimal(25, 3)")]
        public decimal? Balance05 { get; set; }
        [Column("BALANCE_06", TypeName = "decimal(25, 3)")]
        public decimal? Balance06 { get; set; }
        [Column("BALANCE_07", TypeName = "decimal(25, 3)")]
        public decimal? Balance07 { get; set; }
        [Column("BALANCE_08", TypeName = "decimal(25, 3)")]
        public decimal? Balance08 { get; set; }
        [Column("BALANCE_09", TypeName = "decimal(25, 3)")]
        public decimal? Balance09 { get; set; }
        [Column("BALANCE_10", TypeName = "decimal(25, 3)")]
        public decimal? Balance10 { get; set; }
        [Column("BALANCE_11", TypeName = "decimal(25, 3)")]
        public decimal? Balance11 { get; set; }
        [Column("BALANCE_12", TypeName = "decimal(25, 3)")]
        public decimal? Balance12 { get; set; }
        [Column("BALANCE_13", TypeName = "decimal(25, 3)")]
        public decimal? Balance13 { get; set; }
        [Column("BALANCE_14", TypeName = "decimal(25, 3)")]
        public decimal? Balance14 { get; set; }
        [Column("BALANCE_15", TypeName = "decimal(25, 3)")]
        public decimal? Balance15 { get; set; }
        [Column("BALANCE_16", TypeName = "decimal(25, 3)")]
        public decimal? Balance16 { get; set; }
        [Column("BALANCE_17", TypeName = "decimal(25, 3)")]
        public decimal? Balance17 { get; set; }
        [Column("BALANCE_18", TypeName = "decimal(25, 3)")]
        public decimal? Balance18 { get; set; }
        [Column("BALANCE_19", TypeName = "decimal(25, 3)")]
        public decimal? Balance19 { get; set; }
        [Column("BALANCE_20", TypeName = "decimal(25, 3)")]
        public decimal? Balance20 { get; set; }
        [Column("BALANCE_21", TypeName = "decimal(25, 3)")]
        public decimal? Balance21 { get; set; }
        [Column("BALANCE_22", TypeName = "decimal(25, 3)")]
        public decimal? Balance22 { get; set; }
        [Column("BALANCE_23", TypeName = "decimal(25, 3)")]
        public decimal? Balance23 { get; set; }
        [Column("BALANCE_24", TypeName = "decimal(25, 3)")]
        public decimal? Balance24 { get; set; }
        [Column("BALANCE_25", TypeName = "decimal(25, 3)")]
        public decimal? Balance25 { get; set; }
        [Column("BALANCE_26", TypeName = "decimal(25, 3)")]
        public decimal? Balance26 { get; set; }
        [Column("BALANCE_27", TypeName = "decimal(25, 3)")]
        public decimal? Balance27 { get; set; }
        [Column("BALANCE_28", TypeName = "decimal(25, 3)")]
        public decimal? Balance28 { get; set; }
        [Column("BALANCE_29", TypeName = "decimal(25, 3)")]
        public decimal? Balance29 { get; set; }
        [Column("BALANCE_30", TypeName = "decimal(25, 3)")]
        public decimal? Balance30 { get; set; }
        [Column("BALANCE_31", TypeName = "decimal(25, 3)")]
        public decimal? Balance31 { get; set; }
        [Column("BALANCE_32", TypeName = "decimal(25, 3)")]
        public decimal? Balance32 { get; set; }
        [Column("BALANCE_33", TypeName = "decimal(25, 3)")]
        public decimal? Balance33 { get; set; }
        [Column("BALANCE_34", TypeName = "decimal(25, 3)")]
        public decimal? Balance34 { get; set; }
        [Column("BALANCE_35", TypeName = "decimal(25, 3)")]
        public decimal? Balance35 { get; set; }
        [Column("BALANCE_36", TypeName = "decimal(25, 3)")]
        public decimal? Balance36 { get; set; }
        [Column("BALANCE_37", TypeName = "decimal(25, 3)")]
        public decimal? Balance37 { get; set; }
        [Column("BALANCE_38", TypeName = "decimal(25, 3)")]
        public decimal? Balance38 { get; set; }
        [Column("BALANCE_39", TypeName = "decimal(25, 3)")]
        public decimal? Balance39 { get; set; }
        [Column("BALANCE_40", TypeName = "decimal(25, 3)")]
        public decimal? Balance40 { get; set; }
        [Column("BALANCE_41", TypeName = "decimal(25, 3)")]
        public decimal? Balance41 { get; set; }
        [Column("BALANCE_42", TypeName = "decimal(25, 3)")]
        public decimal? Balance42 { get; set; }
        [Column("BALANCE_43", TypeName = "decimal(25, 3)")]
        public decimal? Balance43 { get; set; }
        [Column("BALANCE_44", TypeName = "decimal(25, 3)")]
        public decimal? Balance44 { get; set; }
        [Column("BALANCE_45", TypeName = "decimal(25, 3)")]
        public decimal? Balance45 { get; set; }
        [Column("BALANCE_46", TypeName = "decimal(25, 3)")]
        public decimal? Balance46 { get; set; }
        [Column("BALANCE_47", TypeName = "decimal(25, 3)")]
        public decimal? Balance47 { get; set; }
        [Column("BALANCE_48", TypeName = "decimal(25, 3)")]
        public decimal? Balance48 { get; set; }
        [Column("BALANCE_49", TypeName = "decimal(25, 3)")]
        public decimal? Balance49 { get; set; }
        [Column("BALANCE_50", TypeName = "decimal(25, 3)")]
        public decimal? Balance50 { get; set; }
        [Column("INP_DATE", TypeName = "datetime")]
        public DateTime? InpDate { get; set; }
        [Column("MODIFIED_DATE", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
        [Column("HO_RATE_CHG_DATE", TypeName = "datetime")]
        public DateTime? HoRateChgDate { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("OPE_DATE", TypeName = "datetime")]
        public DateTime? OpeDate { get; set; }
        [Column("TRANS_NO")]
        [StringLength(5)]
        public string TransNo { get; set; }
        [Column("PO_ISSUE_DATE", TypeName = "datetime")]
        public DateTime? PoIssueDate { get; set; }
        [Column("VALUE_DATE", TypeName = "datetime")]
        public DateTime? ValueDate { get; set; }
        [Column("DTL_CCY_CD")]
        [StringLength(2)]
        public string DtlCcyCd { get; set; }
        [Column("DTL_CCY_ABBR")]
        [StringLength(4)]
        public string DtlCcyAbbr { get; set; }
        [Column("AMOUNT", TypeName = "decimal(19, 3)")]
        public decimal? Amount { get; set; }
        [Column("CONVERT_AMT", TypeName = "decimal(19, 3)")]
        public decimal? ConvertAmt { get; set; }
        [Column("DELETE_FLG")]
        [StringLength(1)]
        public string DeleteFlg { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
