using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("FX_TRANSACTION_Confirmation")]
    public partial class FxTransactionConfirmation
    {
        [Key]
        [Column("REF_NO")]
        [StringLength(12)]
        public string RefNo { get; set; }
        [Column("FX_CONFIRM_STATUS_ID")]
        public int? FxConfirmStatusId { get; set; }
        [Required]
        [Column("ADD_BY")]
        [StringLength(8)]
        public string AddBy { get; set; }
        [Column("ADD_ON", TypeName = "smalldatetime")]
        public DateTime AddOn { get; set; }
        [Required]
        [Column("MODIFY_BY")]
        [StringLength(8)]
        public string ModifyBy { get; set; }
        [Column("MODIFY_ON", TypeName = "smalldatetime")]
        public DateTime ModifyOn { get; set; }
        [Column("DELETE_BY")]
        [StringLength(8)]
        public string DeleteBy { get; set; }
        [Column("DELETE_ON", TypeName = "smalldatetime")]
        public DateTime? DeleteOn { get; set; }
    }
}
