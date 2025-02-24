using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("EUC_INDUSTRY_CODE", Schema = "dbo")]
    public partial class EucIndustryCode
    {
        [Key]
        [Column("INDUSTRY_CD")]
        [StringLength(6)]
        [Unicode(false)]
        public string IndustryCd { get; set; }
        [Column("INDUSTRY_NAME")]
        [StringLength(50)]
        [Unicode(false)]
        public string IndustryName { get; set; }
        [Key]
        [Column("BRANCH_NO")]
        [StringLength(3)]
        [Unicode(false)]
        public string BranchNo { get; set; }
    }
}
