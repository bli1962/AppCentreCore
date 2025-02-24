using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_UnitCodeAccount", Schema = "dbo")]
    public partial class DomesticClearingUnitCodeAccount
    {
        public DomesticClearingUnitCodeAccount()
        {
            DomesticClearingUnitCodeAccountLogs = new HashSet<DomesticClearingUnitCodeAccountLog>();
        }

        [Key]
        public int UnitCodeAccountId { get; set; }
        [Required]
        [StringLength(1024)]
        public string UnitCode { get; set; }
        [Required]
        [StringLength(1024)]
        public string CustomerCurrentAccount { get; set; }
        public int? StatusId { get; set; }
        [StringLength(50)]
        public string StatusIdUpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? PreviousStatusId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("DomesticClearingUnitCodeAccounts")]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty("UnitCodeAccount")]
        public virtual ICollection<DomesticClearingUnitCodeAccountLog> DomesticClearingUnitCodeAccountLogs { get; set; }
    }
}
