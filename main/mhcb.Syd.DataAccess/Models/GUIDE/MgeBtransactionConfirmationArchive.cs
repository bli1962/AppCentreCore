using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MGeBTransactionConfirmationArchive", Schema = "dbo")]
    public partial class MgeBtransactionConfirmationArchive
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("gBaseDocumentId")]
        public int GBaseDocumentId { get; set; }
        [Column("eDistributionId")]
        public int? EDistributionId { get; set; }
        [Required]
        [StringLength(100)]
        [Unicode(false)]
        public string ReferenceNumber { get; set; }
        [Required]
        [Unicode(false)]
        public string SourceLocation { get; set; }
        [Required]
        [Unicode(false)]
        public string DestinationLocation { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime AddDate { get; set; }
    }
}
