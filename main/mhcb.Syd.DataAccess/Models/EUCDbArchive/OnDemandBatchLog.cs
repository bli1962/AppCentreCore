using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.EUCDbArchive
{
    [Table("OnDemand_Batch_Log")]
    public partial class OnDemandBatchLog
    {
        [Key]
        public int LogId { get; set; }
        public int BatchId { get; set; }
        [Required]
        [StringLength(50)]
        public string Level { get; set; }
        [Required]
        [StringLength(2048)]
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime When { get; set; }

        [ForeignKey(nameof(BatchId))]
        [InverseProperty(nameof(OnDemandBatch.OnDemandBatchLogs))]
        public virtual OnDemandBatch Batch { get; set; }
    }
}
