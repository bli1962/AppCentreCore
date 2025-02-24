using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Dealing_SettlementOfficeMap", Schema = "dbo")]
    public partial class DealingSettlementOfficeMap
    {
        [Key]
        [Column("Dealing_SettlementOfficeID")]
        public int DealingSettlementOfficeId { get; set; }
        [StringLength(4)]
        [Unicode(false)]
        public string DealingOfficeCode { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string DealingOfficeName { get; set; }
        [StringLength(100)]
        [Unicode(false)]
        public string DealingOfficeLocation { get; set; }
        [StringLength(6)]
        [Unicode(false)]
        public string SettlementOfficeCode { get; set; }
        public bool? Active { get; set; }
        [StringLength(10)]
        [Unicode(false)]
        public string DealingSystem { get; set; }
        [Column("Created_By")]
        [StringLength(50)]
        [Unicode(false)]
        public string CreatedBy { get; set; }
        [Column("Created_Date", TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column("Modified_By")]
        [StringLength(50)]
        [Unicode(false)]
        public string ModifiedBy { get; set; }
        [Column("Modified_Date", TypeName = "datetime")]
        public DateTime? ModifiedDate { get; set; }
    }
}
