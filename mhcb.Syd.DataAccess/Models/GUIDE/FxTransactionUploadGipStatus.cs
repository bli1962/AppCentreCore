using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_TRANSACTION_UploadGipStatus")]
    public partial class FxTransactionUploadGipStatus
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Description { get; set; }
        [Key]
        [Column("Gip_Status")]
        public int GipStatus { get; set; }
    }
}
