using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergReasonCode")]
    public partial class BloombergReasonCode
    {
        public BloombergReasonCode()
        {
            BloombergToMurexRateErrors = new HashSet<BloombergToMurexRateError>();
        }

        [Key]
        public int BloombergReasonCodeId { get; set; }
        [StringLength(16)]
        public string Code { get; set; }
        [StringLength(255)]
        public string Reason { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [InverseProperty(nameof(BloombergToMurexRateError.BloombergReasonCode))]
        public virtual ICollection<BloombergToMurexRateError> BloombergToMurexRateErrors { get; set; }
    }
}
