using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergToMurexRateError")]
    public partial class BloombergToMurexRateError
    {
        [Key]
        public int BloombergToMurexRateErrorId { get; set; }
        public int? BloombergToMurexRateId { get; set; }
        public int? BloombergReasonCodeId { get; set; }
        public int? BloombergReturnCodeId { get; set; }
        [StringLength(50)]
        public string BloombergColumn { get; set; }
        [StringLength(100)]
        public string BloombergTicker { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }

        [ForeignKey(nameof(BloombergReasonCodeId))]
        [InverseProperty("BloombergToMurexRateErrors")]
        public virtual BloombergReasonCode BloombergReasonCode { get; set; }
        [ForeignKey(nameof(BloombergReturnCodeId))]
        [InverseProperty("BloombergToMurexRateErrors")]
        public virtual BloombergReturnCode BloombergReturnCode { get; set; }
        [ForeignKey(nameof(BloombergToMurexRateId))]
        [InverseProperty("BloombergToMurexRateErrors")]
        public virtual BloombergToMurexRate BloombergToMurexRate { get; set; }
    }
}
