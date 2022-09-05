using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergToMurexRate")]
    [Index(nameof(Processed), nameof(IsError), nameof(IsCompletedNotified), nameof(IsErrorNotified), Name = "NCI_BloombergToMurexRate_ProcessedIsErrorIsCompletedNotifiedIsErrorNotified")]
    public partial class BloombergToMurexRate
    {
        public BloombergToMurexRate()
        {
            BloombergToMurexRateErrors = new HashSet<BloombergToMurexRateError>();
        }

        [Key]
        public int BloombergToMurexRateId { get; set; }
        public int BloombergToMurexMappingRuleId { get; set; }
        public int BloombergRateId { get; set; }
        [Column("Bid_Pref1")]
        [StringLength(20)]
        public string BidPref1 { get; set; }
        [Column("Bid_Pref2")]
        [StringLength(20)]
        public string BidPref2 { get; set; }
        [Column("Ask_Pref1")]
        [StringLength(20)]
        public string AskPref1 { get; set; }
        [Column("Ask_Pref2")]
        [StringLength(20)]
        public string AskPref2 { get; set; }
        [Column("Murex_Rates_Code")]
        [StringLength(20)]
        public string MurexRatesCode { get; set; }
        [Column("MUREX_LABLE")]
        [StringLength(50)]
        public string MurexLable { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(50)]
        public string Generator { get; set; }
        [StringLength(50)]
        public string Market { get; set; }
        [StringLength(50)]
        public string Maturity { get; set; }
        [Column(TypeName = "decimal(25, 9)")]
        public decimal? Ordinate { get; set; }
        [StringLength(50)]
        public string Index { get; set; }
        [StringLength(50)]
        public string Pillar { get; set; }
        [Column("SWAP_TEMPLATE")]
        [StringLength(50)]
        public string SwapTemplate { get; set; }
        [Column("SWAP_TENOR")]
        [StringLength(50)]
        public string SwapTenor { get; set; }
        [StringLength(50)]
        public string Lable { get; set; }
        [Column("Batch_Number")]
        public int? BatchNumber { get; set; }
        public bool Processed { get; set; }
        public bool IsError { get; set; }
        public bool IsErrorNotified { get; set; }
        public int? FileId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public bool? IsCompletedNotified { get; set; }

        [ForeignKey(nameof(BloombergRateId))]
        [InverseProperty("BloombergToMurexRates")]
        public virtual BloombergRate BloombergRate { get; set; }
        [ForeignKey(nameof(BloombergToMurexMappingRuleId))]
        [InverseProperty("BloombergToMurexRates")]
        public virtual BloombergToMurexMappingRule BloombergToMurexMappingRule { get; set; }
        [InverseProperty(nameof(BloombergToMurexRateError.BloombergToMurexRate))]
        public virtual ICollection<BloombergToMurexRateError> BloombergToMurexRateErrors { get; set; }
    }
}
