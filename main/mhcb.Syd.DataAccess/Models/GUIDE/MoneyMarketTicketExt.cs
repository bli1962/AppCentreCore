using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("MoneyMarketTicket_Ext", Schema = "dbo")]
    public partial class MoneyMarketTicketExt
    {
        [Key]
        [Column("MMTicketId")]
        public int MmticketId { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AddBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AddOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string AuthorizeBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? AuthorizeOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string VerifyBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? VerifyOn { get; set; }
        [Required]
        [StringLength(50)]
        [Unicode(false)]
        public string ModifyBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? ModifyOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string DeleteBy { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteOn { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string Status { get; set; }
        [StringLength(1)]
        [Unicode(false)]
        public string DeletionStatus { get; set; }
        [StringLength(2)]
        [Unicode(false)]
        public string GipStatus { get; set; }
        [StringLength(1024)]
        [Unicode(false)]
        public string GipDescription { get; set; }
        [StringLength(5)]
        [Unicode(false)]
        public string TranNo { get; set; }
        [Column("GBaseDump", TypeName = "text")]
        public string GbaseDump { get; set; }

        [ForeignKey("MmticketId")]
        [InverseProperty("MoneyMarketTicketExt")]
        public virtual MoneyMarketTicket Mmticket { get; set; }
    }
}
