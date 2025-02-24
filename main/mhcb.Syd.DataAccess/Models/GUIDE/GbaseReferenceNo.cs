using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GBase_ReferenceNo", Schema = "dbo")]
    public partial class GbaseReferenceNo
    {
        [Key]
        [StringLength(3)]
        public string DealTypeCode { get; set; }
        [Key]
        [Column(TypeName = "numeric(7, 0)")]
        public decimal ReferenceCode { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Expiry { get; set; }
    }
}
