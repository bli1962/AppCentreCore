using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("M02_ACCOUNT_ACM_BAL", Schema = "EUC")]
    public partial class M02AccountAcmBal
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("ACT_NO")]
        [StringLength(12)]
        public string ActNo { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("CURR_M_FROM_DATE", TypeName = "datetime")]
        public DateTime? CurrMFromDate { get; set; }
        [Column("CURR_M_TO_DATE", TypeName = "datetime")]
        public DateTime? CurrMToDate { get; set; }
        [Column("CURR_M_DAYS")]
        [StringLength(3)]
        public string CurrMDays { get; set; }
        [Column("BAL_BOOK_ACM_CURR_M", TypeName = "decimal(19, 3)")]
        public decimal? BalBookAcmCurrM { get; set; }
        [Column("BAL_OD_BOOK_ACM_CURR_M", TypeName = "decimal(19, 3)")]
        public decimal? BalOdBookAcmCurrM { get; set; }
        [Column("BAL_VALUE_ACM_CURR_M", TypeName = "decimal(19, 3)")]
        public decimal? BalValueAcmCurrM { get; set; }
        [Column("BAL_OD_VALUE_ACM_CURR_M", TypeName = "decimal(19, 3)")]
        public decimal? BalOdValueAcmCurrM { get; set; }
        [Column("PREV_M_FROM_DATE", TypeName = "datetime")]
        public DateTime? PrevMFromDate { get; set; }
        [Column("PREV_M_TO_DATE", TypeName = "datetime")]
        public DateTime? PrevMToDate { get; set; }
        [Column("PREV_M_DAYS")]
        [StringLength(3)]
        public string PrevMDays { get; set; }
        [Column("BAL_BOOK_ACM_PREV_M", TypeName = "decimal(19, 3)")]
        public decimal? BalBookAcmPrevM { get; set; }
        [Column("BAL_OD_BOOK_ACM_PREV_M", TypeName = "decimal(19, 3)")]
        public decimal? BalOdBookAcmPrevM { get; set; }
        [Column("BAL_VALUE_ACM_PREV_M", TypeName = "decimal(19, 3)")]
        public decimal? BalValueAcmPrevM { get; set; }
        [Column("BAL_OD_VALUE_ACM_PREV_M", TypeName = "decimal(19, 3)")]
        public decimal? BalOdValueAcmPrevM { get; set; }
        [Column("CURR_T_FROM_DATE", TypeName = "datetime")]
        public DateTime? CurrTFromDate { get; set; }
        [Column("CURR_T_TO_DATE", TypeName = "datetime")]
        public DateTime? CurrTToDate { get; set; }
        [Column("CURR_T_DAYS")]
        [StringLength(3)]
        public string CurrTDays { get; set; }
        [Column("BAL_BOOK_ACM_CURR_T", TypeName = "decimal(21, 3)")]
        public decimal? BalBookAcmCurrT { get; set; }
        [Column("BAL_OD_BOOK_ACM_CURR_T", TypeName = "decimal(21, 3)")]
        public decimal? BalOdBookAcmCurrT { get; set; }
        [Column("BAL_VALUE_ACM_CURR_T", TypeName = "decimal(21, 3)")]
        public decimal? BalValueAcmCurrT { get; set; }
        [Column("BAL_OD_VALUE_ACM_CURR_T", TypeName = "decimal(21, 3)")]
        public decimal? BalOdValueAcmCurrT { get; set; }
        [Column("VALUE_ADJUST_FG")]
        [StringLength(1)]
        public string ValueAdjustFg { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
