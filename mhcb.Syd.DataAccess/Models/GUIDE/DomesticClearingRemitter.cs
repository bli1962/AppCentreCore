using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("DomesticClearing_Remitter")]
    [Index(nameof(CustomerAbbreviation), Name = "UQ_DomesticClearing_Remitter_CustomerAbbreviation", IsUnique = true)]
    public partial class DomesticClearingRemitter
    {
        public DomesticClearingRemitter()
        {
            DomesticClearingRemitterLogs = new HashSet<DomesticClearingRemitterLog>();
        }

        [Key]
        public int RemitterId { get; set; }
        [Required]
        [StringLength(12)]
        public string CustomerAbbreviation { get; set; }
        [Required]
        [StringLength(16)]
        public string RemitterName { get; set; }
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

        [ForeignKey(nameof(StatusId))]
        [InverseProperty(nameof(DomesticClearingStatus.DomesticClearingRemitters))]
        public virtual DomesticClearingStatus Status { get; set; }
        [InverseProperty(nameof(DomesticClearingRemitterLog.Remitter))]
        public virtual ICollection<DomesticClearingRemitterLog> DomesticClearingRemitterLogs { get; set; }
    }
}
