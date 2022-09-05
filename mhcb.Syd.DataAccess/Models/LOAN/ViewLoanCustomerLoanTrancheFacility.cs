using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Keyless]
    public partial class ViewLoanCustomerLoanTrancheFacility
    {
        [Column("LOAN_NO")]
        public int LoanNo { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("LOAN_CUST_ABBR")]
        [StringLength(12)]
        public string LoanCustAbbr { get; set; }
        [Column("MULTI_BRW")]
        public bool? MultiBrw { get; set; }
        [Column("RATING")]
        [StringLength(2)]
        public string Rating { get; set; }
        [Required]
        [Column("RATIO_SPREAD1")]
        [StringLength(20)]
        public string RatioSpread1 { get; set; }
        [Required]
        [Column("RATIO_SPREAD2")]
        [StringLength(20)]
        public string RatioSpread2 { get; set; }
        [Column("PROD_DESC_2")]
        [StringLength(20)]
        public string ProdDesc2 { get; set; }
        [Column("PROD_DESC_4")]
        [StringLength(20)]
        public string ProdDesc4 { get; set; }
        [Required]
        [Column("LOAN_STATUS")]
        [StringLength(9)]
        public string LoanStatus { get; set; }
        [Column("TRANCHE_NO")]
        public int? TrancheNo { get; set; }
        [Column("TRANCHE_NAME")]
        [StringLength(22)]
        public string TrancheName { get; set; }
        [Column("APPLN_NO")]
        [StringLength(11)]
        public string ApplnNo { get; set; }
        [Column("BASE_CCY")]
        [StringLength(3)]
        public string BaseCcy { get; set; }
        [Column("TRANCHE_PORTION", TypeName = "decimal(38, 2)")]
        public decimal? TranchePortion { get; set; }
        [Column("AVAIL_START", TypeName = "datetime")]
        public DateTime? AvailStart { get; set; }
        [Column("AVAIL_END", TypeName = "datetime")]
        public DateTime? AvailEnd { get; set; }
        [Column("MAT_DATE", TypeName = "datetime")]
        public DateTime? MatDate { get; set; }
        [Required]
        [Column("TRANCHE_STATUS")]
        [StringLength(9)]
        public string TrancheStatus { get; set; }
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("LIMIT", TypeName = "decimal(27, 4)")]
        public decimal? Limit { get; set; }
        [Column("CUST_NAME")]
        [StringLength(40)]
        public string CustName { get; set; }
        [Column("CUST_STATUS_CD")]
        [StringLength(1)]
        public string CustStatusCd { get; set; }
    }
}
