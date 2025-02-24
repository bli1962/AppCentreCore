using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MsmqMessageData", Schema = "dbo")]
    public partial class MsmqMessageDatum
    {
        [Key]
        [Column(TypeName = "decimal(18, 0)")]
        public decimal Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReceivedTime { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string QueueName { get; set; }
        [Required]
        [StringLength(255)]
        [Unicode(false)]
        public string MessageLabel { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string MessageBody { get; set; }
    }
}
