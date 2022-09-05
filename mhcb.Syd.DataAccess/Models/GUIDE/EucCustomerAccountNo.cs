using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_CUSTOMER_ACCOUNT_NO")]
    public partial class EucCustomerAccountNo
    {
        [Key]
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Key]
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Column("ACT_ABBR ")]
        [StringLength(15)]
        public string ActAbbr { get; set; }
        [Key]
        [Column("ACT_NO")]
        [StringLength(13)]
        public string ActNo { get; set; }
        [Column("ACT_NAME")]
        [StringLength(30)]
        public string ActName { get; set; }
        [Column("ACT_SHORT_NAME")]
        [StringLength(12)]
        public string ActShortName { get; set; }
        [Key]
        [Column("IBF_ID")]
        [StringLength(1)]
        public string IbfId { get; set; }
        [Key]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Column("CCY_ABBR")]
        [StringLength(4)]
        public string CcyAbbr { get; set; }
        [Column("REMARKS")]
        [StringLength(20)]
        public string Remarks { get; set; }
        [Key]
        [Column("STATUS_CD")]
        [StringLength(1)]
        public string StatusCd { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
    }
}
