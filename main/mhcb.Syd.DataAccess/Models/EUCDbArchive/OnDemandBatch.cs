using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Table("OnDemand_Batch")]
    public partial class OnDemandBatch
    {
        public OnDemandBatch()
        {
            OnDemandBatchLogs = new HashSet<OnDemandBatchLog>();
        }

        [Key]
        public int BatchId { get; set; }
        public int? BatchNo { get; set; }
        public bool Started { get; set; }
        public bool Completed { get; set; }
        public bool Errored { get; set; }
        public bool IsRec { get; set; }
        [Required]
        [StringLength(50)]
        public string WhoRequested { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime UpdatedWhen { get; set; }

        [InverseProperty(nameof(OnDemandBatchLog.Batch))]
        public virtual ICollection<OnDemandBatchLog> OnDemandBatchLogs { get; set; }
    }
}
