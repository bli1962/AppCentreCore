using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CUST_ACCOUNT_NO")]
    public partial class CustAccountNo
    {
        [Key]
        [Column("ACT_ID")]
        public int ActId { get; set; }
        [Required]
        [Column("ACT_CD")]
        [StringLength(5)]
        public string ActCd { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        public string CcyCd { get; set; }
        [Required]
        [Column("ACT_NO")]
        [StringLength(9)]
        public string ActNo { get; set; }
        [Column("ACT_DESCRIPTION")]
        [StringLength(25)]
        public string ActDescription { get; set; }
        [Column("UBO")]
        [StringLength(1)]
        public string Ubo { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        public string BranchNo { get; set; }
        [Column("ADD_BY")]
        [StringLength(6)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime? AddOn { get; set; }
        [Column("AUTHORIZE_BY")]
        [StringLength(6)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime? AuthorizeOn { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }
    }
}
