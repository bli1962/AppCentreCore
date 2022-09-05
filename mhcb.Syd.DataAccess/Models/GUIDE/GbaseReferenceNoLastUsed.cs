using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("GBase_ReferenceNo_Last_Used")]
    public partial class GbaseReferenceNoLastUsed
    {
        [Key]
        [StringLength(3)]
        public string DealTypeCode { get; set; }
        [Column(TypeName = "numeric(6, 0)")]
        public decimal LastUsedReferenceCode { get; set; }
    }
}
