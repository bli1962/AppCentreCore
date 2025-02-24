using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("CREDIT_LINE", Schema = "EUC")]
    public partial class CreditLine
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("EXPIRY_DATE", TypeName = "datetime")]
        public DateTime? ExpiryDate { get; set; }
        [Column("NEXT_APPL_DUE", TypeName = "datetime")]
        public DateTime? NextApplDue { get; set; }
        [Column("LOAN_CRED_TYPE")]
        [StringLength(1)]
        public string LoanCredType { get; set; }
        [Column("OD_CRED_TYPE")]
        [StringLength(1)]
        public string OdCredType { get; set; }
        [Column("LC_CRED_TYPE")]
        [StringLength(1)]
        public string LcCredType { get; set; }
        [Column("IBD_CRED_TYPE")]
        [StringLength(1)]
        public string IbdCredType { get; set; }
        [Column("ACC_CRED_TYPE")]
        [StringLength(1)]
        public string AccCredType { get; set; }
        [Column("GRT_CRED_TYPE")]
        [StringLength(1)]
        public string GrtCredType { get; set; }
        [Column("BB_CRED_TYPE")]
        [StringLength(1)]
        public string BbCredType { get; set; }
        [Column("LOAN_CCY_ABBR")]
        [StringLength(4)]
        public string LoanCcyAbbr { get; set; }
        [Column("LOAN_CCY_CD")]
        [StringLength(2)]
        public string LoanCcyCd { get; set; }
        [Column("LOAN_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? LoanLineAmt { get; set; }
        [Column("OD_CCY_ABBR")]
        [StringLength(4)]
        public string OdCcyAbbr { get; set; }
        [Column("OD_CCY_CD")]
        [StringLength(2)]
        public string OdCcyCd { get; set; }
        [Column("OD_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? OdLineAmt { get; set; }
        [Column("LC_CCY_ABBR")]
        [StringLength(4)]
        public string LcCcyAbbr { get; set; }
        [Column("LC_CCY_CD")]
        [StringLength(2)]
        public string LcCcyCd { get; set; }
        [Column("LC_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? LcLineAmt { get; set; }
        [Column("IBD_CCY_ABBR")]
        [StringLength(4)]
        public string IbdCcyAbbr { get; set; }
        [Column("IBD_CCY_CD")]
        [StringLength(2)]
        public string IbdCcyCd { get; set; }
        [Column("IBD_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? IbdLineAmt { get; set; }
        [Column("ACC_CCY_ABBR")]
        [StringLength(4)]
        public string AccCcyAbbr { get; set; }
        [Column("ACC_CCY_CD")]
        [StringLength(2)]
        public string AccCcyCd { get; set; }
        [Column("ACC_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? AccLineAmt { get; set; }
        [Column("GRT_CCY_ABBR")]
        [StringLength(4)]
        public string GrtCcyAbbr { get; set; }
        [Column("GRT_CCY_CD")]
        [StringLength(2)]
        public string GrtCcyCd { get; set; }
        [Column("GRT_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? GrtLineAmt { get; set; }
        [Column("BB_CCY_ABBR")]
        [StringLength(4)]
        public string BbCcyAbbr { get; set; }
        [Column("BB_CCY_CD")]
        [StringLength(2)]
        public string BbCcyCd { get; set; }
        [Column("BB_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? BbLineAmt { get; set; }
        [Column("TTL_CCY_ABBR")]
        [StringLength(4)]
        public string TtlCcyAbbr { get; set; }
        [Column("TTL_CCY_CD")]
        [StringLength(2)]
        public string TtlCcyCd { get; set; }
        [Column("TTL_LINE_AMT", TypeName = "decimal(18, 3)")]
        public decimal? TtlLineAmt { get; set; }
        [Column("REGISTERED", TypeName = "datetime")]
        public DateTime? Registered { get; set; }
        [Column("APPL_KIND")]
        [StringLength(1)]
        public string ApplKind { get; set; }
        [Column("PURPOSE_CD")]
        [StringLength(2)]
        public string PurposeCd { get; set; }
        [Column("RISK_COUNTRY")]
        [StringLength(2)]
        public string RiskCountry { get; set; }
        [Column("RISK_CUST_ABBR")]
        [StringLength(12)]
        public string RiskCustAbbr { get; set; }
        [Column("COMMIT_AVAIL")]
        [StringLength(1)]
        public string CommitAvail { get; set; }
        [Column("GRADE_CD")]
        [StringLength(2)]
        public string GradeCd { get; set; }
        [Column("RATING_POINT", TypeName = "decimal(3, 0)")]
        public decimal? RatingPoint { get; set; }
        [Column("RATING_APPL")]
        [StringLength(9)]
        public string RatingAppl { get; set; }
        [Column("DELETION_DATE", TypeName = "datetime")]
        public DateTime? DeletionDate { get; set; }
        [Column("TMP_OD_CCY_ABBR")]
        [StringLength(4)]
        public string TmpOdCcyAbbr { get; set; }
        [Column("TMP_OD_CCY_CD")]
        [StringLength(2)]
        public string TmpOdCcyCd { get; set; }
        [Column("TMP_OD_AMOUNT", TypeName = "decimal(21, 3)")]
        public decimal? TmpOdAmount { get; set; }
        [Column("TOT_APPL_NO")]
        [StringLength(7)]
        public string TotApplNo { get; set; }
        [Column("SUB_LIMIT_NO_1")]
        [StringLength(2)]
        public string SubLimitNo1 { get; set; }
        [Column("SUB_LIMIT_NO_2")]
        [StringLength(2)]
        public string SubLimitNo2 { get; set; }
        [Column("SUB_LIMIT_NO_3")]
        [StringLength(2)]
        public string SubLimitNo3 { get; set; }
        [Column("SUB_LIMIT_NO_4")]
        [StringLength(2)]
        public string SubLimitNo4 { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
