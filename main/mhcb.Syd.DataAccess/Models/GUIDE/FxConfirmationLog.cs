using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FxConfirmationLog", Schema = "dbo")]
    public partial class FxConfirmationLog
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("gBaseDocumentId")]
        public int? GBaseDocumentId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ReferenceNumber { get; set; }
        [Column("FxConfirmationStatusID")]
        public int FxConfirmationStatusId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddDate { get; set; }
        [Required]
        [StringLength(1000)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column("MGeBTransactionConfirmationId")]
        public int? MgeBtransactionConfirmationId { get; set; }
        public int? ChannelId { get; set; }
    }
}
