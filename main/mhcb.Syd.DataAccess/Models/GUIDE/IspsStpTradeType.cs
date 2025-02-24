using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("Isps_StpTradeType", Schema = "dbo")]
    public partial class IspsStpTradeType
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreateDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? DeleteDate { get; set; }
        [StringLength(128)]
        [Unicode(false)]
        public string DeletedBy { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string TradeTypeName { get; set; }
        [Required]
        [StringLength(128)]
        [Unicode(false)]
        public string LotusNotesFormName { get; set; }
    }
}
