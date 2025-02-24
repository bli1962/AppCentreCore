using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace mhcb.Syd.DataAccess.Models.Rates
{
    [Table("BloombergRate")]
    [Index(nameof(Processed), Name = "NCI_BloombergRate_Processed")]
    public partial class BloombergRate
    {
        public BloombergRate()
        {
            BloombergToMurexRates = new HashSet<BloombergToMurexRate>();
        }

        [Key]
        public int BloombergRateId { get; set; }
        [StringLength(255)]
        public string Securities { get; set; }
        [StringLength(12)]
        public string ErrorCode { get; set; }
        public int? NumFlds { get; set; }
        [Column("PRICING_SOURCE")]
        [StringLength(255)]
        public string PricingSource { get; set; }
        [Column("PX_BID")]
        [StringLength(50)]
        public string PxBid { get; set; }
        [Column("PX_ASK")]
        [StringLength(50)]
        public string PxAsk { get; set; }
        [Column("PX_LAST")]
        [StringLength(50)]
        public string PxLast { get; set; }
        [Column("PX_CLEAN_ASK")]
        [StringLength(50)]
        public string PxCleanAsk { get; set; }
        [Column("PX_CLEAN_BID")]
        [StringLength(50)]
        public string PxCleanBid { get; set; }
        [Column("PX_DIRTY_ASK")]
        [StringLength(50)]
        public string PxDirtyAsk { get; set; }
        [Column("PX_DIRTY_BID")]
        [StringLength(50)]
        public string PxDirtyBid { get; set; }
        [Column("YLD_CNV_ASK")]
        [StringLength(50)]
        public string YldCnvAsk { get; set; }
        [Column("YLD_CNV_BID")]
        [StringLength(50)]
        public string YldCnvBid { get; set; }
        [Column("PX_SETTLE")]
        [StringLength(50)]
        public string PxSettle { get; set; }
        [Column("MATURITY")]
        [StringLength(50)]
        public string Maturity { get; set; }
        public bool? Processed { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedWhen { get; set; }
        [StringLength(50)]
        public string UpdatedWho { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime CreatedWhen { get; set; }
        public int? BloombergRateFileId { get; set; }
        [Column("BVAL_BID_PRICE")]
        [StringLength(50)]
        public string BvalBidPrice { get; set; }
        [Column("BVAL_MID_PRICE")]
        [StringLength(50)]
        public string BvalMidPrice { get; set; }
        [Column("BVAL_ASK_PRICE")]
        [StringLength(50)]
        public string BvalAskPrice { get; set; }
        [Column("BVAL_BID_SCORE")]
        [StringLength(50)]
        public string BvalBidScore { get; set; }
        [Column("BVAL_LAST_UPDATE_DT")]
        [StringLength(50)]
        public string BvalLastUpdateDt { get; set; }

        [ForeignKey(nameof(BloombergRateFileId))]
        [InverseProperty("BloombergRates")]
        public virtual BloombergRateFile BloombergRateFile { get; set; }
        [InverseProperty(nameof(BloombergToMurexRate.BloombergRate))]
        public virtual ICollection<BloombergToMurexRate> BloombergToMurexRates { get; set; }
    }
}
