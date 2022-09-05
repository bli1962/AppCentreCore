using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T03_TOTAL_CREDIT_LINE", Schema = "EUC")]
    public partial class T03TotalCreditLine
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("TOT_APPL_NO")]
        [StringLength(7)]
        public string TotApplNo { get; set; }
        [Column("TOT_CUST_ABBR")]
        [StringLength(12)]
        public string TotCustAbbr { get; set; }
        [Column("TOT_CCY_ABBR")]
        [StringLength(4)]
        public string TotCcyAbbr { get; set; }
        [Column("TOT_CCY_CD")]
        [StringLength(2)]
        public string TotCcyCd { get; set; }
        [Column("TOT_AMOUNT", TypeName = "decimal(21, 3)")]
        public decimal? TotAmount { get; set; }
        [Column("TOT_BALANCE", TypeName = "decimal(21, 3)")]
        public decimal? TotBalance { get; set; }
        [Column("REMARKS")]
        [StringLength(10)]
        public string Remarks { get; set; }
        [Column("SUB_LIMIT_CNT")]
        [StringLength(5)]
        public string SubLimitCnt { get; set; }
        [Column("TOT_REG_DATE", TypeName = "datetime")]
        public DateTime? TotRegDate { get; set; }
        [Column("TOT_MOD_DATE", TypeName = "datetime")]
        public DateTime? TotModDate { get; set; }
        [Column("TOT_DEL_DATE", TypeName = "datetime")]
        public DateTime? TotDelDate { get; set; }
        [Column("SUB_LIMIT_NO")]
        [StringLength(2)]
        public string SubLimitNo { get; set; }
        [Column("SUB_CCY_ABBR")]
        [StringLength(4)]
        public string SubCcyAbbr { get; set; }
        [Column("SUB_CCY_CD")]
        [StringLength(2)]
        public string SubCcyCd { get; set; }
        [Column("SUB_AMOUNT", TypeName = "decimal(21, 3)")]
        public decimal? SubAmount { get; set; }
        [Column("SUB_BALANCE", TypeName = "decimal(21, 3)")]
        public decimal? SubBalance { get; set; }
        [Column("SUB_CUST_ABBR")]
        [StringLength(12)]
        public string SubCustAbbr { get; set; }
        [Column("SUB_REMARKS")]
        [StringLength(10)]
        public string SubRemarks { get; set; }
        [Column("APPL_CTR")]
        [StringLength(5)]
        public string ApplCtr { get; set; }
        [Column("SUB_REG_DATE", TypeName = "datetime")]
        public DateTime? SubRegDate { get; set; }
        [Column("SUB_MOD_DATE", TypeName = "datetime")]
        public DateTime? SubModDate { get; set; }
        [Column("SUB_DEL_DATE", TypeName = "datetime")]
        public DateTime? SubDelDate { get; set; }
        [Column("APPL_NO")]
        [StringLength(7)]
        public string ApplNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
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
        [Column("CONSOLI_BRNO1")]
        [StringLength(3)]
        public string ConsoliBrno1 { get; set; }
        [Column("CONSOLI_BRNO2")]
        [StringLength(3)]
        public string ConsoliBrno2 { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
