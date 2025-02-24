using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MsmqMessageHistoryData", Schema = "dbo")]
    public partial class MsmqMessageHistoryDatum
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Id { get; set; }
        [StringLength(1000)]
        [Unicode(false)]
        public string QueuePath { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string TransactionRefNo { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string MessageLabel { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string MessageBody { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ReceivedTime { get; set; }
    }
}
