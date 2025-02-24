using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("CUST_ACCOUNT_NO", Schema = "dbo")]
    public partial class CustAccountNo
    {
        [Key]
        [Column("ACT_ID")]
        public int ActId { get; set; }
        [Required]
        [Column("ACT_CD")]
        [StringLength(5)]
        [Unicode(false)]
        public string ActCd { get; set; }
        [Required]
        [Column("CCY_CD")]
        [StringLength(2)]
        [Unicode(false)]
        public string CcyCd { get; set; }
        [Required]
        [Column("ACT_NO")]
        [StringLength(9)]
        [Unicode(false)]
        public string ActNo { get; set; }
        [Column("ACT_DESCRIPTION")]
        [StringLength(25)]
        [Unicode(false)]
        public string ActDescription { get; set; }
        [Column("UBO")]
        [StringLength(1)]
        [Unicode(false)]
        public string Ubo { get; set; }
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
        [Column("ADD_BY")]
        [StringLength(6)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime? AddOn { get; set; }
        [Column("AUTHORIZE_BY")]
        [StringLength(6)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column("AUTHORIZE_ON", TypeName = "smalldatetime")]
        public DateTime? AuthorizeOn { get; set; }
        [Column("STATUS")]
        [StringLength(1)]
        [Unicode(false)]
        public string Status { get; set; }
    }
}
