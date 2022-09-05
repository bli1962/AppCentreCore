using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Keyless]
    [Table("T04_CUSTOMER_BALANCE", Schema = "EUC")]
    public partial class T04CustomerBalance
    {
        [Column("DATA_DATE", TypeName = "datetime")]
        public DateTime? DataDate { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("BRANCH_NAME")]
        [StringLength(25)]
        public string BranchName { get; set; }
        [Column("DEPT_CD")]
        [StringLength(2)]
        public string DeptCd { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("LOAN_BC", TypeName = "decimal(18, 3)")]
        public decimal? LoanBc { get; set; }
        [Column("BB_BC", TypeName = "decimal(18, 3)")]
        public decimal? BbBc { get; set; }
        [Column("IB_BC", TypeName = "decimal(18, 3)")]
        public decimal? IbBc { get; set; }
        [Column("ACC_BC", TypeName = "decimal(18, 3)")]
        public decimal? AccBc { get; set; }
        [Column("LC_BC", TypeName = "decimal(18, 3)")]
        public decimal? LcBc { get; set; }
        [Column("GRT_BC", TypeName = "decimal(18, 3)")]
        public decimal? GrtBc { get; set; }
        [Column("SEC_BC", TypeName = "decimal(18, 3)")]
        public decimal? SecBc { get; set; }
        [Column("TOTAL_BC", TypeName = "decimal(18, 3)")]
        public decimal? TotalBc { get; set; }
        [Column("CURRENT_ACT_BC", TypeName = "decimal(18, 3)")]
        public decimal? CurrentActBc { get; set; }
        [Column("LOAN_FC", TypeName = "decimal(18, 3)")]
        public decimal? LoanFc { get; set; }
        [Column("BB_FC", TypeName = "decimal(18, 3)")]
        public decimal? BbFc { get; set; }
        [Column("IB_FC", TypeName = "decimal(18, 3)")]
        public decimal? IbFc { get; set; }
        [Column("ACC_FC", TypeName = "decimal(18, 3)")]
        public decimal? AccFc { get; set; }
        [Column("LC_FC", TypeName = "decimal(18, 3)")]
        public decimal? LcFc { get; set; }
        [Column("GRT_FC", TypeName = "decimal(18, 3)")]
        public decimal? GrtFc { get; set; }
        [Column("SEC_FC", TypeName = "decimal(18, 3)")]
        public decimal? SecFc { get; set; }
        [Column("TOTAL_FC", TypeName = "decimal(18, 3)")]
        public decimal? TotalFc { get; set; }
        [Column("CURRENT_ACT_FC", TypeName = "decimal(18, 3)")]
        public decimal? CurrentActFc { get; set; }
        [Column("UPDATEDATE", TypeName = "datetime")]
        public DateTime? Updatedate { get; set; }
    }
}
