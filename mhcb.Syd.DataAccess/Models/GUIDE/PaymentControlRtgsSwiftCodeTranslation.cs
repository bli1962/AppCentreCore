using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.GUIDE
{
    [Table("PaymentControl_RtgsSwiftCodeTranslation")]
    public partial class PaymentControlRtgsSwiftCodeTranslation
    {
        [Key]
        public int RtgsSwiftCodeTranslationId { get; set; }
        [StringLength(1024)]
        public string Name { get; set; }
        [StringLength(1024)]
        public string SwiftCode { get; set; }
        [StringLength(1024)]
        public string RtgsBic { get; set; }
        [StringLength(1024)]
        public string Bsb { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
    }
}
