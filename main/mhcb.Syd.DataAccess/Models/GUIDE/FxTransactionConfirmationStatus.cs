using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_TRANSACTION_ConfirmationStatus")]
    public partial class FxTransactionConfirmationStatus
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Status { get; set; }
    }
}
