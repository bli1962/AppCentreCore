using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Dealing_SettlementOfficeMap")]
    public partial class DealingSettlementOfficeMap
    {
        [Key]
        [Column("Dealing_SettlementOfficeID")]
        public int DealingSettlementOfficeId { get; set; }
        [StringLength(4)]
        public string DealingOfficeCode { get; set; }
        [StringLength(50)]
        public string DealingOfficeName { get; set; }
        [StringLength(100)]
        public string DealingOfficeLocation { get; set; }
        [StringLength(6)]
        public string SettlementOfficeCode { get; set; }
        public bool? Active { get; set; }
        [StringLength(10)]
        public string DealingSystem { get; set; }
        [Column("Created_By")]
        [StringLength(50)]
        public string CreatedBy { get; set; }
        [Column("Created_Date", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("Modified_By")]
        [StringLength(50)]
        public string ModifiedBy { get; set; }
        [Column("Modified_Date", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
