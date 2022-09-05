using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MoneyMarketTicket_Ext")]
    public partial class MoneyMarketTicketExt
    {
        [Key]
        [Column("MMTicketId")]
        public int MmticketId { get; set; }
        [StringLength(50)]
        public string AddBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddOn { get; set; }
        [StringLength(50)]
        public string AuthorizeBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AuthorizeOn { get; set; }
        [StringLength(50)]
        public string VerifyBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VerifyOn { get; set; }
        [Required]
        [StringLength(50)]
        public string ModifyBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyOn { get; set; }
        [StringLength(50)]
        public string DeleteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteOn { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(1)]
        public string DeletionStatus { get; set; }
        [StringLength(2)]
        public string GipStatus { get; set; }
        [StringLength(1024)]
        public string GipDescription { get; set; }
        [StringLength(5)]
        public string TranNo { get; set; }
        [Column("GBaseDump", TypeName = "text")]
        public string GbaseDump { get; set; }

        [ForeignKey(nameof(MmticketId))]
        [InverseProperty(nameof(MoneyMarketTicket.MoneyMarketTicketExt))]
        public virtual MoneyMarketTicket Mmticket { get; set; }
    }
}
