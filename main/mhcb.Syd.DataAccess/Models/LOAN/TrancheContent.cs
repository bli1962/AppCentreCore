using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.LOAN
{
    [Table("TRANCHE_CONTENT")]
    public partial class TrancheContent
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("TRANCHE_NO")]
        public int TrancheNo { get; set; }
        [Required]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("CUST_ABBR")]
        [StringLength(12)]
        public string CustAbbr { get; set; }
        [Column("LIMIT", TypeName = "decimal(27, 4)")]
        public decimal? Limit { get; set; }
        [Required]
        [Column("CCY")]
        [StringLength(3)]
        public string Ccy { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(1)]
        public string Status { get; set; }

        [ForeignKey(nameof(TrancheNo))]
        [InverseProperty(nameof(TrancheMaster.TrancheContents))]
        public virtual TrancheMaster TrancheNoNavigation { get; set; }
    }
}
